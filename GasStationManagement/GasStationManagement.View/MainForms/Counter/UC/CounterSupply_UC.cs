using System.Linq;
using System.Collections.Generic;
using GasStationManagement.Model.Basic.DataAccess;
using GasStationManagement.Model.CounterSupply;
using GasStationManagement.View.MainForms.Counter;
using MSS.Library.Clasess.FilterClass;

namespace GasStationManagement.View.MainForms.Counter
{
    public partial class CounterSupply_UC : MSS.Library.UserControls.MSSUserControl_UC
    {
        public CounterSupply_UC()
        {
            InitializeComponent();
        }

        public void BindData(int RowNumberSet)
        {
            string str = "";

            if (ParameterSet == null)
                GridViewCounterSupply.DataSource = new ViewModel.CounterSupply.CounterSupply().GetList(ref str);
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
                GridViewCounterSupply.DataSource = new ViewModel.CounterSupply.CounterSupply().GetListByFilter(_listFilter, ref str);
            }
            GridViewCounterSupply.Row = RowNumberSet;
        }

        
        #region All UI Button

        private void headerGridCounterSupply_btnInsertClick(object sender, System.EventArgs e)
        {
            try
            {
                CounterSupplyAdd_Frm CounterSupply = new CounterSupplyAdd_Frm(System.Convert.ToInt32(ParameterSet["Counter_Id"]));
                CounterSupply.ShowDialog();
                BindData(GridViewCounterSupply.RowCount);
            }
            catch { }
        }

        private void headerGridCounterSupply_btnEditClick(object sender, System.EventArgs e)
        {
            try
            {
                int i = GridViewCounterSupply.Row;

                CounterSupplyAdd_Frm CounterSupplyAdd = new CounterSupplyAdd_Frm(
                    int.Parse(GridViewCounterSupply.CurrentRow.Cells["Counter_Id"].Value.ToString()),
                    GridViewCounterSupply.CurrentRow.Cells["CounterSerialNo"].Value.ToString());
                CounterSupplyAdd.ShowDialog();
                BindData(i);
            }
            catch { }
        }

        private void headerGridCounterSupply_btnDeleteClick(object sender, System.EventArgs e)
        {
            if (MSS.Library.Clasess.MSSMessage.MSSMessage_View(0,MSS.Library.Clasess.MSSMessage.MessageType.SConfirmation,true, "آیا به حذف این مورد اطمینان دارید؟"))
            {
                try
                {
                    int i = GridViewCounterSupply.Row;
                    List<TBL_CounterSupply> Ls = new List<TBL_CounterSupply>();
                    TBL_CounterSupply CounterSupply = new TBL_CounterSupply();
                    CounterSupply.Counter_Id = int.Parse(GridViewCounterSupply.CurrentRow.Cells["Counter_Id"].Value.ToString());
                    CounterSupply.CounterSerialNo = GridViewCounterSupply.CurrentRow.Cells["CounterSerialNo"].Value.ToString();
                    Ls.Add(CounterSupply);


                    string str = "";
                    new ViewModel.CounterSupply.CounterSupply().DeleteEntity(Ls, ref str);
                    if (str != "")
                        MSS.Library.Clasess.MSSMessage.MSSMessage_View(0, MSS.Library.Clasess.MSSMessage.MessageType.SError, false, "امکان حذف این مورد در سیستم وجود ندارد", str);
                    else
                        BindData(i - 1);

                }
                catch (System.Exception ex)
                {
                    MSS.Library.Clasess.MSSMessage.MSSMessage_View(0, MSS.Library.Clasess.MSSMessage.MessageType.SError, false, "امکان حذف این مورد در سیستم وجود ندارد", ex.Message);
                }
            }
        }

        private void headerGridCounterSupply_btnRefreshClick(object sender, System.EventArgs e)
        {
            BindData(GridViewCounterSupply.Row);
        }

        #endregion

        private void CounterSupply_UC_Load(object sender, System.EventArgs e)
        {
            BindData(GridViewCounterSupply.Row);
            ParameterSetEvent += new ParameterSetChange(Th_ParameterSetEvent);
        }
        public void Th_ParameterSetEvent()
        {
            BindData(GridViewCounterSupply.Row);
        }

        private void GridViewCounterSupply_SelectionChanged(object sender, System.EventArgs e)
        {
            try
            {
                UserControl_Slave.ParameterSet = new Dictionary<string, object>();
                UserControl_Slave.ParameterSet.Add("Counter_Id", System.Convert.ToInt32(GridViewCounterSupply.CurrentRow.Cells["Counter_Id"].Value));
                UserControl_Slave.ParameterSet.Add("CounterSerialNo", GridViewCounterSupply.CurrentRow.Cells["CounterSerialNo"].Value.ToString());
                UserControl_Slave.ParameterSomeEvent();
            }
            catch { }
        }

        private void GridViewCounterSupply_BindingDataSourceSet(object sender, System.EventArgs e)
        {
            BindData(GridViewCounterSupply.Row);
            GridViewCounterSupply_SelectionChanged(this, null);
        }


    }
}
