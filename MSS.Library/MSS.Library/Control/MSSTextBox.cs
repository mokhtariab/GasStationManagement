using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace MSS.Library.Control
{
    public partial class MSSTextBox : DevComponents.DotNetBar.Controls.TextBoxX
    {
        public MSSTextBox()
        {
            InitializeComponent();
        }

        public MSSTextBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
