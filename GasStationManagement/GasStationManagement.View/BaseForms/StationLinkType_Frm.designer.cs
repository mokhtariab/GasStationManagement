using MSS.Library.Control;

namespace GasStationManagement.View.BaseForms
{
    partial class StationLinkType_Frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StationLinkType_Frm));
            Janus.Windows.GridEX.GridEXLayout GridViewStationLinkType_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.con = new MSS.Library.Control.MSSGroupPanel(this.components);
            this.GridViewStationLinkType = new MSS.Library.Control.MSSGridexView();
            this.tBLStationLinkTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HeaderGridStationLinkType = new MSS.Library.Control.MSSHeaderGrid();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewStationLinkType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLStationLinkTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // con
            // 
            this.con.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.con.Font = new System.Drawing.Font("Tahoma", 8F);
            this.con.Location = new System.Drawing.Point(0, 388);
            this.con.Name = "con";
            this.con.Size = new System.Drawing.Size(605, 26);
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
            // GridViewStationLinkType
            // 
            this.GridViewStationLinkType.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.GridViewStationLinkType.AlternatingColors = true;
            this.GridViewStationLinkType.AlternatingRowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewStationLinkType.BuiltInTextsData = resources.GetString("GridViewStationLinkType.BuiltInTextsData");
            this.GridViewStationLinkType.CardViewGridlines = Janus.Windows.GridEX.CardViewGridlines.Both;
            this.GridViewStationLinkType.DataSource = this.tBLStationLinkTypeBindingSource;
            this.GridViewStationLinkType.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            GridViewStationLinkType_DesignTimeLayout.LayoutString = resources.GetString("GridViewStationLinkType_DesignTimeLayout.LayoutString");
            this.GridViewStationLinkType.DesignTimeLayout = GridViewStationLinkType_DesignTimeLayout;
            this.GridViewStationLinkType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewStationLinkType.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.GridViewStationLinkType.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.GridViewStationLinkType.Font = new System.Drawing.Font("Tahoma", 8.150944F);
            this.GridViewStationLinkType.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewStationLinkType.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
            this.GridViewStationLinkType.Location = new System.Drawing.Point(0, 35);
            this.GridViewStationLinkType.Name = "GridViewStationLinkType";
            this.GridViewStationLinkType.RecordNavigator = true;
            this.GridViewStationLinkType.RowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewStationLinkType.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition;
            this.GridViewStationLinkType.RowHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewStationLinkType.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.GridViewStationLinkType.Size = new System.Drawing.Size(605, 353);
            this.GridViewStationLinkType.TabIndex = 30;
            this.GridViewStationLinkType.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.GridViewStationLinkType.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010;
            // 
            // tBLStationLinkTypeBindingSource
            // 
            this.tBLStationLinkTypeBindingSource.DataSource = typeof(GasStationManagement.Model.Basic.DataAccess.TBL_StationLinkType);
            // 
            // HeaderGridStationLinkType
            // 
            // 
            // 
            // 
            this.HeaderGridStationLinkType.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridStationLinkType.BackgroundStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridStationLinkType.BackgroundStyle.BorderBottomWidth = 1;
            this.HeaderGridStationLinkType.BackgroundStyle.BorderLeftWidth = 1;
            this.HeaderGridStationLinkType.BackgroundStyle.BorderRightWidth = 1;
            this.HeaderGridStationLinkType.BackgroundStyle.BorderTopWidth = 1;
            this.HeaderGridStationLinkType.BackgroundStyle.Class = "ItemPanel";
            this.HeaderGridStationLinkType.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.HeaderGridStationLinkType.BackgroundStyle.PaddingBottom = 1;
            this.HeaderGridStationLinkType.BackgroundStyle.PaddingLeft = 1;
            this.HeaderGridStationLinkType.BackgroundStyle.PaddingRight = 1;
            this.HeaderGridStationLinkType.BackgroundStyle.PaddingTop = 1;
            this.HeaderGridStationLinkType.ButtonDeletePermissionCode = 0;
            this.HeaderGridStationLinkType.ButtonDeleteVisible = true;
            this.HeaderGridStationLinkType.ButtonEditPermissionCode = 0;
            this.HeaderGridStationLinkType.ButtonEditVisible = true;
            this.HeaderGridStationLinkType.ButtonExcelExportVisible = false;
            this.HeaderGridStationLinkType.ButtonExcelPermissionCode = 0;
            this.HeaderGridStationLinkType.ButtonInsertPermissionCode = 0;
            this.HeaderGridStationLinkType.ButtonInsertVisible = true;
            this.HeaderGridStationLinkType.ButtonPrintExpertPermissionCode = 0;
            this.HeaderGridStationLinkType.ButtonPrintExpertVisible = false;
            this.HeaderGridStationLinkType.ButtonPrintPermissionCode = 0;
            this.HeaderGridStationLinkType.ButtonPrintVisible = true;
            this.HeaderGridStationLinkType.ButtonRefreshVisible = true;
            this.HeaderGridStationLinkType.ButtonSearchExpertVisible = false;
            this.HeaderGridStationLinkType.ButtonSearchVisible = true;
            this.HeaderGridStationLinkType.ButtonSelectorVisible = false;
            this.HeaderGridStationLinkType.ContainerControlProcessDialogKey = true;
            this.HeaderGridStationLinkType.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderGridStationLinkType.FitButtonsToContainerWidth = true;
            this.HeaderGridStationLinkType.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.HeaderGridStationLinkType.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.HeaderGridStationLinkType.GridViewSet = this.GridViewStationLinkType;
            this.HeaderGridStationLinkType.Location = new System.Drawing.Point(0, 0);
            this.HeaderGridStationLinkType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HeaderGridStationLinkType.Name = "HeaderGridStationLinkType";
            this.HeaderGridStationLinkType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HeaderGridStationLinkType.Size = new System.Drawing.Size(605, 35);
            this.HeaderGridStationLinkType.TabIndex = 31;
            this.HeaderGridStationLinkType.Text = "mssHeaderGrid1";
            this.HeaderGridStationLinkType.ThemeAware = true;
            this.HeaderGridStationLinkType.buttonItemInsertClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemInsertClickEventHandler(this.headerGridStationLinkType_btnInsertClick);
            this.HeaderGridStationLinkType.buttonItemEditClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemEditClickEventHandler(this.headerGridStationLinkType_btnEditClick);
            this.HeaderGridStationLinkType.buttonItemDeleteClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemDeleteClickEventHandler(this.headerGridStationLinkType_btnDeleteClick);
            this.HeaderGridStationLinkType.buttonItemRefreshClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemRefreshClickEventHandler(this.headerGridStationLinkType_btnRefreshClick);
            // 
            // StationLinkType_Frm
            // 
            this.ClientSize = new System.Drawing.Size(605, 414);
            this.Controls.Add(this.GridViewStationLinkType);
            this.Controls.Add(this.HeaderGridStationLinkType);
            this.Controls.Add(this.con);
            this.Name = "StationLinkType_Frm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "نوع بستر ارتباطی ایستگاه";
            this.Load += new System.EventHandler(this.StationLinkType_Frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewStationLinkType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLStationLinkTypeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MSSGroupPanel con;
        private MSSGridexView GridViewStationLinkType;
        private MSSHeaderGrid HeaderGridStationLinkType;
        private System.Windows.Forms.BindingSource tBLStationLinkTypeBindingSource;
    }
}
