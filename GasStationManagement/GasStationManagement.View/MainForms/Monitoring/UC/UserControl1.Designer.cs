namespace GasStationManagement.View.MainForms.Monitoring.UC
{
    partial class UserControl1
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.monitoring_UC1 = new GasStationManagement.View.MainForms.Monitoring.Monitoring_UC();
            this.monitoringSupply_UC1 = new GasStationManagement.View.MainForms.Monitoring.MonitoringSupply_UC();
            this.SuspendLayout();
            // 
            // monitoring_UC1
            // 
            this.monitoring_UC1.Dock = System.Windows.Forms.DockStyle.Top;
            this.monitoring_UC1.Location = new System.Drawing.Point(0, 0);
            this.monitoring_UC1.Name = "monitoring_UC1";
            this.monitoring_UC1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.monitoring_UC1.Size = new System.Drawing.Size(709, 296);
            this.monitoring_UC1.TabIndex = 0;
            this.monitoring_UC1.UserControl_Slave = this.monitoringSupply_UC1;
            // 
            // monitoringSupply_UC1
            // 
            this.monitoringSupply_UC1.Dock = System.Windows.Forms.DockStyle.Top;
            this.monitoringSupply_UC1.Location = new System.Drawing.Point(0, 296);
            this.monitoringSupply_UC1.Name = "monitoringSupply_UC1";
            this.monitoringSupply_UC1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.monitoringSupply_UC1.Size = new System.Drawing.Size(709, 235);
            this.monitoringSupply_UC1.TabIndex = 1;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.monitoringSupply_UC1);
            this.Controls.Add(this.monitoring_UC1);
            this.Name = "UserControl1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(709, 616);
            this.ResumeLayout(false);

        }

        #endregion

        private Monitoring_UC monitoring_UC1;
        private MonitoringSupply_UC monitoringSupply_UC1;
    }
}
