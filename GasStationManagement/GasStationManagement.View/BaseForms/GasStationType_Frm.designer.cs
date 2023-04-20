using MSS.Library.Control;

namespace GasStationManagement.View.BaseForms
{
    partial class GasStationType_Frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GasStationType_Frm));
            Janus.Windows.GridEX.GridEXLayout GridViewGasStationType_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.con = new MSS.Library.Control.MSSGroupPanel(this.components);
            this.GridViewGasStationType = new MSS.Library.Control.MSSGridexView();
            this.tBLGasStationTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HeaderGridGasStationType = new MSS.Library.Control.MSSHeaderGrid();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewGasStationType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLGasStationTypeBindingSource)).BeginInit();
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
            // GridViewGasStationType
            // 
            this.GridViewGasStationType.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.GridViewGasStationType.AlternatingColors = true;
            this.GridViewGasStationType.AlternatingRowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewGasStationType.BuiltInTextsData = resources.GetString("GridViewGasStationType.BuiltInTextsData");
            this.GridViewGasStationType.CardViewGridlines = Janus.Windows.GridEX.CardViewGridlines.Both;
            this.GridViewGasStationType.DataSource = this.tBLGasStationTypeBindingSource;
            this.GridViewGasStationType.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            GridViewGasStationType_DesignTimeLayout.LayoutString = resources.GetString("GridViewGasStationType_DesignTimeLayout.LayoutString");
            this.GridViewGasStationType.DesignTimeLayout = GridViewGasStationType_DesignTimeLayout;
            this.GridViewGasStationType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewGasStationType.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.GridViewGasStationType.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.GridViewGasStationType.Font = new System.Drawing.Font("Tahoma", 8.150944F);
            this.GridViewGasStationType.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewGasStationType.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
            this.GridViewGasStationType.Location = new System.Drawing.Point(0, 37);
            this.GridViewGasStationType.Name = "GridViewGasStationType";
            this.GridViewGasStationType.RecordNavigator = true;
            this.GridViewGasStationType.RowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewGasStationType.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition;
            this.GridViewGasStationType.RowHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewGasStationType.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.GridViewGasStationType.Size = new System.Drawing.Size(476, 351);
            this.GridViewGasStationType.TabIndex = 30;
            this.GridViewGasStationType.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.GridViewGasStationType.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010;
            // 
            // tBLGasStationTypeBindingSource
            // 
            this.tBLGasStationTypeBindingSource.DataSource = typeof(GasStationManagement.Model.Basic.DataAccess.TBL_GasStationType);
            // 
            // HeaderGridGasStationType
            // 
            // 
            // 
            // 
            this.HeaderGridGasStationType.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridGasStationType.BackgroundStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridGasStationType.BackgroundStyle.BorderBottomWidth = 1;
            this.HeaderGridGasStationType.BackgroundStyle.BorderLeftWidth = 1;
            this.HeaderGridGasStationType.BackgroundStyle.BorderRightWidth = 1;
            this.HeaderGridGasStationType.BackgroundStyle.BorderTopWidth = 1;
            this.HeaderGridGasStationType.BackgroundStyle.Class = "ItemPanel";
            this.HeaderGridGasStationType.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.HeaderGridGasStationType.BackgroundStyle.PaddingBottom = 1;
            this.HeaderGridGasStationType.BackgroundStyle.PaddingLeft = 1;
            this.HeaderGridGasStationType.BackgroundStyle.PaddingRight = 1;
            this.HeaderGridGasStationType.BackgroundStyle.PaddingTop = 1;
            this.HeaderGridGasStationType.ButtonDeletePermissionCode = 0;
            this.HeaderGridGasStationType.ButtonDeleteVisible = true;
            this.HeaderGridGasStationType.ButtonEditPermissionCode = 0;
            this.HeaderGridGasStationType.ButtonEditVisible = true;
            this.HeaderGridGasStationType.ButtonExcelExportVisible = false;
            this.HeaderGridGasStationType.ButtonExcelPermissionCode = 0;
            this.HeaderGridGasStationType.ButtonInsertPermissionCode = 0;
            this.HeaderGridGasStationType.ButtonInsertVisible = true;
            this.HeaderGridGasStationType.ButtonPrintExpertPermissionCode = 0;
            this.HeaderGridGasStationType.ButtonPrintExpertVisible = false;
            this.HeaderGridGasStationType.ButtonPrintPermissionCode = 0;
            this.HeaderGridGasStationType.ButtonPrintVisible = true;
            this.HeaderGridGasStationType.ButtonRefreshVisible = true;
            this.HeaderGridGasStationType.ButtonSearchExpertVisible = false;
            this.HeaderGridGasStationType.ButtonSearchVisible = true;
            this.HeaderGridGasStationType.ButtonSelectorVisible = false;
            this.HeaderGridGasStationType.ContainerControlProcessDialogKey = true;
            this.HeaderGridGasStationType.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderGridGasStationType.FitButtonsToContainerWidth = true;
            this.HeaderGridGasStationType.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.HeaderGridGasStationType.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.HeaderGridGasStationType.GridViewSet = this.GridViewGasStationType;
            this.HeaderGridGasStationType.Location = new System.Drawing.Point(0, 0);
            this.HeaderGridGasStationType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HeaderGridGasStationType.Name = "HeaderGridGasStationType";
            this.HeaderGridGasStationType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HeaderGridGasStationType.Size = new System.Drawing.Size(476, 37);
            this.HeaderGridGasStationType.TabIndex = 31;
            this.HeaderGridGasStationType.Text = "mssHeaderGrid1";
            this.HeaderGridGasStationType.ThemeAware = true;
            this.HeaderGridGasStationType.buttonItemInsertClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemInsertClickEventHandler(this.headerGridGasStationType_btnInsertClick);
            this.HeaderGridGasStationType.buttonItemEditClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemEditClickEventHandler(this.headerGridGasStationType_btnEditClick);
            this.HeaderGridGasStationType.buttonItemDeleteClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemDeleteClickEventHandler(this.headerGridGasStationType_btnDeleteClick);
            this.HeaderGridGasStationType.buttonItemRefreshClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemRefreshClickEventHandler(this.headerGridGasStationType_btnRefreshClick);
            // 
            // GasStationType_Frm
            // 
            this.ClientSize = new System.Drawing.Size(476, 414);
            this.Controls.Add(this.GridViewGasStationType);
            this.Controls.Add(this.HeaderGridGasStationType);
            this.Controls.Add(this.con);
            this.Name = "GasStationType_Frm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "نوع ایستگاه";
            this.Load += new System.EventHandler(this.GasStationType_Frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewGasStationType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLGasStationTypeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MSSGroupPanel con;
        private MSSGridexView GridViewGasStationType;
        private MSSHeaderGrid HeaderGridGasStationType;
        private System.Windows.Forms.BindingSource tBLGasStationTypeBindingSource;
    }
}
