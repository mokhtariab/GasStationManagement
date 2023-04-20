using System.Linq;
using System.Collections.Generic;
using GasStationManagement.Model.Basic.DataAccess;
using System.IO;
using System.Xml.Serialization;
using System.Windows.Forms;
using System;

namespace GasStationManagement.View.SystemImport
{
    public partial class PerformanceInformation_UC : System.Windows.Forms.UserControl
    {
        public PerformanceInformation_UC()
        {
            InitializeComponent();
        }
        public void BindData()
        {
            string str = "";
            ReadFromXmlFiles("Parameter");
            ReadFromXmlFiles("Station");
            
            CreateCheckBoxSelectorParameter();
            CreateCheckBoxSelectorStation();

            ReadListParameter();
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
                    if (NameSelect == "Parameter")
                        ListColumnSelectorsParameter = (List<ParamStationClass>)deserializer.Deserialize(reader);
                    else 
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
                if (NameSelect == "Parameter")
                    ser.Serialize(writer, ListColumnSelectorsParameter);
                else
                    ser.Serialize(writer, ListColumnSelectorsStation);
            }
        }


        List<ParamStationClass> ListColumnSelectorsParameter = new List<ParamStationClass>();
        public void WriteSaveParameter(string ColumnSelectorName, bool UpdateOrDel)
        {
            ListColumnSelectorsParameter.Clear();// RemoveAll(k => k.SelectorsColumn == ColumnSelectorName);
            if (UpdateOrDel)
            {
                foreach (DevComponents.DotNetBar.CheckBoxItem item in itemPanelSelectorParameter.Items)
                {
                    if (item.Checked)
                        ListColumnSelectorsParameter.Add(new ParamStationClass { SelectorsColumn = item.Text, NameColumn = item.Name });
                }
            }
            WriteToXmlFiles("Parameter");
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

        private void ButtonSelectParameter_Click(object sender, EventArgs e)
        {
            foreach (DevComponents.DotNetBar.CheckBoxItem item in itemPanelSelectorParameter.Items)
                item.Checked = ButtonSelectParameter.Checked;

        }

        private void CreateCheckBoxSelectorParameter()
        {
            string str = ""; int i = 0;
            itemPanelSelectorParameter.Items.Clear();

            foreach (string item in new ViewModel.Table_TSample.Table_TSample().GetFieldList().ToList())
            {
                //if (item.Tag != null) continue;

                DevComponents.DotNetBar.CheckBoxItem checkBoxItem = new DevComponents.DotNetBar.CheckBoxItem();
                checkBoxItem.Name = item;
                checkBoxItem.Text = item;
                checkBoxItem.Checked = true;

                itemPanelSelectorParameter.Items.Add(checkBoxItem);
            }
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


        private void ReadListParameter()
        {
            foreach (DevComponents.DotNetBar.CheckBoxItem item in itemPanelSelectorParameter.Items)
                item.Checked = false;

            ParamStationClass ColumnSelect = new ParamStationClass();
            foreach (DevComponents.DotNetBar.CheckBoxItem item in itemPanelSelectorParameter.Items)
            {
                ColumnSelect = null;
                ColumnSelect = ListColumnSelectorsParameter.Find(b => b.SelectorsColumn == item.Name && b.NameColumn == item.Name);
                if (ColumnSelect != null)
                {
                    try
                    {
                        (itemPanelSelectorParameter.Items[item.Name] as DevComponents.DotNetBar.CheckBoxItem).Checked = true;
                    }
                    catch { }
                }
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

        private void ButtonPerInfoStation_Click(object sender, EventArgs e)
        {
            WriteSaveParameter("Parameter", true);
            WriteSaveStation("Station", true);

            PerformanceInfoDate_Frm p = new PerformanceInfoDate_Frm();
            p.ShowDialog();
        }

        private void ButtonPerInfoDate_Click(object sender, EventArgs e)
        {
            WriteSaveParameter("Parameter", true);
            WriteSaveStation("Station", true);

            PerformanceInfoStation_Frm p = new PerformanceInfoStation_Frm();
            p.ShowDialog();
        }
    }
}