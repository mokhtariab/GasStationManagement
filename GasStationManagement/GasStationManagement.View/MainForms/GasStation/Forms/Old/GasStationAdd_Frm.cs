using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
 
namespace GasStationManagement.View.MainForms.GasStation
{
    public partial class GasStationAdd_Frm : MSS.Library.Forms.MSSBaseNew_frm
    {
        private int _id = 0;
        private bool _editIns = false;


         public GasStationAdd_Frm()
        {
            InitializeComponent();
        }


        public GasStationAdd_Frm(int Id)
        {
            InitializeComponent();
            _id = Id;
            _editIns = true;
        }

        private void GasStationAdd_Frm_Load(object sender, EventArgs e)
        {
            SetComboBox();

            if (_editIns) fillControl();
        }

        private void SetComboBox()
        {
            string str = "";
            try
            {
                ComboBoxCapacity.DataSource = new ViewModel.GasStationClass.GasStationClass().GetList(ref str).Single().Capacity.ToString().Distinct();
                ComboBoxCapacity.SelectedIndex = -1;
            }
            catch { }

            try
            {
                ComboBoxGasStationType_Id.ValueMember = "Id";
                ComboBoxGasStationType_Id.DisplayMember = "Name";
                ComboBoxGasStationType_Id.DataSource = new ViewModel.Basic.GasStationType().GetList(ref str);
                ComboBoxGasStationType_Id.SelectedIndex = -1;
            }
            catch { }

            try
            {
                ComboBoxWorkingPressure_Id.ValueMember = "Id";
                ComboBoxWorkingPressure_Id.DisplayMember = "Name";
                ComboBoxWorkingPressure_Id.DataSource = new ViewModel.Basic.WorkingPressure().GetList(ref str);
                ComboBoxWorkingPressure_Id.SelectedIndex = -1;
            }
            catch { }

            try
            {
                ComboBoxUseType_Id.ValueMember = "Id";
                ComboBoxUseType_Id.DisplayMember = "Name";
                ComboBoxUseType_Id.DataSource = new ViewModel.Basic.UseType().GetList(ref str);
                ComboBoxUseType_Id.SelectedIndex = -1;
            }
            catch { }

            try
            {
                ComboBoxLine_Id.ValueMember = "Id";
                ComboBoxLine_Id.DisplayMember = "Name";
                ComboBoxLine_Id.DataSource = new ViewModel.Basic.Line().GetList(ref str);
                ComboBoxLine_Id.SelectedIndex = -1;
            }
            catch { }

            try
            {
                ComboBoxGasStation_Id.ValueMember = "Id";
                ComboBoxGasStation_Id.DisplayMember = "GasStationName";
                ComboBoxGasStation_Id.DataSource = new ViewModel.GasStationClass.GasStationClass().GetList(ref str);
                ComboBoxGasStation_Id.SelectedIndex = -1;
            }
            catch { }

            try
            {
                ComboBoxCounterInsLoc_Id.ValueMember = "Id";
                ComboBoxCounterInsLoc_Id.DisplayMember = "Name";
                ComboBoxCounterInsLoc_Id.DataSource = new ViewModel.Basic.CounterInsLoc().GetList(ref str);
                ComboBoxCounterInsLoc_Id.SelectedIndex = -1;
            }
            catch { }


            try
            {
                ComboBoxStationLinkType_Id.ValueMember = "Id";
                ComboBoxStationLinkType_Id.DisplayMember = "Name";
                ComboBoxStationLinkType_Id.DataSource = new ViewModel.Basic.StationLinkType().GetList(ref str);
                ComboBoxStationLinkType_Id.SelectedIndex = -1;
            }
            catch { }

            try
            {
                ComboBoxMonitoringSysState_Id.ValueMember = "Id";
                ComboBoxMonitoringSysState_Id.DisplayMember = "Name";
                ComboBoxMonitoringSysState_Id.DataSource = new ViewModel.Basic.MonitoringSysState().GetList(ref str);
                ComboBoxMonitoringSysState_Id.SelectedIndex = -1;
            }
            catch { }
        }

        private void fillControl()
        {
            string str = "";
            ViewModel.GasStationClass.GasStationClass RN = new ViewModel.GasStationClass.GasStationClass();

            TextBoxGasStationCode.Text = RN.GetListByID(_id, ref str)[0].GasStationCode;
            textBoxGasStationName.Text = RN.GetListByID(_id, ref str)[0].GasStationName;
            DatePickerGasStationBuildingDate.Value = KagNetComponents2.KagPersianDate.Parse(RN.GetListByID(_id, ref str)[0].GasStationBuildingDate);

            ComboBoxCapacity.Text = RN.GetListByID(_id, ref str)[0].Capacity.ToString();
            ComboBoxGasStationType_Id.SelectedValue = RN.GetListByID(_id, ref str)[0].GasStationType_Id;
            ComboBoxWorkingPressure_Id.SelectedValue = RN.GetListByID(_id, ref str)[0].WorkingPressure_Id;
            ComboBoxUseType_Id.SelectedValue = RN.GetListByID(_id, ref str)[0].UseType_Id;

            RadioBoxMonthly.Checked = RN.GetListByID(_id, ref str)[0].ScheduleRegInfo==0;
            RadioBoxDaily.Checked = RN.GetListByID(_id, ref str)[0].ScheduleRegInfo==1;
            RadioBoxPeriod.Checked = RN.GetListByID(_id, ref str)[0].ScheduleRegInfo==2;
            IntBoxScheduleSpecPeriod.Value = RN.GetListByID(_id, ref str)[0].ScheduleSpecPeriod;
            IntBoxRanFew.Value = RN.GetListByID(_id, ref str)[0].RanFew;
            IntBoxHeater_Few.Value = RN.GetListByID(_id, ref str)[0].Heater_Few;
            IntBoxCorrectionFactor.Value = RN.GetListByID(_id, ref str)[0].CorrectionFactor;

            DatePickerMonitoringSysExeDate.Value = KagNetComponents2.KagPersianDate.Parse(RN.GetListByID(_id, ref str)[0].MonitoringSysExeDate);
            
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
                List<GasStationManagement.Model.GasStation.GasStation> Ls = new List<GasStationManagement.Model.GasStation.GasStation>(1);
                GasStationManagement.Model.GasStation.GasStation GasStation = new GasStationManagement.Model.GasStation.GasStation();
                GasStation.ID = _id;

                GasStation.GasStationCode = TextBoxGasStationCode.Text;
                GasStation.GasStationName = textBoxGasStationName.Text;
                GasStation.GasStationBuildingDate = DatePickerGasStationBuildingDate.Value.ToString();

                GasStation.Capacity = Convert.ToInt16(ComboBoxCapacity.Text == "" ? "0" : ComboBoxCapacity.Text);
                GasStation.GasStationType_Id = Convert.ToInt16(ComboBoxGasStationType_Id.SelectedValue ?? 0);
                GasStation.WorkingPressure_Id = Convert.ToInt16(ComboBoxWorkingPressure_Id.SelectedValue ?? 0);
                GasStation.UseType_Id = Convert.ToInt16(ComboBoxUseType_Id.SelectedValue ?? 0);

                GasStation.ScheduleRegInfo = Convert.ToInt16(RadioBoxMonthly.Checked ? 0 : RadioBoxDaily.Checked ? 1 : 2);
                GasStation.ScheduleSpecPeriod = RadioBoxPeriod.Checked ? IntBoxScheduleSpecPeriod.Text.ToInt() : 0;

                GasStation.Line_Id = Convert.ToInt16(ComboBoxLine_Id.Enabled ? ComboBoxLine_Id.SelectedValue ?? 0 : 0);
                GasStation.GasStation_Id = Convert.ToInt16(ComboBoxGasStation_Id.Enabled ? ComboBoxGasStation_Id.SelectedValue ?? 0 : 0);
                GasStation.RanFew = IntBoxRanFew.Text.ToInt();
                GasStation.Heater_Few = IntBoxHeater_Few.Text.ToInt();
                GasStation.CounterInsLoc_Id = Convert.ToInt16(ComboBoxCounterInsLoc_Id.SelectedValue ?? 0);
                GasStation.CorrectionFactor = IntBoxCorrectionFactor.Text.ToInt();
                GasStation.StationLinkType_Id = Convert.ToInt16(ComboBoxStationLinkType_Id.SelectedValue ?? 0);
                GasStation.MonitoringSysState_Id = Convert.ToInt16(ComboBoxMonitoringSysState_Id.SelectedValue ?? 0);
                GasStation.MonitoringSysExeDate = DatePickerMonitoringSysExeDate.Value.ToString();
                GasStation.Suppliers_Id = Convert.ToInt16((TextBoxSuppliers_Id.Tag??0).ToString());

                GasStation.Description = TextBoxDescription.Text;
                GasStation.IsActive = Convert.ToBoolean(checkBoxIsActive.Checked);

                Ls.Add(GasStation);

                if (!_editIns)
                {
                    new ViewModel.GasStationClass.GasStationClass().InsertEntity(Ls, ref str);
                }
                else
                {
                    new ViewModel.GasStationClass.GasStationClass().UpdateEntity(Ls, ref str);
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
            if (TextBoxGasStationCode.Text.Trim() == "")
            {
                MSS.Library.Clasess.MSSMessage.MSSMessage_View("لطفا مدل را پر نمایید", MSS.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                return false;
            }
            if (textBoxGasStationName.Text.Trim() == "")
            {
                MSS.Library.Clasess.MSSMessage.MSSMessage_View("لطفا برند را پر نمایید", MSS.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                return false;
            }
            if (IntBoxScheduleSpecPeriod.Text.Trim() == "")
            {
                MSS.Library.Clasess.MSSMessage.MSSMessage_View("لطفا گستره فشار کاری psi از را پر نمایید", MSS.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                return false;
            }
            //if (IntBoxPMax.Text.Trim() == "")
            //{
            //    MSS.Library.Clasess.MSSMessage.MSSMessage_View("لطفا گستره فشار کاری psi تا را پر نمایید", MSS.Library.Clasess.MSSMessage.MessageType.SConfirmation);
            //    return false;
            //}
            //if (IntBoxParametersDuration.Text.Trim() == "")
            //{
            //    MSS.Library.Clasess.MSSMessage.MSSMessage_View("لطفا دوره کالیبراسیون را پر نمایید", MSS.Library.Clasess.MSSMessage.MessageType.SConfirmation);
            //    return false;
            //}
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

        private void ComboBoxGasStationType_Id_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxLine_Id.Enabled = ComboBoxGasStationType_Id.SelectedIndex == 0 || ComboBoxGasStationType_Id.SelectedIndex == 2;
            ComboBoxGasStation_Id.Enabled = ComboBoxGasStationType_Id.SelectedIndex == 1 || ComboBoxGasStationType_Id.SelectedIndex == 3;
        }

        MSS.Library.Control.MSSComboBox tx = new MSS.Library.Control.MSSComboBox();
        private void ComboBoxCapacity_TextChanged(object sender, EventArgs e)
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
