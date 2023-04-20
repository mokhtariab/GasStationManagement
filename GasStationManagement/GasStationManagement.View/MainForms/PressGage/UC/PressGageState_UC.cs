using System.Linq;
using System.Collections.Generic;
using GasStationManagement.Model.Basic.DataAccess;
using GasStationManagement.Model.PressGageState;
using MSS.Library.Clasess.FilterClass;

namespace GasStationManagement.View.MainForms.PressGage
{
    public partial class PressGageState_UC : MSS.Library.UserControls.MSSUserControl_UC
    {
        public PressGageState_UC()
        {
            InitializeComponent();
        }

        public void BindData(int RowNumberSet)
        {
            string str = "";
            if (ParameterSet == null)
                GridViewPressGageState.DataSource = new ViewModel.PressGageState.PressGageState().GetList(ref str);
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
                GridViewPressGageState.DataSource = new ViewModel.PressGageState.PressGageState().GetListByFilter(_listFilter, ref str);
            }
            GridViewPressGageState.Row = RowNumberSet;
        }

        
        #region All UI Button

        private void headerGridPressGageState_btnInsertClick(object sender, System.EventArgs e)
        {
            try
            {
                PressGageStateAdd_Frm PressGageStateAdd = null;

                if (ParameterSet.Keys.Contains("GasStation_Id"))
                    PressGageStateAdd = new PressGageStateAdd_Frm(
                        System.Convert.ToInt32(ParameterSet["GasStation_Id"]));
                else
                    PressGageStateAdd = new PressGageStateAdd_Frm(
                        System.Convert.ToInt32(ParameterSet["PressGage_Id"]),
                        ParameterSet["PressGageSerialNo"].ToString());

                PressGageStateAdd.ShowDialog();
                BindData(GridViewPressGageState.RowCount);
            }
            catch { }
        }

        private void headerGridPressGageState_btnEditClick(object sender, System.EventArgs e)
        {
            try
            {
                int i = GridViewPressGageState.Row;

                PressGageStateAdd_Frm PressGageStateAdd = new PressGageStateAdd_Frm(
                    int.Parse(GridViewPressGageState.CurrentRow.Cells["PressGage_Id"].Value.ToString()),
                    GridViewPressGageState.CurrentRow.Cells["PressGageSerialNo"].Value.ToString(),
                    int.Parse(GridViewPressGageState.CurrentRow.Cells["PressGageStateRow"].Value.ToString()));
                PressGageStateAdd.ShowDialog();
                BindData(i);
            }
            catch { }
        }

        private void headerGridPressGageState_btnDeleteClick(object sender, System.EventArgs e)
        {
            if (MSS.Library.Clasess.MSSMessage.MSSMessage_View(0,MSS.Library.Clasess.MSSMessage.MessageType.SConfirmation,true, "آیا به حذف این مورد اطمینان دارید؟"))
            {
                try
                {
                    int i = GridViewPressGageState.Row;

                    List<TBL_PressGageState> Ls = new List<TBL_PressGageState>();
                    TBL_PressGageState PressGageState = new TBL_PressGageState();
                    PressGageState.PressGage_Id = int.Parse(GridViewPressGageState.CurrentRow.Cells["PressGage_Id"].Value.ToString());
                    PressGageState.PressGageSerialNo = GridViewPressGageState.CurrentRow.Cells["PressGageSerialNo"].Value.ToString();
                    PressGageState.PressGageStateRow = int.Parse(GridViewPressGageState.CurrentRow.Cells["PressGageStateRow"].Value.ToString());

                    Ls.Add(PressGageState);


                    string str = "";
                    new ViewModel.PressGageState.PressGageState().DeleteEntity(Ls, ref str);
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

        private void headerGridPressGageState_btnRefreshClick(object sender, System.EventArgs e)
        {
            BindData(GridViewPressGageState.Row);
        }

        #endregion

        private void PressGageState_UC_Load(object sender, System.EventArgs e)
        {
            BindData(GridViewPressGageState.Row);
            ParameterSetEvent += new ParameterSetChange(Th_ParameterSetEvent);
            HeaderGridPressGageState.Visible = HeaderVisible;
        }
        public void Th_ParameterSetEvent()
        {
            BindData(GridViewPressGageState.Row);
        }
        private void GridViewPressGageState_SelectionChanged(object sender, System.EventArgs e)
        {
            try
            {
                UserControl_Slave.ParameterSet = new Dictionary<string, object>();
                UserControl_Slave.ParameterSet.Add("PressGage_Id", System.Convert.ToInt32(GridViewPressGageState.CurrentRow.Cells["PressGage_Id"].Value));
                UserControl_Slave.ParameterSet.Add("PressGageSerialNo", GridViewPressGageState.CurrentRow.Cells["PressGageSerialNo"].Value.ToString());
                UserControl_Slave.ParameterSomeEvent();
            }
            catch { }
        }

        private void GridViewPressGageState_BindingDataSourceSet(object sender, System.EventArgs e)
        {
            BindData(GridViewPressGageState.Row);
            GridViewPressGageState_SelectionChanged(this, null);
        }


    }
}
