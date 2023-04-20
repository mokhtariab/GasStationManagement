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
    public partial class CounterInsLocAdd_Frm : MSS.Library.Forms.MSSBaseNew_frm
    {
        private byte _CounterInsLocCode = 0;
        private bool _editIns = false;

        public CounterInsLocAdd_Frm()
        {
            InitializeComponent();
        }

        public CounterInsLocAdd_Frm(byte CounterInsLocCode)
        {
            InitializeComponent();
            _CounterInsLocCode = CounterInsLocCode;
            string str = "";
            textBoxCounterInsLocDsc.Text = new ViewModel.Basic.CounterInsLoc().GetListByID(CounterInsLocCode, ref str)[0].Name;
            checkBoxIsActive.Checked = new ViewModel.Basic.CounterInsLoc().GetListByID(CounterInsLocCode, ref str)[0].IsActive;
            _editIns = true;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckValidation())
                return;
            try
            {
                string str = "";
                List<TBL_CounterInsLoc> Ls = new List<TBL_CounterInsLoc>(1);
                TBL_CounterInsLoc CounterInsLoc = new TBL_CounterInsLoc();
                CounterInsLoc.Id = _CounterInsLocCode;
                CounterInsLoc.Name = textBoxCounterInsLocDsc.Text;
                CounterInsLoc.IsActive = checkBoxIsActive.Checked;
                Ls.Add(CounterInsLoc);

                if (!_editIns)
                {
                    new ViewModel.Basic.CounterInsLoc().InsertEntity(Ls, ref str);
                }
                else
                {
                    new ViewModel.Basic.CounterInsLoc().UpdateEntity(Ls, ref str);
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
            if (textBoxCounterInsLocDsc.Text.Trim() == "")
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
