using MSS.Library.Control;

namespace GasStationManagement.View.MainForms.Monitoring
{
    partial class Monitoring_UC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Monitoring_UC));
            Janus.Windows.GridEX.GridEXLayout GridViewMonitoring_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.tBLMonitoringBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HeaderGridMonitoring = new MSS.Library.Control.MSSHeaderGrid();
            this.GridViewMonitoring = new MSS.Library.Control.MSSGridexView();
            ((System.ComponentModel.ISupportInitialize)(this.tBLMonitoringBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewMonitoring)).BeginInit();
            this.SuspendLayout();
            // 
            // tBLMonitoringBindingSource
            // 
            this.tBLMonitoringBindingSource.DataSource = typeof(GasStationManagement.Model.Basic.DataAccess.TBL_Monitoring);
            // 
            // HeaderGridMonitoring
            // 
            // 
            // 
            // 
            this.HeaderGridMonitoring.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridMonitoring.BackgroundStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridMonitoring.BackgroundStyle.BorderBottomWidth = 1;
            this.HeaderGridMonitoring.BackgroundStyle.BorderLeftWidth = 1;
            this.HeaderGridMonitoring.BackgroundStyle.BorderRightWidth = 1;
            this.HeaderGridMonitoring.BackgroundStyle.BorderTopWidth = 1;
            this.HeaderGridMonitoring.BackgroundStyle.Class = "ItemPanel";
            this.HeaderGridMonitoring.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.HeaderGridMonitoring.BackgroundStyle.PaddingBottom = 1;
            this.HeaderGridMonitoring.BackgroundStyle.PaddingLeft = 1;
            this.HeaderGridMonitoring.BackgroundStyle.PaddingRight = 1;
            this.HeaderGridMonitoring.BackgroundStyle.PaddingTop = 1;
            this.HeaderGridMonitoring.ButtonDeleteVisible = true;
            this.HeaderGridMonitoring.ButtonEditVisible = true;
            this.HeaderGridMonitoring.ButtonExcelExportVisible = true;
            this.HeaderGridMonitoring.ButtonInsertVisible = true;
            this.HeaderGridMonitoring.ButtonPrintExpertVisible = false;
            this.HeaderGridMonitoring.ButtonPrintVisible = true;
            this.HeaderGridMonitoring.ButtonRefreshVisible = true;
            this.HeaderGridMonitoring.ButtonSearchExpertVisible = false;
            this.HeaderGridMonitoring.ButtonSearchVisible = true;
            this.HeaderGridMonitoring.ButtonSelectorVisible = true;
            this.HeaderGridMonitoring.ContainerControlProcessDialogKey = true;
            this.HeaderGridMonitoring.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderGridMonitoring.FitButtonsToContainerWidth = true;
            this.HeaderGridMonitoring.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.HeaderGridMonitoring.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.HeaderGridMonitoring.Location = new System.Drawing.Point(0, 0);
            this.HeaderGridMonitoring.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HeaderGridMonitoring.Name = "HeaderGridMonitoring";
            this.HeaderGridMonitoring.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HeaderGridMonitoring.Size = new System.Drawing.Size(819, 61);
            this.HeaderGridMonitoring.TabIndex = 31;
            this.HeaderGridMonitoring.Text = "mssHeaderGrid1";
            this.HeaderGridMonitoring.ThemeAware = true;
            this.HeaderGridMonitoring.buttonItemInsertClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemInsertClickEventHandler(this.headerGridMonitoring_btnInsertClick);
            this.HeaderGridMonitoring.buttonItemEditClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemEditClickEventHandler(this.headerGridMonitoring_btnEditClick);
            this.HeaderGridMonitoring.buttonItemDeleteClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemDeleteClickEventHandler(this.headerGridMonitoring_btnDeleteClick);
            this.HeaderGridMonitoring.buttonItemRefreshClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemRefreshClickEventHandler(this.headerGridMonitoring_btnRefreshClick);
            // 
            // GridViewMonitoring
            // 
            this.GridViewMonitoring.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.GridViewMonitoring.AlternatingRowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewMonitoring.BuiltInTextsData = resources.GetString("GridViewMonitoring.BuiltInTextsData");
            this.GridViewMonitoring.CardViewGridlines = Janus.Windows.GridEX.CardViewGridlines.Both;
            this.GridViewMonitoring.DataSource = this.tBLMonitoringBindingSource;
            this.GridViewMonitoring.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            GridViewMonitoring_DesignTimeLayout.LayoutString = resources.GetString("GridViewMonitoring_DesignTimeLayout.LayoutString");
            this.GridViewMonitoring.DesignTimeLayout = GridViewMonitoring_DesignTimeLayout;
            this.GridViewMonitoring.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewMonitoring.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.GridViewMonitoring.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.GridViewMonitoring.Font = new System.Drawing.Font("Tahoma", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.GridViewMonitoring.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewMonitoring.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
            this.GridViewMonitoring.Location = new System.Drawing.Point(0, 61);
            this.GridViewMonitoring.Name = "GridViewMonitoring";
            this.GridViewMonitoring.RecordNavigator = true;
            this.GridViewMonitoring.RowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewMonitoring.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition;
            this.GridViewMonitoring.RowHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewMonitoring.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.GridViewMonitoring.Size = new System.Drawing.Size(819, 444);
            this.GridViewMonitoring.TabIndex = 32;
            this.GridViewMonitoring.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.GridViewMonitoring.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010;
            this.GridViewMonitoring.SelectionChanged += new System.EventHandler(this.GridViewMonitoring_SelectionChanged);
            // 
            // Monitoring_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.GridViewMonitoring);
            this.Controls.Add(this.HeaderGridMonitoring);
            this.Name = "Monitoring_UC";
            this.Size = new System.Drawing.Size(819, 505);
            this.Load += new System.EventHandler(this.Monitoring_UC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tBLMonitoringBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewMonitoring)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource tBLMonitoringBindingSource;
        private MSSHeaderGrid HeaderGridMonitoring;
        private MSSGridexView GridViewMonitoring;
    }
}
