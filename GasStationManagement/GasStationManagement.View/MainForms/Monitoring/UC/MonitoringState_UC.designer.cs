using MSS.Library.Control;

namespace GasStationManagement.View.MainForms.Monitoring
{
    partial class MonitoringState_UC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonitoringState_UC));
            Janus.Windows.GridEX.GridEXLayout GridViewMonitoringState_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.con = new MSS.Library.Control.MSSGroupPanel(this.components);
            this.HeaderGridMonitoringState = new MSS.Library.Control.MSSHeaderGrid();
            this.GridViewMonitoringState = new MSS.Library.Control.MSSGridexView();
            this.vWMonitoringStateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewMonitoringState)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWMonitoringStateBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // con
            // 
            this.con.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.con.Font = new System.Drawing.Font("Tahoma", 8F);
            this.con.Location = new System.Drawing.Point(0, 479);
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
            // HeaderGridMonitoringState
            // 
            // 
            // 
            // 
            this.HeaderGridMonitoringState.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridMonitoringState.BackgroundStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridMonitoringState.BackgroundStyle.BorderBottomWidth = 1;
            this.HeaderGridMonitoringState.BackgroundStyle.BorderLeftWidth = 1;
            this.HeaderGridMonitoringState.BackgroundStyle.BorderRightWidth = 1;
            this.HeaderGridMonitoringState.BackgroundStyle.BorderTopWidth = 1;
            this.HeaderGridMonitoringState.BackgroundStyle.Class = "ItemPanel";
            this.HeaderGridMonitoringState.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.HeaderGridMonitoringState.BackgroundStyle.PaddingBottom = 1;
            this.HeaderGridMonitoringState.BackgroundStyle.PaddingLeft = 1;
            this.HeaderGridMonitoringState.BackgroundStyle.PaddingRight = 1;
            this.HeaderGridMonitoringState.BackgroundStyle.PaddingTop = 1;
            this.HeaderGridMonitoringState.ButtonDeletePermissionCode = 0;
            this.HeaderGridMonitoringState.ButtonDeleteVisible = true;
            this.HeaderGridMonitoringState.ButtonEditPermissionCode = 0;
            this.HeaderGridMonitoringState.ButtonEditVisible = true;
            this.HeaderGridMonitoringState.ButtonExcelExportVisible = true;
            this.HeaderGridMonitoringState.ButtonExcelPermissionCode = 0;
            this.HeaderGridMonitoringState.ButtonInsertPermissionCode = 0;
            this.HeaderGridMonitoringState.ButtonInsertVisible = true;
            this.HeaderGridMonitoringState.ButtonPrintExpertPermissionCode = 0;
            this.HeaderGridMonitoringState.ButtonPrintExpertVisible = false;
            this.HeaderGridMonitoringState.ButtonPrintPermissionCode = 0;
            this.HeaderGridMonitoringState.ButtonPrintVisible = true;
            this.HeaderGridMonitoringState.ButtonRefreshVisible = true;
            this.HeaderGridMonitoringState.ButtonSearchExpertVisible = false;
            this.HeaderGridMonitoringState.ButtonSearchVisible = true;
            this.HeaderGridMonitoringState.ButtonSelectorVisible = true;
            this.HeaderGridMonitoringState.ContainerControlProcessDialogKey = true;
            this.HeaderGridMonitoringState.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderGridMonitoringState.FitButtonsToContainerWidth = true;
            this.HeaderGridMonitoringState.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.HeaderGridMonitoringState.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.HeaderGridMonitoringState.GridViewSet = this.GridViewMonitoringState;
            this.HeaderGridMonitoringState.Location = new System.Drawing.Point(0, 0);
            this.HeaderGridMonitoringState.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HeaderGridMonitoringState.Name = "HeaderGridMonitoringState";
            this.HeaderGridMonitoringState.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HeaderGridMonitoringState.Size = new System.Drawing.Size(819, 37);
            this.HeaderGridMonitoringState.TabIndex = 31;
            this.HeaderGridMonitoringState.Text = "mssHeaderGrid1";
            this.HeaderGridMonitoringState.ThemeAware = true;
            this.HeaderGridMonitoringState.buttonItemInsertClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemInsertClickEventHandler(this.headerGridMonitoringState_btnInsertClick);
            this.HeaderGridMonitoringState.buttonItemEditClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemEditClickEventHandler(this.headerGridMonitoringState_btnEditClick);
            this.HeaderGridMonitoringState.buttonItemDeleteClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemDeleteClickEventHandler(this.headerGridMonitoringState_btnDeleteClick);
            this.HeaderGridMonitoringState.buttonItemRefreshClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemRefreshClickEventHandler(this.headerGridMonitoringState_btnRefreshClick);
            // 
            // GridViewMonitoringState
            // 
            this.GridViewMonitoringState.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.GridViewMonitoringState.AlternatingColors = true;
            this.GridViewMonitoringState.AlternatingRowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewMonitoringState.BuiltInTextsData = resources.GetString("GridViewMonitoringState.BuiltInTextsData");
            this.GridViewMonitoringState.CardViewGridlines = Janus.Windows.GridEX.CardViewGridlines.Both;
            this.GridViewMonitoringState.DataSource = this.vWMonitoringStateBindingSource;
            this.GridViewMonitoringState.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            GridViewMonitoringState_DesignTimeLayout.LayoutString = resources.GetString("GridViewMonitoringState_DesignTimeLayout.LayoutString");
            this.GridViewMonitoringState.DesignTimeLayout = GridViewMonitoringState_DesignTimeLayout;
            this.GridViewMonitoringState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewMonitoringState.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.GridViewMonitoringState.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.GridViewMonitoringState.Font = new System.Drawing.Font("Tahoma", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.GridViewMonitoringState.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewMonitoringState.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
            this.GridViewMonitoringState.Location = new System.Drawing.Point(0, 37);
            this.GridViewMonitoringState.Name = "GridViewMonitoringState";
            this.GridViewMonitoringState.RecordNavigator = true;
            this.GridViewMonitoringState.RowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewMonitoringState.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition;
            this.GridViewMonitoringState.RowHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewMonitoringState.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.GridViewMonitoringState.Size = new System.Drawing.Size(819, 442);
            this.GridViewMonitoringState.TabIndex = 32;
            this.GridViewMonitoringState.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.GridViewMonitoringState.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010;
            this.GridViewMonitoringState.SelectionChanged += new System.EventHandler(this.GridViewMonitoringState_SelectionChanged);
            // 
            // vWMonitoringStateBindingSource
            // 
            this.vWMonitoringStateBindingSource.DataSource = typeof(GasStationManagement.Model.MonitoringState.VW_MonitoringState);
            // 
            // MonitoringState_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.GridViewMonitoringState);
            this.Controls.Add(this.HeaderGridMonitoringState);
            this.Controls.Add(this.con);
            this.Name = "MonitoringState_UC";
            this.Size = new System.Drawing.Size(819, 505);
            this.Load += new System.EventHandler(this.MonitoringState_UC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewMonitoringState)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWMonitoringStateBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MSSGroupPanel con;
        private MSSHeaderGrid HeaderGridMonitoringState;
        private MSSGridexView GridViewMonitoringState;
        private System.Windows.Forms.BindingSource vWMonitoringStateBindingSource;
    }
}
