using MSS.Library.Control;

namespace GasStationManagement.View.SystemImport
{
    partial class PerformanceInfoStation_Frm
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
            Janus.Windows.GridEX.GridEXLayout GridViewPerformanceInfoStation_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PerformanceInfoStation_Frm));
            this.mssPanel2 = new MSS.Library.Control.MSSPanel(this.components);
            this.ButtonAdd = new MSS.Library.Control.MSSButton(this.components);
            this.ComboTreeGasStation = new MSS.Library.Control.MSSComboTree();
            this.gasStationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mssLabel1 = new MSS.Library.Control.MSSLabel(this.components);
            this.GridViewPerformanceInfoStation = new Janus.Windows.GridEX.GridEX();
            this.tableTSampleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mssGroupPanel1.SuspendLayout();
            this.mssPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gasStationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewPerformanceInfoStation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableTSampleBindingSource)).BeginInit();
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
            this.ribbonBarNewBar.Location = new System.Drawing.Point(0, 509);
            this.ribbonBarNewBar.Size = new System.Drawing.Size(803, 59);
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
            this.mssGroupPanel1.Controls.Add(this.GridViewPerformanceInfoStation);
            this.mssGroupPanel1.Controls.Add(this.mssPanel2);
            this.mssGroupPanel1.Size = new System.Drawing.Size(803, 475);
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
            this.buttonItemOK.Click += new System.EventHandler(this.buttonItemOK_Click);
            // 
            // mssPanel2
            // 
            this.mssPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.mssPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.mssPanel2.Controls.Add(this.ButtonAdd);
            this.mssPanel2.Controls.Add(this.ComboTreeGasStation);
            this.mssPanel2.Controls.Add(this.mssLabel1);
            this.mssPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.mssPanel2.Location = new System.Drawing.Point(0, 0);
            this.mssPanel2.Name = "mssPanel2";
            this.mssPanel2.Size = new System.Drawing.Size(797, 51);
            this.mssPanel2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.mssPanel2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.mssPanel2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.mssPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.mssPanel2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.mssPanel2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.mssPanel2.Style.GradientAngle = 90;
            this.mssPanel2.TabIndex = 34;
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonAdd.Location = new System.Drawing.Point(337, 12);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ButtonAdd.Size = new System.Drawing.Size(52, 22);
            this.ButtonAdd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonAdd.TabIndex = 3;
            this.ButtonAdd.Text = "+";
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
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
            this.ComboTreeGasStation.DataSource = this.gasStationBindingSource;
            this.ComboTreeGasStation.DisplayMembers = "GasStationCode,GasStationName";
            this.ComboTreeGasStation.GridRowLines = true;
            this.ComboTreeGasStation.Location = new System.Drawing.Point(407, 12);
            this.ComboTreeGasStation.Name = "ComboTreeGasStation";
            this.ComboTreeGasStation.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ComboTreeGasStation.Size = new System.Drawing.Size(227, 23);
            this.ComboTreeGasStation.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ComboTreeGasStation.TabIndex = 2;
            this.ComboTreeGasStation.ValueMember = "ID";
            // 
            // gasStationBindingSource
            // 
            this.gasStationBindingSource.DataSource = typeof(GasStationManagement.Model.GasStation.GasStation);
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
            this.mssLabel1.Location = new System.Drawing.Point(640, 17);
            this.mssLabel1.Name = "mssLabel1";
            this.mssLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mssLabel1.Size = new System.Drawing.Size(78, 17);
            this.mssLabel1.TabIndex = 0;
            this.mssLabel1.Text = "عنوان ایستگاه:";
            // 
            // GridViewPerformanceInfoStation
            // 
            this.GridViewPerformanceInfoStation.AlternatingColors = true;
            this.GridViewPerformanceInfoStation.AlternatingRowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewPerformanceInfoStation.BuiltInTextsData = "<LocalizableData ID=\"LocalizableStrings\" Collection=\"true\"><RecordNavigator>:ردیف" +
    "|از</RecordNavigator></LocalizableData>";
            GridViewPerformanceInfoStation_DesignTimeLayout.LayoutString = resources.GetString("GridViewPerformanceInfoStation_DesignTimeLayout.LayoutString");
            this.GridViewPerformanceInfoStation.DesignTimeLayout = GridViewPerformanceInfoStation_DesignTimeLayout;
            this.GridViewPerformanceInfoStation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewPerformanceInfoStation.GroupByBoxVisible = false;
            this.GridViewPerformanceInfoStation.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewPerformanceInfoStation.Location = new System.Drawing.Point(0, 51);
            this.GridViewPerformanceInfoStation.Name = "GridViewPerformanceInfoStation";
            this.GridViewPerformanceInfoStation.RecordNavigator = true;
            this.GridViewPerformanceInfoStation.RowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewPerformanceInfoStation.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition;
            this.GridViewPerformanceInfoStation.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.GridViewPerformanceInfoStation.Size = new System.Drawing.Size(797, 418);
            this.GridViewPerformanceInfoStation.TabIndex = 35;
            this.GridViewPerformanceInfoStation.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010;
            this.GridViewPerformanceInfoStation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GridViewPerformanceInfoStation_KeyDown);
            // 
            // tableTSampleBindingSource
            // 
            this.tableTSampleBindingSource.DataSource = typeof(GasStationManagement.Model.Table_TSample.Table_TSample);
            // 
            // PerformanceInfoStation_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.ClientSize = new System.Drawing.Size(803, 568);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "PerformanceInfoStation_Frm";
            this.Text = "ثبت اطلاعات هر ایستگاه به تفکیک";
            this.Load += new System.EventHandler(this.PerformanceInfoStation_Frm_Load);
            this.mssGroupPanel1.ResumeLayout(false);
            this.mssPanel2.ResumeLayout(false);
            this.mssPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gasStationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewPerformanceInfoStation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableTSampleBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MSSPanel mssPanel2;
        private MSSLabel mssLabel1;
        private Janus.Windows.GridEX.GridEX GridViewPerformanceInfoStation;
        private System.Windows.Forms.BindingSource tableTSampleBindingSource;
        private MSSComboTree ComboTreeGasStation;
        private System.Windows.Forms.BindingSource gasStationBindingSource;
        private MSSButton ButtonAdd;

    }
}
