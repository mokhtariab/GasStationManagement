using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using GasStationManagement.Model.Basic.DataAccess;
using GasStationManagement.Model.CounterState;


namespace GasStationManagement.View.MainForms.Counter
{
    public partial class CounterStateAdd_Frm : MSS.Library.Forms.MSSBaseNew_frm
    {
        private byte _CounterStateCode = 0;
        private bool _editIns = false;

        public CounterStateAdd_Frm()
        {
            InitializeComponent();
        }

        public CounterStateAdd_Frm(byte CounterStateCode)
        {
            InitializeComponent();
            _CounterStateCode = CounterStateCode;
            string str = "";
            //textBoxCounterStateDsc.Text = new ViewModel.CounterState.CounterState().GetListByID(CounterStateCode, ref str)[0].Brand;
            checkBoxIsActive.Checked = new ViewModel.CounterState.CounterState().GetListByID(CounterStateCode, ref str)[0].IsActive.Value;
            _editIns = true;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckValidation())
                return;
            try
            {
                string str = "";
                List<TBL_CounterState> Ls = new List<TBL_CounterState>(1);
                TBL_CounterState CounterState = new TBL_CounterState();
                //CounterState.Id = _CounterStateCode;
                CounterState.Description = textBoxCounterStateDsc.Text;
                CounterState.IsActive = checkBoxIsActive.Checked;
                Ls.Add(CounterState);

                if (!_editIns)
                {
                    new ViewModel.CounterState.CounterState().InsertEntity(Ls, ref str);
                }
                else
                {
                    new ViewModel.CounterState.CounterState().UpdateEntity(Ls, ref str);
                }

                MSS.Library.Clasess.MSSMessage.MSSMessage_View("اطلاعات ذخیره شد", MSS.Library.Clasess.MSSMessage.MessageType.SInformation);
                Close();
            }
            catch
            {
                MSS.Library.Clasess.MSSMessage.MSSMessage_View("اشکال در ذخیره اطلاعات", MSS.Library.Clasess.MSSMessage.MessageType.SError);
            }

        }


        private bool CheckValidation()
        {
            if (textBoxCounterStateDsc.Text.Trim() == "")
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
