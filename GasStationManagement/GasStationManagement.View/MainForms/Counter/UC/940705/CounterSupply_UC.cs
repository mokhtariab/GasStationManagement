using System.Linq;
using System.Collections.Generic;
using GasStationManagement.Model.Basic.DataAccess;
using GasStationManagement.Model.CounterSupply;
using GasStationManagement.View.MainForms.Counter;

namespace GasStationManagement.View.MainForms.Counter
{
    public partial class CounterSupply_UC : System.Windows.Forms.UserControl
    {
        public CounterSupply_UC()
        {
            InitializeComponent();
        }

        //public delegate bool CounterSupplyDelegate(int Id, string CounterSupplySerialNo);
        //public event CounterSupplyDelegate CounterSupplyEvent;
        
        public void BindData(int id)
        {
            string str = "";
            GridViewCounterSupply.DataSource = new ViewModel.CounterSupply.CounterSupply().GetListByID(id,ref str);
        }

        
        #region All UI Button

        private void headerGridCounterSupply_btnInsertClick(object sender, System.EventArgs e)
        {
            CounterSupplyAdd_Frm CounterSupply = new CounterSupplyAdd_Frm();
            CounterSupply.ShowDialog();
            BindData(int.Parse(GridViewCounterSupply.CurrentRow.Cells["CounterSupply_Id"].Value.ToString()));
        }

        private void headerGridCounterSupply_btnEditClick(object sender, System.EventArgs e)
        {
            CounterSupplyAdd_Frm CounterSupplyAdd = new CounterSupplyAdd_Frm(byte.Parse(GridViewCounterSupply.CurrentRow.Cells["ID"].Value.ToString()));
            CounterSupplyAdd.ShowDialog();
            BindData(int.Parse(GridViewCounterSupply.CurrentRow.Cells["CounterSupply_Id"].Value.ToString()));
        }

        private void headerGridCounterSupply_btnDeleteClick(object sender, System.EventArgs e)
        {
            if (MSS.Library.Clasess.MSSMessage.MSSMessage_View(0,MSS.Library.Clasess.MSSMessage.MessageType.SConfirmation,true, "آیا به حذف این مورد اطمینان دارید؟"))
            {
                try
                {
                    List<TBL_CounterSupply> Ls = new List<TBL_CounterSupply>();
                    TBL_CounterSupply CounterSupply = new TBL_CounterSupply();
                    //CounterSupply.Id = int.Parse(GridViewCounterSupply.CurrentRow.Cells["Id"].Value.ToString());
                    //CounterSupply.Brand = GridViewCounterSupply.CurrentRow.Cells["Brand"].Value.ToString();
                    //CounterSupply.Size = double.Parse(GridViewCounterSupply.CurrentRow.Cells["Size"].Value.ToString());
                    //CounterSupply.Class = GridViewCounterSupply.CurrentRow.Cells["Class"].Value.ToString();
                    //CounterSupply.Grate = int.Parse(GridViewCounterSupply.CurrentRow.Cells["Grate"].Value.ToString());
                    //CounterSupply.CalibrationDuration = int.Parse(GridViewCounterSupply.CurrentRow.Cells["CalibrationDuration"].Value.ToString());
                    CounterSupply.Description = GridViewCounterSupply.CurrentRow.Cells["Description"].Value.ToString();
                    CounterSupply.IsActive = bool.Parse(GridViewCounterSupply.CurrentRow.Cells["IsActive"].Value.ToString());
                    Ls.Add(CounterSupply);


                    string str = "";
                    new ViewModel.CounterSupply.CounterSupply().DeleteEntity(Ls, ref str);
                }
                catch 
                {
                    MSS.Library.Clasess.MSSMessage.MSSMessage_View("امکان حذف این مورد در سیستم وجود ندارد",MSS.Library.Clasess.MSSMessage.MessageType.SError);
                }
            }
            BindData(int.Parse(GridViewCounterSupply.CurrentRow.Cells["CounterSupply_Id"].Value.ToString()));
        }

        private void headerGridCounterSupply_btnRefreshClick(object sender, System.EventArgs e)
        {
            BindData(int.Parse(GridViewCounterSupply.CurrentRow.Cells["CounterSupply_Id"].Value.ToString()));
        }

        #endregion

        private void CounterSupply_UC_Load(object sender, System.EventArgs e)
        {
            BindData(int.Parse(GridViewCounterSupply.CurrentRow.Cells["CounterSupply_Id"].Value.ToString()));
        }

        private void GridViewCounterSupply_SelectionChanged(object sender, System.EventArgs e)
        {
            //CounterSupplyEvent(int.Parse(GridViewCounterSupply.CurrentRow.Cells["CounterSupply_Id"].Value.ToString()),
            //    GridViewCounterSupply.CurrentRow.Cells["CounterSupplySerialNo"].Value.ToString());
        }


    }
}
