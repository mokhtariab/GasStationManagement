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
    public partial class UseTypeAdd_Frm : MSS.Library.Forms.MSSBaseNew_frm
    {
        private byte _UseTypeCode = 0;
        private bool _editIns = false;

        public UseTypeAdd_Frm()
        {
            InitializeComponent();
        }

        public UseTypeAdd_Frm(byte UseTypeCode)
        {
            InitializeComponent();
            _UseTypeCode = UseTypeCode;
            string str = "";
            textBoxUseTypeDsc.Text = new ViewModel.Basic.UseType().GetListByID(UseTypeCode, ref str)[0].Name;
            checkBoxIsActive.Checked = new ViewModel.Basic.UseType().GetListByID(UseTypeCode, ref str)[0].IsActive;
            _editIns = true;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckValidation())
                return;
            try
            {
                string str = "";
                List<TBL_UseType> Ls = new List<TBL_UseType>(1);
                TBL_UseType UseType = new TBL_UseType();
                UseType.Id = _UseTypeCode;
                UseType.Name = textBoxUseTypeDsc.Text;
                UseType.IsActive = checkBoxIsActive.Checked;
                Ls.Add(UseType);

                if (!_editIns)
                {
                    new ViewModel.Basic.UseType().InsertEntity(Ls, ref str);
                }
                else
                {
                    new ViewModel.Basic.UseType().UpdateEntity(Ls, ref str);
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
            if (textBoxUseTypeDsc.Text.Trim() == "")
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
