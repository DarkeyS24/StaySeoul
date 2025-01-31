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
        public StaySeoul()
        {
            string conteudo = new GerenciadorArquivos().LerArquivo("UserLog");
            if (string.IsNullOrEmpty(conteudo))
            {
                InitializeComponent();
            }
            else
            {
                InitializeComponent();
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
                loginBtn_Click(this, new EventArgs());
            }
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
            if(string.IsNullOrEmpty(employeeTxt.Text) && string.IsNullOrEmpty(userTxt.Text))
            {
                MessageBox.Show("Some fields are empty");
            }
            else if (string.IsNullOrEmpty(employeeTxt.Text))
            {
                MySqlConnection con = new Connection().GetConnection();
                con.Open();
                string query = @"Select * from Users where Username = @user and Password = @password";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@user", userTxt.Text);
                cmd.Parameters.AddWithValue("@password", pswdTxt.Text);
                var resposta = cmd.ExecuteReader();
                
                if (resposta.Read())
                {
                    user.Id = resposta.GetInt32(0);
                    user.GUID = resposta.GetString(1);
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

                    ManagementFrame man = new ManagementFrame(this);
                    man.DisableTabs(1);
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
                string query = @"Select * from Users where Username = @user and Password = @password";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@user", employeeTxt.Text);
                cmd.Parameters.AddWithValue("@password", pswdTxt.Text);
                var resposta = cmd.ExecuteReader();
                User user = new User();
                if (resposta.Read())
                {
                    user.Id = resposta.GetInt32(0);
                    user.GUID = resposta.GetString(1);
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
                    man.DisableTabs(0);
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
            userLog.UserName = user.UserName;
            userLog.Password = user.Password;
            if (UserType == 0)
            {
                userLog.UserType = "Employee";
            }
            else
            {
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
    }
}
