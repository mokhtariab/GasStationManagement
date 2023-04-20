using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using GasStationManagement.Model.Basic.DataAccess;


namespace GasStationManagement.View.BaseForms
{
    public partial class LineAdd_Frm : MSS.Library.Forms.MSSBaseNew_frm
    {
        private short _LineCode = 0;
        private bool _editIns = false;

        public LineAdd_Frm()
        {
            InitializeComponent();
            SetCombobox();
        }

        public LineAdd_Frm(short LineCode)
        {
            InitializeComponent();
            SetCombobox();

            _LineCode = LineCode;
            
            string str = "";
            textBoxName.Text = new ViewModel.Basic.Line().GetListByID(LineCode, ref str)[0].Name;
            ComboBoxZoneOperation_Id.SelectedValue = new ViewModel.Basic.Line().GetListByID(LineCode, ref str)[0].ZoneOperation_Id;
            TextBoxDescription.Text = new ViewModel.Basic.Line().GetListByID(LineCode, ref str)[0].Description;
            checkBoxIsActive.Checked = new ViewModel.Basic.Line().GetListByID(LineCode, ref str)[0].IsActive;
            _editIns = true;
        }
        
        void SetCombobox()
        {
            string str = "";
            ComboBoxZoneOperation_Id.ValueMember = "Id";
            ComboBoxZoneOperation_Id.DisplayMember = "Name";
            ComboBoxZoneOperation_Id.DataSource = new ViewModel.Basic.ZoneOperation().GetList(ref str);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckValidation())
                return;
            try
            {
                string str = "";
                List<TBL_Line> Ls = new List<TBL_Line>(1);
                TBL_Line Line = new TBL_Line();
                Line.Id = _LineCode;
                Line.Name = textBoxName.Text;
                Line.ZoneOperation_Id = Convert.ToInt16(ComboBoxZoneOperation_Id.SelectedValue);
                Line.Description = TextBoxDescription.Text;
                Line.IsActive = checkBoxIsActive.Checked;
                Ls.Add(Line);

                if (!_editIns)
                {
                    new ViewModel.Basic.Line().InsertEntity(Ls, ref str);
                }
                else
                {
                    new ViewModel.Basic.Line().UpdateEntity(Ls, ref str);
                }

                MSS.Library.Clasess.MSSMessage.MSSMessage_View("اطلاعات ذخیره شد", MSS.Library.Clasess.MSSMessage.MessageType.SInformation);
                Close();
            }
            catch (Exception ex)
            {
                MSS.Library.Clasess.MSSMessage.MSSMessage_View(0, MSS.Library.Clasess.MSSMessage.MessageType.SError, false, ex.Message);
            }

        }


        private bool CheckValidation()
        {
            if (textBoxName.Text.Trim() == "")
            {
                MSS.Library.Clasess.MSSMessage.MSSMessage_View("جای خالی را پر نمایید", MSS.Library.Clasess.MSSMessage.MessageType.SInformation);
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
