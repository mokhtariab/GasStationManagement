using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using GasStationManagement.Model.Basic.DataAccess;


namespace GasStationManagement.View.MainForms.PressTrans
{
    public partial class PressTransAdd_Frm : MSS.Library.Forms.MSSBaseNew_frm
    {
        private int _id = 0;
        private bool _editIns = false;


         public PressTransAdd_Frm()
        {
            InitializeComponent();
        }


        public PressTransAdd_Frm(int Id)
        {
            InitializeComponent();
            _id = Id;
            _editIns = true;
        }

        private void PressTransAdd_Frm_Load(object sender, EventArgs e)
        {
            if (_editIns) fillControl();
        }

        private void fillControl()
        {
            string str = "";
            ViewModel.Basic.PressureTransmitter RN = new ViewModel.Basic.PressureTransmitter();

            TextBoxModel.Text = RN.GetListByID(_id, ref str)[0].Model;
            textBoxBrand.Text = RN.GetListByID(_id, ref str)[0].Brand;

            CheckBoxHMIState.Checked = RN.GetListByID(_id, ref str)[0].HMIState;
            IntBoxPMax.Value = RN.GetListByID(_id, ref str)[0].PMax;
            IntBoxCalibrationDuration.Value = RN.GetListByID(_id, ref str)[0].CalibrationDuration;
            TextBoxDescription.Text = RN.GetListByID(_id, ref str)[0].Description;
            checkBoxIsActive.Checked = RN.GetListByID(_id, ref str)[0].IsActive;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckValidation())
                return;
            try
            {
                string str = "";
                List<TBL_PressureTransmitter> Ls = new List<TBL_PressureTransmitter>(1);
                TBL_PressureTransmitter PressTrans = new TBL_PressureTransmitter();
                PressTrans.Id = _id;

                PressTrans.Model = TextBoxModel.Text;
                PressTrans.Brand = textBoxBrand.Text;

                PressTrans.HMIState = Convert.ToBoolean(CheckBoxHMIState.Checked);
                PressTrans.PMax = IntBoxPMax.Text.ToInt();
                PressTrans.CalibrationDuration = IntBoxCalibrationDuration.Text.ToInt();

                PressTrans.Description = TextBoxDescription.Text;
                PressTrans.IsActive = Convert.ToBoolean(checkBoxIsActive.Checked);

                Ls.Add(PressTrans);

                if (!_editIns)
                {
                    new ViewModel.Basic.PressureTransmitter().InsertEntity(Ls, ref str);
                }
                else
                {
                    new ViewModel.Basic.PressureTransmitter().UpdateEntity(Ls, ref str);
                }
                if (str != "")
                    MSS.Library.Clasess.MSSMessage.MSSMessage_View(0, MSS.Library.Clasess.MSSMessage.MessageType.SError, false, "اشکال اطلاعات", str);
                else
                {
                    MSS.Library.Clasess.MSSMessage.MSSMessage_View("اطلاعات ذخیره شد", MSS.Library.Clasess.MSSMessage.MessageType.SInformation);

                    Close();
                }
            }
            catch (Exception ex)
            {
                MSS.Library.Clasess.MSSMessage.MSSMessage_View(0, MSS.Library.Clasess.MSSMessage.MessageType.SError, false, ex.Message);
            }

        }



        private bool CheckValidation()
        {
            if (TextBoxModel.Text.Trim() == "")
            {
                MSS.Library.Clasess.MSSMessage.MSSMessage_View("لطفا مدل را پر نمایید", MSS.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                return false;
            }
            if (textBoxBrand.Text.Trim() == "")
            {
                MSS.Library.Clasess.MSSMessage.MSSMessage_View("لطفا برند را پر نمایید", MSS.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                return false;
            }
            //if (IntBoxPMax.Text == "0")
            //{
            //    MSS.Library.Clasess.MSSMessage.MSSMessage_View("لطفا فشار بیشینه psi را پر نمایید", MSS.Library.Clasess.MSSMessage.MessageType.SConfirmation);
            //    return false;
            //}
            if (IntBoxCalibrationDuration.Text.Trim() == "")
            {
                MSS.Library.Clasess.MSSMessage.MSSMessage_View("لطفا دوره کالیبراسیون را پر نمایید", MSS.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                return false;
            }
            return true;
        }

    }
}
