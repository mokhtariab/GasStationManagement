using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using GasStationManagement.Model.TemGageState;
using MSS.Library.Clasess.FilterClass;

namespace GasStationManagement.View.MainForms.TemGage
{
    public partial class TemGageStateAdd_Frm : MSS.Library.Forms.MSSBaseNew_frm
    {
        private int _TemGage_Id = 0;
        private string _TemGageSerialNo = "";
        private int _TemGageStateRow = 0;
        private int _gasStation_Id = 0;
        private bool _editIns = false;


        public TemGageStateAdd_Frm(int GasStation_Id)
        {
            InitializeComponent();
            _gasStation_Id = GasStation_Id;
            buttonTemGageSerialNo.Visible = true;
            
            ButtonGasStation.Visible = false;
            ButtonCalibration.Visible = false;
            ButtonStore.Visible = false;
            ButtonWorkShop.Visible = false;

            string StrSet = "";
            TextBoxGasStation_Id.Text = new ViewModel.GasStationClass.GasStationClass().GetListByID(GasStation_Id, ref StrSet).Single().GasStationCode + "-" + new ViewModel.GasStationClass.GasStationClass().GetListByID(GasStation_Id, ref StrSet).Single().GasStationName;
            TextBoxGasStation_Id.Tag = GasStation_Id;
        }

        public TemGageStateAdd_Frm(int TemGage_Id, string TemGageSerialNo)
        {
            InitializeComponent();
            _TemGage_Id = TemGage_Id;
            _TemGageSerialNo = TemGageSerialNo;
            
            string str = "";
            TextBoxTemGage_Id.Text = new ViewModel.Basic.TemperatureGage().GetListByID(_TemGage_Id, ref str).Single().Brand;
            TextBoxTemGageSerialNo.Text = _TemGageSerialNo;
        }


        public TemGageStateAdd_Frm(int TemGage_Id, string TemGageSerialNo, int TemGageStateRow)
        {
            InitializeComponent();
            _TemGage_Id = TemGage_Id;
            _TemGageSerialNo = TemGageSerialNo;
            _TemGageStateRow = TemGageStateRow;
            _editIns = true;
        }

        private void TemGageStateAdd_Frm_Load(object sender, EventArgs e)
        {
            SetComboBox();

            if (_editIns) fillControl();
        }

        private void SetComboBox()
        {
            string str = "";
            ComboBoxEquipmentState_Id.ValueMember = "Id";
            ComboBoxEquipmentState_Id.DisplayMember = "Name";
            ComboBoxEquipmentState_Id.DataSource = new ViewModel.Basic.EquipmentState().GetList(ref str);
        }

        private void fillControl()
        {
            string str = "";

            List<QueryFilter.ExpressionBuilder.Filter> Ls = new List<QueryFilter.ExpressionBuilder.Filter>();
            Ls.Add(new QueryFilter.ExpressionBuilder.Filter()
            {
                Operation = QueryFilter.ExpressionBuilder.Op.Equals,
                PropertyName = "TemGage_Id",
                Value = _TemGage_Id,
                OperationFilter = QueryFilter.ExpressionBuilder.OpFilter.And
            });
            Ls.Add(new QueryFilter.ExpressionBuilder.Filter()
            {
                Operation = QueryFilter.ExpressionBuilder.Op.Equals,
                PropertyName = "TemGageSerialNo",
                Value = _TemGageSerialNo,
                OperationFilter = QueryFilter.ExpressionBuilder.OpFilter.And
            });
            Ls.Add(new QueryFilter.ExpressionBuilder.Filter()
            {
                Operation = QueryFilter.ExpressionBuilder.Op.Equals,
                PropertyName = "TemGageStateRow",
                Value = _TemGageStateRow,
                OperationFilter = QueryFilter.ExpressionBuilder.OpFilter.And
            }); 
            
            ViewModel.TemGageState.TemGageState RN = new ViewModel.TemGageState.TemGageState();
            List<VW_TemGageState> ListTemGageState = RN.GetListByFilter(Ls, ref str);

            TextBoxTemGage_Id.Text = ListTemGageState[0].Brand;
            TextBoxTemGageSerialNo.Text = _TemGageSerialNo.ToString();

            DatePickerChangeStateDate.Text = ListTemGageState[0].ChangeStateDate;
            ComboBoxEquipmentState_Id.SelectedValue = ListTemGageState[0].EquipmentState_Id;
            
            TextBoxStore_Id.Tag = ListTemGageState[0].Store_Id;
            TextBoxStore_Id.Text = ListTemGageState[0].StoreName;
            
            TextBoxWorkShop_Id.Tag = ListTemGageState[0].WorkShop_Id;
            TextBoxWorkShop_Id.Text = ListTemGageState[0].WorkShopName;

            TextBoxCalibration_Id.Tag = ListTemGageState[0].Calibration_Id;
            TextBoxCalibration_Id.Text = ListTemGageState[0].CalibrationName;

            TextBoxGasStation_Id.Tag = ListTemGageState[0].GasStation_Id;
            TextBoxGasStation_Id.Text = ListTemGageState[0].GasStationCode + "-" + ListTemGageState[0].GasStationName;

            TextBoxDescription.Text = ListTemGageState[0].Description;
            checkBoxIsActive.Checked = ListTemGageState[0].IsActive;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckValidation())
                return;
            try
            {
                string str = "";
                List<TBL_TemGageState> Ls = new List<TBL_TemGageState>(1);
                TBL_TemGageState TemGageState = new TBL_TemGageState();
                TemGageState.TemGage_Id = _TemGage_Id;
                TemGageState.TemGageSerialNo = TextBoxTemGageSerialNo.Text;
                TemGageState.TemGageStateRow = _TemGageStateRow;

                TemGageState.ChangeStateDate = DatePickerChangeStateDate.Value.ToString();

                TemGageState.EquipmentState_Id = Convert.ToInt16(ComboBoxEquipmentState_Id.SelectedValue);
                TemGageState.Store_Id = Convert.ToInt16(TextBoxStore_Id.Tag);
                TemGageState.WorkShop_Id = Convert.ToInt16(TextBoxWorkShop_Id.Tag);
                TemGageState.Calibration_Id = Convert.ToInt16(TextBoxCalibration_Id.Tag);
                TemGageState.GasStation_Id = Convert.ToInt16(TextBoxGasStation_Id.Tag);

                TemGageState.Description = TextBoxDescription.Text;
                TemGageState.IsActive = Convert.ToBoolean(checkBoxIsActive.Checked);

                Ls.Add(TemGageState);

                if (!_editIns)
                {
                    new ViewModel.TemGageState.TemGageState().InsertEntity(Ls, ref str);
                }
                else
                {
                    new ViewModel.TemGageState.TemGageState().UpdateEntity(Ls, ref str);
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

            if (TextBoxTemGageSerialNo.Text.Trim() == "")
            {
                MSS.Library.Clasess.MSSMessage.MSSMessage_View("لطفا شماره سریال کنتور را پر نمایید", MSS.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                return false;
            }

            if (ComboBoxEquipmentState_Id.Text.Trim() == "")
            {
                MSS.Library.Clasess.MSSMessage.MSSMessage_View("لطفا وضعیت تجهیز را پر نمایید", MSS.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                return false;
            }

            if (TextBoxStore_Id.Tag == null && TextBoxCalibration_Id.Tag == null && TextBoxWorkShop_Id.Tag == null && TextBoxGasStation_Id.Tag == null)
            {
                MSS.Library.Clasess.MSSMessage.MSSMessage_View("لطفا یک نوع تجهیز را مشخص نمایید", MSS.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                return false;
            }

            return true;
        }


        private void buttonTemGageSerialNo_Click(object sender, EventArgs e)
        {
            string StrSet = "";
            Dictionary<string, string> SD = new Dictionary<string, string>();
            Dictionary<string, string> SD1 = new Dictionary<string, string>();

            foreach (var item in new ViewModel.TemGageSupply.TemGageSupply().GetList(ref StrSet))
            {
                List<QueryFilter.ExpressionBuilder.Filter> Ls = new List<QueryFilter.ExpressionBuilder.Filter>();
                Ls.Add(new QueryFilter.ExpressionBuilder.Filter()
                {
                    Operation = QueryFilter.ExpressionBuilder.Op.Equals,
                    PropertyName = "TemGage_Id",
                    Value = item.TemGage_Id,
                    OperationFilter = QueryFilter.ExpressionBuilder.OpFilter.And
                });
                Ls.Add(new QueryFilter.ExpressionBuilder.Filter()
                {
                    Operation = QueryFilter.ExpressionBuilder.Op.Equals,
                    PropertyName = "TemGageSerialNo",
                    Value = item.TemGageSerialNo,
                    OperationFilter = QueryFilter.ExpressionBuilder.OpFilter.And
                });
                Ls.Add(new QueryFilter.ExpressionBuilder.Filter()
                {
                    Operation = QueryFilter.ExpressionBuilder.Op.Equals,
                    PropertyName = "GasStation_Id",
                    Value = _gasStation_Id,
                    OperationFilter = QueryFilter.ExpressionBuilder.OpFilter.And
                });
                Ls.Add(new QueryFilter.ExpressionBuilder.Filter()
                {
                    Operation = QueryFilter.ExpressionBuilder.Op.Equals,
                    PropertyName = "IsActive",
                    Value = true,
                    OperationFilter = QueryFilter.ExpressionBuilder.OpFilter.And
                });

                if (new ViewModel.TemGageState.TemGageState().GetListByFilter(Ls, ref StrSet).Count() == 0)
                    SD.Add(item.TemGageSerialNo, item.TemGage_Id + "-" + item.Brand);
            }

            SD1 = MSS.Library.Forms.MSSSelector_frm.SetDataSelect(SD);
            try
            {
                TextBoxTemGageSerialNo.Text = SD1.Keys.ToList()[0];
                string str = SD1.Values.ToList()[0];
                TextBoxTemGage_Id.Text = str.Substring(str.IndexOf("-") + 1);
                _TemGage_Id = str.Substring(0, str.IndexOf("-")).ToInt();
            }
            catch { }
        }

        private void ButtonStore_Click(object sender, EventArgs e)
        {
            string StrSet = "";
            Dictionary<string, string> SD = new Dictionary<string, string>();
            Dictionary<string, string> SD1 = new Dictionary<string, string>();

            foreach (var item in new ViewModel.Basic.Store().GetList(ref StrSet))
                SD.Add(item.Id.ToString(), item.Name);

            SD1 = MSS.Library.Forms.MSSSelector_frm.SetDataSelect(SD);
            try
            {
                TextBoxStore_Id.Tag = SD1.Keys.ToList()[0];
                TextBoxStore_Id.Text = SD1.Values.ToList()[0];

                TextBoxCalibration_Id.Text = "";
                TextBoxCalibration_Id.Tag = null;
                TextBoxWorkShop_Id.Text = "";
                TextBoxWorkShop_Id.Tag = null;
                TextBoxGasStation_Id.Text = "";
                TextBoxGasStation_Id.Tag = null;
            }
            catch { }
        }
        private void ButtonWorkShop_Click(object sender, EventArgs e)
        {
            string StrSet = "";
            Dictionary<string, string> SD = new Dictionary<string, string>();
            Dictionary<string, string> SD1 = new Dictionary<string, string>();

            foreach (var item in new ViewModel.Basic.WorkShop().GetList(ref StrSet))
                SD.Add(item.Id.ToString(), item.Name);

            SD1 = MSS.Library.Forms.MSSSelector_frm.SetDataSelect(SD);
            try
            {
                TextBoxWorkShop_Id.Tag = SD1.Keys.ToList()[0];
                TextBoxWorkShop_Id.Text = SD1.Values.ToList()[0];

                TextBoxCalibration_Id.Text = "";
                TextBoxCalibration_Id.Tag = null;
                TextBoxStore_Id.Text = "";
                TextBoxStore_Id.Tag = null;
                TextBoxGasStation_Id.Text = "";
                TextBoxGasStation_Id.Tag = null;
            }
            catch { }
        }

        private void ButtonCalibration_Click(object sender, EventArgs e)
        {
            string StrSet = "";
            Dictionary<string, string> SD = new Dictionary<string, string>();
            Dictionary<string, string> SD1 = new Dictionary<string, string>();

            foreach (var item in new ViewModel.Basic.Calibration().GetList(ref StrSet))
                SD.Add(item.Id.ToString(), item.Name);

            SD1 = MSS.Library.Forms.MSSSelector_frm.SetDataSelect(SD);
            try
            {
                TextBoxCalibration_Id.Tag = SD1.Keys.ToList()[0];
                TextBoxCalibration_Id.Text = SD1.Values.ToList()[0];

                TextBoxStore_Id.Text = "";
                TextBoxStore_Id.Tag = null;
                TextBoxWorkShop_Id.Text = "";
                TextBoxWorkShop_Id.Tag = null;
                TextBoxGasStation_Id.Text = "";
                TextBoxGasStation_Id.Tag = null;
            }
            catch { }
        }

        private void ButtonGasStation_Click(object sender, EventArgs e)
        {
            string StrSet = "";
            Dictionary<string, string> SD = new Dictionary<string, string>();
            Dictionary<string, string> SD1 = new Dictionary<string, string>();

            foreach (var item in new ViewModel.GasStationClass.GasStationClass().GetList(ref StrSet))
                SD.Add(item.ID.ToString(), (item.GasStationCode + "-" + item.GasStationName));

            SD1 = MSS.Library.Forms.MSSSelector_frm.SetDataSelect(SD);
            try
            {
                TextBoxGasStation_Id.Tag = SD1.Keys.ToList()[0];
                TextBoxGasStation_Id.Text = SD1.Values.ToList()[0];

                TextBoxStore_Id.Text = "";
                TextBoxStore_Id.Tag = null;
                TextBoxWorkShop_Id.Text = "";
                TextBoxWorkShop_Id.Tag = null;
                TextBoxCalibration_Id.Text = "";
                TextBoxCalibration_Id.Tag = null;
            }
            catch { }
        }


    }
}
