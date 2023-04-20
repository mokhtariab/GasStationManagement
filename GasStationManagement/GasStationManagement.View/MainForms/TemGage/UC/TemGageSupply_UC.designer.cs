using MSS.Library.Control;

namespace GasStationManagement.View.MainForms.TemGage
{
    partial class TemGageSupply_UC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TemGageSupply_UC));
            Janus.Windows.GridEX.GridEXLayout GridViewTemGageSupply_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.HeaderGridTemGageSupply = new MSS.Library.Control.MSSHeaderGrid();
            this.GridViewTemGageSupply = new MSS.Library.Control.MSSGridexView();
            this.vWTemGageSupplyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewTemGageSupply)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWTemGageSupplyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // HeaderGridTemGageSupply
            // 
            // 
            // 
            // 
            this.HeaderGridTemGageSupply.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridTemGageSupply.BackgroundStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridTemGageSupply.BackgroundStyle.BorderBottomWidth = 1;
            this.HeaderGridTemGageSupply.BackgroundStyle.BorderLeftWidth = 1;
            this.HeaderGridTemGageSupply.BackgroundStyle.BorderRightWidth = 1;
            this.HeaderGridTemGageSupply.BackgroundStyle.BorderTopWidth = 1;
            this.HeaderGridTemGageSupply.BackgroundStyle.Class = "ItemPanel";
            this.HeaderGridTemGageSupply.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.HeaderGridTemGageSupply.BackgroundStyle.PaddingBottom = 1;
            this.HeaderGridTemGageSupply.BackgroundStyle.PaddingLeft = 1;
            this.HeaderGridTemGageSupply.BackgroundStyle.PaddingRight = 1;
            this.HeaderGridTemGageSupply.BackgroundStyle.PaddingTop = 1;
            this.HeaderGridTemGageSupply.ButtonDeletePermissionCode = 0;
            this.HeaderGridTemGageSupply.ButtonDeleteVisible = true;
            this.HeaderGridTemGageSupply.ButtonEditPermissionCode = 0;
            this.HeaderGridTemGageSupply.ButtonEditVisible = true;
            this.HeaderGridTemGageSupply.ButtonExcelExportVisible = true;
            this.HeaderGridTemGageSupply.ButtonExcelPermissionCode = 0;
            this.HeaderGridTemGageSupply.ButtonInsertPermissionCode = 0;
            this.HeaderGridTemGageSupply.ButtonInsertVisible = true;
            this.HeaderGridTemGageSupply.ButtonPrintExpertPermissionCode = 0;
            this.HeaderGridTemGageSupply.ButtonPrintExpertVisible = false;
            this.HeaderGridTemGageSupply.ButtonPrintPermissionCode = 0;
            this.HeaderGridTemGageSupply.ButtonPrintVisible = true;
            this.HeaderGridTemGageSupply.ButtonRefreshVisible = true;
            this.HeaderGridTemGageSupply.ButtonSearchExpertVisible = false;
            this.HeaderGridTemGageSupply.ButtonSearchVisible = true;
            this.HeaderGridTemGageSupply.ButtonSelectorVisible = true;
            this.HeaderGridTemGageSupply.ContainerControlProcessDialogKey = true;
            this.HeaderGridTemGageSupply.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderGridTemGageSupply.FitButtonsToContainerWidth = true;
            this.HeaderGridTemGageSupply.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.HeaderGridTemGageSupply.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.HeaderGridTemGageSupply.GridViewSet = this.GridViewTemGageSupply;
            this.HeaderGridTemGageSupply.Location = new System.Drawing.Point(0, 0);
            this.HeaderGridTemGageSupply.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HeaderGridTemGageSupply.Name = "HeaderGridTemGageSupply";
            this.HeaderGridTemGageSupply.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HeaderGridTemGageSupply.Size = new System.Drawing.Size(819, 35);
            this.HeaderGridTemGageSupply.TabIndex = 31;
            this.HeaderGridTemGageSupply.Text = "mssHeaderGrid1";
            this.HeaderGridTemGageSupply.ThemeAware = true;
            this.HeaderGridTemGageSupply.buttonItemInsertClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemInsertClickEventHandler(this.headerGridTemGageSupply_btnInsertClick);
            this.HeaderGridTemGageSupply.buttonItemEditClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemEditClickEventHandler(this.headerGridTemGageSupply_btnEditClick);
            this.HeaderGridTemGageSupply.buttonItemDeleteClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemDeleteClickEventHandler(this.headerGridTemGageSupply_btnDeleteClick);
            this.HeaderGridTemGageSupply.buttonItemRefreshClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemRefreshClickEventHandler(this.headerGridTemGageSupply_btnRefreshClick);
            // 
            // GridViewTemGageSupply
            // 
            this.GridViewTemGageSupply.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.GridViewTemGageSupply.AlternatingRowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewTemGageSupply.BuiltInTextsData = resources.GetString("GridViewTemGageSupply.BuiltInTextsData");
            this.GridViewTemGageSupply.CardViewGridlines = Janus.Windows.GridEX.CardViewGridlines.Both;
            this.GridViewTemGageSupply.DataSource = this.vWTemGageSupplyBindingSource;
            this.GridViewTemGageSupply.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            GridViewTemGageSupply_DesignTimeLayout.LayoutString = resources.GetString("GridViewTemGageSupply_DesignTimeLayout.LayoutString");
            this.GridViewTemGageSupply.DesignTimeLayout = GridViewTemGageSupply_DesignTimeLayout;
            this.GridViewTemGageSupply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewTemGageSupply.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.GridViewTemGageSupply.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.GridViewTemGageSupply.Font = new System.Drawing.Font("Tahoma", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.GridViewTemGageSupply.GroupByBoxVisible = false;
            this.GridViewTemGageSupply.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewTemGageSupply.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
            this.GridViewTemGageSupply.Location = new System.Drawing.Point(0, 35);
            this.GridViewTemGageSupply.Name = "GridViewTemGageSupply";
            this.GridViewTemGageSupply.RecordNavigator = true;
            this.GridViewTemGageSupply.RowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewTemGageSupply.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition;
            this.GridViewTemGageSupply.RowHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewTemGageSupply.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.GridViewTemGageSupply.Size = new System.Drawing.Size(819, 470);
            this.GridViewTemGageSupply.TabIndex = 32;
            this.GridViewTemGageSupply.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.GridViewTemGageSupply.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010;
            this.GridViewTemGageSupply.BindingDataSourceSet += new System.EventHandler(this.GridViewTemGageSupply_BindingDataSourceSet);
            this.GridViewTemGageSupply.SelectionChanged += new System.EventHandler(this.GridViewTemGageSupply_SelectionChanged);
            // 
            // vWTemGageSupplyBindingSource
            // 
            this.vWTemGageSupplyBindingSource.DataSource = typeof(GasStationManagement.Model.TemGageSupply.VW_TemGageSupply);
            // 
            // TemGageSupply_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.GridViewTemGageSupply);
            this.Controls.Add(this.HeaderGridTemGageSupply);
            this.Name = "TemGageSupply_UC";
            this.Size = new System.Drawing.Size(819, 505);
            this.Load += new System.EventHandler(this.TemGageSupply_UC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewTemGageSupply)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWTemGageSupplyBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MSSHeaderGrid HeaderGridTemGageSupply;
        private MSSGridexView GridViewTemGageSupply;
        private System.Windows.Forms.BindingSource vWTemGageSupplyBindingSource;
    }
}
