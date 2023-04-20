using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using GasStationManagement.Model.Basic.DataAccess;
using GasStationManagement.Model.CounterSupply;
using MSS.Library.Clasess.FilterClass;


namespace GasStationManagement.View.MainForms.Counter
{
    public partial class CounterSupplyAdd_Frm : MSS.Library.Forms.MSSBaseNew_frm
    {
        private int _counter_Id = 0;
        private string _counterSerialNo = "";
        private bool _editIns = false;


        public CounterSupplyAdd_Frm(int counter_Id)
        {
            InitializeComponent();
            _counter_Id = counter_Id;

            string str = ""; 
            textBoxCounter_Id.Text = new ViewModel.Basic.Counter().GetListByID(_counter_Id, ref str).Single().Brand;
        }


        public CounterSupplyAdd_Frm(int Counter_Id, string CounterSerialNo)
        {
            InitializeComponent();
            _counter_Id = Counter_Id;
            _counterSerialNo = CounterSerialNo;

            string str = "";
            textBoxCounter_Id.Text = new ViewModel.Basic.Counter().GetListByID(_counter_Id, ref str).Single().Brand;

            _editIns = true;
        }

        private void CounterSupplyAdd_Frm_Load(object sender, EventArgs e)
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
                PropertyName = "Counter_Id",
                Value = _counter_Id,
                OperationFilter = QueryFilter.ExpressionBuilder.OpFilter.And
            });
            Ls.Add(new QueryFilter.ExpressionBuilder.Filter()
            {
                Operation = QueryFilter.ExpressionBuilder.Op.Equals,
                PropertyName = "CounterSerialNo",
                Value = _counterSerialNo,
                OperationFilter = QueryFilter.ExpressionBuilder.OpFilter.And
            });
            
            
            ViewModel.CounterSupply.CounterSupply RN = new ViewModel.CounterSupply.CounterSupply();

            List<VW_CounterSupply> ListCounterSupply = RN.GetListByFilter(Ls, ref str);
            
            //textBoxCounter_Id.Text = RN.GetListByFilter(Ls, ref str)[0].Brand;
            TextBoxCounterSerialNo.Text = ListCounterSupply[0].CounterSerialNo.ToString();

            DatePickerSupplyDate.Text = ListCounterSupply[0].SupplyDate;

            TextBoxSuppliers_Id.Text = ListCounterSupply[0].Name;
            TextBoxSuppliers_Id.Tag = ListCounterSupply[0].Suppliers_Id.ToString();
            IntBoxPrice.Value = ListCounterSupply[0].Price;

            TextBoxInitialVc.Text = ListCounterSupply[0].InitialVc.ToString();
            TextBoxDescription.Text = ListCounterSupply[0].Description;
            checkBoxIsActive.Checked = ListCounterSupply[0].IsActive.Value;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckValidation())
                return;
            try
            {
                string str = "";
                List<TBL_CounterSupply> Ls = new List<TBL_CounterSupply>(1);
                TBL_CounterSupply CounterSupply = new TBL_CounterSupply();
                CounterSupply.Counter_Id = _counter_Id;

                CounterSupply.CounterSerialNo = TextBoxCounterSerialNo.Text;

                CounterSupply.SupplyDate = DatePickerSupplyDate.Value.ToString().Substring(0,10);
                CounterSupply.Price = IntBoxPrice.Value.ToString().ToInt();

                CounterSupply.InitialVc = TextBoxInitialVc.Text;
                CounterSupply.Suppliers_Id = Convert.ToInt16(TextBoxSuppliers_Id.Tag.ToString());

                CounterSupply.Description = TextBoxDescription.Text;
                CounterSupply.IsActive = Convert.ToBoolean(checkBoxIsActive.Checked);

                Ls.Add(CounterSupply);

                if (!_editIns)
                {
                    new ViewModel.CounterSupply.CounterSupply().InsertEntity(Ls, ref str);
                }
                else
                {
                    new ViewModel.CounterSupply.CounterSupply().UpdateEntity(Ls, ref str);
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
            if (TextBoxCounterSerialNo.Text.Trim() == "")
            {
                MSS.Library.Clasess.MSSMessage.MSSMessage_View("لطفا سریال را پر نمایید", MSS.Library.Clasess.MSSMessage.MessageType.SConfirmation);
                return false;
            }
            if (TextBoxInitialVc.Text.Trim() == "")
            {
                MSS.Library.Clasess.MSSMessage.MSSMessage_View("لطفا Vc اولیه را پر نمایید", MSS.Library.Clasess.MSSMessage.MessageType.SConfirmation);
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
