using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AiroHelper
{
    public partial class RegIn : Form
    {
        DataBase dataBase = new DataBase();
        bool sidebarExpand;
        public RegIn()
        {
            InitializeComponent();
        }
        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timerSide_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                guna2PanelLogin.Width -= 5;
                if (guna2PanelLogin.Width == guna2PanelLogin.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    timerSide.Stop();
                }
            }
            else
            {
                guna2PanelLogin.Width += 10;
                if (guna2PanelLogin.Width == guna2PanelLogin.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    timerSide.Stop();
                }
            }
        }

        private void guna2PanelLogin_Click(object sender, EventArgs e)
        {
            if (!sidebarExpand)
            {
                timerSide.Start();
            }
        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            timerSide.Start();
        }
        private void guna2ButtonLog_Click(object sender, EventArgs e)
        {
            LogIn log = new LogIn();
            log.Show();
            this.Hide();
        }
        private void BtnReg_Click(object sender, EventArgs e)
        {
            var mail = MailT.Text;
            var login = LoginT.Text;
            var password = PassT.Text;
            var role = 2;

            // Проверка на пустые поля
            if (string.IsNullOrWhiteSpace(mail) || string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
            {
                panelInfo.Visible = true;
                label3.ForeColor = Color.Red;
                label3.Text = "Все поля должны быть заполнены.";
                if (string.IsNullOrWhiteSpace(mail)) MailT.BorderColor = Color.Red;
                if (string.IsNullOrWhiteSpace(login)) LoginT.BorderColor = Color.Red;
                if (string.IsNullOrWhiteSpace(password)) PassT.BorderColor = Color.Red;
                return; // Прекращаем выполнение метода
            }

            string querystring = $"insert into Users(User_Email, User_Name, User_Password, User_Role) values ('{mail}', '{login}', '{password}', '{role}')";

            SqlCommand command = new SqlCommand(querystring, dataBase.GetConnection());

            dataBase.OpenConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                LogIn airoportsInfo = new LogIn();
                airoportsInfo.Show();
                this.Hide();
            }
            else
            {
                panelInfo.Visible = true;
                label3.ForeColor = Color.Red;
                label3.Text = "Ошибка при регистрации.";
                LoginT.BorderColor = Color.Red;
            }
        }
    }
}
