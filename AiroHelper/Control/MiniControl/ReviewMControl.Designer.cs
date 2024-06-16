namespace AiroHelper.Control.MiniControl
{
    partial class ReviewMControl
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
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelId = new System.Windows.Forms.Label();
            this.labelRiviewComment = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.labelReviewUserName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.FillColor = System.Drawing.Color.LightGray;
            this.guna2CirclePictureBox1.Image = global::AiroHelper.Properties.Resources.user_3237472;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(3, 3);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(43, 42);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 0;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.labelId);
            this.panel1.Controls.Add(this.labelRiviewComment);
            this.panel1.Controls.Add(this.labelReviewUserName);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(897, 48);
            this.panel1.TabIndex = 1;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(139, 15);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(35, 13);
            this.labelId.TabIndex = 2;
            this.labelId.Text = "label1";
            // 
            // labelRiviewComment
            // 
            this.labelRiviewComment.AutoSize = false;
            this.labelRiviewComment.BackColor = System.Drawing.Color.Transparent;
            this.labelRiviewComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRiviewComment.Location = new System.Drawing.Point(192, 1);
            this.labelRiviewComment.Name = "labelRiviewComment";
            this.labelRiviewComment.Size = new System.Drawing.Size(703, 45);
            this.labelRiviewComment.TabIndex = 1;
            this.labelRiviewComment.Text = "labelRiviewComment";
            // 
            // labelReviewUserName
            // 
            this.labelReviewUserName.AutoSize = true;
            this.labelReviewUserName.Location = new System.Drawing.Point(66, 15);
            this.labelReviewUserName.Name = "labelReviewUserName";
            this.labelReviewUserName.Size = new System.Drawing.Size(57, 13);
            this.labelReviewUserName.TabIndex = 0;
            this.labelReviewUserName.Text = "UserName";
            // 
            // ReviewMControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "ReviewMControl";
            this.Size = new System.Drawing.Size(897, 48);
            this.Load += new System.EventHandler(this.ReviewMControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        public Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        public Guna.UI2.WinForms.Guna2HtmlLabel labelRiviewComment;
        public System.Windows.Forms.Label labelReviewUserName;
        public System.Windows.Forms.Label labelId;
    }
}
