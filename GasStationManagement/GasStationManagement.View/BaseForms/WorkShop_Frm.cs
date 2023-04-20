using System.Linq;
using System.Collections.Generic;
using GasStationManagement.Model.Basic.DataAccess;

namespace GasStationManagement.View.BaseForms
{
    public partial class WorkShop_Frm : System.Windows.Forms.Form
    {
        public WorkShop_Frm()
        {
            InitializeComponent();
        }

        public void BindData()
        {
            string str = "";
            GridViewWorkShop.DataSource = new ViewModel.Basic.WorkShop().GetList(ref str);
        }

        
        #region All UI Button

        private void headerGridWorkShop_btnInsertClick(object sender, System.EventArgs e)
        {
            WorkShopAdd_Frm WorkShopAdd = new WorkShopAdd_Frm();
            WorkShopAdd.ShowDialog();
            BindData();
        }

        private void headerGridWorkShop_btnEditClick(object sender, System.EventArgs e)
        {
            WorkShopAdd_Frm WorkShopAdd = new WorkShopAdd_Frm(byte.Parse(GridViewWorkShop.CurrentRow.Cells["Id"].Value.ToString()));
            WorkShopAdd.ShowDialog();
            BindData();
        }

        private void headerGridWorkShop_btnDeleteClick(object sender, System.EventArgs e)
        {
            if (MSS.Library.Clasess.MSSMessage.MSSMessage_View(0,MSS.Library.Clasess.MSSMessage.MessageType.SConfirmation,true, "آیا به حذف این مورد اطمینان دارید؟"))
            {
                try
                {
                    List<TBL_WorkShop> Ls = new List<TBL_WorkShop>();
                    TBL_WorkShop WorkShop = new TBL_WorkShop();
                    WorkShop.Id = short.Parse(GridViewWorkShop.CurrentRow.Cells["Id"].Value.ToString());
                    Ls.Add(WorkShop);


                    string str = "";
                    new ViewModel.Basic.WorkShop().DeleteEntity(Ls, ref str);
                }
                catch 
                {
                    MSS.Library.Clasess.MSSMessage.MSSMessage_View("امکان حذف این مورد در سیستم وجود ندارد",MSS.Library.Clasess.MSSMessage.MessageType.SError);
                }
            }
            BindData();
        }

        private void headerGridWorkShop_btnRefreshClick(object sender, System.EventArgs e)
        {
            BindData();
        }

        #endregion

        private void WorkShop_Frm_Load(object sender, System.EventArgs e)
        {
            BindData();
        }


    }
}
