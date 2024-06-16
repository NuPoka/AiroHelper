namespace AiroHelper.Control.MiniControl
{
    partial class FavoriteAirportsMControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelNameFav = new System.Windows.Forms.Label();
            this.labelCodeFav = new System.Windows.Forms.Label();
            this.pictureBoxAirportFav = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2RatingStar1 = new Guna.UI2.WinForms.Guna2RatingStar();
            this.BtnMark = new Guna.UI2.WinForms.Guna2Button();
            this.guna2VSeparator2 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.BtnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.TexBoxReview = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAirportFav)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNameFav
            // 
            this.labelNameFav.AutoSize = true;
            this.labelNameFav.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameFav.Location = new System.Drawing.Point(141, 28);
            this.labelNameFav.Name = "labelNameFav";
            this.labelNameFav.Size = new System.Drawing.Size(73, 16);
            this.labelNameFav.TabIndex = 1;
            this.labelNameFav.Text = "Название";
            // 
            // labelCodeFav
            // 
            this.labelCodeFav.AutoSize = true;
            this.labelCodeFav.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCodeFav.Location = new System.Drawing.Point(141, 64);
            this.labelCodeFav.Name = "labelCodeFav";
            this.labelCodeFav.Size = new System.Drawing.Size(37, 16);
            this.labelCodeFav.TabIndex = 2;
            this.labelCodeFav.Text = "Код: ";
            // 
            // pictureBoxAirportFav
            // 
            this.pictureBoxAirportFav.FillColor = System.Drawing.Color.Gainsboro;
            this.pictureBoxAirportFav.ImageRotate = 0F;
            this.pictureBoxAirportFav.Location = new System.Drawing.Point(20, 6);
            this.pictureBoxAirportFav.Name = "pictureBoxAirportFav";
            this.pictureBoxAirportFav.Size = new System.Drawing.Size(102, 98);
            this.pictureBoxAirportFav.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAirportFav.TabIndex = 5;
            this.pictureBoxAirportFav.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Turquoise;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.guna2RatingStar1);
            this.panel1.Controls.Add(this.BtnMark);
            this.panel1.Controls.Add(this.guna2VSeparator2);
            this.panel1.Controls.Add(this.BtnDelete);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.guna2VSeparator1);
            this.panel1.Controls.Add(this.TexBoxReview);
            this.panel1.Controls.Add(this.pictureBoxAirportFav);
            this.panel1.Controls.Add(this.labelNameFav);
            this.panel1.Controls.Add(this.labelCodeFav);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(774, 110);
            this.panel1.TabIndex = 6;
            // 
            // guna2RatingStar1
            // 
            this.guna2RatingStar1.BorderColor = System.Drawing.Color.Black;
            this.guna2RatingStar1.BorderThickness = 1;
            this.guna2RatingStar1.Location = new System.Drawing.Point(606, 12);
            this.guna2RatingStar1.Name = "guna2RatingStar1";
            this.guna2RatingStar1.RatingColor = System.Drawing.Color.Yellow;
            this.guna2RatingStar1.Size = new System.Drawing.Size(72, 22);
            this.guna2RatingStar1.TabIndex = 12;
            // 
            // BtnMark
            // 
            this.BtnMark.Animated = true;
            this.BtnMark.AutoRoundedCorners = true;
            this.BtnMark.BackColor = System.Drawing.Color.Transparent;
            this.BtnMark.BorderRadius = 21;
            this.BtnMark.BorderThickness = 1;
            this.BtnMark.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnMark.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnMark.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnMark.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnMark.FillColor = System.Drawing.Color.SpringGreen;
            this.BtnMark.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.BtnMark.ForeColor = System.Drawing.Color.White;
            this.BtnMark.IndicateFocus = true;
            this.BtnMark.Location = new System.Drawing.Point(689, 12);
            this.BtnMark.Name = "BtnMark";
            this.BtnMark.Size = new System.Drawing.Size(82, 45);
            this.BtnMark.TabIndex = 11;
            this.BtnMark.Text = "Оценить";
            this.BtnMark.UseTransparentBackground = true;
            this.BtnMark.Click += new System.EventHandler(this.BtnMark_Click);
            // 
            // guna2VSeparator2
            // 
            this.guna2VSeparator2.FillColor = System.Drawing.Color.Black;
            this.guna2VSeparator2.FillThickness = 2;
            this.guna2VSeparator2.Location = new System.Drawing.Point(676, 9);
            this.guna2VSeparator2.Name = "guna2VSeparator2";
            this.guna2VSeparator2.Size = new System.Drawing.Size(10, 92);
            this.guna2VSeparator2.TabIndex = 10;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Animated = true;
            this.BtnDelete.AutoRoundedCorners = true;
            this.BtnDelete.BackColor = System.Drawing.Color.Transparent;
            this.BtnDelete.BorderRadius = 21;
            this.BtnDelete.BorderThickness = 1;
            this.BtnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnDelete.FillColor = System.Drawing.Color.Red;
            this.BtnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.BtnDelete.ForeColor = System.Drawing.Color.White;
            this.BtnDelete.IndicateFocus = true;
            this.BtnDelete.Location = new System.Drawing.Point(689, 62);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(82, 45);
            this.BtnDelete.TabIndex = 9;
            this.BtnDelete.Text = "Удалить";
            this.BtnDelete.UseTransparentBackground = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(324, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Не больше 50-ти символов.";
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.FillColor = System.Drawing.Color.Black;
            this.guna2VSeparator1.FillThickness = 2;
            this.guna2VSeparator1.Location = new System.Drawing.Point(308, 6);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(10, 92);
            this.guna2VSeparator1.TabIndex = 7;
            // 
            // TexBoxReview
            // 
            this.TexBoxReview.BorderThickness = 2;
            this.TexBoxReview.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TexBoxReview.DefaultText = "";
            this.TexBoxReview.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TexBoxReview.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TexBoxReview.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TexBoxReview.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TexBoxReview.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TexBoxReview.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.TexBoxReview.ForeColor = System.Drawing.Color.Black;
            this.TexBoxReview.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TexBoxReview.Location = new System.Drawing.Point(324, 9);
            this.TexBoxReview.Name = "TexBoxReview";
            this.TexBoxReview.PasswordChar = '\0';
            this.TexBoxReview.PlaceholderText = "";
            this.TexBoxReview.SelectedText = "";
            this.TexBoxReview.Size = new System.Drawing.Size(280, 80);
            this.TexBoxReview.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(499, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(171, 18);
            this.panel2.TabIndex = 13;
            this.panel2.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(7, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "label2";
            // 
            // FavoriteAirportsMControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "FavoriteAirportsMControl";
            this.Size = new System.Drawing.Size(774, 110);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAirportFav)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Label labelNameFav;
        public System.Windows.Forms.Label labelCodeFav;
        public Guna.UI2.WinForms.Guna2PictureBox pictureBoxAirportFav;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        public Guna.UI2.WinForms.Guna2TextBox TexBoxReview;
        private Guna.UI2.WinForms.Guna2Button BtnDelete;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator2;
        private Guna.UI2.WinForms.Guna2RatingStar guna2RatingStar1;
        private Guna.UI2.WinForms.Guna2Button BtnMark;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
    }
}
