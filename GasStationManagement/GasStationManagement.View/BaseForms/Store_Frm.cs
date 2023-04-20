using System.Linq;
using System.Collections.Generic;
using GasStationManagement.Model.Basic.DataAccess;

namespace GasStationManagement.View.BaseForms
{
    public partial class Store_Frm : System.Windows.Forms.Form
    {
        public Store_Frm()
        {
            InitializeComponent();
        }

        public void BindData()
        {
            string str = "";
            GridViewStore.DataSource = new ViewModel.Basic.Store().GetList(ref str);
        }

        
        #region All UI Button

        private void headerGridStore_btnInsertClick(object sender, System.EventArgs e)
        {
            StoreAdd_Frm StoreAdd = new StoreAdd_Frm();
            StoreAdd.ShowDialog();
            BindData();
        }

        private void headerGridStore_btnEditClick(object sender, System.EventArgs e)
        {
            StoreAdd_Frm StoreAdd = new StoreAdd_Frm(byte.Parse(GridViewStore.CurrentRow.Cells["Id"].Value.ToString()));
            StoreAdd.ShowDialog();
            BindData();
        }

        private void headerGridStore_btnDeleteClick(object sender, System.EventArgs e)
        {
            if (MSS.Library.Clasess.MSSMessage.MSSMessage_View(0,MSS.Library.Clasess.MSSMessage.MessageType.SConfirmation,true, "آیا به حذف این مورد اطمینان دارید؟"))
            {
                try
                {
                    List<TBL_Store> Ls = new List<TBL_Store>();
                    TBL_Store Store = new TBL_Store();
                    Store.Id = short.Parse(GridViewStore.CurrentRow.Cells["Id"].Value.ToString());
                    Store.Name = GridViewStore.CurrentRow.Cells["Name"].Value.ToString();
                    Store.IsActive = bool.Parse(GridViewStore.CurrentRow.Cells["IsActive"].Value.ToString());
                    Ls.Add(Store);


                    string str = "";
                    new ViewModel.Basic.Store().DeleteEntity(Ls, ref str);
                }
                catch 
                {
                    MSS.Library.Clasess.MSSMessage.MSSMessage_View("امکان حذف این مورد در سیستم وجود ندارد",MSS.Library.Clasess.MSSMessage.MessageType.SError);
                }
            }
            BindData();
        }

        private void headerGridStore_btnRefreshClick(object sender, System.EventArgs e)
        {
            BindData();
        }

        #endregion

        private void Store_Frm_Load(object sender, System.EventArgs e)
        {
            BindData();
        }


    }
}
