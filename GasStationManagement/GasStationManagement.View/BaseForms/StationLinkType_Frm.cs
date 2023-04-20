using System.Linq;
using System.Collections.Generic;
using GasStationManagement.Model.Basic.DataAccess;

namespace GasStationManagement.View.BaseForms
{
    public partial class StationLinkType_Frm : System.Windows.Forms.Form
    {
        public StationLinkType_Frm()
        {
            InitializeComponent();
        }

        public void BindData()
        {
            string str = "";
            GridViewStationLinkType.DataSource = new ViewModel.Basic.StationLinkType().GetList(ref str);
        }

        
        #region All UI Button

        private void headerGridStationLinkType_btnInsertClick(object sender, System.EventArgs e)
        {
            StationLinkTypeAdd_Frm StationLinkTypeAdd = new StationLinkTypeAdd_Frm();
            StationLinkTypeAdd.ShowDialog();
            BindData();
        }

        private void headerGridStationLinkType_btnEditClick(object sender, System.EventArgs e)
        {
            StationLinkTypeAdd_Frm StationLinkTypeAdd = new StationLinkTypeAdd_Frm(byte.Parse(GridViewStationLinkType.CurrentRow.Cells["Id"].Value.ToString()));
            StationLinkTypeAdd.ShowDialog();
            BindData();
        }

        private void headerGridStationLinkType_btnDeleteClick(object sender, System.EventArgs e)
        {
            if (MSS.Library.Clasess.MSSMessage.MSSMessage_View(0,MSS.Library.Clasess.MSSMessage.MessageType.SConfirmation,true, "آیا به حذف این مورد اطمینان دارید؟"))
            {
                try
                {
                    List<TBL_StationLinkType> Ls = new List<TBL_StationLinkType>();
                    TBL_StationLinkType StationLinkType = new TBL_StationLinkType();
                    StationLinkType.Id = short.Parse(GridViewStationLinkType.CurrentRow.Cells["Id"].Value.ToString());
                    Ls.Add(StationLinkType);


                    string str = "";
                    new ViewModel.Basic.StationLinkType().DeleteEntity(Ls, ref str);
                }
                catch 
                {
                    MSS.Library.Clasess.MSSMessage.MSSMessage_View("امکان حذف این مورد در سیستم وجود ندارد",MSS.Library.Clasess.MSSMessage.MessageType.SError);
                }
            }
            BindData();
        }

        private void headerGridStationLinkType_btnRefreshClick(object sender, System.EventArgs e)
        {
            BindData();
        }

        #endregion

        private void StationLinkType_Frm_Load(object sender, System.EventArgs e)
        {
            BindData();
        }


    }
}
