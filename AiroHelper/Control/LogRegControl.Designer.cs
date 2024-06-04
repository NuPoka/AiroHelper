namespace AiroHelper
{
    partial class LogRegControl
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.BtnReg = new Guna.UI2.WinForms.Guna2Button();
            this.BtnLog = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pictureBoxExit = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBoxExit);
            this.panel1.Controls.Add(this.guna2Separator1);
            this.panel1.Controls.Add(this.BtnReg);
            this.panel1.Controls.Add(this.BtnLog);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 136);
            this.panel1.TabIndex = 0;
            this.panel1.Visible = false;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.FillColor = System.Drawing.Color.Black;
            this.guna2Separator1.Location = new System.Drawing.Point(3, 24);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(200, 10);
            this.guna2Separator1.TabIndex = 3;
            // 
            // BtnReg
            // 
            this.BtnReg.Animated = true;
            this.BtnReg.AutoRoundedCorners = true;
            this.BtnReg.BackColor = System.Drawing.Color.Transparent;
            this.BtnReg.BorderRadius = 21;
            this.BtnReg.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnReg.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnReg.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnReg.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnReg.FillColor = System.Drawing.Color.White;
            this.BtnReg.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnReg.ForeColor = System.Drawing.Color.Black;
            this.BtnReg.Image = global::AiroHelper.Properties.Resources.user_8407895;
            this.BtnReg.IndicateFocus = true;
            this.BtnReg.Location = new System.Drawing.Point(2, 86);
            this.BtnReg.Name = "BtnReg";
            this.BtnReg.Size = new System.Drawing.Size(203, 45);
            this.BtnReg.TabIndex = 2;
            this.BtnReg.Text = "        Регистрация";
            this.BtnReg.UseTransparentBackground = true;
            this.BtnReg.Click += new System.EventHandler(this.BtnReg_Click);
            // 
            // BtnLog
            // 
            this.BtnLog.Animated = true;
            this.BtnLog.AutoRoundedCorners = true;
            this.BtnLog.BackColor = System.Drawing.Color.Transparent;
            this.BtnLog.BorderRadius = 21;
            this.BtnLog.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnLog.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnLog.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnLog.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnLog.FillColor = System.Drawing.Color.White;
            this.BtnLog.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnLog.ForeColor = System.Drawing.Color.Black;
            this.BtnLog.Image = global::AiroHelper.Properties.Resources.user_8407895;
            this.BtnLog.IndicateFocus = true;
            this.BtnLog.Location = new System.Drawing.Point(2, 35);
            this.BtnLog.Name = "BtnLog";
            this.BtnLog.Size = new System.Drawing.Size(203, 45);
            this.BtnLog.TabIndex = 1;
            this.BtnLog.Text = "        Авторизация";
            this.BtnLog.UseTransparentBackground = true;
            this.BtnLog.Click += new System.EventHandler(this.BtnLog_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(72, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Войти";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 35;
            this.guna2Elipse1.TargetControl = this;
            // 
            // pictureBoxExit
            // 
            this.pictureBoxExit.Image = global::AiroHelper.Properties.Resources.close_12484191;
            this.pictureBoxExit.Location = new System.Drawing.Point(177, 2);
            this.pictureBoxExit.Name = "pictureBoxExit";
            this.pictureBoxExit.Size = new System.Drawing.Size(25, 26);
            this.pictureBoxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxExit.TabIndex = 4;
            this.pictureBoxExit.TabStop = false;
            this.pictureBoxExit.Click += new System.EventHandler(this.pictureBoxExit_Click);
            // 
            // LogRegControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "LogRegControl";
            this.Size = new System.Drawing.Size(208, 134);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button BtnLog;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button BtnReg;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxExit;
    }
}
