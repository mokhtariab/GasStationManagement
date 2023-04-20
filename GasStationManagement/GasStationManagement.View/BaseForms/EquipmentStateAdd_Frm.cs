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
    public partial class EquipmentStateAdd_Frm : MSS.Library.Forms.MSSBaseNew_frm
    {
        private byte _EquipmentStateCode = 0;
        private bool _editIns = false;

        public EquipmentStateAdd_Frm()
        {
            InitializeComponent();
        }

        public EquipmentStateAdd_Frm(byte EquipmentStateCode)
        {
            InitializeComponent();
            _EquipmentStateCode = EquipmentStateCode;
            string str = "";
            textBoxEquipmentStateDsc.Text = new ViewModel.Basic.EquipmentState().GetListByID(EquipmentStateCode, ref str)[0].Name;
            checkBoxIsActive.Checked = new ViewModel.Basic.EquipmentState().GetListByID(EquipmentStateCode, ref str)[0].IsActive;
            _editIns = true;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckValidation())
                return;
            try
            {
                string str = "";
                List<TBL_EquipmentState> Ls = new List<TBL_EquipmentState>(1);
                TBL_EquipmentState EquipmentState = new TBL_EquipmentState();
                EquipmentState.Id = _EquipmentStateCode;
                EquipmentState.Name = textBoxEquipmentStateDsc.Text;
                EquipmentState.IsActive = checkBoxIsActive.Checked;
                Ls.Add(EquipmentState);

                if (!_editIns)
                {
                    new ViewModel.Basic.EquipmentState().InsertEntity(Ls, ref str);
                }
                else
                {
                    new ViewModel.Basic.EquipmentState().UpdateEntity(Ls, ref str);
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
            if (textBoxEquipmentStateDsc.Text.Trim() == "")
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
