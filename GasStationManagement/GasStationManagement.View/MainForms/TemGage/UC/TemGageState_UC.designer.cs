using MSS.Library.Control;

namespace GasStationManagement.View.MainForms.TemGage
{
    partial class TemGageState_UC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TemGageState_UC));
            Janus.Windows.GridEX.GridEXLayout GridViewTemGageState_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.HeaderGridTemGageState = new MSS.Library.Control.MSSHeaderGrid();
            this.GridViewTemGageState = new MSS.Library.Control.MSSGridexView();
            this.vWTemGageStateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewTemGageState)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWTemGageStateBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // HeaderGridTemGageState
            // 
            // 
            // 
            // 
            this.HeaderGridTemGageState.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridTemGageState.BackgroundStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridTemGageState.BackgroundStyle.BorderBottomWidth = 1;
            this.HeaderGridTemGageState.BackgroundStyle.BorderLeftWidth = 1;
            this.HeaderGridTemGageState.BackgroundStyle.BorderRightWidth = 1;
            this.HeaderGridTemGageState.BackgroundStyle.BorderTopWidth = 1;
            this.HeaderGridTemGageState.BackgroundStyle.Class = "ItemPanel";
            this.HeaderGridTemGageState.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.HeaderGridTemGageState.BackgroundStyle.PaddingBottom = 1;
            this.HeaderGridTemGageState.BackgroundStyle.PaddingLeft = 1;
            this.HeaderGridTemGageState.BackgroundStyle.PaddingRight = 1;
            this.HeaderGridTemGageState.BackgroundStyle.PaddingTop = 1;
            this.HeaderGridTemGageState.ButtonDeletePermissionCode = 0;
            this.HeaderGridTemGageState.ButtonDeleteVisible = true;
            this.HeaderGridTemGageState.ButtonEditPermissionCode = 0;
            this.HeaderGridTemGageState.ButtonEditVisible = true;
            this.HeaderGridTemGageState.ButtonExcelExportVisible = true;
            this.HeaderGridTemGageState.ButtonExcelPermissionCode = 0;
            this.HeaderGridTemGageState.ButtonInsertPermissionCode = 0;
            this.HeaderGridTemGageState.ButtonInsertVisible = true;
            this.HeaderGridTemGageState.ButtonPrintExpertPermissionCode = 0;
            this.HeaderGridTemGageState.ButtonPrintExpertVisible = false;
            this.HeaderGridTemGageState.ButtonPrintPermissionCode = 0;
            this.HeaderGridTemGageState.ButtonPrintVisible = true;
            this.HeaderGridTemGageState.ButtonRefreshVisible = true;
            this.HeaderGridTemGageState.ButtonSearchExpertVisible = false;
            this.HeaderGridTemGageState.ButtonSearchVisible = true;
            this.HeaderGridTemGageState.ButtonSelectorVisible = true;
            this.HeaderGridTemGageState.ContainerControlProcessDialogKey = true;
            this.HeaderGridTemGageState.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderGridTemGageState.FitButtonsToContainerWidth = true;
            this.HeaderGridTemGageState.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.HeaderGridTemGageState.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.HeaderGridTemGageState.GridViewSet = this.GridViewTemGageState;
            this.HeaderGridTemGageState.Location = new System.Drawing.Point(0, 0);
            this.HeaderGridTemGageState.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HeaderGridTemGageState.Name = "HeaderGridTemGageState";
            this.HeaderGridTemGageState.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HeaderGridTemGageState.Size = new System.Drawing.Size(819, 40);
            this.HeaderGridTemGageState.TabIndex = 31;
            this.HeaderGridTemGageState.Text = "mssHeaderGrid1";
            this.HeaderGridTemGageState.ThemeAware = true;
            this.HeaderGridTemGageState.buttonItemInsertClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemInsertClickEventHandler(this.headerGridTemGageState_btnInsertClick);
            this.HeaderGridTemGageState.buttonItemEditClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemEditClickEventHandler(this.headerGridTemGageState_btnEditClick);
            this.HeaderGridTemGageState.buttonItemDeleteClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemDeleteClickEventHandler(this.headerGridTemGageState_btnDeleteClick);
            this.HeaderGridTemGageState.buttonItemRefreshClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemRefreshClickEventHandler(this.headerGridTemGageState_btnRefreshClick);
            // 
            // GridViewTemGageState
            // 
            this.GridViewTemGageState.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.GridViewTemGageState.AlternatingRowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewTemGageState.BuiltInTextsData = resources.GetString("GridViewTemGageState.BuiltInTextsData");
            this.GridViewTemGageState.CardViewGridlines = Janus.Windows.GridEX.CardViewGridlines.Both;
            this.GridViewTemGageState.DataSource = this.vWTemGageStateBindingSource;
            this.GridViewTemGageState.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            GridViewTemGageState_DesignTimeLayout.LayoutString = resources.GetString("GridViewTemGageState_DesignTimeLayout.LayoutString");
            this.GridViewTemGageState.DesignTimeLayout = GridViewTemGageState_DesignTimeLayout;
            this.GridViewTemGageState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewTemGageState.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.GridViewTemGageState.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.GridViewTemGageState.Font = new System.Drawing.Font("Tahoma", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.GridViewTemGageState.GroupByBoxVisible = false;
            this.GridViewTemGageState.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewTemGageState.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
            this.GridViewTemGageState.Location = new System.Drawing.Point(0, 40);
            this.GridViewTemGageState.Name = "GridViewTemGageState";
            this.GridViewTemGageState.RecordNavigator = true;
            this.GridViewTemGageState.RowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewTemGageState.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition;
            this.GridViewTemGageState.RowHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewTemGageState.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.GridViewTemGageState.Size = new System.Drawing.Size(819, 465);
            this.GridViewTemGageState.TabIndex = 32;
            this.GridViewTemGageState.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.GridViewTemGageState.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010;
            this.GridViewTemGageState.BindingDataSourceSet += new System.EventHandler(this.GridViewTemGageState_BindingDataSourceSet);
            this.GridViewTemGageState.SelectionChanged += new System.EventHandler(this.GridViewTemGageState_SelectionChanged);
            // 
            // vWTemGageStateBindingSource
            // 
            this.vWTemGageStateBindingSource.DataSource = typeof(GasStationManagement.Model.TemGageState.VW_TemGageState);
            // 
            // TemGageState_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.GridViewTemGageState);
            this.Controls.Add(this.HeaderGridTemGageState);
            this.Name = "TemGageState_UC";
            this.Size = new System.Drawing.Size(819, 505);
            this.Load += new System.EventHandler(this.TemGageState_UC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewTemGageState)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWTemGageStateBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MSSHeaderGrid HeaderGridTemGageState;
        private MSSGridexView GridViewTemGageState;
        private System.Windows.Forms.BindingSource vWTemGageStateBindingSource;
    }
}
