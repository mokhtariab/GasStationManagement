using MSS.Library.Control;

namespace GasStationManagement.View.BaseForms
{
    partial class WorkShop_Frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkShop_Frm));
            Janus.Windows.GridEX.GridEXLayout GridViewWorkShop_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.con = new MSS.Library.Control.MSSGroupPanel(this.components);
            this.GridViewWorkShop = new MSS.Library.Control.MSSGridexView();
            this.tBLWorkShopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HeaderGridWorkShop = new MSS.Library.Control.MSSHeaderGrid();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewWorkShop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLWorkShopBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // con
            // 
            this.con.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.con.Font = new System.Drawing.Font("Tahoma", 8F);
            this.con.Location = new System.Drawing.Point(0, 388);
            this.con.Name = "con";
            this.con.Size = new System.Drawing.Size(476, 26);
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
            // GridViewWorkShop
            // 
            this.GridViewWorkShop.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.GridViewWorkShop.AlternatingColors = true;
            this.GridViewWorkShop.AlternatingRowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewWorkShop.BuiltInTextsData = resources.GetString("GridViewWorkShop.BuiltInTextsData");
            this.GridViewWorkShop.CardViewGridlines = Janus.Windows.GridEX.CardViewGridlines.Both;
            this.GridViewWorkShop.DataSource = this.tBLWorkShopBindingSource;
            this.GridViewWorkShop.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            GridViewWorkShop_DesignTimeLayout.LayoutString = resources.GetString("GridViewWorkShop_DesignTimeLayout.LayoutString");
            this.GridViewWorkShop.DesignTimeLayout = GridViewWorkShop_DesignTimeLayout;
            this.GridViewWorkShop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewWorkShop.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.GridViewWorkShop.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.GridViewWorkShop.Font = new System.Drawing.Font("Tahoma", 8.150944F);
            this.GridViewWorkShop.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewWorkShop.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
            this.GridViewWorkShop.Location = new System.Drawing.Point(0, 36);
            this.GridViewWorkShop.Name = "GridViewWorkShop";
            this.GridViewWorkShop.RecordNavigator = true;
            this.GridViewWorkShop.RowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewWorkShop.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition;
            this.GridViewWorkShop.RowHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewWorkShop.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.GridViewWorkShop.Size = new System.Drawing.Size(476, 352);
            this.GridViewWorkShop.TabIndex = 30;
            this.GridViewWorkShop.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.GridViewWorkShop.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010;
            // 
            // tBLWorkShopBindingSource
            // 
            this.tBLWorkShopBindingSource.DataSource = typeof(GasStationManagement.Model.Basic.DataAccess.TBL_WorkShop);
            // 
            // HeaderGridWorkShop
            // 
            // 
            // 
            // 
            this.HeaderGridWorkShop.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridWorkShop.BackgroundStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridWorkShop.BackgroundStyle.BorderBottomWidth = 1;
            this.HeaderGridWorkShop.BackgroundStyle.BorderLeftWidth = 1;
            this.HeaderGridWorkShop.BackgroundStyle.BorderRightWidth = 1;
            this.HeaderGridWorkShop.BackgroundStyle.BorderTopWidth = 1;
            this.HeaderGridWorkShop.BackgroundStyle.Class = "ItemPanel";
            this.HeaderGridWorkShop.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.HeaderGridWorkShop.BackgroundStyle.PaddingBottom = 1;
            this.HeaderGridWorkShop.BackgroundStyle.PaddingLeft = 1;
            this.HeaderGridWorkShop.BackgroundStyle.PaddingRight = 1;
            this.HeaderGridWorkShop.BackgroundStyle.PaddingTop = 1;
            this.HeaderGridWorkShop.ButtonDeletePermissionCode = 0;
            this.HeaderGridWorkShop.ButtonDeleteVisible = true;
            this.HeaderGridWorkShop.ButtonEditPermissionCode = 0;
            this.HeaderGridWorkShop.ButtonEditVisible = true;
            this.HeaderGridWorkShop.ButtonExcelExportVisible = false;
            this.HeaderGridWorkShop.ButtonExcelPermissionCode = 0;
            this.HeaderGridWorkShop.ButtonInsertPermissionCode = 0;
            this.HeaderGridWorkShop.ButtonInsertVisible = true;
            this.HeaderGridWorkShop.ButtonPrintExpertPermissionCode = 0;
            this.HeaderGridWorkShop.ButtonPrintExpertVisible = false;
            this.HeaderGridWorkShop.ButtonPrintPermissionCode = 0;
            this.HeaderGridWorkShop.ButtonPrintVisible = true;
            this.HeaderGridWorkShop.ButtonRefreshVisible = true;
            this.HeaderGridWorkShop.ButtonSearchExpertVisible = false;
            this.HeaderGridWorkShop.ButtonSearchVisible = true;
            this.HeaderGridWorkShop.ButtonSelectorVisible = false;
            this.HeaderGridWorkShop.ContainerControlProcessDialogKey = true;
            this.HeaderGridWorkShop.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderGridWorkShop.FitButtonsToContainerWidth = true;
            this.HeaderGridWorkShop.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.HeaderGridWorkShop.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.HeaderGridWorkShop.GridViewSet = this.GridViewWorkShop;
            this.HeaderGridWorkShop.Location = new System.Drawing.Point(0, 0);
            this.HeaderGridWorkShop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HeaderGridWorkShop.Name = "HeaderGridWorkShop";
            this.HeaderGridWorkShop.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HeaderGridWorkShop.Size = new System.Drawing.Size(476, 36);
            this.HeaderGridWorkShop.TabIndex = 31;
            this.HeaderGridWorkShop.Text = "mssHeaderGrid1";
            this.HeaderGridWorkShop.ThemeAware = true;
            this.HeaderGridWorkShop.buttonItemInsertClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemInsertClickEventHandler(this.headerGridWorkShop_btnInsertClick);
            this.HeaderGridWorkShop.buttonItemEditClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemEditClickEventHandler(this.headerGridWorkShop_btnEditClick);
            this.HeaderGridWorkShop.buttonItemDeleteClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemDeleteClickEventHandler(this.headerGridWorkShop_btnDeleteClick);
            this.HeaderGridWorkShop.buttonItemRefreshClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemRefreshClickEventHandler(this.headerGridWorkShop_btnRefreshClick);
            // 
            // WorkShop_Frm
            // 
            this.ClientSize = new System.Drawing.Size(476, 414);
            this.Controls.Add(this.GridViewWorkShop);
            this.Controls.Add(this.HeaderGridWorkShop);
            this.Controls.Add(this.con);
            this.Name = "WorkShop_Frm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "تعمیرگاه";
            this.Load += new System.EventHandler(this.WorkShop_Frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewWorkShop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLWorkShopBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MSSGroupPanel con;
        private MSSGridexView GridViewWorkShop;
        private MSSHeaderGrid HeaderGridWorkShop;
        private System.Windows.Forms.BindingSource tBLWorkShopBindingSource;
    }
}
