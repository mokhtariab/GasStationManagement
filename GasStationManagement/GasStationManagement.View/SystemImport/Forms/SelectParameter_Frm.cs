using System.Linq;
using System.Collections.Generic;
using GasStationManagement.Model.Basic.DataAccess;
using System.IO;
using System.Xml.Serialization;
using System.Windows.Forms;
using System;

namespace GasStationManagement.View.SystemImport
{
    public partial class SelectParameter_Frm : MSS.Library.Forms.MSSBaseNew_frm
    {
        public SelectParameter_Frm()
        {
            InitializeComponent();
        }
        public void BindData()
        {
            string str = "";
            ReadFromXmlFiles("Parameter");
            
            CreateCheckBoxSelectorParameter();

            ReadListParameter();
        }

        Dictionary<string, string> DicStr = new Dictionary<string, string>();
        private void GasStation_UC_Load(object sender, System.EventArgs e)
        {

            DicStr.Add("GasStationCode", "StationCode");
            DicStr.Add("GasStationName", "StationName");
            //DicStr.Add("time_Stamp", "time");
            //DicStr.Add("strTimeStampShamsi", "Date");
            DicStr.Add("bInvalid", "Validation");
            DicStr.Add("fTotalQb", "Total Qb");
            DicStr.Add("fTotalQm", "Total Qm");
            DicStr.Add("fInGasT", "Tin");
            DicStr.Add("fOutGasT", "Tout");
            DicStr.Add("fInGasP", "Pin");
            DicStr.Add("fOutGasP", "Pout");
            DicStr.Add("fAirT", "Tair");
            DicStr.Add("EK1_nVb", "Vb1");
            DicStr.Add("EK1_nVbD", "VbD1");
            DicStr.Add("EK1_nVm", "Vm1");
            DicStr.Add("EK1_nVmD", "VmD1");
            DicStr.Add("EK1_fP_Psi", "P1");
            DicStr.Add("EK1_fT", "T1");
            DicStr.Add("EK1_fC", "C1");
            DicStr.Add("EK1_fQm", "Qm1");
            DicStr.Add("EK1_fQb", "Qb1");

            DicStr.Add("EK2_nVb", "Vb2");
            DicStr.Add("EK2_nVbD", "VbD2");
            DicStr.Add("EK2_nVm", "Vm2");
            DicStr.Add("EK2_nVmD", "VmD2");
            DicStr.Add("EK2_fP_Psi", "P2");
            DicStr.Add("EK2_fT", "T2");
            DicStr.Add("EK2_fC", "C2");
            DicStr.Add("EK2_fQm", "Qm2");
            DicStr.Add("EK2_fQb", "Qb2");

            DicStr.Add("EK3_nVb", "Vb3");
            DicStr.Add("EK3_nVbD", "VbD3");
            DicStr.Add("EK3_nVm", "Vm3");
            DicStr.Add("EK3_nVmD", "VmD3");
            DicStr.Add("EK3_fP_Psi", "P3");
            DicStr.Add("EK3_fT", "T3");
            DicStr.Add("EK3_fC", "C3");
            DicStr.Add("EK3_fQm", "Qm3");
            DicStr.Add("EK3_fQb", "Qb3");

            DicStr.Add("fInT_Ht1", "Htr1 Tin");
            DicStr.Add("fOutT_Ht1", "Htr1 Tout");
            DicStr.Add("fWaterT_Ht1", "Htr1 Water T");

            DicStr.Add("fInT_Ht2", "Htr2 Tin");
            DicStr.Add("fOutT_Ht2", "Htr2 Tout");
            DicStr.Add("fWaterT_Ht2", "Htr2 Water T");

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


        private void ButtonSelectParameter_Click(object sender, EventArgs e)
        {
            foreach (DevComponents.DotNetBar.CheckBoxItem item in itemPanelSelectorParameter.Items)
                item.Checked = ButtonSelectParameter.Checked;
        }


        private void CreateCheckBoxSelectorParameter()
        {
            string str = ""; int i = 0;
            itemPanelSelectorParameter.Items.Clear();

            foreach (var item in DicStr)
            {
                //if (item.Tag != null) continue;

                DevComponents.DotNetBar.CheckBoxItem checkBoxItem = new DevComponents.DotNetBar.CheckBoxItem();
                checkBoxItem.Name = item.Key;
                checkBoxItem.Text = item.Value;
                checkBoxItem.Checked = true;

                itemPanelSelectorParameter.Items.Add(checkBoxItem);
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
                ColumnSelect = ListColumnSelectorsParameter.Find(b => b.SelectorsColumn == item.Text && b.NameColumn == item.Name);
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

        private void buttonItemOK_Click(object sender, EventArgs e)
        {
            WriteSaveParameter("Parameter", true);
            Close();
        }
        
    }
}