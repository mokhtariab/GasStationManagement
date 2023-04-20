using System.Linq;
using System.Collections.Generic;
using GasStationManagement.Model.Basic.DataAccess;

namespace GasStationManagement.View.BaseForms
{
    public partial class CounterInsLoc_Frm : System.Windows.Forms.Form
    {
        public CounterInsLoc_Frm()
        {
            InitializeComponent();
        }

        public void BindData()
        {
            string str = "";
            GridViewCounterInsLoc.DataSource = new ViewModel.Basic.CounterInsLoc().GetList(ref str);
        }

        
        #region All UI Button

        private void headerGridCounterInsLoc_btnInsertClick(object sender, System.EventArgs e)
        {
            CounterInsLocAdd_Frm CounterInsLocAdd = new CounterInsLocAdd_Frm();
            CounterInsLocAdd.ShowDialog();
            BindData();
        }

        private void headerGridCounterInsLoc_btnEditClick(object sender, System.EventArgs e)
        {
            CounterInsLocAdd_Frm CounterInsLocAdd = new CounterInsLocAdd_Frm(byte.Parse(GridViewCounterInsLoc.CurrentRow.Cells["Id"].Value.ToString()));
            CounterInsLocAdd.ShowDialog();
            BindData();
        }

        private void headerGridCounterInsLoc_btnDeleteClick(object sender, System.EventArgs e)
        {
            if (MSS.Library.Clasess.MSSMessage.MSSMessage_View(0,MSS.Library.Clasess.MSSMessage.MessageType.SConfirmation,true, "آیا به حذف این مورد اطمینان دارید؟"))
            {
                try
                {
                    List<TBL_CounterInsLoc> Ls = new List<TBL_CounterInsLoc>();
                    TBL_CounterInsLoc CounterInsLoc = new TBL_CounterInsLoc();
                    CounterInsLoc.Id = short.Parse(GridViewCounterInsLoc.CurrentRow.Cells["Id"].Value.ToString());
                    CounterInsLoc.Name = GridViewCounterInsLoc.CurrentRow.Cells["Name"].Value.ToString();
                    CounterInsLoc.IsActive = bool.Parse(GridViewCounterInsLoc.CurrentRow.Cells["IsActive"].Value.ToString());
                    Ls.Add(CounterInsLoc);


                    string str = "";
                    new ViewModel.Basic.CounterInsLoc().DeleteEntity(Ls, ref str);
                }
                catch 
                {
                    MSS.Library.Clasess.MSSMessage.MSSMessage_View("امکان حذف این مورد در سیستم وجود ندارد",MSS.Library.Clasess.MSSMessage.MessageType.SError);
                }
            }
            BindData();
        }

        private void headerGridCounterInsLoc_btnRefreshClick(object sender, System.EventArgs e)
        {
            BindData();
        }

        #endregion

        private void CounterInsLoc_Frm_Load(object sender, System.EventArgs e)
        {
            BindData();
        }


    }
}
