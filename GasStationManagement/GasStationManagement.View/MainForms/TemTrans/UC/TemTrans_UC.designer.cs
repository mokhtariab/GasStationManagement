using MSS.Library.Control;

namespace GasStationManagement.View.MainForms.TemTrans
{
    partial class TemTrans_UC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TemTrans_UC));
            Janus.Windows.GridEX.GridEXLayout GridViewTemTrans_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.tBLTemTransBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HeaderGridTemTrans = new MSS.Library.Control.MSSHeaderGrid();
            this.GridViewTemTrans = new MSS.Library.Control.MSSGridexView();
            ((System.ComponentModel.ISupportInitialize)(this.tBLTemTransBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewTemTrans)).BeginInit();
            this.SuspendLayout();
            // 
            // tBLTemTransBindingSource
            // 
            this.tBLTemTransBindingSource.DataSource = typeof(GasStationManagement.Model.Basic.DataAccess.TBL_TemperatureTransmitter);
            // 
            // HeaderGridTemTrans
            // 
            // 
            // 
            // 
            this.HeaderGridTemTrans.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridTemTrans.BackgroundStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridTemTrans.BackgroundStyle.BorderBottomWidth = 1;
            this.HeaderGridTemTrans.BackgroundStyle.BorderLeftWidth = 1;
            this.HeaderGridTemTrans.BackgroundStyle.BorderRightWidth = 1;
            this.HeaderGridTemTrans.BackgroundStyle.BorderTopWidth = 1;
            this.HeaderGridTemTrans.BackgroundStyle.Class = "ItemPanel";
            this.HeaderGridTemTrans.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.HeaderGridTemTrans.BackgroundStyle.PaddingBottom = 1;
            this.HeaderGridTemTrans.BackgroundStyle.PaddingLeft = 1;
            this.HeaderGridTemTrans.BackgroundStyle.PaddingRight = 1;
            this.HeaderGridTemTrans.BackgroundStyle.PaddingTop = 1;
            this.HeaderGridTemTrans.ButtonDeletePermissionCode = 0;
            this.HeaderGridTemTrans.ButtonDeleteVisible = true;
            this.HeaderGridTemTrans.ButtonEditPermissionCode = 0;
            this.HeaderGridTemTrans.ButtonEditVisible = true;
            this.HeaderGridTemTrans.ButtonExcelExportVisible = true;
            this.HeaderGridTemTrans.ButtonExcelPermissionCode = 0;
            this.HeaderGridTemTrans.ButtonInsertPermissionCode = 0;
            this.HeaderGridTemTrans.ButtonInsertVisible = true;
            this.HeaderGridTemTrans.ButtonPrintExpertPermissionCode = 0;
            this.HeaderGridTemTrans.ButtonPrintExpertVisible = false;
            this.HeaderGridTemTrans.ButtonPrintPermissionCode = 0;
            this.HeaderGridTemTrans.ButtonPrintVisible = true;
            this.HeaderGridTemTrans.ButtonRefreshVisible = true;
            this.HeaderGridTemTrans.ButtonSearchExpertVisible = false;
            this.HeaderGridTemTrans.ButtonSearchVisible = true;
            this.HeaderGridTemTrans.ButtonSelectorVisible = true;
            this.HeaderGridTemTrans.ContainerControlProcessDialogKey = true;
            this.HeaderGridTemTrans.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderGridTemTrans.FitButtonsToContainerWidth = true;
            this.HeaderGridTemTrans.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.HeaderGridTemTrans.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.HeaderGridTemTrans.Location = new System.Drawing.Point(0, 0);
            this.HeaderGridTemTrans.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HeaderGridTemTrans.Name = "HeaderGridTemTrans";
            this.HeaderGridTemTrans.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HeaderGridTemTrans.Size = new System.Drawing.Size(819, 42);
            this.HeaderGridTemTrans.TabIndex = 31;
            this.HeaderGridTemTrans.Text = "mssHeaderGrid1";
            this.HeaderGridTemTrans.ThemeAware = true;
            this.HeaderGridTemTrans.buttonItemInsertClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemInsertClickEventHandler(this.headerGridTemTrans_btnInsertClick);
            this.HeaderGridTemTrans.buttonItemEditClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemEditClickEventHandler(this.headerGridTemTrans_btnEditClick);
            this.HeaderGridTemTrans.buttonItemDeleteClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemDeleteClickEventHandler(this.headerGridTemTrans_btnDeleteClick);
            this.HeaderGridTemTrans.buttonItemRefreshClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemRefreshClickEventHandler(this.headerGridTemTrans_btnRefreshClick);
            // 
            // GridViewTemTrans
            // 
            this.GridViewTemTrans.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.GridViewTemTrans.AlternatingRowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewTemTrans.BuiltInTextsData = resources.GetString("GridViewTemTrans.BuiltInTextsData");
            this.GridViewTemTrans.CardViewGridlines = Janus.Windows.GridEX.CardViewGridlines.Both;
            this.GridViewTemTrans.DataSource = this.tBLTemTransBindingSource;
            this.GridViewTemTrans.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            GridViewTemTrans_DesignTimeLayout.LayoutString = resources.GetString("GridViewTemTrans_DesignTimeLayout.LayoutString");
            this.GridViewTemTrans.DesignTimeLayout = GridViewTemTrans_DesignTimeLayout;
            this.GridViewTemTrans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewTemTrans.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.GridViewTemTrans.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.GridViewTemTrans.Font = new System.Drawing.Font("Tahoma", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.GridViewTemTrans.GroupByBoxVisible = false;
            this.GridViewTemTrans.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewTemTrans.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
            this.GridViewTemTrans.Location = new System.Drawing.Point(0, 42);
            this.GridViewTemTrans.Name = "GridViewTemTrans";
            this.GridViewTemTrans.RecordNavigator = true;
            this.GridViewTemTrans.RowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewTemTrans.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition;
            this.GridViewTemTrans.RowHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewTemTrans.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.GridViewTemTrans.Size = new System.Drawing.Size(819, 463);
            this.GridViewTemTrans.TabIndex = 32;
            this.GridViewTemTrans.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.GridViewTemTrans.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010;
            this.GridViewTemTrans.SelectionChanged += new System.EventHandler(this.GridViewTemTrans_SelectionChanged);
            // 
            // TemTrans_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.GridViewTemTrans);
            this.Controls.Add(this.HeaderGridTemTrans);
            this.Name = "TemTrans_UC";
            this.Size = new System.Drawing.Size(819, 505);
            this.Load += new System.EventHandler(this.TemTrans_UC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tBLTemTransBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewTemTrans)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource tBLTemTransBindingSource;
        private MSSHeaderGrid HeaderGridTemTrans;
        private MSSGridexView GridViewTemTrans;
    }
}
