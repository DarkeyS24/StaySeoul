using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Numerics;
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
        private int itemId;

        private List<ItemAttraction> itemAttractionList = new List<ItemAttraction>();
        private List<ItemAttraction> itemAttractionListCopy = new List<ItemAttraction>();
        private List<ItemAmenity> itemAmenityList = new List<ItemAmenity>();
        private Item item = new Item();

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
            foreach (var box in checkList.Items)
            {
                if (checkList.GetItemChecked(checkList.Items.IndexOf(box)))
                {
                    num++;
                }
            }

            if (num > 0)
            {
                return true;
            }
            else{
                MessageBox.Show("Select at least three options");
                return false;
            }
        }
        private bool ThirdTabFieldsVerification()
        {
            int num = 0;
            foreach (DataGridViewRow row in AttractionDistanceTable.Rows)
            {
                if (!row.IsNewRow && !string.IsNullOrEmpty(row.Cells[2].ToString()))
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
        public void SetEditFields(string title, int itemId)
        {
            this.itemId = itemId;

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

            reader.Close();

            query = "Select * from items where userID = @id and Title = @title";
            cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", employeeId);
            cmd.Parameters.AddWithValue("@title", title);
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                itemId = reader.GetInt32(0);
                serviceTypeCb.SelectedIndex = reader.GetInt32(3) - 1;
                areaCb.SelectedIndex = reader.GetInt32(4);
                titleTxt.Text = reader.GetString(5);
                capaciyNumber.Value = reader.GetInt32(6);
                bedsNumber.Value = reader.GetInt32(7);
                bedroomsNumber.Value = reader.GetInt32(8);
                bathroomsNumber.Value = reader.GetInt32(9);
                exactAddressTxt.Text = reader.GetString(10);
                approximateAddressTxt.Text = reader.GetString(11);
                descTxt.Text = reader.GetString(12);
                rulesTxt.Text = reader.GetString(13);
                minNumber.Value = reader.GetInt32(14);
                maxNumber.Value = reader.GetInt32(15);
            }

            reader.Close();

            List<ItemAmenity> itemAmenities = new List<ItemAmenity>();
            query = "Select * from itemamenities where itemID = @item";
            cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("item", itemId);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int value = reader.GetInt32(3);
                checkList.SetItemChecked(value - 1, true);
                ItemAmenity item =  new ItemAmenity();
                item.Id = reader.GetInt64(0);
                item.SetGuid(reader.GetGuid(1));
                item.ItemId = reader.GetInt64(2);
                item.AmenityId = reader.GetInt64(3);
                itemAmenityList.Add(item);
            }

            reader.Close();

            query = "Select att.Name as Attraction, a.Name as Area, ia.Distance, ia.DurationOnFoot as DurationOnFoot, ia.DurationByCar as DurationByCar from itemattractions ia inner join attractions att on ia.AttractionID = att.ID inner join areas a on att.AreaID = a.ID and ia.ItemID = @item";
            cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@item", itemId);
            reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            if (dt != null)
            {
                AttractionDistanceTable.DataSource = dt;
            }

            reader.Close();

            query = "Select * from itemattractions ia inner join attractions att on ia.AttractionID = att.ID inner join areas a on att.AreaID = a.ID and ia.ItemID = @item";
            cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@item", itemId);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ItemAttraction item = new ItemAttraction();
                item.Id = reader.GetInt64(0);
                item.SetGuid(reader.GetGuid(1));
                item.ItemId = reader.GetInt64(2);
                item.AttractionId = reader.GetInt64(3);
                item.Distance = reader.GetDouble(4);
                item.DurationOnFoot = reader.GetInt64(5);
                item.DurationByCar = reader.GetInt64(6);
                itemAttractionList.Add(item);
                itemAttractionListCopy.Add(item);
            }

            con.Close();
        }
        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (this.number == 0)
            {
                if (managementTab.SelectedIndex == 0)
                {
                    if (FirstTabFieldsVerification() && isTitleRegisteredVerification())
                    {
                        do
                        {
                            item.SetGuid(Guid.NewGuid());
                        } while (isGuidRegisteredVerification() == false);
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
                        this.number = 1;
                        managementTab.SelectedIndex = 1;
                        this.number = 0;
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
                        this.number = 1;
                        managementTab.SelectedIndex = 2;
                        this.number = 0;
                    }
                }
            }
        }
        private void SetAttractionTable()
        {
            MySqlConnection con = new Connection().GetConnection();
            con.Open();
            string query = "Select att.Name as Attraction, a.Name as Area from attractions att inner join areas a on att.AreaID = a.ID Where att.AreaID = @area";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@area", item.AreaId);
            var resposta = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            if (resposta.Read())
            {
                dt.Load(resposta);
                AttractionDistanceTable.DataSource = dt;
                AttractionDistanceTable.Columns.Add("Distance", "Distance");
                AttractionDistanceTable.Columns.Add("Duration On Foot", "Duration On Foot");
                AttractionDistanceTable.Columns.Add("Duration By Car", "Duration By Car");
            }
        }
        private void saveBtn_MouseClick(object sender, MouseEventArgs e)
        {
            if (ThirdTabFieldsVerification())
            {
                ItemAttraction itemAttraction = new ItemAttraction();
                int num = 1;
                foreach (DataGridViewRow row in AttractionDistanceTable.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        if (row.Cells[0].Value != null && !string.IsNullOrEmpty(row.Cells[0].Value.ToString()) &&
                            row.Cells[1].Value != null && !string.IsNullOrEmpty(row.Cells[1].Value.ToString()) &&
                            row.Cells[2].Value != null && !string.IsNullOrEmpty(row.Cells[2].Value.ToString()))
                        {
                            itemAttraction.AttractionId = num;
                            itemAttraction.ItemId = item.Id;

                            itemAttraction.Distance = Double.Parse(row.Cells[0].Value.ToString());
                            itemAttraction.DurationOnFoot = BigInteger.Parse(row.Cells[1].Value.ToString());
                            itemAttraction.DurationByCar = BigInteger.Parse(row.Cells[2].Value.ToString());

                            itemAttractionList.Add(itemAttraction);
                        }
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
            string query = "Insert into items values(default, @guid, @userId, @itemTypeId, @areaId, @title, @capacity, @beds, @bedrooms, @bathrooms, @exact, @approximate, @desc, @rules, @min, @max)";
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

            foreach (var itemAttraction in itemAttractionList)
            {
                query = "Insert into itemattractions values(default, @guid, @itemId, @attractionId, @distance, @onFoot, @byCar)";
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
                query = "Insert into itemamenities values(default, @guid, @itemId, @amenityId)";
                cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@guid", itemAmenity.GetGuid());
                cmd.Parameters.AddWithValue("@itemId", itemAmenity.ItemId);
                cmd.Parameters.AddWithValue("@amenityId", itemAmenity.AmenityId);
                cmd.ExecuteNonQuery();
            }

            con.Close();
            MessageBox.Show("data successfully recorded");
        }
        private void UpdateOnDataBase()
        {
            MySqlConnection con = new Connection().GetConnection();
            con.Open();
            string query = "Update items set GUID = @guid, UserID = @userId, ItemTypeID = @itemTypeId, AreaID = @areaId, Title = @title, Capacity = @capacity, NumberOfBeds = @beds, NumberOfBedrooms = @bedrooms, NumberOfBathrooms = @bathrooms, ExactAddress = @exact, ApproximateAddress = @approximate, Description = @desc, HostRules = @rules, MinimumNights = @min, MaximumNights = @max where ID = @itemId";
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
            cmd.Parameters.AddWithValue("@itemId", itemId);
            cmd.ExecuteNonQuery();

            foreach (var itemAttraction in itemAttractionList)
            {
                query = "Update itemattractions set GUID = @guid, ItemID = @itemId, AttractionID = @attractionId, Distance = @distance, DurationOnFoot = @onFoot, DurationByCar = @byCar where ID = @itemAttractionId";
                cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@guid", itemAttraction.GetGuid());
                cmd.Parameters.AddWithValue("@itemId", itemAttraction.ItemId);
                cmd.Parameters.AddWithValue("@attractionId", itemAttraction.AttractionId);
                cmd.Parameters.AddWithValue("@distance", itemAttraction.Distance);
                cmd.Parameters.AddWithValue("@onFoot", itemAttraction.DurationOnFoot);
                cmd.Parameters.AddWithValue("@byCar", itemAttraction.DurationByCar);
                cmd.Parameters.AddWithValue("@itemAttractionId", itemAttraction.Id);
                cmd.ExecuteNonQuery();
            }

            foreach (var itemAmenity in itemAmenityList)
            {
                query = "Update itemamenities set GUID = @guid, ItemID = @itemId, AmenityID = @amenityId where ID = @itemAmenityId";
                cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@guid", itemAmenity.GetGuid());
                cmd.Parameters.AddWithValue("@itemId", itemAmenity.ItemId);
                cmd.Parameters.AddWithValue("@amenityId", itemAmenity.AmenityId);
                cmd.Parameters.AddWithValue("@itemAmenityId", itemAmenity.Id);
                var value = cmd.ExecuteNonQuery();
                if (value == 0)
                {
                    query = "Insert into itemamenities values(default, @guid, @itemId, @amenityId)";
                    cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@guid", itemAmenity.GetGuid());
                    cmd.Parameters.AddWithValue("@itemId", itemAmenity.ItemId);
                    cmd.Parameters.AddWithValue("@amenityId", itemAmenity.AmenityId);
                    cmd.ExecuteNonQuery();
                }
            }

            con.Close();
            MessageBox.Show("data successfully updated");
        }
        private void SetAmenityList()
        {
            itemAmenityList.Clear();
            foreach (object box in checkList.Items)
            {
                if (checkList.GetItemChecked(checkList.Items.IndexOf(box)))
                {
                    
                    ItemAmenity itemAmenity = new ItemAmenity();
                    itemAmenity.AmenityId = checkList.Items.IndexOf(box);
                    if (GetItemId() == 0)
                    {
                        itemAmenity.ItemId = 1;
                    }
                    else
                    {
                        itemAmenity.ItemId = GetItemId();
                    }
                    itemAmenityList.Add(itemAmenity);
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
        private bool isTitleRegisteredVerification()
        {
            MySqlConnection con = new Connection().GetConnection();
            con.Open();
            string query = "Select * from items where Title = @title";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@title", item.Title);
            var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show("The title is already in use");
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool isGuidRegisteredVerification()
        {
            MySqlConnection con = new Connection().GetConnection();
            con.Open();
            string query = "Select * from items where GUID = @guid";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@guid", item.GetGuid());
            var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void closeBtn_Click(object sender, EventArgs e)
        {
            if (isTitleRegisteredVerification())
            {
                if (managementTab.SelectedIndex == 0)
                {
                    if (FirstTabFieldsVerification())
                    {
                        SaveData();
                        UpdateOnDataBase();
                        this.Close();
                    }
                }
                else if (managementTab.SelectedIndex == 1)
                {
                    if (SecondTabFieldsVerification())
                    {
                        SaveData();
                        UpdateOnDataBase();
                        this.Close();
                    }
                }
                else
                {
                    if (ThirdTabFieldsVerification())
                    {
                        SaveData();
                        UpdateOnDataBase();
                        this.Close();
                    }
                }
            }
        }
        private void SaveData()
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

            itemAmenityList.Clear();
            foreach (object box in checkList.Items)
            {
                if (checkList.GetItemChecked(checkList.Items.IndexOf(box)) == true)
                {
                    ItemAmenity itemAmenity = new ItemAmenity();
                    itemAmenity.AmenityId = checkList.Items.IndexOf(box) + 1;
                    itemAmenity.ItemId = this.itemId;
                    itemAmenityList.Add(itemAmenity);
                }
            }

            ItemAttraction itemAttraction = new ItemAttraction();
            int num = 1;
            itemAttractionList.Clear();
            foreach (DataGridViewRow row in AttractionDistanceTable.Rows)
            {
                if (!row.IsNewRow)
                {
                    if (row.Cells[2].Value != null && !string.IsNullOrEmpty(row.Cells[2].Value.ToString()))
                    {
                        itemAttraction.Id = itemAttractionListCopy[num - 1].Id;
                        itemAttraction.AttractionId = num;
                        itemAttraction.ItemId = this.itemId;

                        itemAttraction.Distance = Double.Parse(row.Cells[2].Value.ToString());
                        itemAttraction.DurationOnFoot = BigInteger.Parse(row.Cells[3].Value.ToString());
                        itemAttraction.DurationByCar = BigInteger.Parse(row.Cells[4].Value.ToString());

                        itemAttractionList.Add(itemAttraction);
                    }
                }
                num++;
            }
        }
    }
}