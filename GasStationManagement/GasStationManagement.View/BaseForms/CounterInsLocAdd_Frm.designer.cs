﻿using MSS.Library.Control;

namespace GasStationManagement.View.BaseForms
{
    partial class CounterInsLocAdd_Frm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBoxCounterInsLocDsc = new MSS.Library.Control.MSSTextBox(this.components);
            this.label1 = new MSS.Library.Control.MSSLabel(this.components);
            this.checkBoxIsActive = new MSS.Library.Control.MSSCheckBox(this.components);
            this.mssGroupPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonBarNewBar
            // 
            // 
            // 
            // 
            this.ribbonBarNewBar.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBarNewBar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBarNewBar.Location = new System.Drawing.Point(0, 113);
            this.ribbonBarNewBar.Size = new System.Drawing.Size(401, 57);
            // 
            // 
            // 
            this.ribbonBarNewBar.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBarNewBar.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // mssGroupPanel1
            // 
            this.mssGroupPanel1.Controls.Add(this.checkBoxIsActive);
            this.mssGroupPanel1.Controls.Add(this.textBoxCounterInsLocDsc);
            this.mssGroupPanel1.Controls.Add(this.label1);
            this.mssGroupPanel1.Size = new System.Drawing.Size(401, 79);
            // 
            // 
            // 
            this.mssGroupPanel1.Style.BackColor = System.Drawing.SystemColors.Control;
            this.mssGroupPanel1.Style.BackColor2 = System.Drawing.SystemColors.Control;
            this.mssGroupPanel1.Style.BackColorGradientAngle = 90;
            this.mssGroupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.mssGroupPanel1.Style.BorderBottomWidth = 1;
            this.mssGroupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.mssGroupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.mssGroupPanel1.Style.BorderLeftWidth = 1;
            this.mssGroupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.mssGroupPanel1.Style.BorderRightWidth = 1;
            this.mssGroupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.mssGroupPanel1.Style.BorderTopWidth = 1;
            this.mssGroupPanel1.Style.CornerDiameter = 4;
            this.mssGroupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.mssGroupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.mssGroupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.mssGroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.mssGroupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.mssGroupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // buttonItemOK
            // 
            this.buttonItemOK.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // textBoxCounterInsLocDsc
            // 
            this.textBoxCounterInsLocDsc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.textBoxCounterInsLocDsc.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxCounterInsLocDsc.Font = new System.Drawing.Font("Tahoma", 8F);
            this.textBoxCounterInsLocDsc.Location = new System.Drawing.Point(25, 19);
            this.textBoxCounterInsLocDsc.Name = "textBoxCounterInsLocDsc";
            this.textBoxCounterInsLocDsc.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxCounterInsLocDsc.Size = new System.Drawing.Size(268, 13);
            this.textBoxCounterInsLocDsc.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.label1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(305, 19);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "محل نصب کنتور:";
            // 
            // checkBoxIsActive
            // 
            this.checkBoxIsActive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxIsActive.AutoSize = true;
            this.checkBoxIsActive.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.checkBoxIsActive.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkBoxIsActive.Checked = true;
            this.checkBoxIsActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxIsActive.CheckValue = "Y";
            this.checkBoxIsActive.Font = new System.Drawing.Font("Tahoma", 8F);
            this.checkBoxIsActive.Location = new System.Drawing.Point(250, 43);
            this.checkBoxIsActive.Name = "checkBoxIsActive";
            this.checkBoxIsActive.Size = new System.Drawing.Size(42, 15);
            this.checkBoxIsActive.TabIndex = 59;
            this.checkBoxIsActive.Text = "فعال";
            // 
            // CounterInsLocAdd_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(401, 170);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 280);
            this.MinimumSize = new System.Drawing.Size(300, 197);
            this.Name = "CounterInsLocAdd_Frm";
            this.Text = "محل نصب کنتور";
            this.mssGroupPanel1.ResumeLayout(false);
            this.mssGroupPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MSSTextBox textBoxCounterInsLocDsc;
        private MSSLabel label1;
        private MSSCheckBox checkBoxIsActive;


    }
}
