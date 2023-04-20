using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using GasStationManagement.Model.TemTransState;
using MSS.Library.Clasess.FilterClass;

namespace GasStationManagement.View.MainForms.TemTrans
{
    public partial class TemTransStateAdd_Frm : MSS.Library.Forms.MSSBaseNew_frm
    {
        private int _TemTrans_Id = 0;
        private string _TemTransSerialNo = "";
        private int _TemTransStateRow = 0;
        private int _gasStation_Id = 0;
        private bool _editIns = false;


        public TemTransStateAdd_Frm(int GasStation_Id)
        {
            InitializeComponent();
            _gasStation_Id = GasStation_Id;
            buttonTemTransSerialNo.Visible = true;

            ButtonGasStation.Visible = false;
            ButtonCalibration.Visible = false;
            ButtonStore.Visible = false;
            ButtonWorkShop.Visible = false;

            string StrSet = "";
            TextBoxGasStation_Id.Text = new ViewModel.GasStationClass.GasStationClass().GetListByID(GasStation_Id, ref StrSet).Single().GasStationCode + "-" + new ViewModel.GasStationClass.GasStationClass().GetListByID(GasStation_Id, ref StrSet).Single().GasStationName;
            TextBoxGasStation_Id.Tag = GasStation_Id;
        }

        public TemTransStateAdd_Frm(int TemTrans_Id, string TemTransSerialNo)
        {
            InitializeComponent();
            _TemTrans_Id = TemTrans_Id;
            _TemTransSerialNo = TemTransSerialNo;
            
            string str = "";
            TextBoxTemTrans_Id.Text = new ViewModel.Basic.TemperatureTransmitter().GetListByID(_TemTrans_Id, ref str).Single().Brand;
            TextBoxTemTransSerialNo.Text = _TemTransSerialNo;
        }


        public TemTransStateAdd_Frm(int TemTrans_Id, string TemTransSerialNo, int TemTransStateRow)
        {
            InitializeComponent();
            _TemTrans_Id = TemTrans_Id;
            _TemTransSerialNo = TemTransSerialNo;
            _TemTransStateRow = TemTransStateRow;
            _editIns = true;
        }

        private void TemTransStateAdd_Frm_Load(object sender, EventArgs e)
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
                PropertyName = "TemTrans_Id",
                Value = _TemTrans_Id,
                OperationFilter = QueryFilter.ExpressionBuilder.OpFilter.And
            });
            Ls.Add(new QueryFilter.ExpressionBuilder.Filter()
            {
                Operation = QueryFilter.ExpressionBuilder.Op.Equals,
                PropertyName = "TemTransSerialNo",
                Value = _TemTransSerialNo,
                OperationFilter = QueryFilter.ExpressionBuilder.OpFilter.And
            });
            Ls.Add(new QueryFilter.ExpressionBuilder.Filter()
            {
                Operation = QueryFilter.ExpressionBuilder.Op.Equals,
                PropertyName = "TemTransStateRow",
                Value = _TemTransStateRow,
                OperationFilter = QueryFilter.ExpressionBuilder.OpFilter.And
            }); 
            
            ViewModel.TemTransState.TemTransState RN = new ViewModel.TemTransState.TemTransState();
            List<VW_TemTransState> ListTemTransState = RN.GetListByFilter(Ls, ref str);

            TextBoxTemTrans_Id.Text = ListTemTransState[0].Brand;
            TextBoxTemTransSerialNo.Text = _TemTransSerialNo.ToString();

            DatePickerChangeStateDate.Text = ListTemTransState[0].ChangeStateDate;
            ComboBoxEquipmentState_Id.SelectedValue = ListTemTransState[0].EquipmentState_Id;
            
            TextBoxStore_Id.Tag = ListTemTransState[0].Store_Id;
            TextBoxStore_Id.Text = ListTemTransState[0].StoreName;
            
            TextBoxWorkShop_Id.Tag = ListTemTransState[0].WorkShop_Id;
            TextBoxWorkShop_Id.Text = ListTemTransState[0].WorkShopName;

            TextBoxCalibration_Id.Tag = ListTemTransState[0].Calibration_Id;
            TextBoxCalibration_Id.Text = ListTemTransState[0].CalibrationName;

            TextBoxGasStation_Id.Tag = ListTemTransState[0].GasStation_Id;
            TextBoxGasStation_Id.Text = ListTemTransState[0].GasStationCode + "-" + ListTemTransState[0].GasStationName;

            TextBoxDescription.Text = ListTemTransState[0].Description;
            checkBoxIsActive.Checked = ListTemTransState[0].IsActive;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckValidation())
                return;
            try
            {
                string str = "";
                List<TBL_TemTransState> Ls = new List<TBL_TemTransState>(1);
                TBL_TemTransState TemTransState = new TBL_TemTransState();
                TemTransState.TemTrans_Id = _TemTrans_Id;
                TemTransState.TemTransSerialNo = TextBoxTemTransSerialNo.Text;
                TemTransState.TemTransStateRow = _TemTransStateRow;

                TemTransState.ChangeStateDate = DatePickerChangeStateDate.Value.ToString();

                TemTransState.EquipmentState_Id = Convert.ToInt16(ComboBoxEquipmentState_Id.SelectedValue);
                TemTransState.Store_Id = Convert.ToInt16(TextBoxStore_Id.Tag);
                TemTransState.WorkShop_Id = Convert.ToInt16(TextBoxWorkShop_Id.Tag);
                TemTransState.Calibration_Id = Convert.ToInt16(TextBoxCalibration_Id.Tag);
                TemTransState.GasStation_Id = Convert.ToInt16(TextBoxGasStation_Id.Tag);

                TemTransState.Description = TextBoxDescription.Text;
                TemTransState.IsActive = Convert.ToBoolean(checkBoxIsActive.Checked);

                Ls.Add(TemTransState);

                if (!_editIns)
                {
                    new ViewModel.TemTransState.TemTransState().InsertEntity(Ls, ref str);
                }
                else
                {
                    new ViewModel.TemTransState.TemTransState().UpdateEntity(Ls, ref str);
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

            if (TextBoxTemTransSerialNo.Text.Trim() == "")
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


        private void buttonTemTransSerialNo_Click(object sender, EventArgs e)
        {
            string StrSet = "";
            Dictionary<string, string> SD = new Dictionary<string, string>();
            Dictionary<string, string> SD1 = new Dictionary<string, string>();

            foreach (var item in new ViewModel.TemTransSupply.TemTransSupply().GetList(ref StrSet))
            {
                List<QueryFilter.ExpressionBuilder.Filter> Ls = new List<QueryFilter.ExpressionBuilder.Filter>();
                Ls.Add(new QueryFilter.ExpressionBuilder.Filter()
                {
                    Operation = QueryFilter.ExpressionBuilder.Op.Equals,
                    PropertyName = "TemTrans_Id",
                    Value = item.TemTrans_Id,
                    OperationFilter = QueryFilter.ExpressionBuilder.OpFilter.And
                });
                Ls.Add(new QueryFilter.ExpressionBuilder.Filter()
                {
                    Operation = QueryFilter.ExpressionBuilder.Op.Equals,
                    PropertyName = "TemTransSerialNo",
                    Value = item.TemTransSerialNo,
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

                if (new ViewModel.TemTransState.TemTransState().GetListByFilter(Ls, ref StrSet).Count() == 0)
                    SD.Add(item.TemTransSerialNo, item.TemTrans_Id + "-" + item.Brand);
            }

            SD1 = MSS.Library.Forms.MSSSelector_frm.SetDataSelect(SD);
            try
            {
                TextBoxTemTransSerialNo.Text = SD1.Keys.ToList()[0];
                string str = SD1.Values.ToList()[0];
                TextBoxTemTrans_Id.Text = str.Substring(str.IndexOf("-") + 1);
                _TemTrans_Id = str.Substring(0, str.IndexOf("-")).ToInt();
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
