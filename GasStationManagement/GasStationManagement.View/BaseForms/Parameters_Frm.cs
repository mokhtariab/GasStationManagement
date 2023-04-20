using System.Linq;
using System.Collections.Generic;
using GasStationManagement.Model.Basic.DataAccess;

namespace GasStationManagement.View.BaseForms
{
    public partial class Parameters_Frm : System.Windows.Forms.Form
    {
        public Parameters_Frm()
        {
            InitializeComponent();
        }

        public void BindData()
        {
            string str = "";
            GridViewParameters.DataSource = new ViewModel.Basic.Parameters().GetList(ref str);
        }

        
        #region All UI Button

        private void headerGridParameters_btnInsertClick(object sender, System.EventArgs e)
        {
            ParametersAdd_Frm ParametersAdd = new ParametersAdd_Frm();
            ParametersAdd.ShowDialog();
            BindData();
        }

        private void headerGridParameters_btnEditClick(object sender, System.EventArgs e)
        {
            ParametersAdd_Frm ParametersAdd = new ParametersAdd_Frm(byte.Parse(GridViewParameters.CurrentRow.Cells["Id"].Value.ToString()));
            ParametersAdd.ShowDialog();
            BindData();
        }

        private void headerGridParameters_btnDeleteClick(object sender, System.EventArgs e)
        {
            if (MSS.Library.Clasess.MSSMessage.MSSMessage_View(0,MSS.Library.Clasess.MSSMessage.MessageType.SConfirmation,true, "آیا به حذف این مورد اطمینان دارید؟"))
            {
                try
                {
                    List<TBL_Parameter> Ls = new List<TBL_Parameter>();
                    TBL_Parameter Parameters = new TBL_Parameter();
                    Parameters.Id = short.Parse(GridViewParameters.CurrentRow.Cells["Id"].Value.ToString());
                    Parameters.Name = GridViewParameters.CurrentRow.Cells["Name"].Value.ToString();
                    Parameters.IsActive = bool.Parse(GridViewParameters.CurrentRow.Cells["IsActive"].Value.ToString());
                    Ls.Add(Parameters);


                    string str = "";
                    new ViewModel.Basic.Parameters().DeleteEntity(Ls, ref str);
                }
                catch 
                {
                    MSS.Library.Clasess.MSSMessage.MSSMessage_View("امکان حذف این مورد در سیستم وجود ندارد",MSS.Library.Clasess.MSSMessage.MessageType.SError);
                }
            }
            BindData();
        }

        private void headerGridParameters_btnRefreshClick(object sender, System.EventArgs e)
        {
            BindData();
        }

        #endregion

        private void Parameters_Frm_Load(object sender, System.EventArgs e)
        {
            BindData();
        }


    }
}
