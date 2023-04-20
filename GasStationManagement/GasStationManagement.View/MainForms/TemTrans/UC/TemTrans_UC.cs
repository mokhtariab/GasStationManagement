using System.Linq;
using System.Collections.Generic;
using GasStationManagement.Model.Basic.DataAccess;
using MSS.Library.Clasess.FilterClass;

namespace GasStationManagement.View.MainForms.TemTrans
{
    public partial class TemTrans_UC : MSS.Library.UserControls.MSSUserControl_UC
    {
        public TemTrans_UC()
        {
            InitializeComponent();
        }

        public void BindData(int RowNumberSet)
        {
            string str = "";
            GridViewTemTrans.DataSource = new ViewModel.Basic.TemperatureTransmitter().GetList(ref str);
            GridViewTemTrans.Row = RowNumberSet;
        }

        
        #region All UI Button

        private void headerGridTemTrans_btnInsertClick(object sender, System.EventArgs e)
        {
            TemTransAdd_Frm TemTransAdd = new TemTransAdd_Frm();
            TemTransAdd.ShowDialog();
            BindData(GridViewTemTrans.RowCount);
        }

        private void headerGridTemTrans_btnEditClick(object sender, System.EventArgs e)
        {
            try
            {
                int i = GridViewTemTrans.Row;
                TemTransAdd_Frm TemTransAdd = new TemTransAdd_Frm(byte.Parse(GridViewTemTrans.CurrentRow.Cells["ID"].Value.ToString()));
                TemTransAdd.ShowDialog();
                BindData(i);
            }
            catch { }
        }

        private void headerGridTemTrans_btnDeleteClick(object sender, System.EventArgs e)
        {
            if (MSS.Library.Clasess.MSSMessage.MSSMessage_View(0,MSS.Library.Clasess.MSSMessage.MessageType.SConfirmation,true, "آیا به حذف این مورد اطمینان دارید؟"))
            {
                try
                {
                    int i = GridViewTemTrans.Row;
                    List<TBL_TemperatureTransmitter> Ls = new List<TBL_TemperatureTransmitter>();
                    TBL_TemperatureTransmitter TemTrans = new TBL_TemperatureTransmitter();
                    TemTrans.Id = int.Parse(GridViewTemTrans.CurrentRow.Cells["Id"].Value.ToString());
                    Ls.Add(TemTrans);


                    string str = "";
                    new ViewModel.Basic.TemperatureTransmitter().DeleteEntity(Ls, ref str);
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

        private void headerGridTemTrans_btnRefreshClick(object sender, System.EventArgs e)
        {
            BindData(GridViewTemTrans.Row);
        }

        #endregion

        private void TemTrans_UC_Load(object sender, System.EventArgs e)
        {
            BindData(GridViewTemTrans.Row);
            ParameterSetEvent += new ParameterSetChange(Th_ParameterSetEvent);
        }
        public void Th_ParameterSetEvent()
        {
            BindData(GridViewTemTrans.Row);
        }

        private void GridViewTemTrans_SelectionChanged(object sender, System.EventArgs e)
        {
            try
            {
                UserControl_Slave.ParameterSet = new Dictionary<string, object>();
                UserControl_Slave.ParameterSet.Add("TemTrans_Id", System.Convert.ToInt32(GridViewTemTrans.CurrentRow.Cells["Id"].Value));
                UserControl_Slave.ParameterSomeEvent();
            }
            catch { }
        }


    }
}
