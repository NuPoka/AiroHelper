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
    public partial class AirportListMiniControl : UserControl
    {
        DataBase dataBase = new DataBase();

        public AirportListMiniControl(Image airportImage, string airportDescription, string aidi)
        {
            InitializeComponent();
            PictureBoxListAirport.Image = airportImage;
            labelDesc.Text = airportDescription;
            labelNameM.Text = aidi;
        }
        private void BtnAirport_Click(object sender, EventArgs e)
        {
            try
            {
                AirPortsControl airPorts;
                int airopoprtid;
                FillAirportData(out airPorts, out airopoprtid);
                FillFacilitis(airPorts, airopoprtid);
                FillSchema(airPorts, airopoprtid);
                airPorts.Dock = DockStyle.Fill;
                AiroportsInfo.Instance.pnlNif.Controls["AirPortsControl"].BringToFront();

                AiroportsInfo.Instance.BackButton.Visible = true;
                AiroportsInfo.Instance.pnlSearch.Location = new Point(66, 11);

            }
            catch
            {
                dataBase.CloseConnection();
            }
        }

        private void FillFacilitis(AirPortsControl airPorts, int airopoprtid)
        {
            dataBase.OpenConnection();
            using (SqlCommand commandFacility = new SqlCommand("SELECT * FROM [Facility] WHERE Airoport_Id=@Airoport_Id", dataBase.GetConnection()))
            {

                commandFacility.Parameters.AddWithValue("Airoport_Id", airopoprtid);
                SqlDataReader readerFacility = commandFacility.ExecuteReader();

                while (readerFacility.Read())
                {
                    //информация
                    switch (readerFacility.GetInt32(0))
                    {
                        case 1:
                            airPorts.labelPriemBagaj.Text = readerFacility[2].ToString();
                            break;
                        case 2:
                            airPorts.labelRoziskBagaj.Text = readerFacility[2].ToString();
                            break;
                        case 3:
                            airPorts.labelShop.Text = readerFacility[2].ToString();
                            break;
                        case 4:
                            airPorts.labelCofe.Text = readerFacility[2].ToString();
                            break;
                        case 5:
                            airPorts.labelBronirovanie.Text = readerFacility[2].ToString();
                            break;
                        case 6:
                            airPorts.labelBiletCSO.Text = readerFacility[2].ToString();
                            break;
                        case 7:
                            airPorts.labelFastTrack.Text = readerFacility[2].ToString();
                            break;
                        case 8:
                            airPorts.labelBuisness.Text = readerFacility[2].ToString();
                            break;
                        case 9:
                            airPorts.labelVIP.Text = readerFacility[2].ToString();
                            break;
                        case 10:
                            airPorts.labelSPA.Text = readerFacility[2].ToString();
                            break;
                        case 11:
                            airPorts.labelVIPClass.Text = readerFacility[2].ToString();
                            break;
                        case 12:
                            airPorts.labelBuisnessClass.Text = readerFacility[2].ToString();
                            break;
                        case 13:
                            airPorts.labelBankomat.Text = readerFacility[2].ToString();
                            break;
                        case 14:
                            airPorts.labelValuta.Text = readerFacility[2].ToString();
                            break;
                        case 15:
                            airPorts.labelMedpunkt.Text = readerFacility[2].ToString();
                            break;
                    }
                }
                dataBase.CloseConnection();
            }
        }

        private void FillSchema(AirPortsControl airPorts, int airopoprtid)
        {
            dataBase.OpenConnection();
            using (SqlCommand commandFacility = new SqlCommand("SELECT * FROM [Schema] WHERE Airoports_id=@Airoport_Id", dataBase.GetConnection()))
            {

                commandFacility.Parameters.AddWithValue("Airoport_Id", airopoprtid);
                SqlDataReader readerFacility = commandFacility.ExecuteReader();

                if (readerFacility.Read())
                {
                    //информация
                    byte[] photo = (byte[])(readerFacility["Airoport_Schema1"]);
                    using (var memory = new MemoryStream(photo))
                    airPorts.pictureBox1.Image = Image.FromStream(memory);

                    byte[] photo2 = (byte[])(readerFacility["Airoport_Schema2"]);
                    using (var memory = new MemoryStream(photo2))
                        airPorts.pictureBox2.Image = Image.FromStream(memory);

                    byte[] photo3 = (byte[])(readerFacility["Airoport_Schema3"]);
                    using (var memory = new MemoryStream(photo3))
                        airPorts.pictureBox3.Image = Image.FromStream(memory);

                    byte[] photo4 = (byte[])(readerFacility["Airoport_Schema4"]);
                    using (var memory = new MemoryStream(photo4))
                        airPorts.pictureBox4.Image = Image.FromStream(memory);
                }
                dataBase.CloseConnection();
            }
        }

        private void FillAirportData(out AirPortsControl airPorts, out int airopoprtid)
        {
            dataBase.OpenConnection();

            using (SqlCommand command = new SqlCommand("SELECT * FROM [Airoports] WHERE Airoport_Name=@Airoport_Name", dataBase.GetConnection()))
            {
                command.Parameters.AddWithValue("Airoport_Name", labelNameM.Text);
                var reader = command.ExecuteReader();
                airPorts = new AirPortsControl();
                if (AiroportsInfo.Instance.PnlLableUser.Visible == true)
                {
                    airPorts.BtnClaim.Visible = true;
                }

                AiroportsInfo.Instance.pnlNif.Controls.Add(airPorts);

                if (AiroportsInfo.Instance.PnlLableUser.Visible == true)
                {
                    airPorts.BtnClaim.Visible = true;
                }
                airPorts.guna2PictureBox1.Image = this.PictureBoxListAirport.Image;


                airopoprtid = 0;
                while (reader.Read())
                {
                    airopoprtid = reader.GetInt32(0);
                    //информация
                    airPorts.labelId.Text = reader[0].ToString(); // номер
                    airPorts.labelName.Text = reader[1].ToString(); //название
                    airPorts.labelCode.Text += reader[2].ToString(); // код
                    airPorts.labelCity.Text += reader[3].ToString(); //город
                    airPorts.labelAdress.Text += reader[4].ToString(); //адрес
                    airPorts.labelCompany.Text += reader[8].ToString(); //компания
                    airPorts.labelDesc.Text = reader[10].ToString(); //описание


                }
                reader.Close();
                dataBase.CloseConnection();
            }
        }
    }
}