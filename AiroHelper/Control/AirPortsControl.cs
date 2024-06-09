using AiroHelper.Control;
using AiroHelper.Control.MiniControl;
using Guna.UI2.WinForms;
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
            }
            else
            {
                BtnClaim.ForeColor = Color.White;
                BtnClaim.BackColor = Color.Black;
                BtnClaim.Image = Properties.Resources.favorites_black;
                BtnClaim.Text = "В избранном";
            }
            chenges = !chenges;
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

    }
}
