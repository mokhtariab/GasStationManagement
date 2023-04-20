using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using GasStationManagement.Model.Basic.DataAccess;
using GasStationManagement.Model.PressGageSupply;
using MSS.Library.Clasess.FilterClass;


namespace GasStationManagement.View.MainForms.PressGage
{
    public partial class PressGageSupplyAdd_Frm : MSS.Library.Forms.MSSBaseNew_frm
    {
        private int _PressGage_Id = 0;
        private string _PressGageSerialNo = "";
        private bool _editIns = false;


        public PressGageSupplyAdd_Frm(int PressGage_Id)
        {
            InitializeComponent();
            _PressGage_Id = PressGage_Id;

            string str = ""; 
            textBoxPressGage_Id.Text = new ViewModel.Basic.PressureGage().GetListByID(_PressGage_Id, ref str).Single().Brand;
        }


        public PressGageSupplyAdd_Frm(int PressGage_Id, string PressGageSerialNo)
        {
            InitializeComponent();
            _PressGage_Id = PressGage_Id;
            _PressGageSerialNo = PressGageSerialNo;

            string str = "";
            textBoxPressGage_Id.Text = new ViewModel.Basic.PressureGage().GetListByID(_PressGage_Id, ref str).Single().Brand;

            _editIns = true;
        }

        private void PressGageSupplyAdd_Frm_Load(object sender, EventArgs e)
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
                PropertyName = "PressGage_Id",
                Value = _PressGage_Id,
                OperationFilter = QueryFilter.ExpressionBuilder.OpFilter.And
            });
            Ls.Add(new QueryFilter.ExpressionBuilder.Filter()
            {
                Operation = QueryFilter.ExpressionBuilder.Op.Equals,
                PropertyName = "PressGageSerialNo",
                Value = _PressGageSerialNo,
                OperationFilter = QueryFilter.ExpressionBuilder.OpFilter.And
            });
            
            
            ViewModel.PressGageSupply.PressGageSupply RN = new ViewModel.PressGageSupply.PressGageSupply();

            List<VW_PressGageSupply> ListPressGageSupply = RN.GetListByFilter(Ls, ref str);
            
            //textBoxPressGage_Id.Text = RN.GetListByFilter(Ls, ref str)[0].Brand;
            TextBoxPressGageSerialNo.Text = ListPressGageSupply[0].PressGageSerialNo.ToString();

            DatePickerSupplyDate.Value = KagNetComponents2.KagPersianDate.Parse(ListPressGageSupply[0].SupplyDate);

            TextBoxSuppliers_Id.Text = ListPressGageSupply[0].Name;
            TextBoxSuppliers_Id.Tag = ListPressGageSupply[0].Suppliers_Id.ToString();
            IntBoxPrice.Value = ListPressGageSupply[0].Price;

            TextBoxDescription.Text = ListPressGageSupply[0].Description;
            checkBoxIsActive.Checked = ListPressGageSupply[0].IsActive;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckValidation())
                return;
            try
            {
                string str = "";
                List<TBL_PressGageSupply> Ls = new List<TBL_PressGageSupply>(1);
                TBL_PressGageSupply PressGageSupply = new TBL_PressGageSupply();
                PressGageSupply.PressGage_Id = _PressGage_Id;

                PressGageSupply.PressGageSerialNo = TextBoxPressGageSerialNo.Text;

                PressGageSupply.SupplyDate = DatePickerSupplyDate.Value.ToString();
                PressGageSupply.Price = Convert.ToInt64(IntBoxPrice.Value);

                PressGageSupply.Suppliers_Id = Convert.ToInt16(TextBoxSuppliers_Id.Tag.ToString());

                PressGageSupply.Description = TextBoxDescription.Text;
                PressGageSupply.IsActive = Convert.ToBoolean(checkBoxIsActive.Checked);

                Ls.Add(PressGageSupply);

                if (!_editIns)
                {
                    new ViewModel.PressGageSupply.PressGageSupply().InsertEntity(Ls, ref str);
                }
                else
                {
                    new ViewModel.PressGageSupply.PressGageSupply().UpdateEntity(Ls, ref str);
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
            if (TextBoxPressGageSerialNo.Text.Trim() == "")
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
