using System.Linq;
using System.Collections.Generic;
using GasStationManagement.Model.Basic.DataAccess;

namespace GasStationManagement.View.BaseForms
{
    public partial class Suppliers_Frm : System.Windows.Forms.Form
    {
        public Suppliers_Frm()
        {
            InitializeComponent();
        }

        public void BindData()
        {
            string str = "";
            GridViewSuppliers.DataSource = new ViewModel.Basic.Suppliers().GetList(ref str);
        }

        
        #region All UI Button

        private void headerGridSuppliers_btnInsertClick(object sender, System.EventArgs e)
        {
            SuppliersAdd_Frm SuppliersAdd = new SuppliersAdd_Frm();
            SuppliersAdd.ShowDialog();
            BindData();
        }

        private void headerGridSuppliers_btnEditClick(object sender, System.EventArgs e)
        {
            SuppliersAdd_Frm SuppliersAdd = new SuppliersAdd_Frm(byte.Parse(GridViewSuppliers.CurrentRow.Cells["Id"].Value.ToString()));
            SuppliersAdd.ShowDialog();
            BindData();
        }

        private void headerGridSuppliers_btnDeleteClick(object sender, System.EventArgs e)
        {
            if (MSS.Library.Clasess.MSSMessage.MSSMessage_View(0,MSS.Library.Clasess.MSSMessage.MessageType.SConfirmation,true, "آیا به حذف این مورد اطمینان دارید؟"))
            {
                try
                {
                    List<TBL_Supplier> Ls = new List<TBL_Supplier>();
                    TBL_Supplier Suppliers = new TBL_Supplier();
                    Suppliers.Id = short.Parse(GridViewSuppliers.CurrentRow.Cells["Id"].Value.ToString());
                    Suppliers.Name = GridViewSuppliers.CurrentRow.Cells["Name"].Value.ToString();
                    Suppliers.Address = GridViewSuppliers.CurrentRow.Cells["Address"].Value.ToString();
                    Suppliers.Tel = GridViewSuppliers.CurrentRow.Cells["Tel"].Value.ToString();
                    Suppliers.Description = GridViewSuppliers.CurrentRow.Cells["Description"].Value.ToString();
                    Suppliers.IsActive = bool.Parse(GridViewSuppliers.CurrentRow.Cells["IsActive"].Value.ToString());
                    Ls.Add(Suppliers);


                    string str = "";
                    new ViewModel.Basic.Suppliers().DeleteEntity(Ls, ref str);
                }
                catch 
                {
                    MSS.Library.Clasess.MSSMessage.MSSMessage_View("امکان حذف این مورد در سیستم وجود ندارد",MSS.Library.Clasess.MSSMessage.MessageType.SError);
                }
            }
            BindData();
        }

        private void headerGridSuppliers_btnRefreshClick(object sender, System.EventArgs e)
        {
            BindData();
        }

        #endregion

        private void Suppliers_Frm_Load(object sender, System.EventArgs e)
        {
            BindData();
        }


    }
}
