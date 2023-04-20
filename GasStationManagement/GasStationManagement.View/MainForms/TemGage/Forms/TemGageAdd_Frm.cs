using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using GasStationManagement.Model.Basic.DataAccess;


namespace GasStationManagement.View.MainForms.TemGage
{
    public partial class TemGageAdd_Frm : MSS.Library.Forms.MSSBaseNew_frm
    {
        private int _id = 0;
        private bool _editIns = false;


         public TemGageAdd_Frm()
        {
            InitializeComponent();
        }


        public TemGageAdd_Frm(int Id)
        {
            InitializeComponent();
            _id = Id;
            _editIns = true;
        }

        private void TemGageAdd_Frm_Load(object sender, EventArgs e)
        {
            SetComboBox();

            if (_editIns) fillControl();
        }

        private void SetComboBox()
        {
            string str = "";
            //ComboBoxSize.DataSource = new ViewModel.Basic.TemGage().GetList(ref str).Single().Size.ToString().Distinct();
            //ComboBoxClass.DataSource = new ViewModel.Basic.TemGage().GetList(ref str).Single().Class.Distinct();
            //ComboBoxGrate.DataSource = new ViewModel.Basic.TemGage().GetList(ref str).Single().Grate.ToString().Distinct();
        }

        private void fillControl()
        {
            string str = "";
            ViewModel.Basic.TemperatureGage RN = new ViewModel.Basic.TemperatureGage();

            textBoxBrand.Text = RN.GetListByID(_id, ref str)[0].Brand;

            IntBoxGageSize.Value = RN.GetListByID(_id, ref str)[0].GageSize;
            IntBoxPacketLength.Value = RN.GetListByID(_id, ref str)[0].PacketLength;
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
                List<TBL_TemperatureGage> Ls = new List<TBL_TemperatureGage>(1);
                TBL_TemperatureGage TemGage = new TBL_TemperatureGage();
                TemGage.Id = _id;

                TemGage.Brand = textBoxBrand.Text;

                TemGage.GageSize = Convert.ToDouble(IntBoxGageSize.Value);
                TemGage.PacketLength = Convert.ToDouble(IntBoxPacketLength.Value);
                TemGage.TMin = IntBoxTMin.Text.ToInt();
                TemGage.TMax = IntBoxTMax.Text.ToInt();

                TemGage.CalibrationDuration = IntBoxCalibrationDuration.Text.ToInt();

                TemGage.Description = TextBoxDescription.Text;
                TemGage.IsActive = Convert.ToBoolean(checkBoxIsActive.Checked);

                Ls.Add(TemGage);

                if (!_editIns)
                {
                    new ViewModel.Basic.TemperatureGage().InsertEntity(Ls, ref str);
                }
                else
                {
                    new ViewModel.Basic.TemperatureGage().UpdateEntity(Ls, ref str);
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
            if (textBoxBrand.Text.Trim() == "")
            {
                MSS.Library.Clasess.MSSMessage.MSSMessage_View("لطفا برند را پر نمایید", MSS.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                return false;
            }
            if (IntBoxGageSize.Text.Trim() == "")
            {
                MSS.Library.Clasess.MSSMessage.MSSMessage_View("لطفا سایز صفحه را پر نمایید", MSS.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                return false;
            }
            if (IntBoxPacketLength.Text.Trim() == "")
            {
                MSS.Library.Clasess.MSSMessage.MSSMessage_View("لطفا طول پاکت را پر نمایید", MSS.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                return false;
            }
            if (IntBoxTMin.Text.Trim() == "")
            {
                MSS.Library.Clasess.MSSMessage.MSSMessage_View("لطفا گستره دما از را پر نمایید", MSS.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                return false;
            }
            if (IntBoxTMax.Text.Trim() == "")
            {
                MSS.Library.Clasess.MSSMessage.MSSMessage_View("لطفا گستره دما تا را پر نمایید", MSS.Library.Clasess.MSSMessage.MessageType.SConfirmation);
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
