
using MSS.Library.Control;
namespace GasStationManagement.View.MainForms.PressGage
{
    partial class PressGageSupplyAdd_Frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PressGageSupplyAdd_Frm));
            this.textBoxPressGage_Id = new MSS.Library.Control.MSSTextBox(this.components);
            this.label1 = new MSS.Library.Control.MSSLabel(this.components);
            this.checkBoxIsActive = new MSS.Library.Control.MSSCheckBox(this.components);
            this.IntBoxPrice = new MSS.Library.Control.MSSIntBox(this.components);
            this.mssLabel4 = new MSS.Library.Control.MSSLabel(this.components);
            this.mssLabel5 = new MSS.Library.Control.MSSLabel(this.components);
            this.TextBoxDescription = new MSS.Library.Control.MSSTextBox(this.components);
            this.mssLabel6 = new MSS.Library.Control.MSSLabel(this.components);
            this.TextBoxPressGageSerialNo = new MSS.Library.Control.MSSTextBox(this.components);
            this.DatePickerSupplyDate = new MSS.Library.Control.MSSDatePicker(this.components);
            this.label2 = new MSS.Library.Control.MSSLabel(this.components);
            this.ButtonSuppliers_Id = new MSS.Library.Control.MSSButton(this.components);
            this.mssLabel11 = new MSS.Library.Control.MSSLabel(this.components);
            this.TextBoxSuppliers_Id = new MSS.Library.Control.MSSTextBox(this.components);
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
            this.ribbonBarNewBar.Location = new System.Drawing.Point(0, 318);
            this.ribbonBarNewBar.Size = new System.Drawing.Size(469, 57);
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
            this.mssGroupPanel1.Controls.Add(this.ButtonSuppliers_Id);
            this.mssGroupPanel1.Controls.Add(this.mssLabel11);
            this.mssGroupPanel1.Controls.Add(this.TextBoxSuppliers_Id);
            this.mssGroupPanel1.Controls.Add(this.DatePickerSupplyDate);
            this.mssGroupPanel1.Controls.Add(this.label2);
            this.mssGroupPanel1.Controls.Add(this.IntBoxPrice);
            this.mssGroupPanel1.Controls.Add(this.mssLabel4);
            this.mssGroupPanel1.Controls.Add(this.checkBoxIsActive);
            this.mssGroupPanel1.Controls.Add(this.TextBoxDescription);
            this.mssGroupPanel1.Controls.Add(this.mssLabel5);
            this.mssGroupPanel1.Controls.Add(this.TextBoxPressGageSerialNo);
            this.mssGroupPanel1.Controls.Add(this.mssLabel6);
            this.mssGroupPanel1.Controls.Add(this.textBoxPressGage_Id);
            this.mssGroupPanel1.Controls.Add(this.label1);
            this.mssGroupPanel1.Size = new System.Drawing.Size(469, 284);
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
            // textBoxPressGage_Id
            // 
            this.textBoxPressGage_Id.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.textBoxPressGage_Id.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxPressGage_Id.Enabled = false;
            this.textBoxPressGage_Id.Font = new System.Drawing.Font("Tahoma", 8F);
            this.textBoxPressGage_Id.Location = new System.Drawing.Point(35, 19);
            this.textBoxPressGage_Id.Name = "textBoxPressGage_Id";
            this.textBoxPressGage_Id.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxPressGage_Id.Size = new System.Drawing.Size(296, 13);
            this.textBoxPressGage_Id.TabIndex = 1;
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
            this.label1.Location = new System.Drawing.Point(347, 18);
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
            this.checkBoxIsActive.Location = new System.Drawing.Point(287, 242);
            this.checkBoxIsActive.Name = "checkBoxIsActive";
            this.checkBoxIsActive.Size = new System.Drawing.Size(42, 15);
            this.checkBoxIsActive.TabIndex = 8;
            this.checkBoxIsActive.Text = "فعال";
            // 
            // IntBoxPrice
            // 
            this.IntBoxPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IntBoxPrice.Location = new System.Drawing.Point(35, 117);
            this.IntBoxPrice.Name = "IntBoxPrice";
            this.IntBoxPrice.Size = new System.Drawing.Size(296, 20);
            this.IntBoxPrice.TabIndex = 4;
            this.IntBoxPrice.Text = "0";
            this.IntBoxPrice.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
            this.IntBoxPrice.Value = ((long)(0));
            this.IntBoxPrice.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int64;
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
            this.mssLabel4.Location = new System.Drawing.Point(347, 117);
            this.mssLabel4.Name = "mssLabel4";
            this.mssLabel4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mssLabel4.Size = new System.Drawing.Size(83, 15);
            this.mssLabel4.TabIndex = 61;
            this.mssLabel4.Text = "قیمت خرید (ریال):";
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
            this.mssLabel5.Location = new System.Drawing.Point(347, 186);
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
            this.TextBoxDescription.Location = new System.Drawing.Point(35, 187);
            this.TextBoxDescription.Multiline = true;
            this.TextBoxDescription.Name = "TextBoxDescription";
            this.TextBoxDescription.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TextBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBoxDescription.Size = new System.Drawing.Size(296, 49);
            this.TextBoxDescription.TabIndex = 7;
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
            this.mssLabel6.Location = new System.Drawing.Point(347, 51);
            this.mssLabel6.Name = "mssLabel6";
            this.mssLabel6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mssLabel6.Size = new System.Drawing.Size(34, 15);
            this.mssLabel6.TabIndex = 2;
            this.mssLabel6.Text = "سریال:";
            // 
            // TextBoxPressGageSerialNo
            // 
            this.TextBoxPressGageSerialNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.TextBoxPressGageSerialNo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxPressGageSerialNo.Font = new System.Drawing.Font("Tahoma", 8F);
            this.TextBoxPressGageSerialNo.Location = new System.Drawing.Point(35, 50);
            this.TextBoxPressGageSerialNo.Name = "TextBoxPressGageSerialNo";
            this.TextBoxPressGageSerialNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TextBoxPressGageSerialNo.Size = new System.Drawing.Size(296, 13);
            this.TextBoxPressGageSerialNo.TabIndex = 2;
            // 
            // DatePickerSupplyDate
            // 
            this.DatePickerSupplyDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DatePickerSupplyDate.BackColor = System.Drawing.Color.White;
            this.DatePickerSupplyDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.DatePickerSupplyDate.Location = new System.Drawing.Point(216, 81);
            this.DatePickerSupplyDate.Name = "DatePickerSupplyDate";
            this.DatePickerSupplyDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DatePickerSupplyDate.ShowTime = false;
            this.DatePickerSupplyDate.Size = new System.Drawing.Size(115, 18);
            this.DatePickerSupplyDate.TabIndex = 3;
            this.DatePickerSupplyDate.Text = "mssDatePicker1";
            this.DatePickerSupplyDate.UseFarsiDigits = true;
            this.DatePickerSupplyDate.Value = ((KagNetComponents2.KagPersianDate)(resources.GetObject("DatePickerSupplyDate.Value")));
            this.DatePickerSupplyDate.ValueEn = new System.DateTime(2015, 9, 20, 19, 9, 34, 0);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.label2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(347, 84);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 63;
            this.label2.Text = "تاریخ خرید:";
            // 
            // ButtonSuppliers_Id
            // 
            this.ButtonSuppliers_Id.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonSuppliers_Id.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonSuppliers_Id.Location = new System.Drawing.Point(35, 152);
            this.ButtonSuppliers_Id.Name = "ButtonSuppliers_Id";
            this.ButtonSuppliers_Id.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ButtonSuppliers_Id.Size = new System.Drawing.Size(26, 21);
            this.ButtonSuppliers_Id.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonSuppliers_Id.TabIndex = 6;
            this.ButtonSuppliers_Id.Text = "...";
            this.ButtonSuppliers_Id.Click += new System.EventHandler(this.ButtonSuppliers_Id_Click);
            // 
            // mssLabel11
            // 
            this.mssLabel11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mssLabel11.AutoSize = true;
            this.mssLabel11.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.mssLabel11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mssLabel11.Font = new System.Drawing.Font("Tahoma", 8F);
            this.mssLabel11.ForeColor = System.Drawing.Color.Black;
            this.mssLabel11.Location = new System.Drawing.Point(347, 153);
            this.mssLabel11.Name = "mssLabel11";
            this.mssLabel11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mssLabel11.Size = new System.Drawing.Size(56, 15);
            this.mssLabel11.TabIndex = 99;
            this.mssLabel11.Text = "تامین کننده:";
            // 
            // TextBoxSuppliers_Id
            // 
            this.TextBoxSuppliers_Id.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.TextBoxSuppliers_Id.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxSuppliers_Id.Location = new System.Drawing.Point(67, 156);
            this.TextBoxSuppliers_Id.Name = "TextBoxSuppliers_Id";
            this.TextBoxSuppliers_Id.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TextBoxSuppliers_Id.Size = new System.Drawing.Size(262, 13);
            this.TextBoxSuppliers_Id.TabIndex = 5;
            // 
            // PressGageSupplyAdd_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(469, 375);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 197);
            this.Name = "PressGageSupplyAdd_Frm";
            this.Text = "تامین گیج فشار";
            this.Load += new System.EventHandler(this.PressGageSupplyAdd_Frm_Load);
            this.mssGroupPanel1.ResumeLayout(false);
            this.mssGroupPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MSSTextBox textBoxPressGage_Id;
        private MSSLabel label1;
        private MSSCheckBox checkBoxIsActive;
        private MSSIntBox IntBoxPrice;
        private MSSLabel mssLabel4;
        private MSSTextBox TextBoxDescription;
        private MSSLabel mssLabel5;
        private MSSTextBox TextBoxPressGageSerialNo;
        private MSSLabel mssLabel6;
        private MSSDatePicker DatePickerSupplyDate;
        private MSSLabel label2;
        private MSSButton ButtonSuppliers_Id;
        private MSSLabel mssLabel11;
        private MSSTextBox TextBoxSuppliers_Id;


    }
}
