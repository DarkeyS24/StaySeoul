using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using StaySeoul.Classes.Models;

namespace StaySeoul.Classes.Views
{
    public partial class EditListingForm : Form
    {
        private ManagementFrame form;
        private int number;
        private int employeeId;

        private List<ItemAttraction> itemAttractionList = new List<ItemAttraction>();
        private List<ItemAmenity> itemAmenityListnew = new List<ItemAmenity>();
        private Item item = new Item();
        private List<Amenity> amenityListnew = new List<Amenity>();

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
            if (this.number == 0)
            {
                if (e.TabPageIndex == 0)
                {
                    e.Cancel = true;
                }
                else if (e.TabPageIndex == 1)
                {
                    e.Cancel = true;
                }
                else if (e.TabPageIndex == 2)
                {
                    e.Cancel = true;
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
        private bool ThirdTabFieldsVerification()
        {
            int num = 0;
            foreach (DataRow row in AttractionDistanceTable.Rows)
            {
                if (!string.IsNullOrEmpty(row[2].ToString()))
                {
                    num++;
                }
            }

            if (num < 2)
            {
                MessageBox.Show("Distance from at least two attractions is necessary");
                return false;
            }
            else
            {
                return true ;
            }
        }

        public void SetAddFields()
        {
            MySqlConnection con = new Connection().GetConnection();
            con.Open();
            string query = "Select Name from itemtypes";
            MySqlCommand cmd = new MySqlCommand(query, con);
            var reader = cmd.ExecuteReader();
            while (reader.Read()) 
            {
                serviceTypeCb.Items.Add(reader.GetString(0));
            }
            serviceTypeCb.SelectedItem = serviceTypeCb.Items[0];

            reader.Close();

            query = "Select Name from areas";
            cmd = new MySqlCommand(query, con);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                areaCb.Items.Add(reader.GetString(0));
            }
            areaCb.SelectedItem = areaCb.Items[0];

            reader.Close();

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

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (this.number == 0)
            {
                if (managementTab.SelectedIndex == 0)
                {
                    if (FirstTabFieldsVerification())
                    {
                        item.ItemTypeId = serviceTypeCb.SelectedIndex + 1;
                        item.Title = titleTxt.Text;
                        item.UserId = employeeId;
                        item.Capacity = (int)(capaciyNumber.Value);
                        item.NumberOfBeds = (int)(bedsNumber.Value);
                        item.NumberOfBedrooms = (int)(bedroomsNumber.Value);
                        item.NumberOfBathrooms = (int)(bathroomsNumber.Value);
                        item.AreaId = areaCb.SelectedIndex + 1;
                        item.ApproximateAddress = approximateAddressTxt.Text;
                        item.ExactAddress = exactAddressTxt.Text;
                        item.Description = descTxt.Text;
                        item.HostRules = rulesTxt.Text;
                        item.MinimumNights = (int)(minNumber.Value);
                        item.MaximumNights = (int)(maxNumber.Value);
                        managementTab.SelectedIndex = 1;
                    }
                }else if(managementTab.SelectedIndex == 1)
                {
                    if (SecondTabFieldsVerification())
                    {
                        SetAttractionTable();
                        SetAmenityList();
                        closeBtn.Visible = false;
                        nextBtn.Visible = false;
                        cancelBtn.Visible = false;
                        saveBtn.Visible = true;
                        managementTab.SelectedIndex = 2;
                    }
                }
            }
        }
        private void SetAttractionTable()
        {
            MySqlConnection con = new Connection().GetConnection();
            con.Open();
            string query = "Select att.Name, a.Name from attractions att inner join areas a on att.AreaID = a.ID Where att.AreaID = @area";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@area", item.AreaId);
            var resposta = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            if (resposta.Read())
            {
                dt.Load(resposta);
                AttractionDistanceTable.Columns.Add("Duration On Foot", "Duration On Foot");
                AttractionDistanceTable.Columns.Add("Duration By Car", "Duration By Car");
                AttractionDistanceTable.DataSource = dt;
            }
        }
        private void saveBtn_MouseClick(object sender, MouseEventArgs e)
        {
            if (ThirdTabFieldsVerification())
            {
                ItemAttraction itemAttraction = new ItemAttraction();
                int num = 1;
                foreach (DataRow row in AttractionDistanceTable.Rows)
                {
                    if (!string.IsNullOrEmpty(row[2].ToString()))
                    {
                        itemAttraction.AttractionId = num;
                        itemAttraction.ItemId = item.Id;
                        itemAttraction.Distance = (double)(row[2]);
                        itemAttraction.DurationOnFoot = (BigInteger)(row[3]);
                        itemAttraction.DurationByCar = (BigInteger)(row[4]);
                        itemAttractionList.Add(itemAttraction);
                    }
                    num++;
                }
                SaveOnDataBase();
            }
        }

        private bool pressedBtn = false;
        private Point cursorPoint;
        private Point formPoint;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            pressedBtn = true;
            formPoint = this.Location;
            cursorPoint = Cursor.Position;
        }
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            pressedBtn = false;
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (pressedBtn == true)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(cursorPoint));
                this.Location = Point.Add(formPoint, new Size(dif));
            }
        }
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveOnDataBase()
        {
            MySqlConnection con = new Connection().GetConnection();
            con.Open();
            string query = "Insert into items values(default, @guid, @userId, @itemTypeId, @areaId, @title, @capacity, @beds, @bedrooms, @bathrooms, @exact, @approximate, @desc, @rules, @min, @ max)";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@guid", item.GetGuid());
            cmd.Parameters.AddWithValue("@userId", item.UserId);
            cmd.Parameters.AddWithValue("@itemTypeId", item.ItemTypeId);
            cmd.Parameters.AddWithValue("@areaId", item.AreaId);
            cmd.Parameters.AddWithValue("@title", item.Title);
            cmd.Parameters.AddWithValue("@capacity", item.Capacity);
            cmd.Parameters.AddWithValue("@beds", item.NumberOfBeds);
            cmd.Parameters.AddWithValue("@bedrooms", item.NumberOfBedrooms);
            cmd.Parameters.AddWithValue("@bathrooms", item.NumberOfBathrooms);
            cmd.Parameters.AddWithValue("@exact", item.ExactAddress);
            cmd.Parameters.AddWithValue("@approximate", item.ApproximateAddress);
            cmd.Parameters.AddWithValue("@desc", item.Description);
            cmd.Parameters.AddWithValue("@rules", item.HostRules);
            cmd.Parameters.AddWithValue("@min", item.MinimumNights);
            cmd.Parameters.AddWithValue("@max", item.MaximumNights);
            cmd.ExecuteNonQuery();

            foreach (var amenity in amenityList)
            {
                query = "Insert into amenities values(default, @guid, @name, @iconName)";
                cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@guid", amenity.GetGuid());
                cmd.Parameters.AddWithValue("@name", amenity.Name);
                cmd.Parameters.AddWithValue("@iconName", "");
                cmd.ExecuteNonQuery();
            }

            foreach (var itemAttraction in itemAttractionList)
            {
                query = "Insert into amenities values(default, @guid, @itemId, @attractionId, @distance, @onFoot, @byCar)";
                cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@guid", itemAttraction.GetGuid());
                cmd.Parameters.AddWithValue("@itemId", itemAttraction.ItemId);
                cmd.Parameters.AddWithValue("@attractionId", itemAttraction.AttractionId);
                cmd.Parameters.AddWithValue("@distance", itemAttraction.Distance);
                cmd.Parameters.AddWithValue("@onFoot", itemAttraction.DurationOnFoot);
                cmd.Parameters.AddWithValue("@byCar", itemAttraction.DurationByCar);
                cmd.ExecuteNonQuery();
            }

            foreach (var itemAmenity in itemAmenityList)
            {
                query = "Insert into amenities values(default, @guid, @itemId, @amenityId)";
                cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@guid", itemAmenity.GetGuid());
                cmd.Parameters.AddWithValue("@itemId", itemAmenity.ItemId);
                cmd.Parameters.AddWithValue("@amenityId", itemAmenity.AmenityId);
                cmd.ExecuteNonQuery();
            }

            con.Close();
            MessageBox.Show("data successfully recorded");
        }
        private void SetAmenityList()
        {
            foreach (CheckBox box in checkList.Items)
            {
                if (box.Checked == true)
                {
                    Amenity amenity = new Amenity();
                    amenity.Name = box.Text;
                    ItemAmenity itemAmenity = new ItemAmenity();
                    itemAmenity.AmenityId = box.ImageIndex;
                    if (GetItemId() == 0)
                    {
                        itemAmenity.ItemId = 1;
                    }
                    else
                    {
                        itemAmenity.ItemId = GetItemId();
                    }
                    itemAmenityList.Add(itemAmenity);
                    amenityList.Add(amenity);
                }
            }
        }
        private int GetItemId()
        {
            MySqlConnection con = new Connection().GetConnection();
            con.Open();
            string query = "Select count(*) from items";
            MySqlCommand cmd = new MySqlCommand(query, con);
            var resposta = cmd.ExecuteReader();
            if (resposta.Read())
            {
                return resposta.GetInt32(0);
            }
            else
            {
                return -1;
            }
        }
    }
}
