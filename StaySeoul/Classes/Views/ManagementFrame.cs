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

namespace StaySeoul.Classes.Views
{
    public partial class ManagementFrame : Form
    {
        private StaySeoul form;
        private int num;
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
            this.Close();
            form.Show();
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
    }
}
