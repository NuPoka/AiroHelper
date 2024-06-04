namespace AiroHelper
{
    partial class ListUserMiniControler
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
            this.panelUsers = new System.Windows.Forms.Panel();
            this.guna2VSeparator4 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.guna2VSeparator3 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.labelPassword = new System.Windows.Forms.Label();
            this.pictureBoxDelete = new System.Windows.Forms.PictureBox();
            this.guna2VSeparator2 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.labelName = new System.Windows.Forms.Label();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.labelMail = new System.Windows.Forms.Label();
            this.PictureBoxUsers = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.panelUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // panelUsers
            // 
            this.panelUsers.BackColor = System.Drawing.Color.SlateBlue;
            this.panelUsers.Controls.Add(this.guna2VSeparator4);
            this.panelUsers.Controls.Add(this.guna2VSeparator3);
            this.panelUsers.Controls.Add(this.labelPassword);
            this.panelUsers.Controls.Add(this.pictureBoxDelete);
            this.panelUsers.Controls.Add(this.guna2VSeparator2);
            this.panelUsers.Controls.Add(this.labelName);
            this.panelUsers.Controls.Add(this.guna2VSeparator1);
            this.panelUsers.Controls.Add(this.labelMail);
            this.panelUsers.Controls.Add(this.PictureBoxUsers);
            this.panelUsers.Location = new System.Drawing.Point(0, 0);
            this.panelUsers.Name = "panelUsers";
            this.panelUsers.Size = new System.Drawing.Size(737, 38);
            this.panelUsers.TabIndex = 1;
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
            this.guna2VSeparator3.Location = new System.Drawing.Point(477, 7);
            this.guna2VSeparator3.Name = "guna2VSeparator3";
            this.guna2VSeparator3.Size = new System.Drawing.Size(10, 24);
            this.guna2VSeparator3.TabIndex = 7;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(487, 13);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(45, 13);
            this.labelPassword.TabIndex = 6;
            this.labelPassword.Text = "Пароль";
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
            this.guna2VSeparator2.Location = new System.Drawing.Point(273, 7);
            this.guna2VSeparator2.Name = "guna2VSeparator2";
            this.guna2VSeparator2.Size = new System.Drawing.Size(10, 24);
            this.guna2VSeparator2.TabIndex = 4;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(282, 13);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(38, 13);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Логин";
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.Location = new System.Drawing.Point(60, 7);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(10, 24);
            this.guna2VSeparator1.TabIndex = 2;
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.Location = new System.Drawing.Point(69, 13);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(37, 13);
            this.labelMail.TabIndex = 1;
            this.labelMail.Text = "Почта";
            // 
            // PictureBoxUsers
            // 
            this.PictureBoxUsers.Image = global::AiroHelper.Properties.Resources.user_172163;
            this.PictureBoxUsers.ImageRotate = 0F;
            this.PictureBoxUsers.Location = new System.Drawing.Point(20, 1);
            this.PictureBoxUsers.Name = "PictureBoxUsers";
            this.PictureBoxUsers.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.PictureBoxUsers.Size = new System.Drawing.Size(34, 34);
            this.PictureBoxUsers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxUsers.TabIndex = 0;
            this.PictureBoxUsers.TabStop = false;
            // 
            // ListUserMiniControler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelUsers);
            this.Name = "ListUserMiniControler";
            this.Size = new System.Drawing.Size(737, 38);
            this.panelUsers.ResumeLayout(false);
            this.panelUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panelUsers;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator4;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator3;
        public System.Windows.Forms.Label labelPassword;
        public System.Windows.Forms.PictureBox pictureBoxDelete;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator2;
        public System.Windows.Forms.Label labelName;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        public System.Windows.Forms.Label labelMail;
        public Guna.UI2.WinForms.Guna2CirclePictureBox PictureBoxUsers;
    }
}
