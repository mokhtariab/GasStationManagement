using System.Linq;
using System.Collections.Generic;
using GasStationManagement.Model.Basic.DataAccess;
using GasStationManagement.Model.StationMonitoringState;
using MSS.Library.Clasess.FilterClass;

namespace GasStationManagement.View.MainForms.StationMonitoringState
{
    public partial class StationMonitoringState_UC : MSS.Library.UserControls.MSSUserControl_UC
    {
        public StationMonitoringState_UC()
        {
            InitializeComponent();
        }

        public void BindData(int RowNumberSet)
        {
            string str = "";
            if (ParameterSet == null)
                GridViewStationMonitoringState.DataSource = new ViewModel.StationMonitoringState.StationMonitoringState().GetList(ref str);
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
                GridViewStationMonitoringState.DataSource = new ViewModel.StationMonitoringState.StationMonitoringState().GetListByFilter(_listFilter, ref str);
            }
            GridViewStationMonitoringState.Row = RowNumberSet;
        }

        
        #region All UI Button

        private void headerGridStationMonitoringState_btnInsertClick(object sender, System.EventArgs e)
        {
            try
            {
                StationMonitoringStateAdd_Frm StationMonitoringStateAdd = null;

                if (ParameterSet.Keys.Contains("GasStation_Id"))
                    StationMonitoringStateAdd = new StationMonitoringStateAdd_Frm(
                        System.Convert.ToInt32(ParameterSet["GasStation_Id"]));

                StationMonitoringStateAdd.ShowDialog();
                BindData(GridViewStationMonitoringState.RowCount);
            }
            catch { }
        }

        private void headerGridStationMonitoringState_btnEditClick(object sender, System.EventArgs e)
        {
            try
            {
                int i = GridViewStationMonitoringState.Row;

                StationMonitoringStateAdd_Frm StationMonitoringStateAdd = new StationMonitoringStateAdd_Frm(
                    int.Parse(GridViewStationMonitoringState.CurrentRow.Cells["Id"].Value.ToString()),
                    int.Parse(GridViewStationMonitoringState.CurrentRow.Cells["GasStation_Id"].Value.ToString()));
                StationMonitoringStateAdd.ShowDialog();
                BindData(i);
            }
            catch { }
        }

        private void headerGridStationMonitoringState_btnDeleteClick(object sender, System.EventArgs e)
        {
            if (MSS.Library.Clasess.MSSMessage.MSSMessage_View(0,MSS.Library.Clasess.MSSMessage.MessageType.SConfirmation,true, "آیا به حذف این مورد اطمینان دارید؟"))
            {
                try
                {
                    int i = GridViewStationMonitoringState.Row;

                    List<TBL_StationMonitoringState> Ls = new List<TBL_StationMonitoringState>();
                    TBL_StationMonitoringState StationMonitoringState = new TBL_StationMonitoringState();
                    StationMonitoringState.Id = int.Parse(GridViewStationMonitoringState.CurrentRow.Cells["Id"].Value.ToString());

                    Ls.Add(StationMonitoringState);


                    string str = "";
                    new ViewModel.StationMonitoringState.StationMonitoringState().DeleteEntity(Ls, ref str);
                    if (str != "")
                        MSS.Library.Clasess.MSSMessage.MSSMessage_View(0, MSS.Library.Clasess.MSSMessage.MessageType.SError, false, "امکان حذف این مورد در سیستم وجود ندارد", str);
                    else { BindData(i - 1); }
                }
                catch (System.Exception ex)
                {
                    MSS.Library.Clasess.MSSMessage.MSSMessage_View(0, MSS.Library.Clasess.MSSMessage.MessageType.SError, false, "امکان حذف این مورد در سیستم وجود ندارد", ex.Message);
                }
            }
        }

        private void headerGridStationMonitoringState_btnRefreshClick(object sender, System.EventArgs e)
        {
            BindData(GridViewStationMonitoringState.Row);
        }

        #endregion

        private void StationMonitoringState_UC_Load(object sender, System.EventArgs e)
        {
            BindData(GridViewStationMonitoringState.Row);
            ParameterSetEvent += new ParameterSetChange(Th_ParameterSetEvent);
        }

        public void Th_ParameterSetEvent()
        {
            BindData(GridViewStationMonitoringState.Row);
        }
        private void GridViewStationMonitoringState_BindingDataSourceSet(object sender, System.EventArgs e)
        {
            BindData(GridViewStationMonitoringState.Row);
        }


    }
}
