using MSS.Library.Control;

namespace GasStationManagement.View.MainForms.EVCD
{
    partial class EVCDSupply_UC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EVCDSupply_UC));
            Janus.Windows.GridEX.GridEXLayout GridViewEVCDSupply_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.HeaderGridEVCDSupply = new MSS.Library.Control.MSSHeaderGrid();
            this.GridViewEVCDSupply = new MSS.Library.Control.MSSGridexView();
            this.vWEVCDSupplyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewEVCDSupply)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWEVCDSupplyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // HeaderGridEVCDSupply
            // 
            // 
            // 
            // 
            this.HeaderGridEVCDSupply.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridEVCDSupply.BackgroundStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridEVCDSupply.BackgroundStyle.BorderBottomWidth = 1;
            this.HeaderGridEVCDSupply.BackgroundStyle.BorderLeftWidth = 1;
            this.HeaderGridEVCDSupply.BackgroundStyle.BorderRightWidth = 1;
            this.HeaderGridEVCDSupply.BackgroundStyle.BorderTopWidth = 1;
            this.HeaderGridEVCDSupply.BackgroundStyle.Class = "ItemPanel";
            this.HeaderGridEVCDSupply.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.HeaderGridEVCDSupply.BackgroundStyle.PaddingBottom = 1;
            this.HeaderGridEVCDSupply.BackgroundStyle.PaddingLeft = 1;
            this.HeaderGridEVCDSupply.BackgroundStyle.PaddingRight = 1;
            this.HeaderGridEVCDSupply.BackgroundStyle.PaddingTop = 1;
            this.HeaderGridEVCDSupply.ButtonDeletePermissionCode = 0;
            this.HeaderGridEVCDSupply.ButtonDeleteVisible = true;
            this.HeaderGridEVCDSupply.ButtonEditPermissionCode = 0;
            this.HeaderGridEVCDSupply.ButtonEditVisible = true;
            this.HeaderGridEVCDSupply.ButtonExcelExportVisible = true;
            this.HeaderGridEVCDSupply.ButtonExcelPermissionCode = 0;
            this.HeaderGridEVCDSupply.ButtonInsertPermissionCode = 0;
            this.HeaderGridEVCDSupply.ButtonInsertVisible = true;
            this.HeaderGridEVCDSupply.ButtonPrintExpertPermissionCode = 0;
            this.HeaderGridEVCDSupply.ButtonPrintExpertVisible = false;
            this.HeaderGridEVCDSupply.ButtonPrintPermissionCode = 0;
            this.HeaderGridEVCDSupply.ButtonPrintVisible = true;
            this.HeaderGridEVCDSupply.ButtonRefreshVisible = true;
            this.HeaderGridEVCDSupply.ButtonSearchExpertVisible = false;
            this.HeaderGridEVCDSupply.ButtonSearchVisible = true;
            this.HeaderGridEVCDSupply.ButtonSelectorVisible = true;
            this.HeaderGridEVCDSupply.ContainerControlProcessDialogKey = true;
            this.HeaderGridEVCDSupply.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderGridEVCDSupply.FitButtonsToContainerWidth = true;
            this.HeaderGridEVCDSupply.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.HeaderGridEVCDSupply.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.HeaderGridEVCDSupply.GridViewSet = this.GridViewEVCDSupply;
            this.HeaderGridEVCDSupply.Location = new System.Drawing.Point(0, 0);
            this.HeaderGridEVCDSupply.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HeaderGridEVCDSupply.Name = "HeaderGridEVCDSupply";
            this.HeaderGridEVCDSupply.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HeaderGridEVCDSupply.Size = new System.Drawing.Size(819, 38);
            this.HeaderGridEVCDSupply.TabIndex = 31;
            this.HeaderGridEVCDSupply.Text = "mssHeaderGrid1";
            this.HeaderGridEVCDSupply.ThemeAware = true;
            this.HeaderGridEVCDSupply.buttonItemInsertClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemInsertClickEventHandler(this.headerGridEVCDSupply_btnInsertClick);
            this.HeaderGridEVCDSupply.buttonItemEditClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemEditClickEventHandler(this.headerGridEVCDSupply_btnEditClick);
            this.HeaderGridEVCDSupply.buttonItemDeleteClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemDeleteClickEventHandler(this.headerGridEVCDSupply_btnDeleteClick);
            this.HeaderGridEVCDSupply.buttonItemRefreshClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemRefreshClickEventHandler(this.headerGridEVCDSupply_btnRefreshClick);
            // 
            // GridViewEVCDSupply
            // 
            this.GridViewEVCDSupply.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.GridViewEVCDSupply.AlternatingRowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewEVCDSupply.BuiltInTextsData = resources.GetString("GridViewEVCDSupply.BuiltInTextsData");
            this.GridViewEVCDSupply.CardViewGridlines = Janus.Windows.GridEX.CardViewGridlines.Both;
            this.GridViewEVCDSupply.DataSource = this.vWEVCDSupplyBindingSource;
            this.GridViewEVCDSupply.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            GridViewEVCDSupply_DesignTimeLayout.LayoutString = resources.GetString("GridViewEVCDSupply_DesignTimeLayout.LayoutString");
            this.GridViewEVCDSupply.DesignTimeLayout = GridViewEVCDSupply_DesignTimeLayout;
            this.GridViewEVCDSupply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewEVCDSupply.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.GridViewEVCDSupply.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.GridViewEVCDSupply.Font = new System.Drawing.Font("Tahoma", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.GridViewEVCDSupply.GroupByBoxVisible = false;
            this.GridViewEVCDSupply.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewEVCDSupply.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
            this.GridViewEVCDSupply.Location = new System.Drawing.Point(0, 38);
            this.GridViewEVCDSupply.Name = "GridViewEVCDSupply";
            this.GridViewEVCDSupply.RecordNavigator = true;
            this.GridViewEVCDSupply.RowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewEVCDSupply.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition;
            this.GridViewEVCDSupply.RowHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewEVCDSupply.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.GridViewEVCDSupply.Size = new System.Drawing.Size(819, 337);
            this.GridViewEVCDSupply.TabIndex = 32;
            this.GridViewEVCDSupply.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.GridViewEVCDSupply.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010;
            this.GridViewEVCDSupply.BindingDataSourceSet += new System.EventHandler(this.GridViewEVCDSupply_BindingDataSourceSet);
            this.GridViewEVCDSupply.SelectionChanged += new System.EventHandler(this.GridViewEVCDSupply_SelectionChanged);
            // 
            // vWEVCDSupplyBindingSource
            // 
            this.vWEVCDSupplyBindingSource.DataSource = typeof(GasStationManagement.Model.EVCDSupply.VW_EVCDSupply);
            // 
            // EVCDSupply_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.GridViewEVCDSupply);
            this.Controls.Add(this.HeaderGridEVCDSupply);
            this.Name = "EVCDSupply_UC";
            this.Size = new System.Drawing.Size(819, 375);
            this.Load += new System.EventHandler(this.EVCDSupply_UC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewEVCDSupply)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWEVCDSupplyBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MSSHeaderGrid HeaderGridEVCDSupply;
        private MSSGridexView GridViewEVCDSupply;
        private System.Windows.Forms.BindingSource vWEVCDSupplyBindingSource;
    }
}
