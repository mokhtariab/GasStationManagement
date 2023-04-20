using System.Linq;
using System.Collections.Generic;
using GasStationManagement.Model.Basic.DataAccess;
using MSS.Library.Clasess.FilterClass;
using System;

namespace GasStationManagement.View.MainForms.Counter
{
    public partial class Counter_UC : MSS.Library.UserControls.MSSUserControl_UC
    {
        public Counter_UC()
        {
            InitializeComponent();
        }

        public void BindData(int RowNumberSet)
        {
            string str = "";
            GridViewCounter.DataSource = new ViewModel.Basic.Counter().GetList(ref str);
            try { GridViewCounter.Row = RowNumberSet; }
            catch { }
        }

        
        #region All UI Button

        private void headerGridCounter_btnInsertClick(object sender, System.EventArgs e)
        {
            CounterAdd_Frm CounterAdd = new CounterAdd_Frm();
            CounterAdd.ShowDialog();
            BindData(GridViewCounter.RowCount);
        }

        private void headerGridCounter_btnEditClick(object sender, System.EventArgs e)
        {
            try
            {
                int i = GridViewCounter.Row;
                CounterAdd_Frm CounterAdd = new CounterAdd_Frm(int.Parse(GridViewCounter.CurrentRow.Cells["Id"].Value.ToString()));
                CounterAdd.ShowDialog();
                BindData(i);
            }
            catch { }
        }

        private void headerGridCounter_btnDeleteClick(object sender, System.EventArgs e)
        {
            if (MSS.Library.Clasess.MSSMessage.MSSMessage_View(0, MSS.Library.Clasess.MSSMessage.MessageType.SConfirmation, true, "آیا به حذف این مورد اطمینان دارید؟"))
            {
                try
                {
                    int i = GridViewCounter.Row;
                    List<TBL_Counter> Ls = new List<TBL_Counter>();
                    TBL_Counter Counter = new TBL_Counter();
                    Counter.Id = int.Parse(GridViewCounter.CurrentRow.Cells["Id"].Value.ToString());
                    Ls.Add(Counter);

                    string str = "";
                    new ViewModel.Basic.Counter().DeleteEntity(Ls, ref str);
                    if (str != "")
                        MSS.Library.Clasess.MSSMessage.MSSMessage_View(0, MSS.Library.Clasess.MSSMessage.MessageType.SError, false, "امکان حذف این مورد در سیستم وجود ندارد", str);
                    else
                        BindData(i - 1);
                    
                }
                catch (Exception ex)
                {
                    MSS.Library.Clasess.MSSMessage.MSSMessage_View(0, MSS.Library.Clasess.MSSMessage.MessageType.SError, false, "امکان حذف این مورد در سیستم وجود ندارد", ex.Message);
                }

            } 
        }

        private void headerGridCounter_btnRefreshClick(object sender, System.EventArgs e)
        {
            BindData(GridViewCounter.Row);
        }

        #endregion

        private void Counter_UC_Load(object sender, System.EventArgs e)
        {
            BindData(0);
            ParameterSetEvent += new ParameterSetChange(Th_ParameterSetEvent);
        }
        public void Th_ParameterSetEvent()
        {
            BindData(GridViewCounter.Row);
        }

        private void GridViewCounter_SelectionChanged(object sender, System.EventArgs e)
        {
            try
            {
                UserControl_Slave.ParameterSet = new Dictionary<string, object>();
                UserControl_Slave.ParameterSet.Add("Counter_Id", System.Convert.ToInt32(GridViewCounter.CurrentRow.Cells["Id"].Value));
                UserControl_Slave.ParameterSomeEvent();
            }
            catch { }
        }


    }
}
