namespace AiroHelper.Control.MiniControl
{
    partial class TransportMControl
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
            this.panelTrans = new System.Windows.Forms.Panel();
            this.LabelPublicTrans = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panelAuto = new System.Windows.Forms.Panel();
            this.LabelAutoTrans = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panelTaxi = new System.Windows.Forms.Panel();
            this.LabelTaxiTrans = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LabelName = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.panelTrans.SuspendLayout();
            this.panelAuto.SuspendLayout();
            this.panelTaxi.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTrans
            // 
            this.panelTrans.BackColor = System.Drawing.Color.Gainsboro;
            this.panelTrans.Controls.Add(this.pictureBox2);
            this.panelTrans.Controls.Add(this.LabelPublicTrans);
            this.panelTrans.Controls.Add(this.guna2Button1);
            this.panelTrans.Location = new System.Drawing.Point(3, 3);
            this.panelTrans.Name = "panelTrans";
            this.panelTrans.Size = new System.Drawing.Size(833, 233);
            this.panelTrans.TabIndex = 1;
            // 
            // LabelPublicTrans
            // 
            this.LabelPublicTrans.AutoSize = false;
            this.LabelPublicTrans.BackColor = System.Drawing.Color.Transparent;
            this.LabelPublicTrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelPublicTrans.Location = new System.Drawing.Point(3, 51);
            this.LabelPublicTrans.Name = "LabelPublicTrans";
            this.LabelPublicTrans.Size = new System.Drawing.Size(827, 179);
            this.LabelPublicTrans.TabIndex = 0;
            this.LabelPublicTrans.Text = "Общ.транс.";
            // 
            // panelAuto
            // 
            this.panelAuto.BackColor = System.Drawing.Color.Gainsboro;
            this.panelAuto.Controls.Add(this.pictureBox3);
            this.panelAuto.Controls.Add(this.LabelAutoTrans);
            this.panelAuto.Controls.Add(this.guna2Button2);
            this.panelAuto.Location = new System.Drawing.Point(3, 242);
            this.panelAuto.Name = "panelAuto";
            this.panelAuto.Size = new System.Drawing.Size(833, 234);
            this.panelAuto.TabIndex = 5;
            // 
            // LabelAutoTrans
            // 
            this.LabelAutoTrans.AutoSize = false;
            this.LabelAutoTrans.BackColor = System.Drawing.Color.Transparent;
            this.LabelAutoTrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelAutoTrans.Location = new System.Drawing.Point(3, 51);
            this.LabelAutoTrans.Name = "LabelAutoTrans";
            this.LabelAutoTrans.Size = new System.Drawing.Size(827, 181);
            this.LabelAutoTrans.TabIndex = 1;
            this.LabelAutoTrans.Text = "Авто";
            // 
            // panelTaxi
            // 
            this.panelTaxi.BackColor = System.Drawing.Color.Gainsboro;
            this.panelTaxi.Controls.Add(this.pictureBox1);
            this.panelTaxi.Controls.Add(this.LabelTaxiTrans);
            this.panelTaxi.Controls.Add(this.guna2Button3);
            this.panelTaxi.Location = new System.Drawing.Point(3, 482);
            this.panelTaxi.Name = "panelTaxi";
            this.panelTaxi.Size = new System.Drawing.Size(833, 234);
            this.panelTaxi.TabIndex = 6;
            // 
            // LabelTaxiTrans
            // 
            this.LabelTaxiTrans.AutoSize = false;
            this.LabelTaxiTrans.BackColor = System.Drawing.Color.Transparent;
            this.LabelTaxiTrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelTaxiTrans.Location = new System.Drawing.Point(4, 51);
            this.LabelTaxiTrans.Name = "LabelTaxiTrans";
            this.LabelTaxiTrans.Size = new System.Drawing.Size(826, 181);
            this.LabelTaxiTrans.TabIndex = 2;
            this.LabelTaxiTrans.Text = "Такси";
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelName.Location = new System.Drawing.Point(6, 12);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(121, 25);
            this.LabelName.TabIndex = 7;
            this.LabelName.Text = "LabelName";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panelTrans);
            this.flowLayoutPanel1.Controls.Add(this.panelAuto);
            this.flowLayoutPanel1.Controls.Add(this.panelTaxi);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 40);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(865, 719);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AiroHelper.Properties.Resources.bus_stop_1661962;
            this.pictureBox2.Location = new System.Drawing.Point(8, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 1;
            this.guna2Button1.BorderThickness = 1;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Button1.FillColor = System.Drawing.Color.White;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI Symbol", 24F);
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.Image = global::AiroHelper.Properties.Resources.add_11018427;
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2Button1.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Button1.Location = new System.Drawing.Point(0, 0);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(833, 45);
            this.guna2Button1.TabIndex = 0;
            this.guna2Button1.Text = "Общественный транспорт";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::AiroHelper.Properties.Resources.car_5946028;
            this.pictureBox3.Location = new System.Drawing.Point(8, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // guna2Button2
            // 
            this.guna2Button2.BorderRadius = 1;
            this.guna2Button2.BorderThickness = 1;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Button2.FillColor = System.Drawing.Color.White;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI Symbol", 24F);
            this.guna2Button2.ForeColor = System.Drawing.Color.Black;
            this.guna2Button2.Image = global::AiroHelper.Properties.Resources.add_11018427;
            this.guna2Button2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2Button2.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Button2.Location = new System.Drawing.Point(0, 0);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(833, 45);
            this.guna2Button2.TabIndex = 2;
            this.guna2Button2.Text = "На автомобиле";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AiroHelper.Properties.Resources.taxi_1661993;
            this.pictureBox1.Location = new System.Drawing.Point(8, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // guna2Button3
            // 
            this.guna2Button3.BorderRadius = 1;
            this.guna2Button3.BorderThickness = 1;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Button3.FillColor = System.Drawing.Color.White;
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI Symbol", 24F);
            this.guna2Button3.ForeColor = System.Drawing.Color.Black;
            this.guna2Button3.Image = global::AiroHelper.Properties.Resources.add_11018427;
            this.guna2Button3.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2Button3.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Button3.Location = new System.Drawing.Point(0, 0);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(833, 45);
            this.guna2Button3.TabIndex = 1;
            this.guna2Button3.Text = "Такси";
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // TransportMControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "TransportMControl";
            this.Size = new System.Drawing.Size(890, 842);
            this.panelTrans.ResumeLayout(false);
            this.panelTrans.PerformLayout();
            this.panelAuto.ResumeLayout(false);
            this.panelAuto.PerformLayout();
            this.panelTaxi.ResumeLayout(false);
            this.panelTaxi.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelTrans;
        public Guna.UI2.WinForms.Guna2HtmlLabel LabelPublicTrans;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Panel panelAuto;
        public Guna.UI2.WinForms.Guna2HtmlLabel LabelAutoTrans;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private System.Windows.Forms.Panel panelTaxi;
        public Guna.UI2.WinForms.Guna2HtmlLabel LabelTaxiTrans;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        public System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}
