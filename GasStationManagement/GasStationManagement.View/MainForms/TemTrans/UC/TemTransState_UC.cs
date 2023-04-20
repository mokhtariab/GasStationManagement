using System.Linq;
using System.Collections.Generic;
using GasStationManagement.Model.Basic.DataAccess;
using GasStationManagement.Model.TemTransState;
using MSS.Library.Clasess.FilterClass;

namespace GasStationManagement.View.MainForms.TemTrans
{
    public partial class TemTransState_UC : MSS.Library.UserControls.MSSUserControl_UC
    {
        public TemTransState_UC()
        {
            InitializeComponent();
        }

        public void BindData(int RowNumberSet)
        {
            string str = "";
            if (ParameterSet == null)
                GridViewTemTransState.DataSource = new ViewModel.TemTransState.TemTransState().GetList(ref str);
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
                GridViewTemTransState.DataSource = new ViewModel.TemTransState.TemTransState().GetListByFilter(_listFilter, ref str);
            }
            GridViewTemTransState.Row = RowNumberSet;
        }

        
        #region All UI Button

        private void headerGridTemTransState_btnInsertClick(object sender, System.EventArgs e)
        {
            try
            {
                TemTransStateAdd_Frm TemTransStateAdd = null;

                if (ParameterSet.Keys.Contains("GasStation_Id"))
                    TemTransStateAdd = new TemTransStateAdd_Frm(
                        System.Convert.ToInt32(ParameterSet["GasStation_Id"]));
                else
                    TemTransStateAdd = new TemTransStateAdd_Frm(
                        System.Convert.ToInt32(ParameterSet["TemTrans_Id"]),
                        ParameterSet["TemTransSerialNo"].ToString());

                TemTransStateAdd.ShowDialog();
                BindData(GridViewTemTransState.RowCount);
            }
            catch { }
        }

        private void headerGridTemTransState_btnEditClick(object sender, System.EventArgs e)
        {
            try
            {
                int i = GridViewTemTransState.Row;

                TemTransStateAdd_Frm TemTransStateAdd = new TemTransStateAdd_Frm(
                    int.Parse(GridViewTemTransState.CurrentRow.Cells["TemTrans_Id"].Value.ToString()),
                    GridViewTemTransState.CurrentRow.Cells["TemTransSerialNo"].Value.ToString(),
                    int.Parse(GridViewTemTransState.CurrentRow.Cells["TemTransStateRow"].Value.ToString()));
                TemTransStateAdd.ShowDialog();
                BindData(i);
            }
            catch { }
        }

        private void headerGridTemTransState_btnDeleteClick(object sender, System.EventArgs e)
        {
            if (MSS.Library.Clasess.MSSMessage.MSSMessage_View(0,MSS.Library.Clasess.MSSMessage.MessageType.SConfirmation,true, "آیا به حذف این مورد اطمینان دارید؟"))
            {
                try
                {
                    int i = GridViewTemTransState.Row;

                    List<TBL_TemTransState> Ls = new List<TBL_TemTransState>();
                    TBL_TemTransState TemTransState = new TBL_TemTransState();
                    TemTransState.TemTrans_Id = int.Parse(GridViewTemTransState.CurrentRow.Cells["TemTrans_Id"].Value.ToString());
                    TemTransState.TemTransSerialNo = GridViewTemTransState.CurrentRow.Cells["TemTransSerialNo"].Value.ToString();
                    TemTransState.TemTransStateRow = int.Parse(GridViewTemTransState.CurrentRow.Cells["TemTransStateRow"].Value.ToString());

                    Ls.Add(TemTransState);


                    string str = "";
                    new ViewModel.TemTransState.TemTransState().DeleteEntity(Ls, ref str);
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

        private void headerGridTemTransState_btnRefreshClick(object sender, System.EventArgs e)
        {
            BindData(GridViewTemTransState.Row);
        }

        #endregion

        private void TemTransState_UC_Load(object sender, System.EventArgs e)
        {
            BindData(GridViewTemTransState.Row);
            ParameterSetEvent += new ParameterSetChange(Th_ParameterSetEvent);
            HeaderGridTemTransState.Visible = HeaderVisible;
        }
        public void Th_ParameterSetEvent()
        {
            BindData(GridViewTemTransState.Row);
        }

        private void GridViewTemTransState_SelectionChanged(object sender, System.EventArgs e)
        {
            try
            {
                UserControl_Slave.ParameterSet = new Dictionary<string, object>();
                UserControl_Slave.ParameterSet.Add("TemTrans_Id", System.Convert.ToInt32(GridViewTemTransState.CurrentRow.Cells["TemTrans_Id"].Value));
                UserControl_Slave.ParameterSet.Add("TemTransSerialNo", GridViewTemTransState.CurrentRow.Cells["TemTransSerialNo"].Value.ToString());
                UserControl_Slave.ParameterSomeEvent();
            }
            catch { }
        }

        private void GridViewTemTransState_BindingDataSourceSet(object sender, System.EventArgs e)
        {
            BindData(GridViewTemTransState.Row);
            GridViewTemTransState_SelectionChanged(this, null);
        }


    }
}
