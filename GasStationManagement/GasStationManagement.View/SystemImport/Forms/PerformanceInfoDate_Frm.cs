using System.Linq;
using System.Collections.Generic;
using GasStationManagement.Model.GasStation;
using GasStationManagement.View.SystemImport;
using MSS.Library.Clasess.FilterClass;
using System.Xml.Serialization;
using System.IO;
using System.Windows.Forms;
using System;

namespace GasStationManagement.View.SystemImport
{
    public partial class PerformanceInfoDate_Frm : MSS.Library.Forms.MSSBaseNew_frm
    {
        public PerformanceInfoDate_Frm()
        {
            InitializeComponent();
        }


        public void ReadFromXmlFilesParameter()
        {
            foreach (Janus.Windows.GridEX.GridEXColumn item in GridViewPerformanceInfoDate.RootTable.Columns)
            {
                if (GridViewPerformanceInfoDate.CurrentTable.Columns[item.Key].Tag == null)
                    GridViewPerformanceInfoDate.CurrentTable.Columns[item.Key].Visible = false;
            }

            if (File.Exists(Application.StartupPath + "\\SetParamStation\\Parameter.xml"))
            {
                using (var reader = new StreamReader(Application.StartupPath + "\\SetParamStation\\Parameter.xml"))
                {
                    XmlSerializer deserializer = new XmlSerializer(typeof(List<GasStationManagement.View.SystemImport.SelectParameter_Frm.ParamStationClass>),
                        new XmlRootAttribute("Param_Station"));
                    foreach (var item in (List<GasStationManagement.View.SystemImport.SelectParameter_Frm.ParamStationClass>)deserializer.Deserialize(reader))
                    {
                        try
                        {
                            GridViewPerformanceInfoDate.CurrentTable.Columns[item.NameColumn].Visible = true;
                            GridViewPerformanceInfoDate.CurrentTable.Columns[item.NameColumn].Caption = item.SelectorsColumn;
                        }
                        catch { }
                    }
                }
            }

        }

        public void ReadFromXmlFilesStation()
        {
            string str = "";
            if (File.Exists(Application.StartupPath + "\\SetParamStation\\Station.xml"))
            {
                using (var reader = new StreamReader(Application.StartupPath + "\\SetParamStation\\Station.xml"))
                {
                    XmlSerializer deserializer = new XmlSerializer(typeof(List<GasStationManagement.View.SystemImport.SelectParameter_Frm.ParamStationClass>),
                        new XmlRootAttribute("Param_Station"));

                    List<Model.Table_TSample.Table_TSample> ls = new List<Model.Table_TSample.Table_TSample>();
                    foreach (var item in (List<GasStationManagement.View.SystemImport.SelectParameter_Frm.ParamStationClass>)deserializer.Deserialize(reader))
                    {
                        ls.Add(new Model.Table_TSample.Table_TSample() { GasStationCode = item.NameColumn, GasStationName = item.SelectorsColumn });
                    }
                   
                    new ViewModel.Table_TSample.Table_TSample().InsertEntity(ls,
                        ref str);
                }
            }

        }

        public void SetColumn_InsertData()
        {
            ReadFromXmlFilesParameter();
            ReadFromXmlFilesStation();
        }

        private void PerformanceInfoDate_Frm_Load(object sender, EventArgs e)
        {
            string str = "";
            new ViewModel.Table_TSample.Table_TSample().ClearEntity(ref str);
            SetColumn_InsertData();
            BindData();

            ComboBoxYear.Text = KagNetComponents2.KagPersianDate.Parse(DateTime.Now).ShamsiYear.ToString();
            ComboBoxMonth.SelectedIndex = KagNetComponents2.KagPersianDate.Parse(DateTime.Now).ShamsiMonth;
            ComboBoxDay.Text = KagNetComponents2.KagPersianDate.Parse(DateTime.Now).ShamsiDay.ToString();
            
        }

        public void BindData()
        {
            string str = "";
            GridViewPerformanceInfoDate.DataSource = new ViewModel.Table_TSample.Table_TSample().GetList(ref str);
        }

        private void buttonItemOK_Click(object sender, EventArgs e)
        {
            if ((ComboBoxTime.SelectedItem ?? "").ToString() == "")
            {
                MSS.Library.Clasess.MSSMessage.MSSMessage_View("زمان را وارد نمایید", MSS.Library.Clasess.MSSMessage.MessageType.SError);
                return;
            }


            if (!MSS.Library.Clasess.MSSMessage.MSSMessage_View(0, MSS.Library.Clasess.MSSMessage.MessageType.SConfirmation, true, "آیا مایلید ثبت شود؟")) return;
            
            //foreach (Janus.Windows.GridEX.GridEXColumn item in GridViewPerformanceInfoDate.RootTable.Columns)
            //{
            //    if (GridViewPerformanceInfoDate.CurrentTable.Columns[item.Key].Tag == null)
            //        GridViewPerformanceInfoDate.CurrentTable.Columns[item.Key].Visible = false;
            //}

            string str = "";
           // List<Model.Table_TSample.Table_TSample> ls = new List<Model.Table_TSample.Table_TSample>();

            Model.Table_TSample.Table_TSample tS = null;
            for (int i = 0; i < GridViewPerformanceInfoDate.RowCount; i++)
            {
                GridViewPerformanceInfoDate.Row = i;
                tS = new Model.Table_TSample.Table_TSample()
                {
                    GasStationCode = GridViewPerformanceInfoDate.CurrentRow.Cells["GasStationCode"].Value.ToString(),
                    GasStationName = GridViewPerformanceInfoDate.CurrentRow.Cells["GasStationName"].Value.ToString(),
                    time_Stamp = MSS.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladiWithTime("", ComboBoxYear.SelectedItem.ToString(), ComboBoxMonth.SelectedIndex.ToString(), ComboBoxDay.SelectedItem.ToString(), ComboBoxTime.SelectedItem.ToString().ToInt(), 0, 0),
                    strTimeStampShamsi = ComboBoxYear.SelectedItem.ToString() + "/" + ComboBoxMonth.SelectedIndex.ToString() + "/" + ComboBoxDay.SelectedItem.ToString() + " " + ComboBoxTime.SelectedItem.ToString() + ":00:00",
                    
                    bInvalid = Convert.ToBoolean(GridViewPerformanceInfoDate.CurrentRow.Cells["bInvalid"].Value),
                    fTotalQb= Convert.ToInt32(GridViewPerformanceInfoDate.CurrentRow.Cells["fTotalQb"].Value),
                    fTotalQm= Convert.ToInt32(GridViewPerformanceInfoDate.CurrentRow.Cells["fTotalQm"].Value),
                    fInGasT= Convert.ToInt32(GridViewPerformanceInfoDate.CurrentRow.Cells["fInGasT"].Value),
                    fOutGasT = Convert.ToInt32(GridViewPerformanceInfoDate.CurrentRow.Cells["fOutGasT"].Value),
                    fInGasP = Convert.ToInt32(GridViewPerformanceInfoDate.CurrentRow.Cells["fInGasP"].Value),
                    fOutGasP = Convert.ToInt32(GridViewPerformanceInfoDate.CurrentRow.Cells["fOutGasP"].Value),
                    fAirT = Convert.ToInt32(GridViewPerformanceInfoDate.CurrentRow.Cells["fAirT"].Value),
            
                    
                    EK1_fC = Convert.ToInt32(GridViewPerformanceInfoDate.CurrentRow.Cells["EK1_fC"].Value),
                    EK1_fP_Psi = Convert.ToInt32(GridViewPerformanceInfoDate.CurrentRow.Cells["EK1_fP_Psi"].Value),
                    EK1_fPbX = Convert.ToInt32(GridViewPerformanceInfoDate.CurrentRow.Cells["EK1_fPbX"].Value),
                    EK1_fQb = Convert.ToInt32(GridViewPerformanceInfoDate.CurrentRow.Cells["EK1_fQb"].Value),
                    EK1_fQm = Convert.ToInt32(GridViewPerformanceInfoDate.CurrentRow.Cells["EK1_fQm"].Value),
                    EK1_fT = Convert.ToInt32(GridViewPerformanceInfoDate.CurrentRow.Cells["EK1_fT"].Value),
                    EK1_fTbX = Convert.ToInt32(GridViewPerformanceInfoDate.CurrentRow.Cells["EK1_fTbX"].Value),
                    EK1_nBatRemain = Convert.ToInt32(GridViewPerformanceInfoDate.CurrentRow.Cells["EK1_nBatRemain"].Value),
                    EK1_nVb = Convert.ToInt32(GridViewPerformanceInfoDate.CurrentRow.Cells["EK1_nVb"].Value),
                    EK1_nVbD = Convert.ToInt32(GridViewPerformanceInfoDate.CurrentRow.Cells["EK1_nVbD"].Value),
                    EK1_nVm = Convert.ToInt32(GridViewPerformanceInfoDate.CurrentRow.Cells["EK1_nVm"].Value),
                    EK1_nVmD = Convert.ToInt32(GridViewPerformanceInfoDate.CurrentRow.Cells["EK1_nVmD"].Value),

                    EK2_fC = Convert.ToInt32(GridViewPerformanceInfoDate.CurrentRow.Cells["EK2_fC"].Value),
                    EK2_fP_Psi = Convert.ToInt32(GridViewPerformanceInfoDate.CurrentRow.Cells["EK2_fP_Psi"].Value),
                    EK2_fPbX = Convert.ToInt32(GridViewPerformanceInfoDate.CurrentRow.Cells["EK2_fPbX"].Value),
                    EK2_fQb = Convert.ToInt32(GridViewPerformanceInfoDate.CurrentRow.Cells["EK2_fQb"].Value),
                    EK2_fQm = Convert.ToInt32(GridViewPerformanceInfoDate.CurrentRow.Cells["EK2_fQm"].Value),
                    EK2_fT = Convert.ToInt32(GridViewPerformanceInfoDate.CurrentRow.Cells["EK2_fT"].Value),
                    EK2_fTbX = Convert.ToInt32(GridViewPerformanceInfoDate.CurrentRow.Cells["EK2_fTbX"].Value),
                    EK2_nBatRemain = Convert.ToInt32(GridViewPerformanceInfoDate.CurrentRow.Cells["EK2_nBatRemain"].Value),
                    EK2_nVb = Convert.ToInt32(GridViewPerformanceInfoDate.CurrentRow.Cells["EK2_nVb"].Value),
                    EK2_nVbD = Convert.ToInt32(GridViewPerformanceInfoDate.CurrentRow.Cells["EK2_nVbD"].Value),
                    EK2_nVm = Convert.ToInt32(GridViewPerformanceInfoDate.CurrentRow.Cells["EK2_nVm"].Value),
                    EK2_nVmD = Convert.ToInt32(GridViewPerformanceInfoDate.CurrentRow.Cells["EK2_nVmD"].Value),

                    EK3_fC = Convert.ToInt32(GridViewPerformanceInfoDate.CurrentRow.Cells["EK3_fC"].Value),
                    EK3_fP_Psi = Convert.ToInt32(GridViewPerformanceInfoDate.CurrentRow.Cells["EK3_fP_Psi"].Value),
                    EK3_fPbX = Convert.ToInt32(GridViewPerformanceInfoDate.CurrentRow.Cells["EK3_fPbX"].Value),
                    EK3_fQb = Convert.ToInt32(GridViewPerformanceInfoDate.CurrentRow.Cells["EK3_fQb"].Value),
                    EK3_fQm = Convert.ToInt32(GridViewPerformanceInfoDate.CurrentRow.Cells["EK3_fQm"].Value),
                    EK3_fT = Convert.ToInt32(GridViewPerformanceInfoDate.CurrentRow.Cells["EK3_fT"].Value),
                    EK3_fTbX = Convert.ToInt32(GridViewPerformanceInfoDate.CurrentRow.Cells["EK3_fTbX"].Value),
                    EK3_nBatRemain = Convert.ToInt32(GridViewPerformanceInfoDate.CurrentRow.Cells["EK3_nBatRemain"].Value),
                    EK3_nVb = Convert.ToInt32(GridViewPerformanceInfoDate.CurrentRow.Cells["EK3_nVb"].Value),
                    EK3_nVbD = Convert.ToInt32(GridViewPerformanceInfoDate.CurrentRow.Cells["EK3_nVbD"].Value),
                    EK3_nVm = Convert.ToInt32(GridViewPerformanceInfoDate.CurrentRow.Cells["EK3_nVm"].Value),
                    EK3_nVmD = Convert.ToInt32(GridViewPerformanceInfoDate.CurrentRow.Cells["EK3_nVmD"].Value),

                    fInT_Ht1 = Convert.ToInt32(GridViewPerformanceInfoDate.CurrentRow.Cells["fInT_Ht1"].Value),
                    fOutT_Ht1 = Convert.ToInt32(GridViewPerformanceInfoDate.CurrentRow.Cells["fOutT_Ht1"].Value),
                    fWaterT_Ht1 = Convert.ToInt32(GridViewPerformanceInfoDate.CurrentRow.Cells["fWaterT_Ht1"].Value),
                    fInT_Ht2 = Convert.ToInt32(GridViewPerformanceInfoDate.CurrentRow.Cells["fInT_Ht2"].Value),
                    fOutT_Ht2 = Convert.ToInt32(GridViewPerformanceInfoDate.CurrentRow.Cells["fOutT_Ht2"].Value),
                    fWaterT_Ht2 = Convert.ToInt32(GridViewPerformanceInfoDate.CurrentRow.Cells["fWaterT_Ht2"].Value),


                };
                //ls.Add(tS);
                new ViewModel.Table_TSample.Table_TSample().InsertUpdateTable_T(tS, ref str);
            }

            Close();

        }


    }
}
