using System.Linq;
using System.Collections.Generic;
using GasStationManagement.Model.Basic.DataAccess;

namespace GasStationManagement.View.MainForms.Counter
{
    public partial class CounterState_UC : System.Windows.Forms.UserControl
    {
        public CounterState_UC()
        {
            InitializeComponent();
        }

        //public delegate bool CounterStateDelegate(int Id, string CounterSerialNo);
        //public event CounterStateDelegate CounterStateEvent;
        
        bool CounterEvent(int id)
        {
            BindData(id);
            return true;
        }
        public void BindData(int id)
        {
            string str = "";
            GridViewCounterState.DataSource = new ViewModel.Basic.Counter().GetListByID(id,ref str);
        }

        
        #region All UI Button

        private void headerGridCounter_btnInsertClick(object sender, System.EventArgs e)
        {
            CounterAdd_Frm CounterAdd = new CounterAdd_Frm();
            CounterAdd.ShowDialog();
            BindData(int.Parse(GridViewCounterState.CurrentRow.Cells["Counter_Id"].Value.ToString()));
        }

        private void headerGridCounter_btnEditClick(object sender, System.EventArgs e)
        {
            CounterAdd_Frm CounterAdd = new CounterAdd_Frm(byte.Parse(GridViewCounterState.CurrentRow.Cells["ID"].Value.ToString()));
            CounterAdd.ShowDialog();
            BindData(int.Parse(GridViewCounterState.CurrentRow.Cells["Counter_Id"].Value.ToString()));
        }

        private void headerGridCounter_btnDeleteClick(object sender, System.EventArgs e)
        {
            if (MSS.Library.Clasess.MSSMessage.MSSMessage_View(0,MSS.Library.Clasess.MSSMessage.MessageType.SConfirmation,true, "آیا به حذف این مورد اطمینان دارید؟"))
            {
                try
                {
                    List<TBL_Counter> Ls = new List<TBL_Counter>();
                    TBL_Counter Counter = new TBL_Counter();
                    Counter.Id = int.Parse(GridViewCounterState.CurrentRow.Cells["Id"].Value.ToString());
                    Counter.Brand = GridViewCounterState.CurrentRow.Cells["Brand"].Value.ToString();
                    Counter.Size = double.Parse(GridViewCounterState.CurrentRow.Cells["Size"].Value.ToString());
                    Counter.Class = GridViewCounterState.CurrentRow.Cells["Class"].Value.ToString();
                    Counter.Grate = int.Parse(GridViewCounterState.CurrentRow.Cells["Grate"].Value.ToString());
                    Counter.CalibrationDuration = int.Parse(GridViewCounterState.CurrentRow.Cells["CalibrationDuration"].Value.ToString());
                    Counter.Description = GridViewCounterState.CurrentRow.Cells["Description"].Value.ToString();
                    Counter.IsActive = bool.Parse(GridViewCounterState.CurrentRow.Cells["IsActive"].Value.ToString());
                    Ls.Add(Counter);


                    string str = "";
                    new ViewModel.Basic.Counter().DeleteEntity(Ls, ref str);
                }
                catch 
                {
                    MSS.Library.Clasess.MSSMessage.MSSMessage_View("امکان حذف این مورد در سیستم وجود ندارد",MSS.Library.Clasess.MSSMessage.MessageType.SError);
                }
            }
            BindData(int.Parse(GridViewCounterState.CurrentRow.Cells["Counter_Id"].Value.ToString()));
        }

        private void headerGridCounter_btnRefreshClick(object sender, System.EventArgs e)
        {
            BindData(int.Parse(GridViewCounterState.CurrentRow.Cells["Counter_Id"].Value.ToString()));
        }

        #endregion

        private void CounterState_UC_Load(object sender, System.EventArgs e)
        {
            BindData(int.Parse(GridViewCounterState.CurrentRow.Cells["Counter_Id"].Value.ToString()));
        }

        private void GridViewCounter_SelectionChanged(object sender, System.EventArgs e)
        {
            //CounterStateEvent(int.Parse(GridViewCounterState.CurrentRow.Cells["Counter_Id"].Value.ToString()),
            //    GridViewCounterState.CurrentRow.Cells["CounterSerialNo"].Value.ToString());
        }


    }
}
