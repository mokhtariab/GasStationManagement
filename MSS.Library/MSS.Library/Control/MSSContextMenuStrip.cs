using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace MSS.Library.Control
{
    public partial class MSSContextMenuStrip : System.Windows.Forms.ContextMenuStrip
    {
        public MSSContextMenuStrip()
        {
            InitializeComponent();
        }

        public MSSContextMenuStrip(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
