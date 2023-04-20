using MSS.Library.Control;

namespace GasStationManagement.View.MainForms.Counter
{
    partial class CounterSupply_UC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CounterSupply_UC));
            Janus.Windows.GridEX.GridEXLayout GridViewCounterSupply_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.con = new MSS.Library.Control.MSSGroupPanel(this.components);
            this.HeaderGridCounterSupply = new MSS.Library.Control.MSSHeaderGrid();
            this.GridViewCounterSupply = new MSS.Library.Control.MSSGridexView();
            this.vWCounterSupplyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewCounterSupply)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWCounterSupplyBindingSource)).BeginInit();
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
            // HeaderGridCounterSupply
            // 
            // 
            // 
            // 
            this.HeaderGridCounterSupply.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridCounterSupply.BackgroundStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridCounterSupply.BackgroundStyle.BorderBottomWidth = 1;
            this.HeaderGridCounterSupply.BackgroundStyle.BorderLeftWidth = 1;
            this.HeaderGridCounterSupply.BackgroundStyle.BorderRightWidth = 1;
            this.HeaderGridCounterSupply.BackgroundStyle.BorderTopWidth = 1;
            this.HeaderGridCounterSupply.BackgroundStyle.Class = "ItemPanel";
            this.HeaderGridCounterSupply.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.HeaderGridCounterSupply.BackgroundStyle.PaddingBottom = 1;
            this.HeaderGridCounterSupply.BackgroundStyle.PaddingLeft = 1;
            this.HeaderGridCounterSupply.BackgroundStyle.PaddingRight = 1;
            this.HeaderGridCounterSupply.BackgroundStyle.PaddingTop = 1;
            this.HeaderGridCounterSupply.ButtonDeleteVisible = true;
            this.HeaderGridCounterSupply.ButtonEditVisible = true;
            this.HeaderGridCounterSupply.ButtonExcelExportVisible = true;
            this.HeaderGridCounterSupply.ButtonInsertVisible = true;
            this.HeaderGridCounterSupply.ButtonPrintExpertVisible = false;
            this.HeaderGridCounterSupply.ButtonPrintVisible = true;
            this.HeaderGridCounterSupply.ButtonRefreshVisible = true;
            this.HeaderGridCounterSupply.ButtonSearchExpertVisible = false;
            this.HeaderGridCounterSupply.ButtonSearchVisible = true;
            this.HeaderGridCounterSupply.ButtonSelectorVisible = true;
            this.HeaderGridCounterSupply.ContainerControlProcessDialogKey = true;
            this.HeaderGridCounterSupply.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderGridCounterSupply.FitButtonsToContainerWidth = true;
            this.HeaderGridCounterSupply.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.HeaderGridCounterSupply.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.HeaderGridCounterSupply.GridViewSet = this.GridViewCounterSupply;
            this.HeaderGridCounterSupply.Location = new System.Drawing.Point(0, 0);
            this.HeaderGridCounterSupply.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HeaderGridCounterSupply.Name = "HeaderGridCounterSupply";
            this.HeaderGridCounterSupply.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HeaderGridCounterSupply.Size = new System.Drawing.Size(819, 61);
            this.HeaderGridCounterSupply.TabIndex = 31;
            this.HeaderGridCounterSupply.Text = "mssHeaderGrid1";
            this.HeaderGridCounterSupply.ThemeAware = true;
            this.HeaderGridCounterSupply.buttonItemInsertClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemInsertClickEventHandler(this.headerGridCounterSupply_btnInsertClick);
            this.HeaderGridCounterSupply.buttonItemEditClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemEditClickEventHandler(this.headerGridCounterSupply_btnEditClick);
            this.HeaderGridCounterSupply.buttonItemDeleteClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemDeleteClickEventHandler(this.headerGridCounterSupply_btnDeleteClick);
            this.HeaderGridCounterSupply.buttonItemRefreshClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemRefreshClickEventHandler(this.headerGridCounterSupply_btnRefreshClick);
            // 
            // GridViewCounterSupply
            // 
            this.GridViewCounterSupply.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.GridViewCounterSupply.AlternatingColors = true;
            this.GridViewCounterSupply.AlternatingRowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewCounterSupply.BuiltInTextsData = resources.GetString("GridViewCounterSupply.BuiltInTextsData");
            this.GridViewCounterSupply.CardViewGridlines = Janus.Windows.GridEX.CardViewGridlines.Both;
            this.GridViewCounterSupply.DataSource = this.vWCounterSupplyBindingSource;
            this.GridViewCounterSupply.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            GridViewCounterSupply_DesignTimeLayout.LayoutString = resources.GetString("GridViewCounterSupply_DesignTimeLayout.LayoutString");
            this.GridViewCounterSupply.DesignTimeLayout = GridViewCounterSupply_DesignTimeLayout;
            this.GridViewCounterSupply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewCounterSupply.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.GridViewCounterSupply.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.GridViewCounterSupply.Font = new System.Drawing.Font("Tahoma", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.GridViewCounterSupply.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewCounterSupply.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
            this.GridViewCounterSupply.Location = new System.Drawing.Point(0, 61);
            this.GridViewCounterSupply.Name = "GridViewCounterSupply";
            this.GridViewCounterSupply.RecordNavigator = true;
            this.GridViewCounterSupply.RowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewCounterSupply.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition;
            this.GridViewCounterSupply.RowHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewCounterSupply.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.GridViewCounterSupply.Size = new System.Drawing.Size(819, 418);
            this.GridViewCounterSupply.TabIndex = 32;
            this.GridViewCounterSupply.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.GridViewCounterSupply.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010;
           // this.GridViewCounterSupply.SelectionChanged += new System.EventHandler(this.GridViewCounter_SelectionChanged);
            // 
            // vWCounterSupplyBindingSource
            // 
            this.vWCounterSupplyBindingSource.DataSource = typeof(GasStationManagement.Model.CounterSupply.VW_CounterSupply);
            // 
            // CounterSupply_UC
            // 
            this.Controls.Add(this.GridViewCounterSupply);
            this.Controls.Add(this.HeaderGridCounterSupply);
            this.Controls.Add(this.con);
            this.Name = "CounterSupply_UC";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(819, 505);
            this.Load += new System.EventHandler(this.CounterSupply_UC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewCounterSupply)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWCounterSupplyBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MSSGroupPanel con;
        private MSSHeaderGrid HeaderGridCounterSupply;
        private MSSGridexView GridViewCounterSupply;
        private System.Windows.Forms.BindingSource vWCounterSupplyBindingSource;
    }
}
