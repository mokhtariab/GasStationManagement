using System.Linq;
using System.Collections.Generic;
using GasStationManagement.Model.Basic.DataAccess;
using System.IO;
using System.Xml.Serialization;
using System.Windows.Forms;
using System;

namespace GasStationManagement.View.SystemImport
{
    public partial class SelectStation_Frm : MSS.Library.Forms.MSSBaseNew_frm
    {
        public SelectStation_Frm()
        {
            InitializeComponent();
        }
        public void BindData()
        {
            string str = "";
            ReadFromXmlFiles("Station");
            
            CreateCheckBoxSelectorStation();

            ReadListStation();
        }

        private void GasStation_UC_Load(object sender, System.EventArgs e)
        {
            BindData();
        }



        public class ParamStationClass
        {
            [XmlElement("ParamStations")]
            public String SelectorsColumn { get; set; }

            [XmlElement("namecolumn")]
            public String NameColumn { get; set; }

        }

        public void ReadFromXmlFiles(string NameSelect)
        {
            if (File.Exists(Application.StartupPath + "\\SetParamStation\\" +NameSelect + ".xml"))
            {
                using (var reader = new StreamReader(Application.StartupPath + "\\SetParamStation\\" + NameSelect + ".xml"))
                {
                    XmlSerializer deserializer = new XmlSerializer(typeof(List<ParamStationClass>),
                        new XmlRootAttribute("Param_Station"));
                    ListColumnSelectorsStation = (List<ParamStationClass>)deserializer.Deserialize(reader);
                }
            }

        }

        public void WriteToXmlFiles(string NameSelect)
        {
            if (!Directory.Exists(Application.StartupPath + "\\SetParamStation"))
                Directory.CreateDirectory(Application.StartupPath + "\\SetParamStation");

            using (var writer = new FileStream(Application.StartupPath + "\\SetParamStation\\" + NameSelect + ".xml", FileMode.Create))
            {
                XmlSerializer ser = new XmlSerializer(typeof(List<ParamStationClass>),
                    new XmlRootAttribute("Param_Station"));
                ser.Serialize(writer, ListColumnSelectorsStation);
            }
        }


        List<ParamStationClass> ListColumnSelectorsStation = new List<ParamStationClass>();
        public void WriteSaveStation(string ColumnSelectorName, bool UpdateOrDel)
        {
            ListColumnSelectorsStation.Clear();// RemoveAll(k => k.SelectorsColumn == ColumnSelectorName);
            if (UpdateOrDel)
            {
                foreach (DevComponents.DotNetBar.CheckBoxItem item in itemPanelSelectorStation.Items)
                {
                    if (item.Checked)
                        ListColumnSelectorsStation.Add(new ParamStationClass { SelectorsColumn = item.Text, NameColumn = item.Name});
                }

            }
            WriteToXmlFiles("Station");
        }

        private void ButtonSelectStation_Click(object sender, EventArgs e)
        {
            foreach (DevComponents.DotNetBar.CheckBoxItem item in itemPanelSelectorStation.Items)
                item.Checked = ButtonSelectStation.Checked;
        }

        private void CreateCheckBoxSelectorStation()
        {
            string str = "";
            itemPanelSelectorStation.Items.Clear();

            foreach (var item in new ViewModel.GasStationClass.GasStationClass().GetList(ref str))
            {
                //if (item.Tag != null) continue;

                DevComponents.DotNetBar.CheckBoxItem checkBoxItem = new DevComponents.DotNetBar.CheckBoxItem();
                checkBoxItem.Name = item.GasStationCode;
                checkBoxItem.Text = item.GasStationName;
                checkBoxItem.Checked = true;
                //checkBoxItem.CheckedChanged += checkBoxItem_CheckedChanged;
                itemPanelSelectorStation.Items.Add(checkBoxItem);
            }
        }


        private void ReadListStation()
        {
            foreach (DevComponents.DotNetBar.CheckBoxItem item in itemPanelSelectorStation.Items)
                item.Checked = false;

            ParamStationClass ColumnSelect = new ParamStationClass();
            foreach (DevComponents.DotNetBar.CheckBoxItem item in itemPanelSelectorStation.Items)
            {
                ColumnSelect = null;
                ColumnSelect = ListColumnSelectorsStation.Find(b => b.SelectorsColumn == item.Text && b.NameColumn == item.Name);
                if (ColumnSelect != null)
                {
                    try
                    {
                        (itemPanelSelectorStation.Items[item.Name] as DevComponents.DotNetBar.CheckBoxItem).Checked = true;
                    }
                    catch { }
                }
            }
        }

        private void buttonItemOK_Click(object sender, EventArgs e)
        {
            WriteSaveStation("Station", true);
            Close();
        }
    }
}