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
    public partial class WorkShopAdd_Frm : MSS.Library.Forms.MSSBaseNew_frm
    {
        private byte _WorkShopCode = 0;
        private bool _editIns = false;

        public WorkShopAdd_Frm()
        {
            InitializeComponent();
        }

        public WorkShopAdd_Frm(byte WorkShopCode)
        {
            InitializeComponent();
            _WorkShopCode = WorkShopCode;
            string str = "";
            textBoxWorkShopDsc.Text = new ViewModel.Basic.WorkShop().GetListByID(WorkShopCode, ref str)[0].Name;
            checkBoxIsActive.Checked = new ViewModel.Basic.WorkShop().GetListByID(WorkShopCode, ref str)[0].IsActive;
            _editIns = true;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckValidation())
                return;
            try
            {
                string str = "";
                List<TBL_WorkShop> Ls = new List<TBL_WorkShop>(1);
                TBL_WorkShop WorkShop = new TBL_WorkShop();
                WorkShop.Id = _WorkShopCode;
                WorkShop.Name = textBoxWorkShopDsc.Text;
                WorkShop.IsActive = checkBoxIsActive.Checked;
                Ls.Add(WorkShop);

                if (!_editIns)
                {
                    new ViewModel.Basic.WorkShop().InsertEntity(Ls, ref str);
                }
                else
                {
                    new ViewModel.Basic.WorkShop().UpdateEntity(Ls, ref str);
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
            if (textBoxWorkShopDsc.Text.Trim() == "")
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
