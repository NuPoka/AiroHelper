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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

            Bitmap originalImage = new Bitmap(@"D:\AiroHelper\AiroHelper\Resources\gps.png");
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

                // Очищаем все контролы в pnlNif перед добавлением нового AirPortsControl
                AiroportsInfo.Instance.pnlNif.Controls.Clear();

                // Получаем имя аэропорта из свойства Tag маркера
                string airportName = item.Tag.ToString();

                dataBase.OpenConnection();
                SqlCommand command = new SqlCommand("SELECT * FROM [Airoports] WHERE Airoport_Name='" + airportName + "'", dataBase.GetConnection());
                SqlDataReader reader = command.ExecuteReader();

                AirPortsControl airPorts = new AirPortsControl();

                if (AiroportsInfo.Instance.PnlLableUser.Visible == true) { airPorts.BtnClaim.Visible = true; }
                AiroportsInfo.Instance.pnlNif.Controls.Add(airPorts);
                if (AiroportsInfo.Instance.PnlLableUser.Visible == true) { airPorts.BtnClaim.Visible = true; }

                while (reader.Read())
                {
                    //информация
                    airPorts.labelName.Text = reader[1].ToString();
                    airPorts.labelCode.Text = reader[2].ToString();
                    airPorts.labelCity.Text += reader[3].ToString();
                    airPorts.labelAdress.Text += reader[4].ToString();
                    airPorts.labelCompany.Text += reader[8].ToString();
                    airPorts.labelDesc.Text += reader[10].ToString();
                    airPorts.lableRating.Text = reader[11].ToString();
                    byte[] Photo = (byte[])(reader[9]);
                    MemoryStream memoryStream = new MemoryStream(Photo);
                    airPorts.guna2PictureBox1.Image = Image.FromStream(memoryStream);
                }

                airPorts.Dock = DockStyle.Fill;
                AiroportsInfo.Instance.pnlNif.Controls["AirPortsControl"].BringToFront();

                AiroportsInfo.Instance.BackButton.Visible = true;
                AiroportsInfo.Instance.pnlSearch.Location = new Point(66, 11);
                reader.Close();
                dataBase.CloseConnection();

                this.Close();
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