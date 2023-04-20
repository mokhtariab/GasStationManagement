using System.Linq;
using System.Collections.Generic;
using GasStationManagement.Model.Basic.DataAccess;
using GasStationManagement.Model.TemTransSupply;
using GasStationManagement.View.MainForms.TemTrans;
using MSS.Library.Clasess.FilterClass;

namespace GasStationManagement.View.MainForms.TemTrans
{
    public partial class TemTransSupply_UC : MSS.Library.UserControls.MSSUserControl_UC
    {
        public TemTransSupply_UC()
        {
            InitializeComponent();
        }

        public void BindData(int RowNumberSet)
        {
            string str = "";
            if (ParameterSet == null)
                GridViewTemTransSupply.DataSource = new ViewModel.TemTransSupply.TemTransSupply().GetList(ref str);
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
                GridViewTemTransSupply.DataSource = new ViewModel.TemTransSupply.TemTransSupply().GetListByFilter(_listFilter, ref str);
            }
            GridViewTemTransSupply.Row = RowNumberSet;
        }

        
        #region All UI Button

        private void headerGridTemTransSupply_btnInsertClick(object sender, System.EventArgs e)
        {
            try
            {
                TemTransSupplyAdd_Frm TemTransSupply = new TemTransSupplyAdd_Frm(System.Convert.ToInt32(ParameterSet["TemTrans_Id"]));
                TemTransSupply.ShowDialog();
                BindData(GridViewTemTransSupply.RowCount);
            }
            catch { }

        }

        private void headerGridTemTransSupply_btnEditClick(object sender, System.EventArgs e)
        {
            try
            {
                int i = GridViewTemTransSupply.Row;

                TemTransSupplyAdd_Frm TemTransSupplyAdd = new TemTransSupplyAdd_Frm(
                    int.Parse(GridViewTemTransSupply.CurrentRow.Cells["TemTrans_Id"].Value.ToString()),
                    GridViewTemTransSupply.CurrentRow.Cells["TemTransSerialNo"].Value.ToString());
                TemTransSupplyAdd.ShowDialog();
                BindData(i);
            }
            catch { }
        }

        private void headerGridTemTransSupply_btnDeleteClick(object sender, System.EventArgs e)
        {
            if (MSS.Library.Clasess.MSSMessage.MSSMessage_View(0, MSS.Library.Clasess.MSSMessage.MessageType.SConfirmation, true, "آیا به حذف این مورد اطمینان دارید؟"))
            {
                try
                {
                    int i = GridViewTemTransSupply.Row;
                    List<TBL_TemTransSupply> Ls = new List<TBL_TemTransSupply>();
                    TBL_TemTransSupply TemTransSupply = new TBL_TemTransSupply();
                    TemTransSupply.TemTrans_Id = int.Parse(GridViewTemTransSupply.CurrentRow.Cells["TemTrans_Id"].Value.ToString());
                    TemTransSupply.TemTransSerialNo = GridViewTemTransSupply.CurrentRow.Cells["TemTransSerialNo"].Value.ToString();
                    Ls.Add(TemTransSupply);


                    string str = "";
                    new ViewModel.TemTransSupply.TemTransSupply().DeleteEntity(Ls, ref str);
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

        private void headerGridTemTransSupply_btnRefreshClick(object sender, System.EventArgs e)
        {
            BindData(GridViewTemTransSupply.Row);
        }

        #endregion

        private void TemTransSupply_UC_Load(object sender, System.EventArgs e)
        {
            BindData(GridViewTemTransSupply.Row);
            ParameterSetEvent += new ParameterSetChange(Th_ParameterSetEvent);
        }
        public void Th_ParameterSetEvent()
        {
            BindData(GridViewTemTransSupply.Row);
        }

        private void GridViewTemTransSupply_SelectionChanged(object sender, System.EventArgs e)
        {
            try
            {
                UserControl_Slave.ParameterSet = new Dictionary<string, object>();
                UserControl_Slave.ParameterSet.Add("TemTrans_Id", int.Parse(GridViewTemTransSupply.CurrentRow.Cells["TemTrans_Id"].Value.ToString()));
                UserControl_Slave.ParameterSet.Add("TemTransSerialNo", GridViewTemTransSupply.CurrentRow.Cells["TemTransSerialNo"].Value.ToString());
                UserControl_Slave.ParameterSomeEvent();
            }
            catch { }
        }

        private void GridViewTemTransSupply_BindingDataSourceSet(object sender, System.EventArgs e)
        {
            BindData(GridViewTemTransSupply.Row);
            GridViewTemTransSupply_SelectionChanged(this, null);
        }
    }
}
