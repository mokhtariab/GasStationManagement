using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using GasStationManagement.Model.Basic.DataAccess;


namespace GasStationManagement.View.MainForms.Counter
{
    public partial class CounterAdd_Frm : MSS.Library.Forms.MSSBaseNew_frm
    {
        private int _id = 0;
        private bool _editIns = false;


         public CounterAdd_Frm()
        {
            InitializeComponent();
        }


        public CounterAdd_Frm(int Id)
        {
            InitializeComponent();
            _id = Id;
            _editIns = true;
        }

        private void CounterAdd_Frm_Load(object sender, EventArgs e)
        {
            SetComboBox();

            if (_editIns) fillControl();
        }

        private void SetComboBox()
        {
            string str = "";
            try { ComboBoxSize.DataSource = new ViewModel.Basic.Counter().GetList(ref str).Single().Size.ToString().Distinct(); }
            catch { }
            try { ComboBoxClass.DataSource = new ViewModel.Basic.Counter().GetList(ref str).Single().Class.Distinct(); }
            catch { }
            try { ComboBoxGrate.DataSource = new ViewModel.Basic.Counter().GetList(ref str).Single().Grate.ToString().Distinct();}
            catch { }
        }

        private void fillControl()
        {
            string str = "";
            ViewModel.Basic.Counter RN = new ViewModel.Basic.Counter();


            textBoxBrand.Text = RN.GetListByID(_id, ref str)[0].Brand;
            ComboBoxSize.Text = RN.GetListByID(_id, ref str)[0].Size.ToString();

            ComboBoxClass.Text = RN.GetListByID(_id, ref str)[0].Class;
            ComboBoxGrate.Text = RN.GetListByID(_id, ref str)[0].Grate.ToString();

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
                List<TBL_Counter> Ls = new List<TBL_Counter>(1);
                TBL_Counter Counter = new TBL_Counter();
                Counter.Id = _id;

                Counter.Brand = textBoxBrand.Text;

                Counter.Size = Convert.ToDouble(ComboBoxSize.Text);
                Counter.Class = ComboBoxClass.Text;
                Counter.Grate = Convert.ToInt32(ComboBoxGrate.Text);

                Counter.CalibrationDuration = IntBoxCalibrationDuration.Text.ToInt();

                Counter.Description = TextBoxDescription.Text;
                Counter.IsActive = Convert.ToBoolean(checkBoxIsActive.Checked);

                Ls.Add(Counter);

                if (!_editIns)
                {
                    new ViewModel.Basic.Counter().InsertEntity(Ls, ref str);
                }
                else
                {
                    new ViewModel.Basic.Counter().UpdateEntity(Ls, ref str);
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
            if (ComboBoxSize.Text.Trim() == "")
            {
                MSS.Library.Clasess.MSSMessage.MSSMessage_View("لطفا سایز را پر نمایید", MSS.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                return false;
            }
            if (IntBoxCalibrationDuration.Text.Trim() == "")
            {
                MSS.Library.Clasess.MSSMessage.MSSMessage_View("لطفا دوره کالیبراسیون را پر نمایید", MSS.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                return false;
            }
            if (ComboBoxGrate.Text.Trim() == "")
            {
                MSS.Library.Clasess.MSSMessage.MSSMessage_View("لطفا G rate را پر نمایید", MSS.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                return false;
            }

            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }


        MSS.Library.Control.MSSComboBox tx = new MSS.Library.Control.MSSComboBox();
        private void ComboBoxSize_TextChanged(object sender, EventArgs e)
        {
            tx = (MSS.Library.Control.MSSComboBox)sender;
            string str = tx.Text;
            if (tx.Text != "")
            {
                try
                {
                    str = System.Int64.Parse(str, System.Globalization.NumberStyles.Number).ToString();
                }
                catch
                {
                    str = "";
                }
                tx.Text = str;
            }
        }
    }
}
