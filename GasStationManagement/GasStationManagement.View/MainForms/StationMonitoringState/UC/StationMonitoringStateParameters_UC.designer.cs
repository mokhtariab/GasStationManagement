namespace GasStationManagement.View.MainForms.StationMonitoringState
{
    partial class StationMonitoringStateParameters_UC
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StationMonitoringStateParameters_UC));
            this.buttonDelete = new MSS.Library.Control.MSSButton(this.components);
            this.label1 = new MSS.Library.Control.MSSLabel(this.components);
            this.label2 = new MSS.Library.Control.MSSLabel(this.components);
            this.buttonParameter = new MSS.Library.Control.MSSButton(this.components);
            this.textBoxParameter = new MSS.Library.Control.MSSTextBox(this.components);
            this.TextBoxParameterDescription = new MSS.Library.Control.MSSTextBox(this.components);
            this.SuspendLayout();
            // 
            // buttonDelete
            // 
            this.buttonDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelete.Image = ((System.Drawing.Image)(resources.GetObject("buttonDelete.Image")));
            this.buttonDelete.Location = new System.Drawing.Point(463, 4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonDelete.Size = new System.Drawing.Size(32, 29);
            this.buttonDelete.TabIndex = 65;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            // 
            // 
            // 
            this.label1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(415, 12);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 66;
            this.label1.Text = "پارامتر:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            // 
            // 
            // 
            this.label2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(197, 12);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 68;
            this.label2.Text = "توضیحات:";
            // 
            // buttonParameter
            // 
            this.buttonParameter.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonParameter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonParameter.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonParameter.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonParameter.Location = new System.Drawing.Point(249, 8);
            this.buttonParameter.Name = "buttonParameter";
            this.buttonParameter.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonParameter.Size = new System.Drawing.Size(27, 21);
            this.buttonParameter.TabIndex = 75;
            this.buttonParameter.Text = "...";
            this.buttonParameter.Click += new System.EventHandler(this.buttonParameter_Click);
            // 
            // textBoxParameter
            // 
            this.textBoxParameter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.textBoxParameter.Border.Class = "TextBoxBorder";
            this.textBoxParameter.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxParameter.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBoxParameter.ForeColor = System.Drawing.Color.Black;
            this.textBoxParameter.Location = new System.Drawing.Point(283, 8);
            this.textBoxParameter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxParameter.MaxLength = 50;
            this.textBoxParameter.Name = "textBoxParameter";
            this.textBoxParameter.ReadOnly = true;
            this.textBoxParameter.Size = new System.Drawing.Size(130, 21);
            this.textBoxParameter.TabIndex = 74;
            // 
            // TextBoxParameterDescription
            // 
            this.TextBoxParameterDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.TextBoxParameterDescription.Border.Class = "TextBoxBorder";
            this.TextBoxParameterDescription.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxParameterDescription.Location = new System.Drawing.Point(8, 8);
            this.TextBoxParameterDescription.Name = "TextBoxParameterDescription";
            this.TextBoxParameterDescription.Size = new System.Drawing.Size(183, 21);
            this.TextBoxParameterDescription.TabIndex = 76;
            // 
            // StationMonitoringStateParameters_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.TextBoxParameterDescription);
            this.Controls.Add(this.buttonParameter);
            this.Controls.Add(this.textBoxParameter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDelete);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "StationMonitoringStateParameters_UC";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(498, 38);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MSS.Library.Control.MSSButton buttonDelete;
        private MSS.Library.Control.MSSLabel label1;
        private MSS.Library.Control.MSSLabel label2;
        private MSS.Library.Control.MSSButton buttonParameter;
        private MSS.Library.Control.MSSTextBox textBoxParameter;
        private MSS.Library.Control.MSSTextBox TextBoxParameterDescription;
    }
}
