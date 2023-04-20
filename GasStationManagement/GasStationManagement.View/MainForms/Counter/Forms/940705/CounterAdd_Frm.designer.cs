
using MSS.Library.Control;
namespace GasStationManagement.View.MainForms.Counter
{
    partial class CounterAdd_Frm
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
            this.ComboBoxSize = new MSS.Library.Control.MSSComboBox();
            this.mssLabel1 = new MSS.Library.Control.MSSLabel(this.components);
            this.ComboBoxClass = new MSS.Library.Control.MSSComboBox();
            this.mssLabel2 = new MSS.Library.Control.MSSLabel(this.components);
            this.ComboBoxGrate = new MSS.Library.Control.MSSComboBox();
            this.mssLabel3 = new MSS.Library.Control.MSSLabel(this.components);
            this.IntBoxCalibrationDuration = new MSS.Library.Control.MSSIntBox(this.components);
            this.mssLabel4 = new MSS.Library.Control.MSSLabel(this.components);
            this.mssLabel5 = new MSS.Library.Control.MSSLabel(this.components);
            this.TextBoxDescription = new MSS.Library.Control.MSSTextBox(this.components);
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
            this.mssGroupPanel1.Controls.Add(this.IntBoxCalibrationDuration);
            this.mssGroupPanel1.Controls.Add(this.mssLabel4);
            this.mssGroupPanel1.Controls.Add(this.mssLabel3);
            this.mssGroupPanel1.Controls.Add(this.mssLabel2);
            this.mssGroupPanel1.Controls.Add(this.mssLabel1);
            this.mssGroupPanel1.Controls.Add(this.ComboBoxGrate);
            this.mssGroupPanel1.Controls.Add(this.ComboBoxClass);
            this.mssGroupPanel1.Controls.Add(this.ComboBoxSize);
            this.mssGroupPanel1.Controls.Add(this.checkBoxIsActive);
            this.mssGroupPanel1.Controls.Add(this.TextBoxDescription);
            this.mssGroupPanel1.Controls.Add(this.mssLabel5);
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
            // 
            // buttonItemOK
            // 
            this.buttonItemOK.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // mssPanel1
            // 
            this.mssPanel1.Size = new System.Drawing.Size(492, 34);
            this.mssPanel1.Style.BackColor1.Color = System.Drawing.Color.White;
            this.mssPanel1.Style.BackColor2.Color = System.Drawing.Color.LightBlue;
            this.mssPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.mssPanel1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.mssPanel1.Style.ForeColor.Color = System.Drawing.Color.Maroon;
            this.mssPanel1.Style.GradientAngle = 90;
            this.mssPanel1.Style.MarginLeft = 15;
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
            this.textBoxBrand.Location = new System.Drawing.Point(33, 19);
            this.textBoxBrand.Name = "textBoxBrand";
            this.textBoxBrand.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxBrand.Size = new System.Drawing.Size(319, 13);
            this.textBoxBrand.TabIndex = 1;
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
            this.label1.Location = new System.Drawing.Point(364, 18);
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
            this.checkBoxIsActive.Font = new System.Drawing.Font("Tahoma", 8F);
            this.checkBoxIsActive.Location = new System.Drawing.Point(310, 254);
            this.checkBoxIsActive.Name = "checkBoxIsActive";
            this.checkBoxIsActive.Size = new System.Drawing.Size(42, 15);
            this.checkBoxIsActive.TabIndex = 59;
            this.checkBoxIsActive.Text = "فعال";
            // 
            // ComboBoxSize
            // 
            this.ComboBoxSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxSize.DisplayMember = "Text";
            this.ComboBoxSize.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxSize.FormattingEnabled = true;
            this.ComboBoxSize.ItemHeight = 14;
            this.ComboBoxSize.Location = new System.Drawing.Point(33, 49);
            this.ComboBoxSize.Name = "ComboBoxSize";
            this.ComboBoxSize.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ComboBoxSize.Size = new System.Drawing.Size(319, 20);
            this.ComboBoxSize.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ComboBoxSize.TabIndex = 60;
            // 
            // mssLabel1
            // 
            this.mssLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mssLabel1.AutoSize = true;
            this.mssLabel1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.mssLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mssLabel1.Font = new System.Drawing.Font("Tahoma", 8F);
            this.mssLabel1.ForeColor = System.Drawing.Color.Black;
            this.mssLabel1.Location = new System.Drawing.Point(364, 54);
            this.mssLabel1.Name = "mssLabel1";
            this.mssLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mssLabel1.Size = new System.Drawing.Size(56, 15);
            this.mssLabel1.TabIndex = 61;
            this.mssLabel1.Text = "سایز (اینچ):";
            // 
            // ComboBoxClass
            // 
            this.ComboBoxClass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxClass.DisplayMember = "Text";
            this.ComboBoxClass.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxClass.FormattingEnabled = true;
            this.ComboBoxClass.ItemHeight = 14;
            this.ComboBoxClass.Location = new System.Drawing.Point(33, 86);
            this.ComboBoxClass.Name = "ComboBoxClass";
            this.ComboBoxClass.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ComboBoxClass.Size = new System.Drawing.Size(319, 20);
            this.ComboBoxClass.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ComboBoxClass.TabIndex = 60;
            // 
            // mssLabel2
            // 
            this.mssLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mssLabel2.AutoSize = true;
            this.mssLabel2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.mssLabel2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mssLabel2.Font = new System.Drawing.Font("Tahoma", 8F);
            this.mssLabel2.ForeColor = System.Drawing.Color.Black;
            this.mssLabel2.Location = new System.Drawing.Point(364, 90);
            this.mssLabel2.Name = "mssLabel2";
            this.mssLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mssLabel2.Size = new System.Drawing.Size(32, 15);
            this.mssLabel2.TabIndex = 61;
            this.mssLabel2.Text = "کلاس:";
            // 
            // ComboBoxGrate
            // 
            this.ComboBoxGrate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxGrate.DisplayMember = "Text";
            this.ComboBoxGrate.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxGrate.FormattingEnabled = true;
            this.ComboBoxGrate.ItemHeight = 14;
            this.ComboBoxGrate.Location = new System.Drawing.Point(33, 123);
            this.ComboBoxGrate.Name = "ComboBoxGrate";
            this.ComboBoxGrate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ComboBoxGrate.Size = new System.Drawing.Size(319, 20);
            this.ComboBoxGrate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ComboBoxGrate.TabIndex = 60;
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
            this.mssLabel3.Text = " m3^h - G Rate:";
            // 
            // IntBoxCalibrationDuration
            // 
            this.IntBoxCalibrationDuration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IntBoxCalibrationDuration.Location = new System.Drawing.Point(33, 160);
            this.IntBoxCalibrationDuration.Name = "IntBoxCalibrationDuration";
            this.IntBoxCalibrationDuration.Size = new System.Drawing.Size(319, 20);
            this.IntBoxCalibrationDuration.TabIndex = 62;
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
            this.TextBoxDescription.TabIndex = 1;
            // 
            // CounterAdd_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(492, 387);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 197);
            this.Name = "CounterAdd_Frm";
            this.Text = "کنتور";
            this.Load += new System.EventHandler(this.CounterAdd_Frm_Load);
            this.mssGroupPanel1.ResumeLayout(false);
            this.mssGroupPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MSSTextBox textBoxBrand;
        private MSSLabel label1;
        private MSSCheckBox checkBoxIsActive;
        private MSSLabel mssLabel1;
        private MSSComboBox ComboBoxSize;
        private MSSLabel mssLabel3;
        private MSSLabel mssLabel2;
        private MSSComboBox ComboBoxGrate;
        private MSSComboBox ComboBoxClass;
        private MSSIntBox IntBoxCalibrationDuration;
        private MSSLabel mssLabel4;
        private MSSTextBox TextBoxDescription;
        private MSSLabel mssLabel5;


    }
}
