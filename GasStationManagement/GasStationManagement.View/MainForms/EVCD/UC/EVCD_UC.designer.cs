using MSS.Library.Control;

namespace GasStationManagement.View.MainForms.EVCD
{
    partial class EVCD_UC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EVCD_UC));
            Janus.Windows.GridEX.GridEXLayout GridViewEVCD_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.HeaderGridEVCD = new MSS.Library.Control.MSSHeaderGrid();
            this.GridViewEVCD = new MSS.Library.Control.MSSGridexView();
            this.tBLEVCDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewEVCD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLEVCDBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // HeaderGridEVCD
            // 
            // 
            // 
            // 
            this.HeaderGridEVCD.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridEVCD.BackgroundStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridEVCD.BackgroundStyle.BorderBottomWidth = 1;
            this.HeaderGridEVCD.BackgroundStyle.BorderLeftWidth = 1;
            this.HeaderGridEVCD.BackgroundStyle.BorderRightWidth = 1;
            this.HeaderGridEVCD.BackgroundStyle.BorderTopWidth = 1;
            this.HeaderGridEVCD.BackgroundStyle.Class = "ItemPanel";
            this.HeaderGridEVCD.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.HeaderGridEVCD.BackgroundStyle.PaddingBottom = 1;
            this.HeaderGridEVCD.BackgroundStyle.PaddingLeft = 1;
            this.HeaderGridEVCD.BackgroundStyle.PaddingRight = 1;
            this.HeaderGridEVCD.BackgroundStyle.PaddingTop = 1;
            this.HeaderGridEVCD.ButtonDeletePermissionCode = 0;
            this.HeaderGridEVCD.ButtonDeleteVisible = true;
            this.HeaderGridEVCD.ButtonEditPermissionCode = 0;
            this.HeaderGridEVCD.ButtonEditVisible = true;
            this.HeaderGridEVCD.ButtonExcelExportVisible = true;
            this.HeaderGridEVCD.ButtonExcelPermissionCode = 0;
            this.HeaderGridEVCD.ButtonInsertPermissionCode = 0;
            this.HeaderGridEVCD.ButtonInsertVisible = true;
            this.HeaderGridEVCD.ButtonPrintExpertPermissionCode = 0;
            this.HeaderGridEVCD.ButtonPrintExpertVisible = false;
            this.HeaderGridEVCD.ButtonPrintPermissionCode = 0;
            this.HeaderGridEVCD.ButtonPrintVisible = true;
            this.HeaderGridEVCD.ButtonRefreshVisible = true;
            this.HeaderGridEVCD.ButtonSearchExpertVisible = false;
            this.HeaderGridEVCD.ButtonSearchVisible = true;
            this.HeaderGridEVCD.ButtonSelectorVisible = true;
            this.HeaderGridEVCD.ContainerControlProcessDialogKey = true;
            this.HeaderGridEVCD.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderGridEVCD.FitButtonsToContainerWidth = true;
            this.HeaderGridEVCD.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.HeaderGridEVCD.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.HeaderGridEVCD.Location = new System.Drawing.Point(0, 0);
            this.HeaderGridEVCD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HeaderGridEVCD.Name = "HeaderGridEVCD";
            this.HeaderGridEVCD.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HeaderGridEVCD.Size = new System.Drawing.Size(819, 39);
            this.HeaderGridEVCD.TabIndex = 31;
            this.HeaderGridEVCD.Text = "mssHeaderGrid1";
            this.HeaderGridEVCD.ThemeAware = true;
            this.HeaderGridEVCD.buttonItemInsertClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemInsertClickEventHandler(this.headerGridEVCD_btnInsertClick);
            this.HeaderGridEVCD.buttonItemEditClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemEditClickEventHandler(this.headerGridEVCD_btnEditClick);
            this.HeaderGridEVCD.buttonItemDeleteClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemDeleteClickEventHandler(this.headerGridEVCD_btnDeleteClick);
            this.HeaderGridEVCD.buttonItemRefreshClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemRefreshClickEventHandler(this.headerGridEVCD_btnRefreshClick);
            // 
            // GridViewEVCD
            // 
            this.GridViewEVCD.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.GridViewEVCD.AlternatingRowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewEVCD.BuiltInTextsData = resources.GetString("GridViewEVCD.BuiltInTextsData");
            this.GridViewEVCD.CardViewGridlines = Janus.Windows.GridEX.CardViewGridlines.Both;
            this.GridViewEVCD.DataSource = this.tBLEVCDBindingSource;
            this.GridViewEVCD.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            GridViewEVCD_DesignTimeLayout.LayoutString = resources.GetString("GridViewEVCD_DesignTimeLayout.LayoutString");
            this.GridViewEVCD.DesignTimeLayout = GridViewEVCD_DesignTimeLayout;
            this.GridViewEVCD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewEVCD.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.GridViewEVCD.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.GridViewEVCD.Font = new System.Drawing.Font("Tahoma", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.GridViewEVCD.GroupByBoxVisible = false;
            this.GridViewEVCD.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewEVCD.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
            this.GridViewEVCD.Location = new System.Drawing.Point(0, 39);
            this.GridViewEVCD.Name = "GridViewEVCD";
            this.GridViewEVCD.RecordNavigator = true;
            this.GridViewEVCD.RowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewEVCD.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition;
            this.GridViewEVCD.RowHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewEVCD.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.GridViewEVCD.Size = new System.Drawing.Size(819, 352);
            this.GridViewEVCD.TabIndex = 32;
            this.GridViewEVCD.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.GridViewEVCD.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010;
            this.GridViewEVCD.SelectionChanged += new System.EventHandler(this.GridViewEVCD_SelectionChanged);
            // 
            // tBLEVCDBindingSource
            // 
            this.tBLEVCDBindingSource.DataSource = typeof(GasStationManagement.Model.Basic.DataAccess.TBL_EVCD);
            // 
            // EVCD_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.GridViewEVCD);
            this.Controls.Add(this.HeaderGridEVCD);
            this.Name = "EVCD_UC";
            this.Size = new System.Drawing.Size(819, 391);
            this.Load += new System.EventHandler(this.EVCD_UC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewEVCD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLEVCDBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MSSHeaderGrid HeaderGridEVCD;
        private MSSGridexView GridViewEVCD;
        private System.Windows.Forms.BindingSource tBLEVCDBindingSource;
    }
}
