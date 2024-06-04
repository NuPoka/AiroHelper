using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AiroHelper
{
    public partial class ListAirportMiniControler : UserControl
    {
        DataBase dataBase = new DataBase();
        public ListAirportMiniControler()
        {
            InitializeComponent();
        }

        private void pictureBoxDelete_Click(object sender, EventArgs e)
        {
            dataBase.OpenConnection();
            SqlCommand command = new SqlCommand("DELETE FROM Airoports WHERE Airoport_Name'" + labelName.Text + "'", dataBase.GetConnection());
            command.ExecuteNonQuery();
            dataBase.CloseConnection();
            this.Hide();

            MessageBox.Show("Вы удалили аэропорт");
        }
    }
}
