using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace MSS.Library.Control
{
    public partial class MSSCheckBox : DevComponents.DotNetBar.Controls.CheckBoxX
    {
        public MSSCheckBox()
        {
            InitializeComponent();
        }

        public MSSCheckBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
