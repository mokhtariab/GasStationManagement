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
    public partial class PerformanceInfoStation_Frm : MSS.Library.Forms.MSSBaseNew_frm
    {
        public PerformanceInfoStation_Frm()
        {
            InitializeComponent();
        }


        public void ReadFromXmlFilesParameter()
        {
            foreach (Janus.Windows.GridEX.GridEXColumn item in GridViewPerformanceInfoStation.RootTable.Columns)
            {
                if (GridViewPerformanceInfoStation.CurrentTable.Columns[item.Key].Tag == null)
                    GridViewPerformanceInfoStation.CurrentTable.Columns[item.Key].Visible = false;
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
                            GridViewPerformanceInfoStation.CurrentTable.Columns[item.NameColumn].Visible = true;
                            GridViewPerformanceInfoStation.CurrentTable.Columns[item.NameColumn].Caption = item.SelectorsColumn;
                        }
                        catch { }
                    } 
                }
            }

        }

        //public void ReadFromXmlFilesStation()
        //{
        //    string str = "";
        //    if (File.Exists(Application.StartupPath + "\\SetParamStation\\Station.xml"))
        //    {
        //        using (var reader = new StreamReader(Application.StartupPath + "\\SetParamStation\\Station.xml"))
        //        {
        //            XmlSerializer deserializer = new XmlSerializer(typeof(List<GasStationManagement.View.SystemImport.PerformanceInformation_UC.ParamStationClass>),
        //                new XmlRootAttribute("Param_Station"));

        //            List<Model.Table_TSample.Table_TSample> ls = new List<Model.Table_TSample.Table_TSample>();
        //            foreach (var item in (List<GasStationManagement.View.SystemImport.PerformanceInformation_UC.ParamStationClass>)deserializer.Deserialize(reader))
        //            {
        //                ls.Add(new Model.Table_TSample.Table_TSample() { GasStationCode = item.NameColumn, GasStationName = item.SelectorsColumn });
        //            }
                   
        //            new ViewModel.Table_TSample.Table_TSample().InsertEntity(ls,
        //                ref str);
        //        }
        //    }

        //}

        public void SetColumn_InsertData()
        {
            ReadFromXmlFilesParameter();
            //ReadFromXmlFilesStation();
        }

        private void PerformanceInfoStation_Frm_Load(object sender, EventArgs e)
        {
            string str = "";
            new ViewModel.Table_TSample.Table_TSample().ClearEntity(ref str);
            SetColumn_InsertData();
            BindData();
        }

        public void BindData()
        {
            string str = "";
            GridViewPerformanceInfoStation.DataSource = new ViewModel.Table_TSample.Table_TSample().GetList(ref str);
            ComboTreeGasStation.DataSource = new ViewModel.GasStationClass.GasStationClass().GetList(ref str);
        }

        private void buttonItemOK_Click(object sender, EventArgs e)
        {
            if (!MSS.Library.Clasess.MSSMessage.MSSMessage_View(0, MSS.Library.Clasess.MSSMessage.MessageType.SConfirmation, true, "آیا مایلید ثبت شود؟")) return;
            
            string str = "";
            //List<Model.Table_TSample.Table_TSample> ls = new List<Model.Table_TSample.Table_TSample>();

            Model.Table_TSample.Table_TSample tS = null;
            for (int i = 0; i < GridViewPerformanceInfoStation.RowCount; i++)
            {
                GridViewPerformanceInfoStation.Row = i;

                try
                {
                    MSS.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladiWithTime(GridViewPerformanceInfoStation.CurrentRow.Cells["strTimeStampShamsi"].Value.ToString(), "", "", "",
                        GridViewPerformanceInfoStation.CurrentRow.Cells["Time"].Value.ToString().Substring(0, 2).ToInt(),
                        GridViewPerformanceInfoStation.CurrentRow.Cells["Time"].Value.ToString().Substring(3, 2).ToInt(), 0);
                }
                catch
                {
                    MSS.Library.Clasess.MSSMessage.MSSMessage_View("مقادیر تاریخ و یا ساعت تصحیح گردد", MSS.Library.Clasess.MSSMessage.MessageType.SError);
                    return;
                }

                tS = new Model.Table_TSample.Table_TSample()
                {
                    GasStationCode = GridViewPerformanceInfoStation.CurrentRow.Cells["GasStationCode"].Value.ToString(),
                    GasStationName = GridViewPerformanceInfoStation.CurrentRow.Cells["GasStationName"].Value.ToString(),
                    time_Stamp = 
                    MSS.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladiWithTime(GridViewPerformanceInfoStation.CurrentRow.Cells["strTimeStampShamsi"].Value.ToString(),"","","",
                    GridViewPerformanceInfoStation.CurrentRow.Cells["Time"].Value.ToString().Substring(0, 2).ToInt(),
                    GridViewPerformanceInfoStation.CurrentRow.Cells["Time"].Value.ToString().Substring(3, 2).ToInt(),
                    0),
                    strTimeStampShamsi = GridViewPerformanceInfoStation.CurrentRow.Cells["strTimeStampShamsi"].Value.ToString()+" "+
                                        GridViewPerformanceInfoStation.CurrentRow.Cells["Time"].Value.ToString(),

                    bInvalid = Convert.ToBoolean(GridViewPerformanceInfoStation.CurrentRow.Cells["bInvalid"].Value),
                    fTotalQb = Convert.ToInt32(GridViewPerformanceInfoStation.CurrentRow.Cells["fTotalQb"].Value),
                    fTotalQm = Convert.ToInt32(GridViewPerformanceInfoStation.CurrentRow.Cells["fTotalQm"].Value),
                    fInGasT = Convert.ToInt32(GridViewPerformanceInfoStation.CurrentRow.Cells["fInGasT"].Value),
                    fOutGasT = Convert.ToInt32(GridViewPerformanceInfoStation.CurrentRow.Cells["fOutGasT"].Value),
                    fInGasP = Convert.ToInt32(GridViewPerformanceInfoStation.CurrentRow.Cells["fInGasP"].Value),
                    fOutGasP = Convert.ToInt32(GridViewPerformanceInfoStation.CurrentRow.Cells["fOutGasP"].Value),
                    fAirT = Convert.ToInt32(GridViewPerformanceInfoStation.CurrentRow.Cells["fAirT"].Value),

                    EK1_fC = Convert.ToInt32(GridViewPerformanceInfoStation.CurrentRow.Cells["EK1_fC"].Value),
                    EK1_fP_Psi = Convert.ToInt32(GridViewPerformanceInfoStation.CurrentRow.Cells["EK1_fP_Psi"].Value),
                    EK1_fPbX = Convert.ToInt32(GridViewPerformanceInfoStation.CurrentRow.Cells["EK1_fPbX"].Value),
                    EK1_fQb = Convert.ToInt32(GridViewPerformanceInfoStation.CurrentRow.Cells["EK1_fQb"].Value),
                    EK1_fQm = Convert.ToInt32(GridViewPerformanceInfoStation.CurrentRow.Cells["EK1_fQm"].Value),
                    EK1_fT = Convert.ToInt32(GridViewPerformanceInfoStation.CurrentRow.Cells["EK1_fT"].Value),
                    EK1_fTbX = Convert.ToInt32(GridViewPerformanceInfoStation.CurrentRow.Cells["EK1_fTbX"].Value),
                    EK1_nBatRemain = Convert.ToInt32(GridViewPerformanceInfoStation.CurrentRow.Cells["EK1_nBatRemain"].Value),
                    EK1_nVb = Convert.ToInt32(GridViewPerformanceInfoStation.CurrentRow.Cells["EK1_nVb"].Value),
                    EK1_nVbD = Convert.ToInt32(GridViewPerformanceInfoStation.CurrentRow.Cells["EK1_nVbD"].Value),
                    EK1_nVm = Convert.ToInt32(GridViewPerformanceInfoStation.CurrentRow.Cells["EK1_nVm"].Value),
                    EK1_nVmD = Convert.ToInt32(GridViewPerformanceInfoStation.CurrentRow.Cells["EK1_nVmD"].Value),

                    EK2_fC = Convert.ToInt32(GridViewPerformanceInfoStation.CurrentRow.Cells["EK2_fC"].Value),
                    EK2_fP_Psi = Convert.ToInt32(GridViewPerformanceInfoStation.CurrentRow.Cells["EK2_fP_Psi"].Value),
                    EK2_fPbX = Convert.ToInt32(GridViewPerformanceInfoStation.CurrentRow.Cells["EK2_fPbX"].Value),
                    EK2_fQb = Convert.ToInt32(GridViewPerformanceInfoStation.CurrentRow.Cells["EK2_fQb"].Value),
                    EK2_fQm = Convert.ToInt32(GridViewPerformanceInfoStation.CurrentRow.Cells["EK2_fQm"].Value),
                    EK2_fT = Convert.ToInt32(GridViewPerformanceInfoStation.CurrentRow.Cells["EK2_fT"].Value),
                    EK2_fTbX = Convert.ToInt32(GridViewPerformanceInfoStation.CurrentRow.Cells["EK2_fTbX"].Value),
                    EK2_nBatRemain = Convert.ToInt32(GridViewPerformanceInfoStation.CurrentRow.Cells["EK2_nBatRemain"].Value),
                    EK2_nVb = Convert.ToInt32(GridViewPerformanceInfoStation.CurrentRow.Cells["EK2_nVb"].Value),
                    EK2_nVbD = Convert.ToInt32(GridViewPerformanceInfoStation.CurrentRow.Cells["EK2_nVbD"].Value),
                    EK2_nVm = Convert.ToInt32(GridViewPerformanceInfoStation.CurrentRow.Cells["EK2_nVm"].Value),
                    EK2_nVmD = Convert.ToInt32(GridViewPerformanceInfoStation.CurrentRow.Cells["EK2_nVmD"].Value),

                    EK3_fC = Convert.ToInt32(GridViewPerformanceInfoStation.CurrentRow.Cells["EK3_fC"].Value),
                    EK3_fP_Psi = Convert.ToInt32(GridViewPerformanceInfoStation.CurrentRow.Cells["EK3_fP_Psi"].Value),
                    EK3_fPbX = Convert.ToInt32(GridViewPerformanceInfoStation.CurrentRow.Cells["EK3_fPbX"].Value),
                    EK3_fQb = Convert.ToInt32(GridViewPerformanceInfoStation.CurrentRow.Cells["EK3_fQb"].Value),
                    EK3_fQm = Convert.ToInt32(GridViewPerformanceInfoStation.CurrentRow.Cells["EK3_fQm"].Value),
                    EK3_fT = Convert.ToInt32(GridViewPerformanceInfoStation.CurrentRow.Cells["EK3_fT"].Value),
                    EK3_fTbX = Convert.ToInt32(GridViewPerformanceInfoStation.CurrentRow.Cells["EK3_fTbX"].Value),
                    EK3_nBatRemain = Convert.ToInt32(GridViewPerformanceInfoStation.CurrentRow.Cells["EK3_nBatRemain"].Value),
                    EK3_nVb = Convert.ToInt32(GridViewPerformanceInfoStation.CurrentRow.Cells["EK3_nVb"].Value),
                    EK3_nVbD = Convert.ToInt32(GridViewPerformanceInfoStation.CurrentRow.Cells["EK3_nVbD"].Value),
                    EK3_nVm = Convert.ToInt32(GridViewPerformanceInfoStation.CurrentRow.Cells["EK3_nVm"].Value),
                    EK3_nVmD = Convert.ToInt32(GridViewPerformanceInfoStation.CurrentRow.Cells["EK3_nVmD"].Value),
                    
                    fInT_Ht1 = Convert.ToInt32(GridViewPerformanceInfoStation.CurrentRow.Cells["fInT_Ht1"].Value),
                    fOutT_Ht1 = Convert.ToInt32(GridViewPerformanceInfoStation.CurrentRow.Cells["fOutT_Ht1"].Value),
                    fWaterT_Ht1 = Convert.ToInt32(GridViewPerformanceInfoStation.CurrentRow.Cells["fWaterT_Ht1"].Value),
                    fInT_Ht2 = Convert.ToInt32(GridViewPerformanceInfoStation.CurrentRow.Cells["fInT_Ht2"].Value),
                    fOutT_Ht2 = Convert.ToInt32(GridViewPerformanceInfoStation.CurrentRow.Cells["fOutT_Ht2"].Value),
                    fWaterT_Ht2 = Convert.ToInt32(GridViewPerformanceInfoStation.CurrentRow.Cells["fWaterT_Ht2"].Value),

                };
                //ls.Add(tS);
                new ViewModel.Table_TSample.Table_TSample().InsertUpdateTable_T(tS, ref str);
            }


            Close();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (!UpdateTbl()) return;

            string str = "";
            List<Model.Table_TSample.Table_TSample> ls = new List<Model.Table_TSample.Table_TSample>();
            ls.Add(new Model.Table_TSample.Table_TSample()
            {
                GasStationCode = (ComboTreeGasStation.SelectedNode.DataKey as GasStationManagement.Model.GasStation.VW_GasStation).GasStationCode,
                GasStationName = (ComboTreeGasStation.SelectedNode.DataKey as GasStationManagement.Model.GasStation.VW_GasStation).GasStationName
            }
            );

            new ViewModel.Table_TSample.Table_TSample().InsertEntity(ls,
                ref str);

            GridViewPerformanceInfoStation.DataSource = new ViewModel.Table_TSample.Table_TSample().GetList(ref str);

            for (int i = 0; i < GridViewPerformanceInfoStation.RowCount; i++)
            {
                GridViewPerformanceInfoStation.Row = i;
                try
                {
                    GridViewPerformanceInfoStation.CurrentRow.Cells["Time"].Value =
                    GridViewPerformanceInfoStation.CurrentRow.Cells["time_Stamp"].Value.ToString().Substring(11, 5);
                }
                catch { }
            }

            //BindData();
        }

        private bool UpdateTbl()
        {

            string str = "";
            List<Model.Table_TSample.Table_TSample> ls = new List<Model.Table_TSample.Table_TSample>();

            Model.Table_TSample.Table_TSample tS = null;
            for (int i = 0; i < GridViewPerformanceInfoStation.RowCount; i++)
            {
                GridViewPerformanceInfoStation.Row = i;

                try
                {
                    MSS.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladiWithTime(GridViewPerformanceInfoStation.CurrentRow.Cells["strTimeStampShamsi"].Value.ToString(), "", "", "",
                        GridViewPerformanceInfoStation.CurrentRow.Cells["Time"].Value.ToString().Substring(0, 2).ToInt(),
                        GridViewPerformanceInfoStation.CurrentRow.Cells["Time"].Value.ToString().Substring(3, 2).ToInt(), 0);
                }
                catch
                {
                    MSS.Library.Clasess.MSSMessage.MSSMessage_View("مقادیر تاریخ و یا ساعت تصحیح گردد", MSS.Library.Clasess.MSSMessage.MessageType.SError);
                    return false;
                }


                tS = new Model.Table_TSample.Table_TSample()
                {
                    GasStationCode = GridViewPerformanceInfoStation.CurrentRow.Cells["GasStationCode"].Value.ToString(),
                    GasStationName = GridViewPerformanceInfoStation.CurrentRow.Cells["GasStationName"].Value.ToString(),
                    time_Stamp =
                    MSS.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladiWithTime(GridViewPerformanceInfoStation.CurrentRow.Cells["strTimeStampShamsi"].Value.ToString(), "", "", "",
                    GridViewPerformanceInfoStation.CurrentRow.Cells["Time"].Value.ToString().Substring(0, 2).ToInt(),
                    GridViewPerformanceInfoStation.CurrentRow.Cells["Time"].Value.ToString().Substring(3, 2).ToInt(),
                    0),
                    strTimeStampShamsi = GridViewPerformanceInfoStation.CurrentRow.Cells["strTimeStampShamsi"].Value.ToString(),

                    bInvalid = Convert.ToBoolean(GridViewPerformanceInfoStation.CurrentRow.Cells["bInvalid"].Value),
                    fTotalQb = Convert.ToInt32(GridViewPerformanceInfoStation.CurrentRow.Cells["fTotalQb"].Value),
                    fTotalQm = Convert.ToInt32(GridViewPerformanceInfoStation.CurrentRow.Cells["fTotalQm"].Value),
                    fInGasT = Convert.ToInt32(GridViewPerformanceInfoStation.CurrentRow.Cells["fInGasT"].Value),
                    fOutGasT = Convert.ToInt32(GridViewPerformanceInfoStation.CurrentRow.Cells["fOutGasT"].Value),
                    fInGasP = Convert.ToInt32(GridViewPerformanceInfoStation.CurrentRow.Cells["fInGasP"].Value),
                    fOutGasP = Convert.ToInt32(GridViewPerformanceInfoStation.CurrentRow.Cells["fOutGasP"].Value),
                    fAirT = Convert.ToInt32(GridViewPerformanceInfoStation.CurrentRow.Cells["fAirT"].Value),

                    EK1_fC = Convert.ToInt32(GridViewPerformanceInfoStation.CurrentRow.Cells["EK1_fC"].Value),
                    EK1_fP_Psi = Convert.ToInt32(GridViewPerformanceInfoStation.CurrentRow.Cells["EK1_fP_Psi"].Value),
                    EK1_fPbX = Convert.ToInt32(GridViewPerformanceInfoStation.CurrentRow.Cells["EK1_fPbX"].Value),
                    EK1_fQb = Convert.ToInt32(GridViewPerformanceInfoStation.CurrentRow.Cells["EK1_fQb"].Value),
                    EK1_fQm = Convert.ToInt32(GridViewPerformanceInfoStation.CurrentRow.Cells["EK1_fQm"].Value),
                    EK1_fT = Convert.ToInt32(GridViewPerformanceInfoStation.CurrentRow.Cells["EK1_fT"].Value),
                    EK1_fTbX = Convert.ToInt32(GridViewPerformanceInfoStation.CurrentRow.Cells["EK1_fTbX"].Value),
                    EK1_nBatRemain = Convert.ToInt32(GridViewPerformanceInfoStation.CurrentRow.Cells["EK1_nBatRemain"].Value),
                    EK1_nVb = Convert.ToInt32(GridViewPerformanceInfoStation.CurrentRow.Cells["EK1_nVb"].Value),
                    EK1_nVbD = Convert.ToInt32(GridViewPerformanceInfoStation.CurrentRow.Cells["EK1_nVbD"].Value),
                    EK1_nVm = Convert.ToInt32(GridViewPerformanceInfoStation.CurrentRow.Cells["EK1_nVm"].Value),
                    EK1_nVmD = Convert.ToInt32(GridViewPerformanceInfoStation.CurrentRow.Cells["EK1_nVmD"].Value),

                    EK2_fC = Convert.ToInt32(GridViewPerformanceInfoStation.CurrentRow.Cells["EK2_fC"].Value),
                    EK2_fP_Psi = Convert.ToInt32(GridViewPerformanceInfoStation.CurrentRow.Cells["EK2_fP_Psi"].Value),
                    EK2_fPbX = Convert.ToInt32(GridViewPerformanceInfoStation.CurrentRow.Cells["EK2_fPbX"].Value),
                    EK2_fQb = Convert.ToInt32(GridViewPerformanceInfoStation.CurrentRow.Cells["EK2_fQb"].Value),
                    EK2_fQm = Convert.ToInt32(GridViewPerformanceInfoStation.CurrentRow.Cells["EK2_fQm"].Value),
                    EK2_fT = Convert.ToInt32(GridViewPerformanceInfoStation.CurrentRow.Cells["EK2_fT"].Value),
                    EK2_fTbX = Convert.ToInt32(GridViewPerformanceInfoStation.CurrentRow.Cells["EK2_fTbX"].Value),
                    EK2_nBatRemain = Convert.ToInt32(GridViewPerformanceInfoStation.CurrentRow.Cells["EK2_nBatRemain"].Value),
                    EK2_nVb = Convert.ToInt32(GridViewPerformanceInfoStation.CurrentRow.Cells["EK2_nVb"].Value),
                    EK2_nVbD = Convert.ToInt32(GridViewPerformanceInfoStation.CurrentRow.Cells["EK2_nVbD"].Value),
                    EK2_nVm = Convert.ToInt32(GridViewPerformanceInfoStation.CurrentRow.Cells["EK2_nVm"].Value),
                    EK2_nVmD = Convert.ToInt32(GridViewPerformanceInfoStation.CurrentRow.Cells["EK2_nVmD"].Value),

                    EK3_fC = Convert.ToInt32(GridViewPerformanceInfoStation.CurrentRow.Cells["EK3_fC"].Value),
                    EK3_fP_Psi = Convert.ToInt32(GridViewPerformanceInfoStation.CurrentRow.Cells["EK3_fP_Psi"].Value),
                    EK3_fPbX = Convert.ToInt32(GridViewPerformanceInfoStation.CurrentRow.Cells["EK3_fPbX"].Value),
                    EK3_fQb = Convert.ToInt32(GridViewPerformanceInfoStation.CurrentRow.Cells["EK3_fQb"].Value),
                    EK3_fQm = Convert.ToInt32(GridViewPerformanceInfoStation.CurrentRow.Cells["EK3_fQm"].Value),
                    EK3_fT = Convert.ToInt32(GridViewPerformanceInfoStation.CurrentRow.Cells["EK3_fT"].Value),
                    EK3_fTbX = Convert.ToInt32(GridViewPerformanceInfoStation.CurrentRow.Cells["EK3_fTbX"].Value),
                    EK3_nBatRemain = Convert.ToInt32(GridViewPerformanceInfoStation.CurrentRow.Cells["EK3_nBatRemain"].Value),
                    EK3_nVb = Convert.ToInt32(GridViewPerformanceInfoStation.CurrentRow.Cells["EK3_nVb"].Value),
                    EK3_nVbD = Convert.ToInt32(GridViewPerformanceInfoStation.CurrentRow.Cells["EK3_nVbD"].Value),
                    EK3_nVm = Convert.ToInt32(GridViewPerformanceInfoStation.CurrentRow.Cells["EK3_nVm"].Value),
                    EK3_nVmD = Convert.ToInt32(GridViewPerformanceInfoStation.CurrentRow.Cells["EK3_nVmD"].Value),

                    fInT_Ht1 = Convert.ToInt32(GridViewPerformanceInfoStation.CurrentRow.Cells["fInT_Ht1"].Value),
                    fOutT_Ht1 = Convert.ToInt32(GridViewPerformanceInfoStation.CurrentRow.Cells["fOutT_Ht1"].Value),
                    fWaterT_Ht1 = Convert.ToInt32(GridViewPerformanceInfoStation.CurrentRow.Cells["fWaterT_Ht1"].Value),
                    fInT_Ht2 = Convert.ToInt32(GridViewPerformanceInfoStation.CurrentRow.Cells["fInT_Ht2"].Value),
                    fOutT_Ht2 = Convert.ToInt32(GridViewPerformanceInfoStation.CurrentRow.Cells["fOutT_Ht2"].Value),
                    fWaterT_Ht2 = Convert.ToInt32(GridViewPerformanceInfoStation.CurrentRow.Cells["fWaterT_Ht2"].Value),


                    Id = Convert.ToInt32(GridViewPerformanceInfoStation.CurrentRow.Cells["Id"].Value),
                };
                ls.Add(tS);
            }

            new ViewModel.Table_TSample.Table_TSample().UpdateEntity(ls, ref str);

            return true;

        }

        private void GridViewPerformanceInfoStation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                ButtonAdd_Click(this, null);
        }


    }
}
