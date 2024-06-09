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
                dataBase.OpenConnection();
                SqlCommand command = new SqlCommand("SELECT * FROM [Airoports] WHERE Airoport_Name='" + this.labelNameM.Text + "'", dataBase.GetConnection());
                SqlDataReader reader = command.ExecuteReader();

                AirPortsControl airPorts = new AirPortsControl();

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

                

                while (reader.Read())
                {
                    //информация
                    airPorts.labelId.Text = reader[0].ToString(); // номер
                    airPorts.labelName.Text = reader[1].ToString(); //название
                    airPorts.labelCode.Text += reader[2].ToString(); // код
                    airPorts.labelCity.Text += reader[3].ToString(); //город
                    airPorts.labelAdress.Text += reader[4].ToString(); //адрес
                    airPorts.labelCompany.Text += reader[8].ToString(); //компания
                    airPorts.labelDesc.Text = reader[10].ToString(); //описание


                }

                airPorts.Dock = DockStyle.Fill;
                AiroportsInfo.Instance.pnlNif.Controls["AirPortsControl"].BringToFront();

                AiroportsInfo.Instance.BackButton.Visible = true;
                AiroportsInfo.Instance.pnlSearch.Location = new Point(66, 11);
                reader.Close();
                dataBase.CloseConnection();
            }
            catch
            {
                dataBase.CloseConnection();
            }
        }
    }
}