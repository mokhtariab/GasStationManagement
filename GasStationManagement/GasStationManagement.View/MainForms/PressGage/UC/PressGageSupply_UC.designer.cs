using MSS.Library.Control;

namespace GasStationManagement.View.MainForms.PressGage
{
    partial class PressGageSupply_UC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PressGageSupply_UC));
            Janus.Windows.GridEX.GridEXLayout GridViewPressGageSupply_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.HeaderGridPressGageSupply = new MSS.Library.Control.MSSHeaderGrid();
            this.GridViewPressGageSupply = new MSS.Library.Control.MSSGridexView();
            this.vWPressGageSupplyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewPressGageSupply)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWPressGageSupplyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // HeaderGridPressGageSupply
            // 
            // 
            // 
            // 
            this.HeaderGridPressGageSupply.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridPressGageSupply.BackgroundStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridPressGageSupply.BackgroundStyle.BorderBottomWidth = 1;
            this.HeaderGridPressGageSupply.BackgroundStyle.BorderLeftWidth = 1;
            this.HeaderGridPressGageSupply.BackgroundStyle.BorderRightWidth = 1;
            this.HeaderGridPressGageSupply.BackgroundStyle.BorderTopWidth = 1;
            this.HeaderGridPressGageSupply.BackgroundStyle.Class = "ItemPanel";
            this.HeaderGridPressGageSupply.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.HeaderGridPressGageSupply.BackgroundStyle.PaddingBottom = 1;
            this.HeaderGridPressGageSupply.BackgroundStyle.PaddingLeft = 1;
            this.HeaderGridPressGageSupply.BackgroundStyle.PaddingRight = 1;
            this.HeaderGridPressGageSupply.BackgroundStyle.PaddingTop = 1;
            this.HeaderGridPressGageSupply.ButtonDeletePermissionCode = 0;
            this.HeaderGridPressGageSupply.ButtonDeleteVisible = true;
            this.HeaderGridPressGageSupply.ButtonEditPermissionCode = 0;
            this.HeaderGridPressGageSupply.ButtonEditVisible = true;
            this.HeaderGridPressGageSupply.ButtonExcelExportVisible = true;
            this.HeaderGridPressGageSupply.ButtonExcelPermissionCode = 0;
            this.HeaderGridPressGageSupply.ButtonInsertPermissionCode = 0;
            this.HeaderGridPressGageSupply.ButtonInsertVisible = true;
            this.HeaderGridPressGageSupply.ButtonPrintExpertPermissionCode = 0;
            this.HeaderGridPressGageSupply.ButtonPrintExpertVisible = false;
            this.HeaderGridPressGageSupply.ButtonPrintPermissionCode = 0;
            this.HeaderGridPressGageSupply.ButtonPrintVisible = true;
            this.HeaderGridPressGageSupply.ButtonRefreshVisible = true;
            this.HeaderGridPressGageSupply.ButtonSearchExpertVisible = false;
            this.HeaderGridPressGageSupply.ButtonSearchVisible = true;
            this.HeaderGridPressGageSupply.ButtonSelectorVisible = true;
            this.HeaderGridPressGageSupply.ContainerControlProcessDialogKey = true;
            this.HeaderGridPressGageSupply.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderGridPressGageSupply.FitButtonsToContainerWidth = true;
            this.HeaderGridPressGageSupply.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.HeaderGridPressGageSupply.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.HeaderGridPressGageSupply.GridViewSet = this.GridViewPressGageSupply;
            this.HeaderGridPressGageSupply.Location = new System.Drawing.Point(0, 0);
            this.HeaderGridPressGageSupply.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HeaderGridPressGageSupply.Name = "HeaderGridPressGageSupply";
            this.HeaderGridPressGageSupply.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HeaderGridPressGageSupply.Size = new System.Drawing.Size(819, 38);
            this.HeaderGridPressGageSupply.TabIndex = 31;
            this.HeaderGridPressGageSupply.Text = "mssHeaderGrid1";
            this.HeaderGridPressGageSupply.ThemeAware = true;
            this.HeaderGridPressGageSupply.buttonItemInsertClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemInsertClickEventHandler(this.headerGridPressGageSupply_btnInsertClick);
            this.HeaderGridPressGageSupply.buttonItemEditClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemEditClickEventHandler(this.headerGridPressGageSupply_btnEditClick);
            this.HeaderGridPressGageSupply.buttonItemDeleteClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemDeleteClickEventHandler(this.headerGridPressGageSupply_btnDeleteClick);
            this.HeaderGridPressGageSupply.buttonItemRefreshClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemRefreshClickEventHandler(this.headerGridPressGageSupply_btnRefreshClick);
            // 
            // GridViewPressGageSupply
            // 
            this.GridViewPressGageSupply.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.GridViewPressGageSupply.AlternatingRowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewPressGageSupply.BuiltInTextsData = resources.GetString("GridViewPressGageSupply.BuiltInTextsData");
            this.GridViewPressGageSupply.CardViewGridlines = Janus.Windows.GridEX.CardViewGridlines.Both;
            this.GridViewPressGageSupply.DataSource = this.vWPressGageSupplyBindingSource;
            this.GridViewPressGageSupply.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            GridViewPressGageSupply_DesignTimeLayout.LayoutString = resources.GetString("GridViewPressGageSupply_DesignTimeLayout.LayoutString");
            this.GridViewPressGageSupply.DesignTimeLayout = GridViewPressGageSupply_DesignTimeLayout;
            this.GridViewPressGageSupply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewPressGageSupply.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.GridViewPressGageSupply.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.GridViewPressGageSupply.Font = new System.Drawing.Font("Tahoma", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.GridViewPressGageSupply.GroupByBoxVisible = false;
            this.GridViewPressGageSupply.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewPressGageSupply.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
            this.GridViewPressGageSupply.Location = new System.Drawing.Point(0, 38);
            this.GridViewPressGageSupply.Name = "GridViewPressGageSupply";
            this.GridViewPressGageSupply.RecordNavigator = true;
            this.GridViewPressGageSupply.RowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewPressGageSupply.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition;
            this.GridViewPressGageSupply.RowHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewPressGageSupply.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.GridViewPressGageSupply.Size = new System.Drawing.Size(819, 467);
            this.GridViewPressGageSupply.TabIndex = 32;
            this.GridViewPressGageSupply.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.GridViewPressGageSupply.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010;
            this.GridViewPressGageSupply.BindingDataSourceSet += new System.EventHandler(this.GridViewPressGageSupply_BindingDataSourceSet);
            this.GridViewPressGageSupply.SelectionChanged += new System.EventHandler(this.GridViewPressGageSupply_SelectionChanged);
            // 
            // vWPressGageSupplyBindingSource
            // 
            this.vWPressGageSupplyBindingSource.DataSource = typeof(GasStationManagement.Model.PressGageSupply.VW_PressGageSupply);
            // 
            // PressGageSupply_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.GridViewPressGageSupply);
            this.Controls.Add(this.HeaderGridPressGageSupply);
            this.Name = "PressGageSupply_UC";
            this.Size = new System.Drawing.Size(819, 505);
            this.Load += new System.EventHandler(this.PressGageSupply_UC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewPressGageSupply)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWPressGageSupplyBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MSSHeaderGrid HeaderGridPressGageSupply;
        private MSSGridexView GridViewPressGageSupply;
        private System.Windows.Forms.BindingSource vWPressGageSupplyBindingSource;
    }
}
