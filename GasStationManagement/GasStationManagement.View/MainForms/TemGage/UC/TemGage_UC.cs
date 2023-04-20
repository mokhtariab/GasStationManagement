using System.Linq;
using System.Collections.Generic;
using GasStationManagement.Model.Basic.DataAccess;
using MSS.Library.Clasess.FilterClass;

namespace GasStationManagement.View.MainForms.TemGage
{
    public partial class TemGage_UC : MSS.Library.UserControls.MSSUserControl_UC
    {
        public TemGage_UC()
        {
            InitializeComponent();
        }

        public void BindData(int RowNumberSet)
        {
            string str = "";
            GridViewTemGage.DataSource = new ViewModel.Basic.TemperatureGage().GetList(ref str);
            GridViewTemGage.Row = RowNumberSet;
        }

        
        #region All UI Button

        private void headerGridTemGage_btnInsertClick(object sender, System.EventArgs e)
        {
            TemGageAdd_Frm TemGageAdd = new TemGageAdd_Frm();
            TemGageAdd.ShowDialog();
            BindData(GridViewTemGage.RowCount);
        }

        private void headerGridTemGage_btnEditClick(object sender, System.EventArgs e)
        {
            try
            {
                int i = GridViewTemGage.Row;
                TemGageAdd_Frm TemGageAdd = new TemGageAdd_Frm(byte.Parse(GridViewTemGage.CurrentRow.Cells["ID"].Value.ToString()));
                TemGageAdd.ShowDialog();
                BindData(i);
            }
            catch { }
        }

        private void headerGridTemGage_btnDeleteClick(object sender, System.EventArgs e)
        {
            if (MSS.Library.Clasess.MSSMessage.MSSMessage_View(0,MSS.Library.Clasess.MSSMessage.MessageType.SConfirmation,true, "آیا به حذف این مورد اطمینان دارید؟"))
            {
                try
                {
                    int i = GridViewTemGage.Row;
                    List<TBL_TemperatureGage> Ls = new List<TBL_TemperatureGage>();
                    TBL_TemperatureGage TemGage = new TBL_TemperatureGage();
                    TemGage.Id = int.Parse(GridViewTemGage.CurrentRow.Cells["Id"].Value.ToString());
                    Ls.Add(TemGage);


                    string str = "";
                    new ViewModel.Basic.TemperatureGage().DeleteEntity(Ls, ref str);
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

        private void headerGridTemGage_btnRefreshClick(object sender, System.EventArgs e)
        {
            BindData(GridViewTemGage.Row);
        }

        #endregion

        private void TemGage_UC_Load(object sender, System.EventArgs e)
        {
            BindData(GridViewTemGage.Row);
            ParameterSetEvent += new ParameterSetChange(Th_ParameterSetEvent);
        }
        public void Th_ParameterSetEvent()
        {
            BindData(GridViewTemGage.Row);
        }

        private void GridViewTemGage_SelectionChanged(object sender, System.EventArgs e)
        {
            try
            {
                UserControl_Slave.ParameterSet = new Dictionary<string, object>();
                UserControl_Slave.ParameterSet.Add("TemGage_Id", System.Convert.ToInt32(GridViewTemGage.CurrentRow.Cells["Id"].Value));
                UserControl_Slave.ParameterSomeEvent();
            }
            catch { }
        }


    }
}
