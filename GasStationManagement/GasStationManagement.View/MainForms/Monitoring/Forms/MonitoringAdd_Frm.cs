using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using GasStationManagement.Model.Basic.DataAccess;


namespace GasStationManagement.View.MainForms.Monitoring
{
    public partial class MonitoringAdd_Frm : MSS.Library.Forms.MSSBaseNew_frm
    {
        private int _id = 0;
        private bool _editIns = false;


         public MonitoringAdd_Frm()
        {
            InitializeComponent();
        }


        public MonitoringAdd_Frm(int Id)
        {
            InitializeComponent();
            _id = Id;
            _editIns = true;
        }

        private void MonitoringAdd_Frm_Load(object sender, EventArgs e)
        {
            SetComboBox();

            if (_editIns) fillControl();
        }

        private void SetComboBox()
        {
            string str = "";
            try { ComboBoxSize.DataSource = new ViewModel.Basic.Monitoring().GetList(ref str).Single().Size.ToString().Distinct(); } catch { }
            try { ComboBoxClass.DataSource = new ViewModel.Basic.Monitoring().GetList(ref str).Single().Class.Distinct(); } catch { }
            try { ComboBoxGrate.DataSource = new ViewModel.Basic.Monitoring().GetList(ref str).Single().Grate.ToString().Distinct(); } catch { }
        }

        private void fillControl()
        {
            string str = "";
            ViewModel.Basic.Monitoring RN = new ViewModel.Basic.Monitoring();


            textBoxBrand.Text = RN.GetListByID(_id, ref str)[0].Brand;
            ComboBoxSize.Text = RN.GetListByID(_id, ref str)[0].Size.ToString();

            ComboBoxClass.Text = RN.GetListByID(_id, ref str)[0].Class;
            ComboBoxGrate.Text = RN.GetListByID(_id, ref str)[0].Grate.ToString();

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
                List<TBL_Monitoring> Ls = new List<TBL_Monitoring>(1);
                TBL_Monitoring Monitoring = new TBL_Monitoring();
                Monitoring.ID = _id;

                Monitoring.Brand = textBoxBrand.Text;

                Monitoring.Size = Convert.ToDouble(ComboBoxSize.Text);
                Monitoring.Class = ComboBoxClass.Text;
                Monitoring.Grate = Convert.ToInt32(ComboBoxGrate.Text);

                Monitoring.Description = TextBoxDescription.Text;
                Monitoring.IsActive = Convert.ToBoolean(checkBoxIsActive.Checked);

                Ls.Add(Monitoring);

                if (!_editIns)
                {
                    new ViewModel.Basic.Monitoring().InsertEntity(Ls, ref str);
                }
                else
                {
                    new ViewModel.Basic.Monitoring().UpdateEntity(Ls, ref str);
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


    }
}
