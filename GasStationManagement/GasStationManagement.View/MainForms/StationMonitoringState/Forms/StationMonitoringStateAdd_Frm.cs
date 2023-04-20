using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using GasStationManagement.Model.StationMonitoringState;
using MSS.Library.Clasess.FilterClass;

namespace GasStationManagement.View.MainForms.StationMonitoringState
{
    public partial class StationMonitoringStateAdd_Frm : MSS.Library.Forms.MSSBaseNew_frm
    {
        private int _id = 0;
        private int _gasStation_Id = 0;
        private bool _editIns = false;


        public StationMonitoringStateAdd_Frm(int GasStation_Id)
        {
            InitializeComponent();
            _gasStation_Id = GasStation_Id;
        }

        public StationMonitoringStateAdd_Frm(int Id, int GasStation_Id)
        {
            InitializeComponent();
            _id = Id;
            _gasStation_Id = GasStation_Id;
            _editIns = true;
        }


        private void StationMonitoringStateAdd_Frm_Load(object sender, EventArgs e)
        {
            SetComboBox();

            if (_editIns) fillControl();
        }

        private void SetComboBox()
        {
            string str = "";

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

            ViewModel.StationMonitoringState.StationMonitoringState RN = new ViewModel.StationMonitoringState.StationMonitoringState();
            List<VW_StationMonitoringState> ListStationMonitoringState = RN.GetListByID(_id, ref str);

            DatePickerChangeStateDate.Text = ListStationMonitoringState[0].ChangeStateDate;
            ComboBoxMonitoringSysState_Id.SelectedValue = ListStationMonitoringState[0].MonitoringSysState_Id;
            ComboBoxStationLinkType_Id.SelectedValue = ListStationMonitoringState[0].StationLinkType_Id;
            
            DatePickerMonitoringSysExeDate.Value = KagNetComponents2.KagPersianDate.Parse(RN.GetListByID(_id, ref str)[0].MonitoringSysExeDate);


            TextBoxSuppliers_Id.Text = ListStationMonitoringState[0].SupplierName;
            TextBoxSuppliers_Id.Tag = ListStationMonitoringState[0].Suppliers_Id;


            TextBoxDescription.Text = ListStationMonitoringState[0].Description;
            checkBoxIsActive.Checked = ListStationMonitoringState[0].IsActive;

            FillTableLayoutPanel(_id);

        }

        int i = 0;
        private void FillTableLayoutPanel(int StationMonitoringState_Id)
        {
            string str="";
            try
            {
                i = 0;
                tableLayoutPanelVisit.Controls.Clear();

                var collation = new ViewModel.StationMonitoringStateParameters.StationMonitoringStateParameters().GetList(ref str);//.Select(v =>v.StationMonitoringState_Id == StationMonitoringState_Id);
                foreach (var item in collation)
                {
                    if (item.StationMonitoringState_Id != StationMonitoringState_Id) continue;

                    MainForms.StationMonitoringState.StationMonitoringStateParameters_UC smsp = new StationMonitoringStateParameters_UC(item.Id);
                    smsp.Tag = item.Id;
                    smsp.Controls.Owner.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                    tableLayoutPanelVisit.Controls.Add(smsp, 1, i++);
                }
            }
            catch (Exception ex)
            {
                MSS.Library.Clasess.MSSMessage.MSSMessage_View(0, MSS.Library.Clasess.MSSMessage.MessageType.SError, false, ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckValidation())
                return;
            try
            {
                string str = "";
                List<TBL_StationMonitoringState> Ls = new List<TBL_StationMonitoringState>(1);
                TBL_StationMonitoringState StationMonitoringState = new TBL_StationMonitoringState();
                
                StationMonitoringState.GasStation_Id = _gasStation_Id;

                StationMonitoringState.ChangeStateDate = DatePickerChangeStateDate.Value.ToString().Substring(0, 10);
                StationMonitoringState.MonitoringSysState_Id = Convert.ToInt16(ComboBoxMonitoringSysState_Id.SelectedValue);
                StationMonitoringState.StationLinkType_Id = Convert.ToInt16(ComboBoxStationLinkType_Id.SelectedValue);
                StationMonitoringState.Suppliers_Id = Convert.ToInt16((TextBoxSuppliers_Id.Tag ?? 0).ToString());

                StationMonitoringState.MonitoringSysExeDate = DatePickerMonitoringSysExeDate.Value.ToString().Substring(0,10);

                StationMonitoringState.Description = TextBoxDescription.Text;
                StationMonitoringState.IsActive = Convert.ToBoolean(checkBoxIsActive.Checked);

                Ls.Add(StationMonitoringState);

                if (!_editIns)
                {
                    int? NewId = 0;
                    new ViewModel.StationMonitoringState.StationMonitoringState().InsertEntity(Ls, ref str, ref NewId);
                    SaveParametersUsercontrols(NewId.Value);
                }
                else
                {
                    new ViewModel.StationMonitoringState.StationMonitoringState().UpdateEntity(Ls, ref str);
                    SaveParametersUsercontrols(_id);
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

        private void SaveParametersUsercontrols(int StationMonitoringState_Id)
        {
            string str = "";
            new ViewModel.StationMonitoringStateParameters.StationMonitoringStateParameters().DeleteWithStationMonitoringState(StationMonitoringState_Id, ref str);
            foreach (Control fg in tableLayoutPanelVisit.Controls)
            {
                if ((fg as StationMonitoringStateParameters_UC).Visible)
                    (fg as StationMonitoringStateParameters_UC).save(StationMonitoringState_Id);
                //if (!(fg as StationMonitoringStateParameters_UC).SaveResult)
                //{
                //    MSS.Library.Clasess.MSSMessage.MSSMessage_View(0, MSS.Library.Clasess.MSSMessage.MessageType.SError, false, "اشکال اطلاعات", (fg as StationMonitoringStateParameters_UC).MessageResultStationMonitoringStateParameters);
                //    return false;
                //}
            }
        }



        private bool CheckValidation()
        {

            if (ComboBoxMonitoringSysState_Id.Text.Trim() == "")
            {
                MSS.Library.Clasess.MSSMessage.MSSMessage_View("لطفا وضعیت سیستم مانیتورینگ را پر نمایید", MSS.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                return false;
            }

            if (ComboBoxStationLinkType_Id.Text.Trim() == "")
            {
                MSS.Library.Clasess.MSSMessage.MSSMessage_View("لطفا نوع بستر ارتباطی ایستگاه را پر نمایید", MSS.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                return false;
            }
            if (TextBoxSuppliers_Id.Text.Trim() == "")
            {
                MSS.Library.Clasess.MSSMessage.MSSMessage_View("لطفا مجری سیستم مانیتورینگ را پر نمایید", MSS.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                return false;
            }


            foreach (Control fg in tableLayoutPanelVisit.Controls)
            {
                (fg as StationMonitoringStateParameters_UC).CheckvalidationUC();
                if (!(fg as StationMonitoringStateParameters_UC).SaveResult)
                {
                    MSS.Library.Clasess.MSSMessage.MSSMessage_View(0, MSS.Library.Clasess.MSSMessage.MessageType.SError, false, "اشکال اطلاعات", (fg as StationMonitoringStateParameters_UC).MessageResultStationMonitoringStateParameters);
                    return false;
                }
            }
            return true;
        }



        private void buttonAddParameter_Click(object sender, EventArgs e)
        {
            StationMonitoringStateParameters_UC SSUC = new StationMonitoringStateParameters_UC();
            SSUC.Controls.Owner.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            tableLayoutPanelVisit.Controls.Add(SSUC, 1, i++);
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
