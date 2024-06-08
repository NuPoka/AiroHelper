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
    public partial class Form1 : Form
    {
        DataBase dataBase = new DataBase();
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            MemoryStream memoryStream = new MemoryStream();
            MemoryStream memoryStream2 = new MemoryStream();
            MemoryStream memoryStream3 = new MemoryStream();
            MemoryStream memoryStream4 = new MemoryStream();

            guna2PictureBox1.Image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);
            guna2PictureBox2.Image.Save(memoryStream2, System.Drawing.Imaging.ImageFormat.Png);
            guna2PictureBox3.Image.Save(memoryStream3, System.Drawing.Imaging.ImageFormat.Png);
            guna2PictureBox4.Image.Save(memoryStream4, System.Drawing.Imaging.ImageFormat.Png);

            byte[] Photo = new byte[memoryStream.Length];
            byte[] Photo2 = new byte[memoryStream2.Length];
            byte[] Photo3 = new byte[memoryStream3.Length];
            byte[] Photo4 = new byte[memoryStream4.Length];

            memoryStream.Position = 0;
            memoryStream2.Position = 0;
            memoryStream3.Position = 0;
            memoryStream4.Position = 0;

            memoryStream.Read(Photo, 0, Photo.Length);
            memoryStream2.Read(Photo2, 0, Photo2.Length);
            memoryStream3.Read(Photo3, 0, Photo3.Length);
            memoryStream4.Read(Photo4, 0, Photo4.Length);

            dataBase.OpenConnection();
            SqlCommand command = new SqlCommand("INSERT INTO [Schema] (Airoports_id, Airoport_Schema1, Airoport_Schema2, Airoport_Schema3, Airoport_Schema4) VALUES (@airoportId, @photo, @photo2, @photo3, @photo4)", dataBase.GetConnection());
            command.Parameters.AddWithValue("@airoportId", guna2TextBox1.Text);
            command.Parameters.AddWithValue("@photo", Photo);
            command.Parameters.AddWithValue("@photo2", Photo2);
            command.Parameters.AddWithValue("@photo3", Photo3);
            command.Parameters.AddWithValue("@photo4", Photo4);

            command.ExecuteNonQuery();
            dataBase.CloseConnection();

            this.Close();
        }
        // 1 этаж
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog efd = new OpenFileDialog();
                if (efd.ShowDialog() == DialogResult.OK)
                    guna2PictureBox1.Image = Image.FromFile(efd.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // 2 этаж
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog efd = new OpenFileDialog();
                if (efd.ShowDialog() == DialogResult.OK)
                    guna2PictureBox2.Image = Image.FromFile(efd.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // 3 этаж
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog efd = new OpenFileDialog();
                if (efd.ShowDialog() == DialogResult.OK)
                    guna2PictureBox3.Image = Image.FromFile(efd.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // 4 этаж
        private void guna2Button5_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog efd = new OpenFileDialog();
                if (efd.ShowDialog() == DialogResult.OK)
                    guna2PictureBox4.Image = Image.FromFile(efd.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
