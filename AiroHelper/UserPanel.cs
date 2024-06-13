using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

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
            SqlCommand sqlCommand = new SqlCommand("UPDATE Users SET User_N = @user_name, User_F = @user_family WHERE User_Name = @login", dataBase.GetConnection());
            sqlCommand.Parameters.AddWithValue("@user_name", TextBoxNameU.Text);
            sqlCommand.Parameters.AddWithValue("@user_family", TextBoxFamilyU.Text);
            sqlCommand.Parameters.AddWithValue("@login", DataBank.LoginUser);
            int result = sqlCommand.ExecuteNonQuery();
            if (result > 0)
            {
                MessageBox.Show("Успешно сохранено.");
                TextBoxNameU.BorderColor = Color.Lime;
                TextBoxFamilyU.BorderColor = Color.Lime;
                TextBoxNameU.ReadOnly = true;
                TextBoxFamilyU.ReadOnly = true;
                DataBank.Name = TextBoxNameU.Text;
                DataBank.Family = TextBoxFamilyU.Text;
            }
            else
            {
                MessageBox.Show("Не удалось сохранить.");
            }
        }
        private bool CheckPasswordsMatch(string newPassword, string confirmPassword)
        {
            // Проверяем, что оба поля пароля не пустые и совпадают
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
            Favorits fav = new Favorits();
            fav.Show();
            this.Hide();
        }
    }
}
