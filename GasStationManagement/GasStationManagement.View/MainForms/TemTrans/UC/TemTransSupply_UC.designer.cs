using MSS.Library.Control;

namespace GasStationManagement.View.MainForms.TemTrans
{
    partial class TemTransSupply_UC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TemTransSupply_UC));
            Janus.Windows.GridEX.GridEXLayout GridViewTemTransSupply_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.HeaderGridTemTransSupply = new MSS.Library.Control.MSSHeaderGrid();
            this.GridViewTemTransSupply = new MSS.Library.Control.MSSGridexView();
            this.vWTemTransSupplyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewTemTransSupply)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWTemTransSupplyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // HeaderGridTemTransSupply
            // 
            // 
            // 
            // 
            this.HeaderGridTemTransSupply.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridTemTransSupply.BackgroundStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridTemTransSupply.BackgroundStyle.BorderBottomWidth = 1;
            this.HeaderGridTemTransSupply.BackgroundStyle.BorderLeftWidth = 1;
            this.HeaderGridTemTransSupply.BackgroundStyle.BorderRightWidth = 1;
            this.HeaderGridTemTransSupply.BackgroundStyle.BorderTopWidth = 1;
            this.HeaderGridTemTransSupply.BackgroundStyle.Class = "ItemPanel";
            this.HeaderGridTemTransSupply.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.HeaderGridTemTransSupply.BackgroundStyle.PaddingBottom = 1;
            this.HeaderGridTemTransSupply.BackgroundStyle.PaddingLeft = 1;
            this.HeaderGridTemTransSupply.BackgroundStyle.PaddingRight = 1;
            this.HeaderGridTemTransSupply.BackgroundStyle.PaddingTop = 1;
            this.HeaderGridTemTransSupply.ButtonDeletePermissionCode = 0;
            this.HeaderGridTemTransSupply.ButtonDeleteVisible = true;
            this.HeaderGridTemTransSupply.ButtonEditPermissionCode = 0;
            this.HeaderGridTemTransSupply.ButtonEditVisible = true;
            this.HeaderGridTemTransSupply.ButtonExcelExportVisible = true;
            this.HeaderGridTemTransSupply.ButtonExcelPermissionCode = 0;
            this.HeaderGridTemTransSupply.ButtonInsertPermissionCode = 0;
            this.HeaderGridTemTransSupply.ButtonInsertVisible = true;
            this.HeaderGridTemTransSupply.ButtonPrintExpertPermissionCode = 0;
            this.HeaderGridTemTransSupply.ButtonPrintExpertVisible = false;
            this.HeaderGridTemTransSupply.ButtonPrintPermissionCode = 0;
            this.HeaderGridTemTransSupply.ButtonPrintVisible = true;
            this.HeaderGridTemTransSupply.ButtonRefreshVisible = true;
            this.HeaderGridTemTransSupply.ButtonSearchExpertVisible = false;
            this.HeaderGridTemTransSupply.ButtonSearchVisible = true;
            this.HeaderGridTemTransSupply.ButtonSelectorVisible = true;
            this.HeaderGridTemTransSupply.ContainerControlProcessDialogKey = true;
            this.HeaderGridTemTransSupply.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderGridTemTransSupply.FitButtonsToContainerWidth = true;
            this.HeaderGridTemTransSupply.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.HeaderGridTemTransSupply.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.HeaderGridTemTransSupply.GridViewSet = this.GridViewTemTransSupply;
            this.HeaderGridTemTransSupply.Location = new System.Drawing.Point(0, 0);
            this.HeaderGridTemTransSupply.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HeaderGridTemTransSupply.Name = "HeaderGridTemTransSupply";
            this.HeaderGridTemTransSupply.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HeaderGridTemTransSupply.Size = new System.Drawing.Size(819, 37);
            this.HeaderGridTemTransSupply.TabIndex = 31;
            this.HeaderGridTemTransSupply.Text = "mssHeaderGrid1";
            this.HeaderGridTemTransSupply.ThemeAware = true;
            this.HeaderGridTemTransSupply.buttonItemInsertClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemInsertClickEventHandler(this.headerGridTemTransSupply_btnInsertClick);
            this.HeaderGridTemTransSupply.buttonItemEditClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemEditClickEventHandler(this.headerGridTemTransSupply_btnEditClick);
            this.HeaderGridTemTransSupply.buttonItemDeleteClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemDeleteClickEventHandler(this.headerGridTemTransSupply_btnDeleteClick);
            this.HeaderGridTemTransSupply.buttonItemRefreshClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemRefreshClickEventHandler(this.headerGridTemTransSupply_btnRefreshClick);
            // 
            // GridViewTemTransSupply
            // 
            this.GridViewTemTransSupply.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.GridViewTemTransSupply.AlternatingRowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewTemTransSupply.BuiltInTextsData = resources.GetString("GridViewTemTransSupply.BuiltInTextsData");
            this.GridViewTemTransSupply.CardViewGridlines = Janus.Windows.GridEX.CardViewGridlines.Both;
            this.GridViewTemTransSupply.DataSource = this.vWTemTransSupplyBindingSource;
            this.GridViewTemTransSupply.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            GridViewTemTransSupply_DesignTimeLayout.LayoutString = resources.GetString("GridViewTemTransSupply_DesignTimeLayout.LayoutString");
            this.GridViewTemTransSupply.DesignTimeLayout = GridViewTemTransSupply_DesignTimeLayout;
            this.GridViewTemTransSupply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewTemTransSupply.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.GridViewTemTransSupply.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.GridViewTemTransSupply.Font = new System.Drawing.Font("Tahoma", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.GridViewTemTransSupply.GroupByBoxVisible = false;
            this.GridViewTemTransSupply.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewTemTransSupply.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
            this.GridViewTemTransSupply.Location = new System.Drawing.Point(0, 37);
            this.GridViewTemTransSupply.Name = "GridViewTemTransSupply";
            this.GridViewTemTransSupply.RecordNavigator = true;
            this.GridViewTemTransSupply.RowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewTemTransSupply.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition;
            this.GridViewTemTransSupply.RowHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewTemTransSupply.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.GridViewTemTransSupply.Size = new System.Drawing.Size(819, 468);
            this.GridViewTemTransSupply.TabIndex = 32;
            this.GridViewTemTransSupply.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.GridViewTemTransSupply.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010;
            this.GridViewTemTransSupply.BindingDataSourceSet += new System.EventHandler(this.GridViewTemTransSupply_BindingDataSourceSet);
            this.GridViewTemTransSupply.SelectionChanged += new System.EventHandler(this.GridViewTemTransSupply_SelectionChanged);
            // 
            // vWTemTransSupplyBindingSource
            // 
            this.vWTemTransSupplyBindingSource.DataSource = typeof(GasStationManagement.Model.TemTransSupply.VW_TemTransSupply);
            // 
            // TemTransSupply_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.GridViewTemTransSupply);
            this.Controls.Add(this.HeaderGridTemTransSupply);
            this.Name = "TemTransSupply_UC";
            this.Size = new System.Drawing.Size(819, 505);
            this.Load += new System.EventHandler(this.TemTransSupply_UC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewTemTransSupply)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWTemTransSupplyBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MSSHeaderGrid HeaderGridTemTransSupply;
        private MSSGridexView GridViewTemTransSupply;
        private System.Windows.Forms.BindingSource vWTemTransSupplyBindingSource;
    }
}
