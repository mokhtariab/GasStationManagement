using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using GasStationManagement.Model.Basic.DataAccess;


namespace GasStationManagement.View.MainForms.PressGage
{
    public partial class PressGageAdd_Frm : MSS.Library.Forms.MSSBaseNew_frm
    {
        private int _id = 0;
        private bool _editIns = false;


         public PressGageAdd_Frm()
        {
            InitializeComponent();
        }


        public PressGageAdd_Frm(int Id)
        {
            InitializeComponent();
            _id = Id;
            _editIns = true;
        }

        private void PressGageAdd_Frm_Load(object sender, EventArgs e)
        {
            SetComboBox();

            if (_editIns) fillControl();
        }

        private void SetComboBox()
        {
            string str = "";
            //ComboBoxSize.DataSource = new ViewModel.Basic.PressGage().GetList(ref str).Single().Size.ToString().Distinct();
            //ComboBoxClass.DataSource = new ViewModel.Basic.PressGage().GetList(ref str).Single().Class.Distinct();
            //ComboBoxGrate.DataSource = new ViewModel.Basic.PressGage().GetList(ref str).Single().Grate.ToString().Distinct();
        }

        private void fillControl()
        {
            string str = "";
            ViewModel.Basic.PressureGage RN = new ViewModel.Basic.PressureGage();

            textBoxBrand.Text = RN.GetListByID(_id, ref str)[0].Brand;

            IntBoxGageSize.Value = RN.GetListByID(_id, ref str)[0].GageSize;
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
                List<TBL_PressureGage> Ls = new List<TBL_PressureGage>(1);
                TBL_PressureGage PressGage = new TBL_PressureGage();
                PressGage.Id = _id;

                PressGage.Brand = textBoxBrand.Text;

                PressGage.GageSize = IntBoxGageSize.Text.ToInt();
                PressGage.PMax = IntBoxPMax.Text.ToInt();
                PressGage.CalibrationDuration = IntBoxCalibrationDuration.Text.ToInt();

                PressGage.Description = TextBoxDescription.Text;
                PressGage.IsActive = Convert.ToBoolean(checkBoxIsActive.Checked);

                Ls.Add(PressGage);

                if (!_editIns)
                {
                    new ViewModel.Basic.PressureGage().InsertEntity(Ls, ref str);
                }
                else
                {
                    new ViewModel.Basic.PressureGage().UpdateEntity(Ls, ref str);
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
            if (IntBoxPMax.Text.Trim() == "")
            {
                MSS.Library.Clasess.MSSMessage.MSSMessage_View("لطفا فشار بیشینه psi را پر نمایید", MSS.Library.Clasess.MSSMessage.MessageType.SConfirmation);
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
