using MSS.Library.Control;

namespace GasStationManagement.View.MainForms.Monitoring
{
    partial class MonitoringSupply_UC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonitoringSupply_UC));
            Janus.Windows.GridEX.GridEXLayout GridViewMonitoringSupply_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.con = new MSS.Library.Control.MSSGroupPanel(this.components);
            this.HeaderGridMonitoringSupply = new MSS.Library.Control.MSSHeaderGrid();
            this.GridViewMonitoringSupply = new MSS.Library.Control.MSSGridexView();
            this.vWMonitoringSupplyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewMonitoringSupply)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWMonitoringSupplyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // con
            // 
            this.con.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.con.Font = new System.Drawing.Font("Tahoma", 8F);
            this.con.Location = new System.Drawing.Point(0, 459);
            this.con.Name = "con";
            this.con.Size = new System.Drawing.Size(819, 26);
            // 
            // 
            // 
            this.con.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.con.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.con.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.con.TabIndex = 28;
            // 
            // HeaderGridMonitoringSupply
            // 
            // 
            // 
            // 
            this.HeaderGridMonitoringSupply.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridMonitoringSupply.BackgroundStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridMonitoringSupply.BackgroundStyle.BorderBottomWidth = 1;
            this.HeaderGridMonitoringSupply.BackgroundStyle.BorderLeftWidth = 1;
            this.HeaderGridMonitoringSupply.BackgroundStyle.BorderRightWidth = 1;
            this.HeaderGridMonitoringSupply.BackgroundStyle.BorderTopWidth = 1;
            this.HeaderGridMonitoringSupply.BackgroundStyle.Class = "ItemPanel";
            this.HeaderGridMonitoringSupply.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.HeaderGridMonitoringSupply.BackgroundStyle.PaddingBottom = 1;
            this.HeaderGridMonitoringSupply.BackgroundStyle.PaddingLeft = 1;
            this.HeaderGridMonitoringSupply.BackgroundStyle.PaddingRight = 1;
            this.HeaderGridMonitoringSupply.BackgroundStyle.PaddingTop = 1;
            this.HeaderGridMonitoringSupply.ButtonDeleteVisible = true;
            this.HeaderGridMonitoringSupply.ButtonEditVisible = true;
            this.HeaderGridMonitoringSupply.ButtonExcelExportVisible = true;
            this.HeaderGridMonitoringSupply.ButtonInsertVisible = true;
            this.HeaderGridMonitoringSupply.ButtonPrintExpertVisible = false;
            this.HeaderGridMonitoringSupply.ButtonPrintVisible = true;
            this.HeaderGridMonitoringSupply.ButtonRefreshVisible = true;
            this.HeaderGridMonitoringSupply.ButtonSearchExpertVisible = false;
            this.HeaderGridMonitoringSupply.ButtonSearchVisible = true;
            this.HeaderGridMonitoringSupply.ButtonSelectorVisible = true;
            this.HeaderGridMonitoringSupply.ContainerControlProcessDialogKey = true;
            this.HeaderGridMonitoringSupply.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderGridMonitoringSupply.FitButtonsToContainerWidth = true;
            this.HeaderGridMonitoringSupply.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.HeaderGridMonitoringSupply.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.HeaderGridMonitoringSupply.GridViewSet = this.GridViewMonitoringSupply;
            this.HeaderGridMonitoringSupply.Location = new System.Drawing.Point(0, 0);
            this.HeaderGridMonitoringSupply.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HeaderGridMonitoringSupply.Name = "HeaderGridMonitoringSupply";
            this.HeaderGridMonitoringSupply.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HeaderGridMonitoringSupply.Size = new System.Drawing.Size(819, 61);
            this.HeaderGridMonitoringSupply.TabIndex = 31;
            this.HeaderGridMonitoringSupply.Text = "mssHeaderGrid1";
            this.HeaderGridMonitoringSupply.ThemeAware = true;
            this.HeaderGridMonitoringSupply.buttonItemInsertClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemInsertClickEventHandler(this.headerGridMonitoringSupply_btnInsertClick);
            this.HeaderGridMonitoringSupply.buttonItemEditClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemEditClickEventHandler(this.headerGridMonitoringSupply_btnEditClick);
            this.HeaderGridMonitoringSupply.buttonItemDeleteClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemDeleteClickEventHandler(this.headerGridMonitoringSupply_btnDeleteClick);
            this.HeaderGridMonitoringSupply.buttonItemRefreshClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemRefreshClickEventHandler(this.headerGridMonitoringSupply_btnRefreshClick);
            // 
            // GridViewMonitoringSupply
            // 
            this.GridViewMonitoringSupply.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.GridViewMonitoringSupply.AlternatingColors = true;
            this.GridViewMonitoringSupply.AlternatingRowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewMonitoringSupply.BuiltInTextsData = resources.GetString("GridViewMonitoringSupply.BuiltInTextsData");
            this.GridViewMonitoringSupply.CardViewGridlines = Janus.Windows.GridEX.CardViewGridlines.Both;
            this.GridViewMonitoringSupply.DataSource = this.vWMonitoringSupplyBindingSource;
            this.GridViewMonitoringSupply.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            GridViewMonitoringSupply_DesignTimeLayout.LayoutString = resources.GetString("GridViewMonitoringSupply_DesignTimeLayout.LayoutString");
            this.GridViewMonitoringSupply.DesignTimeLayout = GridViewMonitoringSupply_DesignTimeLayout;
            this.GridViewMonitoringSupply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewMonitoringSupply.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.GridViewMonitoringSupply.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.GridViewMonitoringSupply.Font = new System.Drawing.Font("Tahoma", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.GridViewMonitoringSupply.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewMonitoringSupply.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
            this.GridViewMonitoringSupply.Location = new System.Drawing.Point(0, 61);
            this.GridViewMonitoringSupply.Name = "GridViewMonitoringSupply";
            this.GridViewMonitoringSupply.RecordNavigator = true;
            this.GridViewMonitoringSupply.RowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewMonitoringSupply.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition;
            this.GridViewMonitoringSupply.RowHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewMonitoringSupply.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.GridViewMonitoringSupply.Size = new System.Drawing.Size(819, 398);
            this.GridViewMonitoringSupply.TabIndex = 32;
            this.GridViewMonitoringSupply.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.GridViewMonitoringSupply.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010;
            // 
            // vWMonitoringSupplyBindingSource
            // 
            this.vWMonitoringSupplyBindingSource.DataSource = typeof(GasStationManagement.Model.MonitoringSupply.VW_MonitoringSupply);
            // 
            // MonitoringSupply_UC
            // 
            this.Controls.Add(this.GridViewMonitoringSupply);
            this.Controls.Add(this.HeaderGridMonitoringSupply);
            this.Controls.Add(this.con);
            this.Name = "MonitoringSupply_UC";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(819, 485);
            this.Load += new System.EventHandler(this.MonitoringSupply_UC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewMonitoringSupply)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWMonitoringSupplyBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MSSGroupPanel con;
        private MSSHeaderGrid HeaderGridMonitoringSupply;
        private MSSGridexView GridViewMonitoringSupply;
        private System.Windows.Forms.BindingSource vWMonitoringSupplyBindingSource;
    }
}
