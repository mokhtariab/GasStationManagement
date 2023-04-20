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
    public partial class MonitoringSysStateAdd_Frm : MSS.Library.Forms.MSSBaseNew_frm
    {
        private byte _MonitoringSysStateCode = 0;
        private bool _editIns = false;

        public MonitoringSysStateAdd_Frm()
        {
            InitializeComponent();
        }

        public MonitoringSysStateAdd_Frm(byte MonitoringSysStateCode)
        {
            InitializeComponent();
            _MonitoringSysStateCode = MonitoringSysStateCode;
            string str = "";
            textBoxMonitoringSysStateDsc.Text = new ViewModel.Basic.MonitoringSysState().GetListByID(MonitoringSysStateCode, ref str)[0].Name;
            checkBoxIsActive.Checked = new ViewModel.Basic.MonitoringSysState().GetListByID(MonitoringSysStateCode, ref str)[0].IsActive;
            _editIns = true;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckValidation())
                return;
            try
            {
                string str = "";
                List<TBL_MonitoringSysState> Ls = new List<TBL_MonitoringSysState>(1);
                TBL_MonitoringSysState MonitoringSysState = new TBL_MonitoringSysState();
                MonitoringSysState.Id = _MonitoringSysStateCode;
                MonitoringSysState.Name = textBoxMonitoringSysStateDsc.Text;
                MonitoringSysState.IsActive = checkBoxIsActive.Checked;
                Ls.Add(MonitoringSysState);

                if (!_editIns)
                {
                    new ViewModel.Basic.MonitoringSysState().InsertEntity(Ls, ref str);
                }
                else
                {
                    new ViewModel.Basic.MonitoringSysState().UpdateEntity(Ls, ref str);
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
            if (textBoxMonitoringSysStateDsc.Text.Trim() == "")
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
