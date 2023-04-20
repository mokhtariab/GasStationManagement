using System.Linq;
using System.Collections.Generic;
using GasStationManagement.Model.Basic.DataAccess;
using MSS.Library.Clasess.FilterClass;

namespace GasStationManagement.View.MainForms.PressTrans
{
    public partial class PressTrans_UC : MSS.Library.UserControls.MSSUserControl_UC
    {
        public PressTrans_UC()
        {
            InitializeComponent();
        }

        public void BindData(int RowNumberSet)
        {
            string str = "";
            GridViewPressTrans.DataSource = new ViewModel.Basic.PressureTransmitter().GetList(ref str);
            GridViewPressTrans.Row = RowNumberSet;
        }

        
        #region All UI Button

        private void headerGridPressTrans_btnInsertClick(object sender, System.EventArgs e)
        {
            PressTransAdd_Frm PressTransAdd = new PressTransAdd_Frm();
            PressTransAdd.ShowDialog();
            BindData(GridViewPressTrans.RowCount);
        }

        private void headerGridPressTrans_btnEditClick(object sender, System.EventArgs e)
        {
            try
            {
                int i = GridViewPressTrans.Row;
                PressTransAdd_Frm PressTransAdd = new PressTransAdd_Frm(int.Parse(GridViewPressTrans.CurrentRow.Cells["Id"].Value.ToString()));
                PressTransAdd.ShowDialog();
                BindData(i);
            }
            catch { }
        }

        private void headerGridPressTrans_btnDeleteClick(object sender, System.EventArgs e)
        {
            if (MSS.Library.Clasess.MSSMessage.MSSMessage_View(0,MSS.Library.Clasess.MSSMessage.MessageType.SConfirmation,true, "آیا به حذف این مورد اطمینان دارید؟"))
            {
                try
                {
                    int i = GridViewPressTrans.Row;
                    List<TBL_PressureTransmitter> Ls = new List<TBL_PressureTransmitter>();
                    TBL_PressureTransmitter PressTrans = new TBL_PressureTransmitter();
                    PressTrans.Id = int.Parse(GridViewPressTrans.CurrentRow.Cells["Id"].Value.ToString());
                    Ls.Add(PressTrans);


                    string str = "";
                    new ViewModel.Basic.PressureTransmitter().DeleteEntity(Ls, ref str);
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

        private void headerGridPressTrans_btnRefreshClick(object sender, System.EventArgs e)
        {
            BindData(GridViewPressTrans.Row);
        }

        #endregion

        private void PressTrans_UC_Load(object sender, System.EventArgs e)
        {
            BindData(GridViewPressTrans.Row);
            ParameterSetEvent += new ParameterSetChange(Th_ParameterSetEvent);
        }
        public void Th_ParameterSetEvent()
        {
            BindData(GridViewPressTrans.Row);
        }

        private void GridViewPressTrans_SelectionChanged(object sender, System.EventArgs e)
        {
            try
            {
                UserControl_Slave.ParameterSet = new Dictionary<string, object>();
                UserControl_Slave.ParameterSet.Add("PressTrans_Id", System.Convert.ToInt32(GridViewPressTrans.CurrentRow.Cells["Id"].Value));
                UserControl_Slave.ParameterSomeEvent();
            }
            catch { }
        }


    }
}
