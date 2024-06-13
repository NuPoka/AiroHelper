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
    public partial class LogIn : Form
    {
        DataBase dataBase = new DataBase();
        bool sidebarExpand;
        public LogIn()
        {
            InitializeComponent();
        }

        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timerPanel_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                guna2PanelReg.Width -= 5;
                if (guna2PanelReg.Width == guna2PanelReg.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    timerPanel.Stop();
                }
            }
            else
            {
                guna2PanelReg.Width += 10;
                if (guna2PanelReg.Width == guna2PanelReg.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    timerPanel.Stop();
                }
            }
        }

        private void guna2PanelReg_Click(object sender, EventArgs e)
        {
            if (!sidebarExpand)
            {
                timerPanel.Start();
            }
        }
        private void pictureBoxReg_Click(object sender, EventArgs e)
        {
            timerPanel.Start();
        }
        private void BtnReg_Click(object sender, EventArgs e)
        {
            RegIn reg = new RegIn();
            reg.Show();
            this.Hide();
        }
        private void BtnComeIn_Click(object sender, EventArgs e)
        {
            var login = LoginT.Text;
            var pass = PassT.Text;

            // Проверка на пустые поля
            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(pass))
            {
                panelInfo.Visible = true;
                label3.ForeColor = Color.Red;
                label3.Text = "Логин и пароль не могут быть пустыми.";
                LoginT.BorderColor = Color.Red;
                PassT.BorderColor = Color.Red;
                return; // Прекращаем выполнение метода
            }

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string querystring = $"select User_Name, User_Password from Users where User_Name = '{login}' and User_Password ='{pass}'";

            SqlCommand command = new SqlCommand(querystring, dataBase.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count != 1)
            {
                panelInfo.Visible = true;
                label3.ForeColor = Color.Red;
                label3.Text = "Неправильный логин или пароль.";
                LoginT.BorderColor = Color.Red;
                PassT.BorderColor = Color.Red;
            }
            else
            {
                if (LoginT.Text == "admin") { AiroportsInfo.Instance.pnlAdmin.Visible = true; }
                AiroportsInfo.Instance.PnlLableUserText.Text = LoginT.Text;
                DataBank.LoginUser = LoginT.Text;
                AiroportsInfo.Instance.PnlLableUser.Visible = true;
                AiroportsInfo.Instance.Show();
                this.Hide();
            }
        }
    }
}
