using AiroHelper.Control.MiniControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Image = System.Drawing.Image;

namespace AiroHelper
{
    public partial class UserPanel : Form
    {
        DataBase dataBase = new DataBase();
        public UserPanel()
        {
            InitializeComponent();
        }
        
        private void UserPanel_Load(object sender, EventArgs e)
        {
            TextBoxNameU.Text = DataBank.Name;
            TextBoxFamilyU.Text = DataBank.Family;
            TextBoxOtchestvoU.Text = DataBank.Otchestvo;
            labelNameU.Text = DataBank.LoginUser;
            if (labelNameU.Text == "admin")
            {
                labelRole1.Text = "Администратор";
            }
            else
            {
                labelRole1.Text = "Пользователь";
            }
            dataBase.OpenConnection();
            SqlCommand sqlCommand = new SqlCommand("SELECT User_Email FROM Users WHERE User_Name = @login", dataBase.GetConnection());
            sqlCommand.Parameters.AddWithValue("@login", DataBank.LoginUser);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
              labelMailU.Text = reader["User_Email"].ToString();
            }
            reader.Close();
            dataBase.CloseConnection();
        }

        private void ExitImages_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var nameing = TextBoxNameU.Text;
            var family = TextBoxFamilyU.Text;
            if (string.IsNullOrWhiteSpace(nameing)) TextBoxNameU.BorderColor = Color.Red;
            if (string.IsNullOrWhiteSpace(family)) TextBoxFamilyU.BorderColor = Color.Red;
            dataBase.OpenConnection();
            SqlCommand sqlCommand = new SqlCommand("UPDATE Users SET User_N = @user_name, User_F = @user_family, User_O = @user_otchestvo WHERE User_Name = @login", dataBase.GetConnection());
            sqlCommand.Parameters.AddWithValue("@user_name", TextBoxNameU.Text);
            sqlCommand.Parameters.AddWithValue("@user_family", TextBoxFamilyU.Text);
            sqlCommand.Parameters.AddWithValue("@user_otchestvo", TextBoxOtchestvoU.Text);
            sqlCommand.Parameters.AddWithValue("@login", DataBank.LoginUser);
            int result = sqlCommand.ExecuteNonQuery();
            if (result > 0)
            {
                MessageBox.Show("Успешно сохранено.");
                TextBoxNameU.BorderColor = Color.Lime;
                TextBoxFamilyU.BorderColor = Color.Lime;
                TextBoxNameU.ReadOnly = true;
                TextBoxFamilyU.ReadOnly = true;
                TextBoxOtchestvoU.ReadOnly = true;
                DataBank.Name = TextBoxNameU.Text;
                DataBank.Family = TextBoxFamilyU.Text;
                DataBank.Otchestvo = TextBoxOtchestvoU.Text;
            }
            else
            {
                MessageBox.Show("Не удалось сохранить.");
            }
        }
        private bool CheckPasswordsMatch(string newPassword, string confirmPassword)
        {
            if (string.IsNullOrWhiteSpace(newPassword) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                return false;
            }

            if (newPassword == confirmPassword)
            {
                return true;
            }

            return false;
        }
        private void BtnSavePass_Click(object sender, EventArgs e)
        {
            string pass1 = TextBoxNewPassU.Text;
            string pass2 = TextBoxNewPassU2.Text;

            if (!CheckPasswordsMatch(pass1, pass2))
            {
                MessageBox.Show("Пароль и подтверждение пароля не совпадают.");
                return;
            }
            dataBase.OpenConnection();
            SqlCommand sqlCommand = new SqlCommand("UPDATE Users SET User_Password = @user_pass WHERE User_Name = @login", dataBase.GetConnection());
            sqlCommand.Parameters.AddWithValue("@user_pass", TextBoxNewPassU.Text);
            sqlCommand.Parameters.AddWithValue("@login", DataBank.LoginUser);
            int result = sqlCommand.ExecuteNonQuery();
            if (result > 0)
            {
                MessageBox.Show("Ваш пароль успешно изменён.");
            }
            else
            {
                MessageBox.Show("Не удалось изменить пароль.");
            }
        }

        private void BtnLike_Click(object sender, EventArgs e)
        {
            Favorits favorits = new Favorits();
            favorits.Show();
            this.Hide();
            PrintFavAirport(favorits);
        }
        private void PrintFavAirport(Favorits favorits)
        {
            dataBase.OpenConnection();
            SqlCommand command = new SqlCommand("SELECT * FROM [Favorite] WHERE User_id = @Userid", dataBase.GetConnection());
            command.Parameters.AddWithValue("@Userid", AplicationContext.UserId);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                FavoriteAirportsMControl Item = new FavoriteAirportsMControl();

                byte[] Photo = (byte[])(reader[2]);
                MemoryStream memoryStream = new MemoryStream(Photo);
                Item.pictureBoxAirportFav.Image = Image.FromStream(memoryStream);
                Item.labelNameFav.Text = reader[3].ToString();
                Item.labelCodeFav.Text = reader[4].ToString();
                favorits.flowLayoutPanel1.Controls.Add(Item);
            }
            reader.Close();
            dataBase.CloseConnection();
        }
    }
}
