using MSS.Library.Control;

namespace GasStationManagement.View.MainForms.PressTrans
{
    partial class PressTrans_UC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PressTrans_UC));
            Janus.Windows.GridEX.GridEXLayout GridViewPressTrans_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.tBLPressTransBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HeaderGridPressTrans = new MSS.Library.Control.MSSHeaderGrid();
            this.GridViewPressTrans = new MSS.Library.Control.MSSGridexView();
            ((System.ComponentModel.ISupportInitialize)(this.tBLPressTransBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewPressTrans)).BeginInit();
            this.SuspendLayout();
            // 
            // tBLPressTransBindingSource
            // 
            this.tBLPressTransBindingSource.DataSource = typeof(GasStationManagement.Model.Basic.DataAccess.TBL_PressureTransmitter);
            // 
            // HeaderGridPressTrans
            // 
            // 
            // 
            // 
            this.HeaderGridPressTrans.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridPressTrans.BackgroundStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridPressTrans.BackgroundStyle.BorderBottomWidth = 1;
            this.HeaderGridPressTrans.BackgroundStyle.BorderLeftWidth = 1;
            this.HeaderGridPressTrans.BackgroundStyle.BorderRightWidth = 1;
            this.HeaderGridPressTrans.BackgroundStyle.BorderTopWidth = 1;
            this.HeaderGridPressTrans.BackgroundStyle.Class = "ItemPanel";
            this.HeaderGridPressTrans.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.HeaderGridPressTrans.BackgroundStyle.PaddingBottom = 1;
            this.HeaderGridPressTrans.BackgroundStyle.PaddingLeft = 1;
            this.HeaderGridPressTrans.BackgroundStyle.PaddingRight = 1;
            this.HeaderGridPressTrans.BackgroundStyle.PaddingTop = 1;
            this.HeaderGridPressTrans.ButtonDeletePermissionCode = 0;
            this.HeaderGridPressTrans.ButtonDeleteVisible = true;
            this.HeaderGridPressTrans.ButtonEditPermissionCode = 0;
            this.HeaderGridPressTrans.ButtonEditVisible = true;
            this.HeaderGridPressTrans.ButtonExcelExportVisible = true;
            this.HeaderGridPressTrans.ButtonExcelPermissionCode = 0;
            this.HeaderGridPressTrans.ButtonInsertPermissionCode = 0;
            this.HeaderGridPressTrans.ButtonInsertVisible = true;
            this.HeaderGridPressTrans.ButtonPrintExpertPermissionCode = 0;
            this.HeaderGridPressTrans.ButtonPrintExpertVisible = false;
            this.HeaderGridPressTrans.ButtonPrintPermissionCode = 0;
            this.HeaderGridPressTrans.ButtonPrintVisible = true;
            this.HeaderGridPressTrans.ButtonRefreshVisible = true;
            this.HeaderGridPressTrans.ButtonSearchExpertVisible = false;
            this.HeaderGridPressTrans.ButtonSearchVisible = true;
            this.HeaderGridPressTrans.ButtonSelectorVisible = true;
            this.HeaderGridPressTrans.ContainerControlProcessDialogKey = true;
            this.HeaderGridPressTrans.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderGridPressTrans.FitButtonsToContainerWidth = true;
            this.HeaderGridPressTrans.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.HeaderGridPressTrans.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.HeaderGridPressTrans.Location = new System.Drawing.Point(0, 0);
            this.HeaderGridPressTrans.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HeaderGridPressTrans.Name = "HeaderGridPressTrans";
            this.HeaderGridPressTrans.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HeaderGridPressTrans.Size = new System.Drawing.Size(819, 37);
            this.HeaderGridPressTrans.TabIndex = 31;
            this.HeaderGridPressTrans.Text = "mssHeaderGrid1";
            this.HeaderGridPressTrans.ThemeAware = true;
            this.HeaderGridPressTrans.buttonItemInsertClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemInsertClickEventHandler(this.headerGridPressTrans_btnInsertClick);
            this.HeaderGridPressTrans.buttonItemEditClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemEditClickEventHandler(this.headerGridPressTrans_btnEditClick);
            this.HeaderGridPressTrans.buttonItemDeleteClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemDeleteClickEventHandler(this.headerGridPressTrans_btnDeleteClick);
            this.HeaderGridPressTrans.buttonItemRefreshClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemRefreshClickEventHandler(this.headerGridPressTrans_btnRefreshClick);
            // 
            // GridViewPressTrans
            // 
            this.GridViewPressTrans.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.GridViewPressTrans.AlternatingRowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewPressTrans.BuiltInTextsData = resources.GetString("GridViewPressTrans.BuiltInTextsData");
            this.GridViewPressTrans.CardViewGridlines = Janus.Windows.GridEX.CardViewGridlines.Both;
            this.GridViewPressTrans.DataSource = this.tBLPressTransBindingSource;
            this.GridViewPressTrans.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            GridViewPressTrans_DesignTimeLayout.LayoutString = resources.GetString("GridViewPressTrans_DesignTimeLayout.LayoutString");
            this.GridViewPressTrans.DesignTimeLayout = GridViewPressTrans_DesignTimeLayout;
            this.GridViewPressTrans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewPressTrans.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.GridViewPressTrans.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.GridViewPressTrans.Font = new System.Drawing.Font("Tahoma", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.GridViewPressTrans.GroupByBoxVisible = false;
            this.GridViewPressTrans.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewPressTrans.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
            this.GridViewPressTrans.Location = new System.Drawing.Point(0, 37);
            this.GridViewPressTrans.Name = "GridViewPressTrans";
            this.GridViewPressTrans.RecordNavigator = true;
            this.GridViewPressTrans.RowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewPressTrans.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition;
            this.GridViewPressTrans.RowHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewPressTrans.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.GridViewPressTrans.Size = new System.Drawing.Size(819, 468);
            this.GridViewPressTrans.TabIndex = 32;
            this.GridViewPressTrans.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.GridViewPressTrans.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010;
            this.GridViewPressTrans.SelectionChanged += new System.EventHandler(this.GridViewPressTrans_SelectionChanged);
            // 
            // PressTrans_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.GridViewPressTrans);
            this.Controls.Add(this.HeaderGridPressTrans);
            this.Name = "PressTrans_UC";
            this.Size = new System.Drawing.Size(819, 505);
            this.Load += new System.EventHandler(this.PressTrans_UC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tBLPressTransBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewPressTrans)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource tBLPressTransBindingSource;
        private MSSHeaderGrid HeaderGridPressTrans;
        private MSSGridexView GridViewPressTrans;
    }
}
