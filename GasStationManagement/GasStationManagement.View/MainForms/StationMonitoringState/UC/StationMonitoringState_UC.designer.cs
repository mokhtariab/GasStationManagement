using MSS.Library.Control;

namespace GasStationManagement.View.MainForms.StationMonitoringState
{
    partial class StationMonitoringState_UC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StationMonitoringState_UC));
            Janus.Windows.GridEX.GridEXLayout GridViewStationMonitoringState_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.HeaderGridStationMonitoringState = new MSS.Library.Control.MSSHeaderGrid();
            this.GridViewStationMonitoringState = new MSS.Library.Control.MSSGridexView();
            this.vWStationMonitoringStateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewStationMonitoringState)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWStationMonitoringStateBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // HeaderGridStationMonitoringState
            // 
            // 
            // 
            // 
            this.HeaderGridStationMonitoringState.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridStationMonitoringState.BackgroundStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridStationMonitoringState.BackgroundStyle.BorderBottomWidth = 1;
            this.HeaderGridStationMonitoringState.BackgroundStyle.BorderLeftWidth = 1;
            this.HeaderGridStationMonitoringState.BackgroundStyle.BorderRightWidth = 1;
            this.HeaderGridStationMonitoringState.BackgroundStyle.BorderTopWidth = 1;
            this.HeaderGridStationMonitoringState.BackgroundStyle.Class = "ItemPanel";
            this.HeaderGridStationMonitoringState.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.HeaderGridStationMonitoringState.BackgroundStyle.PaddingBottom = 1;
            this.HeaderGridStationMonitoringState.BackgroundStyle.PaddingLeft = 1;
            this.HeaderGridStationMonitoringState.BackgroundStyle.PaddingRight = 1;
            this.HeaderGridStationMonitoringState.BackgroundStyle.PaddingTop = 1;
            this.HeaderGridStationMonitoringState.ButtonDeletePermissionCode = 0;
            this.HeaderGridStationMonitoringState.ButtonDeleteVisible = true;
            this.HeaderGridStationMonitoringState.ButtonEditPermissionCode = 0;
            this.HeaderGridStationMonitoringState.ButtonEditVisible = true;
            this.HeaderGridStationMonitoringState.ButtonExcelExportVisible = true;
            this.HeaderGridStationMonitoringState.ButtonExcelPermissionCode = 0;
            this.HeaderGridStationMonitoringState.ButtonInsertPermissionCode = 0;
            this.HeaderGridStationMonitoringState.ButtonInsertVisible = true;
            this.HeaderGridStationMonitoringState.ButtonPrintExpertPermissionCode = 0;
            this.HeaderGridStationMonitoringState.ButtonPrintExpertVisible = false;
            this.HeaderGridStationMonitoringState.ButtonPrintPermissionCode = 0;
            this.HeaderGridStationMonitoringState.ButtonPrintVisible = true;
            this.HeaderGridStationMonitoringState.ButtonRefreshVisible = true;
            this.HeaderGridStationMonitoringState.ButtonSearchExpertVisible = false;
            this.HeaderGridStationMonitoringState.ButtonSearchVisible = true;
            this.HeaderGridStationMonitoringState.ButtonSelectorVisible = true;
            this.HeaderGridStationMonitoringState.ContainerControlProcessDialogKey = true;
            this.HeaderGridStationMonitoringState.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderGridStationMonitoringState.FitButtonsToContainerWidth = true;
            this.HeaderGridStationMonitoringState.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.HeaderGridStationMonitoringState.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.HeaderGridStationMonitoringState.GridViewSet = this.GridViewStationMonitoringState;
            this.HeaderGridStationMonitoringState.Location = new System.Drawing.Point(0, 0);
            this.HeaderGridStationMonitoringState.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HeaderGridStationMonitoringState.Name = "HeaderGridStationMonitoringState";
            this.HeaderGridStationMonitoringState.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HeaderGridStationMonitoringState.Size = new System.Drawing.Size(819, 40);
            this.HeaderGridStationMonitoringState.TabIndex = 31;
            this.HeaderGridStationMonitoringState.Text = "mssHeaderGrid1";
            this.HeaderGridStationMonitoringState.ThemeAware = true;
            this.HeaderGridStationMonitoringState.buttonItemInsertClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemInsertClickEventHandler(this.headerGridStationMonitoringState_btnInsertClick);
            this.HeaderGridStationMonitoringState.buttonItemEditClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemEditClickEventHandler(this.headerGridStationMonitoringState_btnEditClick);
            this.HeaderGridStationMonitoringState.buttonItemDeleteClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemDeleteClickEventHandler(this.headerGridStationMonitoringState_btnDeleteClick);
            this.HeaderGridStationMonitoringState.buttonItemRefreshClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemRefreshClickEventHandler(this.headerGridStationMonitoringState_btnRefreshClick);
            // 
            // GridViewStationMonitoringState
            // 
            this.GridViewStationMonitoringState.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.GridViewStationMonitoringState.AlternatingRowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewStationMonitoringState.BuiltInTextsData = resources.GetString("GridViewStationMonitoringState.BuiltInTextsData");
            this.GridViewStationMonitoringState.CardViewGridlines = Janus.Windows.GridEX.CardViewGridlines.Both;
            this.GridViewStationMonitoringState.DataSource = this.vWStationMonitoringStateBindingSource;
            this.GridViewStationMonitoringState.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            GridViewStationMonitoringState_DesignTimeLayout.LayoutString = resources.GetString("GridViewStationMonitoringState_DesignTimeLayout.LayoutString");
            this.GridViewStationMonitoringState.DesignTimeLayout = GridViewStationMonitoringState_DesignTimeLayout;
            this.GridViewStationMonitoringState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewStationMonitoringState.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.GridViewStationMonitoringState.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.GridViewStationMonitoringState.Font = new System.Drawing.Font("Tahoma", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.GridViewStationMonitoringState.GroupByBoxVisible = false;
            this.GridViewStationMonitoringState.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewStationMonitoringState.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
            this.GridViewStationMonitoringState.Location = new System.Drawing.Point(0, 40);
            this.GridViewStationMonitoringState.Name = "GridViewStationMonitoringState";
            this.GridViewStationMonitoringState.RecordNavigator = true;
            this.GridViewStationMonitoringState.RowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewStationMonitoringState.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition;
            this.GridViewStationMonitoringState.RowHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewStationMonitoringState.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.GridViewStationMonitoringState.Size = new System.Drawing.Size(819, 465);
            this.GridViewStationMonitoringState.TabIndex = 32;
            this.GridViewStationMonitoringState.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.GridViewStationMonitoringState.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010;
            this.GridViewStationMonitoringState.BindingDataSourceSet += new System.EventHandler(this.GridViewStationMonitoringState_BindingDataSourceSet);
            // 
            // vWStationMonitoringStateBindingSource
            // 
            this.vWStationMonitoringStateBindingSource.DataSource = typeof(GasStationManagement.Model.StationMonitoringState.VW_StationMonitoringState);
            // 
            // StationMonitoringState_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.GridViewStationMonitoringState);
            this.Controls.Add(this.HeaderGridStationMonitoringState);
            this.Name = "StationMonitoringState_UC";
            this.Size = new System.Drawing.Size(819, 505);
            this.Load += new System.EventHandler(this.StationMonitoringState_UC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewStationMonitoringState)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWStationMonitoringStateBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MSSHeaderGrid HeaderGridStationMonitoringState;
        private MSSGridexView GridViewStationMonitoringState;
        private System.Windows.Forms.BindingSource vWStationMonitoringStateBindingSource;
    }
}
