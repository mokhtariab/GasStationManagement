using System.Linq;
using System.Collections.Generic;
using GasStationManagement.Model.Basic.DataAccess;

namespace GasStationManagement.View.BaseForms
{
    public partial class Calibration_Frm : System.Windows.Forms.Form
    {
        public Calibration_Frm()
        {
            InitializeComponent();
        }

        public void BindData()
        {
            string str = "";
            GridViewCalibration.DataSource = new ViewModel.Basic.Calibration().GetList(ref str);
        }

        
        #region All UI Button

        private void headerGridCalibration_btnInsertClick(object sender, System.EventArgs e)
        {
            CalibrationAdd_Frm CalibrationAdd = new CalibrationAdd_Frm();
            CalibrationAdd.ShowDialog();
            BindData();
        }

        private void headerGridCalibration_btnEditClick(object sender, System.EventArgs e)
        {
            CalibrationAdd_Frm CalibrationAdd = new CalibrationAdd_Frm(byte.Parse(GridViewCalibration.CurrentRow.Cells["Id"].Value.ToString()));
            CalibrationAdd.ShowDialog();
            BindData();
        }

        private void headerGridCalibration_btnDeleteClick(object sender, System.EventArgs e)
        {
            if (MSS.Library.Clasess.MSSMessage.MSSMessage_View(0,MSS.Library.Clasess.MSSMessage.MessageType.SConfirmation,true, "آیا به حذف این مورد اطمینان دارید؟"))
            {
                try
                {
                    List<TBL_Calibration> Ls = new List<TBL_Calibration>();
                    TBL_Calibration Calibration = new TBL_Calibration();
                    Calibration.Id = short.Parse(GridViewCalibration.CurrentRow.Cells["Id"].Value.ToString());
                    Calibration.Name = GridViewCalibration.CurrentRow.Cells["Name"].Value.ToString();
                    Calibration.IsActive = bool.Parse(GridViewCalibration.CurrentRow.Cells["IsActive"].Value.ToString());
                    Ls.Add(Calibration);


                    string str = "";
                    new ViewModel.Basic.Calibration().DeleteEntity(Ls, ref str);
                }
                catch 
                {
                    MSS.Library.Clasess.MSSMessage.MSSMessage_View("امکان حذف این مورد در سیستم وجود ندارد",MSS.Library.Clasess.MSSMessage.MessageType.SError);
                }
            }
            BindData();
        }

        private void headerGridCalibration_btnRefreshClick(object sender, System.EventArgs e)
        {
            BindData();
        }

        #endregion

        private void Calibration_Frm_Load(object sender, System.EventArgs e)
        {
            BindData();
        }


    }
}
