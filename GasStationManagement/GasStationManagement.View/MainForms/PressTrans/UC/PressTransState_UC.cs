using System.Linq;
using System.Collections.Generic;
using GasStationManagement.Model.Basic.DataAccess;
using GasStationManagement.Model.PressTransState;
using MSS.Library.Clasess.FilterClass;

namespace GasStationManagement.View.MainForms.PressTrans
{
    public partial class PressTransState_UC : MSS.Library.UserControls.MSSUserControl_UC
    {
        public PressTransState_UC()
        {
            InitializeComponent();
        }

        public void BindData(int RowNumberSet)
        {
            string str = "";
            if (ParameterSet == null)
                GridViewPressTransState.DataSource = new ViewModel.PressTransState.PressTransState().GetList(ref str);
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
                GridViewPressTransState.DataSource = new ViewModel.PressTransState.PressTransState().GetListByFilter(_listFilter, ref str);
            }
            GridViewPressTransState.Row = RowNumberSet;
        }

        
        #region All UI Button

        private void headerGridPressTransState_btnInsertClick(object sender, System.EventArgs e)
        {
            try
            {
                PressTransStateAdd_Frm PressTransStateAdd = null;

                if (ParameterSet.Keys.Contains("GasStation_Id"))
                    PressTransStateAdd = new PressTransStateAdd_Frm(
                        System.Convert.ToInt32(ParameterSet["GasStation_Id"]));
                else
                    PressTransStateAdd = new PressTransStateAdd_Frm(
                        System.Convert.ToInt32(ParameterSet["PressTrans_Id"]),
                        ParameterSet["PressTransSerialNo"].ToString());

                PressTransStateAdd.ShowDialog();
                BindData(GridViewPressTransState.RowCount);
            }
            catch { }
        }

        private void headerGridPressTransState_btnEditClick(object sender, System.EventArgs e)
        {
            try
            {
                int i = GridViewPressTransState.Row;

                PressTransStateAdd_Frm PressTransStateAdd = new PressTransStateAdd_Frm(
                    int.Parse(GridViewPressTransState.CurrentRow.Cells["PressTrans_Id"].Value.ToString()),
                    GridViewPressTransState.CurrentRow.Cells["PressTransSerialNo"].Value.ToString(),
                    int.Parse(GridViewPressTransState.CurrentRow.Cells["PressTransStateRow"].Value.ToString()));
                PressTransStateAdd.ShowDialog();
                BindData(i);
            }
            catch { }
        }

        private void headerGridPressTransState_btnDeleteClick(object sender, System.EventArgs e)
        {
            if (MSS.Library.Clasess.MSSMessage.MSSMessage_View(0,MSS.Library.Clasess.MSSMessage.MessageType.SConfirmation,true, "آیا به حذف این مورد اطمینان دارید؟"))
            {
                try
                {
                    int i = GridViewPressTransState.Row;

                    List<TBL_PressTransState> Ls = new List<TBL_PressTransState>();
                    TBL_PressTransState PressTransState = new TBL_PressTransState();
                    PressTransState.PressTrans_Id = int.Parse(GridViewPressTransState.CurrentRow.Cells["PressTrans_Id"].Value.ToString());
                    PressTransState.PressTransSerialNo = GridViewPressTransState.CurrentRow.Cells["PressTransSerialNo"].Value.ToString();
                    PressTransState.PressTransStateRow = int.Parse(GridViewPressTransState.CurrentRow.Cells["PressTransStateRow"].Value.ToString());

                    Ls.Add(PressTransState);


                    string str = "";
                    new ViewModel.PressTransState.PressTransState().DeleteEntity(Ls, ref str);
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

        private void headerGridPressTransState_btnRefreshClick(object sender, System.EventArgs e)
        {
            BindData(GridViewPressTransState.Row);
        }

        #endregion

        private void PressTransState_UC_Load(object sender, System.EventArgs e)
        {
            BindData(GridViewPressTransState.Row);
            ParameterSetEvent += new ParameterSetChange(Th_ParameterSetEvent);
            HeaderGridPressTransState.Visible = HeaderVisible;
        }
        public void Th_ParameterSetEvent()
        {
            BindData(GridViewPressTransState.Row);
        }

        private void GridViewPressTransState_SelectionChanged(object sender, System.EventArgs e)
        {
            try
            {
                UserControl_Slave.ParameterSet = new Dictionary<string, object>();
                UserControl_Slave.ParameterSet.Add("PressTrans_Id", System.Convert.ToInt32(GridViewPressTransState.CurrentRow.Cells["PressTrans_Id"].Value));
                UserControl_Slave.ParameterSet.Add("PressTransSerialNo", GridViewPressTransState.CurrentRow.Cells["PressTransSerialNo"].Value.ToString());
                UserControl_Slave.ParameterSomeEvent();
            }
            catch { }
        }

        private void GridViewPressTransState_BindingDataSourceSet(object sender, System.EventArgs e)
        {
            BindData(GridViewPressTransState.Row);
            GridViewPressTransState_SelectionChanged(this, null);
        }


    }
}
