using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using GasStationManagement.Model.Basic.DataAccess;
using GasStationManagement.Model.TemGageSupply;
using MSS.Library.Clasess.FilterClass;


namespace GasStationManagement.View.MainForms.TemGage
{
    public partial class TemGageSupplyAdd_Frm : MSS.Library.Forms.MSSBaseNew_frm
    {
       private int _TemGage_Id = 0;
        private string _TemGageSerialNo = "";
        private bool _editIns = false;


        public TemGageSupplyAdd_Frm(int TemGage_Id)
        {
            InitializeComponent();
            _TemGage_Id = TemGage_Id;

            string str = ""; 
            textBoxTemGage_Id.Text = new ViewModel.Basic.TemperatureGage().GetListByID(_TemGage_Id, ref str).Single().Brand;
        }


        public TemGageSupplyAdd_Frm(int TemGage_Id, string TemGageSerialNo)
        {
            InitializeComponent();
            _TemGage_Id = TemGage_Id;
            _TemGageSerialNo = TemGageSerialNo;

            string str = "";
            textBoxTemGage_Id.Text = new ViewModel.Basic.TemperatureGage().GetListByID(_TemGage_Id, ref str).Single().Brand;

            _editIns = true;
        }

        private void TemGageSupplyAdd_Frm_Load(object sender, EventArgs e)
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
                PropertyName = "TemGage_Id",
                Value = _TemGage_Id,
                OperationFilter = QueryFilter.ExpressionBuilder.OpFilter.And
            });
            Ls.Add(new QueryFilter.ExpressionBuilder.Filter()
            {
                Operation = QueryFilter.ExpressionBuilder.Op.Equals,
                PropertyName = "TemGageSerialNo",
                Value = _TemGageSerialNo,
                OperationFilter = QueryFilter.ExpressionBuilder.OpFilter.And
            });
            
            
            ViewModel.TemGageSupply.TemGageSupply RN = new ViewModel.TemGageSupply.TemGageSupply();

            List<VW_TemGageSupply> ListTemGageSupply = RN.GetListByFilter(Ls, ref str);
            
            //textBoxTemGage_Id.Text = RN.GetListByFilter(Ls, ref str)[0].Brand;
            TextBoxTemGageSerialNo.Text = ListTemGageSupply[0].TemGageSerialNo.ToString();

            DatePickerSupplyDate.Value = KagNetComponents2.KagPersianDate.Parse(ListTemGageSupply[0].SupplyDate);

            TextBoxSuppliers_Id.Text = ListTemGageSupply[0].Name;
            TextBoxSuppliers_Id.Tag = ListTemGageSupply[0].Suppliers_Id.ToString();
            IntBoxPrice.Value = ListTemGageSupply[0].Price;

            TextBoxDescription.Text = ListTemGageSupply[0].Description;
            checkBoxIsActive.Checked = ListTemGageSupply[0].IsActive;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckValidation())
                return;
            try
            {
                string str = "";
                List<TBL_TemGageSupply> Ls = new List<TBL_TemGageSupply>(1);
                TBL_TemGageSupply TemGageSupply = new TBL_TemGageSupply();
                TemGageSupply.TemGage_Id = _TemGage_Id;

                TemGageSupply.TemGageSerialNo = TextBoxTemGageSerialNo.Text;

                TemGageSupply.SupplyDate = DatePickerSupplyDate.Value.ToString();
                TemGageSupply.Price = Convert.ToInt64(IntBoxPrice.Value);

                TemGageSupply.Suppliers_Id = Convert.ToInt16(TextBoxSuppliers_Id.Tag.ToString());

                TemGageSupply.Description = TextBoxDescription.Text;
                TemGageSupply.IsActive = Convert.ToBoolean(checkBoxIsActive.Checked);

                Ls.Add(TemGageSupply);

                if (!_editIns)
                {
                    new ViewModel.TemGageSupply.TemGageSupply().InsertEntity(Ls, ref str);
                }
                else
                {
                    new ViewModel.TemGageSupply.TemGageSupply().UpdateEntity(Ls, ref str);
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
            if (TextBoxTemGageSerialNo.Text.Trim() == "")
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
