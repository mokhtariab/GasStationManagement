using MSS.Library.Control;

namespace GasStationManagement.View.MainForms.TemGage
{
    partial class TemGage_UC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TemGage_UC));
            Janus.Windows.GridEX.GridEXLayout GridViewTemGage_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.tBLTemGageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HeaderGridTemGage = new MSS.Library.Control.MSSHeaderGrid();
            this.GridViewTemGage = new MSS.Library.Control.MSSGridexView();
            ((System.ComponentModel.ISupportInitialize)(this.tBLTemGageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewTemGage)).BeginInit();
            this.SuspendLayout();
            // 
            // tBLTemGageBindingSource
            // 
            this.tBLTemGageBindingSource.DataSource = typeof(GasStationManagement.Model.Basic.DataAccess.TBL_TemperatureGage);
            // 
            // HeaderGridTemGage
            // 
            // 
            // 
            // 
            this.HeaderGridTemGage.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridTemGage.BackgroundStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridTemGage.BackgroundStyle.BorderBottomWidth = 1;
            this.HeaderGridTemGage.BackgroundStyle.BorderLeftWidth = 1;
            this.HeaderGridTemGage.BackgroundStyle.BorderRightWidth = 1;
            this.HeaderGridTemGage.BackgroundStyle.BorderTopWidth = 1;
            this.HeaderGridTemGage.BackgroundStyle.Class = "ItemPanel";
            this.HeaderGridTemGage.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.HeaderGridTemGage.BackgroundStyle.PaddingBottom = 1;
            this.HeaderGridTemGage.BackgroundStyle.PaddingLeft = 1;
            this.HeaderGridTemGage.BackgroundStyle.PaddingRight = 1;
            this.HeaderGridTemGage.BackgroundStyle.PaddingTop = 1;
            this.HeaderGridTemGage.ButtonDeletePermissionCode = 0;
            this.HeaderGridTemGage.ButtonDeleteVisible = true;
            this.HeaderGridTemGage.ButtonEditPermissionCode = 0;
            this.HeaderGridTemGage.ButtonEditVisible = true;
            this.HeaderGridTemGage.ButtonExcelExportVisible = true;
            this.HeaderGridTemGage.ButtonExcelPermissionCode = 0;
            this.HeaderGridTemGage.ButtonInsertPermissionCode = 0;
            this.HeaderGridTemGage.ButtonInsertVisible = true;
            this.HeaderGridTemGage.ButtonPrintExpertPermissionCode = 0;
            this.HeaderGridTemGage.ButtonPrintExpertVisible = false;
            this.HeaderGridTemGage.ButtonPrintPermissionCode = 0;
            this.HeaderGridTemGage.ButtonPrintVisible = true;
            this.HeaderGridTemGage.ButtonRefreshVisible = true;
            this.HeaderGridTemGage.ButtonSearchExpertVisible = false;
            this.HeaderGridTemGage.ButtonSearchVisible = true;
            this.HeaderGridTemGage.ButtonSelectorVisible = true;
            this.HeaderGridTemGage.ContainerControlProcessDialogKey = true;
            this.HeaderGridTemGage.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderGridTemGage.FitButtonsToContainerWidth = true;
            this.HeaderGridTemGage.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.HeaderGridTemGage.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.HeaderGridTemGage.Location = new System.Drawing.Point(0, 0);
            this.HeaderGridTemGage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HeaderGridTemGage.Name = "HeaderGridTemGage";
            this.HeaderGridTemGage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HeaderGridTemGage.Size = new System.Drawing.Size(819, 42);
            this.HeaderGridTemGage.TabIndex = 31;
            this.HeaderGridTemGage.Text = "mssHeaderGrid1";
            this.HeaderGridTemGage.ThemeAware = true;
            this.HeaderGridTemGage.buttonItemInsertClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemInsertClickEventHandler(this.headerGridTemGage_btnInsertClick);
            this.HeaderGridTemGage.buttonItemEditClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemEditClickEventHandler(this.headerGridTemGage_btnEditClick);
            this.HeaderGridTemGage.buttonItemDeleteClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemDeleteClickEventHandler(this.headerGridTemGage_btnDeleteClick);
            this.HeaderGridTemGage.buttonItemRefreshClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemRefreshClickEventHandler(this.headerGridTemGage_btnRefreshClick);
            // 
            // GridViewTemGage
            // 
            this.GridViewTemGage.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.GridViewTemGage.AlternatingRowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewTemGage.BuiltInTextsData = resources.GetString("GridViewTemGage.BuiltInTextsData");
            this.GridViewTemGage.CardViewGridlines = Janus.Windows.GridEX.CardViewGridlines.Both;
            this.GridViewTemGage.DataSource = this.tBLTemGageBindingSource;
            this.GridViewTemGage.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            GridViewTemGage_DesignTimeLayout.LayoutString = resources.GetString("GridViewTemGage_DesignTimeLayout.LayoutString");
            this.GridViewTemGage.DesignTimeLayout = GridViewTemGage_DesignTimeLayout;
            this.GridViewTemGage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewTemGage.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.GridViewTemGage.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.GridViewTemGage.Font = new System.Drawing.Font("Tahoma", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.GridViewTemGage.GroupByBoxVisible = false;
            this.GridViewTemGage.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewTemGage.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
            this.GridViewTemGage.Location = new System.Drawing.Point(0, 42);
            this.GridViewTemGage.Name = "GridViewTemGage";
            this.GridViewTemGage.RecordNavigator = true;
            this.GridViewTemGage.RowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewTemGage.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition;
            this.GridViewTemGage.RowHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewTemGage.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.GridViewTemGage.Size = new System.Drawing.Size(819, 277);
            this.GridViewTemGage.TabIndex = 32;
            this.GridViewTemGage.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.GridViewTemGage.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010;
            this.GridViewTemGage.SelectionChanged += new System.EventHandler(this.GridViewTemGage_SelectionChanged);
            // 
            // TemGage_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.GridViewTemGage);
            this.Controls.Add(this.HeaderGridTemGage);
            this.Name = "TemGage_UC";
            this.Size = new System.Drawing.Size(819, 319);
            this.Load += new System.EventHandler(this.TemGage_UC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tBLTemGageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewTemGage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource tBLTemGageBindingSource;
        private MSSHeaderGrid HeaderGridTemGage;
        private MSSGridexView GridViewTemGage;
    }
}
