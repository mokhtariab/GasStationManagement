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
    public partial class StoreAdd_Frm : MSS.Library.Forms.MSSBaseNew_frm
    {
        private byte _StoreCode = 0;
        private bool _editIns = false;

        public StoreAdd_Frm()
        {
            InitializeComponent();
        }

        public StoreAdd_Frm(byte StoreCode)
        {
            InitializeComponent();
            _StoreCode = StoreCode;
            string str = "";
            textBoxStoreDsc.Text = new ViewModel.Basic.Store().GetListByID(StoreCode, ref str)[0].Name;
            checkBoxIsActive.Checked = new ViewModel.Basic.Store().GetListByID(StoreCode, ref str)[0].IsActive;
            _editIns = true;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckValidation())
                return;
            try
            {
                string str = "";
                List<TBL_Store> Ls = new List<TBL_Store>(1);
                TBL_Store Store = new TBL_Store();
                Store.Id = _StoreCode;
                Store.Name = textBoxStoreDsc.Text;
                Store.IsActive = checkBoxIsActive.Checked;
                Ls.Add(Store);

                if (!_editIns)
                {
                    new ViewModel.Basic.Store().InsertEntity(Ls, ref str);
                }
                else
                {
                    new ViewModel.Basic.Store().UpdateEntity(Ls, ref str);
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
            if (textBoxStoreDsc.Text.Trim() == "")
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
