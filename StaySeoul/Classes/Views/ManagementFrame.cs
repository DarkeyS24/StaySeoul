using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Org.BouncyCastle.Math.EC;
using StaySeoul.Classes.Models;

namespace StaySeoul.Classes.Views
{
    public partial class ManagementFrame : Form
    {
        private StaySeoul form;
        private int num;
        private List<Item> itemList = new List<Item>();
        public ManagementFrame(StaySeoul form)
        {
            InitializeComponent();
            this.form = form;
        }

        private bool pressBtn = false;
        private Point formPoint;
        private Point cursorPoint;

        public void SetNumber(int num)
        {
            this.num = num;
        }

        private void panel1_MouseDown_1(object sender, MouseEventArgs e)
        {
            pressBtn = true;
            formPoint = this.Location;
            cursorPoint = Cursor.Position;
        }

        private void panel1_MouseUp_1(object sender, MouseEventArgs e)
        {
            pressBtn = false;
        }

        private void panel1_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (pressBtn == true)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(cursorPoint));
                this.Location = Point.Add(formPoint, new Size(dif));
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void travelerControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (num == 1)
            {
                if (e.TabPageIndex == 1)
                {
                    e.Cancel = true;
                }
            }
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            form.Show();
        }

        public void setData(DataTable table)
        {
            //foreach(DataRow row in table.Rows)
            //{
            //    //Item item = new Item();

            //    //item.Id = (int)(row["ID"]);  
            //    //item.GUID = row["GUID"].ToString();
            //    //item.UserId = (int)(row["UserID"]);
            //    //item.ItemTypeId = (int)(row["ItemTypeID"]);
            //    //item.AreaId = (int)(row["AreaID"]);
            //    //item.Title = row["Title"].ToString();
            //    //item.Capacity = (int)(row["Capacity"]);
            //    //item.NumberOfBeds = (int)(row["NumberOfBeds"]);
            //    //item.NumberOfBedrooms = (int)(row["NumberOfBedrooms"]);
            //    //item.NumberOfBathrooms = (int)(row["NumberOfBathrooms"]);
            //    //item.ExactAddress = row["ExactAddress"].ToString();
            //    //item.ApproximateAddress = row["ApproximateAddress"].ToString();
            //    //item.Description = row["Description"].ToString();
            //    //item.HostRules = row["HostRules"].ToString();
            //    //item.MinimumNights = (int)(row["MinimumNights"]);
            //    //item.MaximumNights = (int)(row["MaximumNights"]);

            //    //itemList.Add(item);
            //}

            DataTable filteredTable = table.Copy();

            foreach (DataColumn col in table.Columns)
            {
                if (col.ColumnName != "ID" && col.ColumnName != "ID1" && col.ColumnName != "ID2" && col.ColumnName != "Title" && col.ColumnName != "Capacity" && col.ColumnName != "Name" && col.ColumnName != "Name1")
                {
                    filteredTable.Columns.Remove(col.ColumnName);
                }
            }
            travelerTable.DataSource = filteredTable;

        }
    }
}
