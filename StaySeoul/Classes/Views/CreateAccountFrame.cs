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
using StaySeoul.Classes.Models;

namespace StaySeoul.Classes.Views
{
    public partial class CreateAccountFrame : Form
    {
        private User user = new User();
        public CreateAccountFrame()
        {
            InitializeComponent();
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void saveLoginBtn_Click(object sender, EventArgs e)
        {
            if (termCb.Checked == true)
            {
                if (string.IsNullOrEmpty(userTxt.Text))
                {
                    MessageBox.Show("Username field is empty");
                }else if (string.IsNullOrEmpty(fullNameTxt.Text))
                {
                    MessageBox.Show("Full name field is empty");
                }else if (maleRb.Checked == false && femaleRb.Checked == false)
                {
                    MessageBox.Show("Select a gender");
                }else if(familyNumber.Value < 0)
                {
                    MessageBox.Show("Invalid number on family members field");
                }else if (dataPicker.Value > DateTime.Now.Date)
                {
                    MessageBox.Show("Invalid birthday");
                }else if (pswdTxt.Text.Length < 5)
                {
                    MessageBox.Show("Password need to contain at least 5 characters");
                }else if (rePswdTxt.Text.Length < 5)
                {
                    MessageBox.Show("The passwords doesn't match");
                }else if (!pswdTxt.Text.Equals(rePswdTxt.Text))
                {
                    MessageBox.Show("The passwords doesn't match");
                }
                else
                {
                    user.SetGuid(Guid.NewGuid());
                    user.UserTypeId = 2;
                    user.UserName = userTxt.Text;
                    user.FullName = fullNameTxt.Text;
                    if (maleRb.Checked == true)
                    {
                        user.Gender = 0;
                    }
                    else
                    {
                        user.Gender = 1;
                    }
                    user.FamilyCount = (int)(familyNumber.Value);
                    user.BirthDate = dataPicker.Value;
                    user.Password = pswdTxt.Text;

                    if (GuidVerification())
                    {
                        user.SetGuid(Guid.NewGuid());
                    }else if (UsernameVerification())
                    {
                        MessageBox.Show("Username is already in use");
                    }
                    else
                    {
                        int rowsAffected = SaveUser();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User saved successfully");
                            StaySeoul frame = new StaySeoul();
                            frame.SetTextBox(user.UserName, user.Password);
                        }
                        else
                        {
                            MessageBox.Show("User not created");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Accept the terms and conditions");
            }
        }
        private bool GuidVerification()
        {
            MySqlConnection con = new Connection().GetConnection();
            con.Open();
            string query = "Select * from users where GUID = @Guid";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Guid", user.GetGuid());
            var resposta = cmd.ExecuteReader();
            if (resposta.Read())
            {
                con.Close();
                return true;
            }
            else
            {
                con.Close();
                return false;
            }
        }
        private bool UsernameVerification()
        {
            MySqlConnection con = new Connection().GetConnection();
            con.Open();
            string query = "Select * from users where Username = @user";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@user", user.UserName);
            var resposta = cmd.ExecuteReader();
            if (resposta.Read())
            {
                con.Close();
                return true;
            }
            else
            {
                con.Close();
                return false;
            }
        }
        private int SaveUser()
        {
            MySqlConnection con = new Connection().GetConnection();
            con.Open();
            string query = "Insert into users values(default, @Guid, @type, @username, @pswd, @fullname, @gender, @birthdate, @familyCount);";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Guid", user.GetGuid());
            cmd.Parameters.AddWithValue("@type", user.UserTypeId);
            cmd.Parameters.AddWithValue("@username", user.UserName);
            cmd.Parameters.AddWithValue("@pswd", user.Password);
            cmd.Parameters.AddWithValue("@fullname", user.FullName);
            cmd.Parameters.AddWithValue("@gender", user.Gender);
            cmd.Parameters.AddWithValue("@birthdate", user.BirthDate);
            cmd.Parameters.AddWithValue("@familyCount", user.FamilyCount);
            return cmd.ExecuteNonQuery();
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
    }
}
