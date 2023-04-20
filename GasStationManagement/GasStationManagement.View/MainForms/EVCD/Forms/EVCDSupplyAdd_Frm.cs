using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using GasStationManagement.Model.Basic.DataAccess;
using GasStationManagement.Model.EVCDSupply;
using MSS.Library.Clasess.FilterClass;


namespace GasStationManagement.View.MainForms.EVCD
{
    public partial class EVCDSupplyAdd_Frm : MSS.Library.Forms.MSSBaseNew_frm
    {
        private int _EVCD_Id = 0;
        private string _EVCDSerialNo = "";
        private bool _editIns = false;


        public EVCDSupplyAdd_Frm(int EVCD_Id)
        {
            InitializeComponent();
            _EVCD_Id = EVCD_Id;

            string str = ""; 
            textBoxEVCD_Id.Text = new ViewModel.Basic.EVCD().GetListByID(_EVCD_Id, ref str).Single().Model;
        }


        public EVCDSupplyAdd_Frm(int EVCD_Id, string EVCDSerialNo)
        {
            InitializeComponent();
            _EVCD_Id = EVCD_Id;
            _EVCDSerialNo = EVCDSerialNo;

            string str = "";
            textBoxEVCD_Id.Text = new ViewModel.Basic.EVCD().GetListByID(_EVCD_Id, ref str).Single().Model;

            _editIns = true;
        }

        private void EVCDSupplyAdd_Frm_Load(object sender, EventArgs e)
        {
            if (_editIns) fillControl();
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
            
            
            ViewModel.EVCDSupply.EVCDSupply RN = new ViewModel.EVCDSupply.EVCDSupply();
            List<VW_EVCDSupply> ListEVCDSupply = RN.GetListByFilter(Ls, ref str);


            //textBoxEVCD_Id.Text = RN.GetListByFilter(Ls, ref str)[0].Brand;
            TextBoxEVCDSerialNo.Text = ListEVCDSupply[0].EVCDSerialNo.ToString();

            DatePickerSupplyDate.Value = KagNetComponents2.KagPersianDate.Parse(ListEVCDSupply[0].SupplyDate);

            TextBoxSuppliers_Id.Text = ListEVCDSupply[0].Name;
            TextBoxSuppliers_Id.Tag = ListEVCDSupply[0].Suppliers_Id.ToString();
            IntBoxPrice.Value = ListEVCDSupply[0].Price;

            TextBoxTEVCDSerialNo.Text = ListEVCDSupply[0].TEVCDSerialNo;
            TextBoxPEVCDSerialNo.Text = ListEVCDSupply[0].PEVCDSerialNo;
            IntBoxInitialVm.Text = ListEVCDSupply[0].InitialVm.ToString();
            TextBoxDescription.Text = ListEVCDSupply[0].Description;
            checkBoxIsActive.Checked = ListEVCDSupply[0].IsActive.Value;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckValidation())
                return;
            try
            {
                string str = "";
                List<TBL_EVCDSupply> Ls = new List<TBL_EVCDSupply>(1);
                TBL_EVCDSupply EVCDSupply = new TBL_EVCDSupply();
                EVCDSupply.EVCD_Id = _EVCD_Id;

                EVCDSupply.EVCDSerialNo = TextBoxEVCDSerialNo.Text;

                EVCDSupply.SupplyDate = DatePickerSupplyDate.Value.ToString();
                EVCDSupply.Price = Convert.ToInt64(IntBoxPrice.Value);

                EVCDSupply.TEVCDSerialNo = TextBoxTEVCDSerialNo.Text;
                EVCDSupply.PEVCDSerialNo = TextBoxPEVCDSerialNo.Text;
                EVCDSupply.InitialVm = IntBoxInitialVm.Text.ToInt();
                EVCDSupply.Suppliers_Id = Convert.ToInt16(TextBoxSuppliers_Id.Tag.ToString());

                EVCDSupply.Description = TextBoxDescription.Text;
                EVCDSupply.IsActive = Convert.ToBoolean(checkBoxIsActive.Checked);

                Ls.Add(EVCDSupply);

                if (!_editIns)
                {
                    new ViewModel.EVCDSupply.EVCDSupply().InsertEntity(Ls, ref str);
                }
                else
                {
                    new ViewModel.EVCDSupply.EVCDSupply().UpdateEntity(Ls, ref str);
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
                MSS.Library.Clasess.MSSMessage.MSSMessage_View("لطفا سریال را پر نمایید", MSS.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                return false;
            }
            if (IntBoxInitialVm.Text.Trim() == "")
            {
                MSS.Library.Clasess.MSSMessage.MSSMessage_View("لطفا Vm اولیه را پر نمایید", MSS.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                return false;
            }
            if (TextBoxSuppliers_Id.Text.Trim() == "")
            {
                MSS.Library.Clasess.MSSMessage.MSSMessage_View("لطفا تامین کننده را پر نمایید", MSS.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                return false;
            }
            return true;
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
