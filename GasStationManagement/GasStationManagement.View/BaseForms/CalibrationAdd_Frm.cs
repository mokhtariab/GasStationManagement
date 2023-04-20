using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using GasStationManagement.Model.Basic.DataAccess;


namespace GasStationManagement.View.BaseForms
{
    public partial class CalibrationAdd_Frm : MSS.Library.Forms.MSSBaseNew_frm
    {
        private byte _CalibrationCode = 0;
        private bool _editIns = false;

        public CalibrationAdd_Frm()
        {
            InitializeComponent();
        }

        public CalibrationAdd_Frm(byte CalibrationCode)
        {
            InitializeComponent();
            _CalibrationCode = CalibrationCode;
            string str = "";
            textBoxCalibrationDsc.Text = new ViewModel.Basic.Calibration().GetListByID(CalibrationCode, ref str)[0].Name;
            checkBoxIsActive.Checked = new ViewModel.Basic.Calibration().GetListByID(CalibrationCode, ref str)[0].IsActive;
            _editIns = true;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckValidation())
                return;
            try
            {
                string str = "";
                List<TBL_Calibration> Ls = new List<TBL_Calibration>(1);
                TBL_Calibration Calibration = new TBL_Calibration();
                Calibration.Id = _CalibrationCode;
                Calibration.Name = textBoxCalibrationDsc.Text;
                Calibration.IsActive = checkBoxIsActive.Checked;
                Ls.Add(Calibration);

                if (!_editIns)
                {
                    new ViewModel.Basic.Calibration().InsertEntity(Ls, ref str);
                }
                else
                {
                    new ViewModel.Basic.Calibration().UpdateEntity(Ls, ref str);
                }

                MSS.Library.Clasess.MSSMessage.MSSMessage_View("اطلاعات ذخیره شد", MSS.Library.Clasess.MSSMessage.MessageType.SInformation);
                Close();
            }
            catch(Exception ex)
            {
                MSS.Library.Clasess.MSSMessage.MSSMessage_View(0, MSS.Library.Clasess.MSSMessage.MessageType.SError, false, ex.Message);
            }

        }


        private bool CheckValidation()
        {
            if (textBoxCalibrationDsc.Text.Trim() == "")
            {
                MSS.Library.Clasess.MSSMessage.MSSMessage_View("جای خالی را پر نمایید", MSS.Library.Clasess.MSSMessage.MessageType.SInformation);
                return false;
            }
            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
