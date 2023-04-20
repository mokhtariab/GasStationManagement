using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using GasStationManagement.Model.Basic.DataAccess;
using GasStationManagement.Model.TemTransSupply;
using MSS.Library.Clasess.FilterClass;


namespace GasStationManagement.View.MainForms.TemTrans
{
    public partial class TemTransSupplyAdd_Frm : MSS.Library.Forms.MSSBaseNew_frm
    {
       private int _TemTrans_Id = 0;
        private string _TemTransSerialNo = "";
        private bool _editIns = false;


        public TemTransSupplyAdd_Frm(int TemTrans_Id)
        {
            InitializeComponent();
            _TemTrans_Id = TemTrans_Id;

            string str = ""; 
            textBoxTemTrans_Id.Text = new ViewModel.Basic.TemperatureTransmitter().GetListByID(_TemTrans_Id, ref str).Single().Model;
        }


        public TemTransSupplyAdd_Frm(int TemTrans_Id, string TemTransSerialNo)
        {
            InitializeComponent();
            _TemTrans_Id = TemTrans_Id;
            _TemTransSerialNo = TemTransSerialNo;

            string str = "";
            textBoxTemTrans_Id.Text = new ViewModel.Basic.TemperatureTransmitter().GetListByID(_TemTrans_Id, ref str).Single().Model;

            _editIns = true;
        }

        private void TemTransSupplyAdd_Frm_Load(object sender, EventArgs e)
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
            
            
            ViewModel.TemTransSupply.TemTransSupply RN = new ViewModel.TemTransSupply.TemTransSupply();

            List<VW_TemTransSupply> ListTemTransSupply = RN.GetListByFilter(Ls, ref str);
            
            //textBoxTemTrans_Id.Text = RN.GetListByFilter(Ls, ref str)[0].Brand;
            TextBoxTemTransSerialNo.Text = ListTemTransSupply[0].TemTransSerialNo.ToString();

            DatePickerSupplyDate.Value = KagNetComponents2.KagPersianDate.Parse(ListTemTransSupply[0].SupplyDate);

            TextBoxSuppliers_Id.Text = ListTemTransSupply[0].Name;
            TextBoxSuppliers_Id.Tag = ListTemTransSupply[0].Suppliers_Id.ToString();
            IntBoxPrice.Value = ListTemTransSupply[0].Price;

            TextBoxDescription.Text = ListTemTransSupply[0].Description;
            checkBoxIsActive.Checked = ListTemTransSupply[0].IsActive;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckValidation())
                return;
            try
            {
                string str = "";
                List<TBL_TemTransSupply> Ls = new List<TBL_TemTransSupply>(1);
                TBL_TemTransSupply TemTransSupply = new TBL_TemTransSupply();
                TemTransSupply.TemTrans_Id = _TemTrans_Id;

                TemTransSupply.TemTransSerialNo = TextBoxTemTransSerialNo.Text;

                TemTransSupply.SupplyDate = DatePickerSupplyDate.Value.ToString();
                TemTransSupply.Price = Convert.ToInt64(IntBoxPrice.Value);

                TemTransSupply.Suppliers_Id = Convert.ToInt16(TextBoxSuppliers_Id.Tag.ToString());

                TemTransSupply.Description = TextBoxDescription.Text;
                TemTransSupply.IsActive = Convert.ToBoolean(checkBoxIsActive.Checked);

                Ls.Add(TemTransSupply);

                if (!_editIns)
                {
                    new ViewModel.TemTransSupply.TemTransSupply().InsertEntity(Ls, ref str);
                }
                else
                {
                    new ViewModel.TemTransSupply.TemTransSupply().UpdateEntity(Ls, ref str);
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
                MSS.Library.Clasess.MSSMessage.MSSMessage_View("لطفا سریال را پر نمایید", MSS.Library.Clasess.MSSMessage.MessageType.SConfirmation);
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
