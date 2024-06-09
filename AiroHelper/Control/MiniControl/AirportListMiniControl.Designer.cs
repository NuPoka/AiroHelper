namespace AiroHelper
{
    partial class AirportListMiniControl
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
            this.PanelPulcovo = new Guna.UI2.WinForms.Guna2Panel();
            this.labelNameM = new System.Windows.Forms.Label();
            this.BtnAirport = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PanelDesc = new Guna.UI2.WinForms.Guna2Panel();
            this.labelDesc = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2VSeparator4 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.PictureBoxListAirport = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2ElipseMainPanel = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.PanelPulcovo.SuspendLayout();
            this.guna2PanelDesc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxListAirport)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelPulcovo
            // 
            this.PanelPulcovo.BackColor = System.Drawing.Color.GhostWhite;
            this.PanelPulcovo.Controls.Add(this.labelNameM);
            this.PanelPulcovo.Controls.Add(this.BtnAirport);
            this.PanelPulcovo.Controls.Add(this.guna2PanelDesc);
            this.PanelPulcovo.Controls.Add(this.guna2VSeparator4);
            this.PanelPulcovo.Controls.Add(this.PictureBoxListAirport);
            this.PanelPulcovo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelPulcovo.Location = new System.Drawing.Point(0, 0);
            this.PanelPulcovo.Name = "PanelPulcovo";
            this.PanelPulcovo.Size = new System.Drawing.Size(895, 100);
            this.PanelPulcovo.TabIndex = 1;
            // 
            // labelNameM
            // 
            this.labelNameM.AutoSize = true;
            this.labelNameM.Location = new System.Drawing.Point(4, 3);
            this.labelNameM.Name = "labelNameM";
            this.labelNameM.Size = new System.Drawing.Size(15, 13);
            this.labelNameM.TabIndex = 6;
            this.labelNameM.Text = "id";
            // 
            // BtnAirport
            // 
            this.BtnAirport.Animated = true;
            this.BtnAirport.AutoRoundedCorners = true;
            this.BtnAirport.BackColor = System.Drawing.Color.Transparent;
            this.BtnAirport.BorderRadius = 30;
            this.BtnAirport.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnAirport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnAirport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnAirport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnAirport.FillColor = System.Drawing.Color.Green;
            this.BtnAirport.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.BtnAirport.ForeColor = System.Drawing.Color.White;
            this.BtnAirport.Image = global::AiroHelper.Properties.Resources.next_10238851;
            this.BtnAirport.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BtnAirport.IndicateFocus = true;
            this.BtnAirport.Location = new System.Drawing.Point(734, 19);
            this.BtnAirport.Name = "BtnAirport";
            this.BtnAirport.Size = new System.Drawing.Size(139, 62);
            this.BtnAirport.TabIndex = 5;
            this.BtnAirport.Text = "Перейти";
            this.BtnAirport.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BtnAirport.UseTransparentBackground = true;
            this.BtnAirport.Click += new System.EventHandler(this.BtnAirport_Click);
            // 
            // guna2PanelDesc
            // 
            this.guna2PanelDesc.BackColor = System.Drawing.Color.Gainsboro;
            this.guna2PanelDesc.Controls.Add(this.labelDesc);
            this.guna2PanelDesc.Location = new System.Drawing.Point(133, 19);
            this.guna2PanelDesc.Name = "guna2PanelDesc";
            this.guna2PanelDesc.Size = new System.Drawing.Size(560, 62);
            this.guna2PanelDesc.TabIndex = 5;
            // 
            // labelDesc
            // 
            this.labelDesc.AutoSize = false;
            this.labelDesc.BackColor = System.Drawing.Color.Transparent;
            this.labelDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDesc.Location = new System.Drawing.Point(3, 0);
            this.labelDesc.Name = "labelDesc";
            this.labelDesc.Size = new System.Drawing.Size(554, 62);
            this.labelDesc.TabIndex = 0;
            this.labelDesc.Text = "Опись";
            // 
            // guna2VSeparator4
            // 
            this.guna2VSeparator4.FillThickness = 3;
            this.guna2VSeparator4.Location = new System.Drawing.Point(116, 19);
            this.guna2VSeparator4.Name = "guna2VSeparator4";
            this.guna2VSeparator4.Size = new System.Drawing.Size(10, 62);
            this.guna2VSeparator4.TabIndex = 5;
            // 
            // PictureBoxListAirport
            // 
            this.PictureBoxListAirport.FillColor = System.Drawing.Color.Silver;
            this.PictureBoxListAirport.Image = global::AiroHelper.Properties.Resources.PulkovPicture;
            this.PictureBoxListAirport.ImageRotate = 0F;
            this.PictureBoxListAirport.Location = new System.Drawing.Point(14, 3);
            this.PictureBoxListAirport.Name = "PictureBoxListAirport";
            this.PictureBoxListAirport.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.PictureBoxListAirport.Size = new System.Drawing.Size(95, 94);
            this.PictureBoxListAirport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxListAirport.TabIndex = 3;
            this.PictureBoxListAirport.TabStop = false;
            // 
            // guna2ElipseMainPanel
            // 
            this.guna2ElipseMainPanel.BorderRadius = 25;
            this.guna2ElipseMainPanel.TargetControl = this.PanelPulcovo;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 15;
            this.guna2Elipse2.TargetControl = this.guna2PanelDesc;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 25;
            this.guna2Elipse1.TargetControl = this;
            // 
            // AirportListMiniControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.PanelPulcovo);
            this.Name = "AirportListMiniControl";
            this.Size = new System.Drawing.Size(895, 100);
            this.PanelPulcovo.ResumeLayout(false);
            this.PanelPulcovo.PerformLayout();
            this.guna2PanelDesc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxListAirport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel PanelPulcovo;
        private Guna.UI2.WinForms.Guna2Button BtnAirport;
        private Guna.UI2.WinForms.Guna2Panel guna2PanelDesc;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator4;
        private Guna.UI2.WinForms.Guna2Elipse guna2ElipseMainPanel;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        public Guna.UI2.WinForms.Guna2HtmlLabel labelDesc;
        public Guna.UI2.WinForms.Guna2CirclePictureBox PictureBoxListAirport;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        public System.Windows.Forms.Label labelNameM;
    }
}
