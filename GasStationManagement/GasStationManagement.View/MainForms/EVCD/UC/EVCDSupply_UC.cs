using System.Linq;
using System.Collections.Generic;
using GasStationManagement.Model.Basic.DataAccess;
using GasStationManagement.Model.EVCDSupply;
using GasStationManagement.View.MainForms.EVCD;
using MSS.Library.Clasess.FilterClass;

namespace GasStationManagement.View.MainForms.EVCD
{
    public partial class EVCDSupply_UC : MSS.Library.UserControls.MSSUserControl_UC
    {
        public EVCDSupply_UC()
        {
            InitializeComponent();
        }


        public void BindData(int RowNumberSet)
        {
            string str = "";
            if (ParameterSet == null)
                GridViewEVCDSupply.DataSource = new ViewModel.EVCDSupply.EVCDSupply().GetList(ref str);
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
                GridViewEVCDSupply.DataSource = new ViewModel.EVCDSupply.EVCDSupply().GetListByFilter(_listFilter, ref str);
            }
            GridViewEVCDSupply.Row = RowNumberSet;
        }

        
        #region All UI Button

        private void headerGridEVCDSupply_btnInsertClick(object sender, System.EventArgs e)
        {
            try
            {
                EVCDSupplyAdd_Frm EVCDSupply = new EVCDSupplyAdd_Frm(System.Convert.ToInt32(ParameterSet["EVCD_Id"]));
                //int.Parse(GridViewEVCDSupply.CurrentRow.Cells["EVCD_Id"].Value.ToString()));
                EVCDSupply.ShowDialog();
                BindData(GridViewEVCDSupply.RowCount);
            }
            catch { }

        }

        private void headerGridEVCDSupply_btnEditClick(object sender, System.EventArgs e)
        {
            try
            {
                int i = GridViewEVCDSupply.Row;

                EVCDSupplyAdd_Frm EVCDSupplyAdd = new EVCDSupplyAdd_Frm(
                    int.Parse(GridViewEVCDSupply.CurrentRow.Cells["EVCD_Id"].Value.ToString()),
                    GridViewEVCDSupply.CurrentRow.Cells["EVCDSerialNo"].Value.ToString());
                EVCDSupplyAdd.ShowDialog();
                BindData(i);
            }
            catch { }
        }

        private void headerGridEVCDSupply_btnDeleteClick(object sender, System.EventArgs e)
        {
            if (MSS.Library.Clasess.MSSMessage.MSSMessage_View(0, MSS.Library.Clasess.MSSMessage.MessageType.SConfirmation, true, "آیا به حذف این مورد اطمینان دارید؟"))
            {
                try
                {
                    int i = GridViewEVCDSupply.Row;
                    List<TBL_EVCDSupply> Ls = new List<TBL_EVCDSupply>();
                    TBL_EVCDSupply EVCDSupply = new TBL_EVCDSupply();
                    EVCDSupply.EVCD_Id = int.Parse(GridViewEVCDSupply.CurrentRow.Cells["EVCD_Id"].Value.ToString());
                    EVCDSupply.EVCDSerialNo = GridViewEVCDSupply.CurrentRow.Cells["EVCDSerialNo"].Value.ToString();
                    Ls.Add(EVCDSupply);


                    string str = "";
                    new ViewModel.EVCDSupply.EVCDSupply().DeleteEntity(Ls, ref str);
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

        private void headerGridEVCDSupply_btnRefreshClick(object sender, System.EventArgs e)
        {
            BindData(GridViewEVCDSupply.Row);
        }

        #endregion

        private void EVCDSupply_UC_Load(object sender, System.EventArgs e)
        {
            BindData(GridViewEVCDSupply.Row);
            ParameterSetEvent += new ParameterSetChange(Th_ParameterSetEvent);
        }
        public void Th_ParameterSetEvent()
        {
            BindData(GridViewEVCDSupply.Row);
        }

        private void GridViewEVCDSupply_SelectionChanged(object sender, System.EventArgs e)
        {
            //EVCDSupplyEvent(int.Parse(GridViewEVCDSupply.CurrentRow.Cells["EVCDSupply_Id"].Value.ToString()),
            //    GridViewEVCDSupply.CurrentRow.Cells["EVCDSupplySerialNo"].Value.ToString());
            try
            {
                UserControl_Slave.ParameterSet = new Dictionary<string, object>();
                UserControl_Slave.ParameterSet.Add("EVCD_Id", System.Convert.ToInt32(GridViewEVCDSupply.CurrentRow.Cells["EVCD_Id"].Value));
                UserControl_Slave.ParameterSet.Add("EVCDSerialNo", GridViewEVCDSupply.CurrentRow.Cells["EVCDSerialNo"].Value.ToString());
                UserControl_Slave.ParameterSomeEvent();
            }
            catch { }
        }

        private void GridViewEVCDSupply_BindingDataSourceSet(object sender, System.EventArgs e)
        {
            BindData(GridViewEVCDSupply.Row);
            GridViewEVCDSupply_SelectionChanged(this, null);
        }

    }
}
