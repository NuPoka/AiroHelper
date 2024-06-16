using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AiroHelper.Control.MiniControl
{
    public partial class ReviewMControl : UserControl
    {
        DataBase dataBase = new DataBase();
        public ReviewMControl()
        {
            InitializeComponent();
        }

        private void ReviewMControl_Load(object sender, EventArgs e)
        {
        }
    }
}
