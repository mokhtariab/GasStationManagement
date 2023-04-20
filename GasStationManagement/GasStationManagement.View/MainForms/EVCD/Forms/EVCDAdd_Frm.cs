using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using GasStationManagement.Model.Basic.DataAccess;


namespace GasStationManagement.View.MainForms.EVCD
{
    public partial class EVCDAdd_Frm : MSS.Library.Forms.MSSBaseNew_frm
    {
        private int _id = 0;
        private bool _editIns = false;


         public EVCDAdd_Frm()
        {
            InitializeComponent();
        }


        public EVCDAdd_Frm(int Id)
        {
            InitializeComponent();
            _id = Id;
            _editIns = true;
        }

        private void EVCDAdd_Frm_Load(object sender, EventArgs e)
        {
            SetComboBox();

            if (_editIns) fillControl();
        }

        private void SetComboBox()
        {
            string str = "";
            //ComboBoxSize.DataSource = new ViewModel.Basic.EVCD().GetList(ref str).Single().Size.ToString().Distinct();
            //ComboBoxClass.DataSource = new ViewModel.Basic.EVCD().GetList(ref str).Single().Class.Distinct();
            //ComboBoxGrate.DataSource = new ViewModel.Basic.EVCD().GetList(ref str).Single().Grate.ToString().Distinct();
        }

        private void fillControl()
        {
            string str = "";
            ViewModel.Basic.EVCD RN = new ViewModel.Basic.EVCD();

            TextBoxModel.Text = RN.GetListByID(_id, ref str)[0].Model;
            textBoxBrand.Text = RN.GetListByID(_id, ref str)[0].Brand;

            IntBoxPMin.Value = RN.GetListByID(_id, ref str)[0].PMin;
            IntBoxPMax.Value = RN.GetListByID(_id, ref str)[0].PMax;
            IntBoxCalibrationDuration.Value = RN.GetListByID(_id, ref str)[0].CalibrationDuration;
            TextBoxDescription.Text = RN.GetListByID(_id, ref str)[0].Description;
            checkBoxIsActive.Checked = RN.GetListByID(_id, ref str)[0].IsActive.Value;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckValidation())
                return;
            try
            {
                string str = "";
                List<TBL_EVCD> Ls = new List<TBL_EVCD>(1);
                TBL_EVCD EVCD = new TBL_EVCD();
                EVCD.Id = _id;

                EVCD.Model = TextBoxModel.Text;
                EVCD.Brand = textBoxBrand.Text;

                EVCD.PMin = IntBoxPMin.Text.ToInt();
                EVCD.PMax = IntBoxPMax.Text.ToInt();
                EVCD.CalibrationDuration = IntBoxCalibrationDuration.Text.ToInt();

                EVCD.Description = TextBoxDescription.Text;
                EVCD.IsActive = Convert.ToBoolean(checkBoxIsActive.Checked);

                Ls.Add(EVCD);

                if (!_editIns)
                {
                    new ViewModel.Basic.EVCD().InsertEntity(Ls, ref str);
                }
                else
                {
                    new ViewModel.Basic.EVCD().UpdateEntity(Ls, ref str);
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
            if (IntBoxPMin.Text.Trim() == "")
            {
                MSS.Library.Clasess.MSSMessage.MSSMessage_View("لطفا گستره فشار کاری psi از را پر نمایید", MSS.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                return false;
            }
            if (IntBoxPMax.Text.Trim() == "")
            {
                MSS.Library.Clasess.MSSMessage.MSSMessage_View("لطفا گستره فشار کاری psi تا را پر نمایید", MSS.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                return false;
            }
            if (IntBoxCalibrationDuration.Text.Trim() == "")
            {
                MSS.Library.Clasess.MSSMessage.MSSMessage_View("لطفا دوره کالیبراسیون را پر نمایید", MSS.Library.Clasess.MSSMessage.MessageType.SConfirmation);
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
