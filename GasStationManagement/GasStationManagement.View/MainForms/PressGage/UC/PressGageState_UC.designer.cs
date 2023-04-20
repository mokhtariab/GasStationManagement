using MSS.Library.Control;

namespace GasStationManagement.View.MainForms.PressGage
{
    partial class PressGageState_UC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PressGageState_UC));
            Janus.Windows.GridEX.GridEXLayout GridViewPressGageState_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.HeaderGridPressGageState = new MSS.Library.Control.MSSHeaderGrid();
            this.GridViewPressGageState = new MSS.Library.Control.MSSGridexView();
            this.vWPressGageStateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewPressGageState)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWPressGageStateBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // HeaderGridPressGageState
            // 
            // 
            // 
            // 
            this.HeaderGridPressGageState.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridPressGageState.BackgroundStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridPressGageState.BackgroundStyle.BorderBottomWidth = 1;
            this.HeaderGridPressGageState.BackgroundStyle.BorderLeftWidth = 1;
            this.HeaderGridPressGageState.BackgroundStyle.BorderRightWidth = 1;
            this.HeaderGridPressGageState.BackgroundStyle.BorderTopWidth = 1;
            this.HeaderGridPressGageState.BackgroundStyle.Class = "ItemPanel";
            this.HeaderGridPressGageState.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.HeaderGridPressGageState.BackgroundStyle.PaddingBottom = 1;
            this.HeaderGridPressGageState.BackgroundStyle.PaddingLeft = 1;
            this.HeaderGridPressGageState.BackgroundStyle.PaddingRight = 1;
            this.HeaderGridPressGageState.BackgroundStyle.PaddingTop = 1;
            this.HeaderGridPressGageState.ButtonDeletePermissionCode = 0;
            this.HeaderGridPressGageState.ButtonDeleteVisible = true;
            this.HeaderGridPressGageState.ButtonEditPermissionCode = 0;
            this.HeaderGridPressGageState.ButtonEditVisible = true;
            this.HeaderGridPressGageState.ButtonExcelExportVisible = true;
            this.HeaderGridPressGageState.ButtonExcelPermissionCode = 0;
            this.HeaderGridPressGageState.ButtonInsertPermissionCode = 0;
            this.HeaderGridPressGageState.ButtonInsertVisible = true;
            this.HeaderGridPressGageState.ButtonPrintExpertPermissionCode = 0;
            this.HeaderGridPressGageState.ButtonPrintExpertVisible = false;
            this.HeaderGridPressGageState.ButtonPrintPermissionCode = 0;
            this.HeaderGridPressGageState.ButtonPrintVisible = true;
            this.HeaderGridPressGageState.ButtonRefreshVisible = true;
            this.HeaderGridPressGageState.ButtonSearchExpertVisible = false;
            this.HeaderGridPressGageState.ButtonSearchVisible = true;
            this.HeaderGridPressGageState.ButtonSelectorVisible = true;
            this.HeaderGridPressGageState.ContainerControlProcessDialogKey = true;
            this.HeaderGridPressGageState.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderGridPressGageState.FitButtonsToContainerWidth = true;
            this.HeaderGridPressGageState.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.HeaderGridPressGageState.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.HeaderGridPressGageState.GridViewSet = this.GridViewPressGageState;
            this.HeaderGridPressGageState.Location = new System.Drawing.Point(0, 0);
            this.HeaderGridPressGageState.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HeaderGridPressGageState.Name = "HeaderGridPressGageState";
            this.HeaderGridPressGageState.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HeaderGridPressGageState.Size = new System.Drawing.Size(819, 35);
            this.HeaderGridPressGageState.TabIndex = 31;
            this.HeaderGridPressGageState.Text = "mssHeaderGrid1";
            this.HeaderGridPressGageState.ThemeAware = true;
            this.HeaderGridPressGageState.buttonItemInsertClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemInsertClickEventHandler(this.headerGridPressGageState_btnInsertClick);
            this.HeaderGridPressGageState.buttonItemEditClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemEditClickEventHandler(this.headerGridPressGageState_btnEditClick);
            this.HeaderGridPressGageState.buttonItemDeleteClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemDeleteClickEventHandler(this.headerGridPressGageState_btnDeleteClick);
            this.HeaderGridPressGageState.buttonItemRefreshClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemRefreshClickEventHandler(this.headerGridPressGageState_btnRefreshClick);
            // 
            // GridViewPressGageState
            // 
            this.GridViewPressGageState.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.GridViewPressGageState.AlternatingRowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewPressGageState.BuiltInTextsData = resources.GetString("GridViewPressGageState.BuiltInTextsData");
            this.GridViewPressGageState.CardViewGridlines = Janus.Windows.GridEX.CardViewGridlines.Both;
            this.GridViewPressGageState.DataSource = this.vWPressGageStateBindingSource;
            this.GridViewPressGageState.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            GridViewPressGageState_DesignTimeLayout.LayoutString = resources.GetString("GridViewPressGageState_DesignTimeLayout.LayoutString");
            this.GridViewPressGageState.DesignTimeLayout = GridViewPressGageState_DesignTimeLayout;
            this.GridViewPressGageState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewPressGageState.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.GridViewPressGageState.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.GridViewPressGageState.Font = new System.Drawing.Font("Tahoma", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.GridViewPressGageState.GroupByBoxVisible = false;
            this.GridViewPressGageState.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewPressGageState.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
            this.GridViewPressGageState.Location = new System.Drawing.Point(0, 35);
            this.GridViewPressGageState.Name = "GridViewPressGageState";
            this.GridViewPressGageState.RecordNavigator = true;
            this.GridViewPressGageState.RowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewPressGageState.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition;
            this.GridViewPressGageState.RowHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewPressGageState.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.GridViewPressGageState.Size = new System.Drawing.Size(819, 470);
            this.GridViewPressGageState.TabIndex = 32;
            this.GridViewPressGageState.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.GridViewPressGageState.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010;
            this.GridViewPressGageState.BindingDataSourceSet += new System.EventHandler(this.GridViewPressGageState_BindingDataSourceSet);
            this.GridViewPressGageState.SelectionChanged += new System.EventHandler(this.GridViewPressGageState_SelectionChanged);
            // 
            // vWPressGageStateBindingSource
            // 
            this.vWPressGageStateBindingSource.DataSource = typeof(GasStationManagement.Model.PressGageState.VW_PressGageState);
            // 
            // PressGageState_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.GridViewPressGageState);
            this.Controls.Add(this.HeaderGridPressGageState);
            this.Name = "PressGageState_UC";
            this.Size = new System.Drawing.Size(819, 505);
            this.Load += new System.EventHandler(this.PressGageState_UC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewPressGageState)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWPressGageStateBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MSSHeaderGrid HeaderGridPressGageState;
        private MSSGridexView GridViewPressGageState;
        private System.Windows.Forms.BindingSource vWPressGageStateBindingSource;
    }
}
