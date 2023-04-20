using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using GasStationManagement.Model.PressGageState;
using MSS.Library.Clasess.FilterClass;

namespace GasStationManagement.View.MainForms.PressGage
{
    public partial class PressGageStateAdd_Frm : MSS.Library.Forms.MSSBaseNew_frm
    {
        private int _PressGage_Id = 0;
        private string _PressGageSerialNo = "";
        private int _PressGageStateRow = 0;
        private int _gasStation_Id = 0;
        private bool _editIns = false;


        public PressGageStateAdd_Frm(int GasStation_Id)
        {
            InitializeComponent();
            _gasStation_Id = GasStation_Id;
            buttonPressGageSerialNo.Visible = true;

            ButtonGasStation.Visible = false;
            ButtonCalibration.Visible = false;
            ButtonStore.Visible = false;
            ButtonWorkShop.Visible = false;

            string StrSet = "";
            TextBoxGasStation_Id.Text = new ViewModel.GasStationClass.GasStationClass().GetListByID(GasStation_Id, ref StrSet).Single().GasStationCode + "-" + new ViewModel.GasStationClass.GasStationClass().GetListByID(GasStation_Id, ref StrSet).Single().GasStationName;
            TextBoxGasStation_Id.Tag = GasStation_Id;
        }

        public PressGageStateAdd_Frm(int PressGage_Id, string PressGageSerialNo)
        {
            InitializeComponent();
            _PressGage_Id = PressGage_Id;
            _PressGageSerialNo = PressGageSerialNo;
            
            string str = "";
            TextBoxPressGage_Id.Text = new ViewModel.Basic.PressureGage().GetListByID(_PressGage_Id, ref str).Single().Brand;
            TextBoxPressGageSerialNo.Text = _PressGageSerialNo;
        }


        public PressGageStateAdd_Frm(int PressGage_Id, string PressGageSerialNo, int PressGageStateRow)
        {
            InitializeComponent();
            _PressGage_Id = PressGage_Id;
            _PressGageSerialNo = PressGageSerialNo;
            _PressGageStateRow = PressGageStateRow;
            _editIns = true;
        }

        private void PressGageStateAdd_Frm_Load(object sender, EventArgs e)
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
                PropertyName = "PressGage_Id",
                Value = _PressGage_Id,
                OperationFilter = QueryFilter.ExpressionBuilder.OpFilter.And
            });
            Ls.Add(new QueryFilter.ExpressionBuilder.Filter()
            {
                Operation = QueryFilter.ExpressionBuilder.Op.Equals,
                PropertyName = "PressGageSerialNo",
                Value = _PressGageSerialNo,
                OperationFilter = QueryFilter.ExpressionBuilder.OpFilter.And
            });
            Ls.Add(new QueryFilter.ExpressionBuilder.Filter()
            {
                Operation = QueryFilter.ExpressionBuilder.Op.Equals,
                PropertyName = "PressGageStateRow",
                Value = _PressGageStateRow,
                OperationFilter = QueryFilter.ExpressionBuilder.OpFilter.And
            }); 
            
            ViewModel.PressGageState.PressGageState RN = new ViewModel.PressGageState.PressGageState();
            List<VW_PressGageState> ListPressGageState = RN.GetListByFilter(Ls, ref str);

            TextBoxPressGage_Id.Text = ListPressGageState[0].Brand;
            TextBoxPressGageSerialNo.Text = _PressGageSerialNo.ToString();

            DatePickerChangeStateDate.Text = ListPressGageState[0].ChangeStateDate;
            ComboBoxEquipmentState_Id.SelectedValue = ListPressGageState[0].EquipmentState_Id;
            
            TextBoxStore_Id.Tag = ListPressGageState[0].Store_Id;
            TextBoxStore_Id.Text = ListPressGageState[0].StoreName;
            
            TextBoxWorkShop_Id.Tag = ListPressGageState[0].WorkShop_Id;
            TextBoxWorkShop_Id.Text = ListPressGageState[0].WorkShopName;

            TextBoxCalibration_Id.Tag = ListPressGageState[0].Calibration_Id;
            TextBoxCalibration_Id.Text = ListPressGageState[0].CalibrationName;

            TextBoxGasStation_Id.Tag = ListPressGageState[0].GasStation_Id;
            TextBoxGasStation_Id.Text = ListPressGageState[0].GasStationCode + "-" + ListPressGageState[0].GasStationName;

            TextBoxDescription.Text = ListPressGageState[0].Description;
            checkBoxIsActive.Checked = ListPressGageState[0].IsActive;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckValidation())
                return;
            try
            {
                string str = "";
                List<TBL_PressGageState> Ls = new List<TBL_PressGageState>(1);
                TBL_PressGageState PressGageState = new TBL_PressGageState();
                PressGageState.PressGage_Id = _PressGage_Id;
                PressGageState.PressGageSerialNo = TextBoxPressGageSerialNo.Text;
                PressGageState.PressGageStateRow = _PressGageStateRow;

                PressGageState.ChangeStateDate = DatePickerChangeStateDate.Value.ToString();

                PressGageState.EquipmentState_Id = Convert.ToInt16(ComboBoxEquipmentState_Id.SelectedValue);
                PressGageState.Store_Id = Convert.ToInt16(TextBoxStore_Id.Tag);
                PressGageState.WorkShop_Id = Convert.ToInt16(TextBoxWorkShop_Id.Tag);
                PressGageState.Calibration_Id = Convert.ToInt16(TextBoxCalibration_Id.Tag);
                PressGageState.GasStation_Id = Convert.ToInt16(TextBoxGasStation_Id.Tag);

                PressGageState.Description = TextBoxDescription.Text;
                PressGageState.IsActive = Convert.ToBoolean(checkBoxIsActive.Checked);

                Ls.Add(PressGageState);

                if (!_editIns)
                {
                    new ViewModel.PressGageState.PressGageState().InsertEntity(Ls, ref str);
                }
                else
                {
                    new ViewModel.PressGageState.PressGageState().UpdateEntity(Ls, ref str);
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

            if (TextBoxPressGageSerialNo.Text.Trim() == "")
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


        private void buttonPressGageSerialNo_Click(object sender, EventArgs e)
        {
            string StrSet = "";
            Dictionary<string, string> SD = new Dictionary<string, string>();
            Dictionary<string, string> SD1 = new Dictionary<string, string>();

            foreach (var item in new ViewModel.PressGageSupply.PressGageSupply().GetList(ref StrSet))
            {
                List<QueryFilter.ExpressionBuilder.Filter> Ls = new List<QueryFilter.ExpressionBuilder.Filter>();
                Ls.Add(new QueryFilter.ExpressionBuilder.Filter()
                {
                    Operation = QueryFilter.ExpressionBuilder.Op.Equals,
                    PropertyName = "PressGage_Id",
                    Value = item.PressGage_Id,
                    OperationFilter = QueryFilter.ExpressionBuilder.OpFilter.And
                });
                Ls.Add(new QueryFilter.ExpressionBuilder.Filter()
                {
                    Operation = QueryFilter.ExpressionBuilder.Op.Equals,
                    PropertyName = "PressGageSerialNo",
                    Value = item.PressGageSerialNo,
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

                if (new ViewModel.PressGageState.PressGageState().GetListByFilter(Ls, ref StrSet).Count() == 0)
                    SD.Add(item.PressGageSerialNo, item.PressGage_Id + "-" + item.Brand);
            }

            SD1 = MSS.Library.Forms.MSSSelector_frm.SetDataSelect(SD);
            try
            {
                TextBoxPressGageSerialNo.Text = SD1.Keys.ToList()[0];
                string str = SD1.Values.ToList()[0];
                TextBoxPressGage_Id.Text = str.Substring(str.IndexOf("-") + 1);
                _PressGage_Id = str.Substring(0, str.IndexOf("-")).ToInt();
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
