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
            DeleteSchema();
            DeleteAirport();
            this.Hide();
        }
        private void DeleteSchema()
        {
            try
            {
                dataBase.OpenConnection();

                // Удаление записей из таблицы Schema, которые ссылаются на аэропорт
                SqlCommand deleteSchemaCommand = new SqlCommand("DELETE FROM [Schema] WHERE Airoports_id ='" + this.labelIDMC.Text + "'", dataBase.GetConnection());
                deleteSchemaCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось удалить схему: " + ex.Message);
            }
        }
        private void DeleteAirport()
        {
            try
            {
                dataBase.OpenConnection();
                // Удаление аэропорта
                SqlCommand deleteAirportCommand = new SqlCommand("DELETE FROM [Airoports] WHERE Airoport_Name ='" + this.labelName.Text + "'", dataBase.GetConnection());
                deleteAirportCommand.ExecuteNonQuery();

                dataBase.CloseConnection();

                MessageBox.Show("Аэропорт был успешно удален");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось удалить аэропорт: " + ex.Message);
            }
        }
    }
}
