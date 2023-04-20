using MSS.Library.Control;

namespace GasStationManagement.View.BaseForms
{
    partial class CounterInsLoc_Frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CounterInsLoc_Frm));
            Janus.Windows.GridEX.GridEXLayout GridViewCounterInsLoc_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.con = new MSS.Library.Control.MSSGroupPanel(this.components);
            this.GridViewCounterInsLoc = new MSS.Library.Control.MSSGridexView();
            this.tBLCounterInsLocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HeaderGridCounterInsLoc = new MSS.Library.Control.MSSHeaderGrid();
            this.mssPanel1 = new MSS.Library.Control.MSSPanel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewCounterInsLoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLCounterInsLocBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // con
            // 
            this.con.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.con.Font = new System.Drawing.Font("Tahoma", 8F);
            this.con.Location = new System.Drawing.Point(0, 405);
            this.con.Name = "con";
            this.con.Size = new System.Drawing.Size(518, 26);
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
            // GridViewCounterInsLoc
            // 
            this.GridViewCounterInsLoc.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.GridViewCounterInsLoc.AlternatingColors = true;
            this.GridViewCounterInsLoc.AlternatingRowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewCounterInsLoc.BuiltInTextsData = resources.GetString("GridViewCounterInsLoc.BuiltInTextsData");
            this.GridViewCounterInsLoc.CardViewGridlines = Janus.Windows.GridEX.CardViewGridlines.Both;
            this.GridViewCounterInsLoc.DataSource = this.tBLCounterInsLocBindingSource;
            this.GridViewCounterInsLoc.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            GridViewCounterInsLoc_DesignTimeLayout.LayoutString = resources.GetString("GridViewCounterInsLoc_DesignTimeLayout.LayoutString");
            this.GridViewCounterInsLoc.DesignTimeLayout = GridViewCounterInsLoc_DesignTimeLayout;
            this.GridViewCounterInsLoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewCounterInsLoc.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.GridViewCounterInsLoc.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.GridViewCounterInsLoc.Font = new System.Drawing.Font("Tahoma", 8.150944F);
            this.GridViewCounterInsLoc.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewCounterInsLoc.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
            this.GridViewCounterInsLoc.Location = new System.Drawing.Point(0, 37);
            this.GridViewCounterInsLoc.Name = "GridViewCounterInsLoc";
            this.GridViewCounterInsLoc.RecordNavigator = true;
            this.GridViewCounterInsLoc.RowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewCounterInsLoc.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition;
            this.GridViewCounterInsLoc.RowHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewCounterInsLoc.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.GridViewCounterInsLoc.Size = new System.Drawing.Size(518, 368);
            this.GridViewCounterInsLoc.TabIndex = 30;
            this.GridViewCounterInsLoc.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.GridViewCounterInsLoc.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010;
            // 
            // tBLCounterInsLocBindingSource
            // 
            this.tBLCounterInsLocBindingSource.DataSource = typeof(GasStationManagement.Model.Basic.DataAccess.TBL_CounterInsLoc);
            // 
            // HeaderGridCounterInsLoc
            // 
            // 
            // 
            // 
            this.HeaderGridCounterInsLoc.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridCounterInsLoc.BackgroundStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridCounterInsLoc.BackgroundStyle.BorderBottomWidth = 1;
            this.HeaderGridCounterInsLoc.BackgroundStyle.BorderLeftWidth = 1;
            this.HeaderGridCounterInsLoc.BackgroundStyle.BorderRightWidth = 1;
            this.HeaderGridCounterInsLoc.BackgroundStyle.BorderTopWidth = 1;
            this.HeaderGridCounterInsLoc.BackgroundStyle.Class = "ItemPanel";
            this.HeaderGridCounterInsLoc.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.HeaderGridCounterInsLoc.BackgroundStyle.PaddingBottom = 1;
            this.HeaderGridCounterInsLoc.BackgroundStyle.PaddingLeft = 1;
            this.HeaderGridCounterInsLoc.BackgroundStyle.PaddingRight = 1;
            this.HeaderGridCounterInsLoc.BackgroundStyle.PaddingTop = 1;
            this.HeaderGridCounterInsLoc.ButtonDeletePermissionCode = 0;
            this.HeaderGridCounterInsLoc.ButtonDeleteVisible = true;
            this.HeaderGridCounterInsLoc.ButtonEditPermissionCode = 0;
            this.HeaderGridCounterInsLoc.ButtonEditVisible = true;
            this.HeaderGridCounterInsLoc.ButtonExcelExportVisible = false;
            this.HeaderGridCounterInsLoc.ButtonExcelPermissionCode = 0;
            this.HeaderGridCounterInsLoc.ButtonInsertPermissionCode = 0;
            this.HeaderGridCounterInsLoc.ButtonInsertVisible = true;
            this.HeaderGridCounterInsLoc.ButtonPrintExpertPermissionCode = 0;
            this.HeaderGridCounterInsLoc.ButtonPrintExpertVisible = false;
            this.HeaderGridCounterInsLoc.ButtonPrintPermissionCode = 0;
            this.HeaderGridCounterInsLoc.ButtonPrintVisible = true;
            this.HeaderGridCounterInsLoc.ButtonRefreshVisible = true;
            this.HeaderGridCounterInsLoc.ButtonSearchExpertVisible = false;
            this.HeaderGridCounterInsLoc.ButtonSearchVisible = true;
            this.HeaderGridCounterInsLoc.ButtonSelectorVisible = false;
            this.HeaderGridCounterInsLoc.ContainerControlProcessDialogKey = true;
            this.HeaderGridCounterInsLoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderGridCounterInsLoc.FitButtonsToContainerWidth = true;
            this.HeaderGridCounterInsLoc.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.HeaderGridCounterInsLoc.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.HeaderGridCounterInsLoc.GridViewSet = this.GridViewCounterInsLoc;
            this.HeaderGridCounterInsLoc.Location = new System.Drawing.Point(0, 0);
            this.HeaderGridCounterInsLoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HeaderGridCounterInsLoc.Name = "HeaderGridCounterInsLoc";
            this.HeaderGridCounterInsLoc.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HeaderGridCounterInsLoc.Size = new System.Drawing.Size(518, 37);
            this.HeaderGridCounterInsLoc.TabIndex = 31;
            this.HeaderGridCounterInsLoc.Text = "mssHeaderGrid1";
            this.HeaderGridCounterInsLoc.ThemeAware = true;
            this.HeaderGridCounterInsLoc.buttonItemInsertClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemInsertClickEventHandler(this.headerGridCounterInsLoc_btnInsertClick);
            this.HeaderGridCounterInsLoc.buttonItemEditClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemEditClickEventHandler(this.headerGridCounterInsLoc_btnEditClick);
            this.HeaderGridCounterInsLoc.buttonItemDeleteClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemDeleteClickEventHandler(this.headerGridCounterInsLoc_btnDeleteClick);
            this.HeaderGridCounterInsLoc.buttonItemRefreshClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemRefreshClickEventHandler(this.headerGridCounterInsLoc_btnRefreshClick);
            // 
            // mssPanel1
            // 
            this.mssPanel1.Location = new System.Drawing.Point(0, 0);
            this.mssPanel1.Name = "mssPanel1";
            this.mssPanel1.Size = new System.Drawing.Size(200, 100);
            this.mssPanel1.TabIndex = 0;
            // 
            // CounterInsLoc_Frm
            // 
            this.ClientSize = new System.Drawing.Size(518, 431);
            this.Controls.Add(this.GridViewCounterInsLoc);
            this.Controls.Add(this.HeaderGridCounterInsLoc);
            this.Controls.Add(this.con);
            this.Name = "CounterInsLoc_Frm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "محل نصب کنتور";
            this.Load += new System.EventHandler(this.CounterInsLoc_Frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewCounterInsLoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLCounterInsLocBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MSSGroupPanel con;
        private MSSGridexView GridViewCounterInsLoc;
        private MSSHeaderGrid HeaderGridCounterInsLoc;
        private MSSPanel mssPanel1;
        private System.Windows.Forms.BindingSource tBLCounterInsLocBindingSource;
    }
}
