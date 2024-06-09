using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AiroHelper.Control.MiniControl
{
    public partial class TransportMControl : UserControl
    {
        public TransportMControl()
        {
            InitializeComponent();
            panelAuto.Height = 45;
            panelTrans.Height = 45;
            panelTaxi.Height = 45;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (panelTrans.Height == 45) panelTrans.Height = 233;
            else panelTrans.Height = 45;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (panelAuto.Height == 45) panelAuto.Height = 234;
            else panelAuto.Height = 45;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (panelTaxi.Height == 45) panelTaxi.Height = 234;
            else panelTaxi.Height = 45;
        }
    }
}
