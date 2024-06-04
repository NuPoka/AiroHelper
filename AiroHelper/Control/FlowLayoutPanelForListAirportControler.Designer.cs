namespace AiroHelper
{
    partial class FlowLayoutPanelForListAirportControler
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
            this.flowLayoutPanelAirPort = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flowLayoutPanelAirPort
            // 
            this.flowLayoutPanelAirPort.AutoScroll = true;
            this.flowLayoutPanelAirPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelAirPort.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelAirPort.Name = "flowLayoutPanelAirPort";
            this.flowLayoutPanelAirPort.Size = new System.Drawing.Size(853, 528);
            this.flowLayoutPanelAirPort.TabIndex = 0;
            // 
            // FlowLayoutPanelForListAirportControler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanelAirPort);
            this.Name = "FlowLayoutPanelForListAirportControler";
            this.Size = new System.Drawing.Size(853, 528);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanelAirPort;
    }
}
