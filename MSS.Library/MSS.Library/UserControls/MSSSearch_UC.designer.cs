namespace MSS.Library.UserControls
{
    partial class MSSSearch_UC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MSSSearch_UC));
            this.ComboBoxIf = new MSS.Library.Control.MSSComboBox();
            this.Equals = new DevComponents.Editors.ComboItem();
            this.GreaterThan = new DevComponents.Editors.ComboItem();
            this.LessThan = new DevComponents.Editors.ComboItem();
            this.GreaterThanOrEqual = new DevComponents.Editors.ComboItem();
            this.LessThanOrEqual = new DevComponents.Editors.ComboItem();
            this.Contains = new DevComponents.Editors.ComboItem();
            this.StartsWith = new DevComponents.Editors.ComboItem();
            this.EndsWith = new DevComponents.Editors.ComboItem();
            this.ComboBoxFieldList = new MSS.Library.Control.MSSComboBox();
            this.TextBoxStrSearch = new MSS.Library.Control.MSSTextBox(this.components);
            this.label1 = new MSS.Library.Control.MSSLabel(this.components);
            this.label2 = new MSS.Library.Control.MSSLabel(this.components);
            this.comboBoxAndOr = new MSS.Library.Control.MSSComboBox();
            this.comboItemAnd = new DevComponents.Editors.ComboItem();
            this.comboItemOr = new DevComponents.Editors.ComboItem();
            this.buttonDelete = new MSS.Library.Control.MSSButton(this.components);
            this.SuspendLayout();
            // 
            // ComboBoxIf
            // 
            this.ComboBoxIf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxIf.DisplayMember = "Text";
            this.ComboBoxIf.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxIf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxIf.FormattingEnabled = true;
            this.ComboBoxIf.ItemHeight = 16;
            this.ComboBoxIf.Items.AddRange(new object[] {
            this.Equals,
            this.GreaterThan,
            this.LessThan,
            this.GreaterThanOrEqual,
            this.LessThanOrEqual,
            this.Contains,
            this.StartsWith,
            this.EndsWith});
            this.ComboBoxIf.Location = new System.Drawing.Point(300, 7);
            this.ComboBoxIf.Name = "ComboBoxIf";
            this.ComboBoxIf.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ComboBoxIf.Size = new System.Drawing.Size(128, 22);
            this.ComboBoxIf.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ComboBoxIf.TabIndex = 75;
            // 
            // Equals
            // 
            this.Equals.Text = "مساوی";
            this.Equals.TextAlignment = System.Drawing.StringAlignment.Center;
            this.Equals.TextLineAlignment = System.Drawing.StringAlignment.Center;
            // 
            // GreaterThan
            // 
            this.GreaterThan.Text = "بزرگتر از";
            this.GreaterThan.TextAlignment = System.Drawing.StringAlignment.Center;
            this.GreaterThan.TextLineAlignment = System.Drawing.StringAlignment.Center;
            // 
            // LessThan
            // 
            this.LessThan.Text = "کوچکتر از";
            this.LessThan.TextAlignment = System.Drawing.StringAlignment.Center;
            this.LessThan.TextLineAlignment = System.Drawing.StringAlignment.Center;
            // 
            // GreaterThanOrEqual
            // 
            this.GreaterThanOrEqual.Text = "بزرگتر یا مساوی";
            this.GreaterThanOrEqual.TextAlignment = System.Drawing.StringAlignment.Center;
            this.GreaterThanOrEqual.TextLineAlignment = System.Drawing.StringAlignment.Center;
            // 
            // LessThanOrEqual
            // 
            this.LessThanOrEqual.Text = "کوچکتر یا مساوی";
            this.LessThanOrEqual.TextAlignment = System.Drawing.StringAlignment.Center;
            this.LessThanOrEqual.TextLineAlignment = System.Drawing.StringAlignment.Center;
            // 
            // Contains
            // 
            this.Contains.Text = "شامل";
            this.Contains.TextAlignment = System.Drawing.StringAlignment.Center;
            this.Contains.TextLineAlignment = System.Drawing.StringAlignment.Center;
            // 
            // StartsWith
            // 
            this.StartsWith.Text = "ابتدا شامل";
            this.StartsWith.TextAlignment = System.Drawing.StringAlignment.Center;
            this.StartsWith.TextLineAlignment = System.Drawing.StringAlignment.Center;
            // 
            // EndsWith
            // 
            this.EndsWith.Text = "انتها شامل";
            this.EndsWith.TextAlignment = System.Drawing.StringAlignment.Center;
            this.EndsWith.TextLineAlignment = System.Drawing.StringAlignment.Center;
            // 
            // ComboBoxFieldList
            // 
            this.ComboBoxFieldList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxFieldList.DisplayMember = "Text";
            this.ComboBoxFieldList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxFieldList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxFieldList.FormattingEnabled = true;
            this.ComboBoxFieldList.ItemHeight = 16;
            this.ComboBoxFieldList.Location = new System.Drawing.Point(445, 7);
            this.ComboBoxFieldList.Name = "ComboBoxFieldList";
            this.ComboBoxFieldList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ComboBoxFieldList.Size = new System.Drawing.Size(152, 22);
            this.ComboBoxFieldList.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ComboBoxFieldList.TabIndex = 74;
            // 
            // TextBoxStrSearch
            // 
            this.TextBoxStrSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.TextBoxStrSearch.Border.Class = "TextBoxBorder";
            this.TextBoxStrSearch.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxStrSearch.Location = new System.Drawing.Point(63, 6);
            this.TextBoxStrSearch.Name = "TextBoxStrSearch";
            this.TextBoxStrSearch.Size = new System.Drawing.Size(185, 24);
            this.TextBoxStrSearch.TabIndex = 73;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            // 
            // 
            // 
            this.label1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(256, 9);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 72;
            this.label1.Text = "عبارت:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            // 
            // 
            // 
            this.label2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(596, 10);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 68;
            this.label2.Text = "انتخاب فیلد:";
            // 
            // comboBoxAndOr
            // 
            this.comboBoxAndOr.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxAndOr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAndOr.DropDownWidth = 47;
            this.comboBoxAndOr.FormattingEnabled = true;
            this.comboBoxAndOr.ItemHeight = 16;
            this.comboBoxAndOr.Items.AddRange(new object[] {
            this.comboItemAnd,
            this.comboItemOr});
            this.comboBoxAndOr.Location = new System.Drawing.Point(7, 8);
            this.comboBoxAndOr.Name = "comboBoxAndOr";
            this.comboBoxAndOr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBoxAndOr.Size = new System.Drawing.Size(47, 22);
            this.comboBoxAndOr.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxAndOr.TabIndex = 71;
            // 
            // comboItemAnd
            // 
            this.comboItemAnd.Text = "و";
            this.comboItemAnd.TextAlignment = System.Drawing.StringAlignment.Center;
            this.comboItemAnd.TextLineAlignment = System.Drawing.StringAlignment.Center;
            // 
            // comboItemOr
            // 
            this.comboItemOr.Text = "یا";
            this.comboItemOr.TextAlignment = System.Drawing.StringAlignment.Center;
            this.comboItemOr.TextLineAlignment = System.Drawing.StringAlignment.Center;
            // 
            // buttonDelete
            // 
            this.buttonDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.buttonDelete.Image = ((System.Drawing.Image)(resources.GetObject("buttonDelete.Image")));
            this.buttonDelete.Location = new System.Drawing.Point(675, 4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonDelete.Size = new System.Drawing.Size(32, 29);
            this.buttonDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonDelete.TabIndex = 65;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // MSSSearch_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.ComboBoxIf);
            this.Controls.Add(this.ComboBoxFieldList);
            this.Controls.Add(this.TextBoxStrSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxAndOr);
            this.Controls.Add(this.buttonDelete);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MSSSearch_UC";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(711, 37);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Control.MSSButton buttonDelete;
        private Control.MSSLabel label2;
        private Control.MSSComboBox comboBoxAndOr;
        private DevComponents.Editors.ComboItem comboItemAnd;
        private DevComponents.Editors.ComboItem comboItemOr;
        private Control.MSSLabel label1;
        private Control.MSSTextBox TextBoxStrSearch;
        private Control.MSSComboBox ComboBoxFieldList;
        private Control.MSSComboBox ComboBoxIf;
        private DevComponents.Editors.ComboItem Equals;
        private DevComponents.Editors.ComboItem GreaterThan;
        private DevComponents.Editors.ComboItem LessThan;
        private DevComponents.Editors.ComboItem GreaterThanOrEqual;
        private DevComponents.Editors.ComboItem LessThanOrEqual;
        private DevComponents.Editors.ComboItem Contains;
        private DevComponents.Editors.ComboItem StartsWith;
        private DevComponents.Editors.ComboItem EndsWith;
    }
}
