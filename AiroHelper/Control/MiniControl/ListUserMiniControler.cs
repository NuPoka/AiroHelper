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
    public partial class ListUserMiniControler : UserControl
    {
        DataBase dataBase = new DataBase();
        public ListUserMiniControler()
        {
            InitializeComponent();
        }

        private void pictureBoxDelete_Click(object sender, EventArgs e)
        {
            ReviewBase();
            UserBase();
        }
        private void UserBase()
        {
            dataBase.OpenConnection();
            SqlCommand command = new SqlCommand("DELETE FROM Users WHERE User_Name='" + labelName.Text + "'", dataBase.GetConnection());
            command.ExecuteNonQuery();
            dataBase.CloseConnection();
            this.Hide();

            MessageBox.Show("Вы удалили пользователя");
        }
        private void ReviewBase()
        {
            dataBase.OpenConnection();
            SqlCommand command = new SqlCommand("DELETE FROM Review WHERE User_Id=@userid", dataBase.GetConnection());
            command.Parameters.AddWithValue("@userid", label1.Text);
            command.ExecuteNonQuery();
            dataBase.CloseConnection();
            this.Hide();

        }
        /* private void pictureBoxDelete_Click(object sender, EventArgs e)
         {

             DeleteUserAndReviews();
         }

        private void DeleteUserAndReviews()
         {
             using (SqlConnection connection = dataBase.GetConnection())
             {
                 connection.Open();
                 SqlTransaction transaction = connection.BeginTransaction();

                 try
                 {
                     // Удаление записей из таблицы Review
                     SqlCommand reviewCommand = new SqlCommand("DELETE FROM Review WHERE User_Id=@userid", connection, transaction);
                     reviewCommand.Parameters.AddWithValue("@userid", label1.Text);
                     reviewCommand.ExecuteNonQuery();

                     // Удаление записи из таблицы Users
                     SqlCommand userCommand = new SqlCommand("DELETE FROM Users WHERE User_Name=@username", connection, transaction);
                     userCommand.Parameters.AddWithValue("@username", labelName.Text);
                     userCommand.ExecuteNonQuery();

                     // Завершение транзакции
                     transaction.Commit();

                     MessageBox.Show("Вы удалили пользователя и его отзывы");
                 }
                 catch (Exception ex)
                 {
                     // Откат транзакции в случае ошибки
                     transaction.Rollback();
                     MessageBox.Show("Произошла ошибка: " + ex.Message);
                 }
             }

             this.Hide();*/
    }
}

