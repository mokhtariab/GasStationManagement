using System;

namespace MSS.Library.Forms
{
	public partial class MSSPrintPreview_frm : System.Windows.Forms.Form
	{


		//Form overrides dispose to clean up the component list.
		internal MSSPrintPreview_frm()
		{
			InitializeComponent();
		}
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}

		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;

		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.  
		//Do not modify it using the code editor.
		internal System.Windows.Forms.PrintPreviewControl PrintPreviewControl1;
		internal System.Windows.Forms.PageSetupDialog PageSetupDialog1;
        internal System.Windows.Forms.ImageList imlSmall;
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MSSPrintPreview_frm));
            this.imlSmall = new System.Windows.Forms.ImageList(this.components);
            this.PrintPreviewControl1 = new System.Windows.Forms.PrintPreviewControl();
            this.PageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.ribbon1 = new Janus.Windows.Ribbon.Ribbon();
            this.imlLarge = new System.Windows.Forms.ImageList(this.components);
            this.rtabPrintPreview = new Janus.Windows.Ribbon.RibbonTab();
            this.r = new Janus.Windows.Ribbon.RibbonGroup();
            this.rcmdPrint = new Janus.Windows.Ribbon.ButtonCommand();
            this.rcmdPageSetup = new Janus.Windows.Ribbon.ButtonCommand();
            this.rbngView = new Janus.Windows.Ribbon.RibbonGroup();
            this.rcmdActualSize = new Janus.Windows.Ribbon.ButtonCommand();
            this.rcmdOnePage = new Janus.Windows.Ribbon.ButtonCommand();
            this.rcmdTwoPages = new Janus.Windows.Ribbon.ButtonCommand();
            this.rbngPreview = new Janus.Windows.Ribbon.RibbonGroup();
            this.rcmdNextPage = new Janus.Windows.Ribbon.ButtonCommand();
            this.rcmdPreviousPage = new Janus.Windows.Ribbon.ButtonCommand();
            this.separatorCommand1 = new Janus.Windows.Ribbon.SeparatorCommand();
            this.rcmdClose = new Janus.Windows.Ribbon.ButtonCommand();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon1)).BeginInit();
            this.SuspendLayout();
            // 
            // imlSmall
            // 
            this.imlSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlSmall.ImageStream")));
            this.imlSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.imlSmall.Images.SetKeyName(0, "NextPage.ico");
            this.imlSmall.Images.SetKeyName(1, "PreviousPage.ico");
            // 
            // PrintPreviewControl1
            // 
            this.PrintPreviewControl1.AutoZoom = false;
            this.PrintPreviewControl1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PrintPreviewControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PrintPreviewControl1.Location = new System.Drawing.Point(0, 146);
            this.PrintPreviewControl1.Name = "PrintPreviewControl1";
            this.PrintPreviewControl1.Size = new System.Drawing.Size(708, 276);
            this.PrintPreviewControl1.TabIndex = 1;
            this.PrintPreviewControl1.UseAntiAlias = true;
            this.PrintPreviewControl1.Zoom = 1D;
            this.PrintPreviewControl1.StartPageChanged += new System.EventHandler(this.PrintPreviewControl1_StartPageChanged);
            // 
            // ribbon1
            // 
            this.ribbon1.BackstageMenuData = "<?xml version=\"1.0\" encoding=\"utf-8\"?><BackstageMenu><ImageKey /><Key /><Text>Fil" +
    "e</Text></BackstageMenu>";
            // 
            // 
            // 
            this.ribbon1.HelpButton.Key = "HelpButton";
            this.ribbon1.ImageList = this.imlSmall;
            this.ribbon1.LargeImageList = this.imlLarge;
            this.ribbon1.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.Name = "ribbon1";
            this.ribbon1.ShowCustomizeButton = false;
            this.ribbon1.Size = new System.Drawing.Size(708, 146);
            // 
            // 
            // 
            this.ribbon1.SuperTipComponent.AutoPopDelay = 2000;
            this.ribbon1.SuperTipComponent.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbon1.SuperTipComponent.ImageList = this.imlSmall;
            this.ribbon1.TabIndex = 2;
            this.ribbon1.Tabs.AddRange(new Janus.Windows.Ribbon.RibbonTab[] {
            this.rtabPrintPreview});
            this.ribbon1.Text = "";
            this.ribbon1.CommandClick += new Janus.Windows.Ribbon.CommandEventHandler(this.ribbon1_CommandClick);
            // 
            // imlLarge
            // 
            this.imlLarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlLarge.ImageStream")));
            this.imlLarge.TransparentColor = System.Drawing.Color.Transparent;
            this.imlLarge.Images.SetKeyName(0, "Printing.ico");
            this.imlLarge.Images.SetKeyName(1, "Page Setup.ico");
            this.imlLarge.Images.SetKeyName(2, "Actual Size.ico");
            this.imlLarge.Images.SetKeyName(3, "One Page.ico");
            this.imlLarge.Images.SetKeyName(4, "Two Pages.ico");
            this.imlLarge.Images.SetKeyName(5, "Close.ico");
            // 
            // rtabPrintPreview
            // 
            this.rtabPrintPreview.Groups.AddRange(new Janus.Windows.Ribbon.RibbonGroup[] {
            this.r,
            this.rbngView,
            this.rbngPreview});
            this.rtabPrintPreview.Key = "rtabPrintPreview";
            this.rtabPrintPreview.Name = "rtabPrintPreview";
            this.rtabPrintPreview.Text = "پیش نمایش";
            // 
            // r
            // 
            this.r.Commands.AddRange(new Janus.Windows.Ribbon.CommandBase[] {
            this.rcmdPrint,
            this.rcmdPageSetup});
            this.r.DialogButtonSuperTipSettings.ImageListProvider = this.r;
            this.r.Key = "ribbonGroup1";
            this.r.Name = "r";
            this.r.Text = "چاپ";
            // 
            // rcmdPrint
            // 
            this.rcmdPrint.Key = "rcmdPrint";
            this.rcmdPrint.LargeImageKey = "Printing.ico";
            this.rcmdPrint.Name = "rcmdPrint";
            this.rcmdPrint.Text = "چاپ";
            // 
            // rcmdPageSetup
            // 
            this.rcmdPageSetup.Key = "rcmdPageSetup";
            this.rcmdPageSetup.LargeImageKey = "Page Setup.ico";
            this.rcmdPageSetup.Name = "rcmdPageSetup";
            this.rcmdPageSetup.Text = "تنظیمات صفحه";
            // 
            // rbngView
            // 
            this.rbngView.Commands.AddRange(new Janus.Windows.Ribbon.CommandBase[] {
            this.rcmdActualSize,
            this.rcmdOnePage,
            this.rcmdTwoPages});
            this.rbngView.DialogButtonSuperTipSettings.ImageListProvider = this.rbngView;
            this.rbngView.Key = "rbngView";
            this.rbngView.Name = "rbngView";
            this.rbngView.Text = "نمایش";
            // 
            // rcmdActualSize
            // 
            this.rcmdActualSize.Checked = true;
            this.rcmdActualSize.CheckOnClick = true;
            this.rcmdActualSize.Key = "rcmdActualSize";
            this.rcmdActualSize.LargeImageKey = "Actual Size.ico";
            this.rcmdActualSize.Name = "rcmdActualSize";
            this.rcmdActualSize.Text = "اندازه واقعی";
            // 
            // rcmdOnePage
            // 
            this.rcmdOnePage.CheckOnClick = true;
            this.rcmdOnePage.Key = "rcmdOnePage";
            this.rcmdOnePage.LargeImageKey = "One Page.ico";
            this.rcmdOnePage.Name = "rcmdOnePage";
            this.rcmdOnePage.Text = "تک صفحه";
            // 
            // rcmdTwoPages
            // 
            this.rcmdTwoPages.Checked = true;
            this.rcmdTwoPages.CheckOnClick = true;
            this.rcmdTwoPages.Key = "rcmdTwoPages";
            this.rcmdTwoPages.LargeImageKey = "Two Pages.ico";
            this.rcmdTwoPages.Name = "rcmdTwoPages";
            this.rcmdTwoPages.Text = "دو صفحه";
            // 
            // rbngPreview
            // 
            this.rbngPreview.Commands.AddRange(new Janus.Windows.Ribbon.CommandBase[] {
            this.rcmdNextPage,
            this.rcmdPreviousPage,
            this.separatorCommand1,
            this.rcmdClose});
            this.rbngPreview.DialogButtonSuperTipSettings.ImageListProvider = this.rbngPreview;
            this.rbngPreview.Key = "rbngPreview";
            this.rbngPreview.Name = "rbngPreview";
            this.rbngPreview.Text = "پیش نمایش";
            // 
            // rcmdNextPage
            // 
            this.rcmdNextPage.ImageIndex = 0;
            this.rcmdNextPage.Key = "rcmdNextPage";
            this.rcmdNextPage.Name = "rcmdNextPage";
            this.rcmdNextPage.SizeStyle = Janus.Windows.Ribbon.CommandSizeStyle.Small;
            this.rcmdNextPage.Text = "صفحه بعدی";
            // 
            // rcmdPreviousPage
            // 
            this.rcmdPreviousPage.Enabled = false;
            this.rcmdPreviousPage.ImageIndex = 1;
            this.rcmdPreviousPage.Key = "rcmdPreviousPage";
            this.rcmdPreviousPage.Name = "rcmdPreviousPage";
            this.rcmdPreviousPage.SizeStyle = Janus.Windows.Ribbon.CommandSizeStyle.Small;
            this.rcmdPreviousPage.Text = "صفحه قبلی";
            // 
            // separatorCommand1
            // 
            this.separatorCommand1.Key = "separatorCommand1";
            this.separatorCommand1.Name = "separatorCommand1";
            // 
            // rcmdClose
            // 
            this.rcmdClose.Key = "rcmdClose";
            this.rcmdClose.LargeImageKey = "Close.ico";
            this.rcmdClose.Name = "rcmdClose";
            this.rcmdClose.Text = "بستن پیش نمایش";
            // 
            // MSSPrintPreview_frm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
            this.ClientSize = new System.Drawing.Size(708, 422);
            this.Controls.Add(this.PrintPreviewControl1);
            this.Controls.Add(this.ribbon1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MSSPrintPreview_frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "صفحه پیش نمایش";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon1)).EndInit();
            this.ResumeLayout(false);

		}

        private Janus.Windows.Ribbon.Ribbon ribbon1;
        private Janus.Windows.Ribbon.RibbonTab rtabPrintPreview;
        private Janus.Windows.Ribbon.RibbonGroup r;
        private Janus.Windows.Ribbon.ButtonCommand rcmdPrint;
        private Janus.Windows.Ribbon.ButtonCommand rcmdPageSetup;
        private Janus.Windows.Ribbon.RibbonGroup rbngView;
        private Janus.Windows.Ribbon.ButtonCommand rcmdActualSize;
        private Janus.Windows.Ribbon.ButtonCommand rcmdOnePage;
        private Janus.Windows.Ribbon.ButtonCommand rcmdTwoPages;
        private Janus.Windows.Ribbon.RibbonGroup rbngPreview;
        private Janus.Windows.Ribbon.ButtonCommand rcmdNextPage;
        private Janus.Windows.Ribbon.ButtonCommand rcmdPreviousPage;
        private Janus.Windows.Ribbon.SeparatorCommand separatorCommand1;
        private Janus.Windows.Ribbon.ButtonCommand rcmdClose;
        private System.Windows.Forms.ImageList imlLarge;

	}

} //end of root namespace