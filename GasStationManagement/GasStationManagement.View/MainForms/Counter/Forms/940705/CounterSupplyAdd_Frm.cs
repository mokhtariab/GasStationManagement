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
    public partial class CounterSupplyAdd_Frm : MSS.Library.Forms.MSSBaseNew_frm
    {
        private int _id = 0;
        private bool _editIns = false;


         public CounterSupplyAdd_Frm()
        {
            InitializeComponent();
        }


        public CounterSupplyAdd_Frm(int Id)
        {
            InitializeComponent();
            _id = Id;
            _editIns = true;
        }

        private void CounterSupplyAdd_Frm_Load(object sender, EventArgs e)
        {
            SetComboBox();

            if (_editIns) fillControl();
        }

        private void SetComboBox()
        {
            string str = "";
            ComboBoxSize.DataSource = new ViewModel.Basic.CounterSupply().GetList(ref str).Single().Size.ToString().Distinct();
            ComboBoxClass.DataSource = new ViewModel.Basic.CounterSupply().GetList(ref str).Single().Class.Distinct();
            ComboBoxGrate.DataSource = new ViewModel.Basic.CounterSupply().GetList(ref str).Single().Grate.ToString().Distinct();
        }

        private void fillControl()
        {
            string str = "";
            ViewModel.Basic.CounterSupply RN = new ViewModel.Basic.CounterSupply();


            textBoxCounter_Id.Text = RN.GetListByID(_id, ref str)[0].Brand;
            ComboBoxSize.Text = RN.GetListByID(_id, ref str)[0].Size.ToString();

            ComboBoxClass.Text = RN.GetListByID(_id, ref str)[0].Class;
            ComboBoxGrate.Text = RN.GetListByID(_id, ref str)[0].Grate.ToString();

            IntBoxPrice.Value = RN.GetListByID(_id, ref str)[0].CalibrationDuration;
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
                List<TBL_CounterSupply> Ls = new List<TBL_CounterSupply>(1);
                TBL_CounterSupply CounterSupply = new TBL_CounterSupply();
                CounterSupply.Id = _id;

                CounterSupply.Brand = textBoxCounter_Id.Text;

                CounterSupply.Size = Convert.ToDouble(ComboBoxSize.Text);
                CounterSupply.Class = ComboBoxClass.Text;
                CounterSupply.Grate = Convert.ToInt32(ComboBoxGrate.Text);

                CounterSupply.CalibrationDuration = IntBoxPrice.Text.ToInt();

                CounterSupply.Description = TextBoxDescription.Text;
                CounterSupply.IsActive = Convert.ToBoolean(checkBoxIsActive.Checked);

                Ls.Add(CounterSupply);

                if (!_editIns)
                {
                    new ViewModel.Basic.CounterSupply().InsertEntity(Ls, ref str);
                }
                else
                {
                    new ViewModel.Basic.CounterSupply().UpdateEntity(Ls, ref str);
                }
                if (str != "")
                    MSS.Library.Clasess.MSSMessage.MSSMessage_View(0, MSS.Library.Clasess.MSSMessage.MessageType.SError, false, "اشکال اطلاعات", str);
                else
                {
                    MSS.Library.Clasess.MSSMessage.MSSMessage_View("اطلاعات ذخیره شد", MSS.Library.Clasess.MSSMessage.MessageType.SInformation);

                    Close();
                }
            }
            catch
            {
                MSS.Library.Clasess.MSSMessage.MSSMessage_View("اشکال در ذخیره اطلاعات", MSS.Library.Clasess.MSSMessage.MessageType.SError);
            }

        }



        private bool CheckValidation()
        {
            if (textBoxCounter_Id.Text.Trim() == "")
            {
                MSS.Library.Clasess.MSSMessage.MSSMessage_View("لطفا برند را پر نمایید", MSS.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                return false;
            }
            if (ComboBoxSize.Text.Trim() == "")
            {
                MSS.Library.Clasess.MSSMessage.MSSMessage_View("لطفا سایز را پر نمایید", MSS.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                return false;
            }
            if (IntBoxPrice.Text.Trim() == "")
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

        private void ButtonSuppliers_Id_Click(object sender, EventArgs e)
        {
            string StrSet = "";
            Dictionary<string, string> SD = new Dictionary<string, string>();
            Dictionary<string, string> SD1 = new Dictionary<string, string>();

            foreach (var item in new ViewModel.Basic.Suppliers().GetList(ref StrSet))
                SD.Add(item.Id.ToString(), item.Name);

            SD1 = MSS.Library.Forms.MSSSelector_frm.SetDataSelect(SD);
            TextBoxSuppliers_Id.Tag = SD1.Keys.ToList()[0];
            TextBoxSuppliers_Id.Text = SD1.Values.ToList()[0];
        }


    }
}
