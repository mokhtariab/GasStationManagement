using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace MSS.Library.Control
{
    public partial class MSSPanel : DevComponents.DotNetBar.PanelEx
    {
        public MSSPanel()
        {
            InitializeComponent();
        }

        public MSSPanel(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

    }
}
