using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using StaySeoul.Classes.Applications;
using StaySeoul.Classes.Models;
using StaySeoul.Classes.Views;
using StaySeoul.Resources;
using static System.Windows.Forms.LinkLabel;

namespace StaySeoul
{
    public partial class StaySeoul : Form
    {
        private User user = new User();
        private int number = 0;
        public StaySeoul()
        {
            InitializeComponent();
            loginBtn_Click(this, new EventArgs());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool pressBtn = false;
        private Point formPoint;
        private Point cursorPoint;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            pressBtn = true;
            formPoint = this.Location;
            cursorPoint = Cursor.Position;
        }
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            pressBtn = false;
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (pressBtn == true)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(cursorPoint));
                this.Location = Point.Add(formPoint, new Size(dif));
            }
        }
        private void showPswdCb_CheckedChanged(object sender, EventArgs e)
        {
            if (showPswdCb.Checked == true)
            {
                pswdTxt.PasswordChar = '\0';
            }
            else
            {
                pswdTxt.PasswordChar = '*';
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (number == 0)
            {
                string conteudo = new GerenciadorArquivos().LerArquivo("UserLog");
                if (!string.IsNullOrEmpty(conteudo))
                {
                    UserLog newUser = JsonConvert.DeserializeObject<UserLog>(conteudo);
                    if (newUser.UserType.Equals("Employee"))
                    {
                        employeeTxt.Text = newUser.UserName;
                        pswdTxt.Text = newUser.Password;
                    }
                    else
                    {
                        userTxt.Text = newUser.UserName;
                        pswdTxt.Text = newUser.Password;
                    }
                }
            }
            
                if (string.IsNullOrEmpty(employeeTxt.Text) && string.IsNullOrEmpty(userTxt.Text))
                {
                    MessageBox.Show("Some fields are empty");
                }
                else if (string.IsNullOrEmpty(employeeTxt.Text))
                {
                    MySqlConnection con = new Connection().GetConnection();
                    con.Open();
                    string query = @"Select * from Users where Username = @user and Password = @password and UserTypeID = @type";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@user", userTxt.Text);
                    cmd.Parameters.AddWithValue("@password", pswdTxt.Text);
                    cmd.Parameters.AddWithValue("@type", 2);
                    var resposta = cmd.ExecuteReader();

                    if (resposta.Read())
                    {
                        user.Id = resposta.GetInt32(0);
                        user.GUID = resposta.GetGuid(1);
                        user.UserTypeId = resposta.GetInt32(2);
                        user.UserName = resposta.GetString(3);
                        user.Password = resposta.GetString(4);
                        user.FullName = resposta.GetString(5);
                        user.Gender = resposta.GetInt32(6);
                        user.BirthDate = resposta.GetDateTime(7);
                        user.FamilyCount = resposta.GetInt32(8);

                        if (signedCb.Checked == true)
                        {
                            SetActualUser(1);
                        }

                        number = 0;
                        ManagementFrame man = new ManagementFrame(this);
                        man.SetNumber(1);
                        man.setData(GetTravelerData(), GetUserData((int)(user.Id)));
                        man.Show();
                    }
                    else
                    {
                        MessageBox.Show("User not found");
                    }
                }
                else
                {
                    MySqlConnection con = new Connection().GetConnection();
                    con.Open();
                    string query = @"Select * from Users where Username = @user and Password = @password and UserTypeID = @type";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@user", employeeTxt.Text);
                    cmd.Parameters.AddWithValue("@password", pswdTxt.Text);
                    cmd.Parameters.AddWithValue("@type", 1);
                    var resposta = cmd.ExecuteReader();
                    User user = new User();
                    if (resposta.Read())
                    {
                        user.Id = resposta.GetInt32(0);
                        user.GUID = resposta.GetGuid(1);
                        user.UserTypeId = resposta.GetInt32(2);
                        user.UserName = resposta.GetString(3);
                        user.Password = resposta.GetString(4);
                        user.FullName = resposta.GetString(5);
                        user.Gender = resposta.GetInt32(6);
                        user.BirthDate = resposta.GetDateTime(7);
                        user.FamilyCount = resposta.GetInt32(8);

                        if (signedCb.Checked == true)
                        {
                            SetActualUser(0);
                        }

                        ManagementFrame man = new ManagementFrame(this);
                        man.SetNumber(0);
                        man.setData(GetTravelerData(), GetUserData((int)(user.Id)));
                        man.Show();
                    }
                    else
                    {
                        MessageBox.Show("Employee not found");
                    }
                }
        }

        private void SetActualUser(int UserType)
        {
            UserLog userLog = new UserLog();
            userLog.Password = pswdTxt.Text;
            if (UserType == 0)
            {
                userLog.UserName = employeeTxt.Text;
                userLog.UserType = "Employee";
            }
            else
            {
                userLog.UserName = userTxt.Text;
                userLog.UserType = "User";
            }
            
            string jsonLink = JsonConvert.SerializeObject(userLog);
            new GerenciadorArquivos().EscreverArquivo("UserLog", jsonLink);
       
        }

        private void createAccountLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateAccountFrame createAccountFrame = new CreateAccountFrame();
            createAccountFrame.Show();
        }
    
        public DataTable GetTravelerData()
        {
            MySqlConnection con = new Connection().GetConnection();
            con.Open();
            string query = "Select i.Title, i.Capacity, it.Name, a.Name from items i join itemtypes it on i.ItemTypeID = it.ID join areas a on i.AreaID = a.ID";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            con.Close();
            return dt;
        }

        public DataTable GetUserData(int id)
        {
            MySqlConnection con = new Connection().GetConnection();
            con.Open();
            string query = "Select i.Title, i.Capacity, it.Name, a.Name from items i inner join itemtypes it on i.ItemTypeID = it.ID inner join areas a on i.AreaID = a.ID inner join users u on i.UserID = u.ID and u.ID = @id";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", id);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            con.Close();
            return dt;
        }

        public void SetTextBox(string userName, string pswd)
        {
            number = 1;
            userTxt.Text = userName;
            employeeTxt.Text = "";
            pswdTxt.Text = pswd;
            loginBtn_Click(this, new EventArgs());
        }
    }
}
