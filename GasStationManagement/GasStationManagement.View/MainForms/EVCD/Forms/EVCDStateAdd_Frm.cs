using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using GasStationManagement.Model.EVCDState;
using MSS.Library.Clasess.FilterClass;

namespace GasStationManagement.View.MainForms.EVCD
{
    public partial class EVCDStateAdd_Frm : MSS.Library.Forms.MSSBaseNew_frm
    {
        private int _EVCD_Id = 0;
        private string _EVCDSerialNo = "";
        private int _EVCDStateRow = 0;
        private int _gasStation_Id = 0;
        private bool _editIns = false;


        public EVCDStateAdd_Frm(int GasStation_Id)
        {
            InitializeComponent();
            _gasStation_Id = GasStation_Id;
            buttonEVCDSerialNo.Visible = true;

            ButtonGasStation.Visible = false;
            ButtonCalibration.Visible = false;
            ButtonStore.Visible = false;
            ButtonWorkShop.Visible = false;

            string StrSet = "";
            TextBoxGasStation_Id.Text = new ViewModel.GasStationClass.GasStationClass().GetListByID(GasStation_Id, ref StrSet).Single().GasStationCode + "-" + new ViewModel.GasStationClass.GasStationClass().GetListByID(GasStation_Id, ref StrSet).Single().GasStationName;
            TextBoxGasStation_Id.Tag = GasStation_Id;
        }

        public EVCDStateAdd_Frm(int EVCD_Id, string EVCDSerialNo)
        {
            InitializeComponent();
            _EVCD_Id = EVCD_Id;
            _EVCDSerialNo = EVCDSerialNo;
            
            string str = "";
            TextBoxEVCD_Id.Text = new ViewModel.Basic.EVCD().GetListByID(_EVCD_Id, ref str).Single().Brand;
            TextBoxEVCDSerialNo.Text = _EVCDSerialNo;
        }


        public EVCDStateAdd_Frm(int EVCD_Id, string EVCDSerialNo, int EVCDStateRow)
        {
            InitializeComponent();
            _EVCD_Id = EVCD_Id;
            _EVCDSerialNo = EVCDSerialNo;
            _EVCDStateRow = EVCDStateRow;
            _editIns = true;
        }

        private void EVCDStateAdd_Frm_Load(object sender, EventArgs e)
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
                PropertyName = "EVCD_Id",
                Value = _EVCD_Id,
                OperationFilter = QueryFilter.ExpressionBuilder.OpFilter.And
            });
            Ls.Add(new QueryFilter.ExpressionBuilder.Filter()
            {
                Operation = QueryFilter.ExpressionBuilder.Op.Equals,
                PropertyName = "EVCDSerialNo",
                Value = _EVCDSerialNo,
                OperationFilter = QueryFilter.ExpressionBuilder.OpFilter.And
            });
            Ls.Add(new QueryFilter.ExpressionBuilder.Filter()
            {
                Operation = QueryFilter.ExpressionBuilder.Op.Equals,
                PropertyName = "EVCDStateRow",
                Value = _EVCDStateRow,
                OperationFilter = QueryFilter.ExpressionBuilder.OpFilter.And
            }); 
            
            ViewModel.EVCDState.EVCDState RN = new ViewModel.EVCDState.EVCDState();
            List<VW_EVCDState> ListEVCDState = RN.GetListByFilter(Ls, ref str);

            TextBoxEVCD_Id.Text = ListEVCDState[0].Brand;
            TextBoxEVCDSerialNo.Text = _EVCDSerialNo.ToString();

            DatePickerChangeStateDate.Text = ListEVCDState[0].ChangeStateDate;
            ComboBoxEquipmentState_Id.SelectedValue = ListEVCDState[0].EquipmentState_Id;
            
            TextBoxStore_Id.Tag = ListEVCDState[0].Store_Id;
            TextBoxStore_Id.Text = ListEVCDState[0].StoreName;
            
            TextBoxWorkShop_Id.Tag = ListEVCDState[0].WorkShop_Id;
            TextBoxWorkShop_Id.Text = ListEVCDState[0].WorkShopName;

            TextBoxCalibration_Id.Tag = ListEVCDState[0].Calibration_Id;
            TextBoxCalibration_Id.Text = ListEVCDState[0].CalibrationName;

            TextBoxGasStation_Id.Tag = ListEVCDState[0].GasStation_Id;
            TextBoxGasStation_Id.Text = ListEVCDState[0].GasStationCode + "-" + ListEVCDState[0].GasStationName;

            TextBoxDescription.Text = ListEVCDState[0].Description;
            checkBoxIsActive.Checked = ListEVCDState[0].IsActive;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckValidation())
                return;
            try
            {
                string str = "";
                List<TBL_EVCDState> Ls = new List<TBL_EVCDState>(1);
                TBL_EVCDState EVCDState = new TBL_EVCDState();
                EVCDState.EVCD_Id = _EVCD_Id;
                EVCDState.EVCDSerialNo = TextBoxEVCDSerialNo.Text;
                EVCDState.EVCDStateRow = _EVCDStateRow;

                EVCDState.ChangeStateDate = DatePickerChangeStateDate.Value.ToString();

                EVCDState.EquipmentState_Id = Convert.ToInt16(ComboBoxEquipmentState_Id.SelectedValue);
                EVCDState.Store_Id = Convert.ToInt16(TextBoxStore_Id.Tag);
                EVCDState.WorkShop_Id = Convert.ToInt16(TextBoxWorkShop_Id.Tag);
                EVCDState.Calibration_Id = Convert.ToInt16(TextBoxCalibration_Id.Tag);
                EVCDState.GasStation_Id = Convert.ToInt16(TextBoxGasStation_Id.Tag);

                EVCDState.Description = TextBoxDescription.Text;
                EVCDState.IsActive = Convert.ToBoolean(checkBoxIsActive.Checked);

                Ls.Add(EVCDState);

                if (!_editIns)
                {
                    new ViewModel.EVCDState.EVCDState().InsertEntity(Ls, ref str);
                }
                else
                {
                    new ViewModel.EVCDState.EVCDState().UpdateEntity(Ls, ref str);
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

            if (TextBoxEVCDSerialNo.Text.Trim() == "")
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


        private void buttonEVCDSerialNo_Click(object sender, EventArgs e)
        {
            string StrSet = "";
            Dictionary<string, string> SD = new Dictionary<string, string>();
            Dictionary<string, string> SD1 = new Dictionary<string, string>();

            foreach (var item in new ViewModel.EVCDSupply.EVCDSupply().GetList(ref StrSet))
            {
                List<QueryFilter.ExpressionBuilder.Filter> Ls = new List<QueryFilter.ExpressionBuilder.Filter>();
                Ls.Add(new QueryFilter.ExpressionBuilder.Filter()
                {
                    Operation = QueryFilter.ExpressionBuilder.Op.Equals,
                    PropertyName = "EVCD_Id",
                    Value = item.EVCD_Id,
                    OperationFilter = QueryFilter.ExpressionBuilder.OpFilter.And
                });
                Ls.Add(new QueryFilter.ExpressionBuilder.Filter()
                {
                    Operation = QueryFilter.ExpressionBuilder.Op.Equals,
                    PropertyName = "EVCDSerialNo",
                    Value = item.EVCDSerialNo,
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

                if (new ViewModel.EVCDState.EVCDState().GetListByFilter(Ls, ref StrSet).Count() == 0)
                    SD.Add(item.EVCDSerialNo, item.EVCD_Id + "-" + item.Brand);
            }

            SD1 = MSS.Library.Forms.MSSSelector_frm.SetDataSelect(SD);
            try
            {
                TextBoxEVCDSerialNo.Text = SD1.Keys.ToList()[0];
                string str = SD1.Values.ToList()[0];
                TextBoxEVCD_Id.Text = str.Substring(str.IndexOf("-") + 1);
                _EVCD_Id = str.Substring(0, str.IndexOf("-")).ToInt();
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
