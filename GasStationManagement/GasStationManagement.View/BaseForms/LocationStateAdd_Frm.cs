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
    public partial class LocationStateAdd_Frm : MSS.Library.Forms.MSSBaseNew_frm
    {
        private byte _LocationStateCode = 0;
        private bool _editIns = false;

        public LocationStateAdd_Frm()
        {
            InitializeComponent();
        }

        public LocationStateAdd_Frm(byte LocationStateCode)
        {
            InitializeComponent();
            _LocationStateCode = LocationStateCode;
            string str = "";
            textBoxLocationStateDsc.Text = new ViewModel.Basic.LocationState().GetListByID(LocationStateCode, ref str)[0].Name;
            checkBoxIsActive.Checked = new ViewModel.Basic.LocationState().GetListByID(LocationStateCode, ref str)[0].IsActive;
            _editIns = true;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckValidation())
                return;
            try
            {
                string str = "";
                List<TBL_LocationState> Ls = new List<TBL_LocationState>(1);
                TBL_LocationState LocationState = new TBL_LocationState();
                LocationState.Id = _LocationStateCode;
                LocationState.Name = textBoxLocationStateDsc.Text;
                LocationState.IsActive = checkBoxIsActive.Checked;
                Ls.Add(LocationState);

                if (!_editIns)
                {
                    new ViewModel.Basic.LocationState().InsertEntity(Ls, ref str);
                }
                else
                {
                    new ViewModel.Basic.LocationState().UpdateEntity(Ls, ref str);
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
            if (textBoxLocationStateDsc.Text.Trim() == "")
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
