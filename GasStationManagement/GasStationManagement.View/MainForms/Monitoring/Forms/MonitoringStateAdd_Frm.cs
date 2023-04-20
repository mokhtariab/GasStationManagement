using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using GasStationManagement.Model.MonitoringState;

namespace GasStationManagement.View.MainForms.Monitoring
{
    public partial class MonitoringStateAdd_Frm : MSS.Library.Forms.MSSBaseNew_frm
    {
        private int _id = 0;
        private bool _editIns = false;


         public MonitoringStateAdd_Frm()
        {
            InitializeComponent();
        }


        public MonitoringStateAdd_Frm(int Id)
        {
            InitializeComponent();
            _id = Id;
            _editIns = true;
        }

        private void MonitoringStateAdd_Frm_Load(object sender, EventArgs e)
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

            ComboBoxStore_Id.ValueMember = "Id";
            ComboBoxStore_Id.DisplayMember = "Name";
            ComboBoxStore_Id.DataSource = new ViewModel.Basic.Store().GetList(ref str);

            ComboBoxWorkShop_Id.ValueMember = "Id";
            ComboBoxWorkShop_Id.DisplayMember = "Name";
            ComboBoxWorkShop_Id.DataSource = new ViewModel.Basic.WorkShop().GetList(ref str);

            ComboBoxCalibration_Id.ValueMember = "Id";
            ComboBoxCalibration_Id.DisplayMember = "Name";
            ComboBoxCalibration_Id.DataSource = new ViewModel.Basic.Calibration().GetList(ref str);

            ComboBoxGasStation_Id.ValueMember = "Id";
            ComboBoxGasStation_Id.DisplayMember = "GasStationName";
            ComboBoxGasStation_Id.DataSource = new ViewModel.GasStationClass.GasStationClass().GetList(ref str);
        }

        private void fillControl()
        {
            string str = "";
            ViewModel.MonitoringState.MonitoringState RN = new ViewModel.MonitoringState.MonitoringState();


            TextBoxMonitoring_Id.Text = RN.GetListByID(_id, ref str)[0].Monitoring_Id.ToString();
            TextBoxMonitoringSerialNo.Text = RN.GetListByID(_id, ref str)[0].MonitoringSerialNo.ToString();

            DatePickerChangeStateDate.Text = RN.GetListByID(_id, ref str)[0].ChangeStateDate;
            ComboBoxEquipmentState_Id.SelectedValue = RN.GetListByID(_id, ref str)[0].EquipmentState_Id;
            ComboBoxStore_Id.SelectedValue = RN.GetListByID(_id, ref str)[0].Store_Id;
            ComboBoxWorkShop_Id.SelectedValue = RN.GetListByID(_id, ref str)[0].WorkShop_Id;
            ComboBoxCalibration_Id.SelectedValue = RN.GetListByID(_id, ref str)[0].Calibration_Id;
            ComboBoxGasStation_Id.SelectedValue = RN.GetListByID(_id, ref str)[0].GasStation_Id;

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
                List<TBL_MonitoringState> Ls = new List<TBL_MonitoringState>(1);
                TBL_MonitoringState MonitoringState = new TBL_MonitoringState();
                MonitoringState.Monitoring_Id = _id;
                MonitoringState.MonitoringSerialNo = TextBoxMonitoringSerialNo.Text;

                MonitoringState.ChangeStateDate = DatePickerChangeStateDate.Text;

                MonitoringState.EquipmentState_Id = Convert.ToInt16(ComboBoxEquipmentState_Id.SelectedValue);
                MonitoringState.Store_Id = Convert.ToInt16(ComboBoxStore_Id.SelectedValue);
                MonitoringState.WorkShop_Id = Convert.ToInt16(ComboBoxWorkShop_Id.SelectedValue);
                MonitoringState.Calibration_Id = Convert.ToInt16(ComboBoxCalibration_Id.SelectedValue);
                MonitoringState.GasStation_Id = Convert.ToInt16(ComboBoxGasStation_Id.SelectedValue);

                MonitoringState.Description = TextBoxDescription.Text;
                MonitoringState.IsActive = Convert.ToBoolean(checkBoxIsActive.Checked);

                Ls.Add(MonitoringState);

                if (!_editIns)
                {
                    new ViewModel.MonitoringState.MonitoringState().InsertEntity(Ls, ref str);
                }
                else
                {
                    new ViewModel.MonitoringState.MonitoringState().UpdateEntity(Ls, ref str);
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
           
            if (ComboBoxEquipmentState_Id.Text.Trim() == "")
            {
                MSS.Library.Clasess.MSSMessage.MSSMessage_View("لطفا وضعیت تجهیز را پر نمایید", MSS.Library.Clasess.MSSMessage.MessageType.SConfirmation);
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
