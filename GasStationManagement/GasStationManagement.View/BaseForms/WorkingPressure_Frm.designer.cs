using MSS.Library.Control;

namespace GasStationManagement.View.BaseForms
{
    partial class WorkingPressure_Frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkingPressure_Frm));
            Janus.Windows.GridEX.GridEXLayout GridViewWorkingPressure_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.con = new MSS.Library.Control.MSSGroupPanel(this.components);
            this.GridViewWorkingPressure = new MSS.Library.Control.MSSGridexView();
            this.tBLWorkingPressureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HeaderGridWorkingPressure = new MSS.Library.Control.MSSHeaderGrid();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewWorkingPressure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLWorkingPressureBindingSource)).BeginInit();
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
            // GridViewWorkingPressure
            // 
            this.GridViewWorkingPressure.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.GridViewWorkingPressure.AlternatingColors = true;
            this.GridViewWorkingPressure.AlternatingRowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewWorkingPressure.BuiltInTextsData = resources.GetString("GridViewWorkingPressure.BuiltInTextsData");
            this.GridViewWorkingPressure.CardViewGridlines = Janus.Windows.GridEX.CardViewGridlines.Both;
            this.GridViewWorkingPressure.DataSource = this.tBLWorkingPressureBindingSource;
            this.GridViewWorkingPressure.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            GridViewWorkingPressure_DesignTimeLayout.LayoutString = resources.GetString("GridViewWorkingPressure_DesignTimeLayout.LayoutString");
            this.GridViewWorkingPressure.DesignTimeLayout = GridViewWorkingPressure_DesignTimeLayout;
            this.GridViewWorkingPressure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewWorkingPressure.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.GridViewWorkingPressure.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.GridViewWorkingPressure.Font = new System.Drawing.Font("Tahoma", 8.150944F);
            this.GridViewWorkingPressure.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewWorkingPressure.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
            this.GridViewWorkingPressure.Location = new System.Drawing.Point(0, 35);
            this.GridViewWorkingPressure.Name = "GridViewWorkingPressure";
            this.GridViewWorkingPressure.RecordNavigator = true;
            this.GridViewWorkingPressure.RowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewWorkingPressure.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition;
            this.GridViewWorkingPressure.RowHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewWorkingPressure.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.GridViewWorkingPressure.Size = new System.Drawing.Size(476, 353);
            this.GridViewWorkingPressure.TabIndex = 30;
            this.GridViewWorkingPressure.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.GridViewWorkingPressure.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010;
            // 
            // tBLWorkingPressureBindingSource
            // 
            this.tBLWorkingPressureBindingSource.DataSource = typeof(GasStationManagement.Model.Basic.DataAccess.TBL_WorkingPressure);
            // 
            // HeaderGridWorkingPressure
            // 
            // 
            // 
            // 
            this.HeaderGridWorkingPressure.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridWorkingPressure.BackgroundStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridWorkingPressure.BackgroundStyle.BorderBottomWidth = 1;
            this.HeaderGridWorkingPressure.BackgroundStyle.BorderLeftWidth = 1;
            this.HeaderGridWorkingPressure.BackgroundStyle.BorderRightWidth = 1;
            this.HeaderGridWorkingPressure.BackgroundStyle.BorderTopWidth = 1;
            this.HeaderGridWorkingPressure.BackgroundStyle.Class = "ItemPanel";
            this.HeaderGridWorkingPressure.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.HeaderGridWorkingPressure.BackgroundStyle.PaddingBottom = 1;
            this.HeaderGridWorkingPressure.BackgroundStyle.PaddingLeft = 1;
            this.HeaderGridWorkingPressure.BackgroundStyle.PaddingRight = 1;
            this.HeaderGridWorkingPressure.BackgroundStyle.PaddingTop = 1;
            this.HeaderGridWorkingPressure.ButtonDeletePermissionCode = 0;
            this.HeaderGridWorkingPressure.ButtonDeleteVisible = true;
            this.HeaderGridWorkingPressure.ButtonEditPermissionCode = 0;
            this.HeaderGridWorkingPressure.ButtonEditVisible = true;
            this.HeaderGridWorkingPressure.ButtonExcelExportVisible = false;
            this.HeaderGridWorkingPressure.ButtonExcelPermissionCode = 0;
            this.HeaderGridWorkingPressure.ButtonInsertPermissionCode = 0;
            this.HeaderGridWorkingPressure.ButtonInsertVisible = true;
            this.HeaderGridWorkingPressure.ButtonPrintExpertPermissionCode = 0;
            this.HeaderGridWorkingPressure.ButtonPrintExpertVisible = false;
            this.HeaderGridWorkingPressure.ButtonPrintPermissionCode = 0;
            this.HeaderGridWorkingPressure.ButtonPrintVisible = true;
            this.HeaderGridWorkingPressure.ButtonRefreshVisible = true;
            this.HeaderGridWorkingPressure.ButtonSearchExpertVisible = false;
            this.HeaderGridWorkingPressure.ButtonSearchVisible = true;
            this.HeaderGridWorkingPressure.ButtonSelectorVisible = false;
            this.HeaderGridWorkingPressure.ContainerControlProcessDialogKey = true;
            this.HeaderGridWorkingPressure.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderGridWorkingPressure.FitButtonsToContainerWidth = true;
            this.HeaderGridWorkingPressure.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.HeaderGridWorkingPressure.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.HeaderGridWorkingPressure.GridViewSet = this.GridViewWorkingPressure;
            this.HeaderGridWorkingPressure.Location = new System.Drawing.Point(0, 0);
            this.HeaderGridWorkingPressure.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HeaderGridWorkingPressure.Name = "HeaderGridWorkingPressure";
            this.HeaderGridWorkingPressure.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HeaderGridWorkingPressure.Size = new System.Drawing.Size(476, 35);
            this.HeaderGridWorkingPressure.TabIndex = 31;
            this.HeaderGridWorkingPressure.Text = "mssHeaderGrid1";
            this.HeaderGridWorkingPressure.ThemeAware = true;
            this.HeaderGridWorkingPressure.buttonItemInsertClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemInsertClickEventHandler(this.headerGridWorkingPressure_btnInsertClick);
            this.HeaderGridWorkingPressure.buttonItemEditClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemEditClickEventHandler(this.headerGridWorkingPressure_btnEditClick);
            this.HeaderGridWorkingPressure.buttonItemDeleteClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemDeleteClickEventHandler(this.headerGridWorkingPressure_btnDeleteClick);
            this.HeaderGridWorkingPressure.buttonItemRefreshClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemRefreshClickEventHandler(this.headerGridWorkingPressure_btnRefreshClick);
            // 
            // WorkingPressure_Frm
            // 
            this.ClientSize = new System.Drawing.Size(476, 414);
            this.Controls.Add(this.GridViewWorkingPressure);
            this.Controls.Add(this.HeaderGridWorkingPressure);
            this.Controls.Add(this.con);
            this.Name = "WorkingPressure_Frm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "فشار کاری Psi";
            this.Load += new System.EventHandler(this.WorkingPressure_Frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewWorkingPressure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLWorkingPressureBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MSSGroupPanel con;
        private MSSGridexView GridViewWorkingPressure;
        private MSSHeaderGrid HeaderGridWorkingPressure;
        private System.Windows.Forms.BindingSource tBLWorkingPressureBindingSource;
    }
}
