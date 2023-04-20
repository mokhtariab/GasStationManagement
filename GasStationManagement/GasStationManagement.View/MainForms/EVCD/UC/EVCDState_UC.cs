using System.Linq;
using System.Collections.Generic;
using GasStationManagement.Model.Basic.DataAccess;
using GasStationManagement.Model.EVCDState;
using MSS.Library.Clasess.FilterClass;

namespace GasStationManagement.View.MainForms.EVCD
{
    public partial class EVCDState_UC : MSS.Library.UserControls.MSSUserControl_UC
    {
        public EVCDState_UC()
        {
            InitializeComponent();
        }

        public void BindData(int RowNumberSet)
        {
            string str = "";
            if (ParameterSet == null)
                GridViewEVCDState.DataSource = new ViewModel.EVCDState.EVCDState().GetList(ref str);
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
                GridViewEVCDState.DataSource = new ViewModel.EVCDState.EVCDState().GetListByFilter(_listFilter, ref str);
            }
            GridViewEVCDState.Row = RowNumberSet;
        }

        
        #region All UI Button

        private void headerGridEVCDState_btnInsertClick(object sender, System.EventArgs e)
        {
            try
            {
                EVCDStateAdd_Frm EVCDStateAdd = null;

                if (ParameterSet.Keys.Contains("GasStation_Id"))
                    EVCDStateAdd = new EVCDStateAdd_Frm(
                        System.Convert.ToInt32(ParameterSet["GasStation_Id"]));
                else
                    EVCDStateAdd = new EVCDStateAdd_Frm(
                        System.Convert.ToInt32(ParameterSet["EVCD_Id"]),
                        ParameterSet["EVCDSerialNo"].ToString());

                EVCDStateAdd.ShowDialog();
                BindData(GridViewEVCDState.RowCount);
            }
            catch { }
        }

        private void headerGridEVCDState_btnEditClick(object sender, System.EventArgs e)
        {
            try
            {
                int i = GridViewEVCDState.Row;

                EVCDStateAdd_Frm EVCDStateAdd = new EVCDStateAdd_Frm(
                    int.Parse(GridViewEVCDState.CurrentRow.Cells["EVCD_Id"].Value.ToString()),
                    GridViewEVCDState.CurrentRow.Cells["EVCDSerialNo"].Value.ToString(),
                    int.Parse(GridViewEVCDState.CurrentRow.Cells["EVCDStateRow"].Value.ToString()));
                EVCDStateAdd.ShowDialog();
                BindData(i);
            }
            catch { }
        }

        private void headerGridEVCDState_btnDeleteClick(object sender, System.EventArgs e)
        {
            if (MSS.Library.Clasess.MSSMessage.MSSMessage_View(0,MSS.Library.Clasess.MSSMessage.MessageType.SConfirmation,true, "آیا به حذف این مورد اطمینان دارید؟"))
            {
                try
                {
                    int i = GridViewEVCDState.Row;

                    List<TBL_EVCDState> Ls = new List<TBL_EVCDState>();
                    TBL_EVCDState EVCDState = new TBL_EVCDState();
                    EVCDState.EVCD_Id = int.Parse(GridViewEVCDState.CurrentRow.Cells["EVCD_Id"].Value.ToString());
                    EVCDState.EVCDSerialNo = GridViewEVCDState.CurrentRow.Cells["EVCDSerialNo"].Value.ToString();
                    EVCDState.EVCDStateRow = int.Parse(GridViewEVCDState.CurrentRow.Cells["EVCDStateRow"].Value.ToString());

                    Ls.Add(EVCDState);


                    string str = "";
                    new ViewModel.EVCDState.EVCDState().DeleteEntity(Ls, ref str);
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

        private void headerGridEVCDState_btnRefreshClick(object sender, System.EventArgs e)
        {
            BindData(GridViewEVCDState.Row);
        }

        #endregion

        private void EVCDState_UC_Load(object sender, System.EventArgs e)
        {
            BindData(GridViewEVCDState.Row);
            ParameterSetEvent += new ParameterSetChange(Th_ParameterSetEvent);
            HeaderGridEVCDState.Visible = HeaderVisible;
        }
        public void Th_ParameterSetEvent()
        {
            BindData(GridViewEVCDState.Row);
        }

        private void GridViewEVCDState_SelectionChanged(object sender, System.EventArgs e)
        {
            try
            {
                UserControl_Slave.ParameterSet = new Dictionary<string, object>();
                UserControl_Slave.ParameterSet.Add("EVCD_Id", System.Convert.ToInt32(GridViewEVCDState.CurrentRow.Cells["EVCD_Id"].Value));
                UserControl_Slave.ParameterSet.Add("EVCDSerialNo", GridViewEVCDState.CurrentRow.Cells["EVCDSerialNo"].Value.ToString());
                UserControl_Slave.ParameterSomeEvent();
            }
            catch { }
        }

        private void GridViewEVCDState_BindingDataSourceSet(object sender, System.EventArgs e)
        {
            BindData(GridViewEVCDState.Row);
            GridViewEVCDState_SelectionChanged(this, null);
        }


    }
}
