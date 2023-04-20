using System.Linq;
using System.Collections.Generic;
using GasStationManagement.Model.Basic.DataAccess;
using GasStationManagement.Model.MonitoringSupply;
using GasStationManagement.View.MainForms.Monitoring;
using System;
using MSS.Library.Clasess.FilterClass;

namespace GasStationManagement.View.MainForms.Monitoring
{
    public partial class MonitoringSupply_UC : MSS.Library.UserControls.MSSUserControl_UC
    {
        public MonitoringSupply_UC()
        {
            InitializeComponent();
        }

        public void BindData()
        {
            string str = "";
            if (ParameterSet == null)
                GridViewMonitoringSupply.DataSource = new ViewModel.MonitoringSupply.MonitoringSupply().GetList(ref str);
            else
            {
                QueryFilter.ExpressionBuilder.Filter _filter = null;
                List<QueryFilter.ExpressionBuilder.Filter> _listFilter = new List<QueryFilter.ExpressionBuilder.Filter>();

                foreach (var item in ParameterSet)
                {
                    _filter = new QueryFilter.ExpressionBuilder.Filter();
                    _filter.PropertyName = item.Key;
                    _filter.Operation = QueryFilter.ExpressionBuilder.Op.Equals;
                    _filter.Value = item.Value;
                    _filter.OperationFilter = QueryFilter.ExpressionBuilder.OpFilter.And;
                    _listFilter.Add(_filter);
                }
                GridViewMonitoringSupply.DataSource = new ViewModel.MonitoringSupply.MonitoringSupply().GetListByFilter(_listFilter, ref str);
            }
        }

        
        #region All UI Button

        private void headerGridMonitoringSupply_btnInsertClick(object sender, System.EventArgs e)
        {
            MonitoringSupplyAdd_Frm MonitoringSupply = new MonitoringSupplyAdd_Frm(int.Parse(GridViewMonitoringSupply.CurrentRow.Cells["Monitoring_Id"].Value.ToString()));
            MonitoringSupply.ShowDialog();
            BindData();
        }

        private void headerGridMonitoringSupply_btnEditClick(object sender, System.EventArgs e)
        {
            MonitoringSupplyAdd_Frm MonitoringSupplyAdd = new MonitoringSupplyAdd_Frm(
                int.Parse(GridViewMonitoringSupply.CurrentRow.Cells["Monitoring_Id"].Value.ToString()),
                GridViewMonitoringSupply.CurrentRow.Cells["MonitoringSerialNo"].Value.ToString()
                );
            MonitoringSupplyAdd.ShowDialog();
            BindData();
        }

        private void headerGridMonitoringSupply_btnDeleteClick(object sender, System.EventArgs e)
        {
            if (MSS.Library.Clasess.MSSMessage.MSSMessage_View(0,MSS.Library.Clasess.MSSMessage.MessageType.SConfirmation,true, "آیا به حذف این مورد اطمینان دارید؟"))
            {
                try
                {
                    List<TBL_MonitoringSupply> Ls = new List<TBL_MonitoringSupply>();
                    TBL_MonitoringSupply MonitoringSupply = new TBL_MonitoringSupply();
                    MonitoringSupply.Monitoring_Id = int.Parse(GridViewMonitoringSupply.CurrentRow.Cells["Monitoring_Id"].Value.ToString());
                    MonitoringSupply.MonitoringSerialNo = GridViewMonitoringSupply.CurrentRow.Cells["MonitoringSerialNo"].Value.ToString();
                    MonitoringSupply.Price = long.Parse(GridViewMonitoringSupply.CurrentRow.Cells["Price"].Value.ToString());
                    MonitoringSupply.InitialVc = GridViewMonitoringSupply.CurrentRow.Cells["InitialVc"].Value.ToString();
                    MonitoringSupply.Suppliers_Id = short.Parse(GridViewMonitoringSupply.CurrentRow.Cells["Suppliers_Id"].Value.ToString());
                    MonitoringSupply.SupplyDate = GridViewMonitoringSupply.CurrentRow.Cells["SupplyDate"].Value.ToString();
                    MonitoringSupply.Description = GridViewMonitoringSupply.CurrentRow.Cells["Description"].Value.ToString();
                    MonitoringSupply.IsActive = bool.Parse(GridViewMonitoringSupply.CurrentRow.Cells["IsActive"].Value.ToString());
                    Ls.Add(MonitoringSupply);


                    string str = "";
                    new ViewModel.MonitoringSupply.MonitoringSupply().DeleteEntity(Ls, ref str);
                }
                catch 
                {
                    MSS.Library.Clasess.MSSMessage.MSSMessage_View("امکان حذف این مورد در سیستم وجود ندارد",MSS.Library.Clasess.MSSMessage.MessageType.SError);
                }
            }
            BindData();
        }

        private void headerGridMonitoringSupply_btnRefreshClick(object sender, System.EventArgs e)
        {
            BindData();
        }

        private void GridViewMonitoringSupply_SelectionChanged(object sender, System.EventArgs e)
        {
            UserControl_Slave.ParameterSet = new Dictionary<string, object>();
            UserControl_Slave.ParameterSet.Add("Monitoring_Id", System.Convert.ToInt32(GridViewMonitoringSupply.CurrentRow.Cells["Monitoring_Id"].Value));
            UserControl_Slave.ParameterSet.Add("MonitoringSerialNo", GridViewMonitoringSupply.CurrentRow.Cells["MonitoringSerialNo"].Value.ToString());

            UserControl_Slave.ParameterSomeEvent();
        }

        #endregion

        private void MonitoringSupply_UC_Load(object sender, System.EventArgs e)
        {
            BindData();
            ParameterSetEvent += new ParameterSetChange(Th_ParameterSetEvent);
        }

        public void Th_ParameterSetEvent()
        {
            BindData();
        }


    }
}
