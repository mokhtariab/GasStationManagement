using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace MSS.Library.Forms
{
    public partial class MSSColumnSelector_frm : Form
    {
        public MSS.Library.Control.MSSGridexView _grid;
        [System.ComponentModel.DefaultValue(typeof(MSS.Library.Control.MSSGridexView), "(none)")]
        public MSS.Library.Control.MSSGridexView GridViewSet
        {
            get
            {
                if (_grid == null) return null;
                return _grid;
            }
            set
            {
                _grid = value;
            }
        }

        public MSSColumnSelector_frm(MSS.Library.Control.MSSGridexView GridViewEnter)
        {
            InitializeComponent();
            this.GridViewSet = GridViewEnter;
        }

        private void MSSColumnSelector_frm_Load(object sender, EventArgs e)
        {
            ReadFromXmlFiles();
            CreateCheckBoxFromGrid();
            ComboBoxSelectorBind();
        }

        private void CreateCheckBoxFromGrid()
        {
            itemPanelSelector.Items.Clear();

            foreach (Janus.Windows.GridEX.GridEXColumn item in _grid.RootTable.Columns)
            {
                if (item.Tag != null) continue;

                DevComponents.DotNetBar.CheckBoxItem checkBoxItem = new DevComponents.DotNetBar.CheckBoxItem();
                checkBoxItem.Name = item.Key;
                checkBoxItem.Text = item.Caption;
                checkBoxItem.Checked = true;
                checkBoxItem.CheckedChanged += checkBoxItem_CheckedChanged;
                itemPanelSelector.Items.Add(checkBoxItem);
            }
        }

        void checkBoxItem_CheckedChanged(object sender, DevComponents.DotNetBar.CheckBoxChangeEventArgs e)
        {
            _grid.CurrentTable.Columns[(sender as DevComponents.DotNetBar.CheckBoxItem).Name].Visible = e.NewChecked.Checked;
        }

       
        public void ComboBoxSelectorBind()
        {
            comboBoxSelector.DataSource = ListColumnSelectors.Select(o => o.SelectorsColumn).Distinct().ToList();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            WriteSave(comboBoxSelector.Text, true);
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            WriteSave(comboBoxSelector.Text, false);
        }
        private void comboBoxSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReadList(comboBoxSelector.Text);
        }

        private void ReadList(string ColumnSelectorName)
        {
            foreach (DevComponents.DotNetBar.CheckBoxItem item in itemPanelSelector.Items)
                item.Checked = false;

            ColumnSelectorsClass ColumnSelect = new ColumnSelectorsClass();
            foreach (Janus.Windows.GridEX.GridEXColumn item in _grid.RootTable.Columns)
            {
                ColumnSelect = null;
                ColumnSelect = ListColumnSelectors.Find(b => b.SelectorsColumn == ColumnSelectorName && b.NameColumn == item.Key);
                if (ColumnSelect != null)
                {
                    try
                    {
                        (itemPanelSelector.Items[item.Key] as DevComponents.DotNetBar.CheckBoxItem).Checked = true;
                        item.Width = ColumnSelect.WidthColumn;
                    }
                    catch { }
                }
            }
        }


        #region Read&Write ConfigFile & Settings


        public class ColumnSelectorsClass
        {
            [XmlElement("columnselectors")]
            public String SelectorsColumn { get; set; }

            [XmlElement("namecolumn")]
            public String NameColumn { get; set; }

            [XmlElement("widthcolumn")]
            public Int32 WidthColumn { get; set; }

        }

        List<ColumnSelectorsClass> ListColumnSelectors = new List<ColumnSelectorsClass>();
        public void WriteSave(string ColumnSelectorName, bool UpdateOrDel)
        {
            ListColumnSelectors.RemoveAll(k => k.SelectorsColumn == ColumnSelectorName);
            if (UpdateOrDel)
            {
                foreach (Janus.Windows.GridEX.GridEXColumn item in _grid.CurrentTable.Columns)
                {
                    if (item.Visible)
                        ListColumnSelectors.Add(new ColumnSelectorsClass { SelectorsColumn = ColumnSelectorName, NameColumn = item.Key, WidthColumn = item.Width });
                }

            }
            WriteToXmlFiles();
            ComboBoxSelectorBind();
        }

        
        public void ReadFromXmlFiles()
        {
            if (File.Exists(Application.StartupPath + "\\ColumnSelector\\" + _grid.Name +(_grid.Tag??0).ToString() + ".xml"))
            {
                using (var reader = new StreamReader(Application.StartupPath + "\\ColumnSelector\\" + _grid.Name + (_grid.Tag ?? 0).ToString() + ".xml"))
                {
                    XmlSerializer deserializer = new XmlSerializer(typeof(List<ColumnSelectorsClass>),
                        new XmlRootAttribute("Column_Selector"));
                    ListColumnSelectors = (List<ColumnSelectorsClass>)deserializer.Deserialize(reader);
                }
            }

        }

        public void WriteToXmlFiles()
        {
            if (!Directory.Exists(Application.StartupPath + "\\ColumnSelector")) 
                Directory.CreateDirectory(Application.StartupPath + "\\ColumnSelector");

            using (var writer = new FileStream(Application.StartupPath + "\\ColumnSelector\\" + _grid.Name + (_grid.Tag ?? 0).ToString() + ".xml", FileMode.Create))
            {
                XmlSerializer ser = new XmlSerializer(typeof(List<ColumnSelectorsClass>),
                    new XmlRootAttribute("Column_Selector"));
                ser.Serialize(writer, ListColumnSelectors);
            }
        }




        #endregion

        private void ButtonSelect_CheckedChanged(object sender, EventArgs e)
        {
            foreach (DevComponents.DotNetBar.CheckBoxItem item in itemPanelSelector.Items)
                item.Checked = ButtonSelect.Checked;
        }

    }
}
