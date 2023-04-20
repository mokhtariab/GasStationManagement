using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using GasStationManagement.Model.Basic.DataAccess;
using GasStationManagement.Model.PressTransSupply;
using MSS.Library.Clasess.FilterClass;


namespace GasStationManagement.View.MainForms.PressTrans
{
    public partial class PressTransSupplyAdd_Frm : MSS.Library.Forms.MSSBaseNew_frm
    {
       private int _PressTrans_Id = 0;
        private string _PressTransSerialNo = "";
        private bool _editIns = false;


        public PressTransSupplyAdd_Frm(int PressTrans_Id)
        {
            InitializeComponent();
            _PressTrans_Id = PressTrans_Id;

            string str = ""; 
            textBoxPressTrans_Id.Text = new ViewModel.Basic.PressureTransmitter().GetListByID(_PressTrans_Id, ref str).Single().Model;
        }


        public PressTransSupplyAdd_Frm(int PressTrans_Id, string PressTransSerialNo)
        {
            InitializeComponent();
            _PressTrans_Id = PressTrans_Id;
            _PressTransSerialNo = PressTransSerialNo;

            string str = "";
            textBoxPressTrans_Id.Text = new ViewModel.Basic.PressureTransmitter().GetListByID(_PressTrans_Id, ref str).Single().Model;

            _editIns = true;
        }

        private void PressTransSupplyAdd_Frm_Load(object sender, EventArgs e)
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
            
            
            ViewModel.PressTransSupply.PressTransSupply RN = new ViewModel.PressTransSupply.PressTransSupply();

            List<VW_PressTransSupply> ListPressTransSupply = RN.GetListByFilter(Ls, ref str);
            
            //textBoxPressTrans_Id.Text = RN.GetListByFilter(Ls, ref str)[0].Brand;
            TextBoxPressTransSerialNo.Text = ListPressTransSupply[0].PressTransSerialNo.ToString();

            DatePickerSupplyDate.Value = KagNetComponents2.KagPersianDate.Parse(ListPressTransSupply[0].SupplyDate);

            TextBoxSuppliers_Id.Text = ListPressTransSupply[0].Name;
            TextBoxSuppliers_Id.Tag = ListPressTransSupply[0].Suppliers_Id.ToString();
            IntBoxPrice.Value = ListPressTransSupply[0].Price;

            TextBoxDescription.Text = ListPressTransSupply[0].Description;
            checkBoxIsActive.Checked = ListPressTransSupply[0].IsActive;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckValidation())
                return;
            try
            {
                string str = "";
                List<TBL_PressTransSupply> Ls = new List<TBL_PressTransSupply>(1);
                TBL_PressTransSupply PressTransSupply = new TBL_PressTransSupply();
                PressTransSupply.PressTrans_Id = _PressTrans_Id;

                PressTransSupply.PressTransSerialNo = TextBoxPressTransSerialNo.Text;

                PressTransSupply.SupplyDate = DatePickerSupplyDate.Value.ToString();
                PressTransSupply.Price = Convert.ToInt64(IntBoxPrice.Value);

                PressTransSupply.Suppliers_Id = Convert.ToInt16(TextBoxSuppliers_Id.Tag.ToString());

                PressTransSupply.Description = TextBoxDescription.Text;
                PressTransSupply.IsActive = Convert.ToBoolean(checkBoxIsActive.Checked);

                Ls.Add(PressTransSupply);

                if (!_editIns)
                {
                    new ViewModel.PressTransSupply.PressTransSupply().InsertEntity(Ls, ref str);
                }
                else
                {
                    new ViewModel.PressTransSupply.PressTransSupply().UpdateEntity(Ls, ref str);
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


    }
}
