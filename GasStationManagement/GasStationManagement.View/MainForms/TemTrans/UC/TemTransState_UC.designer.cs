using MSS.Library.Control;

namespace GasStationManagement.View.MainForms.TemTrans
{
    partial class TemTransState_UC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TemTransState_UC));
            Janus.Windows.GridEX.GridEXLayout GridViewTemTransState_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.HeaderGridTemTransState = new MSS.Library.Control.MSSHeaderGrid();
            this.GridViewTemTransState = new MSS.Library.Control.MSSGridexView();
            this.vWTemTransStateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewTemTransState)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWTemTransStateBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // HeaderGridTemTransState
            // 
            // 
            // 
            // 
            this.HeaderGridTemTransState.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridTemTransState.BackgroundStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridTemTransState.BackgroundStyle.BorderBottomWidth = 1;
            this.HeaderGridTemTransState.BackgroundStyle.BorderLeftWidth = 1;
            this.HeaderGridTemTransState.BackgroundStyle.BorderRightWidth = 1;
            this.HeaderGridTemTransState.BackgroundStyle.BorderTopWidth = 1;
            this.HeaderGridTemTransState.BackgroundStyle.Class = "ItemPanel";
            this.HeaderGridTemTransState.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.HeaderGridTemTransState.BackgroundStyle.PaddingBottom = 1;
            this.HeaderGridTemTransState.BackgroundStyle.PaddingLeft = 1;
            this.HeaderGridTemTransState.BackgroundStyle.PaddingRight = 1;
            this.HeaderGridTemTransState.BackgroundStyle.PaddingTop = 1;
            this.HeaderGridTemTransState.ButtonDeletePermissionCode = 0;
            this.HeaderGridTemTransState.ButtonDeleteVisible = true;
            this.HeaderGridTemTransState.ButtonEditPermissionCode = 0;
            this.HeaderGridTemTransState.ButtonEditVisible = true;
            this.HeaderGridTemTransState.ButtonExcelExportVisible = true;
            this.HeaderGridTemTransState.ButtonExcelPermissionCode = 0;
            this.HeaderGridTemTransState.ButtonInsertPermissionCode = 0;
            this.HeaderGridTemTransState.ButtonInsertVisible = true;
            this.HeaderGridTemTransState.ButtonPrintExpertPermissionCode = 0;
            this.HeaderGridTemTransState.ButtonPrintExpertVisible = false;
            this.HeaderGridTemTransState.ButtonPrintPermissionCode = 0;
            this.HeaderGridTemTransState.ButtonPrintVisible = true;
            this.HeaderGridTemTransState.ButtonRefreshVisible = true;
            this.HeaderGridTemTransState.ButtonSearchExpertVisible = false;
            this.HeaderGridTemTransState.ButtonSearchVisible = true;
            this.HeaderGridTemTransState.ButtonSelectorVisible = true;
            this.HeaderGridTemTransState.ContainerControlProcessDialogKey = true;
            this.HeaderGridTemTransState.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderGridTemTransState.FitButtonsToContainerWidth = true;
            this.HeaderGridTemTransState.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.HeaderGridTemTransState.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.HeaderGridTemTransState.GridViewSet = this.GridViewTemTransState;
            this.HeaderGridTemTransState.Location = new System.Drawing.Point(0, 0);
            this.HeaderGridTemTransState.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HeaderGridTemTransState.Name = "HeaderGridTemTransState";
            this.HeaderGridTemTransState.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HeaderGridTemTransState.Size = new System.Drawing.Size(819, 40);
            this.HeaderGridTemTransState.TabIndex = 31;
            this.HeaderGridTemTransState.Text = "mssHeaderGrid1";
            this.HeaderGridTemTransState.ThemeAware = true;
            this.HeaderGridTemTransState.buttonItemInsertClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemInsertClickEventHandler(this.headerGridTemTransState_btnInsertClick);
            this.HeaderGridTemTransState.buttonItemEditClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemEditClickEventHandler(this.headerGridTemTransState_btnEditClick);
            this.HeaderGridTemTransState.buttonItemDeleteClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemDeleteClickEventHandler(this.headerGridTemTransState_btnDeleteClick);
            this.HeaderGridTemTransState.buttonItemRefreshClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemRefreshClickEventHandler(this.headerGridTemTransState_btnRefreshClick);
            // 
            // GridViewTemTransState
            // 
            this.GridViewTemTransState.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.GridViewTemTransState.AlternatingRowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewTemTransState.BuiltInTextsData = resources.GetString("GridViewTemTransState.BuiltInTextsData");
            this.GridViewTemTransState.CardViewGridlines = Janus.Windows.GridEX.CardViewGridlines.Both;
            this.GridViewTemTransState.DataSource = this.vWTemTransStateBindingSource;
            this.GridViewTemTransState.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            GridViewTemTransState_DesignTimeLayout.LayoutString = resources.GetString("GridViewTemTransState_DesignTimeLayout.LayoutString");
            this.GridViewTemTransState.DesignTimeLayout = GridViewTemTransState_DesignTimeLayout;
            this.GridViewTemTransState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewTemTransState.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.GridViewTemTransState.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.GridViewTemTransState.Font = new System.Drawing.Font("Tahoma", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.GridViewTemTransState.GroupByBoxVisible = false;
            this.GridViewTemTransState.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewTemTransState.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
            this.GridViewTemTransState.Location = new System.Drawing.Point(0, 40);
            this.GridViewTemTransState.Name = "GridViewTemTransState";
            this.GridViewTemTransState.RecordNavigator = true;
            this.GridViewTemTransState.RowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewTemTransState.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition;
            this.GridViewTemTransState.RowHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewTemTransState.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.GridViewTemTransState.Size = new System.Drawing.Size(819, 465);
            this.GridViewTemTransState.TabIndex = 32;
            this.GridViewTemTransState.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.GridViewTemTransState.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010;
            this.GridViewTemTransState.BindingDataSourceSet += new System.EventHandler(this.GridViewTemTransState_BindingDataSourceSet);
            this.GridViewTemTransState.SelectionChanged += new System.EventHandler(this.GridViewTemTransState_SelectionChanged);
            // 
            // vWTemTransStateBindingSource
            // 
            this.vWTemTransStateBindingSource.DataSource = typeof(GasStationManagement.Model.TemTransState.VW_TemTransState);
            // 
            // TemTransState_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.GridViewTemTransState);
            this.Controls.Add(this.HeaderGridTemTransState);
            this.Name = "TemTransState_UC";
            this.Size = new System.Drawing.Size(819, 505);
            this.Load += new System.EventHandler(this.TemTransState_UC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewTemTransState)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWTemTransStateBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MSSHeaderGrid HeaderGridTemTransState;
        private MSSGridexView GridViewTemTransState;
        private System.Windows.Forms.BindingSource vWTemTransStateBindingSource;
    }
}
