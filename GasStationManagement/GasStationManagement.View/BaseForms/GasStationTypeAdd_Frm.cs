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
    public partial class GasStationTypeAdd_Frm : MSS.Library.Forms.MSSBaseNew_frm
    {
        private byte _GasStationTypeCode = 0;
        private bool _editIns = false;

        public GasStationTypeAdd_Frm()
        {
            InitializeComponent();
        }

        public GasStationTypeAdd_Frm(byte GasStationTypeCode)
        {
            InitializeComponent();
            _GasStationTypeCode = GasStationTypeCode;
            string str = "";
            textBoxGasStationTypeDsc.Text = new ViewModel.Basic.GasStationType().GetListByID(GasStationTypeCode, ref str)[0].Name;
            checkBoxIsActive.Checked = new ViewModel.Basic.GasStationType().GetListByID(GasStationTypeCode, ref str)[0].IsActive;
            _editIns = true;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckValidation())
                return;
            try
            {
                string str = "";
                List<TBL_GasStationType> Ls = new List<TBL_GasStationType>(1);
                TBL_GasStationType GasStationType = new TBL_GasStationType();
                GasStationType.Id = _GasStationTypeCode;
                GasStationType.Name = textBoxGasStationTypeDsc.Text;
                GasStationType.IsActive = checkBoxIsActive.Checked;
                Ls.Add(GasStationType);

                if (!_editIns)
                {
                    new ViewModel.Basic.GasStationType().InsertEntity(Ls, ref str);
                }
                else
                {
                    new ViewModel.Basic.GasStationType().UpdateEntity(Ls, ref str);
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
            if (textBoxGasStationTypeDsc.Text.Trim() == "")
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
