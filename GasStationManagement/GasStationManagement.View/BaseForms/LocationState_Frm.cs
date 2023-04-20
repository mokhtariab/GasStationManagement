using System.Linq;
using System.Collections.Generic;
using GasStationManagement.Model.Basic.DataAccess;

namespace GasStationManagement.View.BaseForms
{
    public partial class LocationState_Frm : System.Windows.Forms.Form
    {
        public LocationState_Frm()
        {
            InitializeComponent();
        }

        public void BindData()
        {
            string str = "";
            GridViewLocationState.DataSource = new ViewModel.Basic.LocationState().GetList(ref str);
        }

        
        #region All UI Button

        private void headerGridLocationState_btnInsertClick(object sender, System.EventArgs e)
        {
            LocationStateAdd_Frm LocationStateAdd = new LocationStateAdd_Frm();
            LocationStateAdd.ShowDialog();
            BindData();
        }

        private void headerGridLocationState_btnEditClick(object sender, System.EventArgs e)
        {
            LocationStateAdd_Frm LocationStateAdd = new LocationStateAdd_Frm(byte.Parse(GridViewLocationState.CurrentRow.Cells["Id"].Value.ToString()));
            LocationStateAdd.ShowDialog();
            BindData();
        }

        private void headerGridLocationState_btnDeleteClick(object sender, System.EventArgs e)
        {
            if (MSS.Library.Clasess.MSSMessage.MSSMessage_View(0,MSS.Library.Clasess.MSSMessage.MessageType.SConfirmation,true, "آیا به حذف این مورد اطمینان دارید؟"))
            {
                try
                {
                    List<TBL_LocationState> Ls = new List<TBL_LocationState>();
                    TBL_LocationState LocationState = new TBL_LocationState();
                    LocationState.Id = short.Parse(GridViewLocationState.CurrentRow.Cells["Id"].Value.ToString());
                    LocationState.Name = GridViewLocationState.CurrentRow.Cells["Name"].Value.ToString();
                    LocationState.IsActive = bool.Parse(GridViewLocationState.CurrentRow.Cells["IsActive"].Value.ToString());
                    Ls.Add(LocationState);


                    string str = "";
                    new ViewModel.Basic.LocationState().DeleteEntity(Ls, ref str);
                }
                catch 
                {
                    MSS.Library.Clasess.MSSMessage.MSSMessage_View("امکان حذف این مورد در سیستم وجود ندارد",MSS.Library.Clasess.MSSMessage.MessageType.SError);
                }
            }
            BindData();
        }

        private void headerGridLocationState_btnRefreshClick(object sender, System.EventArgs e)
        {
            BindData();
        }

        #endregion

        private void LocationState_Frm_Load(object sender, System.EventArgs e)
        {
            BindData();
        }


    }
}
