using MSS.Library.Control;

namespace GasStationManagement.View.BaseForms
{
    partial class EquipmentState_Frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EquipmentState_Frm));
            Janus.Windows.GridEX.GridEXLayout GridViewEquipmentState_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.con = new MSS.Library.Control.MSSGroupPanel(this.components);
            this.GridViewEquipmentState = new MSS.Library.Control.MSSGridexView();
            this.tBLEquipmentStateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HeaderGridEquipmentState = new MSS.Library.Control.MSSHeaderGrid();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewEquipmentState)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLEquipmentStateBindingSource)).BeginInit();
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
            // GridViewEquipmentState
            // 
            this.GridViewEquipmentState.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.GridViewEquipmentState.AlternatingColors = true;
            this.GridViewEquipmentState.AlternatingRowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewEquipmentState.BuiltInTextsData = resources.GetString("GridViewEquipmentState.BuiltInTextsData");
            this.GridViewEquipmentState.CardViewGridlines = Janus.Windows.GridEX.CardViewGridlines.Both;
            this.GridViewEquipmentState.DataSource = this.tBLEquipmentStateBindingSource;
            this.GridViewEquipmentState.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            GridViewEquipmentState_DesignTimeLayout.LayoutString = resources.GetString("GridViewEquipmentState_DesignTimeLayout.LayoutString");
            this.GridViewEquipmentState.DesignTimeLayout = GridViewEquipmentState_DesignTimeLayout;
            this.GridViewEquipmentState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewEquipmentState.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.GridViewEquipmentState.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.GridViewEquipmentState.Font = new System.Drawing.Font("Tahoma", 8.150944F);
            this.GridViewEquipmentState.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewEquipmentState.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
            this.GridViewEquipmentState.Location = new System.Drawing.Point(0, 34);
            this.GridViewEquipmentState.Name = "GridViewEquipmentState";
            this.GridViewEquipmentState.RecordNavigator = true;
            this.GridViewEquipmentState.RowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewEquipmentState.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition;
            this.GridViewEquipmentState.RowHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewEquipmentState.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.GridViewEquipmentState.Size = new System.Drawing.Size(476, 354);
            this.GridViewEquipmentState.TabIndex = 30;
            this.GridViewEquipmentState.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.GridViewEquipmentState.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010;
            // 
            // tBLEquipmentStateBindingSource
            // 
            this.tBLEquipmentStateBindingSource.DataSource = typeof(GasStationManagement.Model.Basic.DataAccess.TBL_EquipmentState);
            // 
            // HeaderGridEquipmentState
            // 
            // 
            // 
            // 
            this.HeaderGridEquipmentState.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridEquipmentState.BackgroundStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridEquipmentState.BackgroundStyle.BorderBottomWidth = 1;
            this.HeaderGridEquipmentState.BackgroundStyle.BorderLeftWidth = 1;
            this.HeaderGridEquipmentState.BackgroundStyle.BorderRightWidth = 1;
            this.HeaderGridEquipmentState.BackgroundStyle.BorderTopWidth = 1;
            this.HeaderGridEquipmentState.BackgroundStyle.Class = "ItemPanel";
            this.HeaderGridEquipmentState.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.HeaderGridEquipmentState.BackgroundStyle.PaddingBottom = 1;
            this.HeaderGridEquipmentState.BackgroundStyle.PaddingLeft = 1;
            this.HeaderGridEquipmentState.BackgroundStyle.PaddingRight = 1;
            this.HeaderGridEquipmentState.BackgroundStyle.PaddingTop = 1;
            this.HeaderGridEquipmentState.ButtonDeletePermissionCode = 0;
            this.HeaderGridEquipmentState.ButtonDeleteVisible = true;
            this.HeaderGridEquipmentState.ButtonEditPermissionCode = 0;
            this.HeaderGridEquipmentState.ButtonEditVisible = true;
            this.HeaderGridEquipmentState.ButtonExcelExportVisible = false;
            this.HeaderGridEquipmentState.ButtonExcelPermissionCode = 0;
            this.HeaderGridEquipmentState.ButtonInsertPermissionCode = 0;
            this.HeaderGridEquipmentState.ButtonInsertVisible = true;
            this.HeaderGridEquipmentState.ButtonPrintExpertPermissionCode = 0;
            this.HeaderGridEquipmentState.ButtonPrintExpertVisible = false;
            this.HeaderGridEquipmentState.ButtonPrintPermissionCode = 0;
            this.HeaderGridEquipmentState.ButtonPrintVisible = true;
            this.HeaderGridEquipmentState.ButtonRefreshVisible = true;
            this.HeaderGridEquipmentState.ButtonSearchExpertVisible = false;
            this.HeaderGridEquipmentState.ButtonSearchVisible = true;
            this.HeaderGridEquipmentState.ButtonSelectorVisible = false;
            this.HeaderGridEquipmentState.ContainerControlProcessDialogKey = true;
            this.HeaderGridEquipmentState.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderGridEquipmentState.FitButtonsToContainerWidth = true;
            this.HeaderGridEquipmentState.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.HeaderGridEquipmentState.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.HeaderGridEquipmentState.GridViewSet = this.GridViewEquipmentState;
            this.HeaderGridEquipmentState.Location = new System.Drawing.Point(0, 0);
            this.HeaderGridEquipmentState.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HeaderGridEquipmentState.Name = "HeaderGridEquipmentState";
            this.HeaderGridEquipmentState.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HeaderGridEquipmentState.Size = new System.Drawing.Size(476, 34);
            this.HeaderGridEquipmentState.TabIndex = 31;
            this.HeaderGridEquipmentState.Text = "mssHeaderGrid1";
            this.HeaderGridEquipmentState.ThemeAware = true;
            this.HeaderGridEquipmentState.buttonItemInsertClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemInsertClickEventHandler(this.headerGridEquipmentState_btnInsertClick);
            this.HeaderGridEquipmentState.buttonItemEditClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemEditClickEventHandler(this.headerGridEquipmentState_btnEditClick);
            this.HeaderGridEquipmentState.buttonItemDeleteClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemDeleteClickEventHandler(this.headerGridEquipmentState_btnDeleteClick);
            this.HeaderGridEquipmentState.buttonItemRefreshClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemRefreshClickEventHandler(this.headerGridEquipmentState_btnRefreshClick);
            // 
            // EquipmentState_Frm
            // 
            this.ClientSize = new System.Drawing.Size(476, 414);
            this.Controls.Add(this.GridViewEquipmentState);
            this.Controls.Add(this.HeaderGridEquipmentState);
            this.Controls.Add(this.con);
            this.Name = "EquipmentState_Frm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "وضعیت تجهیز";
            this.Load += new System.EventHandler(this.EquipmentState_Frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewEquipmentState)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLEquipmentStateBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MSSGroupPanel con;
        private MSSGridexView GridViewEquipmentState;
        private MSSHeaderGrid HeaderGridEquipmentState;
        private System.Windows.Forms.BindingSource tBLEquipmentStateBindingSource;
    }
}
