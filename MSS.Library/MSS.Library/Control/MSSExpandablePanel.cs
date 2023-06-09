﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace MSS.Library.Control
{
    public partial class MSSExpandablePanel : DevComponents.DotNetBar.ExpandablePanel
    {
        public MSSExpandablePanel()
        {
            InitializeComponent();

            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            ForeColor = System.Drawing.Color.Black;
        }

        public MSSExpandablePanel(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
