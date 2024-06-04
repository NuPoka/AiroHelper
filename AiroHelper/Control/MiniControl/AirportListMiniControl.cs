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
    public partial class AirportListMiniControl : UserControl
    {
        DataBase dataBase = new DataBase();
        public AirportListMiniControl(Image airportImage, string airportDescription)
        {
            InitializeComponent();
            PictureBoxListAirport.Image = airportImage;
            labelDesc.Text = airportDescription;
        }

        private void BtnAirport_Click(object sender, EventArgs e)
        {
            dataBase.OpenConnection();
            SqlCommand command = new SqlCommand("SELECT * FROM [Airoports] WHERE Airoport_Description=@Description", dataBase.GetConnection());
            command.Parameters.AddWithValue("@Description", this.labelDesc.Text);
            SqlDataReader reader = command.ExecuteReader();

            // Логгирование для диагностики
            Console.WriteLine("Executing query: SELECT * FROM [Airoports] WHERE Airoport_Description='" + this.labelDesc.Text + "'");

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    AirPortsControl airportControl = new AirPortsControl();

                    if (AiroportsInfo.Instance.PnlLableUser.Visible == true)
                    {
                        airportControl.BtnClaim.Visible = true;
                    }

                    airportControl.guna2PictureBox1.Image = this.PictureBoxListAirport.Image;

                    // Логгирование данных, которые читаются из базы данных
                    Console.WriteLine("Airoport_Name: " + reader["Airoport_Name"].ToString());
                    Console.WriteLine("Airoport_Code: " + reader["Airoport_Code"].ToString());
                    Console.WriteLine("Airoport_City: " + reader["Airoport_City"].ToString());
                    Console.WriteLine("Airoport_Аddress: " + reader["Airoport_Аddress"].ToString());
                    Console.WriteLine("Airoport_Company: " + reader["Airoport_Company"].ToString());
                    Console.WriteLine("Airoport_Description: " + reader["Airoport_Description"].ToString());

                    airportControl.labelName.Text = reader["Airoport_Name"].ToString(); // название
                    airportControl.labelCode.Text = reader["Airoport_Code"].ToString(); // код
                    airportControl.labelCity.Text = reader["Airoport_City"].ToString(); // город
                    airportControl.labelAdress.Text = reader["Airoport_Аddress"].ToString(); // адрес
                                                                                            //airportControl.labelLocation.Text = reader["Airoport_LocationX"].ToString(); // локация x
                                                                                            //airportControl.labelLocation2.Text = reader["Airoport_LocationY"].ToString(); // локация y
                    airportControl.labelCompany.Text = reader["Airoport_Company"].ToString(); // компания
                                                                                              //airportControl.labelStar.Text = reader["Airoport_Rating"].ToString(); // рейтинг
                    airportControl.labelDesc.Text = reader["Airoport_Description"].ToString(); // описание

                    string imagePath = reader["Airoport_Map_Image"].ToString();
                    if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                    {
                        airportControl.guna2PictureBox1.Image = Image.FromFile(imagePath);
                    }

                    AiroportsInfo.Instance.pnlNif.Controls.Add(airportControl);
                }

                AiroportsInfo.Instance.pnlNif.Controls["AirPortsControl"].BringToFront();
                AiroportsInfo.Instance.BackButton.Visible = true;
                AiroportsInfo.Instance.pnlSearch.Location = new Point(97, 10);
            }
            else
            {
                Console.WriteLine("No rows found.");
            }

            reader.Close();
            dataBase.CloseConnection();
        }

    }
}
