using System.Linq;
using System.Collections.Generic;
using GasStationManagement.Model.Basic.DataAccess;

namespace GasStationManagement.View.BaseForms
{
    public partial class EquipmentState_Frm : System.Windows.Forms.Form
    {
        public EquipmentState_Frm()
        {
            InitializeComponent();
        }

        public void BindData()
        {
            string str = "";
            GridViewEquipmentState.DataSource = new ViewModel.Basic.EquipmentState().GetList(ref str);
        }

        
        #region All UI Button

        private void headerGridEquipmentState_btnInsertClick(object sender, System.EventArgs e)
        {
            EquipmentStateAdd_Frm EquipmentStateAdd = new EquipmentStateAdd_Frm();
            EquipmentStateAdd.ShowDialog();
            BindData();
        }

        private void headerGridEquipmentState_btnEditClick(object sender, System.EventArgs e)
        {
            EquipmentStateAdd_Frm EquipmentStateAdd = new EquipmentStateAdd_Frm(byte.Parse(GridViewEquipmentState.CurrentRow.Cells["Id"].Value.ToString()));
            EquipmentStateAdd.ShowDialog();
            BindData();
        }

        private void headerGridEquipmentState_btnDeleteClick(object sender, System.EventArgs e)
        {
            if (MSS.Library.Clasess.MSSMessage.MSSMessage_View(0,MSS.Library.Clasess.MSSMessage.MessageType.SConfirmation,true, "آیا به حذف این مورد اطمینان دارید؟"))
            {
                try
                {
                    List<TBL_EquipmentState> Ls = new List<TBL_EquipmentState>();
                    TBL_EquipmentState EquipmentState = new TBL_EquipmentState();
                    EquipmentState.Id = short.Parse(GridViewEquipmentState.CurrentRow.Cells["Id"].Value.ToString());
                    EquipmentState.Name = GridViewEquipmentState.CurrentRow.Cells["Name"].Value.ToString();
                    EquipmentState.IsActive = bool.Parse(GridViewEquipmentState.CurrentRow.Cells["IsActive"].Value.ToString());
                    Ls.Add(EquipmentState);


                    string str = "";
                    new ViewModel.Basic.EquipmentState().DeleteEntity(Ls, ref str);
                }
                catch 
                {
                    MSS.Library.Clasess.MSSMessage.MSSMessage_View("امکان حذف این مورد در سیستم وجود ندارد",MSS.Library.Clasess.MSSMessage.MessageType.SError);
                }
            }
            BindData();
        }

        private void headerGridEquipmentState_btnRefreshClick(object sender, System.EventArgs e)
        {
            BindData();
        }

        #endregion

        private void EquipmentState_Frm_Load(object sender, System.EventArgs e)
        {
            BindData();
        }


    }
}
