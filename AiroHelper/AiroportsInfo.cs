using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace AiroHelper
{
    public partial class AiroportsInfo : Form
    {
        DataBase dataBase = new DataBase();
        
        public AiroportsInfo()
        {
            InitializeComponent();
            _obj = this;
        }
        static AiroportsInfo _obj;
        public static AiroportsInfo Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new AiroportsInfo();
                }
                return _obj;
            }
        }
        public Panel PnlUser
        {
            get { return PanelUser; }
            set { PanelUser = value; }
        }
        public Panel pnlSearch
        {
            get { return PanelSeach; }
            set { PanelSeach = value; }
        }
        public Panel pnlAdmin
        {
            get { return AdminPanel; }
            set { AdminPanel = value; }
        }
        public Label PnlLableUserText
        {
            get { return labelNameUser; }
            set { labelNameUser = value; }
        }
        public Panel PnlLableUser
        {
            get { return UserPanel; }
            set { UserPanel = value; }
        }
        public Guna.UI2.WinForms.Guna2Panel pnlNif
        {
            get { return PanelInfo; }
            set { PanelInfo = value; }
        }
        private void PerformSearch()
        {
            string query = TextBoxSearch.Text;
            FlowLayoutPanelForListAirportControler userListControl;

            if (PanelInfo.Controls.Count == 0 || !(PanelInfo.Controls[0] is FlowLayoutPanelForListAirportControler))
            {
                userListControl = new FlowLayoutPanelForListAirportControler();
                PanelInfo.Controls.Add(userListControl);
            }
            else
            {
                userListControl = (FlowLayoutPanelForListAirportControler)PanelInfo.Controls[0];
            }

            userListControl.flowLayoutPanelAirPort.Controls.Clear();

            dataBase.OpenConnection();
            string sqlQuery = "SELECT Airoport_Name, Airoport_City, Airoport_Description, Airoport_Map_Image FROM Airoports WHERE Airoport_City LIKE @query OR Airoport_Name LIKE @query";
            using (SqlCommand command = new SqlCommand(sqlQuery, dataBase.GetConnection()))
            {
                command.Parameters.AddWithValue("@query", "%" + query + "%");
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    bool hasResults = false;

                    while (reader.Read())
                    {
                        hasResults = true;
                        byte[] photo = (byte[])(reader["Airoport_Map_Image"]);
                        string airportDescription = reader["Airoport_Description"].ToString();
                        string aidi = reader["Airoport_Name"].ToString();
                        Image airportImage = null;
                        if (photo != null && photo.Length > 0)
                        {
                            using (MemoryStream memoryStream = new MemoryStream(photo))
                            {
                                airportImage = Image.FromStream(memoryStream);
                            }
                        }
                        var resultControl = new AirportListMiniControl(airportImage, airportDescription, aidi);
                        userListControl.flowLayoutPanelAirPort.Controls.Add(resultControl);
                    }

                    if (!hasResults)
                    {
                        MessageBox.Show("Аэропорт или город не найден.");
                    }
                }
            }
            dataBase.CloseConnection();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            PerformSearch();
        }

        private void AdminBtn_Click(object sender, EventArgs e)
        {
            ListAdminUserControl admin = new ListAdminUserControl();
            admin.Location = new Point(220, 80);
            admin.Size = new Size(963, 780);
            this.Controls.Add(admin);
            admin.BringToFront();

            PrintListAirport(admin);
            PrintListUser(admin);
        }
        private void PrintListAirport(ListAdminUserControl admin)
        {
            dataBase.OpenConnection();

            // Создаем команду и привязываем к ней соединение
            SqlCommand command = new SqlCommand("SELECT * FROM [Airoports]", dataBase.GetConnection());
            SqlDataReader reader = command.ExecuteReader();

            admin.flowLayoutPanelAirprot.Controls.Clear();
            int AirportCount = 0;
            while (reader.Read())
            {
                ListAirportMiniControler Item = new ListAirportMiniControler();
                if (!reader.IsDBNull(9))
                {
                    try
                    {
                        byte[] Photo = (byte[])(reader[9]);
                        MemoryStream memoryStream = new MemoryStream(Photo);
                        {
                            Item.PictureBoxAirports.Image = Image.FromStream(memoryStream);
                        }
                    }
                    catch (Exception ex)
                    {
                        // Логирование ошибки (если необходимо)
                        Console.WriteLine("Ошибка при загрузке изображения: " + ex.Message);
                    }
                    Item.labelIDMC.Text = reader["Id_Airoport"].ToString();
                    Item.labelName.Text = reader[1].ToString();
                    Item.labelCode.Text = reader[2].ToString();
                    Item.labelCity.Text = reader[3].ToString();

                    admin.flowLayoutPanelAirprot.Controls.Add(Item);
                    AirportCount++;
                }
            }
            reader.Close();
            dataBase.CloseConnection();
            admin.labelCountAirport.Text = " " + AirportCount.ToString();
        }
        private void PrintListUser(ListAdminUserControl admin)
        {
            dataBase.OpenConnection();

            // Создаем команду и привязываем к ней соединение
            SqlCommand command = new SqlCommand("SELECT * FROM [Users]", dataBase.GetConnection());
            SqlDataReader reader = command.ExecuteReader();

            admin.flowLayoutPanelUser.Controls.Clear();
            int userCount = 0;
            while (reader.Read())
            {
                ListUserMiniControler Item = new ListUserMiniControler();
                Item.labelMail.Text = reader[1].ToString();
                Item.labelName.Text = reader[2].ToString();
                Item.labelPassword.Text = reader[3].ToString();

                admin.flowLayoutPanelUser.Controls.Add(Item);
                userCount++;
            }
            reader.Close();
            dataBase.CloseConnection();
            admin.labelCountUser.Text = " " + userCount.ToString();
        }
        public void PrintListAirport(FlowLayoutPanelForListAirportControler UserListControl)
        {
            dataBase.OpenConnection();
            SqlCommand command = new SqlCommand("SELECT * FROM [Airoports]", dataBase.GetConnection());
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {

                // Проверяем, что столбец с фото и описанием существует
                if (reader[9] != DBNull.Value && reader[7] != DBNull.Value)
                {

                    byte[] photo = (byte[])(reader[9]);
                    MemoryStream memoryStream = new MemoryStream(photo);
                    Image airportImage = Image.FromStream(memoryStream);
                    string description = reader[7].ToString();
                    string aidi = reader[1].ToString();

                    // Создаем элемент управления и устанавливаем изображение и описание
                    AirportListMiniControl item = new AirportListMiniControl(airportImage, description, aidi);

                    UserListControl.flowLayoutPanelAirPort.Controls.Add(item);
                }
            }
            reader.Close();
            dataBase.CloseConnection();
        }
        private void AiroportsInfo_Load(object sender, EventArgs e)
        {
            _obj = this;
            if (PanelInfo.Controls.Count > 0)
                PanelInfo.Controls.RemoveAt(0);
            FlowLayoutPanelForListAirportControler userListControl = new FlowLayoutPanelForListAirportControler();
            PanelInfo.Controls.Add(userListControl);
            userListControl.BringToFront();

            PrintListAirport(userListControl);
        }
        private void BtnMap_Click(object sender, EventArgs e)
        {
            MapForm mapForm = new MapForm();
            mapForm.Show();
        }

        private void PictureBoxLogReg_Click(object sender, EventArgs e)
        {
            LogRegControl userControl1 = new LogRegControl();
            PanelInfo.Controls.Add(userControl1);
            if (labelNameUser.Text != "Name")
            {
                userControl1.panelLogReg.Visible = false;
                userControl1.Size = new Size(208, 45);
            }
            userControl1.Location = new Point(750, 0);
            userControl1.BringToFront();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            PanelSeach.Location = new Point(24, 12);
            PanelInfo.Controls.RemoveAt(0);
            BackButton.Visible = false;
        }

        private void btnAeroport_Click(object sender, EventArgs e)
        {
            _obj = this;
            if (PanelInfo.Controls.Count > 0)
                PanelInfo.Controls.RemoveAt(0);
            FlowLayoutPanelForListAirportControler userListControl = new FlowLayoutPanelForListAirportControler();
            PanelInfo.Controls.Add(userListControl);
            userListControl.BringToFront();
            PrintListAirport(userListControl);
        }

        private void BtnUser_Click(object sender, EventArgs e)
        {
            UserPanel userpanel = new UserPanel();
            userpanel.Show();
        }
    }
}
