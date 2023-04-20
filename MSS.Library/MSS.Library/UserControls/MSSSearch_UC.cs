using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MSS.Library.Clasess.FilterClass;

namespace MSS.Library.UserControls
{
    public partial class MSSSearch_UC : UserControl
    {
        public bool SaveResult = true;
        public string MessageResultStateDrugs = "";


        public MSS.Library.Control.MSSGridexView _grid;
        [System.ComponentModel.DefaultValue(typeof(MSS.Library.Control.MSSGridexView), "(none)")]
        public MSS.Library.Control.MSSGridexView GridViewSet
        {
            get
            {
                if (_grid == null) return null;
                return _grid;
            }
            set
            {
                _grid = value;
            }
        }

        QueryFilter.ExpressionBuilder.Filter _thisFilter = new QueryFilter.ExpressionBuilder.Filter();
        public MSSSearch_UC(MSS.Library.Control.MSSGridexView GridViewEnter, QueryFilter.ExpressionBuilder.Filter ThisFilter)
        {
            InitializeComponent();
            
            this.GridViewSet = GridViewEnter;

            SetColumnList();
            
            _thisFilter = ThisFilter;
            comboBoxAndOr.SelectedIndex = 1;
            SetComponentFilter();
        }

        private void SetComponentFilter()
        {
            if (_thisFilter == null) return;

            ComboBoxFieldList.SelectedValue = _thisFilter.PropertyName;
            ComboBoxIf.SelectedIndex = (int)_thisFilter.Operation;
            TextBoxStrSearch.Text = _thisFilter.Value.ToString();
            comboBoxAndOr.SelectedIndex = (int)_thisFilter.OperationFilter;
        }

        List<Tuple<string, string, Type>> lm = new List<Tuple<string,string,Type>>();
        private void SetColumnList()
        {
            ComboBoxFieldList.Items.Clear();
            lm.Clear();

            Dictionary<string, string> k = new Dictionary<string, string>();
            foreach (Janus.Windows.GridEX.GridEXColumn item in _grid.RootTable.Columns)
            {
                if (item.Tag != null) continue;
                k.Add(item.Key, item.Caption);
                lm.Add(new Tuple<string, string, Type>(item.Key, item.Caption, item.Type));
            }
            ComboBoxFieldList.DisplayMember = "Value";
            ComboBoxFieldList.ValueMember = "Key";

            ComboBoxFieldList.DataSource = (from l in k.ToList() select new { l.Key, l.Value }).ToList();
            
            //foreach (DevComponents.Editors.ComboItem item in ComboBoxFieldList.Items)
            //    item.TextAlignment = StringAlignment.Center;
        }


        public void save(ref QueryFilter.ExpressionBuilder.Filter thisfilter)
        {
            if (TextBoxStrSearch.Text == "" || ComboBoxIf.SelectedIndex == -1 || comboBoxAndOr.SelectedIndex == -1 || ComboBoxFieldList.Text == "")
            {
                SaveResult = false;
                MessageResultStateDrugs = "تمامی موارد را وارد نمایید";
                return;
            }
            try
            {
                SaveResult = true;
                _thisFilter = new QueryFilter.ExpressionBuilder.Filter();
                _thisFilter.PropertyName = ComboBoxFieldList.SelectedValue.ToString();
                _thisFilter.Operation = (QueryFilter.ExpressionBuilder.Op)ComboBoxIf.SelectedIndex;
                foreach (Tuple<string,string,Type> oo in lm)
                    if (oo.Item1 == _thisFilter.PropertyName)
                    {
                        _thisFilter.Value = Convert.ChangeType(TextBoxStrSearch.Text, oo.Item3);
                        break;
                    }

                _thisFilter.OperationFilter = (QueryFilter.ExpressionBuilder.OpFilter)comboBoxAndOr.SelectedIndex;
                
                thisfilter =  _thisFilter;
            }
            catch (Exception ex)
            {
                MSS.Library.Clasess.MSSMessage.MSSMessage_View(ex.Message, Library.Clasess.MSSMessage.MessageType.SError);
            }

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }


    }
}
