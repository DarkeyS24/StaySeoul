using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StaySeoul.Classes.Views
{
    public partial class Terms : UserControl
    {
        public Terms()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        public void SetText(string text)
        {
            termsTxt.Text = text;
        }
    }
}
