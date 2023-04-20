using MSS.Library.Control;

namespace GasStationManagement.View.BaseForms
{
    partial class Store_Frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Store_Frm));
            Janus.Windows.GridEX.GridEXLayout GridViewStore_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.con = new MSS.Library.Control.MSSGroupPanel(this.components);
            this.GridViewStore = new MSS.Library.Control.MSSGridexView();
            this.tBLStoreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HeaderGridStore = new MSS.Library.Control.MSSHeaderGrid();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewStore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLStoreBindingSource)).BeginInit();
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
            // GridViewStore
            // 
            this.GridViewStore.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.GridViewStore.AlternatingColors = true;
            this.GridViewStore.AlternatingRowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewStore.BuiltInTextsData = resources.GetString("GridViewStore.BuiltInTextsData");
            this.GridViewStore.CardViewGridlines = Janus.Windows.GridEX.CardViewGridlines.Both;
            this.GridViewStore.DataSource = this.tBLStoreBindingSource;
            this.GridViewStore.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            GridViewStore_DesignTimeLayout.LayoutString = resources.GetString("GridViewStore_DesignTimeLayout.LayoutString");
            this.GridViewStore.DesignTimeLayout = GridViewStore_DesignTimeLayout;
            this.GridViewStore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewStore.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.GridViewStore.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.GridViewStore.Font = new System.Drawing.Font("Tahoma", 8.150944F);
            this.GridViewStore.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewStore.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
            this.GridViewStore.Location = new System.Drawing.Point(0, 35);
            this.GridViewStore.Name = "GridViewStore";
            this.GridViewStore.RecordNavigator = true;
            this.GridViewStore.RowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewStore.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition;
            this.GridViewStore.RowHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewStore.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.GridViewStore.Size = new System.Drawing.Size(476, 353);
            this.GridViewStore.TabIndex = 30;
            this.GridViewStore.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.GridViewStore.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010;
            // 
            // tBLStoreBindingSource
            // 
            this.tBLStoreBindingSource.DataSource = typeof(GasStationManagement.Model.Basic.DataAccess.TBL_Store);
            // 
            // HeaderGridStore
            // 
            // 
            // 
            // 
            this.HeaderGridStore.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridStore.BackgroundStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridStore.BackgroundStyle.BorderBottomWidth = 1;
            this.HeaderGridStore.BackgroundStyle.BorderLeftWidth = 1;
            this.HeaderGridStore.BackgroundStyle.BorderRightWidth = 1;
            this.HeaderGridStore.BackgroundStyle.BorderTopWidth = 1;
            this.HeaderGridStore.BackgroundStyle.Class = "ItemPanel";
            this.HeaderGridStore.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.HeaderGridStore.BackgroundStyle.PaddingBottom = 1;
            this.HeaderGridStore.BackgroundStyle.PaddingLeft = 1;
            this.HeaderGridStore.BackgroundStyle.PaddingRight = 1;
            this.HeaderGridStore.BackgroundStyle.PaddingTop = 1;
            this.HeaderGridStore.ButtonDeletePermissionCode = 0;
            this.HeaderGridStore.ButtonDeleteVisible = true;
            this.HeaderGridStore.ButtonEditPermissionCode = 0;
            this.HeaderGridStore.ButtonEditVisible = true;
            this.HeaderGridStore.ButtonExcelExportVisible = false;
            this.HeaderGridStore.ButtonExcelPermissionCode = 0;
            this.HeaderGridStore.ButtonInsertPermissionCode = 0;
            this.HeaderGridStore.ButtonInsertVisible = true;
            this.HeaderGridStore.ButtonPrintExpertPermissionCode = 0;
            this.HeaderGridStore.ButtonPrintExpertVisible = false;
            this.HeaderGridStore.ButtonPrintPermissionCode = 0;
            this.HeaderGridStore.ButtonPrintVisible = true;
            this.HeaderGridStore.ButtonRefreshVisible = true;
            this.HeaderGridStore.ButtonSearchExpertVisible = false;
            this.HeaderGridStore.ButtonSearchVisible = true;
            this.HeaderGridStore.ButtonSelectorVisible = false;
            this.HeaderGridStore.ContainerControlProcessDialogKey = true;
            this.HeaderGridStore.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderGridStore.FitButtonsToContainerWidth = true;
            this.HeaderGridStore.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.HeaderGridStore.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.HeaderGridStore.GridViewSet = this.GridViewStore;
            this.HeaderGridStore.Location = new System.Drawing.Point(0, 0);
            this.HeaderGridStore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HeaderGridStore.Name = "HeaderGridStore";
            this.HeaderGridStore.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HeaderGridStore.Size = new System.Drawing.Size(476, 35);
            this.HeaderGridStore.TabIndex = 31;
            this.HeaderGridStore.Text = "mssHeaderGrid1";
            this.HeaderGridStore.ThemeAware = true;
            this.HeaderGridStore.buttonItemInsertClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemInsertClickEventHandler(this.headerGridStore_btnInsertClick);
            this.HeaderGridStore.buttonItemEditClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemEditClickEventHandler(this.headerGridStore_btnEditClick);
            this.HeaderGridStore.buttonItemDeleteClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemDeleteClickEventHandler(this.headerGridStore_btnDeleteClick);
            this.HeaderGridStore.buttonItemRefreshClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemRefreshClickEventHandler(this.headerGridStore_btnRefreshClick);
            // 
            // Store_Frm
            // 
            this.ClientSize = new System.Drawing.Size(476, 414);
            this.Controls.Add(this.GridViewStore);
            this.Controls.Add(this.HeaderGridStore);
            this.Controls.Add(this.con);
            this.Name = "Store_Frm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "انبار\t";
            this.Load += new System.EventHandler(this.Store_Frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewStore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLStoreBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MSSGroupPanel con;
        private MSSGridexView GridViewStore;
        private MSSHeaderGrid HeaderGridStore;
        private System.Windows.Forms.BindingSource tBLStoreBindingSource;
    }
}
