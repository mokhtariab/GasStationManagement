﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace MSS.Library.Control
{
    public partial class MSSMonthPicker : KagNetComponents2.KagPersianMonthCalendar
    {
        public MSSMonthPicker()
        {
            InitializeComponent();


            BackColor = System.Drawing.Color.White;
            Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            UseFarsiDigits = true;
            ShowToday = true;

            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
        }

        public MSSMonthPicker(IContainer container)
        {
            container.Add(this);

            InitializeComponent();

            BackColor = System.Drawing.Color.White;
            Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            ShowToday = true;
            UseFarsiDigits = true;

            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
        }
    }
}
