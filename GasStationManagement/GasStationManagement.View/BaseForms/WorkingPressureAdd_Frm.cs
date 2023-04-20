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
    public partial class WorkingPressureAdd_Frm : MSS.Library.Forms.MSSBaseNew_frm
    {
        private byte _WorkingPressureCode = 0;
        private bool _editIns = false;

        public WorkingPressureAdd_Frm()
        {
            InitializeComponent();
        }

        public WorkingPressureAdd_Frm(byte WorkingPressureCode)
        {
            InitializeComponent();
            _WorkingPressureCode = WorkingPressureCode;
            string str = "";
            textBoxWorkingPressureDsc.Text = new ViewModel.Basic.WorkingPressure().GetListByID(WorkingPressureCode, ref str)[0].Name;
            checkBoxIsActive.Checked = new ViewModel.Basic.WorkingPressure().GetListByID(WorkingPressureCode, ref str)[0].IsActive;
            _editIns = true;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckValidation())
                return;
            try
            {
                string str = "";
                List<TBL_WorkingPressure> Ls = new List<TBL_WorkingPressure>(1);
                TBL_WorkingPressure WorkingPressure = new TBL_WorkingPressure();
                WorkingPressure.Id = _WorkingPressureCode;
                WorkingPressure.Name = textBoxWorkingPressureDsc.Text;
                WorkingPressure.IsActive = checkBoxIsActive.Checked;
                Ls.Add(WorkingPressure);

                if (!_editIns)
                {
                    new ViewModel.Basic.WorkingPressure().InsertEntity(Ls, ref str);
                }
                else
                {
                    new ViewModel.Basic.WorkingPressure().UpdateEntity(Ls, ref str);
                }

                MSS.Library.Clasess.MSSMessage.MSSMessage_View("اطلاعات ذخیره شد", MSS.Library.Clasess.MSSMessage.MessageType.SInformation);
                Close();
            }
            catch (Exception ex)
            {
                MSS.Library.Clasess.MSSMessage.MSSMessage_View(0, MSS.Library.Clasess.MSSMessage.MessageType.SError, false, ex.Message);
            }

        }


        private bool CheckValidation()
        {
            if (textBoxWorkingPressureDsc.Text.Trim() == "")
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
