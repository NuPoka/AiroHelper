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
    public partial class LogRegControl : UserControl
    {
        public LogRegControl()
        {
            InitializeComponent();
        }

        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BtnLog_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Show();
            this.Hide();
        }

        private void BtnReg_Click(object sender, EventArgs e)
        {
            RegIn regIn = new RegIn();
            regIn.Show();
            this.Hide();
        }
    }
}
