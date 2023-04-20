using System.Linq;
using System.Collections.Generic;
using GasStationManagement.Model.Basic.DataAccess;
using GasStationManagement.Model.TemGageState;
using MSS.Library.Clasess.FilterClass;

namespace GasStationManagement.View.MainForms.TemGage
{
    public partial class TemGageState_UC : MSS.Library.UserControls.MSSUserControl_UC
    {
        public TemGageState_UC()
        {
            InitializeComponent();
        }

        public void BindData(int RowNumberSet)
        {
            string str = "";
            if (ParameterSet == null)
                GridViewTemGageState.DataSource = new ViewModel.TemGageState.TemGageState().GetList(ref str);
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
                GridViewTemGageState.DataSource = new ViewModel.TemGageState.TemGageState().GetListByFilter(_listFilter, ref str);
            }
            GridViewTemGageState.Row = RowNumberSet;
        }

        
        #region All UI Button

        private void headerGridTemGageState_btnInsertClick(object sender, System.EventArgs e)
        {
            try
            {
                TemGageStateAdd_Frm TemGageStateAdd = null;

                if (ParameterSet.Keys.Contains("GasStation_Id"))
                    TemGageStateAdd = new TemGageStateAdd_Frm(
                        System.Convert.ToInt32(ParameterSet["GasStation_Id"]));
                else
                    TemGageStateAdd = new TemGageStateAdd_Frm(
                        System.Convert.ToInt32(ParameterSet["TemGage_Id"]),
                        ParameterSet["TemGageSerialNo"].ToString());

                TemGageStateAdd.ShowDialog();
                BindData(GridViewTemGageState.RowCount);
            }
            catch { }
        }

        private void headerGridTemGageState_btnEditClick(object sender, System.EventArgs e)
        {
            try
            {
                int i = GridViewTemGageState.Row;

                TemGageStateAdd_Frm TemGageStateAdd = new TemGageStateAdd_Frm(
                    int.Parse(GridViewTemGageState.CurrentRow.Cells["TemGage_Id"].Value.ToString()),
                    GridViewTemGageState.CurrentRow.Cells["TemGageSerialNo"].Value.ToString(),
                    int.Parse(GridViewTemGageState.CurrentRow.Cells["TemGageStateRow"].Value.ToString()));
                TemGageStateAdd.ShowDialog();
                BindData(i);
            }
            catch { }
        }

        private void headerGridTemGageState_btnDeleteClick(object sender, System.EventArgs e)
        {
            if (MSS.Library.Clasess.MSSMessage.MSSMessage_View(0,MSS.Library.Clasess.MSSMessage.MessageType.SConfirmation,true, "آیا به حذف این مورد اطمینان دارید؟"))
            {
                try
                {
                    int i = GridViewTemGageState.Row;

                    List<TBL_TemGageState> Ls = new List<TBL_TemGageState>();
                    TBL_TemGageState TemGageState = new TBL_TemGageState();
                    TemGageState.TemGage_Id = int.Parse(GridViewTemGageState.CurrentRow.Cells["TemGage_Id"].Value.ToString());
                    TemGageState.TemGageSerialNo = GridViewTemGageState.CurrentRow.Cells["TemGageSerialNo"].Value.ToString();
                    TemGageState.TemGageStateRow = int.Parse(GridViewTemGageState.CurrentRow.Cells["TemGageStateRow"].Value.ToString());

                    Ls.Add(TemGageState);


                    string str = "";
                    new ViewModel.TemGageState.TemGageState().DeleteEntity(Ls, ref str);
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

        private void headerGridTemGageState_btnRefreshClick(object sender, System.EventArgs e)
        {
            BindData(GridViewTemGageState.Row);
        }

        #endregion

        private void TemGageState_UC_Load(object sender, System.EventArgs e)
        {
            BindData(GridViewTemGageState.Row);
            ParameterSetEvent += new ParameterSetChange(Th_ParameterSetEvent);
            HeaderGridTemGageState.Visible = HeaderVisible;
        }
        public void Th_ParameterSetEvent()
        {
            BindData(GridViewTemGageState.Row);
        }

        private void GridViewTemGageState_SelectionChanged(object sender, System.EventArgs e)
        {
            try
            {
                UserControl_Slave.ParameterSet = new Dictionary<string, object>();
                UserControl_Slave.ParameterSet.Add("TemGage_Id", System.Convert.ToInt32(GridViewTemGageState.CurrentRow.Cells["TemGage_Id"].Value));
                UserControl_Slave.ParameterSet.Add("TemGageSerialNo", GridViewTemGageState.CurrentRow.Cells["TemGageSerialNo"].Value.ToString());
                UserControl_Slave.ParameterSomeEvent();
            }
            catch { }
        }

        private void GridViewTemGageState_BindingDataSourceSet(object sender, System.EventArgs e)
        {
            BindData(GridViewTemGageState.Row);
            GridViewTemGageState_SelectionChanged(this, null);
        }


    }
}
