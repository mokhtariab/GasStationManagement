using System.Linq;
using System.Collections.Generic;
using GasStationManagement.Model.Basic.DataAccess;

namespace GasStationManagement.View.BaseForms
{
    public partial class ZoneOperation_Frm : System.Windows.Forms.Form
    {
        public ZoneOperation_Frm()
        {
            InitializeComponent();
        }

        public void BindData()
        {
            string str = "";
            GridViewZoneOperation.DataSource = new ViewModel.Basic.ZoneOperation().GetList(ref str);
        }

        
        #region All UI Button

        private void headerGridZoneOperation_btnInsertClick(object sender, System.EventArgs e)
        {
            ZoneOperationAdd_Frm ZoneOperationAdd = new ZoneOperationAdd_Frm();
            ZoneOperationAdd.ShowDialog();
            BindData();
        }

        private void headerGridZoneOperation_btnEditClick(object sender, System.EventArgs e)
        {
            ZoneOperationAdd_Frm ZoneOperationAdd = new ZoneOperationAdd_Frm(byte.Parse(GridViewZoneOperation.CurrentRow.Cells["Id"].Value.ToString()));
            ZoneOperationAdd.ShowDialog();
            BindData();
        }

        private void headerGridZoneOperation_btnDeleteClick(object sender, System.EventArgs e)
        {
            if (MSS.Library.Clasess.MSSMessage.MSSMessage_View(0,MSS.Library.Clasess.MSSMessage.MessageType.SConfirmation,true, "آیا به حذف این مورد اطمینان دارید؟"))
            {
                try
                {
                    List<TBL_ZoneOperation> Ls = new List<TBL_ZoneOperation>();
                    TBL_ZoneOperation ZoneOperation = new TBL_ZoneOperation();
                    ZoneOperation.Id = short.Parse(GridViewZoneOperation.CurrentRow.Cells["Id"].Value.ToString());
                    Ls.Add(ZoneOperation);


                    string str = "";
                    new ViewModel.Basic.ZoneOperation().DeleteEntity(Ls, ref str);
                }
                catch 
                {
                    MSS.Library.Clasess.MSSMessage.MSSMessage_View("امکان حذف این مورد در سیستم وجود ندارد",MSS.Library.Clasess.MSSMessage.MessageType.SError);
                }
            }
            BindData();
        }

        private void headerGridZoneOperation_btnRefreshClick(object sender, System.EventArgs e)
        {
            BindData();
        }

        #endregion

        private void ZoneOperation_Frm_Load(object sender, System.EventArgs e)
        {
            BindData();
        }


    }
}
