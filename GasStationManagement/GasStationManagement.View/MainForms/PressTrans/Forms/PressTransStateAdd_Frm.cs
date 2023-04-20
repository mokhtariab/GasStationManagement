using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using GasStationManagement.Model.PressTransState;
using MSS.Library.Clasess.FilterClass;

namespace GasStationManagement.View.MainForms.PressTrans
{
    public partial class PressTransStateAdd_Frm : MSS.Library.Forms.MSSBaseNew_frm
    {
        private int _PressTrans_Id = 0;
        private string _PressTransSerialNo = "";
        private int _PressTransStateRow = 0;
        private int _gasStation_Id = 0;
        private bool _editIns = false;


        public PressTransStateAdd_Frm(int GasStation_Id)
        {
            InitializeComponent();
            _gasStation_Id = GasStation_Id;
            buttonPressTransSerialNo.Visible = true;

            ButtonGasStation.Visible = false;
            ButtonCalibration.Visible = false;
            ButtonStore.Visible = false;
            ButtonWorkShop.Visible = false;

            string StrSet = "";
            TextBoxGasStation_Id.Text = new ViewModel.GasStationClass.GasStationClass().GetListByID(GasStation_Id, ref StrSet).Single().GasStationCode + "-" + new ViewModel.GasStationClass.GasStationClass().GetListByID(GasStation_Id, ref StrSet).Single().GasStationName;
            TextBoxGasStation_Id.Tag = GasStation_Id;
        }

        public PressTransStateAdd_Frm(int PressTrans_Id, string PressTransSerialNo)
        {
            InitializeComponent();
            _PressTrans_Id = PressTrans_Id;
            _PressTransSerialNo = PressTransSerialNo;
            
            string str = "";
            TextBoxPressTrans_Id.Text = new ViewModel.Basic.PressureTransmitter().GetListByID(_PressTrans_Id, ref str).Single().Brand;
            TextBoxPressTransSerialNo.Text = _PressTransSerialNo;
        }


        public PressTransStateAdd_Frm(int PressTrans_Id, string PressTransSerialNo, int PressTransStateRow)
        {
            InitializeComponent();
            _PressTrans_Id = PressTrans_Id;
            _PressTransSerialNo = PressTransSerialNo;
            _PressTransStateRow = PressTransStateRow;
            _editIns = true;
        }

        private void PressTransStateAdd_Frm_Load(object sender, EventArgs e)
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
                PropertyName = "PressTrans_Id",
                Value = _PressTrans_Id,
                OperationFilter = QueryFilter.ExpressionBuilder.OpFilter.And
            });
            Ls.Add(new QueryFilter.ExpressionBuilder.Filter()
            {
                Operation = QueryFilter.ExpressionBuilder.Op.Equals,
                PropertyName = "PressTransSerialNo",
                Value = _PressTransSerialNo,
                OperationFilter = QueryFilter.ExpressionBuilder.OpFilter.And
            });
            Ls.Add(new QueryFilter.ExpressionBuilder.Filter()
            {
                Operation = QueryFilter.ExpressionBuilder.Op.Equals,
                PropertyName = "PressTransStateRow",
                Value = _PressTransStateRow,
                OperationFilter = QueryFilter.ExpressionBuilder.OpFilter.And
            }); 
            
            ViewModel.PressTransState.PressTransState RN = new ViewModel.PressTransState.PressTransState();
            List<VW_PressTransState> ListPressTransState = RN.GetListByFilter(Ls, ref str);

            TextBoxPressTrans_Id.Text = ListPressTransState[0].Brand;
            TextBoxPressTransSerialNo.Text = _PressTransSerialNo.ToString();

            DatePickerChangeStateDate.Text = ListPressTransState[0].ChangeStateDate;
            ComboBoxEquipmentState_Id.SelectedValue = ListPressTransState[0].EquipmentState_Id;
            
            TextBoxStore_Id.Tag = ListPressTransState[0].Store_Id;
            TextBoxStore_Id.Text = ListPressTransState[0].StoreName;
            
            TextBoxWorkShop_Id.Tag = ListPressTransState[0].WorkShop_Id;
            TextBoxWorkShop_Id.Text = ListPressTransState[0].WorkShopName;

            TextBoxCalibration_Id.Tag = ListPressTransState[0].Calibration_Id;
            TextBoxCalibration_Id.Text = ListPressTransState[0].CalibrationName;

            TextBoxGasStation_Id.Tag = ListPressTransState[0].GasStation_Id;
            TextBoxGasStation_Id.Text = ListPressTransState[0].GasStationCode + "-" + ListPressTransState[0].GasStationName;

            TextBoxDescription.Text = ListPressTransState[0].Description;
            checkBoxIsActive.Checked = ListPressTransState[0].IsActive;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckValidation())
                return;
            try
            {
                string str = "";
                List<TBL_PressTransState> Ls = new List<TBL_PressTransState>(1);
                TBL_PressTransState PressTransState = new TBL_PressTransState();
                PressTransState.PressTrans_Id = _PressTrans_Id;
                PressTransState.PressTransSerialNo = TextBoxPressTransSerialNo.Text;
                PressTransState.PressTransStateRow = _PressTransStateRow;

                PressTransState.ChangeStateDate = DatePickerChangeStateDate.Value.ToString();

                PressTransState.EquipmentState_Id = Convert.ToInt16(ComboBoxEquipmentState_Id.SelectedValue);
                PressTransState.Store_Id = Convert.ToInt16(TextBoxStore_Id.Tag);
                PressTransState.WorkShop_Id = Convert.ToInt16(TextBoxWorkShop_Id.Tag);
                PressTransState.Calibration_Id = Convert.ToInt16(TextBoxCalibration_Id.Tag);
                PressTransState.GasStation_Id = Convert.ToInt16(TextBoxGasStation_Id.Tag);

                PressTransState.Description = TextBoxDescription.Text;
                PressTransState.IsActive = Convert.ToBoolean(checkBoxIsActive.Checked);

                Ls.Add(PressTransState);

                if (!_editIns)
                {
                    new ViewModel.PressTransState.PressTransState().InsertEntity(Ls, ref str);
                }
                else
                {
                    new ViewModel.PressTransState.PressTransState().UpdateEntity(Ls, ref str);
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

            if (TextBoxPressTransSerialNo.Text.Trim() == "")
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


        private void buttonPressTransSerialNo_Click(object sender, EventArgs e)
        {
            string StrSet = "";
            Dictionary<string, string> SD = new Dictionary<string, string>();
            Dictionary<string, string> SD1 = new Dictionary<string, string>();

            foreach (var item in new ViewModel.PressTransSupply.PressTransSupply().GetList(ref StrSet))
            {
                List<QueryFilter.ExpressionBuilder.Filter> Ls = new List<QueryFilter.ExpressionBuilder.Filter>();
                Ls.Add(new QueryFilter.ExpressionBuilder.Filter()
                {
                    Operation = QueryFilter.ExpressionBuilder.Op.Equals,
                    PropertyName = "PressTrans_Id",
                    Value = item.PressTrans_Id,
                    OperationFilter = QueryFilter.ExpressionBuilder.OpFilter.And
                });
                Ls.Add(new QueryFilter.ExpressionBuilder.Filter()
                {
                    Operation = QueryFilter.ExpressionBuilder.Op.Equals,
                    PropertyName = "PressTransSerialNo",
                    Value = item.PressTransSerialNo,
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

                if (new ViewModel.PressTransState.PressTransState().GetListByFilter(Ls, ref StrSet).Count() == 0)
                    SD.Add(item.PressTransSerialNo, item.PressTrans_Id + "-" + item.Brand);
            }

            SD1 = MSS.Library.Forms.MSSSelector_frm.SetDataSelect(SD);
            try
            {
                TextBoxPressTransSerialNo.Text = SD1.Keys.ToList()[0];
                string str = SD1.Values.ToList()[0];
                TextBoxPressTrans_Id.Text = str.Substring(str.IndexOf("-") + 1);
                _PressTrans_Id = str.Substring(0, str.IndexOf("-")).ToInt();
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
