using System.Linq;
using System.Collections.Generic;
using GasStationManagement.Model.Basic.DataAccess;
using GasStationManagement.Model.PressGageSupply;
using GasStationManagement.View.MainForms.PressGage;
using MSS.Library.Clasess.FilterClass;

namespace GasStationManagement.View.MainForms.PressGage
{
    public partial class PressGageSupply_UC : MSS.Library.UserControls.MSSUserControl_UC
    {
        public PressGageSupply_UC()
        {
            InitializeComponent();
        }

        public void BindData(int RowNumberSet)
        {
            string str = "";

            if (ParameterSet == null)
                GridViewPressGageSupply.DataSource = new ViewModel.PressGageSupply.PressGageSupply().GetList(ref str);
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
                GridViewPressGageSupply.DataSource = new ViewModel.PressGageSupply.PressGageSupply().GetListByFilter(_listFilter, ref str);
            }
            GridViewPressGageSupply.Row = RowNumberSet;
        }

        
        #region All UI Button

        private void headerGridPressGageSupply_btnInsertClick(object sender, System.EventArgs e)
        {
            try
            {
                PressGageSupplyAdd_Frm PressGageSupply = new PressGageSupplyAdd_Frm(System.Convert.ToInt32(ParameterSet["PressGage_Id"]));
                PressGageSupply.ShowDialog();
                BindData(GridViewPressGageSupply.RowCount);
            }
            catch { }

        }

        private void headerGridPressGageSupply_btnEditClick(object sender, System.EventArgs e)
        {
            try
            {
                int i = GridViewPressGageSupply.Row;

                PressGageSupplyAdd_Frm PressGageSupplyAdd = new PressGageSupplyAdd_Frm(
                    int.Parse(GridViewPressGageSupply.CurrentRow.Cells["PressGage_Id"].Value.ToString()),
                    GridViewPressGageSupply.CurrentRow.Cells["PressGageSerialNo"].Value.ToString());
                PressGageSupplyAdd.ShowDialog();
                BindData(i);
            }
            catch { }
        }

        private void headerGridPressGageSupply_btnDeleteClick(object sender, System.EventArgs e)
        {
            if (MSS.Library.Clasess.MSSMessage.MSSMessage_View(0, MSS.Library.Clasess.MSSMessage.MessageType.SConfirmation, true, "آیا به حذف این مورد اطمینان دارید؟"))
            {
                try
                {
                    int i = GridViewPressGageSupply.Row;
                    List<TBL_PressGageSupply> Ls = new List<TBL_PressGageSupply>();
                    TBL_PressGageSupply PressGageSupply = new TBL_PressGageSupply();
                    PressGageSupply.PressGage_Id = int.Parse(GridViewPressGageSupply.CurrentRow.Cells["PressGage_Id"].Value.ToString());
                    PressGageSupply.PressGageSerialNo = GridViewPressGageSupply.CurrentRow.Cells["PressGageSerialNo"].Value.ToString();
                    Ls.Add(PressGageSupply);


                    string str = "";
                    new ViewModel.PressGageSupply.PressGageSupply().DeleteEntity(Ls, ref str);
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

        private void headerGridPressGageSupply_btnRefreshClick(object sender, System.EventArgs e)
        {
            BindData(GridViewPressGageSupply.Row);
        }

        #endregion

        private void PressGageSupply_UC_Load(object sender, System.EventArgs e)
        {
            BindData(GridViewPressGageSupply.Row);
            ParameterSetEvent += new ParameterSetChange(Th_ParameterSetEvent);
        }
        public void Th_ParameterSetEvent()
        {
            BindData(GridViewPressGageSupply.Row);
        }

        private void GridViewPressGageSupply_SelectionChanged(object sender, System.EventArgs e)
        {
            try
            {
                UserControl_Slave.ParameterSet = new Dictionary<string, object>();
                UserControl_Slave.ParameterSet.Add("PressGage_Id", System.Convert.ToInt32(GridViewPressGageSupply.CurrentRow.Cells["PressGage_Id"].Value));
                UserControl_Slave.ParameterSet.Add("PressGageSerialNo", GridViewPressGageSupply.CurrentRow.Cells["PressGageSerialNo"].Value.ToString());
                UserControl_Slave.ParameterSomeEvent();
            }
            catch { }
        }

        private void GridViewPressGageSupply_BindingDataSourceSet(object sender, System.EventArgs e)
        {
            BindData(GridViewPressGageSupply.Row);
            GridViewPressGageSupply_SelectionChanged(this, null);
        }

    }
}
