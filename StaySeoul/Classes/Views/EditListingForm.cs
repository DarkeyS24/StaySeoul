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
    public partial class EditListingForm : Form
    {
        private ManagementFrame form;
        private int number;
        private int employeeId;
        public EditListingForm(ManagementFrame form, int employeeId)
        {
            InitializeComponent();
            this.form = form;
            this.employeeId = employeeId;
        }

        public void setTabControl(int number)
        {
            this.number = number;   

            if (number == 0)
            {
                closeBtn.Visible = false;
                nextBtn.Visible = true;
                cancelBtn.Visible = true;
                saveBtn.Visible = false;
            }
            else
            {
                closeBtn.Visible = true;
                nextBtn.Visible = false;
                cancelBtn.Visible = false;
                saveBtn.Visible = false;
            }
        }

        private void managementTab_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (this.number == 1)
            {
                if (managementTab.SelectedIndex == 2)
                {
                
                    closeBtn.Visible = false;
                    nextBtn.Visible = true;
                    cancelBtn.Visible = false;
                    saveBtn.Visible = true;
                }
            }
        }

        private bool FirstTabFieldsVerification()
        {
            if (string.IsNullOrEmpty(titleTxt.Text))
            {
                MessageBox.Show("Title field is empty");
                return false;
            }
            else if (capaciyNumber.Value <= 0)
            {
                MessageBox.Show("invalid value on capacity field");
                return false;
            }
            else if (bedsNumber.Value <= 0)
            {
                MessageBox.Show("invalid value on beds field");
                return false;
            }
            else if (bedroomsNumber.Value <= 0)
            {
                MessageBox.Show("invalid value on bedrooms field");
                return false;
            }
            else if (bathroomsNumber.Value <= 0)
            {
                MessageBox.Show("invalid value on bathrooms field");
                return false;
            }
            else if (string.IsNullOrEmpty(approximateAddressTxt.Text))
            {
                MessageBox.Show("Approximate address field is empty");
                return false;
            }
            else if (string.IsNullOrEmpty(exactAddressTxt.Text))
            {
                MessageBox.Show("Exact address field is empty");
                return false;
            }
            else if (string.IsNullOrEmpty(descTxt.Text))
            {
                MessageBox.Show("Description field is empty");
                return false;
            }
            else if (string.IsNullOrEmpty(rulesTxt.Text))
            {
                MessageBox.Show("Host rules field is empty");
                return false;
            }
            else if (minNumber.Value <= 0)
            {
                MessageBox.Show("invalid value on minnimum nights field");
                return false;
            }
            else if (maxNumber.Value <= 0)
            {
                MessageBox.Show("invalid value on maximum nights field");
                return false;
            }
            else if (minNumber.Value >= maxNumber.Value)
            {
                MessageBox.Show("minimum nights value can't be higher than maximum nights value");
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool SecondTabFieldsVerification()
        {
            int num = 0;
            foreach (CheckBox box in checkList.Items)
            {
                if (box.Checked == true)
                {
                    num++;
                }
            }

            if (num > 0)
            {
                return true;
            }
            else{
                return false;
            }
        }

        //private bool ThirdTabFieldsVerification()
        //{

        //}

        public void SetAddFields()
        {
            MySqlConnection con = new Connection().GetConnection();
            con.Open();
            string query = "Select Name from servicetypes";
            MySqlCommand cmd = new MySqlCommand(query, con);
            var reader = cmd.ExecuteReader();
            while (reader.Read()) 
            {
                serviceTypeCb.Items.Add(reader.GetString(0));
            }

            query = "Select Name from amenities";
            cmd = new MySqlCommand(query, con);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                checkList.Items.Add(reader.GetString(0));
            }
            con.Close();
        }

        public void SetEditFields()
        {
            MySqlConnection con = new Connection().GetConnection();
            con.Open();

            //Set Combo Box
            string query = "Select Name from servicetypes";
            MySqlCommand cmd = new MySqlCommand(query, con);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                serviceTypeCb.Items.Add(reader.GetString(0));
            }

            query = "Select * from items where UserID = @id";
            cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", this.employeeId);
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                serviceTypeCb.Items.Add(reader.GetString(0));
            }

            query = "Select Name from amenities";
            cmd = new MySqlCommand(query, con);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                checkList.Items.Add(reader.GetString(0));
            }
            con.Close();
        }
    }
}
