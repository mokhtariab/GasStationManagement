using MSS.Library.Control;

namespace GasStationManagement.View.MainForms.PressGage
{
    partial class PressGage_UC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PressGage_UC));
            Janus.Windows.GridEX.GridEXLayout GridViewPressGage_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.tBLPressGageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HeaderGridPressGage = new MSS.Library.Control.MSSHeaderGrid();
            this.GridViewPressGage = new MSS.Library.Control.MSSGridexView();
            ((System.ComponentModel.ISupportInitialize)(this.tBLPressGageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewPressGage)).BeginInit();
            this.SuspendLayout();
            // 
            // tBLPressGageBindingSource
            // 
            this.tBLPressGageBindingSource.DataSource = typeof(GasStationManagement.Model.Basic.DataAccess.TBL_PressureGage);
            // 
            // HeaderGridPressGage
            // 
            // 
            // 
            // 
            this.HeaderGridPressGage.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridPressGage.BackgroundStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridPressGage.BackgroundStyle.BorderBottomWidth = 1;
            this.HeaderGridPressGage.BackgroundStyle.BorderLeftWidth = 1;
            this.HeaderGridPressGage.BackgroundStyle.BorderRightWidth = 1;
            this.HeaderGridPressGage.BackgroundStyle.BorderTopWidth = 1;
            this.HeaderGridPressGage.BackgroundStyle.Class = "ItemPanel";
            this.HeaderGridPressGage.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.HeaderGridPressGage.BackgroundStyle.PaddingBottom = 1;
            this.HeaderGridPressGage.BackgroundStyle.PaddingLeft = 1;
            this.HeaderGridPressGage.BackgroundStyle.PaddingRight = 1;
            this.HeaderGridPressGage.BackgroundStyle.PaddingTop = 1;
            this.HeaderGridPressGage.ButtonDeletePermissionCode = 0;
            this.HeaderGridPressGage.ButtonDeleteVisible = true;
            this.HeaderGridPressGage.ButtonEditPermissionCode = 0;
            this.HeaderGridPressGage.ButtonEditVisible = true;
            this.HeaderGridPressGage.ButtonExcelExportVisible = true;
            this.HeaderGridPressGage.ButtonExcelPermissionCode = 0;
            this.HeaderGridPressGage.ButtonInsertPermissionCode = 0;
            this.HeaderGridPressGage.ButtonInsertVisible = true;
            this.HeaderGridPressGage.ButtonPrintExpertPermissionCode = 0;
            this.HeaderGridPressGage.ButtonPrintExpertVisible = false;
            this.HeaderGridPressGage.ButtonPrintPermissionCode = 0;
            this.HeaderGridPressGage.ButtonPrintVisible = true;
            this.HeaderGridPressGage.ButtonRefreshVisible = true;
            this.HeaderGridPressGage.ButtonSearchExpertVisible = false;
            this.HeaderGridPressGage.ButtonSearchVisible = true;
            this.HeaderGridPressGage.ButtonSelectorVisible = true;
            this.HeaderGridPressGage.ContainerControlProcessDialogKey = true;
            this.HeaderGridPressGage.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderGridPressGage.FitButtonsToContainerWidth = true;
            this.HeaderGridPressGage.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.HeaderGridPressGage.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.HeaderGridPressGage.Location = new System.Drawing.Point(0, 0);
            this.HeaderGridPressGage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HeaderGridPressGage.Name = "HeaderGridPressGage";
            this.HeaderGridPressGage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HeaderGridPressGage.Size = new System.Drawing.Size(819, 38);
            this.HeaderGridPressGage.TabIndex = 31;
            this.HeaderGridPressGage.Text = "mssHeaderGrid1";
            this.HeaderGridPressGage.ThemeAware = true;
            this.HeaderGridPressGage.buttonItemInsertClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemInsertClickEventHandler(this.headerGridPressGage_btnInsertClick);
            this.HeaderGridPressGage.buttonItemEditClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemEditClickEventHandler(this.headerGridPressGage_btnEditClick);
            this.HeaderGridPressGage.buttonItemDeleteClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemDeleteClickEventHandler(this.headerGridPressGage_btnDeleteClick);
            this.HeaderGridPressGage.buttonItemRefreshClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemRefreshClickEventHandler(this.headerGridPressGage_btnRefreshClick);
            // 
            // GridViewPressGage
            // 
            this.GridViewPressGage.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.GridViewPressGage.AlternatingRowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewPressGage.BuiltInTextsData = resources.GetString("GridViewPressGage.BuiltInTextsData");
            this.GridViewPressGage.CardViewGridlines = Janus.Windows.GridEX.CardViewGridlines.Both;
            this.GridViewPressGage.DataSource = this.tBLPressGageBindingSource;
            this.GridViewPressGage.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            GridViewPressGage_DesignTimeLayout.LayoutString = resources.GetString("GridViewPressGage_DesignTimeLayout.LayoutString");
            this.GridViewPressGage.DesignTimeLayout = GridViewPressGage_DesignTimeLayout;
            this.GridViewPressGage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewPressGage.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.GridViewPressGage.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.GridViewPressGage.Font = new System.Drawing.Font("Tahoma", 8.150944F);
            this.GridViewPressGage.GroupByBoxVisible = false;
            this.GridViewPressGage.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewPressGage.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
            this.GridViewPressGage.Location = new System.Drawing.Point(0, 38);
            this.GridViewPressGage.Name = "GridViewPressGage";
            this.GridViewPressGage.RecordNavigator = true;
            this.GridViewPressGage.RowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewPressGage.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition;
            this.GridViewPressGage.RowHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewPressGage.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.GridViewPressGage.Size = new System.Drawing.Size(819, 280);
            this.GridViewPressGage.TabIndex = 32;
            this.GridViewPressGage.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.GridViewPressGage.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010;
            this.GridViewPressGage.FormattingRow += new Janus.Windows.GridEX.RowLoadEventHandler(this.GridViewPressGage_FormattingRow);
            this.GridViewPressGage.SelectionChanged += new System.EventHandler(this.GridViewPressGage_SelectionChanged);
            // 
            // PressGage_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.GridViewPressGage);
            this.Controls.Add(this.HeaderGridPressGage);
            this.Name = "PressGage_UC";
            this.Size = new System.Drawing.Size(819, 318);
            this.Load += new System.EventHandler(this.PressGage_UC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tBLPressGageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewPressGage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource tBLPressGageBindingSource;
        private MSSHeaderGrid HeaderGridPressGage;
        private MSSGridexView GridViewPressGage;
    }
}
