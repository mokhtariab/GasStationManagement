using MSS.Library.Control;

namespace GasStationManagement.View.BaseForms
{
    partial class MonitoringSysState_Frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonitoringSysState_Frm));
            Janus.Windows.GridEX.GridEXLayout GridViewMonitoringSysState_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.con = new MSS.Library.Control.MSSGroupPanel(this.components);
            this.GridViewMonitoringSysState = new MSS.Library.Control.MSSGridexView();
            this.tBLMonitoringSysStateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HeaderGridMonitoringSysState = new MSS.Library.Control.MSSHeaderGrid();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewMonitoringSysState)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLMonitoringSysStateBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // con
            // 
            this.con.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.con.Font = new System.Drawing.Font("Tahoma", 8F);
            this.con.Location = new System.Drawing.Point(0, 388);
            this.con.Name = "con";
            this.con.Size = new System.Drawing.Size(476, 26);
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
            // GridViewMonitoringSysState
            // 
            this.GridViewMonitoringSysState.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.GridViewMonitoringSysState.AlternatingColors = true;
            this.GridViewMonitoringSysState.AlternatingRowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewMonitoringSysState.BuiltInTextsData = resources.GetString("GridViewMonitoringSysState.BuiltInTextsData");
            this.GridViewMonitoringSysState.CardViewGridlines = Janus.Windows.GridEX.CardViewGridlines.Both;
            this.GridViewMonitoringSysState.DataSource = this.tBLMonitoringSysStateBindingSource;
            this.GridViewMonitoringSysState.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            GridViewMonitoringSysState_DesignTimeLayout.LayoutString = resources.GetString("GridViewMonitoringSysState_DesignTimeLayout.LayoutString");
            this.GridViewMonitoringSysState.DesignTimeLayout = GridViewMonitoringSysState_DesignTimeLayout;
            this.GridViewMonitoringSysState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewMonitoringSysState.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.GridViewMonitoringSysState.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.GridViewMonitoringSysState.Font = new System.Drawing.Font("Tahoma", 8.150944F);
            this.GridViewMonitoringSysState.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewMonitoringSysState.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
            this.GridViewMonitoringSysState.Location = new System.Drawing.Point(0, 36);
            this.GridViewMonitoringSysState.Name = "GridViewMonitoringSysState";
            this.GridViewMonitoringSysState.RecordNavigator = true;
            this.GridViewMonitoringSysState.RowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewMonitoringSysState.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition;
            this.GridViewMonitoringSysState.RowHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewMonitoringSysState.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.GridViewMonitoringSysState.Size = new System.Drawing.Size(476, 352);
            this.GridViewMonitoringSysState.TabIndex = 30;
            this.GridViewMonitoringSysState.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.GridViewMonitoringSysState.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010;
            // 
            // tBLMonitoringSysStateBindingSource
            // 
            this.tBLMonitoringSysStateBindingSource.DataSource = typeof(GasStationManagement.Model.Basic.DataAccess.TBL_MonitoringSysState);
            // 
            // HeaderGridMonitoringSysState
            // 
            // 
            // 
            // 
            this.HeaderGridMonitoringSysState.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridMonitoringSysState.BackgroundStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridMonitoringSysState.BackgroundStyle.BorderBottomWidth = 1;
            this.HeaderGridMonitoringSysState.BackgroundStyle.BorderLeftWidth = 1;
            this.HeaderGridMonitoringSysState.BackgroundStyle.BorderRightWidth = 1;
            this.HeaderGridMonitoringSysState.BackgroundStyle.BorderTopWidth = 1;
            this.HeaderGridMonitoringSysState.BackgroundStyle.Class = "ItemPanel";
            this.HeaderGridMonitoringSysState.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.HeaderGridMonitoringSysState.BackgroundStyle.PaddingBottom = 1;
            this.HeaderGridMonitoringSysState.BackgroundStyle.PaddingLeft = 1;
            this.HeaderGridMonitoringSysState.BackgroundStyle.PaddingRight = 1;
            this.HeaderGridMonitoringSysState.BackgroundStyle.PaddingTop = 1;
            this.HeaderGridMonitoringSysState.ButtonDeletePermissionCode = 0;
            this.HeaderGridMonitoringSysState.ButtonDeleteVisible = true;
            this.HeaderGridMonitoringSysState.ButtonEditPermissionCode = 0;
            this.HeaderGridMonitoringSysState.ButtonEditVisible = true;
            this.HeaderGridMonitoringSysState.ButtonExcelExportVisible = false;
            this.HeaderGridMonitoringSysState.ButtonExcelPermissionCode = 0;
            this.HeaderGridMonitoringSysState.ButtonInsertPermissionCode = 0;
            this.HeaderGridMonitoringSysState.ButtonInsertVisible = true;
            this.HeaderGridMonitoringSysState.ButtonPrintExpertPermissionCode = 0;
            this.HeaderGridMonitoringSysState.ButtonPrintExpertVisible = false;
            this.HeaderGridMonitoringSysState.ButtonPrintPermissionCode = 0;
            this.HeaderGridMonitoringSysState.ButtonPrintVisible = true;
            this.HeaderGridMonitoringSysState.ButtonRefreshVisible = true;
            this.HeaderGridMonitoringSysState.ButtonSearchExpertVisible = false;
            this.HeaderGridMonitoringSysState.ButtonSearchVisible = true;
            this.HeaderGridMonitoringSysState.ButtonSelectorVisible = false;
            this.HeaderGridMonitoringSysState.ContainerControlProcessDialogKey = true;
            this.HeaderGridMonitoringSysState.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderGridMonitoringSysState.FitButtonsToContainerWidth = true;
            this.HeaderGridMonitoringSysState.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.HeaderGridMonitoringSysState.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.HeaderGridMonitoringSysState.GridViewSet = this.GridViewMonitoringSysState;
            this.HeaderGridMonitoringSysState.Location = new System.Drawing.Point(0, 0);
            this.HeaderGridMonitoringSysState.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HeaderGridMonitoringSysState.Name = "HeaderGridMonitoringSysState";
            this.HeaderGridMonitoringSysState.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HeaderGridMonitoringSysState.Size = new System.Drawing.Size(476, 36);
            this.HeaderGridMonitoringSysState.TabIndex = 31;
            this.HeaderGridMonitoringSysState.Text = "mssHeaderGrid1";
            this.HeaderGridMonitoringSysState.ThemeAware = true;
            this.HeaderGridMonitoringSysState.buttonItemInsertClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemInsertClickEventHandler(this.headerGridMonitoringSysState_btnInsertClick);
            this.HeaderGridMonitoringSysState.buttonItemEditClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemEditClickEventHandler(this.headerGridMonitoringSysState_btnEditClick);
            this.HeaderGridMonitoringSysState.buttonItemDeleteClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemDeleteClickEventHandler(this.headerGridMonitoringSysState_btnDeleteClick);
            this.HeaderGridMonitoringSysState.buttonItemRefreshClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemRefreshClickEventHandler(this.headerGridMonitoringSysState_btnRefreshClick);
            // 
            // MonitoringSysState_Frm
            // 
            this.ClientSize = new System.Drawing.Size(476, 414);
            this.Controls.Add(this.GridViewMonitoringSysState);
            this.Controls.Add(this.HeaderGridMonitoringSysState);
            this.Controls.Add(this.con);
            this.Name = "MonitoringSysState_Frm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "وضعیت سیستم مانیتورینگ";
            this.Load += new System.EventHandler(this.MonitoringSysState_Frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewMonitoringSysState)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLMonitoringSysStateBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MSSGroupPanel con;
        private MSSGridexView GridViewMonitoringSysState;
        private MSSHeaderGrid HeaderGridMonitoringSysState;
        private System.Windows.Forms.BindingSource tBLMonitoringSysStateBindingSource;
    }
}
