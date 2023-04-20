using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using GasStationManagement.Model.Basic.DataAccess;


namespace GasStationManagement.View.MainForms.TemTrans
{
    public partial class TemTransAdd_Frm : MSS.Library.Forms.MSSBaseNew_frm
    {
        private int _id = 0;
        private bool _editIns = false;


         public TemTransAdd_Frm()
        {
            InitializeComponent();
        }


        public TemTransAdd_Frm(int Id)
        {
            InitializeComponent();
            _id = Id;
            _editIns = true;
        }

        private void TemTransAdd_Frm_Load(object sender, EventArgs e)
        {
            if (_editIns) fillControl();
        }

        private void fillControl()
        {
            string str = "";
            ViewModel.Basic.TemperatureTransmitter RN = new ViewModel.Basic.TemperatureTransmitter();

            textBoxBrand.Text = RN.GetListByID(_id, ref str)[0].Brand;
            TextBoxModel.Text = RN.GetListByID(_id, ref str)[0].Model;

            CheckBoxHMIState.Checked = RN.GetListByID(_id, ref str)[0].HMIState;
            IntBoxPacketLength.Value = RN.GetListByID(_id, ref str)[0].PacketLength;
            ComboBoxSensorType.Text = RN.GetListByID(_id, ref str)[0].SensorType;
            IntBoxTMin.Value = RN.GetListByID(_id, ref str)[0].TMin;
            IntBoxTMax.Value = RN.GetListByID(_id, ref str)[0].TMax;
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
                List<TBL_TemperatureTransmitter> Ls = new List<TBL_TemperatureTransmitter>(1);
                TBL_TemperatureTransmitter TemTrans = new TBL_TemperatureTransmitter();
                TemTrans.Id = _id;

                TemTrans.Model = TextBoxModel.Text;
                TemTrans.Brand = textBoxBrand.Text;

                TemTrans.HMIState = Convert.ToBoolean(CheckBoxHMIState.Checked);
                TemTrans.PacketLength = Convert.ToDouble(IntBoxPacketLength.Text);
                TemTrans.SensorType = ComboBoxSensorType.Text;
                TemTrans.TMin = IntBoxTMin.Text.ToInt();
                TemTrans.TMax = IntBoxTMax.Text.ToInt();
                TemTrans.CalibrationDuration = IntBoxCalibrationDuration.Text.ToInt();

                TemTrans.Description = TextBoxDescription.Text;
                TemTrans.IsActive = Convert.ToBoolean(checkBoxIsActive.Checked);

                Ls.Add(TemTrans);

                if (!_editIns)
                {
                    new ViewModel.Basic.TemperatureTransmitter().InsertEntity(Ls, ref str);
                }
                else
                {
                    new ViewModel.Basic.TemperatureTransmitter().UpdateEntity(Ls, ref str);
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
            if (IntBoxPacketLength.Text.Trim() == "")
            {
                MSS.Library.Clasess.MSSMessage.MSSMessage_View("لطفا طول پاکت را پر نمایید", MSS.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                return false;
            }
            if (ComboBoxSensorType.SelectedItem == "")
            {
                MSS.Library.Clasess.MSSMessage.MSSMessage_View("لطفا نوع سنسور دما را پر نمایید", MSS.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                return false;
            }
            if (IntBoxCalibrationDuration.Text.Trim() == "")
            {
                MSS.Library.Clasess.MSSMessage.MSSMessage_View("لطفا دوره کالیبراسیون را پر نمایید", MSS.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                return false;
            }
            return true;
        }

    }
}
