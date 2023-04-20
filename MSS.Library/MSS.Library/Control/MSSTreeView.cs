using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace MSS.Library.Control
{
    public partial class MSSTreeView : System.Windows.Forms.TreeView
    {
        public MSSTreeView()
        {
            InitializeComponent();

            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            RightToLeftLayout = true;
        }

        public MSSTreeView(IContainer container)
        {
            container.Add(this);

            InitializeComponent();

        }
    }
}
