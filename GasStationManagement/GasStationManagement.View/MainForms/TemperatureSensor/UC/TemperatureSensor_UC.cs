using System.Linq;
using System.Collections.Generic;
using GasStationManagement.Model.Basic.DataAccess;
using MSS.Library.Clasess.FilterClass;

namespace GasStationManagement.View.MainForms.TemperatureSensor
{
    public partial class TemperatureSensor_UC : MSS.Library.UserControls.MSSUserControl_UC
    {
        public TemperatureSensor_UC()
        {
            InitializeComponent();
        }
        public void BindData()
        {
            string str = "";
            if (ParameterSet == null)
                GridViewTemperatureSensor.DataSource = new ViewModel.Basic.TemperatureSensor().GetList(ref str);
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
                GridViewTemperatureSensor.DataSource = new ViewModel.Basic.TemperatureSensor().GetListByFilter(_listFilter, ref str);
            }
        }

        
        #region All UI Button

        private void headerGridTemperatureSensor_btnInsertClick(object sender, System.EventArgs e)
        {
            TemperatureSensorAdd_Frm TemperatureSensorAdd = new TemperatureSensorAdd_Frm();
            TemperatureSensorAdd.ShowDialog();
            BindData();
        }

        private void headerGridTemperatureSensor_btnEditClick(object sender, System.EventArgs e)
        {
            TemperatureSensorAdd_Frm TemperatureSensorAdd = new TemperatureSensorAdd_Frm(int.Parse(GridViewTemperatureSensor.CurrentRow.Cells["Id"].Value.ToString()));
            TemperatureSensorAdd.ShowDialog();
            BindData();
        }

        private void headerGridTemperatureSensor_btnDeleteClick(object sender, System.EventArgs e)
        {
            if (MSS.Library.Clasess.MSSMessage.MSSMessage_View(0,MSS.Library.Clasess.MSSMessage.MessageType.SConfirmation,true, "آیا به حذف این مورد اطمینان دارید؟"))
            {
                try
                {
                    List<TBL_TemperatureSensor> Ls = new List<TBL_TemperatureSensor>();
                    TBL_TemperatureSensor TemperatureSensor = new TBL_TemperatureSensor();
                    TemperatureSensor.Id = int.Parse(GridViewTemperatureSensor.CurrentRow.Cells["Id"].Value.ToString());
                    TemperatureSensor.Brand = GridViewTemperatureSensor.CurrentRow.Cells["Brand"].Value.ToString();
                    TemperatureSensor.SensorType = GridViewTemperatureSensor.CurrentRow.Cells["SensorType"].Value.ToString();
                    TemperatureSensor.WireCount = int.Parse(GridViewTemperatureSensor.CurrentRow.Cells["WireCount"].Value.ToString());
                    TemperatureSensor.PacketLength = double.Parse(GridViewTemperatureSensor.CurrentRow.Cells["PacketLength"].Value.ToString());
                    TemperatureSensor.TMin = int.Parse(GridViewTemperatureSensor.CurrentRow.Cells["TMin"].Value.ToString());
                    TemperatureSensor.TMax = int.Parse(GridViewTemperatureSensor.CurrentRow.Cells["TMax"].Value.ToString());
                    TemperatureSensor.Description = GridViewTemperatureSensor.CurrentRow.Cells["Description"].Value.ToString();
                    TemperatureSensor.IsActive = bool.Parse(GridViewTemperatureSensor.CurrentRow.Cells["IsActive"].Value.ToString());
                    Ls.Add(TemperatureSensor);


                    string str = "";
                    new ViewModel.Basic.TemperatureSensor().DeleteEntity(Ls, ref str);
                }
                catch 
                {
                    MSS.Library.Clasess.MSSMessage.MSSMessage_View("امکان حذف این مورد در سیستم وجود ندارد",MSS.Library.Clasess.MSSMessage.MessageType.SError);
                }
            }
            BindData();
        }

        private void headerGridTemperatureSensor_btnRefreshClick(object sender, System.EventArgs e)
        {
            BindData();
        }

        #endregion

        private void TemperatureSensor_UC_Load(object sender, System.EventArgs e)
        {
            BindData();
            ParameterSetEvent += new ParameterSetChange(Th_ParameterSetEvent);
        }
        public void Th_ParameterSetEvent()
        {
            BindData();
        }

        private void GridViewTemperatureSensor_SelectionChanged(object sender, System.EventArgs e)
        {
            //TemperatureSensorEvent(int.Parse(GridViewTemperatureSensor.CurrentRow.Cells["Id"].Value.ToString()));
            try
            {
                UserControl_Slave.ParameterSet = new Dictionary<string, object>();
                UserControl_Slave.ParameterSet.Add("TemperatureSensor_Id", System.Convert.ToInt32(GridViewTemperatureSensor.CurrentRow.Cells["Id"].Value));
                UserControl_Slave.ParameterSomeEvent();
            }
            catch { }
        }


    }
}
