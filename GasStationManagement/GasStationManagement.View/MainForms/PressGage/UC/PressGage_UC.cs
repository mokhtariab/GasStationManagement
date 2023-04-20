using System.Linq;
using System.Collections.Generic;
using GasStationManagement.Model.Basic.DataAccess;
using MSS.Library.Clasess.FilterClass;

namespace GasStationManagement.View.MainForms.PressGage
{
    public partial class PressGage_UC : MSS.Library.UserControls.MSSUserControl_UC
    {
        public PressGage_UC()
        {
            InitializeComponent();
        }

        public void BindData(int RowNumberSet)
        {
            string str = "";
            GridViewPressGage.DataSource = new ViewModel.Basic.PressureGage().GetList(ref str);
            GridViewPressGage.Row = RowNumberSet;
        }

        
        #region All UI Button

        private void headerGridPressGage_btnInsertClick(object sender, System.EventArgs e)
        {
            PressGageAdd_Frm PressGageAdd = new PressGageAdd_Frm();
            PressGageAdd.ShowDialog();
            BindData(GridViewPressGage.RowCount);
        }

        private void headerGridPressGage_btnEditClick(object sender, System.EventArgs e)
        {
            try
            {
                int i = GridViewPressGage.Row;
                PressGageAdd_Frm PressGageAdd = new PressGageAdd_Frm(int.Parse(GridViewPressGage.CurrentRow.Cells["Id"].Value.ToString()));
                PressGageAdd.ShowDialog();
                BindData(i);
            }
            catch { }
        }

        private void headerGridPressGage_btnDeleteClick(object sender, System.EventArgs e)
        {
            if (MSS.Library.Clasess.MSSMessage.MSSMessage_View(0,MSS.Library.Clasess.MSSMessage.MessageType.SConfirmation,true, "آیا به حذف این مورد اطمینان دارید؟"))
            {
                try
                {
                    int i = GridViewPressGage.Row;
                    List<TBL_PressureGage> Ls = new List<TBL_PressureGage>();
                    TBL_PressureGage PressGage = new TBL_PressureGage();
                    PressGage.Id = int.Parse(GridViewPressGage.CurrentRow.Cells["Id"].Value.ToString());
                    Ls.Add(PressGage);


                    string str = "";
                    new ViewModel.Basic.PressureGage().DeleteEntity(Ls, ref str);
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

        private void headerGridPressGage_btnRefreshClick(object sender, System.EventArgs e)
        {
            BindData(GridViewPressGage.Row);
        }

        #endregion

        private void PressGage_UC_Load(object sender, System.EventArgs e)
        {
            BindData(GridViewPressGage.Row);
            ParameterSetEvent += new ParameterSetChange(Th_ParameterSetEvent);
        }
        public void Th_ParameterSetEvent()
        {
            BindData(GridViewPressGage.Row);
        }

        private void GridViewPressGage_SelectionChanged(object sender, System.EventArgs e)
        {
            //PressGageEvent(int.Parse(GridViewPressGage.CurrentRow.Cells["Id"].Value.ToString()));
            try
            {
                UserControl_Slave.ParameterSet = new Dictionary<string, object>();
                UserControl_Slave.ParameterSet.Add("PressGage_Id", System.Convert.ToInt32(GridViewPressGage.CurrentRow.Cells["Id"].Value));
                UserControl_Slave.ParameterSomeEvent();
            }
            catch { }
        }

        private void GridViewPressGage_FormattingRow(object sender, Janus.Windows.GridEX.RowLoadEventArgs e)
        {

        }


    }
}
