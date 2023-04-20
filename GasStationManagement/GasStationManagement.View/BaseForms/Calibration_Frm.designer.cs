using MSS.Library.Control;

namespace GasStationManagement.View.BaseForms
{
    partial class Calibration_Frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calibration_Frm));
            Janus.Windows.GridEX.GridEXLayout GridViewCalibration_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.con = new MSS.Library.Control.MSSGroupPanel(this.components);
            this.GridViewCalibration = new MSS.Library.Control.MSSGridexView();
            this.HeaderGridCalibration = new MSS.Library.Control.MSSHeaderGrid();
            this.mssPanel1 = new MSS.Library.Control.MSSPanel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewCalibration)).BeginInit();
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
            // GridViewCalibration
            // 
            this.GridViewCalibration.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.GridViewCalibration.AlternatingColors = true;
            this.GridViewCalibration.AlternatingRowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewCalibration.BuiltInTextsData = resources.GetString("GridViewCalibration.BuiltInTextsData");
            this.GridViewCalibration.CardViewGridlines = Janus.Windows.GridEX.CardViewGridlines.Both;
            this.GridViewCalibration.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            GridViewCalibration_DesignTimeLayout.LayoutString = resources.GetString("GridViewCalibration_DesignTimeLayout.LayoutString");
            this.GridViewCalibration.DesignTimeLayout = GridViewCalibration_DesignTimeLayout;
            this.GridViewCalibration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewCalibration.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.GridViewCalibration.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.GridViewCalibration.Font = new System.Drawing.Font("Tahoma", 8.150944F);
            this.GridViewCalibration.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewCalibration.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
            this.GridViewCalibration.Location = new System.Drawing.Point(0, 36);
            this.GridViewCalibration.Name = "GridViewCalibration";
            this.GridViewCalibration.RecordNavigator = true;
            this.GridViewCalibration.RowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewCalibration.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition;
            this.GridViewCalibration.RowHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewCalibration.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.GridViewCalibration.Size = new System.Drawing.Size(518, 369);
            this.GridViewCalibration.TabIndex = 30;
            this.GridViewCalibration.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.GridViewCalibration.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010;
            // 
            // HeaderGridCalibration
            // 
            // 
            // 
            // 
            this.HeaderGridCalibration.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridCalibration.BackgroundStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridCalibration.BackgroundStyle.BorderBottomWidth = 1;
            this.HeaderGridCalibration.BackgroundStyle.BorderLeftWidth = 1;
            this.HeaderGridCalibration.BackgroundStyle.BorderRightWidth = 1;
            this.HeaderGridCalibration.BackgroundStyle.BorderTopWidth = 1;
            this.HeaderGridCalibration.BackgroundStyle.Class = "ItemPanel";
            this.HeaderGridCalibration.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.HeaderGridCalibration.BackgroundStyle.PaddingBottom = 1;
            this.HeaderGridCalibration.BackgroundStyle.PaddingLeft = 1;
            this.HeaderGridCalibration.BackgroundStyle.PaddingRight = 1;
            this.HeaderGridCalibration.BackgroundStyle.PaddingTop = 1;
            this.HeaderGridCalibration.ButtonDeletePermissionCode = 0;
            this.HeaderGridCalibration.ButtonDeleteVisible = true;
            this.HeaderGridCalibration.ButtonEditPermissionCode = 0;
            this.HeaderGridCalibration.ButtonEditVisible = true;
            this.HeaderGridCalibration.ButtonExcelExportVisible = false;
            this.HeaderGridCalibration.ButtonExcelPermissionCode = 0;
            this.HeaderGridCalibration.ButtonInsertPermissionCode = 0;
            this.HeaderGridCalibration.ButtonInsertVisible = true;
            this.HeaderGridCalibration.ButtonPrintExpertPermissionCode = 0;
            this.HeaderGridCalibration.ButtonPrintExpertVisible = false;
            this.HeaderGridCalibration.ButtonPrintPermissionCode = 0;
            this.HeaderGridCalibration.ButtonPrintVisible = true;
            this.HeaderGridCalibration.ButtonRefreshVisible = true;
            this.HeaderGridCalibration.ButtonSearchExpertVisible = false;
            this.HeaderGridCalibration.ButtonSearchVisible = true;
            this.HeaderGridCalibration.ButtonSelectorVisible = false;
            this.HeaderGridCalibration.ContainerControlProcessDialogKey = true;
            this.HeaderGridCalibration.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderGridCalibration.FitButtonsToContainerWidth = true;
            this.HeaderGridCalibration.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.HeaderGridCalibration.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.HeaderGridCalibration.GridViewSet = this.GridViewCalibration;
            this.HeaderGridCalibration.Location = new System.Drawing.Point(0, 0);
            this.HeaderGridCalibration.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HeaderGridCalibration.Name = "HeaderGridCalibration";
            this.HeaderGridCalibration.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HeaderGridCalibration.Size = new System.Drawing.Size(518, 36);
            this.HeaderGridCalibration.TabIndex = 31;
            this.HeaderGridCalibration.Text = "mssHeaderGrid1";
            this.HeaderGridCalibration.ThemeAware = true;
            this.HeaderGridCalibration.buttonItemInsertClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemInsertClickEventHandler(this.headerGridCalibration_btnInsertClick);
            this.HeaderGridCalibration.buttonItemEditClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemEditClickEventHandler(this.headerGridCalibration_btnEditClick);
            this.HeaderGridCalibration.buttonItemDeleteClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemDeleteClickEventHandler(this.headerGridCalibration_btnDeleteClick);
            this.HeaderGridCalibration.buttonItemRefreshClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemRefreshClickEventHandler(this.headerGridCalibration_btnRefreshClick);
            // 
            // mssPanel1
            // 
            this.mssPanel1.Location = new System.Drawing.Point(0, 0);
            this.mssPanel1.Name = "mssPanel1";
            this.mssPanel1.Size = new System.Drawing.Size(200, 100);
            this.mssPanel1.TabIndex = 0;
            // 
            // Calibration_Frm
            // 
            this.ClientSize = new System.Drawing.Size(518, 431);
            this.Controls.Add(this.GridViewCalibration);
            this.Controls.Add(this.HeaderGridCalibration);
            this.Controls.Add(this.con);
            this.Name = "Calibration_Frm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "در حال کالیبراسیون";
            this.Load += new System.EventHandler(this.Calibration_Frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewCalibration)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MSSGroupPanel con;
        private MSSGridexView GridViewCalibration;
        private MSSHeaderGrid HeaderGridCalibration;
        private MSSPanel mssPanel1;
    }
}
