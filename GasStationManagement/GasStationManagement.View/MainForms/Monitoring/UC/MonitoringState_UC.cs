using System.Linq;
using System.Collections.Generic;
using GasStationManagement.Model.Basic.DataAccess;
using GasStationManagement.Model.MonitoringState;

namespace GasStationManagement.View.MainForms.Monitoring
{
    public partial class MonitoringState_UC : MSS.Library.UserControls.MSSUserControl_UC
    {
        public MonitoringState_UC()
        {
            InitializeComponent();
        }

        //public delegate bool MonitoringStateDelegate(int Id, string MonitoringSerialNo);
        //public event MonitoringStateDelegate MonitoringStateEvent;

        bool MonitoringStateEvent(int id)
        {
            BindData(id);
            return true;
        }
        public void BindData(int id)
        {
            string str = "";
            GridViewMonitoringState.DataSource = new ViewModel.MonitoringState.MonitoringState().GetListByID(id, ref str);
        }

        
        #region All UI Button

        private void headerGridMonitoringState_btnInsertClick(object sender, System.EventArgs e)
        {
            MonitoringStateAdd_Frm MonitoringStateAdd = new MonitoringStateAdd_Frm();
            MonitoringStateAdd.ShowDialog();
            BindData(int.Parse(GridViewMonitoringState.CurrentRow.Cells["Monitoring_Id"].Value.ToString()));
        }

        private void headerGridMonitoringState_btnEditClick(object sender, System.EventArgs e)
        {
            MonitoringStateAdd_Frm MonitoringStateAdd = new MonitoringStateAdd_Frm(byte.Parse(GridViewMonitoringState.CurrentRow.Cells["Monitoring_Id"].Value.ToString()));
            MonitoringStateAdd.ShowDialog();
            BindData(int.Parse(GridViewMonitoringState.CurrentRow.Cells["Monitoring_Id"].Value.ToString()));
        }

        private void headerGridMonitoringState_btnDeleteClick(object sender, System.EventArgs e)
        {
            if (MSS.Library.Clasess.MSSMessage.MSSMessage_View(0,MSS.Library.Clasess.MSSMessage.MessageType.SConfirmation,true, "آیا به حذف این مورد اطمینان دارید؟"))
            {
                try
                {
                    List<TBL_MonitoringState> Ls = new List<TBL_MonitoringState>();
                    TBL_MonitoringState MonitoringState = new TBL_MonitoringState();
                    MonitoringState.Monitoring_Id = int.Parse(GridViewMonitoringState.CurrentRow.Cells["Monitoring_Id"].Value.ToString());
                    MonitoringState.MonitoringSerialNo = GridViewMonitoringState.CurrentRow.Cells["MonitoringSerialNo"].Value.ToString();
                    MonitoringState.MonitoringStateRow = int.Parse(GridViewMonitoringState.CurrentRow.Cells["MonitoringStateRow"].Value.ToString());
                    MonitoringState.ChangeStateDate = GridViewMonitoringState.CurrentRow.Cells["ChangeStateDate"].Value.ToString();
                    MonitoringState.EquipmentState_Id = short.Parse(GridViewMonitoringState.CurrentRow.Cells["EquipmentState_Id"].Value.ToString());
                    MonitoringState.Store_Id = short.Parse(GridViewMonitoringState.CurrentRow.Cells["Store_Id"].Value.ToString());
                    MonitoringState.WorkShop_Id = short.Parse(GridViewMonitoringState.CurrentRow.Cells["WorkShop_Id"].Value.ToString());
                    MonitoringState.Calibration_Id = short.Parse(GridViewMonitoringState.CurrentRow.Cells["Calibration_Id"].Value.ToString());
                    MonitoringState.GasStation_Id = short.Parse(GridViewMonitoringState.CurrentRow.Cells["GasStation_Id"].Value.ToString());
                    MonitoringState.Description = GridViewMonitoringState.CurrentRow.Cells["Description"].Value.ToString();
                    MonitoringState.IsActive = bool.Parse(GridViewMonitoringState.CurrentRow.Cells["IsActive"].Value.ToString());
                    Ls.Add(MonitoringState);


                    string str = "";
                    new ViewModel.MonitoringState.MonitoringState().DeleteEntity(Ls, ref str);
                }
                catch 
                {
                    MSS.Library.Clasess.MSSMessage.MSSMessage_View("امکان حذف این مورد در سیستم وجود ندارد",MSS.Library.Clasess.MSSMessage.MessageType.SError);
                }
            }
            BindData(int.Parse(GridViewMonitoringState.CurrentRow.Cells["Monitoring_Id"].Value.ToString()));
        }

        private void headerGridMonitoringState_btnRefreshClick(object sender, System.EventArgs e)
        {
            BindData(int.Parse(GridViewMonitoringState.CurrentRow.Cells["Monitoring_Id"].Value.ToString()));
        }

        #endregion

        private void MonitoringState_UC_Load(object sender, System.EventArgs e)
        {
            BindData(int.Parse(GridViewMonitoringState.CurrentRow.Cells["Monitoring_Id"].Value.ToString()));
        }

        private void GridViewMonitoringState_SelectionChanged(object sender, System.EventArgs e)
        {
            //MonitoringStateEvent(int.Parse(GridViewMonitoringState.CurrentRow.Cells["Monitoring_Id"].Value.ToString()),
            //    GridViewMonitoringState.CurrentRow.Cells["MonitoringSerialNo"].Value.ToString());
        }


    }
}
