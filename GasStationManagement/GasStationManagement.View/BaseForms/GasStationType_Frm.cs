using System.Linq;
using System.Collections.Generic;
using GasStationManagement.Model.Basic.DataAccess;

namespace GasStationManagement.View.BaseForms
{
    public partial class GasStationType_Frm : System.Windows.Forms.Form
    {
        public GasStationType_Frm()
        {
            InitializeComponent();
        }

        public void BindData()
        {
            string str = "";
            GridViewGasStationType.DataSource = new ViewModel.Basic.GasStationType().GetList(ref str);
        }

        
        #region All UI Button

        private void headerGridGasStationType_btnInsertClick(object sender, System.EventArgs e)
        {
            GasStationTypeAdd_Frm GasStationTypeAdd = new GasStationTypeAdd_Frm();
            GasStationTypeAdd.ShowDialog();
            BindData();
        }

        private void headerGridGasStationType_btnEditClick(object sender, System.EventArgs e)
        {
            GasStationTypeAdd_Frm GasStationTypeAdd = new GasStationTypeAdd_Frm(byte.Parse(GridViewGasStationType.CurrentRow.Cells["Id"].Value.ToString()));
            GasStationTypeAdd.ShowDialog();
            BindData();
        }

        private void headerGridGasStationType_btnDeleteClick(object sender, System.EventArgs e)
        {
            if (MSS.Library.Clasess.MSSMessage.MSSMessage_View(0,MSS.Library.Clasess.MSSMessage.MessageType.SConfirmation,true, "آیا به حذف این مورد اطمینان دارید؟"))
            {
                try
                {
                    List<TBL_GasStationType> Ls = new List<TBL_GasStationType>();
                    TBL_GasStationType GasStationType = new TBL_GasStationType();
                    GasStationType.Id = short.Parse(GridViewGasStationType.CurrentRow.Cells["Id"].Value.ToString());
                    GasStationType.Name = GridViewGasStationType.CurrentRow.Cells["Name"].Value.ToString();
                    GasStationType.IsActive = bool.Parse(GridViewGasStationType.CurrentRow.Cells["IsActive"].Value.ToString());
                    Ls.Add(GasStationType);


                    string str = "";
                    new ViewModel.Basic.GasStationType().DeleteEntity(Ls, ref str);
                }
                catch 
                {
                    MSS.Library.Clasess.MSSMessage.MSSMessage_View("امکان حذف این مورد در سیستم وجود ندارد",MSS.Library.Clasess.MSSMessage.MessageType.SError);
                }
            }
            BindData();
        }

        private void headerGridGasStationType_btnRefreshClick(object sender, System.EventArgs e)
        {
            BindData();
        }

        #endregion

        private void GasStationType_Frm_Load(object sender, System.EventArgs e)
        {
            BindData();
        }


    }
}
