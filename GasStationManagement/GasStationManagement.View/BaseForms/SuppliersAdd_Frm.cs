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
    public partial class SuppliersAdd_Frm : MSS.Library.Forms.MSSBaseNew_frm
    {
        private byte _SuppliersCode = 0;
        private bool _editIns = false;

        public SuppliersAdd_Frm()
        {
            InitializeComponent();
        }

        public SuppliersAdd_Frm(byte SuppliersCode)
        {
            InitializeComponent();
            _SuppliersCode = SuppliersCode;
            string str = "";
            textBoxName.Text = new ViewModel.Basic.Suppliers().GetListByID(SuppliersCode, ref str)[0].Name;
            TextBoxAddress.Text = new ViewModel.Basic.Suppliers().GetListByID(SuppliersCode, ref str)[0].Address;
            TextBoxTel.Text = new ViewModel.Basic.Suppliers().GetListByID(SuppliersCode, ref str)[0].Tel;
            TextBoxDescription.Text = new ViewModel.Basic.Suppliers().GetListByID(SuppliersCode, ref str)[0].Description;
            checkBoxIsActive.Checked = new ViewModel.Basic.Suppliers().GetListByID(SuppliersCode, ref str)[0].IsActive;
            _editIns = true;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckValidation())
                return;
            try
            {
                string str = "";
                List<TBL_Supplier> Ls = new List<TBL_Supplier>(1);
                TBL_Supplier Suppliers = new TBL_Supplier();
                Suppliers.Id = _SuppliersCode;
                Suppliers.Name = textBoxName.Text;
                Suppliers.Tel = TextBoxTel.Text;
                Suppliers.Address = TextBoxAddress.Text;
                Suppliers.Description = TextBoxDescription.Text;
                Suppliers.IsActive = checkBoxIsActive.Checked;
                Ls.Add(Suppliers);

                if (!_editIns)
                {
                    new ViewModel.Basic.Suppliers().InsertEntity(Ls, ref str);
                }
                else
                {
                    new ViewModel.Basic.Suppliers().UpdateEntity(Ls, ref str);
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
            if (textBoxName.Text.Trim() == "")
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
