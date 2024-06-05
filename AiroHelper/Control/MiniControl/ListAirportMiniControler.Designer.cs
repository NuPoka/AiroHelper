namespace AiroHelper
{
    partial class ListAirportMiniControler
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
            this.panelAirports = new System.Windows.Forms.Panel();
            this.guna2VSeparator4 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.guna2VSeparator3 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.labelCity = new System.Windows.Forms.Label();
            this.pictureBoxDelete = new System.Windows.Forms.PictureBox();
            this.guna2VSeparator2 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.labelCode = new System.Windows.Forms.Label();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.labelName = new System.Windows.Forms.Label();
            this.PictureBoxAirports = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.panelAirports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxAirports)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAirports
            // 
            this.panelAirports.BackColor = System.Drawing.Color.SlateBlue;
            this.panelAirports.Controls.Add(this.guna2VSeparator4);
            this.panelAirports.Controls.Add(this.guna2VSeparator3);
            this.panelAirports.Controls.Add(this.labelCity);
            this.panelAirports.Controls.Add(this.pictureBoxDelete);
            this.panelAirports.Controls.Add(this.guna2VSeparator2);
            this.panelAirports.Controls.Add(this.labelCode);
            this.panelAirports.Controls.Add(this.guna2VSeparator1);
            this.panelAirports.Controls.Add(this.labelName);
            this.panelAirports.Controls.Add(this.PictureBoxAirports);
            this.panelAirports.Location = new System.Drawing.Point(0, 0);
            this.panelAirports.Name = "panelAirports";
            this.panelAirports.Size = new System.Drawing.Size(737, 38);
            this.panelAirports.TabIndex = 0;
            // 
            // guna2VSeparator4
            // 
            this.guna2VSeparator4.Location = new System.Drawing.Point(680, 7);
            this.guna2VSeparator4.Name = "guna2VSeparator4";
            this.guna2VSeparator4.Size = new System.Drawing.Size(10, 24);
            this.guna2VSeparator4.TabIndex = 8;
            // 
            // guna2VSeparator3
            // 
            this.guna2VSeparator3.Location = new System.Drawing.Point(372, 7);
            this.guna2VSeparator3.Name = "guna2VSeparator3";
            this.guna2VSeparator3.Size = new System.Drawing.Size(10, 24);
            this.guna2VSeparator3.TabIndex = 7;
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelCity.ForeColor = System.Drawing.Color.White;
            this.labelCity.Location = new System.Drawing.Point(382, 13);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(42, 15);
            this.labelCity.TabIndex = 6;
            this.labelCity.Text = "Город";
            // 
            // pictureBoxDelete
            // 
            this.pictureBoxDelete.Image = global::AiroHelper.Properties.Resources.close_12484191;
            this.pictureBoxDelete.Location = new System.Drawing.Point(696, 7);
            this.pictureBoxDelete.Name = "pictureBoxDelete";
            this.pictureBoxDelete.Size = new System.Drawing.Size(31, 24);
            this.pictureBoxDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDelete.TabIndex = 5;
            this.pictureBoxDelete.TabStop = false;
            this.pictureBoxDelete.Click += new System.EventHandler(this.pictureBoxDelete_Click);
            // 
            // guna2VSeparator2
            // 
            this.guna2VSeparator2.Location = new System.Drawing.Point(260, 7);
            this.guna2VSeparator2.Name = "guna2VSeparator2";
            this.guna2VSeparator2.Size = new System.Drawing.Size(10, 24);
            this.guna2VSeparator2.TabIndex = 4;
            // 
            // labelCode
            // 
            this.labelCode.AutoSize = true;
            this.labelCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelCode.ForeColor = System.Drawing.Color.White;
            this.labelCode.Location = new System.Drawing.Point(269, 13);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(29, 15);
            this.labelCode.TabIndex = 3;
            this.labelCode.Text = "Код";
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.Location = new System.Drawing.Point(60, 7);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(10, 24);
            this.guna2VSeparator1.TabIndex = 2;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Location = new System.Drawing.Point(69, 13);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(32, 15);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Имя";
            // 
            // PictureBoxAirports
            // 
            this.PictureBoxAirports.ImageRotate = 0F;
            this.PictureBoxAirports.Location = new System.Drawing.Point(20, 1);
            this.PictureBoxAirports.Name = "PictureBoxAirports";
            this.PictureBoxAirports.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.PictureBoxAirports.Size = new System.Drawing.Size(34, 34);
            this.PictureBoxAirports.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxAirports.TabIndex = 0;
            this.PictureBoxAirports.TabStop = false;
            // 
            // ListAirportMiniControler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelAirports);
            this.Name = "ListAirportMiniControler";
            this.Size = new System.Drawing.Size(737, 38);
            this.panelAirports.ResumeLayout(false);
            this.panelAirports.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxAirports)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator2;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator4;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator3;
        public System.Windows.Forms.Label labelCode;
        public System.Windows.Forms.PictureBox pictureBoxDelete;
        public System.Windows.Forms.Label labelCity;
        public System.Windows.Forms.Panel panelAirports;
        public Guna.UI2.WinForms.Guna2CirclePictureBox PictureBoxAirports;
        public System.Windows.Forms.Label labelName;
    }
}
