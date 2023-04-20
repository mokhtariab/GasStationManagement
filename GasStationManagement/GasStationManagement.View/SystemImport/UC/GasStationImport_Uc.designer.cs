namespace GasStationManagement.View.SystemImport
{
    partial class GasStationImport_Uc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GasStationImport_Uc));
            this.GridViewImportExcel = new Janus.Windows.GridEX.GridEX();
            this.panel2 = new MSS.Library.Control.MSSPanel(this.components);
            this.ComboBoxRan = new MSS.Library.Control.MSSComboBox();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.comboItem3 = new DevComponents.Editors.ComboItem();
            this.mssLabel2 = new MSS.Library.Control.MSSLabel(this.components);
            this.ComboTreeGasStation = new MSS.Library.Control.MSSComboTree();
            this.LabelAddress = new MSS.Library.Control.MSSLabel(this.components);
            this.mssLabel1 = new MSS.Library.Control.MSSLabel(this.components);
            this.label1 = new MSS.Library.Control.MSSLabel(this.components);
            this.buttonPatientID = new MSS.Library.Control.MSSButton(this.components);
            this.textBoxPatientID = new MSS.Library.Control.MSSTextBox(this.components);
            this.buttonImport = new MSS.Library.Control.MSSButton(this.components);
            this.label2 = new MSS.Library.Control.MSSLabel(this.components);
            this.splitter1 = new MSS.Library.Control.MSSExpandableSplitter(this.components);
            this.listViewErrore = new MSS.Library.Control.MSSListView(this.components);
            this.ProgressBarSave = new MSS.Library.Control.MSSProgressBar(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewImportExcel)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridViewImportExcel
            // 
            this.GridViewImportExcel.AlternatingRowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewImportExcel.BuiltInTextsData = "<LocalizableData ID=\"LocalizableStrings\" Collection=\"true\"><RecordNavigator>:ردیف" +
    "|از</RecordNavigator></LocalizableData>";
            this.GridViewImportExcel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewImportExcel.GroupByBoxVisible = false;
            this.GridViewImportExcel.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewImportExcel.Location = new System.Drawing.Point(0, 205);
            this.GridViewImportExcel.Name = "GridViewImportExcel";
            this.GridViewImportExcel.RecordNavigator = true;
            this.GridViewImportExcel.RowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewImportExcel.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition;
            this.GridViewImportExcel.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.GridViewImportExcel.Size = new System.Drawing.Size(893, 235);
            this.GridViewImportExcel.TabIndex = 305;
            this.GridViewImportExcel.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ComboBoxRan);
            this.panel2.Controls.Add(this.mssLabel2);
            this.panel2.Controls.Add(this.ComboTreeGasStation);
            this.panel2.Controls.Add(this.LabelAddress);
            this.panel2.Controls.Add(this.mssLabel1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.buttonPatientID);
            this.panel2.Controls.Add(this.textBoxPatientID);
            this.panel2.Controls.Add(this.buttonImport);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(893, 182);
            this.panel2.TabIndex = 298;
            // 
            // ComboBoxRan
            // 
            this.ComboBoxRan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxRan.DisplayMember = "Text";
            this.ComboBoxRan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxRan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxRan.FormattingEnabled = true;
            this.ComboBoxRan.ItemHeight = 16;
            this.ComboBoxRan.Items.AddRange(new object[] {
            this.comboItem1,
            this.comboItem2,
            this.comboItem3});
            this.ComboBoxRan.Location = new System.Drawing.Point(296, 67);
            this.ComboBoxRan.Name = "ComboBoxRan";
            this.ComboBoxRan.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ComboBoxRan.Size = new System.Drawing.Size(121, 22);
            this.ComboBoxRan.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ComboBoxRan.TabIndex = 76;
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "1";
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "2";
            // 
            // comboItem3
            // 
            this.comboItem3.Text = "3";
            // 
            // mssLabel2
            // 
            this.mssLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mssLabel2.AutoSize = true;
            // 
            // 
            // 
            this.mssLabel2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mssLabel2.ForeColor = System.Drawing.Color.Black;
            this.mssLabel2.Location = new System.Drawing.Point(423, 70);
            this.mssLabel2.Name = "mssLabel2";
            this.mssLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mssLabel2.Size = new System.Drawing.Size(56, 17);
            this.mssLabel2.TabIndex = 74;
            this.mssLabel2.Text = "شماره رن:";
            // 
            // ComboTreeGasStation
            // 
            this.ComboTreeGasStation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboTreeGasStation.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.ComboTreeGasStation.BackgroundStyle.Class = "TextBoxBorder";
            this.ComboTreeGasStation.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ComboTreeGasStation.ButtonDropDown.Visible = true;
            this.ComboTreeGasStation.ColumnsVisible = false;
            this.ComboTreeGasStation.DisplayMembers = "GasStationCode,GasStationName";
            this.ComboTreeGasStation.Location = new System.Drawing.Point(526, 65);
            this.ComboTreeGasStation.Name = "ComboTreeGasStation";
            this.ComboTreeGasStation.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ComboTreeGasStation.Size = new System.Drawing.Size(267, 23);
            this.ComboTreeGasStation.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ComboTreeGasStation.TabIndex = 75;
            this.ComboTreeGasStation.ValueMember = "ID";
            // 
            // LabelAddress
            // 
            this.LabelAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.LabelAddress.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelAddress.ForeColor = System.Drawing.Color.Black;
            this.LabelAddress.Location = new System.Drawing.Point(62, 30);
            this.LabelAddress.Name = "LabelAddress";
            this.LabelAddress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LabelAddress.Size = new System.Drawing.Size(484, 16);
            this.LabelAddress.TabIndex = 74;
            this.LabelAddress.Text = "آدرس";
            this.LabelAddress.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // mssLabel1
            // 
            this.mssLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mssLabel1.AutoSize = true;
            // 
            // 
            // 
            this.mssLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mssLabel1.ForeColor = System.Drawing.Color.Black;
            this.mssLabel1.Location = new System.Drawing.Point(799, 72);
            this.mssLabel1.Name = "mssLabel1";
            this.mssLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mssLabel1.Size = new System.Drawing.Size(78, 17);
            this.mssLabel1.TabIndex = 74;
            this.mssLabel1.Text = "عنوان ایستگاه:";
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
            this.label1.Location = new System.Drawing.Point(793, 28);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 73;
            this.label1.Text = "خواندن از فایل:";
            // 
            // buttonPatientID
            // 
            this.buttonPatientID.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonPatientID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPatientID.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonPatientID.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonPatientID.Location = new System.Drawing.Point(560, 25);
            this.buttonPatientID.Name = "buttonPatientID";
            this.buttonPatientID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonPatientID.Size = new System.Drawing.Size(33, 21);
            this.buttonPatientID.TabIndex = 72;
            this.buttonPatientID.Text = "...";
            this.buttonPatientID.Click += new System.EventHandler(this.buttonPatientID_Click);
            // 
            // textBoxPatientID
            // 
            this.textBoxPatientID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.textBoxPatientID.Border.Class = "TextBoxBorder";
            this.textBoxPatientID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxPatientID.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBoxPatientID.ForeColor = System.Drawing.Color.Black;
            this.textBoxPatientID.Location = new System.Drawing.Point(598, 25);
            this.textBoxPatientID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxPatientID.MaxLength = 50;
            this.textBoxPatientID.Name = "textBoxPatientID";
            this.textBoxPatientID.Size = new System.Drawing.Size(195, 24);
            this.textBoxPatientID.TabIndex = 71;
            // 
            // buttonImport
            // 
            this.buttonImport.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonImport.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonImport.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonImport.Image = ((System.Drawing.Image)(resources.GetObject("buttonImport.Image")));
            this.buttonImport.Location = new System.Drawing.Point(62, 116);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonImport.Size = new System.Drawing.Size(269, 44);
            this.buttonImport.TabIndex = 2;
            this.buttonImport.Text = "ثبت در بانک اطلاعاتی";
            this.buttonImport.Click += new System.EventHandler(this.buttonImport_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Coral;
            // 
            // 
            // 
            this.label2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(0, 440);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(893, 14);
            this.label2.TabIndex = 304;
            this.label2.Text = "اشکالات ثبتی";
            // 
            // splitter1
            // 
            this.splitter1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(150)))));
            this.splitter1.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.splitter1.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.ExpandFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(150)))));
            this.splitter1.ExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.splitter1.ExpandLineColor = System.Drawing.SystemColors.ControlText;
            this.splitter1.ExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.splitter1.ForeColor = System.Drawing.Color.Black;
            this.splitter1.GripDarkColor = System.Drawing.SystemColors.ControlText;
            this.splitter1.GripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.splitter1.GripLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.splitter1.GripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.splitter1.HotBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(142)))), ((int)(((byte)(75)))));
            this.splitter1.HotBackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(139)))));
            this.splitter1.HotBackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground2;
            this.splitter1.HotBackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground;
            this.splitter1.HotExpandFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(150)))));
            this.splitter1.HotExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.splitter1.HotExpandLineColor = System.Drawing.SystemColors.ControlText;
            this.splitter1.HotExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.splitter1.HotGripDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(150)))));
            this.splitter1.HotGripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.splitter1.HotGripLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.splitter1.HotGripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.splitter1.Location = new System.Drawing.Point(0, 454);
            this.splitter1.Name = "splitter1";
            this.splitter1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitter1.Size = new System.Drawing.Size(893, 3);
            this.splitter1.TabIndex = 302;
            this.splitter1.TabStop = false;
            // 
            // listViewErrore
            // 
            this.listViewErrore.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listViewErrore.FullRowSelect = true;
            this.listViewErrore.GridLines = true;
            this.listViewErrore.Location = new System.Drawing.Point(0, 457);
            this.listViewErrore.Name = "listViewErrore";
            this.listViewErrore.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listViewErrore.RightToLeftLayout = true;
            this.listViewErrore.Size = new System.Drawing.Size(893, 82);
            this.listViewErrore.TabIndex = 300;
            this.listViewErrore.UseCompatibleStateImageBehavior = false;
            this.listViewErrore.View = System.Windows.Forms.View.Tile;
            this.listViewErrore.DoubleClick += new System.EventHandler(this.listViewErrore_DoubleClick);
            // 
            // ProgressBarSave
            // 
            // 
            // 
            // 
            this.ProgressBarSave.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ProgressBarSave.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProgressBarSave.Location = new System.Drawing.Point(0, 182);
            this.ProgressBarSave.Name = "ProgressBarSave";
            this.ProgressBarSave.Size = new System.Drawing.Size(893, 23);
            this.ProgressBarSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ProgressBarSave.TabIndex = 306;
            this.ProgressBarSave.Text = "mssProgressBar1";
            this.ProgressBarSave.Visible = false;
            // 
            // GasStationImport_Uc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GridViewImportExcel);
            this.Controls.Add(this.ProgressBarSave);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.listViewErrore);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "GasStationImport_Uc";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(893, 539);
            this.Tag = "ثبت اطلاعات مصرف";
            this.Load += new System.EventHandler(this.GasStationImport_Uc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewImportExcel)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MSS.Library.Control.MSSButton buttonImport;
        private MSS.Library.Control.MSSPanel panel2;
        private MSS.Library.Control.MSSListView listViewErrore;
        private MSS.Library.Control.MSSExpandableSplitter splitter1;
        private MSS.Library.Control.MSSButton buttonPatientID;
        private MSS.Library.Control.MSSTextBox textBoxPatientID;
        private MSS.Library.Control.MSSLabel label1;
        private MSS.Library.Control.MSSLabel label2;
        private Janus.Windows.GridEX.GridEX GridViewImportExcel;
        private MSS.Library.Control.MSSComboTree ComboTreeGasStation;
        private MSS.Library.Control.MSSLabel mssLabel1;
        private MSS.Library.Control.MSSLabel mssLabel2;
        private MSS.Library.Control.MSSComboBox ComboBoxRan;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
        private DevComponents.Editors.ComboItem comboItem3;
        private MSS.Library.Control.MSSLabel LabelAddress;
        private MSS.Library.Control.MSSProgressBar ProgressBarSave;
    }
}
