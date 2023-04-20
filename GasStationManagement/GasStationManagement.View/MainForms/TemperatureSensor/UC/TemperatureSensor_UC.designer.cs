using MSS.Library.Control;

namespace GasStationManagement.View.MainForms.TemperatureSensor
{
    partial class TemperatureSensor_UC
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
            Janus.Windows.GridEX.GridEXLayout GridViewTemperatureSensor_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TemperatureSensor_UC));
            this.tBLTemperatureSensorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.con = new MSS.Library.Control.MSSGroupPanel(this.components);
            this.HeaderGridTemperatureSensor = new MSS.Library.Control.MSSHeaderGrid();
            this.GridViewTemperatureSensor = new MSS.Library.Control.MSSGridexView();
            ((System.ComponentModel.ISupportInitialize)(this.tBLTemperatureSensorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewTemperatureSensor)).BeginInit();
            this.SuspendLayout();
            // 
            // tBLTemperatureSensorBindingSource
            // 
            this.tBLTemperatureSensorBindingSource.DataSource = typeof(GasStationManagement.Model.Basic.DataAccess.TBL_TemperatureSensor);
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
            // HeaderGridTemperatureSensor
            // 
            // 
            // 
            // 
            this.HeaderGridTemperatureSensor.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridTemperatureSensor.BackgroundStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.HeaderGridTemperatureSensor.BackgroundStyle.BorderBottomWidth = 1;
            this.HeaderGridTemperatureSensor.BackgroundStyle.BorderLeftWidth = 1;
            this.HeaderGridTemperatureSensor.BackgroundStyle.BorderRightWidth = 1;
            this.HeaderGridTemperatureSensor.BackgroundStyle.BorderTopWidth = 1;
            this.HeaderGridTemperatureSensor.BackgroundStyle.Class = "ItemPanel";
            this.HeaderGridTemperatureSensor.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.HeaderGridTemperatureSensor.BackgroundStyle.PaddingBottom = 1;
            this.HeaderGridTemperatureSensor.BackgroundStyle.PaddingLeft = 1;
            this.HeaderGridTemperatureSensor.BackgroundStyle.PaddingRight = 1;
            this.HeaderGridTemperatureSensor.BackgroundStyle.PaddingTop = 1;
            this.HeaderGridTemperatureSensor.ButtonDeleteVisible = true;
            this.HeaderGridTemperatureSensor.ButtonEditVisible = true;
            this.HeaderGridTemperatureSensor.ButtonExcelExportVisible = true;
            this.HeaderGridTemperatureSensor.ButtonInsertVisible = true;
            this.HeaderGridTemperatureSensor.ButtonPrintExpertVisible = false;
            this.HeaderGridTemperatureSensor.ButtonPrintVisible = true;
            this.HeaderGridTemperatureSensor.ButtonRefreshVisible = true;
            this.HeaderGridTemperatureSensor.ButtonSearchExpertVisible = false;
            this.HeaderGridTemperatureSensor.ButtonSearchVisible = true;
            this.HeaderGridTemperatureSensor.ButtonSelectorVisible = true;
            this.HeaderGridTemperatureSensor.ContainerControlProcessDialogKey = true;
            this.HeaderGridTemperatureSensor.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderGridTemperatureSensor.FitButtonsToContainerWidth = true;
            this.HeaderGridTemperatureSensor.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.HeaderGridTemperatureSensor.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.HeaderGridTemperatureSensor.Location = new System.Drawing.Point(0, 0);
            this.HeaderGridTemperatureSensor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HeaderGridTemperatureSensor.Name = "HeaderGridTemperatureSensor";
            this.HeaderGridTemperatureSensor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HeaderGridTemperatureSensor.Size = new System.Drawing.Size(819, 61);
            this.HeaderGridTemperatureSensor.TabIndex = 31;
            this.HeaderGridTemperatureSensor.Text = "mssHeaderGrid1";
            this.HeaderGridTemperatureSensor.ThemeAware = true;
            this.HeaderGridTemperatureSensor.buttonItemInsertClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemInsertClickEventHandler(this.headerGridTemperatureSensor_btnInsertClick);
            this.HeaderGridTemperatureSensor.buttonItemEditClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemEditClickEventHandler(this.headerGridTemperatureSensor_btnEditClick);
            this.HeaderGridTemperatureSensor.buttonItemDeleteClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemDeleteClickEventHandler(this.headerGridTemperatureSensor_btnDeleteClick);
            this.HeaderGridTemperatureSensor.buttonItemRefreshClick += new MSS.Library.Control.MSSHeaderGrid.buttonItemRefreshClickEventHandler(this.headerGridTemperatureSensor_btnRefreshClick);
            // 
            // GridViewTemperatureSensor
            // 
            this.GridViewTemperatureSensor.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.GridViewTemperatureSensor.AlternatingRowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewTemperatureSensor.CardViewGridlines = Janus.Windows.GridEX.CardViewGridlines.Both;
            this.GridViewTemperatureSensor.DataSource = this.tBLTemperatureSensorBindingSource;
            this.GridViewTemperatureSensor.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            GridViewTemperatureSensor_DesignTimeLayout.LayoutString = resources.GetString("GridViewTemperatureSensor_DesignTimeLayout.LayoutString");
            this.GridViewTemperatureSensor.DesignTimeLayout = GridViewTemperatureSensor_DesignTimeLayout;
            this.GridViewTemperatureSensor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewTemperatureSensor.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.GridViewTemperatureSensor.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.GridViewTemperatureSensor.Font = new System.Drawing.Font("Tahoma", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.GridViewTemperatureSensor.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewTemperatureSensor.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
            this.GridViewTemperatureSensor.Location = new System.Drawing.Point(0, 61);
            this.GridViewTemperatureSensor.Name = "GridViewTemperatureSensor";
            this.GridViewTemperatureSensor.RecordNavigator = true;
            this.GridViewTemperatureSensor.RowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewTemperatureSensor.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition;
            this.GridViewTemperatureSensor.RowHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GridViewTemperatureSensor.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.GridViewTemperatureSensor.Size = new System.Drawing.Size(819, 418);
            this.GridViewTemperatureSensor.TabIndex = 32;
            this.GridViewTemperatureSensor.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.GridViewTemperatureSensor.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010;
            this.GridViewTemperatureSensor.SelectionChanged += new System.EventHandler(this.GridViewTemperatureSensor_SelectionChanged);
            // 
            // TemperatureSensor_UC
            // 
            this.Controls.Add(this.GridViewTemperatureSensor);
            this.Controls.Add(this.HeaderGridTemperatureSensor);
            this.Controls.Add(this.con);
            this.Name = "TemperatureSensor_UC";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(819, 505);
            this.Load += new System.EventHandler(this.TemperatureSensor_UC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tBLTemperatureSensorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewTemperatureSensor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MSSGroupPanel con;
        private System.Windows.Forms.BindingSource tBLTemperatureSensorBindingSource;
        private MSSHeaderGrid HeaderGridTemperatureSensor;
        private MSSGridexView GridViewTemperatureSensor;
    }
}
