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

namespace AiroHelper
{
    public partial class MapForm : Form
    {
        DataBase dataBase = new DataBase();
        bool sidebarExpand;
        public MapForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
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
                marker.AirMapInfo = coordinat;
                ListAir.Markers.Add(marker); // Добавление маркера в оверлей
            }
            gMapControl.Overlays.Add(ListAir);
            gMapControl.OnMarkerClick += gMapControl_OnMarkerClick;
        }
        private void gMapControl_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            dataBase.OpenConnection();
            SqlCommand command = new SqlCommand("SELECT * FROM [Airoports] WHERE Airoport_Name='" + item.ToolTipText + "'", dataBase.GetConnection());
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                AirPortsControl AirportControl = new AirPortsControl();
                if (AiroportsInfo.Instance.PnlLableUser.Visible) { AirportControl.BtnClaim.Visible = true; }

                AirportControl.labelName.Text = reader["Airoport_Name"].ToString();
                AirportControl.labelCode.Text = reader["Airoport_Code"].ToString();
                AirportControl.labelCity.Text = reader["Airoport_City"].ToString();
                AirportControl.labelAdress.Text = reader["Airoport_Address"].ToString();
                AirportControl.labelCompany.Text = reader["Airoport_Company"].ToString();
                AirportControl.labelDesc.Text = reader["Airoport_Description"].ToString();

                AirportControl.Dock = DockStyle.Fill;

                AiroportsInfo.Instance.pnlNif.Controls.Clear();
                AiroportsInfo.Instance.pnlNif.Controls.Add(AirportControl);

                if (AiroportsInfo.Instance.PnlLableUser.Visible) { AirportControl.BtnClaim.Visible = true; }

                AiroportsInfo.Instance.BackButton.Visible = true;
                AiroportsInfo.Instance.pnlSearch.Location = new Point(92, 12);
            }

            reader.Close();
            dataBase.CloseConnection();
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