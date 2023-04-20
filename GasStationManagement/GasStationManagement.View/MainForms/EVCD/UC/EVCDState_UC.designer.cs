using MSS.Library.Control;

namespace GasStationManagement.View.MainForms.EVCD
{
    partial class EVCDState_UC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EVCDState_UC));
            Janus.Windows.GridEX.GridEXLayout GridViewEVCDState_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.HeaderGridEVCDState = new MSS.Library.Control.MSSHeaderGrid();
            this.GridViewEVCDState = new MSS.Library.Control.MSSGridexView();
            this.vWEVCDStateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewEVCDState)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWEVCDStateBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // HeaderGridEVCDState
            // 
            // 
            // 
            // 
            this.HeaderGridEVCDState.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridEVCDState.BackgroundStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridEVCDState.BackgroundStyle.BorderBottomWidth = 1;
            this.HeaderGridEVCDState.BackgroundStyle.BorderLeftWidth = 1;
            this.HeaderGridEVCDState.BackgroundStyle.BorderRightWidth = 1;
            this.HeaderGridEVCDState.BackgroundStyle.BorderTopWidth = 1;
            this.HeaderGridEVCDState.BackgroundStyle.Class = "ItemPanel";
            this.HeaderGridEVCDState.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.HeaderGridEVCDState.BackgroundStyle.PaddingBottom = 1;
            this.HeaderGridEVCDState.BackgroundStyle.PaddingLeft = 1;
            this.HeaderGridEVCDState.BackgroundStyle.PaddingRight = 1;
            this.HeaderGridEVCDState.BackgroundStyle.PaddingTop = 1;
            this.HeaderGridEVCDState.ButtonDeletePermissionCode = 0;
            this.HeaderGridEVCDState.ButtonDeleteVisible = true;
            this.HeaderGridEVCDState.ButtonEditPermissionCode = 0;
            this.HeaderGridEVCDState.ButtonEditVisible = true;
            this.HeaderGridEVCDState.ButtonExcelExportVisible = true;
            this.HeaderGridEVCDState.ButtonExcelPermissionCode = 0;
            this.HeaderGridEVCDState.ButtonInsertPermissionCode = 0;
            this.HeaderGridEVCDState.ButtonInsertVisible = true;
            this.HeaderGridEVCDState.ButtonPrintExpertPermissionCode = 0;
            this.HeaderGridEVCDState.ButtonPrintExpertVisible = false;
            this.HeaderGridEVCDState.ButtonPrintPermissionCode = 0;
            this.HeaderGridEVCDState.ButtonPrintVisible = true;
            this.HeaderGridEVCDState.ButtonRefreshVisible = true;
            this.HeaderGridEVCDState.ButtonSearchExpertVisible = false;
            this.HeaderGridEVCDState.ButtonSearchVisible = true;
            this.HeaderGridEVCDState.ButtonSelectorVisible = true;
            this.HeaderGridEVCDState.ContainerControlProcessDialogKey = true;
            this.HeaderGridEVCDState.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderGridEVCDState.FitButtonsToContainerWidth = true;
            this.HeaderGridEVCDState.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.HeaderGridEVCDState.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.HeaderGridEVCDState.GridViewSet = this.GridViewEVCDState;
            this.HeaderGridEVCDState.Location = new System.Drawing.Point(0, 0);
            this.HeaderGridEVCDState.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HeaderGridEVCDState.Name = "HeaderGridEVCDState";
            this.HeaderGridEVCDState.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HeaderGridEVCDState.Size = new System.Drawing.Size(819, 40);
            this.HeaderGridEVCDState.TabIndex = 31;
            this.HeaderGridEVCDState.Text = "mssHeaderGrid1";
            this.HeaderGridEVCDState.ThemeAware = true;
            this.HeaderGridEVCDState.buttonItemInsertClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemInsertClickEventHandler(this.headerGridEVCDState_btnInsertClick);
            this.HeaderGridEVCDState.buttonItemEditClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemEditClickEventHandler(this.headerGridEVCDState_btnEditClick);
            this.HeaderGridEVCDState.buttonItemDeleteClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemDeleteClickEventHandler(this.headerGridEVCDState_btnDeleteClick);
            this.HeaderGridEVCDState.buttonItemRefreshClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemRefreshClickEventHandler(this.headerGridEVCDState_btnRefreshClick);
            // 
            // GridViewEVCDState
            // 
            this.GridViewEVCDState.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.GridViewEVCDState.AlternatingRowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewEVCDState.BuiltInTextsData = resources.GetString("GridViewEVCDState.BuiltInTextsData");
            this.GridViewEVCDState.CardViewGridlines = Janus.Windows.GridEX.CardViewGridlines.Both;
            this.GridViewEVCDState.DataSource = this.vWEVCDStateBindingSource;
            this.GridViewEVCDState.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            GridViewEVCDState_DesignTimeLayout.LayoutString = resources.GetString("GridViewEVCDState_DesignTimeLayout.LayoutString");
            this.GridViewEVCDState.DesignTimeLayout = GridViewEVCDState_DesignTimeLayout;
            this.GridViewEVCDState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewEVCDState.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.GridViewEVCDState.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.GridViewEVCDState.Font = new System.Drawing.Font("Tahoma", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.GridViewEVCDState.GroupByBoxVisible = false;
            this.GridViewEVCDState.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewEVCDState.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
            this.GridViewEVCDState.Location = new System.Drawing.Point(0, 40);
            this.GridViewEVCDState.Name = "GridViewEVCDState";
            this.GridViewEVCDState.RecordNavigator = true;
            this.GridViewEVCDState.RowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewEVCDState.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition;
            this.GridViewEVCDState.RowHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewEVCDState.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.GridViewEVCDState.Size = new System.Drawing.Size(819, 465);
            this.GridViewEVCDState.TabIndex = 32;
            this.GridViewEVCDState.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.GridViewEVCDState.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010;
            this.GridViewEVCDState.BindingDataSourceSet += new System.EventHandler(this.GridViewEVCDState_BindingDataSourceSet);
            this.GridViewEVCDState.SelectionChanged += new System.EventHandler(this.GridViewEVCDState_SelectionChanged);
            // 
            // vWEVCDStateBindingSource
            // 
            this.vWEVCDStateBindingSource.DataSource = typeof(GasStationManagement.Model.EVCDState.VW_EVCDState);
            // 
            // EVCDState_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.GridViewEVCDState);
            this.Controls.Add(this.HeaderGridEVCDState);
            this.Name = "EVCDState_UC";
            this.Size = new System.Drawing.Size(819, 505);
            this.Load += new System.EventHandler(this.EVCDState_UC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewEVCDState)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWEVCDStateBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MSSHeaderGrid HeaderGridEVCDState;
        private MSSGridexView GridViewEVCDState;
        private System.Windows.Forms.BindingSource vWEVCDStateBindingSource;
    }
}
