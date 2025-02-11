using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using StaySeoul.Classes.Models;

namespace StaySeoul.Classes.Views
{
    public partial class ManagementFrame : Form
    {
        private StaySeoul form;
        private int num;
        private int employeeId;
        private int travelerItemsNum;
        private int employeeItemsNum;

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
            }else if (num == 0)
            {
                if (e.TabPageIndex == 1)
                {
                    itemLbl.Text = employeeItemsNum + " items found";
                }
                else
                {
                    itemLbl.Text = travelerItemsNum + " items found";
                }
            }
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            form.Show();
        }

        public void setData(DataTable travTable, DataTable userTable, int employeeId)
        {
            this.employeeId = employeeId;

            travelerTable.DataSource = travTable;
            itemLbl.Text = travTable.Rows.Count + " items found";

            employeeTable.DataSource = userTable;
            travelerItemsNum = travTable.Rows.Count;
            employeeItemsNum = userTable.Rows.Count;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            EditListingForm add = new EditListingForm(this, employeeId);
            add.setTabControl(0);
            add.SetAddFields();
            add.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow row;
            string title = "";
            if (employeeTable.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Select a row");
            }
            else
            {
                row = employeeTable.CurrentRow;
                title = row.Cells[0].Value.ToString();
                EditListingForm form = new EditListingForm(this, employeeId);
                form.setTabControl(1);
                int itemId = GetItemId(title);
                form.SetEditFields(title, itemId);
                form.Show();
            }
        }

        private int GetItemId(string title)
        {
            MySqlConnection con = new Connection().GetConnection();
            con.Open();
            string query = "Select id from items where Title = @title";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@title", title);
            var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return reader.GetInt32(0);
            }
            else
            {
                return -1;
            }
        }
    }
}