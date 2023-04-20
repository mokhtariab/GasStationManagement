using MSS.Library.Control;

namespace GasStationManagement.View.BaseForms
{
    partial class Line_Frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Line_Frm));
            Janus.Windows.GridEX.GridEXLayout GridViewLine_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.tBLLineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.con = new MSS.Library.Control.MSSGroupPanel(this.components);
            this.GridViewLine = new MSS.Library.Control.MSSGridexView();
            this.HeaderGridLine = new MSS.Library.Control.MSSHeaderGrid();
            ((System.ComponentModel.ISupportInitialize)(this.tBLLineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewLine)).BeginInit();
            this.SuspendLayout();
            // 
            // tBLLineBindingSource
            // 
            this.tBLLineBindingSource.DataSource = typeof(GasStationManagement.Model.Basic.DataAccess.TBL_Line);
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
            // GridViewLine
            // 
            this.GridViewLine.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.GridViewLine.AlternatingColors = true;
            this.GridViewLine.AlternatingRowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewLine.BuiltInTextsData = resources.GetString("GridViewLine.BuiltInTextsData");
            this.GridViewLine.CardViewGridlines = Janus.Windows.GridEX.CardViewGridlines.Both;
            this.GridViewLine.DataSource = this.tBLLineBindingSource;
            this.GridViewLine.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            GridViewLine_DesignTimeLayout.LayoutString = resources.GetString("GridViewLine_DesignTimeLayout.LayoutString");
            this.GridViewLine.DesignTimeLayout = GridViewLine_DesignTimeLayout;
            this.GridViewLine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewLine.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.GridViewLine.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.GridViewLine.Font = new System.Drawing.Font("Tahoma", 8.150944F);
            this.GridViewLine.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewLine.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
            this.GridViewLine.Location = new System.Drawing.Point(0, 35);
            this.GridViewLine.Name = "GridViewLine";
            this.GridViewLine.RecordNavigator = true;
            this.GridViewLine.RowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewLine.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition;
            this.GridViewLine.RowHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewLine.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.GridViewLine.Size = new System.Drawing.Size(663, 353);
            this.GridViewLine.TabIndex = 30;
            this.GridViewLine.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.GridViewLine.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010;
            // 
            // HeaderGridLine
            // 
            // 
            // 
            // 
            this.HeaderGridLine.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridLine.BackgroundStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridLine.BackgroundStyle.BorderBottomWidth = 1;
            this.HeaderGridLine.BackgroundStyle.BorderLeftWidth = 1;
            this.HeaderGridLine.BackgroundStyle.BorderRightWidth = 1;
            this.HeaderGridLine.BackgroundStyle.BorderTopWidth = 1;
            this.HeaderGridLine.BackgroundStyle.Class = "ItemPanel";
            this.HeaderGridLine.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.HeaderGridLine.BackgroundStyle.PaddingBottom = 1;
            this.HeaderGridLine.BackgroundStyle.PaddingLeft = 1;
            this.HeaderGridLine.BackgroundStyle.PaddingRight = 1;
            this.HeaderGridLine.BackgroundStyle.PaddingTop = 1;
            this.HeaderGridLine.ButtonDeletePermissionCode = 0;
            this.HeaderGridLine.ButtonDeleteVisible = true;
            this.HeaderGridLine.ButtonEditPermissionCode = 0;
            this.HeaderGridLine.ButtonEditVisible = true;
            this.HeaderGridLine.ButtonExcelExportVisible = false;
            this.HeaderGridLine.ButtonExcelPermissionCode = 0;
            this.HeaderGridLine.ButtonInsertPermissionCode = 0;
            this.HeaderGridLine.ButtonInsertVisible = true;
            this.HeaderGridLine.ButtonPrintExpertPermissionCode = 0;
            this.HeaderGridLine.ButtonPrintExpertVisible = false;
            this.HeaderGridLine.ButtonPrintPermissionCode = 0;
            this.HeaderGridLine.ButtonPrintVisible = true;
            this.HeaderGridLine.ButtonRefreshVisible = true;
            this.HeaderGridLine.ButtonSearchExpertVisible = false;
            this.HeaderGridLine.ButtonSearchVisible = true;
            this.HeaderGridLine.ButtonSelectorVisible = false;
            this.HeaderGridLine.ContainerControlProcessDialogKey = true;
            this.HeaderGridLine.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderGridLine.FitButtonsToContainerWidth = true;
            this.HeaderGridLine.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.HeaderGridLine.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.HeaderGridLine.GridViewSet = this.GridViewLine;
            this.HeaderGridLine.Location = new System.Drawing.Point(0, 0);
            this.HeaderGridLine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HeaderGridLine.Name = "HeaderGridLine";
            this.HeaderGridLine.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HeaderGridLine.Size = new System.Drawing.Size(663, 35);
            this.HeaderGridLine.TabIndex = 31;
            this.HeaderGridLine.Text = "mssHeaderGrid1";
            this.HeaderGridLine.ThemeAware = true;
            this.HeaderGridLine.buttonItemInsertClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemInsertClickEventHandler(this.headerGridLine_btnInsertClick);
            this.HeaderGridLine.buttonItemEditClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemEditClickEventHandler(this.headerGridLine_btnEditClick);
            this.HeaderGridLine.buttonItemDeleteClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemDeleteClickEventHandler(this.headerGridLine_btnDeleteClick);
            this.HeaderGridLine.buttonItemRefreshClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemRefreshClickEventHandler(this.headerGridLine_btnRefreshClick);
            // 
            // Line_Frm
            // 
            this.ClientSize = new System.Drawing.Size(663, 414);
            this.Controls.Add(this.GridViewLine);
            this.Controls.Add(this.HeaderGridLine);
            this.Controls.Add(this.con);
            this.Name = "Line_Frm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "خط";
            this.Load += new System.EventHandler(this.Line_Frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tBLLineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewLine)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MSSGroupPanel con;
        private System.Windows.Forms.BindingSource tBLLineBindingSource;
        private MSSGridexView GridViewLine;
        private MSSHeaderGrid HeaderGridLine;
    }
}
