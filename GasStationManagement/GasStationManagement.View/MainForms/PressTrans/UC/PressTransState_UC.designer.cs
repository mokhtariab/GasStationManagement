using MSS.Library.Control;

namespace GasStationManagement.View.MainForms.PressTrans
{
    partial class PressTransState_UC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PressTransState_UC));
            Janus.Windows.GridEX.GridEXLayout GridViewPressTransState_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.HeaderGridPressTransState = new MSS.Library.Control.MSSHeaderGrid();
            this.GridViewPressTransState = new MSS.Library.Control.MSSGridexView();
            this.vWPressTransStateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewPressTransState)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWPressTransStateBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // HeaderGridPressTransState
            // 
            // 
            // 
            // 
            this.HeaderGridPressTransState.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridPressTransState.BackgroundStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridPressTransState.BackgroundStyle.BorderBottomWidth = 1;
            this.HeaderGridPressTransState.BackgroundStyle.BorderLeftWidth = 1;
            this.HeaderGridPressTransState.BackgroundStyle.BorderRightWidth = 1;
            this.HeaderGridPressTransState.BackgroundStyle.BorderTopWidth = 1;
            this.HeaderGridPressTransState.BackgroundStyle.Class = "ItemPanel";
            this.HeaderGridPressTransState.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.HeaderGridPressTransState.BackgroundStyle.PaddingBottom = 1;
            this.HeaderGridPressTransState.BackgroundStyle.PaddingLeft = 1;
            this.HeaderGridPressTransState.BackgroundStyle.PaddingRight = 1;
            this.HeaderGridPressTransState.BackgroundStyle.PaddingTop = 1;
            this.HeaderGridPressTransState.ButtonDeletePermissionCode = 0;
            this.HeaderGridPressTransState.ButtonDeleteVisible = true;
            this.HeaderGridPressTransState.ButtonEditPermissionCode = 0;
            this.HeaderGridPressTransState.ButtonEditVisible = true;
            this.HeaderGridPressTransState.ButtonExcelExportVisible = true;
            this.HeaderGridPressTransState.ButtonExcelPermissionCode = 0;
            this.HeaderGridPressTransState.ButtonInsertPermissionCode = 0;
            this.HeaderGridPressTransState.ButtonInsertVisible = true;
            this.HeaderGridPressTransState.ButtonPrintExpertPermissionCode = 0;
            this.HeaderGridPressTransState.ButtonPrintExpertVisible = false;
            this.HeaderGridPressTransState.ButtonPrintPermissionCode = 0;
            this.HeaderGridPressTransState.ButtonPrintVisible = true;
            this.HeaderGridPressTransState.ButtonRefreshVisible = true;
            this.HeaderGridPressTransState.ButtonSearchExpertVisible = false;
            this.HeaderGridPressTransState.ButtonSearchVisible = true;
            this.HeaderGridPressTransState.ButtonSelectorVisible = true;
            this.HeaderGridPressTransState.ContainerControlProcessDialogKey = true;
            this.HeaderGridPressTransState.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderGridPressTransState.FitButtonsToContainerWidth = true;
            this.HeaderGridPressTransState.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.HeaderGridPressTransState.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.HeaderGridPressTransState.GridViewSet = this.GridViewPressTransState;
            this.HeaderGridPressTransState.Location = new System.Drawing.Point(0, 0);
            this.HeaderGridPressTransState.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HeaderGridPressTransState.Name = "HeaderGridPressTransState";
            this.HeaderGridPressTransState.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HeaderGridPressTransState.Size = new System.Drawing.Size(819, 40);
            this.HeaderGridPressTransState.TabIndex = 31;
            this.HeaderGridPressTransState.Text = "mssHeaderGrid1";
            this.HeaderGridPressTransState.ThemeAware = true;
            this.HeaderGridPressTransState.buttonItemInsertClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemInsertClickEventHandler(this.headerGridPressTransState_btnInsertClick);
            this.HeaderGridPressTransState.buttonItemEditClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemEditClickEventHandler(this.headerGridPressTransState_btnEditClick);
            this.HeaderGridPressTransState.buttonItemDeleteClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemDeleteClickEventHandler(this.headerGridPressTransState_btnDeleteClick);
            this.HeaderGridPressTransState.buttonItemRefreshClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemRefreshClickEventHandler(this.headerGridPressTransState_btnRefreshClick);
            // 
            // GridViewPressTransState
            // 
            this.GridViewPressTransState.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.GridViewPressTransState.AlternatingRowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewPressTransState.BuiltInTextsData = resources.GetString("GridViewPressTransState.BuiltInTextsData");
            this.GridViewPressTransState.CardViewGridlines = Janus.Windows.GridEX.CardViewGridlines.Both;
            this.GridViewPressTransState.DataSource = this.vWPressTransStateBindingSource;
            this.GridViewPressTransState.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            GridViewPressTransState_DesignTimeLayout.LayoutString = resources.GetString("GridViewPressTransState_DesignTimeLayout.LayoutString");
            this.GridViewPressTransState.DesignTimeLayout = GridViewPressTransState_DesignTimeLayout;
            this.GridViewPressTransState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewPressTransState.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.GridViewPressTransState.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.GridViewPressTransState.Font = new System.Drawing.Font("Tahoma", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.GridViewPressTransState.GroupByBoxVisible = false;
            this.GridViewPressTransState.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewPressTransState.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
            this.GridViewPressTransState.Location = new System.Drawing.Point(0, 40);
            this.GridViewPressTransState.Name = "GridViewPressTransState";
            this.GridViewPressTransState.RecordNavigator = true;
            this.GridViewPressTransState.RowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewPressTransState.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition;
            this.GridViewPressTransState.RowHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewPressTransState.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.GridViewPressTransState.Size = new System.Drawing.Size(819, 465);
            this.GridViewPressTransState.TabIndex = 32;
            this.GridViewPressTransState.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.GridViewPressTransState.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010;
            this.GridViewPressTransState.BindingDataSourceSet += new System.EventHandler(this.GridViewPressTransState_BindingDataSourceSet);
            this.GridViewPressTransState.SelectionChanged += new System.EventHandler(this.GridViewPressTransState_SelectionChanged);
            // 
            // vWPressTransStateBindingSource
            // 
            this.vWPressTransStateBindingSource.DataSource = typeof(GasStationManagement.Model.PressTransState.VW_PressTransState);
            // 
            // PressTransState_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.GridViewPressTransState);
            this.Controls.Add(this.HeaderGridPressTransState);
            this.Name = "PressTransState_UC";
            this.Size = new System.Drawing.Size(819, 505);
            this.Load += new System.EventHandler(this.PressTransState_UC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewPressTransState)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWPressTransStateBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MSSHeaderGrid HeaderGridPressTransState;
        private MSSGridexView GridViewPressTransState;
        private System.Windows.Forms.BindingSource vWPressTransStateBindingSource;
    }
}
