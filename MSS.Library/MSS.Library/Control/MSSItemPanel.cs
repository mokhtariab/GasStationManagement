using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace MSS.Library.Control
{
    public partial class MSSItemPanel : DevComponents.DotNetBar.ItemPanel
    {
        public MSSItemPanel()
        {
            InitializeComponent();

            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            ForeColor = System.Drawing.Color.Black;
        }

        public MSSItemPanel(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
