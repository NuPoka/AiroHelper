using AiroHelper.Control;
using AiroHelper.Control.MiniControl;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.Entity;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AiroHelper
{
    public partial class AirPortsControl : UserControl
    {
       
        DataBase dataBase = new DataBase();
        public AirPortsControl()
        {
            InitializeComponent();
        }
        bool chenges = false;
        private void BtnClaim_Click(object sender, EventArgs e)
        {
            if (chenges)
            {
                BtnClaim.ForeColor = Color.Black;
                BtnClaim.BackColor = SystemColors.Control;
                BtnClaim.Image = Properties.Resources.favorites_white;
                BtnClaim.Text = "В избранное";
                DeleteFavAir();
            }
            else
            {
                BtnClaim.ForeColor = Color.White;
                BtnClaim.BackColor = Color.Black;
                BtnClaim.Image = Properties.Resources.favorites_black;
                BtnClaim.Text = "В избранном";
                AddFavAir();
            }
            chenges = !chenges;
        }
        private void AddFavAir()
        {
            try
            {
                MemoryStream memoryStream = new MemoryStream();
                guna2PictureBox1.Image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);
                byte[] Photo = new byte[memoryStream.Length];

                memoryStream.Position = 0;
                memoryStream.Read(Photo, 0, Photo.Length);
                dataBase.OpenConnection();
                SqlCommand command = new SqlCommand("INSERT INTO Favorite (User_id, Favorite_Name, Favorite_Image, Favorite_Code) VALUES (@Userid, @AirName, @photo, @AirCode)", dataBase.GetConnection());
                command.Parameters.AddWithValue("@photo", Photo);
                command.Parameters.AddWithValue("@AirName", labelName.Text);
                command.Parameters.AddWithValue("@AirCode", labelCode.Text);
                command.Parameters.AddWithValue("@Userid", AplicationContext.UserId);
                command.ExecuteNonQuery();
                dataBase.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Messenge", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataBase.CloseConnection();
            }
        }
        private void DeleteFavAir()
        {
            try
            {
                dataBase.OpenConnection();
                SqlCommand command = new SqlCommand("DELETE FROM Favorite WHERE Favorite_Name=@AirName", dataBase.GetConnection());
                command.Parameters.AddWithValue("@AirName", labelName.Text);
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

        private void BtnRoad_Click(object sender, EventArgs e)
        {
            RoadControl road = new RoadControl();
            road.Location = new Point(0, 0);
            road.Size = new Size(957, 936);
            this.Controls.Add(road);
            road.BringToFront();
            PrintListAirport(road); // передаем выбранный идентификатор аэропорта
        }

        private void PrintListAirport(RoadControl road)
        {
            dataBase.OpenConnection();
            SqlCommand command = new SqlCommand("SELECT * FROM [Transport] WHERE Airoport_Id='" + this.labelId.Text + "'", dataBase.GetConnection());
            SqlDataReader reader = command.ExecuteReader();
            road.flowLayoutPanel1.Controls.Clear();
            while (reader.Read())
            {
                TransportMControl roadControl = new TransportMControl();
                roadControl.LabelName.Text = reader["Airoport_Name"].ToString();
                roadControl.LabelPublicTrans.Text = reader["Transport_Public"].ToString();
                roadControl.LabelAutoTrans.Text = reader["Transport_Auto"].ToString();
                roadControl.LabelTaxiTrans.Text = reader["Transport_Taxi"].ToString();
                road.flowLayoutPanel1.Controls.Add(roadControl);
            }
            reader.Close();
            dataBase.CloseConnection();
        }

        private void AirPortsControl_Load(object sender, EventArgs e)
        {
            dataBase.OpenConnection();
            SqlCommand command = new SqlCommand("SELECT * FROM [Review] WHERE Airoport_id='" + this.labelId.Text + "'", dataBase.GetConnection());
            SqlDataReader reader = command.ExecuteReader();
            flowLayoutPanelReview.Controls.Clear();
            while (reader.Read())
            {
                ReviewMControl review = new ReviewMControl();
                review.labelReviewUserName.Text = reader["User_Id"].ToString();
                review.labelId.Text = reader["Airoport_id"].ToString();
                review.labelRiviewComment.Text = reader["Review_Comment"].ToString();
                flowLayoutPanelReview.Controls.Add(review);
            }
            reader.Close();
            dataBase.CloseConnection();
        }
    }
}
 