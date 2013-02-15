using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RSSReader
{
    public partial class RSSReader : Form
    {
        public RSSReader()
        {
            InitializeComponent();
        }


        private void regViewBtn_Click(object sender, EventArgs e)
        {
            ListView newView = new ListView();
            newView.Show();
            this.Hide();
        }
    }
}
