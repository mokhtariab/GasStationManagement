using System.Linq;
using System.Collections.Generic;
using GasStationManagement.Model.Basic.DataAccess;

namespace GasStationManagement.View.BaseForms
{
    public partial class MonitoringSysState_Frm : System.Windows.Forms.Form
    {
        public MonitoringSysState_Frm()
        {
            InitializeComponent();
        }

        public void BindData()
        {
            string str = "";
            GridViewMonitoringSysState.DataSource = new ViewModel.Basic.MonitoringSysState().GetList(ref str);
        }

        
        #region All UI Button

        private void headerGridMonitoringSysState_btnInsertClick(object sender, System.EventArgs e)
        {
            MonitoringSysStateAdd_Frm MonitoringSysStateAdd = new MonitoringSysStateAdd_Frm();
            MonitoringSysStateAdd.ShowDialog();
            BindData();
        }

        private void headerGridMonitoringSysState_btnEditClick(object sender, System.EventArgs e)
        {
            MonitoringSysStateAdd_Frm MonitoringSysStateAdd = new MonitoringSysStateAdd_Frm(byte.Parse(GridViewMonitoringSysState.CurrentRow.Cells["Id"].Value.ToString()));
            MonitoringSysStateAdd.ShowDialog();
            BindData();
        }

        private void headerGridMonitoringSysState_btnDeleteClick(object sender, System.EventArgs e)
        {
            if (MSS.Library.Clasess.MSSMessage.MSSMessage_View(0,MSS.Library.Clasess.MSSMessage.MessageType.SConfirmation,true, "آیا به حذف این مورد اطمینان دارید؟"))
            {
                try
                {
                    List<TBL_MonitoringSysState> Ls = new List<TBL_MonitoringSysState>();
                    TBL_MonitoringSysState MonitoringSysState = new TBL_MonitoringSysState();
                    MonitoringSysState.Id = short.Parse(GridViewMonitoringSysState.CurrentRow.Cells["Id"].Value.ToString());
                    MonitoringSysState.Name = GridViewMonitoringSysState.CurrentRow.Cells["Name"].Value.ToString();
                    MonitoringSysState.IsActive = bool.Parse(GridViewMonitoringSysState.CurrentRow.Cells["IsActive"].Value.ToString());
                    Ls.Add(MonitoringSysState);


                    string str = "";
                    new ViewModel.Basic.MonitoringSysState().DeleteEntity(Ls, ref str);
                }
                catch 
                {
                    MSS.Library.Clasess.MSSMessage.MSSMessage_View("امکان حذف این مورد در سیستم وجود ندارد",MSS.Library.Clasess.MSSMessage.MessageType.SError);
                }
            }
            BindData();
        }

        private void headerGridMonitoringSysState_btnRefreshClick(object sender, System.EventArgs e)
        {
            BindData();
        }

        #endregion

        private void MonitoringSysState_Frm_Load(object sender, System.EventArgs e)
        {
            BindData();
        }


    }
}
