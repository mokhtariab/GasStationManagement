using System.Linq;
using System.Collections.Generic;
using GasStationManagement.Model.Basic.DataAccess;

namespace GasStationManagement.View.BaseForms
{
    public partial class UseType_Frm : System.Windows.Forms.Form
    {
        public UseType_Frm()
        {
            InitializeComponent();
        }

        public void BindData()
        {
            string str = "";
            GridViewUseType.DataSource = new ViewModel.Basic.UseType().GetList(ref str);
        }

        
        #region All UI Button

        private void headerGridUseType_btnInsertClick(object sender, System.EventArgs e)
        {
            UseTypeAdd_Frm UseTypeAdd = new UseTypeAdd_Frm();
            UseTypeAdd.ShowDialog();
            BindData();
        }

        private void headerGridUseType_btnEditClick(object sender, System.EventArgs e)
        {
            UseTypeAdd_Frm UseTypeAdd = new UseTypeAdd_Frm(byte.Parse(GridViewUseType.CurrentRow.Cells["Id"].Value.ToString()));
            UseTypeAdd.ShowDialog();
            BindData();
        }

        private void headerGridUseType_btnDeleteClick(object sender, System.EventArgs e)
        {
            if (MSS.Library.Clasess.MSSMessage.MSSMessage_View(0,MSS.Library.Clasess.MSSMessage.MessageType.SConfirmation,true, "آیا به حذف این مورد اطمینان دارید؟"))
            {
                try
                {
                    List<TBL_UseType> Ls = new List<TBL_UseType>();
                    TBL_UseType UseType = new TBL_UseType();
                    UseType.Id = short.Parse(GridViewUseType.CurrentRow.Cells["Id"].Value.ToString());
                    Ls.Add(UseType);


                    string str = "";
                    new ViewModel.Basic.UseType().DeleteEntity(Ls, ref str);
                }
                catch 
                {
                    MSS.Library.Clasess.MSSMessage.MSSMessage_View("امکان حذف این مورد در سیستم وجود ندارد",MSS.Library.Clasess.MSSMessage.MessageType.SError);
                }
            }
            BindData();
        }

        private void headerGridUseType_btnRefreshClick(object sender, System.EventArgs e)
        {
            BindData();
        }

        #endregion

        private void UseType_Frm_Load(object sender, System.EventArgs e)
        {
            BindData();
        }


    }
}
