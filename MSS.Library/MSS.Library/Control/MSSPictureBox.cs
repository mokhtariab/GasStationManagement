using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace MSS.Library.Control
{
    public partial class MSSPictureBox : System.Windows.Forms.PictureBox
    {
        public MSSPictureBox()
        {
            InitializeComponent();
        }

        public MSSPictureBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();

            this.DoubleClick += MSSPictureBox_DoubleClick;
        }

        void MSSPictureBox_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                this.Image.Save("D:\\A.jpg");
                System.Diagnostics.Process.Start("D:\\A.jpg");
            }
            catch { }

        }
    }
}
