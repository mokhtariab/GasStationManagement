using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using GasStationManagement.Model.Basic.DataAccess;
using GasStationManagement.Model.MonitoringSupply;


namespace GasStationManagement.View.MainForms.Monitoring
{
    public partial class MonitoringSupplyAdd_Frm : MSS.Library.Forms.MSSBaseNew_frm
    {
        private int _id = 0;
        private string _monitoringSerialNo = "";
        private bool _editIns = false;


        public MonitoringSupplyAdd_Frm(int Id)
        {
            InitializeComponent();
            _id = Id;
        }


        public MonitoringSupplyAdd_Frm(int Id, string MonitoringSerialNo)
        {
            InitializeComponent();
            _id = Id;
            _monitoringSerialNo = MonitoringSerialNo;
            _editIns = true;
        }

        private void MonitoringSupplyAdd_Frm_Load(object sender, EventArgs e)
        {
            //SetComboBox();

            if (_editIns) fillControl();
        }

        //private void SetComboBox()
        //{
        //    string str = "";
        //    ComboBoxSize.DataSource = new ViewModel.Basic.MonitoringSupply().GetList(ref str).Single().Size.ToString().Distinct();
        //    ComboBoxClass.DataSource = new ViewModel.Basic.MonitoringSupply().GetList(ref str).Single().Class.Distinct();
        //    ComboBoxGrate.DataSource = new ViewModel.Basic.MonitoringSupply().GetList(ref str).Single().Grate.ToString().Distinct();
        //}

        private void fillControl()
        {
            string str = "";
            ViewModel.MonitoringSupply.MonitoringSupply RN = new ViewModel.MonitoringSupply.MonitoringSupply();

            textBoxMonitoring_Id.Text = _id.ToString();
            TextBoxMonitoringSerialNo.Text = _monitoringSerialNo;

            DatePickerSupplyDate.Text = RN.GetListByID(_id, ref str)[0].SupplyDate;

            TextBoxSuppliers_Id.Tag = RN.GetListByID(_id, ref str)[0].Suppliers_Id.ToString();
            IntBoxPrice.Value = RN.GetListByID(_id, ref str)[0].Price;

            TextBoxInitialVc.Text = RN.GetListByID(_id, ref str)[0].InitialVc.ToString();
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
                List<TBL_MonitoringSupply> Ls = new List<TBL_MonitoringSupply>(1);
                TBL_MonitoringSupply MonitoringSupply = new TBL_MonitoringSupply();
                MonitoringSupply.Monitoring_Id = _id;

                MonitoringSupply.MonitoringSerialNo = TextBoxMonitoringSerialNo.Text;

                MonitoringSupply.SupplyDate = DatePickerSupplyDate.Text;
                MonitoringSupply.Price = IntBoxPrice.Text.ToInt();

                MonitoringSupply.InitialVc = TextBoxInitialVc.Text;
                MonitoringSupply.Suppliers_Id = Convert.ToInt16(TextBoxSuppliers_Id.Tag.ToString());

                MonitoringSupply.Description = TextBoxDescription.Text;
                MonitoringSupply.IsActive = Convert.ToBoolean(checkBoxIsActive.Checked);

                Ls.Add(MonitoringSupply);

                if (!_editIns)
                {
                    new ViewModel.MonitoringSupply.MonitoringSupply().InsertEntity(Ls, ref str);
                }
                else
                {
                    new ViewModel.MonitoringSupply.MonitoringSupply().UpdateEntity(Ls, ref str);
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
            if (TextBoxMonitoringSerialNo.Text.Trim() == "")
            {
                MSS.Library.Clasess.MSSMessage.MSSMessage_View("لطفا سریال را پر نمایید", MSS.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                return false;
            }
            if (TextBoxInitialVc.Text.Trim() == "")
            {
                MSS.Library.Clasess.MSSMessage.MSSMessage_View("لطفا Vc اولیه را پر نمایید", MSS.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                return false;
            }
            if (TextBoxSuppliers_Id.Text.Trim() == "")
            {
                MSS.Library.Clasess.MSSMessage.MSSMessage_View("لطفا تامین کننده را پر نمایید", MSS.Library.Clasess.MSSMessage.MessageType.SConfirmation);
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
            try
            {
                TextBoxSuppliers_Id.Tag = SD1.Keys.ToList()[0];
                TextBoxSuppliers_Id.Text = SD1.Values.ToList()[0];
            }
            catch { }
        }

    }
}
