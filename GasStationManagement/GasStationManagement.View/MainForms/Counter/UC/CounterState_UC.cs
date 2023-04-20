using System.Linq;
using System.Collections.Generic;
using GasStationManagement.Model.Basic.DataAccess;
using GasStationManagement.Model.CounterState;
using MSS.Library.Clasess.FilterClass;

namespace GasStationManagement.View.MainForms.Counter
{
    public partial class CounterState_UC : MSS.Library.UserControls.MSSUserControl_UC
    {
        public CounterState_UC()
        {
            InitializeComponent();
        }

        public void BindData(int RowNumberSet)
        {
            string str = "";
            if (ParameterSet == null)
                GridViewCounterState.DataSource = new ViewModel.CounterState.CounterState().GetList(ref str);
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
                GridViewCounterState.DataSource = new ViewModel.CounterState.CounterState().GetListByFilter(_listFilter, ref str);
            }
            try { GridViewCounterState.Row = RowNumberSet; }
            catch { }
        }

        
        #region All UI Button

        private void headerGridCounterState_btnInsertClick(object sender, System.EventArgs e)
        {
            try
            {
                CounterStateAdd_Frm CounterStateAdd = null;

                if (ParameterSet.Keys.Contains("GasStation_Id"))
                    CounterStateAdd = new CounterStateAdd_Frm(
                        System.Convert.ToInt32(ParameterSet["GasStation_Id"]));
                else
                    CounterStateAdd = new CounterStateAdd_Frm(
                        System.Convert.ToInt32(ParameterSet["Counter_Id"]),
                        ParameterSet["CounterSerialNo"].ToString());

                CounterStateAdd.ShowDialog();
                BindData(GridViewCounterState.RowCount);
            }
            catch { }
        }

        private void headerGridCounterState_btnEditClick(object sender, System.EventArgs e)
        {
            try
            {
                int i = GridViewCounterState.Row;

                CounterStateAdd_Frm CounterStateAdd = new CounterStateAdd_Frm(
                    int.Parse(GridViewCounterState.CurrentRow.Cells["Counter_Id"].Value.ToString()),
                    GridViewCounterState.CurrentRow.Cells["CounterSerialNo"].Value.ToString(),
                    int.Parse(GridViewCounterState.CurrentRow.Cells["CounterStateRow"].Value.ToString()));
                CounterStateAdd.ShowDialog();
                BindData(i);
            }
            catch { }
        }

        private void headerGridCounterState_btnDeleteClick(object sender, System.EventArgs e)
        {
            if (MSS.Library.Clasess.MSSMessage.MSSMessage_View(0,MSS.Library.Clasess.MSSMessage.MessageType.SConfirmation,true, "آیا به حذف این مورد اطمینان دارید؟"))
            {
                try
                {
                    int i = GridViewCounterState.Row;

                    List<TBL_CounterState> Ls = new List<TBL_CounterState>();
                    TBL_CounterState CounterState = new TBL_CounterState();
                    CounterState.Counter_Id = int.Parse(GridViewCounterState.CurrentRow.Cells["Counter_Id"].Value.ToString());
                    CounterState.CounterSerialNo = GridViewCounterState.CurrentRow.Cells["CounterSerialNo"].Value.ToString();
                    CounterState.CounterStateRow = int.Parse(GridViewCounterState.CurrentRow.Cells["CounterStateRow"].Value.ToString());

                    Ls.Add(CounterState);


                    string str = "";
                    new ViewModel.CounterState.CounterState().DeleteEntity(Ls, ref str);
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

        private void headerGridCounterState_btnRefreshClick(object sender, System.EventArgs e)
        {
            BindData(GridViewCounterState.Row);
        }

        #endregion

        private void CounterState_UC_Load(object sender, System.EventArgs e)
        {
            BindData(GridViewCounterState.Row);
            ParameterSetEvent += new ParameterSetChange(Th_ParameterSetEvent);
            HeaderGridCounterState.Visible = HeaderVisible;
        }
        public void Th_ParameterSetEvent()
        {
            BindData(GridViewCounterState.Row);
        }

        private void GridViewCounterState_SelectionChanged(object sender, System.EventArgs e)
        {
            try
            {
                UserControl_Slave.ParameterSet = new Dictionary<string, object>();
                UserControl_Slave.ParameterSet.Add("Counter_Id", System.Convert.ToInt32(GridViewCounterState.CurrentRow.Cells["Counter_Id"].Value));
                UserControl_Slave.ParameterSet.Add("CounterSerialNo", GridViewCounterState.CurrentRow.Cells["CounterSerialNo"].Value.ToString());
                UserControl_Slave.ParameterSomeEvent();
            }
            catch { }
        }

        private void GridViewCounterState_BindingDataSourceSet(object sender, System.EventArgs e)
        {
            BindData(GridViewCounterState.Row);
            GridViewCounterState_SelectionChanged(this, null);
        }

    }
}
