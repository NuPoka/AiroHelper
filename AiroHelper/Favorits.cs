using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AiroHelper
{
    public partial class Favorits : Form
    {
        public Favorits()
        {
            InitializeComponent();
        }

        private void BtnUser_Click(object sender, EventArgs e)
        {
            UserPanel userPanel = new UserPanel();
            userPanel.Show();
            this.Hide();
        }
    }
}
