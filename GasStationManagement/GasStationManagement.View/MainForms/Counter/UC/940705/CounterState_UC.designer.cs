using MSS.Library.Control;

namespace GasStationManagement.View.MainForms.Counter
{
    partial class CounterState_UC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CounterState_UC));
            Janus.Windows.GridEX.GridEXLayout GridViewCounterState_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.con = new MSS.Library.Control.MSSGroupPanel(this.components);
            this.HeaderGridCounterState = new MSS.Library.Control.MSSHeaderGrid();
            this.GridViewCounterState = new MSS.Library.Control.MSSGridexView();
            this.vWCounterStateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewCounterState)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWCounterStateBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // con
            // 
            this.con.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.con.Font = new System.Drawing.Font("Tahoma", 8F);
            this.con.Location = new System.Drawing.Point(0, 479);
            this.con.Name = "con";
            this.con.Size = new System.Drawing.Size(819, 26);
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
            // HeaderGridCounterState
            // 
            // 
            // 
            // 
            this.HeaderGridCounterState.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridCounterState.BackgroundStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridCounterState.BackgroundStyle.BorderBottomWidth = 1;
            this.HeaderGridCounterState.BackgroundStyle.BorderLeftWidth = 1;
            this.HeaderGridCounterState.BackgroundStyle.BorderRightWidth = 1;
            this.HeaderGridCounterState.BackgroundStyle.BorderTopWidth = 1;
            this.HeaderGridCounterState.BackgroundStyle.Class = "ItemPanel";
            this.HeaderGridCounterState.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.HeaderGridCounterState.BackgroundStyle.PaddingBottom = 1;
            this.HeaderGridCounterState.BackgroundStyle.PaddingLeft = 1;
            this.HeaderGridCounterState.BackgroundStyle.PaddingRight = 1;
            this.HeaderGridCounterState.BackgroundStyle.PaddingTop = 1;
            this.HeaderGridCounterState.ButtonDeleteVisible = true;
            this.HeaderGridCounterState.ButtonEditVisible = true;
            this.HeaderGridCounterState.ButtonExcelExportVisible = true;
            this.HeaderGridCounterState.ButtonInsertVisible = true;
            this.HeaderGridCounterState.ButtonPrintExpertVisible = false;
            this.HeaderGridCounterState.ButtonPrintVisible = true;
            this.HeaderGridCounterState.ButtonRefreshVisible = true;
            this.HeaderGridCounterState.ButtonSearchExpertVisible = false;
            this.HeaderGridCounterState.ButtonSearchVisible = true;
            this.HeaderGridCounterState.ButtonSelectorVisible = true;
            this.HeaderGridCounterState.ContainerControlProcessDialogKey = true;
            this.HeaderGridCounterState.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderGridCounterState.FitButtonsToContainerWidth = true;
            this.HeaderGridCounterState.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.HeaderGridCounterState.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.HeaderGridCounterState.GridViewSet = this.GridViewCounterState;
            this.HeaderGridCounterState.Location = new System.Drawing.Point(0, 0);
            this.HeaderGridCounterState.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HeaderGridCounterState.Name = "HeaderGridCounterState";
            this.HeaderGridCounterState.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HeaderGridCounterState.Size = new System.Drawing.Size(819, 61);
            this.HeaderGridCounterState.TabIndex = 31;
            this.HeaderGridCounterState.Text = "mssHeaderGrid1";
            this.HeaderGridCounterState.ThemeAware = true;
            this.HeaderGridCounterState.buttonItemInsertClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemInsertClickEventHandler(this.headerGridCounter_btnInsertClick);
            this.HeaderGridCounterState.buttonItemEditClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemEditClickEventHandler(this.headerGridCounter_btnEditClick);
            this.HeaderGridCounterState.buttonItemDeleteClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemDeleteClickEventHandler(this.headerGridCounter_btnDeleteClick);
            this.HeaderGridCounterState.buttonItemRefreshClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemRefreshClickEventHandler(this.headerGridCounter_btnRefreshClick);
            // 
            // GridViewCounterState
            // 
            this.GridViewCounterState.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.GridViewCounterState.AlternatingColors = true;
            this.GridViewCounterState.AlternatingRowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewCounterState.BuiltInTextsData = resources.GetString("GridViewCounterState.BuiltInTextsData");
            this.GridViewCounterState.CardViewGridlines = Janus.Windows.GridEX.CardViewGridlines.Both;
            this.GridViewCounterState.DataSource = this.vWCounterStateBindingSource;
            this.GridViewCounterState.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            GridViewCounterState_DesignTimeLayout.LayoutString = resources.GetString("GridViewCounterState_DesignTimeLayout.LayoutString");
            this.GridViewCounterState.DesignTimeLayout = GridViewCounterState_DesignTimeLayout;
            this.GridViewCounterState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewCounterState.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.GridViewCounterState.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.GridViewCounterState.Font = new System.Drawing.Font("Tahoma", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.GridViewCounterState.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewCounterState.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
            this.GridViewCounterState.Location = new System.Drawing.Point(0, 61);
            this.GridViewCounterState.Name = "GridViewCounterState";
            this.GridViewCounterState.RecordNavigator = true;
            this.GridViewCounterState.RowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewCounterState.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition;
            this.GridViewCounterState.RowHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewCounterState.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.GridViewCounterState.Size = new System.Drawing.Size(819, 418);
            this.GridViewCounterState.TabIndex = 32;
            this.GridViewCounterState.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.GridViewCounterState.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010;
            this.GridViewCounterState.SelectionChanged += new System.EventHandler(this.GridViewCounter_SelectionChanged);
            // 
            // vWCounterStateBindingSource
            // 
            this.vWCounterStateBindingSource.DataSource = typeof(GasStationManagement.Model.CounterState.VW_CounterState);
            // 
            // CounterState_UC
            // 
            this.Controls.Add(this.GridViewCounterState);
            this.Controls.Add(this.HeaderGridCounterState);
            this.Controls.Add(this.con);
            this.Name = "CounterState_UC";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(819, 505);
            this.Load += new System.EventHandler(this.CounterState_UC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewCounterState)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWCounterStateBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MSSGroupPanel con;
        private MSSHeaderGrid HeaderGridCounterState;
        private MSSGridexView GridViewCounterState;
        private System.Windows.Forms.BindingSource vWCounterStateBindingSource;
    }
}
