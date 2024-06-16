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
using System.Windows.Forms;

namespace AiroHelper
{
    public partial class AdminPanel : Form
    {
        DataBase dataBase = new DataBase();
        public AdminPanel()
        {
            InitializeComponent();
            this.ActiveControl = label1;
        }
        private void AirPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'А' && e.KeyChar <= 'я') || e.KeyChar == 'Ё' || e.KeyChar == 'ё')
            {
                e.Handled = false;
            }
            // Разрешаем использование управляющих клавиш (Backspace, Delete и т.д.)
            else if (char.IsControl(e.KeyChar) || e.KeyChar == ' ')
            {
                e.Handled = false;
            }
            else
            {
                // Блокируем ввод всех остальных символов
                e.Handled = true;
            }
        }
        private void validateButton_Click(object sender, CancelEventArgs e)
        {
            string input = TextBoxName.Text.Trim();

            //if (input.Equals("Аэропорт", StringComparison.OrdinalIgnoreCase))
            if (string.IsNullOrEmpty(input))
            {
                panelInfo.Visible = true;
                labelMessenge.ForeColor = Color.Red;
                labelMessenge.Text = "Ошибка. Вы не заполнили это поле.";
                TextBoxName.BorderColor = Color.Red;
            }
            else
            {
                // Проверка, что текст содержит "Аэропорт" и после него есть дополнительные символы
                string pattern = @"Аэропорт.+";

                if (Regex.IsMatch(input, pattern, RegexOptions.IgnoreCase))
                {
                    panelInfo.Visible = false;
                    TextBoxName.BorderColor = Color.Lime;
                }
                else
                {
                    panelInfo.Visible = true;
                    labelMessenge.ForeColor = Color.Red;
                    labelMessenge.Text = "Ошибка. Пожалуйста введите слово 'Аэропорт' или после него название.";
                    TextBoxName.BorderColor = Color.Red;
                }
            }
        }
        private void limitedTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.GetUnicodeCategory(e.KeyChar) == System.Globalization.UnicodeCategory.LowercaseLetter ||
                char.GetUnicodeCategory(e.KeyChar) == System.Globalization.UnicodeCategory.UppercaseLetter)
            {
                if (!(e.KeyChar >= 'A' && e.KeyChar <= 'Z'))
                {
                    e.Handled = true;
                }
            }
        }
        private void TextBoxCode_TextChanged(object sender, EventArgs e)
        {
            if (limitedTextBox.Text.Length < 3)
            {
                panelInfo.Visible = true;
                labelMessenge.ForeColor = Color.Red;
                labelMessenge.Text = "Ошибка. Вы ввели меньше 3-ех символов.";
                limitedTextBox.BorderColor = Color.Red;
            }
            else
            {
                panelInfo.Visible = false;
                limitedTextBox.BorderColor = Color.Lime;
            }
        }

        private void CodeButton_Click(object sender, CancelEventArgs e)
        {
            string inputCode = limitedTextBox.Text.Trim();
            if (string.IsNullOrEmpty(inputCode))
            {
                panelInfo.Visible = true;
                labelMessenge.ForeColor = Color.Red;
                labelMessenge.Text = "Ошибка. Вы не заполнили это поле.";
                limitedTextBox.BorderColor = Color.Red;
            }
        }

        private void ShareBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog efd = new OpenFileDialog();
                if (efd.ShowDialog() == DialogResult.OK)
                    SharePictureBox.Image = Image.FromFile(efd.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ComboBox_Click(object sender, CancelEventArgs e)
        {
            if (ComboBoxCity.SelectedIndex == -1 || string.IsNullOrEmpty(ComboBoxCity.SelectedItem?.ToString()))
            {
                panelInfo.Visible = true;
                labelMessenge.ForeColor = Color.Red;
                labelMessenge.Text = "Пожалуйста, выберите элемент из списка";
                ComboBoxCity.BorderColor = Color.Red;
            }
            else
            {
                panelInfo.Visible = false;
                ComboBoxCity.BorderColor = Color.Lime;
            }
        }

        private void Adress_Click(object sender, CancelEventArgs e)
        {
            string inputAdress = AdressTextBox.Text.Trim();

            //if (input.Equals("Аэропорт", StringComparison.OrdinalIgnoreCase))
            if (string.IsNullOrEmpty(inputAdress))
            {
                panelInfo.Visible = true;
                labelMessenge.ForeColor = Color.Red;
                labelMessenge.Text = "Ошибка. Вы не заполнили это поле.";
                AdressTextBox.BorderColor = Color.Red;
            }
            else
            {
                panelInfo.Visible = false;
                AdressTextBox.BorderColor = Color.Lime;
            }
        }

        private void AdressTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'А' && e.KeyChar <= 'я') || e.KeyChar == 'Ё' || e.KeyChar == 'ё')
            {
                e.Handled = false;
            }
            // Разрешаем использование управляющих клавиш (Backspace, Delete и т.д.)
            else if (char.IsControl(e.KeyChar) || e.KeyChar == ' ' || char.IsDigit(e.KeyChar))
            {
                panelInfo.Visible = false;
                AdressTextBox.BorderColor = Color.Lime;
                e.Handled = false;
            }
            else
            {
                // Блокируем ввод всех остальных символов
                e.Handled = true;
            }
        }
        private void Coordinate_Click(object sender, CancelEventArgs e)
        {
            string inputCoordinate = TextBoxCoorditik_X.Text.Trim();

            //if (input.Equals("Аэропорт", StringComparison.OrdinalIgnoreCase))
            if (string.IsNullOrEmpty(inputCoordinate))
            {
                panelInfo.Visible = true;
                labelMessenge.ForeColor = Color.Red;
                labelMessenge.Text = "Ошибка. Вы не заполнили это поле.";
                TextBoxCoorditik_X.BorderColor = Color.Red;
            }
            else
            {
                panelInfo.Visible = false;
                TextBoxCoorditik_X.BorderColor = Color.Lime;
            }
        }
        private void TextBoxCoorditik_TextChanged(object sender, EventArgs e)
        {

            // Получаем текущий текст из текстового поля
            string text = TextBoxCoorditik_X.Text;

            // Удаляем все символы, не соответствующие паттерну
            TextBoxCoorditik_X.Text = Regex.Replace(text, "[^0-9., -]", "");

            // Перемещаем курсор в конец текста
            TextBoxCoorditik_X.SelectionStart = TextBoxCoorditik_X.Text.Length;
        }
        private void TextBoxCoorditik_Y_Click(object sender, CancelEventArgs e)
        {
            string inputCoordinate = TextBoxCoorditik_Y.Text.Trim();

            //if (input.Equals("Аэропорт", StringComparison.OrdinalIgnoreCase))
            if (string.IsNullOrEmpty(inputCoordinate))
            {
                panelInfo.Visible = true;
                labelMessenge.ForeColor = Color.Red;
                labelMessenge.Text = "Ошибка. Вы не заполнили это поле.";
                TextBoxCoorditik_Y.BorderColor = Color.Red;
            }
            else
            {
                panelInfo.Visible = false;
                TextBoxCoorditik_Y.BorderColor = Color.Lime;
            }
        }
        private void TextBoxCoorditik_Y_TextChanged(object sender, EventArgs e)
        {

            // Получаем текущий текст из текстового поля
            string text = TextBoxCoorditik_Y.Text;

            // Удаляем все символы, не соответствующие паттерну
            TextBoxCoorditik_Y.Text = Regex.Replace(text, "[^0-9., -]", "");

            // Перемещаем курсор в конец текста
            TextBoxCoorditik_Y.SelectionStart = TextBoxCoorditik_Y.Text.Length;
        }
        private void TextBoxCompany_Click(object sender, CancelEventArgs e)
        {
            string inputCompany = TextBoxCompany.Text.Trim();
            if (string.IsNullOrEmpty(inputCompany))
            {
                panelInfo.Visible = true;
                labelMessenge.ForeColor = Color.Red;
                labelMessenge.Text = "Ошибка. Вы не заполнили это поле.";
                TextBoxCompany.BorderColor = Color.Red;
            }
            else
            {
                panelInfo.Visible = false;
                TextBoxCompany.BorderColor = Color.Lime;
            }
        }

        private void TextBoxCompany_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'А' && e.KeyChar <= 'я') || e.KeyChar == 'Ё' || e.KeyChar == 'ё')
            {
                e.Handled = false;
            }
            // Разрешаем использование управляющих клавиш (Backspace, Delete и т.д.)
            else if (char.IsControl(e.KeyChar) || e.KeyChar == ' ')
            {
                panelInfo.Visible = false;
                TextBoxCompany.BorderColor = Color.Lime;
                e.Handled = false;
            }
            else
            {
                // Блокируем ввод всех остальных символов
                e.Handled = true;
            }
        }
        Point lastPoint;

        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(TextBoxName.Text) ||
                    string.IsNullOrEmpty(limitedTextBox.Text) ||
                    string.IsNullOrEmpty(ComboBoxCity.Text) ||
                    string.IsNullOrEmpty(AdressTextBox.Text) ||
                    string.IsNullOrEmpty(TextBoxCoorditik_X.Text) ||
                    string.IsNullOrEmpty(TextBoxCoorditik_Y.Text) ||
                    string.IsNullOrEmpty(TextBoxCompany.Text) ||
                    SharePictureBox.Image == null ||
                    string.IsNullOrEmpty(TextBoxDescription.Text))
                {
                    MessageBox.Show("Пожалуйста, заполните все поля.");
                    return;
                }

                dataBase.OpenConnection();
                MemoryStream memoryStream = new MemoryStream();
                SharePictureBox.Image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);
                byte[] Photo = new byte[memoryStream.Length];

                memoryStream.Position = 0;
                memoryStream.Read(Photo, 0, Photo.Length);

                SqlCommand command = new SqlCommand(
                    "INSERT INTO Airoports (Airoport_Name, Airoport_Code, Airoport_City, Airoport_Аddress, Airoport_Location_x, Airoport_Location_y, Airoport_Company, Airoport_Map_Image, Airoport_Description) " +
                    "OUTPUT INSERTED.Id_Airoport " +
                    "VALUES (@name, @code, @city, @address, @location_x, @location_y, @company, @photo, @description)",
                    dataBase.GetConnection());

                command.Parameters.AddWithValue("@name", TextBoxName.Text);
                command.Parameters.AddWithValue("@code", limitedTextBox.Text);
                command.Parameters.AddWithValue("@city", ComboBoxCity.Text);
                command.Parameters.AddWithValue("@address", AdressTextBox.Text);
                command.Parameters.AddWithValue("@location_x", TextBoxCoorditik_X.Text);
                command.Parameters.AddWithValue("@location_y", TextBoxCoorditik_Y.Text);
                command.Parameters.AddWithValue("@company", TextBoxCompany.Text);
                command.Parameters.AddWithValue("@photo", Photo);
                command.Parameters.AddWithValue("@description", TextBoxDescription.Text);
                
                int newAirportId = (int)command.ExecuteScalar();
                AplicationContext.AirId = newAirportId;
                dataBase.CloseConnection();

                MessageBox.Show("Аэропорт был успешно добавлен");

                
                
                // Открытие другой формы и передача ID
                Schema schemafrom = new Schema(newAirportId);
                schemafrom.Show();

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось добавить аэропорт: " + ex.Message);
            }
        }
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            AdminPanel adminPanel = new AdminPanel();
            adminPanel.Show();
            this.Hide();
        }
    }
}
