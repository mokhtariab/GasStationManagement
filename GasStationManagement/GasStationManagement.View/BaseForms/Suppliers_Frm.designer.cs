using MSS.Library.Control;

namespace GasStationManagement.View.BaseForms
{
    partial class Suppliers_Frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Suppliers_Frm));
            Janus.Windows.GridEX.GridEXLayout GridViewSuppliers_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.tBLSuppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.con = new MSS.Library.Control.MSSGroupPanel(this.components);
            this.GridViewSuppliers = new MSS.Library.Control.MSSGridexView();
            this.HeaderGridSuppliers = new MSS.Library.Control.MSSHeaderGrid();
            ((System.ComponentModel.ISupportInitialize)(this.tBLSuppliersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewSuppliers)).BeginInit();
            this.SuspendLayout();
            // 
            // tBLSuppliersBindingSource
            // 
            this.tBLSuppliersBindingSource.DataSource = typeof(GasStationManagement.Model.Basic.DataAccess.TBL_Supplier);
            // 
            // con
            // 
            this.con.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.con.Font = new System.Drawing.Font("Tahoma", 8F);
            this.con.Location = new System.Drawing.Point(0, 388);
            this.con.Name = "con";
            this.con.Size = new System.Drawing.Size(663, 26);
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
            // GridViewSuppliers
            // 
            this.GridViewSuppliers.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.GridViewSuppliers.AlternatingColors = true;
            this.GridViewSuppliers.AlternatingRowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewSuppliers.BuiltInTextsData = resources.GetString("GridViewSuppliers.BuiltInTextsData");
            this.GridViewSuppliers.CardViewGridlines = Janus.Windows.GridEX.CardViewGridlines.Both;
            this.GridViewSuppliers.DataSource = this.tBLSuppliersBindingSource;
            this.GridViewSuppliers.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            GridViewSuppliers_DesignTimeLayout.LayoutString = resources.GetString("GridViewSuppliers_DesignTimeLayout.LayoutString");
            this.GridViewSuppliers.DesignTimeLayout = GridViewSuppliers_DesignTimeLayout;
            this.GridViewSuppliers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewSuppliers.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.GridViewSuppliers.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.GridViewSuppliers.Font = new System.Drawing.Font("Tahoma", 8.150944F);
            this.GridViewSuppliers.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewSuppliers.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
            this.GridViewSuppliers.Location = new System.Drawing.Point(0, 36);
            this.GridViewSuppliers.Name = "GridViewSuppliers";
            this.GridViewSuppliers.RecordNavigator = true;
            this.GridViewSuppliers.RowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewSuppliers.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition;
            this.GridViewSuppliers.RowHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewSuppliers.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.GridViewSuppliers.Size = new System.Drawing.Size(663, 352);
            this.GridViewSuppliers.TabIndex = 30;
            this.GridViewSuppliers.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.GridViewSuppliers.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010;
            // 
            // HeaderGridSuppliers
            // 
            // 
            // 
            // 
            this.HeaderGridSuppliers.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridSuppliers.BackgroundStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridSuppliers.BackgroundStyle.BorderBottomWidth = 1;
            this.HeaderGridSuppliers.BackgroundStyle.BorderLeftWidth = 1;
            this.HeaderGridSuppliers.BackgroundStyle.BorderRightWidth = 1;
            this.HeaderGridSuppliers.BackgroundStyle.BorderTopWidth = 1;
            this.HeaderGridSuppliers.BackgroundStyle.Class = "ItemPanel";
            this.HeaderGridSuppliers.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.HeaderGridSuppliers.BackgroundStyle.PaddingBottom = 1;
            this.HeaderGridSuppliers.BackgroundStyle.PaddingLeft = 1;
            this.HeaderGridSuppliers.BackgroundStyle.PaddingRight = 1;
            this.HeaderGridSuppliers.BackgroundStyle.PaddingTop = 1;
            this.HeaderGridSuppliers.ButtonDeletePermissionCode = 0;
            this.HeaderGridSuppliers.ButtonDeleteVisible = true;
            this.HeaderGridSuppliers.ButtonEditPermissionCode = 0;
            this.HeaderGridSuppliers.ButtonEditVisible = true;
            this.HeaderGridSuppliers.ButtonExcelExportVisible = false;
            this.HeaderGridSuppliers.ButtonExcelPermissionCode = 0;
            this.HeaderGridSuppliers.ButtonInsertPermissionCode = 0;
            this.HeaderGridSuppliers.ButtonInsertVisible = true;
            this.HeaderGridSuppliers.ButtonPrintExpertPermissionCode = 0;
            this.HeaderGridSuppliers.ButtonPrintExpertVisible = false;
            this.HeaderGridSuppliers.ButtonPrintPermissionCode = 0;
            this.HeaderGridSuppliers.ButtonPrintVisible = true;
            this.HeaderGridSuppliers.ButtonRefreshVisible = true;
            this.HeaderGridSuppliers.ButtonSearchExpertVisible = false;
            this.HeaderGridSuppliers.ButtonSearchVisible = true;
            this.HeaderGridSuppliers.ButtonSelectorVisible = false;
            this.HeaderGridSuppliers.ContainerControlProcessDialogKey = true;
            this.HeaderGridSuppliers.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderGridSuppliers.FitButtonsToContainerWidth = true;
            this.HeaderGridSuppliers.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.HeaderGridSuppliers.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.HeaderGridSuppliers.GridViewSet = this.GridViewSuppliers;
            this.HeaderGridSuppliers.Location = new System.Drawing.Point(0, 0);
            this.HeaderGridSuppliers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HeaderGridSuppliers.Name = "HeaderGridSuppliers";
            this.HeaderGridSuppliers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HeaderGridSuppliers.Size = new System.Drawing.Size(663, 36);
            this.HeaderGridSuppliers.TabIndex = 31;
            this.HeaderGridSuppliers.Text = "mssHeaderGrid1";
            this.HeaderGridSuppliers.ThemeAware = true;
            this.HeaderGridSuppliers.buttonItemInsertClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemInsertClickEventHandler(this.headerGridSuppliers_btnInsertClick);
            this.HeaderGridSuppliers.buttonItemEditClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemEditClickEventHandler(this.headerGridSuppliers_btnEditClick);
            this.HeaderGridSuppliers.buttonItemDeleteClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemDeleteClickEventHandler(this.headerGridSuppliers_btnDeleteClick);
            this.HeaderGridSuppliers.buttonItemRefreshClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemRefreshClickEventHandler(this.headerGridSuppliers_btnRefreshClick);
            // 
            // Suppliers_Frm
            // 
            this.ClientSize = new System.Drawing.Size(663, 414);
            this.Controls.Add(this.GridViewSuppliers);
            this.Controls.Add(this.HeaderGridSuppliers);
            this.Controls.Add(this.con);
            this.Name = "Suppliers_Frm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "تامین کنندگان";
            this.Load += new System.EventHandler(this.Suppliers_Frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tBLSuppliersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewSuppliers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MSSGroupPanel con;
        private System.Windows.Forms.BindingSource tBLSuppliersBindingSource;
        private MSSGridexView GridViewSuppliers;
        private MSSHeaderGrid HeaderGridSuppliers;
    }
}
