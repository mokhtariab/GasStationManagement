using MSS.Library.Control;

namespace GasStationManagement.View.BaseForms
{
    partial class Parameters_Frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Parameters_Frm));
            Janus.Windows.GridEX.GridEXLayout GridViewParameters_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.con = new MSS.Library.Control.MSSGroupPanel(this.components);
            this.HeaderGridParameters = new MSS.Library.Control.MSSHeaderGrid();
            this.mssPanel1 = new MSS.Library.Control.MSSPanel(this.components);
            this.GridViewParameters = new MSS.Library.Control.MSSGridexView();
            this.tBLParameterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewParameters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLParameterBindingSource)).BeginInit();
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
            // HeaderGridParameters
            // 
            // 
            // 
            // 
            this.HeaderGridParameters.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridParameters.BackgroundStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridParameters.BackgroundStyle.BorderBottomWidth = 1;
            this.HeaderGridParameters.BackgroundStyle.BorderLeftWidth = 1;
            this.HeaderGridParameters.BackgroundStyle.BorderRightWidth = 1;
            this.HeaderGridParameters.BackgroundStyle.BorderTopWidth = 1;
            this.HeaderGridParameters.BackgroundStyle.Class = "ItemPanel";
            this.HeaderGridParameters.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.HeaderGridParameters.BackgroundStyle.PaddingBottom = 1;
            this.HeaderGridParameters.BackgroundStyle.PaddingLeft = 1;
            this.HeaderGridParameters.BackgroundStyle.PaddingRight = 1;
            this.HeaderGridParameters.BackgroundStyle.PaddingTop = 1;
            this.HeaderGridParameters.ButtonDeletePermissionCode = 0;
            this.HeaderGridParameters.ButtonDeleteVisible = true;
            this.HeaderGridParameters.ButtonEditPermissionCode = 0;
            this.HeaderGridParameters.ButtonEditVisible = true;
            this.HeaderGridParameters.ButtonExcelExportVisible = false;
            this.HeaderGridParameters.ButtonExcelPermissionCode = 0;
            this.HeaderGridParameters.ButtonInsertPermissionCode = 0;
            this.HeaderGridParameters.ButtonInsertVisible = true;
            this.HeaderGridParameters.ButtonPrintExpertPermissionCode = 0;
            this.HeaderGridParameters.ButtonPrintExpertVisible = false;
            this.HeaderGridParameters.ButtonPrintPermissionCode = 0;
            this.HeaderGridParameters.ButtonPrintVisible = true;
            this.HeaderGridParameters.ButtonRefreshVisible = true;
            this.HeaderGridParameters.ButtonSearchExpertVisible = false;
            this.HeaderGridParameters.ButtonSearchVisible = true;
            this.HeaderGridParameters.ButtonSelectorVisible = false;
            this.HeaderGridParameters.ContainerControlProcessDialogKey = true;
            this.HeaderGridParameters.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderGridParameters.FitButtonsToContainerWidth = true;
            this.HeaderGridParameters.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.HeaderGridParameters.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.HeaderGridParameters.Location = new System.Drawing.Point(0, 0);
            this.HeaderGridParameters.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HeaderGridParameters.Name = "HeaderGridParameters";
            this.HeaderGridParameters.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HeaderGridParameters.Size = new System.Drawing.Size(518, 36);
            this.HeaderGridParameters.TabIndex = 31;
            this.HeaderGridParameters.Text = "mssHeaderGrid1";
            this.HeaderGridParameters.ThemeAware = true;
            this.HeaderGridParameters.buttonItemInsertClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemInsertClickEventHandler(this.headerGridParameters_btnInsertClick);
            this.HeaderGridParameters.buttonItemEditClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemEditClickEventHandler(this.headerGridParameters_btnEditClick);
            this.HeaderGridParameters.buttonItemDeleteClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemDeleteClickEventHandler(this.headerGridParameters_btnDeleteClick);
            this.HeaderGridParameters.buttonItemRefreshClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemRefreshClickEventHandler(this.headerGridParameters_btnRefreshClick);
            // 
            // mssPanel1
            // 
            this.mssPanel1.Location = new System.Drawing.Point(0, 0);
            this.mssPanel1.Name = "mssPanel1";
            this.mssPanel1.Size = new System.Drawing.Size(200, 100);
            this.mssPanel1.TabIndex = 0;
            // 
            // GridViewParameters
            // 
            this.GridViewParameters.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.GridViewParameters.AlternatingRowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewParameters.BuiltInTextsData = resources.GetString("GridViewParameters.BuiltInTextsData");
            this.GridViewParameters.CardViewGridlines = Janus.Windows.GridEX.CardViewGridlines.Both;
            this.GridViewParameters.DataSource = this.tBLParameterBindingSource;
            this.GridViewParameters.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            GridViewParameters_DesignTimeLayout.LayoutString = resources.GetString("GridViewParameters_DesignTimeLayout.LayoutString");
            this.GridViewParameters.DesignTimeLayout = GridViewParameters_DesignTimeLayout;
            this.GridViewParameters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewParameters.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.GridViewParameters.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.GridViewParameters.Font = new System.Drawing.Font("Tahoma", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.GridViewParameters.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewParameters.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
            this.GridViewParameters.Location = new System.Drawing.Point(0, 36);
            this.GridViewParameters.Name = "GridViewParameters";
            this.GridViewParameters.RecordNavigator = true;
            this.GridViewParameters.RowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewParameters.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition;
            this.GridViewParameters.RowHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewParameters.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.GridViewParameters.Size = new System.Drawing.Size(518, 369);
            this.GridViewParameters.TabIndex = 32;
            this.GridViewParameters.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.GridViewParameters.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010;
            // 
            // tBLParameterBindingSource
            // 
            this.tBLParameterBindingSource.DataSource = typeof(GasStationManagement.Model.Basic.DataAccess.TBL_Parameter);
            // 
            // Parameters_Frm
            // 
            this.ClientSize = new System.Drawing.Size(518, 431);
            this.Controls.Add(this.GridViewParameters);
            this.Controls.Add(this.HeaderGridParameters);
            this.Controls.Add(this.con);
            this.Name = "Parameters_Frm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "پارامتر";
            this.Load += new System.EventHandler(this.Parameters_Frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewParameters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLParameterBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MSSGroupPanel con;
        private MSSHeaderGrid HeaderGridParameters;
        private MSSPanel mssPanel1;
        private MSSGridexView GridViewParameters;
        private System.Windows.Forms.BindingSource tBLParameterBindingSource;
    }
}
