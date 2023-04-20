
using MSS.Library.Control;
namespace GasStationManagement.View.MainForms.PressTrans
{
    partial class PressTransAdd_Frm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBoxBrand = new MSS.Library.Control.MSSTextBox(this.components);
            this.label1 = new MSS.Library.Control.MSSLabel(this.components);
            this.checkBoxIsActive = new MSS.Library.Control.MSSCheckBox(this.components);
            this.mssLabel3 = new MSS.Library.Control.MSSLabel(this.components);
            this.IntBoxCalibrationDuration = new MSS.Library.Control.MSSIntBox(this.components);
            this.mssLabel4 = new MSS.Library.Control.MSSLabel(this.components);
            this.mssLabel5 = new MSS.Library.Control.MSSLabel(this.components);
            this.TextBoxDescription = new MSS.Library.Control.MSSTextBox(this.components);
            this.mssLabel6 = new MSS.Library.Control.MSSLabel(this.components);
            this.TextBoxModel = new MSS.Library.Control.MSSTextBox(this.components);
            this.IntBoxPMax = new MSS.Library.Control.MSSIntBox(this.components);
            this.CheckBoxHMIState = new MSS.Library.Control.MSSCheckBox(this.components);
            this.mssGroupPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonBarNewBar
            // 
            // 
            // 
            // 
            this.ribbonBarNewBar.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBarNewBar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBarNewBar.Location = new System.Drawing.Point(0, 330);
            this.ribbonBarNewBar.Size = new System.Drawing.Size(492, 57);
            this.ribbonBarNewBar.TabIndex = 2;
            // 
            // 
            // 
            this.ribbonBarNewBar.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBarNewBar.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // mssGroupPanel1
            // 
            this.mssGroupPanel1.Controls.Add(this.IntBoxPMax);
            this.mssGroupPanel1.Controls.Add(this.IntBoxCalibrationDuration);
            this.mssGroupPanel1.Controls.Add(this.mssLabel4);
            this.mssGroupPanel1.Controls.Add(this.mssLabel3);
            this.mssGroupPanel1.Controls.Add(this.CheckBoxHMIState);
            this.mssGroupPanel1.Controls.Add(this.checkBoxIsActive);
            this.mssGroupPanel1.Controls.Add(this.TextBoxDescription);
            this.mssGroupPanel1.Controls.Add(this.mssLabel5);
            this.mssGroupPanel1.Controls.Add(this.TextBoxModel);
            this.mssGroupPanel1.Controls.Add(this.mssLabel6);
            this.mssGroupPanel1.Controls.Add(this.textBoxBrand);
            this.mssGroupPanel1.Controls.Add(this.label1);
            this.mssGroupPanel1.Size = new System.Drawing.Size(492, 296);
            // 
            // 
            // 
            this.mssGroupPanel1.Style.BackColor = System.Drawing.SystemColors.Control;
            this.mssGroupPanel1.Style.BackColor2 = System.Drawing.SystemColors.Control;
            this.mssGroupPanel1.Style.BackColorGradientAngle = 90;
            this.mssGroupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.mssGroupPanel1.Style.BorderBottomWidth = 1;
            this.mssGroupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.mssGroupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.mssGroupPanel1.Style.BorderLeftWidth = 1;
            this.mssGroupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.mssGroupPanel1.Style.BorderRightWidth = 1;
            this.mssGroupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.mssGroupPanel1.Style.BorderTopWidth = 1;
            this.mssGroupPanel1.Style.CornerDiameter = 4;
            this.mssGroupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.mssGroupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.mssGroupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.mssGroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.mssGroupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.mssGroupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mssGroupPanel1.TabIndex = 1;
            // 
            // buttonItemOK
            // 
            this.buttonItemOK.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // textBoxBrand
            // 
            this.textBoxBrand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.textBoxBrand.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxBrand.Font = new System.Drawing.Font("Tahoma", 8F);
            this.textBoxBrand.Location = new System.Drawing.Point(33, 59);
            this.textBoxBrand.Name = "textBoxBrand";
            this.textBoxBrand.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxBrand.Size = new System.Drawing.Size(319, 13);
            this.textBoxBrand.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.label1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(364, 60);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(23, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "برند:";
            // 
            // checkBoxIsActive
            // 
            this.checkBoxIsActive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxIsActive.AutoSize = true;
            this.checkBoxIsActive.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.checkBoxIsActive.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkBoxIsActive.Checked = true;
            this.checkBoxIsActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxIsActive.CheckValue = "Y";
            this.checkBoxIsActive.Font = new System.Drawing.Font("Tahoma", 8F);
            this.checkBoxIsActive.Location = new System.Drawing.Point(310, 254);
            this.checkBoxIsActive.Name = "checkBoxIsActive";
            this.checkBoxIsActive.Size = new System.Drawing.Size(42, 15);
            this.checkBoxIsActive.TabIndex = 7;
            this.checkBoxIsActive.Text = "فعال";
            // 
            // mssLabel3
            // 
            this.mssLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mssLabel3.AutoSize = true;
            this.mssLabel3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.mssLabel3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mssLabel3.Font = new System.Drawing.Font("Tahoma", 8F);
            this.mssLabel3.ForeColor = System.Drawing.Color.Black;
            this.mssLabel3.Location = new System.Drawing.Point(364, 126);
            this.mssLabel3.Name = "mssLabel3";
            this.mssLabel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mssLabel3.Size = new System.Drawing.Size(80, 15);
            this.mssLabel3.TabIndex = 61;
            this.mssLabel3.Text = "فشار بیشینه psi:";
            // 
            // IntBoxCalibrationDuration
            // 
            this.IntBoxCalibrationDuration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IntBoxCalibrationDuration.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.General;
            this.IntBoxCalibrationDuration.Location = new System.Drawing.Point(33, 160);
            this.IntBoxCalibrationDuration.Name = "IntBoxCalibrationDuration";
            this.IntBoxCalibrationDuration.Size = new System.Drawing.Size(319, 20);
            this.IntBoxCalibrationDuration.TabIndex = 5;
            this.IntBoxCalibrationDuration.Text = "0";
            this.IntBoxCalibrationDuration.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
            this.IntBoxCalibrationDuration.Value = 0;
            this.IntBoxCalibrationDuration.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int32;
            // 
            // mssLabel4
            // 
            this.mssLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mssLabel4.AutoSize = true;
            this.mssLabel4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.mssLabel4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mssLabel4.Font = new System.Drawing.Font("Tahoma", 8F);
            this.mssLabel4.ForeColor = System.Drawing.Color.Black;
            this.mssLabel4.Location = new System.Drawing.Point(364, 162);
            this.mssLabel4.Name = "mssLabel4";
            this.mssLabel4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mssLabel4.Size = new System.Drawing.Size(105, 15);
            this.mssLabel4.TabIndex = 61;
            this.mssLabel4.Text = "دوره کالیبراسیون (ماه):";
            // 
            // mssLabel5
            // 
            this.mssLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mssLabel5.AutoSize = true;
            this.mssLabel5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.mssLabel5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mssLabel5.Font = new System.Drawing.Font("Tahoma", 8F);
            this.mssLabel5.ForeColor = System.Drawing.Color.Black;
            this.mssLabel5.Location = new System.Drawing.Point(364, 198);
            this.mssLabel5.Name = "mssLabel5";
            this.mssLabel5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mssLabel5.Size = new System.Drawing.Size(45, 15);
            this.mssLabel5.TabIndex = 2;
            this.mssLabel5.Text = "توضیحات:";
            // 
            // TextBoxDescription
            // 
            this.TextBoxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.TextBoxDescription.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxDescription.Font = new System.Drawing.Font("Tahoma", 8F);
            this.TextBoxDescription.Location = new System.Drawing.Point(33, 197);
            this.TextBoxDescription.Multiline = true;
            this.TextBoxDescription.Name = "TextBoxDescription";
            this.TextBoxDescription.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TextBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBoxDescription.Size = new System.Drawing.Size(319, 41);
            this.TextBoxDescription.TabIndex = 6;
            // 
            // mssLabel6
            // 
            this.mssLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mssLabel6.AutoSize = true;
            this.mssLabel6.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.mssLabel6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mssLabel6.Font = new System.Drawing.Font("Tahoma", 8F);
            this.mssLabel6.ForeColor = System.Drawing.Color.Black;
            this.mssLabel6.Location = new System.Drawing.Point(364, 29);
            this.mssLabel6.Name = "mssLabel6";
            this.mssLabel6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mssLabel6.Size = new System.Drawing.Size(24, 15);
            this.mssLabel6.TabIndex = 2;
            this.mssLabel6.Text = "مدل:";
            // 
            // TextBoxModel
            // 
            this.TextBoxModel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.TextBoxModel.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxModel.Font = new System.Drawing.Font("Tahoma", 8F);
            this.TextBoxModel.Location = new System.Drawing.Point(33, 28);
            this.TextBoxModel.Name = "TextBoxModel";
            this.TextBoxModel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TextBoxModel.Size = new System.Drawing.Size(319, 13);
            this.TextBoxModel.TabIndex = 1;
            // 
            // IntBoxPMax
            // 
            this.IntBoxPMax.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IntBoxPMax.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.General;
            this.IntBoxPMax.Location = new System.Drawing.Point(33, 126);
            this.IntBoxPMax.Name = "IntBoxPMax";
            this.IntBoxPMax.Size = new System.Drawing.Size(319, 20);
            this.IntBoxPMax.TabIndex = 4;
            this.IntBoxPMax.Text = "0";
            this.IntBoxPMax.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
            this.IntBoxPMax.Value = 0;
            this.IntBoxPMax.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int32;
            // 
            // CheckBoxHMIState
            // 
            this.CheckBoxHMIState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckBoxHMIState.AutoSize = true;
            this.CheckBoxHMIState.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.CheckBoxHMIState.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.CheckBoxHMIState.Checked = true;
            this.CheckBoxHMIState.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBoxHMIState.CheckValue = "Y";
            this.CheckBoxHMIState.Font = new System.Drawing.Font("Tahoma", 8F);
            this.CheckBoxHMIState.Location = new System.Drawing.Point(270, 93);
            this.CheckBoxHMIState.Name = "CheckBoxHMIState";
            this.CheckBoxHMIState.Size = new System.Drawing.Size(82, 15);
            this.CheckBoxHMIState.TabIndex = 3;
            this.CheckBoxHMIState.Text = "صفحه نمایش";
            // 
            // PressTransAdd_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(492, 387);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 197);
            this.Name = "PressTransAdd_Frm";
            this.Text = "ترانسمیتر فشار";
            this.Load += new System.EventHandler(this.PressTransAdd_Frm_Load);
            this.mssGroupPanel1.ResumeLayout(false);
            this.mssGroupPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MSSTextBox textBoxBrand;
        private MSSLabel label1;
        private MSSCheckBox checkBoxIsActive;
        private MSSLabel mssLabel3;
        private MSSIntBox IntBoxCalibrationDuration;
        private MSSLabel mssLabel4;
        private MSSTextBox TextBoxDescription;
        private MSSLabel mssLabel5;
        private MSSIntBox IntBoxPMax;
        private MSSTextBox TextBoxModel;
        private MSSLabel mssLabel6;
        private MSSCheckBox CheckBoxHMIState;


    }
}
