using System.Linq;
using System.Collections.Generic;
using GasStationManagement.Model.Basic.DataAccess;

namespace GasStationManagement.View.BaseForms
{
    public partial class WorkingPressure_Frm : System.Windows.Forms.Form
    {
        public WorkingPressure_Frm()
        {
            InitializeComponent();
        }

        public void BindData()
        {
            string str = "";
            GridViewWorkingPressure.DataSource = new ViewModel.Basic.WorkingPressure().GetList(ref str);
        }

        
        #region All UI Button

        private void headerGridWorkingPressure_btnInsertClick(object sender, System.EventArgs e)
        {
            WorkingPressureAdd_Frm WorkingPressureAdd = new WorkingPressureAdd_Frm();
            WorkingPressureAdd.ShowDialog();
            BindData();
        }

        private void headerGridWorkingPressure_btnEditClick(object sender, System.EventArgs e)
        {
            WorkingPressureAdd_Frm WorkingPressureAdd = new WorkingPressureAdd_Frm(byte.Parse(GridViewWorkingPressure.CurrentRow.Cells["Id"].Value.ToString()));
            WorkingPressureAdd.ShowDialog();
            BindData();
        }

        private void headerGridWorkingPressure_btnDeleteClick(object sender, System.EventArgs e)
        {
            if (MSS.Library.Clasess.MSSMessage.MSSMessage_View(0,MSS.Library.Clasess.MSSMessage.MessageType.SConfirmation,true, "آیا به حذف این مورد اطمینان دارید؟"))
            {
                try
                {
                    List<TBL_WorkingPressure> Ls = new List<TBL_WorkingPressure>();
                    TBL_WorkingPressure WorkingPressure = new TBL_WorkingPressure();
                    WorkingPressure.Id = short.Parse(GridViewWorkingPressure.CurrentRow.Cells["Id"].Value.ToString());
                    Ls.Add(WorkingPressure);


                    string str = "";
                    new ViewModel.Basic.WorkingPressure().DeleteEntity(Ls, ref str);
                }
                catch 
                {
                    MSS.Library.Clasess.MSSMessage.MSSMessage_View("امکان حذف این مورد در سیستم وجود ندارد",MSS.Library.Clasess.MSSMessage.MessageType.SError);
                }
            }
            BindData();
        }

        private void headerGridWorkingPressure_btnRefreshClick(object sender, System.EventArgs e)
        {
            BindData();
        }

        #endregion

        private void WorkingPressure_Frm_Load(object sender, System.EventArgs e)
        {
            BindData();
        }


    }
}
