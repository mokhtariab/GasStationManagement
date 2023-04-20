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
    public partial class ZoneOperationAdd_Frm : MSS.Library.Forms.MSSBaseNew_frm
    {
        private byte _ZoneOperationCode = 0;
        private bool _editIns = false;

        public ZoneOperationAdd_Frm()
        {
            InitializeComponent();
        }

        public ZoneOperationAdd_Frm(byte ZoneOperationCode)
        {
            InitializeComponent();
            _ZoneOperationCode = ZoneOperationCode;
            string str = "";
            textBoxZoneOperationDsc.Text = new ViewModel.Basic.ZoneOperation().GetListByID(ZoneOperationCode, ref str)[0].Name;
            checkBoxIsActive.Checked = new ViewModel.Basic.ZoneOperation().GetListByID(ZoneOperationCode, ref str)[0].IsActive;
            _editIns = true;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckValidation())
                return;
            try
            {
                string str = "";
                List<TBL_ZoneOperation> Ls = new List<TBL_ZoneOperation>(1);
                TBL_ZoneOperation ZoneOperation = new TBL_ZoneOperation();
                ZoneOperation.Id = _ZoneOperationCode;
                ZoneOperation.Name = textBoxZoneOperationDsc.Text;
                ZoneOperation.IsActive = checkBoxIsActive.Checked;
                Ls.Add(ZoneOperation);

                if (!_editIns)
                {
                    new ViewModel.Basic.ZoneOperation().InsertEntity(Ls, ref str);
                }
                else
                {
                    new ViewModel.Basic.ZoneOperation().UpdateEntity(Ls, ref str);
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
            if (textBoxZoneOperationDsc.Text.Trim() == "")
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
