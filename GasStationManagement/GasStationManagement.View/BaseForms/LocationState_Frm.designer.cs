using MSS.Library.Control;

namespace GasStationManagement.View.BaseForms
{
    partial class LocationState_Frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LocationState_Frm));
            Janus.Windows.GridEX.GridEXLayout GridViewLocationState_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.con = new MSS.Library.Control.MSSGroupPanel(this.components);
            this.GridViewLocationState = new MSS.Library.Control.MSSGridexView();
            this.tBLLocationStateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HeaderGridLocationState = new MSS.Library.Control.MSSHeaderGrid();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewLocationState)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLLocationStateBindingSource)).BeginInit();
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
            // GridViewLocationState
            // 
            this.GridViewLocationState.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.GridViewLocationState.AlternatingColors = true;
            this.GridViewLocationState.AlternatingRowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewLocationState.BuiltInTextsData = resources.GetString("GridViewLocationState.BuiltInTextsData");
            this.GridViewLocationState.CardViewGridlines = Janus.Windows.GridEX.CardViewGridlines.Both;
            this.GridViewLocationState.DataSource = this.tBLLocationStateBindingSource;
            this.GridViewLocationState.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            GridViewLocationState_DesignTimeLayout.LayoutString = resources.GetString("GridViewLocationState_DesignTimeLayout.LayoutString");
            this.GridViewLocationState.DesignTimeLayout = GridViewLocationState_DesignTimeLayout;
            this.GridViewLocationState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewLocationState.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.GridViewLocationState.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.GridViewLocationState.Font = new System.Drawing.Font("Tahoma", 8.150944F);
            this.GridViewLocationState.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewLocationState.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
            this.GridViewLocationState.Location = new System.Drawing.Point(0, 35);
            this.GridViewLocationState.Name = "GridViewLocationState";
            this.GridViewLocationState.RecordNavigator = true;
            this.GridViewLocationState.RowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewLocationState.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition;
            this.GridViewLocationState.RowHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewLocationState.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.GridViewLocationState.Size = new System.Drawing.Size(476, 353);
            this.GridViewLocationState.TabIndex = 30;
            this.GridViewLocationState.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.GridViewLocationState.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010;
            // 
            // tBLLocationStateBindingSource
            // 
            this.tBLLocationStateBindingSource.DataSource = typeof(GasStationManagement.Model.Basic.DataAccess.TBL_LocationState);
            // 
            // HeaderGridLocationState
            // 
            // 
            // 
            // 
            this.HeaderGridLocationState.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridLocationState.BackgroundStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridLocationState.BackgroundStyle.BorderBottomWidth = 1;
            this.HeaderGridLocationState.BackgroundStyle.BorderLeftWidth = 1;
            this.HeaderGridLocationState.BackgroundStyle.BorderRightWidth = 1;
            this.HeaderGridLocationState.BackgroundStyle.BorderTopWidth = 1;
            this.HeaderGridLocationState.BackgroundStyle.Class = "ItemPanel";
            this.HeaderGridLocationState.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.HeaderGridLocationState.BackgroundStyle.PaddingBottom = 1;
            this.HeaderGridLocationState.BackgroundStyle.PaddingLeft = 1;
            this.HeaderGridLocationState.BackgroundStyle.PaddingRight = 1;
            this.HeaderGridLocationState.BackgroundStyle.PaddingTop = 1;
            this.HeaderGridLocationState.ButtonDeletePermissionCode = 0;
            this.HeaderGridLocationState.ButtonDeleteVisible = true;
            this.HeaderGridLocationState.ButtonEditPermissionCode = 0;
            this.HeaderGridLocationState.ButtonEditVisible = true;
            this.HeaderGridLocationState.ButtonExcelExportVisible = false;
            this.HeaderGridLocationState.ButtonExcelPermissionCode = 0;
            this.HeaderGridLocationState.ButtonInsertPermissionCode = 0;
            this.HeaderGridLocationState.ButtonInsertVisible = true;
            this.HeaderGridLocationState.ButtonPrintExpertPermissionCode = 0;
            this.HeaderGridLocationState.ButtonPrintExpertVisible = false;
            this.HeaderGridLocationState.ButtonPrintPermissionCode = 0;
            this.HeaderGridLocationState.ButtonPrintVisible = true;
            this.HeaderGridLocationState.ButtonRefreshVisible = true;
            this.HeaderGridLocationState.ButtonSearchExpertVisible = false;
            this.HeaderGridLocationState.ButtonSearchVisible = true;
            this.HeaderGridLocationState.ButtonSelectorVisible = false;
            this.HeaderGridLocationState.ContainerControlProcessDialogKey = true;
            this.HeaderGridLocationState.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderGridLocationState.FitButtonsToContainerWidth = true;
            this.HeaderGridLocationState.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.HeaderGridLocationState.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.HeaderGridLocationState.GridViewSet = this.GridViewLocationState;
            this.HeaderGridLocationState.Location = new System.Drawing.Point(0, 0);
            this.HeaderGridLocationState.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HeaderGridLocationState.Name = "HeaderGridLocationState";
            this.HeaderGridLocationState.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HeaderGridLocationState.Size = new System.Drawing.Size(476, 35);
            this.HeaderGridLocationState.TabIndex = 31;
            this.HeaderGridLocationState.Text = "mssHeaderGrid1";
            this.HeaderGridLocationState.ThemeAware = true;
            this.HeaderGridLocationState.buttonItemInsertClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemInsertClickEventHandler(this.headerGridLocationState_btnInsertClick);
            this.HeaderGridLocationState.buttonItemEditClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemEditClickEventHandler(this.headerGridLocationState_btnEditClick);
            this.HeaderGridLocationState.buttonItemDeleteClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemDeleteClickEventHandler(this.headerGridLocationState_btnDeleteClick);
            this.HeaderGridLocationState.buttonItemRefreshClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemRefreshClickEventHandler(this.headerGridLocationState_btnRefreshClick);
            // 
            // LocationState_Frm
            // 
            this.ClientSize = new System.Drawing.Size(476, 414);
            this.Controls.Add(this.GridViewLocationState);
            this.Controls.Add(this.HeaderGridLocationState);
            this.Controls.Add(this.con);
            this.Name = "LocationState_Frm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "موقعیت تجهیز";
            this.Load += new System.EventHandler(this.LocationState_Frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewLocationState)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLLocationStateBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MSSGroupPanel con;
        private MSSGridexView GridViewLocationState;
        private MSSHeaderGrid HeaderGridLocationState;
        private System.Windows.Forms.BindingSource tBLLocationStateBindingSource;
    }
}
