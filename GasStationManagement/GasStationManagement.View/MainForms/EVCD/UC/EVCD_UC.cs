using System.Linq;
using System.Collections.Generic;
using GasStationManagement.Model.Basic.DataAccess;
using MSS.Library.Clasess.FilterClass;

namespace GasStationManagement.View.MainForms.EVCD
{
    public partial class EVCD_UC : MSS.Library.UserControls.MSSUserControl_UC
    {
        public EVCD_UC()
        {
            InitializeComponent();
        }

        public void BindData(int RowNumberSet)
        {
            string str = "";
            GridViewEVCD.DataSource = new ViewModel.Basic.EVCD().GetList(ref str);
            GridViewEVCD.Row = RowNumberSet;
        }

        
        #region All UI Button

        private void headerGridEVCD_btnInsertClick(object sender, System.EventArgs e)
        {
            EVCDAdd_Frm EVCDAdd = new EVCDAdd_Frm();
            EVCDAdd.ShowDialog();
            BindData(GridViewEVCD.RowCount);
        }

        private void headerGridEVCD_btnEditClick(object sender, System.EventArgs e)
        {
            try
            {
                int i = GridViewEVCD.Row;
                EVCDAdd_Frm EVCDAdd = new EVCDAdd_Frm(int.Parse(GridViewEVCD.CurrentRow.Cells["Id"].Value.ToString()));
                EVCDAdd.ShowDialog();
                BindData(i);
            }
            catch { }
        }

        private void headerGridEVCD_btnDeleteClick(object sender, System.EventArgs e)
        {
            if (MSS.Library.Clasess.MSSMessage.MSSMessage_View(0,MSS.Library.Clasess.MSSMessage.MessageType.SConfirmation,true, "آیا به حذف این مورد اطمینان دارید؟"))
            {
                try
                {
                    int i = GridViewEVCD.Row;
                    List<TBL_EVCD> Ls = new List<TBL_EVCD>();
                    TBL_EVCD EVCD = new TBL_EVCD();
                    EVCD.Id = int.Parse(GridViewEVCD.CurrentRow.Cells["Id"].Value.ToString());
                    Ls.Add(EVCD);


                    string str = "";
                    new ViewModel.Basic.EVCD().DeleteEntity(Ls, ref str);
                    if (str != "")
                        MSS.Library.Clasess.MSSMessage.MSSMessage_View(0, MSS.Library.Clasess.MSSMessage.MessageType.SError, false, "امکان حذف این مورد در سیستم وجود ندارد", str);
                    else
                        BindData(i - 1);

                }
                catch (System.Exception ex)
                {
                    MSS.Library.Clasess.MSSMessage.MSSMessage_View(0, MSS.Library.Clasess.MSSMessage.MessageType.SError, false, "امکان حذف این مورد در سیستم وجود ندارد", ex.Message);
                }

            }
        }

        private void headerGridEVCD_btnRefreshClick(object sender, System.EventArgs e)
        {
            BindData(GridViewEVCD.Row);
        }

        #endregion

        private void EVCD_UC_Load(object sender, System.EventArgs e)
        {
            BindData(GridViewEVCD.Row);
            ParameterSetEvent += new ParameterSetChange(Th_ParameterSetEvent);
        }
        public void Th_ParameterSetEvent()
        {
            BindData(GridViewEVCD.Row);
        }

        private void GridViewEVCD_SelectionChanged(object sender, System.EventArgs e)
        {
            //EVCDEvent(int.Parse(GridViewEVCD.CurrentRow.Cells["Id"].Value.ToString()));
            try
            {
                UserControl_Slave.ParameterSet = new Dictionary<string, object>();
                UserControl_Slave.ParameterSet.Add("EVCD_Id", System.Convert.ToInt32(GridViewEVCD.CurrentRow.Cells["Id"].Value));
                UserControl_Slave.ParameterSomeEvent();
            }
            catch { }
        }


    }
}
