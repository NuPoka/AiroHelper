using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace AiroHelper
{
    public partial class UserPanel : Form
    {
        DataBase dataBase = new DataBase();
        public UserPanel()
        {
            InitializeComponent();
        }
        
        private void UserPanel_Load(object sender, EventArgs e)
        {
            labelNameU.Text = DataBank.LoginUser;
            dataBase.OpenConnection();
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM [Users]", dataBase.GetConnection());
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
              labelMailU.Text = reader["User_Email"].ToString();
            }
            reader.Close();
            dataBase.CloseConnection();
        }

        private void ExitImages_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var nameing = TextBoxNameU.Text;
            var family = TextBoxFamilyU.Text;
            if (string.IsNullOrWhiteSpace(nameing)) TextBoxNameU.BorderColor = Color.Red;
            if (string.IsNullOrWhiteSpace(family)) TextBoxFamilyU.BorderColor = Color.Red;
            MessageBox.Show("Успешно сохранено.");
        }
    }
}
