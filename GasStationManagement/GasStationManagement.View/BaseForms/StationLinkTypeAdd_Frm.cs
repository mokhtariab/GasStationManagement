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
    public partial class StationLinkTypeAdd_Frm : MSS.Library.Forms.MSSBaseNew_frm
    {
        private byte _StationLinkTypeCode = 0;
        private bool _editIns = false;

        public StationLinkTypeAdd_Frm()
        {
            InitializeComponent();
        }

        public StationLinkTypeAdd_Frm(byte StationLinkTypeCode)
        {
            InitializeComponent();
            _StationLinkTypeCode = StationLinkTypeCode;
            string str = "";
            textBoxStationLinkTypeDsc.Text = new ViewModel.Basic.StationLinkType().GetListByID(StationLinkTypeCode, ref str)[0].Name;
            TextBoxDescription.Text = new ViewModel.Basic.StationLinkType().GetListByID(StationLinkTypeCode, ref str)[0].Description;
            checkBoxIsActive.Checked = new ViewModel.Basic.StationLinkType().GetListByID(StationLinkTypeCode, ref str)[0].IsActive;
            _editIns = true;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckValidation())
                return;
            try
            {
                string str = "";
                List<TBL_StationLinkType> Ls = new List<TBL_StationLinkType>(1);
                TBL_StationLinkType StationLinkType = new TBL_StationLinkType();
                StationLinkType.Id = _StationLinkTypeCode;
                StationLinkType.Name = textBoxStationLinkTypeDsc.Text;
                StationLinkType.Description = TextBoxDescription.Text;
                StationLinkType.IsActive = checkBoxIsActive.Checked;
                Ls.Add(StationLinkType);

                if (!_editIns)
                {
                    new ViewModel.Basic.StationLinkType().InsertEntity(Ls, ref str);
                }
                else
                {
                    new ViewModel.Basic.StationLinkType().UpdateEntity(Ls, ref str);
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
            if (textBoxStationLinkTypeDsc.Text.Trim() == "")
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
