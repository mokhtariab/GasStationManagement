using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MSS.Library.Clasess.FilterClass;

namespace GasStationManagement.View.MainForms.StationMonitoringState
{
    public partial class StationMonitoringStateParameters_UC : UserControl
    {
        public bool SaveResult = true;
        public string MessageResultStationMonitoringStateParameters = "";

        int _id = 0;

        public StationMonitoringStateParameters_UC(int Id)
        {
            InitializeComponent();

            _id = Id;
            try
            {
                string str = "";
                textBoxParameter.Text = new ViewModel.StationMonitoringStateParameters.StationMonitoringStateParameters().GetListByID(_id, ref str).Single().ParametersName;
                textBoxParameter.Tag = new ViewModel.StationMonitoringStateParameters.StationMonitoringStateParameters().GetListByID(_id, ref str).Single().Parameters_Id;
                TextBoxParameterDescription.Text = new ViewModel.StationMonitoringStateParameters.StationMonitoringStateParameters().GetListByID(_id, ref str).Single().Description;
            }
            catch { }
        }

        public StationMonitoringStateParameters_UC()
        {
            InitializeComponent();
        }


        public void CheckvalidationUC()
        {
            if (textBoxParameter.Text == "")
            {
                SaveResult = false;
                MessageResultStationMonitoringStateParameters = "پارامتر را وارد نمایید";
                return;
            }
        }

        public void save(int StationMonitoringState_Id)
        {
            try
            {
                SaveResult = true;
                string str = "";

                Model.StationMonitoringStateParameters.TBL_StationMonitoringStateParameter tb = new Model.StationMonitoringStateParameters.TBL_StationMonitoringStateParameter();
                tb.Parameters_Id = textBoxParameter.Tag.ToString().ToInt();
                tb.StationMonitoringState_Id = StationMonitoringState_Id;
                tb.Description = TextBoxParameterDescription.Text;
                List<Model.StationMonitoringStateParameters.TBL_StationMonitoringStateParameter> ls = new List<Model.StationMonitoringStateParameters.TBL_StationMonitoringStateParameter>();
                ls.Add(tb);
                new ViewModel.StationMonitoringStateParameters.StationMonitoringStateParameters().InsertEntity(
                   ls, ref str);
            }
            catch (Exception ex) 
            {
                MSS.Library.Clasess.MSSMessage.MSSMessage_View(ex.Message, MSS.Library.Clasess.MSSMessage.MessageType.SError);
            }

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (MSS.Library.Clasess.MSSMessage.MSSMessage_View(0, MSS.Library.Clasess.MSSMessage.MessageType.SConfirmation, true, "آیا مایلید پارامتر حذف شود؟"))
            {
                this.Visible = false;
            }
        }

        private void buttonParameter_Click(object sender, EventArgs e)
        {
            string StrSet = "";
            Dictionary<string, string> SD = new Dictionary<string, string>();
            Dictionary<string, string> SD1 = new Dictionary<string, string>();

            foreach (var item in new ViewModel.Basic.Parameters().GetList(ref StrSet))
                SD.Add(item.Id.ToString(), item.Name);

            SD1 = MSS.Library.Forms.MSSSelector_frm.SetDataSelect(SD);
            try
            {
                textBoxParameter.Tag = SD1.Keys.ToList()[0];
                textBoxParameter.Text = SD1.Values.ToList()[0];
            }
            catch { }

        }

    }
}
