using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using GasStationManagement.Model.Basic.DataAccess;


namespace GasStationManagement.View.MainForms.TemperatureSensor
{
    public partial class TemperatureSensorAdd_Frm : MSS.Library.Forms.MSSBaseNew_frm
    {
        private int _id = 0;
        private bool _editIns = false;


         public TemperatureSensorAdd_Frm()
        {
            InitializeComponent();
        }


        public TemperatureSensorAdd_Frm(int Id)
        {
            InitializeComponent();
            _id = Id;
            _editIns = true;
        }

        private void TemperatureSensorAdd_Frm_Load(object sender, EventArgs e)
        {
            SetComboBox();

            if (_editIns) fillControl();
        }

        private void SetComboBox()
        {
            string str = "";
            //ComboBoxSize.DataSource = new ViewModel.Basic.TemperatureSensor().GetList(ref str).Single().Size.ToString().Distinct();
            //ComboBoxClass.DataSource = new ViewModel.Basic.TemperatureSensor().GetList(ref str).Single().Class.Distinct();
            //ComboBoxGrate.DataSource = new ViewModel.Basic.TemperatureSensor().GetList(ref str).Single().Grate.ToString().Distinct();
        }

        private void fillControl()
        {
            string str = "";
            ViewModel.Basic.TemperatureSensor RN = new ViewModel.Basic.TemperatureSensor();

            textBoxBrand.Text = RN.GetListByID(_id, ref str)[0].Brand;
            TextBoxSensorType.Text = RN.GetListByID(_id, ref str)[0].SensorType;

            IntBoxWireCount.Value = RN.GetListByID(_id, ref str)[0].WireCount;
            IntBoxPacketLength.Value = RN.GetListByID(_id, ref str)[0].PacketLength;
            IntBoxTMin.Value = RN.GetListByID(_id, ref str)[0].TMin;
            IntBoxTMax.Value = RN.GetListByID(_id, ref str)[0].TMax;
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
                List<TBL_TemperatureSensor> Ls = new List<TBL_TemperatureSensor>(1);
                TBL_TemperatureSensor TemperatureSensor = new TBL_TemperatureSensor();
                TemperatureSensor.Id = _id;

                TemperatureSensor.Brand = textBoxBrand.Text;
                TemperatureSensor.SensorType = TextBoxSensorType.Text;

                TemperatureSensor.WireCount = IntBoxWireCount.Text.ToInt();
                TemperatureSensor.PacketLength = IntBoxPacketLength.Text.ToInt();
                TemperatureSensor.TMin = IntBoxTMin.Text.ToInt();
                TemperatureSensor.TMax = IntBoxTMax.Text.ToInt();
                
                TemperatureSensor.Description = TextBoxDescription.Text;
                TemperatureSensor.IsActive = Convert.ToBoolean(checkBoxIsActive.Checked);

                Ls.Add(TemperatureSensor);

                if (!_editIns)
                {
                    new ViewModel.Basic.TemperatureSensor().InsertEntity(Ls, ref str);
                }
                else
                {
                    new ViewModel.Basic.TemperatureSensor().UpdateEntity(Ls, ref str);
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
            if (TextBoxSensorType.Text.Trim() == "")
            {
                MSS.Library.Clasess.MSSMessage.MSSMessage_View("لطفا نوع سنسور دما را پر نمایید", MSS.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                return false;
            }
            if (IntBoxWireCount.Text.Trim() == "")
            {
                MSS.Library.Clasess.MSSMessage.MSSMessage_View("لطفا تعداد سیم ها را پر نمایید", MSS.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                return false;
            }
            if (IntBoxPacketLength.Text.Trim() == "")
            {
                MSS.Library.Clasess.MSSMessage.MSSMessage_View("لطفا طول پاکت را پر نمایید", MSS.Library.Clasess.MSSMessage.MessageType.SConfirmation);
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
