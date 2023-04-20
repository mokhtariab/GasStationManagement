using MSS.Library.Control;

namespace GasStationManagement.View.MainForms.Counter
{
    partial class Counter_UC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Counter_UC));
            Janus.Windows.GridEX.GridEXLayout GridViewCounter_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.tBLCounterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.con = new MSS.Library.Control.MSSGroupPanel(this.components);
            this.HeaderGridCounter = new MSS.Library.Control.MSSHeaderGrid();
            this.GridViewCounter = new MSS.Library.Control.MSSGridexView();
            ((System.ComponentModel.ISupportInitialize)(this.tBLCounterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewCounter)).BeginInit();
            this.SuspendLayout();
            // 
            // tBLCounterBindingSource
            // 
            this.tBLCounterBindingSource.DataSource = typeof(GasStationManagement.Model.Basic.DataAccess.TBL_Counter);
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
            // HeaderGridCounter
            // 
            // 
            // 
            // 
            this.HeaderGridCounter.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridCounter.BackgroundStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridCounter.BackgroundStyle.BorderBottomWidth = 1;
            this.HeaderGridCounter.BackgroundStyle.BorderLeftWidth = 1;
            this.HeaderGridCounter.BackgroundStyle.BorderRightWidth = 1;
            this.HeaderGridCounter.BackgroundStyle.BorderTopWidth = 1;
            this.HeaderGridCounter.BackgroundStyle.Class = "ItemPanel";
            this.HeaderGridCounter.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.HeaderGridCounter.BackgroundStyle.PaddingBottom = 1;
            this.HeaderGridCounter.BackgroundStyle.PaddingLeft = 1;
            this.HeaderGridCounter.BackgroundStyle.PaddingRight = 1;
            this.HeaderGridCounter.BackgroundStyle.PaddingTop = 1;
            this.HeaderGridCounter.ButtonDeleteVisible = true;
            this.HeaderGridCounter.ButtonEditVisible = true;
            this.HeaderGridCounter.ButtonExcelExportVisible = true;
            this.HeaderGridCounter.ButtonInsertVisible = true;
            this.HeaderGridCounter.ButtonPrintExpertVisible = false;
            this.HeaderGridCounter.ButtonPrintVisible = true;
            this.HeaderGridCounter.ButtonRefreshVisible = true;
            this.HeaderGridCounter.ButtonSearchExpertVisible = false;
            this.HeaderGridCounter.ButtonSearchVisible = true;
            this.HeaderGridCounter.ButtonSelectorVisible = true;
            this.HeaderGridCounter.ContainerControlProcessDialogKey = true;
            this.HeaderGridCounter.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderGridCounter.FitButtonsToContainerWidth = true;
            this.HeaderGridCounter.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.HeaderGridCounter.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.HeaderGridCounter.Location = new System.Drawing.Point(0, 0);
            this.HeaderGridCounter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HeaderGridCounter.Name = "HeaderGridCounter";
            this.HeaderGridCounter.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HeaderGridCounter.Size = new System.Drawing.Size(819, 61);
            this.HeaderGridCounter.TabIndex = 31;
            this.HeaderGridCounter.Text = "mssHeaderGrid1";
            this.HeaderGridCounter.ThemeAware = true;
            this.HeaderGridCounter.buttonItemInsertClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemInsertClickEventHandler(this.headerGridCounter_btnInsertClick);
            this.HeaderGridCounter.buttonItemEditClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemEditClickEventHandler(this.headerGridCounter_btnEditClick);
            this.HeaderGridCounter.buttonItemDeleteClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemDeleteClickEventHandler(this.headerGridCounter_btnDeleteClick);
            this.HeaderGridCounter.buttonItemRefreshClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemRefreshClickEventHandler(this.headerGridCounter_btnRefreshClick);
            // 
            // GridViewCounter
            // 
            this.GridViewCounter.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.GridViewCounter.AlternatingRowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewCounter.BuiltInTextsData = resources.GetString("GridViewCounter.BuiltInTextsData");
            this.GridViewCounter.CardViewGridlines = Janus.Windows.GridEX.CardViewGridlines.Both;
            this.GridViewCounter.DataSource = this.tBLCounterBindingSource;
            this.GridViewCounter.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            GridViewCounter_DesignTimeLayout.LayoutString = resources.GetString("GridViewCounter_DesignTimeLayout.LayoutString");
            this.GridViewCounter.DesignTimeLayout = GridViewCounter_DesignTimeLayout;
            this.GridViewCounter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewCounter.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.GridViewCounter.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.GridViewCounter.Font = new System.Drawing.Font("Tahoma", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.GridViewCounter.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewCounter.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
            this.GridViewCounter.Location = new System.Drawing.Point(0, 61);
            this.GridViewCounter.Name = "GridViewCounter";
            this.GridViewCounter.RecordNavigator = true;
            this.GridViewCounter.RowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewCounter.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition;
            this.GridViewCounter.RowHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewCounter.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.GridViewCounter.Size = new System.Drawing.Size(819, 418);
            this.GridViewCounter.TabIndex = 32;
            this.GridViewCounter.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.GridViewCounter.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010;
            this.GridViewCounter.SelectionChanged += new System.EventHandler(this.GridViewCounter_SelectionChanged);
            // 
            // Counter_UC
            // 
            this.ClientSize = new System.Drawing.Size(819, 505);
            this.Controls.Add(this.GridViewCounter);
            this.Controls.Add(this.HeaderGridCounter);
            this.Controls.Add(this.con);
            this.Name = "Counter_UC";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "نوع وضعیت ظاهری";
            this.Load += new System.EventHandler(this.Counter_UC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tBLCounterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewCounter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MSSGroupPanel con;
        private System.Windows.Forms.BindingSource tBLCounterBindingSource;
        private MSSHeaderGrid HeaderGridCounter;
        private MSSGridexView GridViewCounter;
    }
}
