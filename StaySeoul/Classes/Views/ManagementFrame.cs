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
        public ManagementFrame(StaySeoul form)
        {
            InitializeComponent();
            this.form = form;
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

        public void DisableTabs(int num)
        {
            if (num == 0)
            {
                travelerControl.TabPages[1].Enabled = true;
                travelerControl.TabPages[0].Enabled = true;
            }
            else
            {
                travelerControl.TabPages[1].Enabled = false;
                travelerControl.TabPages[0].Enabled = true;
            }
        }
    }
}
