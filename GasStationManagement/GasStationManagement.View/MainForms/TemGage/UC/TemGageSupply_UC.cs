using System.Linq;
using System.Collections.Generic;
using GasStationManagement.Model.Basic.DataAccess;
using GasStationManagement.Model.TemGageSupply;
using GasStationManagement.View.MainForms.TemGage;
using MSS.Library.Clasess.FilterClass;

namespace GasStationManagement.View.MainForms.TemGage
{
    public partial class TemGageSupply_UC : MSS.Library.UserControls.MSSUserControl_UC
    {
        public TemGageSupply_UC()
        {
            InitializeComponent();
        }
        public void BindData(int RowNumberSet)
        {
            string str = "";
            if (ParameterSet == null)
                GridViewTemGageSupply.DataSource = new ViewModel.TemGageSupply.TemGageSupply().GetList(ref str);
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
                GridViewTemGageSupply.DataSource = new ViewModel.TemGageSupply.TemGageSupply().GetListByFilter(_listFilter, ref str);
            }
            GridViewTemGageSupply.Row = RowNumberSet;
        }

        
        #region All UI Button

        private void headerGridTemGageSupply_btnInsertClick(object sender, System.EventArgs e)
        {
            try
            {
                TemGageSupplyAdd_Frm TemGageSupply = new TemGageSupplyAdd_Frm(System.Convert.ToInt32(ParameterSet["TemGage_Id"]));
                //int.Parse(GridViewTemGageSupply.CurrentRow.Cells["TemGage_Id"].Value.ToString()));
                TemGageSupply.ShowDialog();
                BindData(GridViewTemGageSupply.RowCount);
            }
            catch { }

        }

        private void headerGridTemGageSupply_btnEditClick(object sender, System.EventArgs e)
        {
            try
            {
                int i = GridViewTemGageSupply.Row;

                TemGageSupplyAdd_Frm TemGageSupplyAdd = new TemGageSupplyAdd_Frm(
                    int.Parse(GridViewTemGageSupply.CurrentRow.Cells["TemGage_Id"].Value.ToString()),
                    GridViewTemGageSupply.CurrentRow.Cells["TemGageSerialNo"].Value.ToString());
                TemGageSupplyAdd.ShowDialog();
                BindData(i);
            }
            catch { }
        }

        private void headerGridTemGageSupply_btnDeleteClick(object sender, System.EventArgs e)
        {
            if (MSS.Library.Clasess.MSSMessage.MSSMessage_View(0, MSS.Library.Clasess.MSSMessage.MessageType.SConfirmation, true, "آیا به حذف این مورد اطمینان دارید؟"))
            {
                try
                {
                    int i = GridViewTemGageSupply.Row;
                    List<TBL_TemGageSupply> Ls = new List<TBL_TemGageSupply>();
                    TBL_TemGageSupply TemGageSupply = new TBL_TemGageSupply();
                    TemGageSupply.TemGage_Id = int.Parse(GridViewTemGageSupply.CurrentRow.Cells["TemGage_Id"].Value.ToString());
                    TemGageSupply.TemGageSerialNo = GridViewTemGageSupply.CurrentRow.Cells["TemGageSerialNo"].Value.ToString();
                    Ls.Add(TemGageSupply);


                    string str = "";
                    new ViewModel.TemGageSupply.TemGageSupply().DeleteEntity(Ls, ref str);
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

        private void headerGridTemGageSupply_btnRefreshClick(object sender, System.EventArgs e)
        {
            BindData(GridViewTemGageSupply.Row);
        }

        #endregion

        private void TemGageSupply_UC_Load(object sender, System.EventArgs e)
        {
            BindData(GridViewTemGageSupply.Row);
            ParameterSetEvent += new ParameterSetChange(Th_ParameterSetEvent);
        }
        public void Th_ParameterSetEvent()
        {
            BindData(GridViewTemGageSupply.Row);
        }

        private void GridViewTemGageSupply_SelectionChanged(object sender, System.EventArgs e)
        {
            try
            {
                UserControl_Slave.ParameterSet = new Dictionary<string, object>();
                UserControl_Slave.ParameterSet.Add("TemGage_Id", System.Convert.ToInt32(GridViewTemGageSupply.CurrentRow.Cells["TemGage_Id"].Value));
                UserControl_Slave.ParameterSet.Add("TemGageSerialNo", GridViewTemGageSupply.CurrentRow.Cells["TemGageSerialNo"].Value.ToString());
                UserControl_Slave.ParameterSomeEvent();
            }
            catch { }
        }

        private void GridViewTemGageSupply_BindingDataSourceSet(object sender, System.EventArgs e)
        {
            BindData(GridViewTemGageSupply.Row);
            GridViewTemGageSupply_SelectionChanged(this, null);
        }
    }
}
