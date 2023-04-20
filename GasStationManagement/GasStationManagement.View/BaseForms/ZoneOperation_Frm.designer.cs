using MSS.Library.Control;

namespace GasStationManagement.View.BaseForms
{
    partial class ZoneOperation_Frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZoneOperation_Frm));
            Janus.Windows.GridEX.GridEXLayout GridViewZoneOperation_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.con = new MSS.Library.Control.MSSGroupPanel(this.components);
            this.GridViewZoneOperation = new MSS.Library.Control.MSSGridexView();
            this.tBLZoneOperationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HeaderGridZoneOperation = new MSS.Library.Control.MSSHeaderGrid();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewZoneOperation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLZoneOperationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // con
            // 
            this.con.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.con.Font = new System.Drawing.Font("Tahoma", 8F);
            this.con.Location = new System.Drawing.Point(0, 371);
            this.con.Name = "con";
            this.con.Size = new System.Drawing.Size(489, 26);
            // 
            // 
            // 
            this.con.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.con.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.con.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.con.TabIndex = 28;
            // 
            // GridViewZoneOperation
            // 
            this.GridViewZoneOperation.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.GridViewZoneOperation.AlternatingColors = true;
            this.GridViewZoneOperation.AlternatingRowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewZoneOperation.BuiltInTextsData = resources.GetString("GridViewZoneOperation.BuiltInTextsData");
            this.GridViewZoneOperation.CardViewGridlines = Janus.Windows.GridEX.CardViewGridlines.Both;
            this.GridViewZoneOperation.DataSource = this.tBLZoneOperationBindingSource;
            this.GridViewZoneOperation.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            GridViewZoneOperation_DesignTimeLayout.LayoutString = resources.GetString("GridViewZoneOperation_DesignTimeLayout.LayoutString");
            this.GridViewZoneOperation.DesignTimeLayout = GridViewZoneOperation_DesignTimeLayout;
            this.GridViewZoneOperation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewZoneOperation.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.GridViewZoneOperation.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.GridViewZoneOperation.Font = new System.Drawing.Font("Tahoma", 8.150944F);
            this.GridViewZoneOperation.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewZoneOperation.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
            this.GridViewZoneOperation.Location = new System.Drawing.Point(0, 36);
            this.GridViewZoneOperation.Name = "GridViewZoneOperation";
            this.GridViewZoneOperation.RecordNavigator = true;
            this.GridViewZoneOperation.RowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewZoneOperation.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition;
            this.GridViewZoneOperation.RowHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewZoneOperation.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.GridViewZoneOperation.Size = new System.Drawing.Size(489, 335);
            this.GridViewZoneOperation.TabIndex = 30;
            this.GridViewZoneOperation.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.GridViewZoneOperation.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010;
            // 
            // tBLZoneOperationBindingSource
            // 
            this.tBLZoneOperationBindingSource.DataSource = typeof(GasStationManagement.Model.Basic.DataAccess.TBL_ZoneOperation);
            // 
            // HeaderGridZoneOperation
            // 
            // 
            // 
            // 
            this.HeaderGridZoneOperation.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridZoneOperation.BackgroundStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridZoneOperation.BackgroundStyle.BorderBottomWidth = 1;
            this.HeaderGridZoneOperation.BackgroundStyle.BorderLeftWidth = 1;
            this.HeaderGridZoneOperation.BackgroundStyle.BorderRightWidth = 1;
            this.HeaderGridZoneOperation.BackgroundStyle.BorderTopWidth = 1;
            this.HeaderGridZoneOperation.BackgroundStyle.Class = "ItemPanel";
            this.HeaderGridZoneOperation.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.HeaderGridZoneOperation.BackgroundStyle.PaddingBottom = 1;
            this.HeaderGridZoneOperation.BackgroundStyle.PaddingLeft = 1;
            this.HeaderGridZoneOperation.BackgroundStyle.PaddingRight = 1;
            this.HeaderGridZoneOperation.BackgroundStyle.PaddingTop = 1;
            this.HeaderGridZoneOperation.ButtonDeletePermissionCode = 0;
            this.HeaderGridZoneOperation.ButtonDeleteVisible = true;
            this.HeaderGridZoneOperation.ButtonEditPermissionCode = 0;
            this.HeaderGridZoneOperation.ButtonEditVisible = true;
            this.HeaderGridZoneOperation.ButtonExcelExportVisible = false;
            this.HeaderGridZoneOperation.ButtonExcelPermissionCode = 0;
            this.HeaderGridZoneOperation.ButtonInsertPermissionCode = 0;
            this.HeaderGridZoneOperation.ButtonInsertVisible = true;
            this.HeaderGridZoneOperation.ButtonPrintExpertPermissionCode = 0;
            this.HeaderGridZoneOperation.ButtonPrintExpertVisible = false;
            this.HeaderGridZoneOperation.ButtonPrintPermissionCode = 0;
            this.HeaderGridZoneOperation.ButtonPrintVisible = true;
            this.HeaderGridZoneOperation.ButtonRefreshVisible = true;
            this.HeaderGridZoneOperation.ButtonSearchExpertVisible = false;
            this.HeaderGridZoneOperation.ButtonSearchVisible = true;
            this.HeaderGridZoneOperation.ButtonSelectorVisible = false;
            this.HeaderGridZoneOperation.ContainerControlProcessDialogKey = true;
            this.HeaderGridZoneOperation.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderGridZoneOperation.FitButtonsToContainerWidth = true;
            this.HeaderGridZoneOperation.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.HeaderGridZoneOperation.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.HeaderGridZoneOperation.GridViewSet = this.GridViewZoneOperation;
            this.HeaderGridZoneOperation.Location = new System.Drawing.Point(0, 0);
            this.HeaderGridZoneOperation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HeaderGridZoneOperation.Name = "HeaderGridZoneOperation";
            this.HeaderGridZoneOperation.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HeaderGridZoneOperation.Size = new System.Drawing.Size(489, 36);
            this.HeaderGridZoneOperation.TabIndex = 31;
            this.HeaderGridZoneOperation.Text = "mssHeaderGrid1";
            this.HeaderGridZoneOperation.ThemeAware = true;
            this.HeaderGridZoneOperation.buttonItemInsertClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemInsertClickEventHandler(this.headerGridZoneOperation_btnInsertClick);
            this.HeaderGridZoneOperation.buttonItemEditClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemEditClickEventHandler(this.headerGridZoneOperation_btnEditClick);
            this.HeaderGridZoneOperation.buttonItemDeleteClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemDeleteClickEventHandler(this.headerGridZoneOperation_btnDeleteClick);
            this.HeaderGridZoneOperation.buttonItemRefreshClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemRefreshClickEventHandler(this.headerGridZoneOperation_btnRefreshClick);
            // 
            // ZoneOperation_Frm
            // 
            this.ClientSize = new System.Drawing.Size(489, 397);
            this.Controls.Add(this.GridViewZoneOperation);
            this.Controls.Add(this.HeaderGridZoneOperation);
            this.Controls.Add(this.con);
            this.Name = "ZoneOperation_Frm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "منطقه عملیاتی";
            this.Load += new System.EventHandler(this.ZoneOperation_Frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewZoneOperation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLZoneOperationBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MSSGroupPanel con;
        private MSSGridexView GridViewZoneOperation;
        private MSSHeaderGrid HeaderGridZoneOperation;
        private System.Windows.Forms.BindingSource tBLZoneOperationBindingSource;
    }
}
