using System.Linq;
using System.Collections.Generic;
using GasStationManagement.Model.Basic.DataAccess;

namespace GasStationManagement.View.MainForms.Counter
{
    public partial class Counter_UC : System.Windows.Forms.UserControl
    {
        public Counter_UC()
        {
            InitializeComponent();
        }

        //public delegate bool CounterDelegate(int Id);
        //public event CounterDelegate CounterEvent;

        public void BindData()
        {
            string str = "";
            GridViewCounter.DataSource = new ViewModel.Basic.Counter().GetList(ref str);
        }

        
        #region All UI Button

        private void headerGridCounter_btnInsertClick(object sender, System.EventArgs e)
        {
            CounterAdd_Frm CounterAdd = new CounterAdd_Frm();
            CounterAdd.ShowDialog();
            BindData();
        }

        private void headerGridCounter_btnEditClick(object sender, System.EventArgs e)
        {
            CounterAdd_Frm CounterAdd = new CounterAdd_Frm(byte.Parse(GridViewCounter.CurrentRow.Cells["ID"].Value.ToString()));
            CounterAdd.ShowDialog();
            BindData();
        }

        private void headerGridCounter_btnDeleteClick(object sender, System.EventArgs e)
        {
            if (MSS.Library.Clasess.MSSMessage.MSSMessage_View(0,MSS.Library.Clasess.MSSMessage.MessageType.SConfirmation,true, "آیا به حذف این مورد اطمینان دارید؟"))
            {
                try
                {
                    List<TBL_Counter> Ls = new List<TBL_Counter>();
                    TBL_Counter Counter = new TBL_Counter();
                    Counter.Id = int.Parse(GridViewCounter.CurrentRow.Cells["Id"].Value.ToString());
                    Counter.Brand = GridViewCounter.CurrentRow.Cells["Brand"].Value.ToString();
                    Counter.Size = double.Parse(GridViewCounter.CurrentRow.Cells["Size"].Value.ToString());
                    Counter.Class = GridViewCounter.CurrentRow.Cells["Class"].Value.ToString();
                    Counter.Grate = int.Parse(GridViewCounter.CurrentRow.Cells["Grate"].Value.ToString());
                    Counter.CalibrationDuration = int.Parse(GridViewCounter.CurrentRow.Cells["CalibrationDuration"].Value.ToString());
                    Counter.Description = GridViewCounter.CurrentRow.Cells["Description"].Value.ToString();
                    Counter.IsActive = bool.Parse(GridViewCounter.CurrentRow.Cells["IsActive"].Value.ToString());
                    Ls.Add(Counter);


                    string str = "";
                    new ViewModel.Basic.Counter().DeleteEntity(Ls, ref str);
                }
                catch 
                {
                    MSS.Library.Clasess.MSSMessage.MSSMessage_View("امکان حذف این مورد در سیستم وجود ندارد",MSS.Library.Clasess.MSSMessage.MessageType.SError);
                }
            }
            BindData();
        }

        private void headerGridCounter_btnRefreshClick(object sender, System.EventArgs e)
        {
            BindData();
        }

        #endregion

        private void Counter_UC_Load(object sender, System.EventArgs e)
        {
            BindData();
        }

        private void GridViewCounter_SelectionChanged(object sender, System.EventArgs e)
        {
            //CounterEvent(int.Parse(GridViewCounter.CurrentRow.Cells["Id"].Value.ToString()));
        }


    }
}
