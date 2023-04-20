using System.Linq;
using System.Collections.Generic;
using GasStationManagement.Model.Basic.DataAccess;
using GasStationManagement.Model.PressTransSupply;
using GasStationManagement.View.MainForms.PressTrans;
using MSS.Library.Clasess.FilterClass;

namespace GasStationManagement.View.MainForms.PressTrans
{
    public partial class PressTransSupply_UC : MSS.Library.UserControls.MSSUserControl_UC
    {
        public PressTransSupply_UC()
        {
            InitializeComponent();
        }

        public void BindData(int RowNumberSet)
        {
            string str = "";

            if (ParameterSet == null)
                GridViewPressTransSupply.DataSource = new ViewModel.PressTransSupply.PressTransSupply().GetList(ref str);
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
                GridViewPressTransSupply.DataSource = new ViewModel.PressTransSupply.PressTransSupply().GetListByFilter(_listFilter, ref str);
            }
            GridViewPressTransSupply.Row = RowNumberSet;
        }

        
        #region All UI Button

        private void headerGridPressTransSupply_btnInsertClick(object sender, System.EventArgs e)
        {
           try
            {
                PressTransSupplyAdd_Frm PressTransSupply = new PressTransSupplyAdd_Frm(System.Convert.ToInt32(ParameterSet["PressTrans_Id"]));
                //int.Parse(GridViewPressTransSupply.CurrentRow.Cells["PressTrans_Id"].Value.ToString()));
                PressTransSupply.ShowDialog();
                BindData(GridViewPressTransSupply.RowCount);
            }
            catch { }

        }

        private void headerGridPressTransSupply_btnEditClick(object sender, System.EventArgs e)
        {
            try
            {
                int i = GridViewPressTransSupply.Row;

                PressTransSupplyAdd_Frm PressTransSupplyAdd = new PressTransSupplyAdd_Frm(
                    int.Parse(GridViewPressTransSupply.CurrentRow.Cells["PressTrans_Id"].Value.ToString()),
                    GridViewPressTransSupply.CurrentRow.Cells["PressTransSerialNo"].Value.ToString());
                PressTransSupplyAdd.ShowDialog();
                BindData(i);
            }
            catch { }
        }

        private void headerGridPressTransSupply_btnDeleteClick(object sender, System.EventArgs e)
        {
            if (MSS.Library.Clasess.MSSMessage.MSSMessage_View(0, MSS.Library.Clasess.MSSMessage.MessageType.SConfirmation, true, "آیا به حذف این مورد اطمینان دارید؟"))
            {
                try
                {
                    int i = GridViewPressTransSupply.Row;
                    List<TBL_PressTransSupply> Ls = new List<TBL_PressTransSupply>();
                    TBL_PressTransSupply PressTransSupply = new TBL_PressTransSupply();
                    PressTransSupply.PressTrans_Id = int.Parse(GridViewPressTransSupply.CurrentRow.Cells["PressTrans_Id"].Value.ToString());
                    PressTransSupply.PressTransSerialNo = GridViewPressTransSupply.CurrentRow.Cells["PressTransSerialNo"].Value.ToString();
                    Ls.Add(PressTransSupply);


                    string str = "";
                    new ViewModel.PressTransSupply.PressTransSupply().DeleteEntity(Ls, ref str);
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

        private void headerGridPressTransSupply_btnRefreshClick(object sender, System.EventArgs e)
        {
            BindData(GridViewPressTransSupply.Row);
        }

        #endregion

        private void PressTransSupply_UC_Load(object sender, System.EventArgs e)
        {
            BindData(GridViewPressTransSupply.Row);
            ParameterSetEvent += new ParameterSetChange(Th_ParameterSetEvent);
        }
        public void Th_ParameterSetEvent()
        {
            BindData(GridViewPressTransSupply.Row);
        }

        private void GridViewPressTransSupply_SelectionChanged(object sender, System.EventArgs e)
        {
            try
            {
                UserControl_Slave.ParameterSet = new Dictionary<string, object>();
                UserControl_Slave.ParameterSet.Add("PressTrans_Id", System.Convert.ToInt32(GridViewPressTransSupply.CurrentRow.Cells["PressTrans_Id"].Value));
                UserControl_Slave.ParameterSet.Add("PressTransSerialNo", GridViewPressTransSupply.CurrentRow.Cells["PressTransSerialNo"].Value.ToString());
                UserControl_Slave.ParameterSomeEvent();
            }
            catch { }
        }

        private void GridViewPressTransSupply_BindingDataSourceSet(object sender, System.EventArgs e)
        {
            BindData(GridViewPressTransSupply.Row);
            GridViewPressTransSupply_SelectionChanged(this, null);
        }
    }
}
