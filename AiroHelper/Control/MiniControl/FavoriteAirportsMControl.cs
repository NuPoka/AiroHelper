using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.Entity;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AiroHelper.Control.MiniControl
{
    public partial class FavoriteAirportsMControl : UserControl
    {
        DataBase dataBase = new DataBase();
        public FavoriteAirportsMControl()
        {
            InitializeComponent();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                dataBase.OpenConnection();
                SqlCommand command = new SqlCommand("DELETE FROM Favorite WHERE Favorite_Name='" + labelNameFav.Text + "'", dataBase.GetConnection());
                command.ExecuteNonQuery();
                dataBase.CloseConnection();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Messenge", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataBase.CloseConnection();
            }
        }
        private void BtnMark_Click(object sender, EventArgs e)
        {
            string airportName = labelNameFav.Text;
            string reviewComment = TexBoxReview.Text;

            if (string.IsNullOrWhiteSpace(airportName) || string.IsNullOrWhiteSpace(reviewComment))
            {
                panel2.Visible = true;
                label2.ForeColor = Color.Red;
                label2.Text = "Пожалуйста, заполните поле.";
                TexBoxReview.BorderColor = Color.Red;
                return;
            }
            else
            {
                MessageBox.Show("Спасибо за ваш отзыв.");
            }
            int Userid = 0;
            FillReviewsData(airportName, Userid, reviewComment);
        }
        private void FillReviewsData(string airportName, int Userid, string reviewComment)
        {
            DateTime currentDateTime = DateTime.Now;
            int airopoprtid;

            try
            {
                dataBase.OpenConnection();

                SqlCommand getUserIdCommand = new SqlCommand("SELECT Id_User FROM Users WHERE Airoport_Name = @AirportName", dataBase.GetConnection());
                getUserIdCommand.Parameters.AddWithValue("@AirportName", Userid);

                SqlCommand getAirportIdCommand = new SqlCommand("SELECT Id_Airoport FROM Airoports WHERE Airoport_Name = @AirportName", dataBase.GetConnection());
                getAirportIdCommand.Parameters.AddWithValue("@AirportName", airportName);

                // Выполняем команду и получаем ID аэропорта
                airopoprtid = (int)getAirportIdCommand.ExecuteScalar();

                SqlCommand command = new SqlCommand("INSERT INTO Review (User_Id, Airoport_id, Review_Comment, Review_Date) VALUES (@IdUser, @Airportid, @ReviewComment, @ReviewDate)", dataBase.GetConnection());
                command.Parameters.AddWithValue("@Airportid", airopoprtid);
                command.Parameters.AddWithValue("@IdUser", AplicationContext.UserId);
                command.Parameters.AddWithValue("@ReviewComment", reviewComment);
                command.Parameters.AddWithValue("@ReviewDate", currentDateTime);

                command.ExecuteNonQuery();
                dataBase.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }
    }
}
