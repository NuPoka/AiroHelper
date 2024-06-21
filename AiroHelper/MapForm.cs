using GMap.NET.MapProviders;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;
using GMap.NET.WindowsForms;
using GMap.NET;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Data.Common;
using System.Data.OleDb;

namespace AiroHelper
{
    public partial class MapForm : Form
    {
        DataBase dataBase = new DataBase();
        bool sidebarExpand;
        private bool isFormOpen = false;
        public MapForm()
        {
            InitializeComponent();
        }
        private void gMapControl_Load(object sender, EventArgs e)
        {
            gMapControl.MapProvider = GoogleMapProvider.Instance;
            gMapControl.CacheLocation = Application.StartupPath + @"\maps\OSMCache";
            GMaps.Instance.Mode = AccessMode.ServerAndCache;
            gMapControl.CanDragMap = true;
            gMapControl.DragButton = MouseButtons.Left;
            gMapControl.MouseWheelZoomEnabled = true;
            gMapControl.MouseWheelZoomType = MouseWheelZoomType.MousePositionWithoutCenter;
            gMapControl.MinZoom = 0;
            gMapControl.MaxZoom = 30;
            gMapControl.Zoom = 3;
            gMapControl.Position = new PointLatLng(61.520513, 87.212321);
            gMapControl.ShowCenter = false;
            Createmarker();
        }

        public class AirMarker : GMarkerGoogle
        {
            public AirMarker(PointLatLng p, Bitmap bitmap) : base(p, bitmap)
            {

            }
            public AirMap AirMapInfo { get; set; }
            public Bitmap image { get; set; }
        }
        private DataBase _db;
        private void Createmarker()
        {
            GMapOverlay ListAir = new GMapOverlay("AirPort");

            Bitmap originalImage = new Bitmap(@"C:\Users\ilya-\Source\Repos\AiroHelper\AiroHelper\Resources\gps.png");
            int newWidth = (int)(originalImage.Width * 0.5);
            int newHeight = (int)(originalImage.Height * 0.5);
            Bitmap resizedImage = new Bitmap(originalImage, new Size(newWidth, newHeight));
            var Airepos = new AirMapRepos();
            var AirPhlot = Airepos.GetAir();
            foreach (var coordinat in AirPhlot)
            {
                var marker = new AirMarker(new PointLatLng((double)coordinat.Airoport_Location_x, (double)coordinat.Airoport_Location_y), resizedImage);
                marker.ToolTip = new GMapRoundedToolTip(marker);
                marker.ToolTipText = coordinat.Airoport_Name; // Установка имени аэропорта как текста подсказки
                marker.Tag = coordinat.Airoport_Name; // Установка имени аэропорта в качестве значения Tag
                marker.AirMapInfo = coordinat;
                ListAir.Markers.Add(marker); // Добавление маркера в оверлей
            }
            gMapControl.Overlays.Add(ListAir);
            gMapControl.OnMarkerClick += gMapControl_OnMarkerClick;
        }
        private void gMapControl_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            if (!isFormOpen)
            {
                isFormOpen = true;
                try
                {
                    string airoportName = item.Tag.ToString();
                    AirPortsControl airPorts;
                    int airopoprtid;
                    FillAirportData(out airPorts, out airopoprtid, airoportName);
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
        private void FillAirportData(out AirPortsControl airPorts, out int airopoprtid, string airoportName)
        {
            dataBase.OpenConnection();

            using (SqlCommand command = new SqlCommand("SELECT * FROM [Airoports] WHERE Airoport_Name=@Airoport_Name", dataBase.GetConnection()))
            {
                command.Parameters.AddWithValue("Airoport_Name", airoportName);
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

                    if (!reader.IsDBNull(9))
                    {
                        try
                        {
                            byte[] photo = (byte[])(reader[9]);
                            using (MemoryStream memoryStream = new MemoryStream(photo))
                            {
                                airPorts.guna2PictureBox1.Image = Image.FromStream(memoryStream);
                            }
                        }
                        catch (Exception ex)
                        {
                            // Логирование ошибки (если необходимо)
                            Console.WriteLine("Ошибка при загрузке изображения: " + ex.Message);
                        }
                    }
                }
                    reader.Close();
                    dataBase.CloseConnection();
            }
        }
            private void SlideBarTimer_Tick(object sender, EventArgs e)
            {
            if (sidebarExpand)
            {
                panelMenu.Width -= 15;
                if (panelMenu.Width == panelMenu.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    SlideBarTimer.Stop();
                }
            }
            else
            {
                panelMenu.Width += 15;
                if (panelMenu.Width == panelMenu.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    SlideBarTimer.Stop();
                }
            }
        }
        private void menuButton_Click(object sender, EventArgs e)
        {
            SlideBarTimer.Start();
        }
        private void ExitImages_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}