using MSS.Library.Control;

namespace GasStationManagement.View.MainForms.PressTrans
{
    partial class PressTransSupply_UC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PressTransSupply_UC));
            Janus.Windows.GridEX.GridEXLayout GridViewPressTransSupply_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.HeaderGridPressTransSupply = new MSS.Library.Control.MSSHeaderGrid();
            this.GridViewPressTransSupply = new MSS.Library.Control.MSSGridexView();
            this.vWPressTransSupplyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewPressTransSupply)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWPressTransSupplyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // HeaderGridPressTransSupply
            // 
            // 
            // 
            // 
            this.HeaderGridPressTransSupply.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridPressTransSupply.BackgroundStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridPressTransSupply.BackgroundStyle.BorderBottomWidth = 1;
            this.HeaderGridPressTransSupply.BackgroundStyle.BorderLeftWidth = 1;
            this.HeaderGridPressTransSupply.BackgroundStyle.BorderRightWidth = 1;
            this.HeaderGridPressTransSupply.BackgroundStyle.BorderTopWidth = 1;
            this.HeaderGridPressTransSupply.BackgroundStyle.Class = "ItemPanel";
            this.HeaderGridPressTransSupply.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.HeaderGridPressTransSupply.BackgroundStyle.PaddingBottom = 1;
            this.HeaderGridPressTransSupply.BackgroundStyle.PaddingLeft = 1;
            this.HeaderGridPressTransSupply.BackgroundStyle.PaddingRight = 1;
            this.HeaderGridPressTransSupply.BackgroundStyle.PaddingTop = 1;
            this.HeaderGridPressTransSupply.ButtonDeletePermissionCode = 0;
            this.HeaderGridPressTransSupply.ButtonDeleteVisible = true;
            this.HeaderGridPressTransSupply.ButtonEditPermissionCode = 0;
            this.HeaderGridPressTransSupply.ButtonEditVisible = true;
            this.HeaderGridPressTransSupply.ButtonExcelExportVisible = true;
            this.HeaderGridPressTransSupply.ButtonExcelPermissionCode = 0;
            this.HeaderGridPressTransSupply.ButtonInsertPermissionCode = 0;
            this.HeaderGridPressTransSupply.ButtonInsertVisible = true;
            this.HeaderGridPressTransSupply.ButtonPrintExpertPermissionCode = 0;
            this.HeaderGridPressTransSupply.ButtonPrintExpertVisible = false;
            this.HeaderGridPressTransSupply.ButtonPrintPermissionCode = 0;
            this.HeaderGridPressTransSupply.ButtonPrintVisible = true;
            this.HeaderGridPressTransSupply.ButtonRefreshVisible = true;
            this.HeaderGridPressTransSupply.ButtonSearchExpertVisible = false;
            this.HeaderGridPressTransSupply.ButtonSearchVisible = true;
            this.HeaderGridPressTransSupply.ButtonSelectorVisible = true;
            this.HeaderGridPressTransSupply.ContainerControlProcessDialogKey = true;
            this.HeaderGridPressTransSupply.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderGridPressTransSupply.FitButtonsToContainerWidth = true;
            this.HeaderGridPressTransSupply.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.HeaderGridPressTransSupply.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.HeaderGridPressTransSupply.GridViewSet = this.GridViewPressTransSupply;
            this.HeaderGridPressTransSupply.Location = new System.Drawing.Point(0, 0);
            this.HeaderGridPressTransSupply.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HeaderGridPressTransSupply.Name = "HeaderGridPressTransSupply";
            this.HeaderGridPressTransSupply.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HeaderGridPressTransSupply.Size = new System.Drawing.Size(819, 35);
            this.HeaderGridPressTransSupply.TabIndex = 31;
            this.HeaderGridPressTransSupply.Text = "mssHeaderGrid1";
            this.HeaderGridPressTransSupply.ThemeAware = true;
            this.HeaderGridPressTransSupply.buttonItemInsertClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemInsertClickEventHandler(this.headerGridPressTransSupply_btnInsertClick);
            this.HeaderGridPressTransSupply.buttonItemEditClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemEditClickEventHandler(this.headerGridPressTransSupply_btnEditClick);
            this.HeaderGridPressTransSupply.buttonItemDeleteClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemDeleteClickEventHandler(this.headerGridPressTransSupply_btnDeleteClick);
            this.HeaderGridPressTransSupply.buttonItemRefreshClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemRefreshClickEventHandler(this.headerGridPressTransSupply_btnRefreshClick);
            // 
            // GridViewPressTransSupply
            // 
            this.GridViewPressTransSupply.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.GridViewPressTransSupply.AlternatingRowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewPressTransSupply.BuiltInTextsData = resources.GetString("GridViewPressTransSupply.BuiltInTextsData");
            this.GridViewPressTransSupply.CardViewGridlines = Janus.Windows.GridEX.CardViewGridlines.Both;
            this.GridViewPressTransSupply.DataSource = this.vWPressTransSupplyBindingSource;
            this.GridViewPressTransSupply.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            GridViewPressTransSupply_DesignTimeLayout.LayoutString = resources.GetString("GridViewPressTransSupply_DesignTimeLayout.LayoutString");
            this.GridViewPressTransSupply.DesignTimeLayout = GridViewPressTransSupply_DesignTimeLayout;
            this.GridViewPressTransSupply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewPressTransSupply.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.GridViewPressTransSupply.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.GridViewPressTransSupply.Font = new System.Drawing.Font("Tahoma", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.GridViewPressTransSupply.GroupByBoxVisible = false;
            this.GridViewPressTransSupply.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewPressTransSupply.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
            this.GridViewPressTransSupply.Location = new System.Drawing.Point(0, 35);
            this.GridViewPressTransSupply.Name = "GridViewPressTransSupply";
            this.GridViewPressTransSupply.RecordNavigator = true;
            this.GridViewPressTransSupply.RowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewPressTransSupply.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition;
            this.GridViewPressTransSupply.RowHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewPressTransSupply.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.GridViewPressTransSupply.Size = new System.Drawing.Size(819, 470);
            this.GridViewPressTransSupply.TabIndex = 32;
            this.GridViewPressTransSupply.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.GridViewPressTransSupply.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010;
            this.GridViewPressTransSupply.BindingDataSourceSet += new System.EventHandler(this.GridViewPressTransSupply_BindingDataSourceSet);
            this.GridViewPressTransSupply.SelectionChanged += new System.EventHandler(this.GridViewPressTransSupply_SelectionChanged);
            // 
            // vWPressTransSupplyBindingSource
            // 
            this.vWPressTransSupplyBindingSource.DataSource = typeof(GasStationManagement.Model.PressTransSupply.VW_PressTransSupply);
            // 
            // PressTransSupply_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.GridViewPressTransSupply);
            this.Controls.Add(this.HeaderGridPressTransSupply);
            this.Name = "PressTransSupply_UC";
            this.Size = new System.Drawing.Size(819, 505);
            this.Load += new System.EventHandler(this.PressTransSupply_UC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewPressTransSupply)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWPressTransSupplyBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MSSHeaderGrid HeaderGridPressTransSupply;
        private MSSGridexView GridViewPressTransSupply;
        private System.Windows.Forms.BindingSource vWPressTransSupplyBindingSource;
    }
}
