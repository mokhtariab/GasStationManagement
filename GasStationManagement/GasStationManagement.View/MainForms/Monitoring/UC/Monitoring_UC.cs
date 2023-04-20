using System.Linq;
using System.Collections.Generic;
using GasStationManagement.Model.Basic.DataAccess;
using MSS.Library.Clasess.FilterClass;

namespace GasStationManagement.View.MainForms.Monitoring
{
    public partial class Monitoring_UC : MSS.Library.UserControls.MSSUserControl_UC
    {

        public Monitoring_UC()
        {
            InitializeComponent();
        }

        public void BindData()
        {
            string str = "";
            if (ParameterSet == null)
                GridViewMonitoring.DataSource = new ViewModel.Basic.Monitoring().GetList(ref str);
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
                GridViewMonitoring.DataSource = new ViewModel.Basic.Monitoring().GetListByFilter(_listFilter, ref str);
            }
        }

        
        #region All UI Button

        private void headerGridMonitoring_btnInsertClick(object sender, System.EventArgs e)
        {
            MonitoringAdd_Frm MonitoringAdd = new MonitoringAdd_Frm();
            MonitoringAdd.ShowDialog();
            BindData();
        }

        private void headerGridMonitoring_btnEditClick(object sender, System.EventArgs e)
        {
            MonitoringAdd_Frm MonitoringAdd = new MonitoringAdd_Frm(int.Parse(GridViewMonitoring.CurrentRow.Cells["Id"].Value.ToString()));
            MonitoringAdd.ShowDialog();
            BindData();
        }

        private void headerGridMonitoring_btnDeleteClick(object sender, System.EventArgs e)
        {
            if (MSS.Library.Clasess.MSSMessage.MSSMessage_View(0,MSS.Library.Clasess.MSSMessage.MessageType.SConfirmation,true, "آیا به حذف این مورد اطمینان دارید؟"))
            {
                try
                {
                    List<TBL_Monitoring> Ls = new List<TBL_Monitoring>();
                    TBL_Monitoring Monitoring = new TBL_Monitoring();
                    Monitoring.ID = int.Parse(GridViewMonitoring.CurrentRow.Cells["Id"].Value.ToString());
                    Monitoring.Brand = GridViewMonitoring.CurrentRow.Cells["Brand"].Value.ToString();
                    Monitoring.Size = double.Parse(GridViewMonitoring.CurrentRow.Cells["Size"].Value.ToString());
                    Monitoring.Class = GridViewMonitoring.CurrentRow.Cells["Class"].Value.ToString();
                    Monitoring.Grate = int.Parse(GridViewMonitoring.CurrentRow.Cells["Grate"].Value.ToString());
                    Monitoring.Description = GridViewMonitoring.CurrentRow.Cells["Description"].Value.ToString();
                    Monitoring.IsActive = bool.Parse(GridViewMonitoring.CurrentRow.Cells["IsActive"].Value.ToString());
                    Ls.Add(Monitoring);


                    string str = "";
                    new ViewModel.Basic.Monitoring().DeleteEntity(Ls, ref str);
                }
                catch 
                {
                    MSS.Library.Clasess.MSSMessage.MSSMessage_View("امکان حذف این مورد در سیستم وجود ندارد",MSS.Library.Clasess.MSSMessage.MessageType.SError);
                }
            }
            BindData();
        }

        private void headerGridMonitoring_btnRefreshClick(object sender, System.EventArgs e)
        {
            BindData();
        }

        #endregion

        private void Monitoring_UC_Load(object sender, System.EventArgs e)
        {
            BindData();
            ParameterSetEvent += new ParameterSetChange(Th_ParameterSetEvent);
        }
        public void Th_ParameterSetEvent()
        {
            BindData();
        }

        private void GridViewMonitoring_SelectionChanged(object sender, System.EventArgs e)
        {
            try
            {
                UserControl_Slave.ParameterSet = new Dictionary<string, object>();
                UserControl_Slave.ParameterSet.Add("Monitoring_Id", System.Convert.ToInt32(GridViewMonitoring.CurrentRow.Cells["Id"].Value));
                UserControl_Slave.ParameterSomeEvent();
            }
            catch { }
        }

    }
}
