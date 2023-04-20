using System.Linq;
using System.Collections.Generic;
using GasStationManagement.Model.Basic.DataAccess;

namespace GasStationManagement.View.BaseForms
{
    public partial class Line_Frm : System.Windows.Forms.Form
    {
        public Line_Frm()
        {
            InitializeComponent();
        }

        public void BindData()
        {
            string str = "";
            GridViewLine.DataSource = new ViewModel.Basic.Line().GetList(ref str);
        }

        
        #region All UI Button

        private void headerGridLine_btnInsertClick(object sender, System.EventArgs e)
        {
            LineAdd_Frm LineAdd = new LineAdd_Frm();
            LineAdd.ShowDialog();
            BindData();
        }

        private void headerGridLine_btnEditClick(object sender, System.EventArgs e)
        {
            LineAdd_Frm LineAdd = new LineAdd_Frm(byte.Parse(GridViewLine.CurrentRow.Cells["Id"].Value.ToString()));
            LineAdd.ShowDialog();
            BindData();
        }

        private void headerGridLine_btnDeleteClick(object sender, System.EventArgs e)
        {
            if (MSS.Library.Clasess.MSSMessage.MSSMessage_View(0,MSS.Library.Clasess.MSSMessage.MessageType.SConfirmation,true, "آیا به حذف این مورد اطمینان دارید؟"))
            {
                try
                {
                    List<TBL_Line> Ls = new List<TBL_Line>();
                    TBL_Line Line = new TBL_Line();
                    Line.Id = short.Parse(GridViewLine.CurrentRow.Cells["Id"].Value.ToString());
                    Line.Name = GridViewLine.CurrentRow.Cells["Name"].Value.ToString();
                    Line.Description = GridViewLine.CurrentRow.Cells["Description"].Value.ToString();
                    Line.ZoneOperation_Id = short.Parse(GridViewLine.CurrentRow.Cells["ZoneOperation_Id"].Value.ToString());
                    Line.IsActive = bool.Parse(GridViewLine.CurrentRow.Cells["IsActive"].Value.ToString());
                    Ls.Add(Line);


                    string str = "";
                    new ViewModel.Basic.Line().DeleteEntity(Ls, ref str);
                }
                catch 
                {
                    MSS.Library.Clasess.MSSMessage.MSSMessage_View("امکان حذف این مورد در سیستم وجود ندارد",MSS.Library.Clasess.MSSMessage.MessageType.SError);
                }
            }
            BindData();
        }

        private void headerGridLine_btnRefreshClick(object sender, System.EventArgs e)
        {
            BindData();
        }

        #endregion

        private void Line_Frm_Load(object sender, System.EventArgs e)
        {
            BindData();
        }


    }
}
