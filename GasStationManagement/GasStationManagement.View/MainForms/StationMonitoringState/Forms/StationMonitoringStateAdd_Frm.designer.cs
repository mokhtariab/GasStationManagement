
using MSS.Library.Control;
namespace GasStationManagement.View.MainForms.StationMonitoringState
{
    partial class StationMonitoringStateAdd_Frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StationMonitoringStateAdd_Frm));
            this.checkBoxIsActive = new MSS.Library.Control.MSSCheckBox(this.components);
            this.mssLabel5 = new MSS.Library.Control.MSSLabel(this.components);
            this.TextBoxDescription = new MSS.Library.Control.MSSTextBox(this.components);
            this.mssLabel16 = new MSS.Library.Control.MSSLabel(this.components);
            this.ComboBoxMonitoringSysState_Id = new MSS.Library.Control.MSSComboBox();
            this.mssLabel17 = new MSS.Library.Control.MSSLabel(this.components);
            this.DatePickerMonitoringSysExeDate = new MSS.Library.Control.MSSDatePicker(this.components);
            this.mssLabel18 = new MSS.Library.Control.MSSLabel(this.components);
            this.TextBoxSuppliers_Id = new MSS.Library.Control.MSSTextBox(this.components);
            this.ButtonSuppliers_Id = new MSS.Library.Control.MSSButton(this.components);
            this.mssLabel14 = new MSS.Library.Control.MSSLabel(this.components);
            this.ComboBoxStationLinkType_Id = new MSS.Library.Control.MSSComboBox();
            this.mssPanel2 = new MSS.Library.Control.MSSPanel(this.components);
            this.mssLabel1 = new MSS.Library.Control.MSSLabel(this.components);
            this.DatePickerChangeStateDate = new MSS.Library.Control.MSSDatePicker(this.components);
            this.mssPanel3 = new MSS.Library.Control.MSSPanel(this.components);
            this.tableLayoutPanelVisit = new System.Windows.Forms.TableLayoutPanel();
            this.groupPanel_All = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.buttonAddParameter = new DevComponents.DotNetBar.ButtonX();
            this.mssPanel4 = new MSS.Library.Control.MSSPanel(this.components);
            this.mssGroupPanel1.SuspendLayout();
            this.mssPanel2.SuspendLayout();
            this.mssPanel3.SuspendLayout();
            this.groupPanel_All.SuspendLayout();
            this.mssPanel4.SuspendLayout();
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
            this.ribbonBarNewBar.Location = new System.Drawing.Point(0, 439);
            this.ribbonBarNewBar.Size = new System.Drawing.Size(715, 57);
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
            this.mssGroupPanel1.Controls.Add(this.mssPanel4);
            this.mssGroupPanel1.Controls.Add(this.mssPanel3);
            this.mssGroupPanel1.Controls.Add(this.mssPanel2);
            this.mssGroupPanel1.Size = new System.Drawing.Size(715, 405);
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
            // checkBoxIsActive
            // 
            this.checkBoxIsActive.AutoSize = true;
            this.checkBoxIsActive.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.checkBoxIsActive.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkBoxIsActive.Checked = true;
            this.checkBoxIsActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxIsActive.CheckValue = "Y";
            this.checkBoxIsActive.Enabled = false;
            this.checkBoxIsActive.Font = new System.Drawing.Font("Tahoma", 8F);
            this.checkBoxIsActive.Location = new System.Drawing.Point(47, 16);
            this.checkBoxIsActive.Name = "checkBoxIsActive";
            this.checkBoxIsActive.Size = new System.Drawing.Size(42, 15);
            this.checkBoxIsActive.TabIndex = 59;
            this.checkBoxIsActive.Text = "فعال";
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
            this.mssLabel5.Location = new System.Drawing.Point(555, 37);
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
            this.TextBoxDescription.Location = new System.Drawing.Point(22, 36);
            this.TextBoxDescription.Multiline = true;
            this.TextBoxDescription.Name = "TextBoxDescription";
            this.TextBoxDescription.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TextBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBoxDescription.Size = new System.Drawing.Size(525, 36);
            this.TextBoxDescription.TabIndex = 1;
            // 
            // mssLabel16
            // 
            this.mssLabel16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mssLabel16.AutoSize = true;
            this.mssLabel16.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.mssLabel16.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mssLabel16.Font = new System.Drawing.Font("Tahoma", 8F);
            this.mssLabel16.ForeColor = System.Drawing.Color.Black;
            this.mssLabel16.Location = new System.Drawing.Point(555, 13);
            this.mssLabel16.Name = "mssLabel16";
            this.mssLabel16.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mssLabel16.Size = new System.Drawing.Size(126, 15);
            this.mssLabel16.TabIndex = 76;
            this.mssLabel16.Text = "وضعیت سیستم مانیتورینگ:";
            // 
            // ComboBoxMonitoringSysState_Id
            // 
            this.ComboBoxMonitoringSysState_Id.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxMonitoringSysState_Id.DisplayMember = "Text";
            this.ComboBoxMonitoringSysState_Id.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxMonitoringSysState_Id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxMonitoringSysState_Id.FormattingEnabled = true;
            this.ComboBoxMonitoringSysState_Id.ItemHeight = 14;
            this.ComboBoxMonitoringSysState_Id.Location = new System.Drawing.Point(312, 10);
            this.ComboBoxMonitoringSysState_Id.Name = "ComboBoxMonitoringSysState_Id";
            this.ComboBoxMonitoringSysState_Id.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ComboBoxMonitoringSysState_Id.Size = new System.Drawing.Size(235, 20);
            this.ComboBoxMonitoringSysState_Id.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ComboBoxMonitoringSysState_Id.TabIndex = 1;
            // 
            // mssLabel17
            // 
            this.mssLabel17.AutoSize = true;
            this.mssLabel17.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.mssLabel17.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mssLabel17.Font = new System.Drawing.Font("Tahoma", 8F);
            this.mssLabel17.ForeColor = System.Drawing.Color.Black;
            this.mssLabel17.Location = new System.Drawing.Point(178, 10);
            this.mssLabel17.Name = "mssLabel17";
            this.mssLabel17.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mssLabel17.Size = new System.Drawing.Size(47, 15);
            this.mssLabel17.TabIndex = 66;
            this.mssLabel17.Text = "تاریخ اجرا:";
            // 
            // DatePickerMonitoringSysExeDate
            // 
            this.DatePickerMonitoringSysExeDate.BackColor = System.Drawing.Color.White;
            this.DatePickerMonitoringSysExeDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.DatePickerMonitoringSysExeDate.Location = new System.Drawing.Point(48, 10);
            this.DatePickerMonitoringSysExeDate.Name = "DatePickerMonitoringSysExeDate";
            this.DatePickerMonitoringSysExeDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DatePickerMonitoringSysExeDate.ShowTime = false;
            this.DatePickerMonitoringSysExeDate.Size = new System.Drawing.Size(115, 18);
            this.DatePickerMonitoringSysExeDate.TabIndex = 2;
            this.DatePickerMonitoringSysExeDate.Text = "mssDatePicker1";
            this.DatePickerMonitoringSysExeDate.UseFarsiDigits = true;
            this.DatePickerMonitoringSysExeDate.Value = ((KagNetComponents2.KagPersianDate)(resources.GetObject("DatePickerMonitoringSysExeDate.Value")));
            this.DatePickerMonitoringSysExeDate.ValueEn = new System.DateTime(2015, 9, 20, 19, 9, 34, 0);
            // 
            // mssLabel18
            // 
            this.mssLabel18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mssLabel18.AutoSize = true;
            this.mssLabel18.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.mssLabel18.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mssLabel18.Font = new System.Drawing.Font("Tahoma", 8F);
            this.mssLabel18.ForeColor = System.Drawing.Color.Black;
            this.mssLabel18.Location = new System.Drawing.Point(555, 40);
            this.mssLabel18.Name = "mssLabel18";
            this.mssLabel18.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mssLabel18.Size = new System.Drawing.Size(121, 15);
            this.mssLabel18.TabIndex = 102;
            this.mssLabel18.Text = "مجری سیستم مانیتورینگ:";
            // 
            // TextBoxSuppliers_Id
            // 
            this.TextBoxSuppliers_Id.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.TextBoxSuppliers_Id.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxSuppliers_Id.Enabled = false;
            this.TextBoxSuppliers_Id.Location = new System.Drawing.Point(312, 41);
            this.TextBoxSuppliers_Id.Name = "TextBoxSuppliers_Id";
            this.TextBoxSuppliers_Id.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TextBoxSuppliers_Id.Size = new System.Drawing.Size(235, 13);
            this.TextBoxSuppliers_Id.TabIndex = 3;
            // 
            // ButtonSuppliers_Id
            // 
            this.ButtonSuppliers_Id.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonSuppliers_Id.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonSuppliers_Id.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonSuppliers_Id.Location = new System.Drawing.Point(280, 36);
            this.ButtonSuppliers_Id.Name = "ButtonSuppliers_Id";
            this.ButtonSuppliers_Id.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ButtonSuppliers_Id.Size = new System.Drawing.Size(26, 21);
            this.ButtonSuppliers_Id.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonSuppliers_Id.TabIndex = 4;
            this.ButtonSuppliers_Id.Text = "...";
            this.ButtonSuppliers_Id.Click += new System.EventHandler(this.ButtonSuppliers_Id_Click);
            // 
            // mssLabel14
            // 
            this.mssLabel14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mssLabel14.AutoSize = true;
            this.mssLabel14.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.mssLabel14.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mssLabel14.Font = new System.Drawing.Font("Tahoma", 8F);
            this.mssLabel14.ForeColor = System.Drawing.Color.Black;
            this.mssLabel14.Location = new System.Drawing.Point(555, 68);
            this.mssLabel14.Name = "mssLabel14";
            this.mssLabel14.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mssLabel14.Size = new System.Drawing.Size(122, 15);
            this.mssLabel14.TabIndex = 104;
            this.mssLabel14.Text = "نوع بستر ارتباطی ایستگاه:";
            // 
            // ComboBoxStationLinkType_Id
            // 
            this.ComboBoxStationLinkType_Id.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxStationLinkType_Id.DisplayMember = "Text";
            this.ComboBoxStationLinkType_Id.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxStationLinkType_Id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxStationLinkType_Id.FormattingEnabled = true;
            this.ComboBoxStationLinkType_Id.ItemHeight = 14;
            this.ComboBoxStationLinkType_Id.Location = new System.Drawing.Point(312, 65);
            this.ComboBoxStationLinkType_Id.Name = "ComboBoxStationLinkType_Id";
            this.ComboBoxStationLinkType_Id.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ComboBoxStationLinkType_Id.Size = new System.Drawing.Size(235, 20);
            this.ComboBoxStationLinkType_Id.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ComboBoxStationLinkType_Id.TabIndex = 103;
            // 
            // mssPanel2
            // 
            this.mssPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mssPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.mssPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.mssPanel2.Controls.Add(this.mssLabel1);
            this.mssPanel2.Controls.Add(this.DatePickerChangeStateDate);
            this.mssPanel2.Controls.Add(this.mssLabel5);
            this.mssPanel2.Controls.Add(this.TextBoxDescription);
            this.mssPanel2.Controls.Add(this.checkBoxIsActive);
            this.mssPanel2.Location = new System.Drawing.Point(5, 105);
            this.mssPanel2.Name = "mssPanel2";
            this.mssPanel2.Size = new System.Drawing.Size(698, 86);
            this.mssPanel2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.mssPanel2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.mssPanel2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.mssPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.mssPanel2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.mssPanel2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.mssPanel2.Style.GradientAngle = 90;
            this.mssPanel2.TabIndex = 64;
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
            this.mssLabel1.Location = new System.Drawing.Point(555, 16);
            this.mssLabel1.Name = "mssLabel1";
            this.mssLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mssLabel1.Size = new System.Drawing.Size(85, 15);
            this.mssLabel1.TabIndex = 68;
            this.mssLabel1.Text = "تاریخ تغییر وضعیت:";
            // 
            // DatePickerChangeStateDate
            // 
            this.DatePickerChangeStateDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DatePickerChangeStateDate.BackColor = System.Drawing.Color.White;
            this.DatePickerChangeStateDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.DatePickerChangeStateDate.Location = new System.Drawing.Point(432, 13);
            this.DatePickerChangeStateDate.Name = "DatePickerChangeStateDate";
            this.DatePickerChangeStateDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DatePickerChangeStateDate.ShowTime = false;
            this.DatePickerChangeStateDate.Size = new System.Drawing.Size(115, 18);
            this.DatePickerChangeStateDate.TabIndex = 67;
            this.DatePickerChangeStateDate.Text = "mssDatePicker1";
            this.DatePickerChangeStateDate.UseFarsiDigits = true;
            this.DatePickerChangeStateDate.Value = ((KagNetComponents2.KagPersianDate)(resources.GetObject("DatePickerChangeStateDate.Value")));
            this.DatePickerChangeStateDate.ValueEn = new System.DateTime(2015, 9, 20, 19, 9, 34, 0);
            // 
            // mssPanel3
            // 
            this.mssPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mssPanel3.CanvasColor = System.Drawing.SystemColors.Control;
            this.mssPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.mssPanel3.Controls.Add(this.tableLayoutPanelVisit);
            this.mssPanel3.Controls.Add(this.groupPanel_All);
            this.mssPanel3.Location = new System.Drawing.Point(5, 198);
            this.mssPanel3.Name = "mssPanel3";
            this.mssPanel3.Size = new System.Drawing.Size(698, 195);
            this.mssPanel3.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.mssPanel3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.mssPanel3.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.mssPanel3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.mssPanel3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.mssPanel3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.mssPanel3.Style.GradientAngle = 90;
            this.mssPanel3.TabIndex = 65;
            // 
            // tableLayoutPanelVisit
            // 
            this.tableLayoutPanelVisit.AutoScroll = true;
            this.tableLayoutPanelVisit.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tableLayoutPanelVisit.ColumnCount = 1;
            this.tableLayoutPanelVisit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelVisit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelVisit.Location = new System.Drawing.Point(0, 36);
            this.tableLayoutPanelVisit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanelVisit.Name = "tableLayoutPanelVisit";
            this.tableLayoutPanelVisit.RowCount = 1;
            this.tableLayoutPanelVisit.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelVisit.Size = new System.Drawing.Size(698, 159);
            this.tableLayoutPanelVisit.TabIndex = 7;
            // 
            // groupPanel_All
            // 
            this.groupPanel_All.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel_All.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel_All.Controls.Add(this.buttonAddParameter);
            this.groupPanel_All.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanel_All.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel_All.IsShadowEnabled = true;
            this.groupPanel_All.Location = new System.Drawing.Point(0, 0);
            this.groupPanel_All.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupPanel_All.Name = "groupPanel_All";
            this.groupPanel_All.Size = new System.Drawing.Size(698, 36);
            // 
            // 
            // 
            this.groupPanel_All.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel_All.Style.BackColorGradientAngle = 90;
            this.groupPanel_All.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel_All.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_All.Style.BorderBottomWidth = 1;
            this.groupPanel_All.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel_All.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_All.Style.BorderLeftWidth = 1;
            this.groupPanel_All.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_All.Style.BorderRightWidth = 1;
            this.groupPanel_All.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_All.Style.BorderTopWidth = 1;
            this.groupPanel_All.Style.CornerDiameter = 4;
            this.groupPanel_All.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel_All.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel_All.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel_All.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel_All.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel_All.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel_All.TabIndex = 2;
            // 
            // buttonAddParameter
            // 
            this.buttonAddParameter.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonAddParameter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddParameter.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonAddParameter.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonAddParameter.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddParameter.Image")));
            this.buttonAddParameter.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.buttonAddParameter.Location = new System.Drawing.Point(477, 2);
            this.buttonAddParameter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddParameter.Name = "buttonAddParameter";
            this.buttonAddParameter.Size = new System.Drawing.Size(195, 26);
            this.buttonAddParameter.TabIndex = 71;
            this.buttonAddParameter.Text = "اضافه کردن پارامتر";
            this.buttonAddParameter.TextColor = System.Drawing.Color.Black;
            this.buttonAddParameter.Click += new System.EventHandler(this.buttonAddParameter_Click);
            // 
            // mssPanel4
            // 
            this.mssPanel4.CanvasColor = System.Drawing.SystemColors.Control;
            this.mssPanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.mssPanel4.Controls.Add(this.mssLabel14);
            this.mssPanel4.Controls.Add(this.mssLabel16);
            this.mssPanel4.Controls.Add(this.DatePickerMonitoringSysExeDate);
            this.mssPanel4.Controls.Add(this.ComboBoxStationLinkType_Id);
            this.mssPanel4.Controls.Add(this.mssLabel17);
            this.mssPanel4.Controls.Add(this.ButtonSuppliers_Id);
            this.mssPanel4.Controls.Add(this.mssLabel18);
            this.mssPanel4.Controls.Add(this.TextBoxSuppliers_Id);
            this.mssPanel4.Controls.Add(this.ComboBoxMonitoringSysState_Id);
            this.mssPanel4.Location = new System.Drawing.Point(5, 5);
            this.mssPanel4.Name = "mssPanel4";
            this.mssPanel4.Size = new System.Drawing.Size(698, 94);
            this.mssPanel4.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.mssPanel4.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.mssPanel4.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.mssPanel4.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.mssPanel4.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.mssPanel4.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.mssPanel4.Style.GradientAngle = 90;
            this.mssPanel4.TabIndex = 66;
            // 
            // StationMonitoringStateAdd_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(715, 496);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 197);
            this.Name = "StationMonitoringStateAdd_Frm";
            this.Text = "وضعیت مانیتورینگ ایستگاه";
            this.Load += new System.EventHandler(this.StationMonitoringStateAdd_Frm_Load);
            this.mssGroupPanel1.ResumeLayout(false);
            this.mssPanel2.ResumeLayout(false);
            this.mssPanel2.PerformLayout();
            this.mssPanel3.ResumeLayout(false);
            this.groupPanel_All.ResumeLayout(false);
            this.mssPanel4.ResumeLayout(false);
            this.mssPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MSSCheckBox checkBoxIsActive;
        private MSSTextBox TextBoxDescription;
        private MSSLabel mssLabel5;
        private MSSLabel mssLabel16;
        private MSSComboBox ComboBoxMonitoringSysState_Id;
        private MSSLabel mssLabel17;
        private MSSDatePicker DatePickerMonitoringSysExeDate;
        private MSSLabel mssLabel18;
        private MSSTextBox TextBoxSuppliers_Id;
        private MSSButton ButtonSuppliers_Id;
        private MSSPanel mssPanel2;
        private MSSLabel mssLabel14;
        private MSSComboBox ComboBoxStationLinkType_Id;
        private MSSLabel mssLabel1;
        private MSSDatePicker DatePickerChangeStateDate;
        private MSSPanel mssPanel3;
        private MSSPanel mssPanel4;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel_All;
        private DevComponents.DotNetBar.ButtonX buttonAddParameter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelVisit;


    }
}
