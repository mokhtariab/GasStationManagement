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
    public partial class ParametersAdd_Frm : MSS.Library.Forms.MSSBaseNew_frm
    {
        private byte _ParametersCode = 0;
        private bool _editIns = false;

        public ParametersAdd_Frm()
        {
            InitializeComponent();
        }

        public ParametersAdd_Frm(byte ParametersCode)
        {
            InitializeComponent();
            _ParametersCode = ParametersCode;
            string str = "";
            textBoxParametersDsc.Text = new ViewModel.Basic.Parameters().GetListByID(ParametersCode, ref str)[0].Name;
            checkBoxIsActive.Checked = new ViewModel.Basic.Parameters().GetListByID(ParametersCode, ref str)[0].IsActive;
            _editIns = true;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckValidation())
                return;
            try
            {
                string str = "";
                List<TBL_Parameter> Ls = new List<TBL_Parameter>(1);
                TBL_Parameter Parameters = new TBL_Parameter();
                Parameters.Id = _ParametersCode;
                Parameters.Name = textBoxParametersDsc.Text;
                Parameters.IsActive = checkBoxIsActive.Checked;
                Ls.Add(Parameters);

                if (!_editIns)
                {
                    new ViewModel.Basic.Parameters().InsertEntity(Ls, ref str);
                }
                else
                {
                    new ViewModel.Basic.Parameters().UpdateEntity(Ls, ref str);
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
            if (textBoxParametersDsc.Text.Trim() == "")
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
