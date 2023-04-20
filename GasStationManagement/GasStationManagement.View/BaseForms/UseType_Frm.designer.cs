using MSS.Library.Control;

namespace GasStationManagement.View.BaseForms
{
    partial class UseType_Frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UseType_Frm));
            Janus.Windows.GridEX.GridEXLayout GridViewUseType_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.con = new MSS.Library.Control.MSSGroupPanel(this.components);
            this.GridViewUseType = new MSS.Library.Control.MSSGridexView();
            this.tBLUseTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HeaderGridUseType = new MSS.Library.Control.MSSHeaderGrid();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewUseType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLUseTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // con
            // 
            this.con.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.con.Font = new System.Drawing.Font("Tahoma", 8F);
            this.con.Location = new System.Drawing.Point(0, 383);
            this.con.Name = "con";
            this.con.Size = new System.Drawing.Size(470, 26);
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
            // GridViewUseType
            // 
            this.GridViewUseType.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.GridViewUseType.AlternatingColors = true;
            this.GridViewUseType.AlternatingRowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewUseType.BuiltInTextsData = resources.GetString("GridViewUseType.BuiltInTextsData");
            this.GridViewUseType.CardViewGridlines = Janus.Windows.GridEX.CardViewGridlines.Both;
            this.GridViewUseType.DataSource = this.tBLUseTypeBindingSource;
            this.GridViewUseType.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            GridViewUseType_DesignTimeLayout.LayoutString = resources.GetString("GridViewUseType_DesignTimeLayout.LayoutString");
            this.GridViewUseType.DesignTimeLayout = GridViewUseType_DesignTimeLayout;
            this.GridViewUseType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewUseType.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.GridViewUseType.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.GridViewUseType.Font = new System.Drawing.Font("Tahoma", 8.150944F);
            this.GridViewUseType.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewUseType.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
            this.GridViewUseType.Location = new System.Drawing.Point(0, 36);
            this.GridViewUseType.Name = "GridViewUseType";
            this.GridViewUseType.RecordNavigator = true;
            this.GridViewUseType.RowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewUseType.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition;
            this.GridViewUseType.RowHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewUseType.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.GridViewUseType.Size = new System.Drawing.Size(470, 347);
            this.GridViewUseType.TabIndex = 30;
            this.GridViewUseType.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.GridViewUseType.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010;
            // 
            // tBLUseTypeBindingSource
            // 
            this.tBLUseTypeBindingSource.DataSource = typeof(GasStationManagement.Model.Basic.DataAccess.TBL_UseType);
            // 
            // HeaderGridUseType
            // 
            // 
            // 
            // 
            this.HeaderGridUseType.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridUseType.BackgroundStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridUseType.BackgroundStyle.BorderBottomWidth = 1;
            this.HeaderGridUseType.BackgroundStyle.BorderLeftWidth = 1;
            this.HeaderGridUseType.BackgroundStyle.BorderRightWidth = 1;
            this.HeaderGridUseType.BackgroundStyle.BorderTopWidth = 1;
            this.HeaderGridUseType.BackgroundStyle.Class = "ItemPanel";
            this.HeaderGridUseType.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.HeaderGridUseType.BackgroundStyle.PaddingBottom = 1;
            this.HeaderGridUseType.BackgroundStyle.PaddingLeft = 1;
            this.HeaderGridUseType.BackgroundStyle.PaddingRight = 1;
            this.HeaderGridUseType.BackgroundStyle.PaddingTop = 1;
            this.HeaderGridUseType.ButtonDeletePermissionCode = 0;
            this.HeaderGridUseType.ButtonDeleteVisible = true;
            this.HeaderGridUseType.ButtonEditPermissionCode = 0;
            this.HeaderGridUseType.ButtonEditVisible = true;
            this.HeaderGridUseType.ButtonExcelExportVisible = false;
            this.HeaderGridUseType.ButtonExcelPermissionCode = 0;
            this.HeaderGridUseType.ButtonInsertPermissionCode = 0;
            this.HeaderGridUseType.ButtonInsertVisible = true;
            this.HeaderGridUseType.ButtonPrintExpertPermissionCode = 0;
            this.HeaderGridUseType.ButtonPrintExpertVisible = false;
            this.HeaderGridUseType.ButtonPrintPermissionCode = 0;
            this.HeaderGridUseType.ButtonPrintVisible = true;
            this.HeaderGridUseType.ButtonRefreshVisible = true;
            this.HeaderGridUseType.ButtonSearchExpertVisible = false;
            this.HeaderGridUseType.ButtonSearchVisible = true;
            this.HeaderGridUseType.ButtonSelectorVisible = false;
            this.HeaderGridUseType.ContainerControlProcessDialogKey = true;
            this.HeaderGridUseType.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderGridUseType.FitButtonsToContainerWidth = true;
            this.HeaderGridUseType.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.HeaderGridUseType.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.HeaderGridUseType.GridViewSet = this.GridViewUseType;
            this.HeaderGridUseType.Location = new System.Drawing.Point(0, 0);
            this.HeaderGridUseType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HeaderGridUseType.Name = "HeaderGridUseType";
            this.HeaderGridUseType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HeaderGridUseType.Size = new System.Drawing.Size(470, 36);
            this.HeaderGridUseType.TabIndex = 31;
            this.HeaderGridUseType.Text = "mssHeaderGrid1";
            this.HeaderGridUseType.ThemeAware = true;
            this.HeaderGridUseType.buttonItemInsertClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemInsertClickEventHandler(this.headerGridUseType_btnInsertClick);
            this.HeaderGridUseType.buttonItemEditClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemEditClickEventHandler(this.headerGridUseType_btnEditClick);
            this.HeaderGridUseType.buttonItemDeleteClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemDeleteClickEventHandler(this.headerGridUseType_btnDeleteClick);
            this.HeaderGridUseType.buttonItemRefreshClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemRefreshClickEventHandler(this.headerGridUseType_btnRefreshClick);
            // 
            // UseType_Frm
            // 
            this.ClientSize = new System.Drawing.Size(470, 409);
            this.Controls.Add(this.GridViewUseType);
            this.Controls.Add(this.HeaderGridUseType);
            this.Controls.Add(this.con);
            this.Name = "UseType_Frm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "نوع مصرف";
            this.Load += new System.EventHandler(this.UseType_Frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewUseType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLUseTypeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MSSGroupPanel con;
        private MSSGridexView GridViewUseType;
        private MSSHeaderGrid HeaderGridUseType;
        private System.Windows.Forms.BindingSource tBLUseTypeBindingSource;
    }
}
