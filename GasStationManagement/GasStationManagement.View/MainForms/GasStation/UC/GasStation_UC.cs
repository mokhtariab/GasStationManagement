using System.Linq;
using System.Collections.Generic;
using GasStationManagement.Model.Basic.DataAccess;

namespace GasStationManagement.View.MainForms.GasStation
{
    public partial class GasStation_UC : System.Windows.Forms.UserControl
    {
        public GasStation_UC()
        {
            InitializeComponent();
        }
        public void BindData()
        {
            string str = "";
            GridViewGasStation.DataSource = new ViewModel.GasStationClass.GasStationClass().GetList(ref str);
        }

        
        #region All UI Button

        private void headerGridGasStation_btnInsertClick(object sender, System.EventArgs e)
        {
            GasStationAdd_Frm GasStationAdd = new GasStationAdd_Frm();
            GasStationAdd.ShowDialog();
            BindData();
        }

        private void headerGridGasStation_btnEditClick(object sender, System.EventArgs e)
        {
            try
            {
                GasStationAdd_Frm GasStationAdd = new GasStationAdd_Frm(byte.Parse(GridViewGasStation.CurrentRow.Cells["ID"].Value.ToString()));
                GasStationAdd.ShowDialog();
                BindData();
            }
            catch { }
        }

        private void headerGridGasStation_btnDeleteClick(object sender, System.EventArgs e)
        {
            if (MSS.Library.Clasess.MSSMessage.MSSMessage_View(0,MSS.Library.Clasess.MSSMessage.MessageType.SConfirmation,true, "آیا به حذف این مورد اطمینان دارید؟"))
            {
                try
                {
                    List<GasStationManagement.Model.GasStation.GasStation> Ls = new List<GasStationManagement.Model.GasStation.GasStation>();
                    GasStationManagement.Model.GasStation.GasStation GasStation = new GasStationManagement.Model.GasStation.GasStation();
                    GasStation.ID = int.Parse(GridViewGasStation.CurrentRow.Cells["ID"].Value.ToString());
                    //GasStation.GasStationCode = GridViewGasStation.CurrentRow.Cells["GasStationCode"].Value.ToString();
                    //GasStation.GasStationName = GridViewGasStation.CurrentRow.Cells["GasStationName"].Value.ToString();
                    //GasStation.GasStationBuildingDate = GridViewGasStation.CurrentRow.Cells["GasStationBuildingDate"].Value.ToString();
                    //GasStation.Capacity = int.Parse(GridViewGasStation.CurrentRow.Cells["Capacity"].Value.ToString());
                    //GasStation.GasStationType_Id = short.Parse(GridViewGasStation.CurrentRow.Cells["GasStationType_Id"].Value.ToString());
                    //GasStation.WorkingPressure_Id = short.Parse(GridViewGasStation.CurrentRow.Cells["WorkingPressure_Id"].Value.ToString());
                    //GasStation.UseType_Id = short.Parse(GridViewGasStation.CurrentRow.Cells["UseType_Id"].Value.ToString());
                    //GasStation.ScheduleRegInfo = short.Parse(GridViewGasStation.CurrentRow.Cells["ScheduleRegInfo"].Value.ToString());
                    //GasStation.ScheduleSpecPeriod = int.Parse(GridViewGasStation.CurrentRow.Cells["ScheduleSpecPeriod"].Value.ToString());
                    //GasStation.Line_Id = short.Parse(GridViewGasStation.CurrentRow.Cells["Line_Id"].Value.ToString());
                    //GasStation.GasStation_Id = int.Parse(GridViewGasStation.CurrentRow.Cells["GasStation_Id"].Value.ToString());
                    //GasStation.RanFew = int.Parse(GridViewGasStation.CurrentRow.Cells["RanFew"].Value.ToString());
                    //GasStation.Heater_Few = int.Parse(GridViewGasStation.CurrentRow.Cells["Heater_Few"].Value.ToString());
                    //GasStation.CounterInsLoc_Id = short.Parse(GridViewGasStation.CurrentRow.Cells["CounterInsLoc_Id"].Value.ToString());
                    //GasStation.CorrectionFactor = int.Parse(GridViewGasStation.CurrentRow.Cells["CorrectionFactor"].Value.ToString());
                    //GasStation.StationLinkType_Id = short.Parse(GridViewGasStation.CurrentRow.Cells["StationLinkType_Id"].Value.ToString());
                    //GasStation.MonitoringSysState_Id = short.Parse(GridViewGasStation.CurrentRow.Cells["MonitoringSysState_Id"].Value.ToString());
                    //GasStation.MonitoringSysExeDate = GridViewGasStation.CurrentRow.Cells["MonitoringSysExeDate"].Value.ToString();
                    //GasStation.Suppliers_Id = short.Parse(GridViewGasStation.CurrentRow.Cells["Suppliers_Id"].Value.ToString());
                    //GasStation.Description = GridViewGasStation.CurrentRow.Cells["Description"].Value.ToString();
                    //GasStation.IsActive = bool.Parse(GridViewGasStation.CurrentRow.Cells["IsActive"].Value.ToString());
                    Ls.Add(GasStation);


                    string str = "";
                    new ViewModel.GasStationClass.GasStationClass().DeleteEntity(Ls, ref str);
                }
                catch (System.Exception ex)
                {
                    MSS.Library.Clasess.MSSMessage.MSSMessage_View(0, MSS.Library.Clasess.MSSMessage.MessageType.SError, false, "امکان حذف این مورد در سیستم وجود ندارد", ex.Message);
                }
            }
            BindData();
        }

        private void headerGridGasStation_btnRefreshClick(object sender, System.EventArgs e)
        {
            BindData();
        }

        #endregion

        private void GasStation_UC_Load(object sender, System.EventArgs e)
        {
            BindData();
        }

        private void GridViewGasStation_SelectionChanged(object sender, System.EventArgs e)
        {
            //Counter
            try
            {
                counterState_UC1.ParameterSet = new Dictionary<string, object>();
                counterState_UC1.ParameterSet.Add("GasStation_Id", System.Convert.ToInt32(GridViewGasStation.CurrentRow.Cells["ID"].Value));
                counterState_UC1.ParameterSet.Add("IsActive", true);
                counterState_UC1.ParameterSomeEvent();
            }
            catch { }
            
            try
            {
                counterState_UC2.ParameterSet = new Dictionary<string, object>();
                counterState_UC2.ParameterSet.Add("GasStation_Id", System.Convert.ToInt32(GridViewGasStation.CurrentRow.Cells["ID"].Value));
                counterState_UC2.ParameterSomeEvent();
            }
            catch { }

            
            //EVCD
            try
            {
                evcdState_UC1.ParameterSet = new Dictionary<string, object>();
                evcdState_UC1.ParameterSet.Add("GasStation_Id", System.Convert.ToInt32(GridViewGasStation.CurrentRow.Cells["ID"].Value));
                evcdState_UC1.ParameterSet.Add("IsActive", true);
                evcdState_UC1.ParameterSomeEvent();
            }
            catch { }

            try
            {
                evcdState_UC2.ParameterSet = new Dictionary<string, object>();
                evcdState_UC2.ParameterSet.Add("GasStation_Id", System.Convert.ToInt32(GridViewGasStation.CurrentRow.Cells["ID"].Value));
                evcdState_UC2.ParameterSomeEvent();
            }
            catch { }

            
            
            //PressGage
            try
            {
                pressGageState_UC1.ParameterSet = new Dictionary<string, object>();
                pressGageState_UC1.ParameterSet.Add("GasStation_Id", System.Convert.ToInt32(GridViewGasStation.CurrentRow.Cells["ID"].Value));
                pressGageState_UC1.ParameterSet.Add("IsActive", true);
                pressGageState_UC1.ParameterSomeEvent();
            }
            catch { }

            try
            {
                pressGageState_UC2.ParameterSet = new Dictionary<string, object>();
                pressGageState_UC2.ParameterSet.Add("GasStation_Id", System.Convert.ToInt32(GridViewGasStation.CurrentRow.Cells["ID"].Value));
                pressGageState_UC2.ParameterSomeEvent();
            }
            catch { }



            //TemGage
            try
            {
                temGageState_UC1.ParameterSet = new Dictionary<string, object>();
                temGageState_UC1.ParameterSet.Add("GasStation_Id", System.Convert.ToInt32(GridViewGasStation.CurrentRow.Cells["ID"].Value));
                temGageState_UC1.ParameterSet.Add("IsActive", true);
                temGageState_UC1.ParameterSomeEvent();
            }
            catch { }

            try
            {
                temGageState_UC2.ParameterSet = new Dictionary<string, object>();
                temGageState_UC2.ParameterSet.Add("GasStation_Id", System.Convert.ToInt32(GridViewGasStation.CurrentRow.Cells["ID"].Value));
                temGageState_UC2.ParameterSomeEvent();
            }
            catch { }



            //PressTrans
            try
            {
                pressTransState_UC1.ParameterSet = new Dictionary<string, object>();
                pressTransState_UC1.ParameterSet.Add("GasStation_Id", System.Convert.ToInt32(GridViewGasStation.CurrentRow.Cells["ID"].Value));
                pressTransState_UC1.ParameterSet.Add("IsActive", true);
                pressTransState_UC1.ParameterSomeEvent();
            }
            catch { }

            try
            {
                pressTransState_UC2.ParameterSet = new Dictionary<string, object>();
                pressTransState_UC2.ParameterSet.Add("GasStation_Id", System.Convert.ToInt32(GridViewGasStation.CurrentRow.Cells["ID"].Value));
                pressTransState_UC2.ParameterSomeEvent();
            }
            catch { }

            //TemTrans
            try
            {
                temTransState_UC1.ParameterSet = new Dictionary<string, object>();
                temTransState_UC1.ParameterSet.Add("GasStation_Id", System.Convert.ToInt32(GridViewGasStation.CurrentRow.Cells["ID"].Value));
                temTransState_UC1.ParameterSet.Add("IsActive", true);
                temTransState_UC1.ParameterSomeEvent();
            }
            catch { }

            try
            {
                temTransState_UC2.ParameterSet = new Dictionary<string, object>();
                temTransState_UC2.ParameterSet.Add("GasStation_Id", System.Convert.ToInt32(GridViewGasStation.CurrentRow.Cells["ID"].Value));
                temTransState_UC2.ParameterSomeEvent();
            }
            catch { }


            //stationMonitoringState
            try
            {
                stationMonitoringState_UC1.ParameterSet = new Dictionary<string, object>();
                stationMonitoringState_UC1.ParameterSet.Add("GasStation_Id", System.Convert.ToInt32(GridViewGasStation.CurrentRow.Cells["ID"].Value));
                //stationMonitoringState_UC1.ParameterSet.Add("IsActive", true);
                stationMonitoringState_UC1.ParameterSomeEvent();
            }
            catch { }

        }


    }
}
