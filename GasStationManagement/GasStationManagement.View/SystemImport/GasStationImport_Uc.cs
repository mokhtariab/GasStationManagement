using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Office.Interop;
using Microsoft.CSharp;



namespace GasStationManagement.View.SystemImport
{
    public partial class GasStationImport_Uc : UserControl
    {
        public GasStationImport_Uc()
        {
            InitializeComponent();
        }

        #region Export Excel

        private void ReadExcel(string pathStr, string SheetName)
        {
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            excelApp.Visible = false;
            excelApp.ScreenUpdating = false;
            excelApp.DisplayAlerts = false;
            Microsoft.Office.Interop.Excel.Workbook excelWorkbook = excelApp.Workbooks.Open(pathStr, 0, false, 5, "", "", false, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "", true, false, 0, true, false, false);
            Microsoft.Office.Interop.Excel.Sheets excelSheets = excelWorkbook.Worksheets;

            try
            {
                string currentSheet = SheetName;
                Microsoft.Office.Interop.Excel.Worksheet excelWorksheet = (Microsoft.Office.Interop.Excel.Worksheet)excelSheets.get_Item(currentSheet);
                Microsoft.Office.Interop.Excel.Range range = (Microsoft.Office.Interop.Excel.Range)excelWorksheet.UsedRange;
                //string sValue = (range.Cells[_row, _column] as Microsoft.Office.Interop.Excel.Range).Value2.ToString();
                int i = (range as Microsoft.Office.Interop.Excel.Range).Columns.Count;
                int h = (range as Microsoft.Office.Interop.Excel.Range).Rows.Count;

                DataTable dt = new DataTable();
                for (int j = 1; j <= i; j++)
                    dt.Columns.Add((range.Cells[1, j] as Microsoft.Office.Interop.Excel.Range).Value2.ToString(), Type.GetType("System.String"));

                for (int f = 2; f <= h; f++)
                {
                    DataRow dr = dt.NewRow();

                    for (int j = 1; j <= i; j++)
                    {
                        dr[j - 1] = ((range.Cells[f, j] as Microsoft.Office.Interop.Excel.Range).Value2 ?? "").ToString();
                    }
                    dt.Rows.Add(dr);
                }
                GridViewImportExcel.DataSource = dt;
                GridViewImportExcel.RetrieveStructure();

            }
            catch (System.Exception ex)
            {
                if (ex.ToString().Contains("is not a valid"))
                {
                    MSS.Library.Clasess.MSSMessage.MSSMessage_View(0, MSS.Library.Clasess.MSSMessage.MessageType.SError, false, "نام شيت اشتباه است");
                    textBoxPatientID.Focus();
                }
                else
                    MSS.Library.Clasess.MSSMessage.MSSMessage_View(0, MSS.Library.Clasess.MSSMessage.MessageType.SError, false, "اشكال در لود ديتا", ex.Message);
            }
            excelWorkbook.Close();

            excelApp.Quit();



        }
       


        #endregion

        private void buttonImport_Click(object sender, EventArgs e)
        {
            if (GridViewImportExcel.RowCount == 0)
            {
                MSS.Library.Clasess.MSSMessage.MSSMessage_View("اطلاعات پر نشده است", MSS.Library.Clasess.MSSMessage.MessageType.SError);
                textBoxPatientID.Focus();
                return;
            }

            listViewErrore.Nodes.Clear();
            string str = "";
            List<Model.Table_TSample.Table_TSample> ls = new List<Model.Table_TSample.Table_TSample>();

            Model.Table_TSample.Table_TSample tS = null;
            for (int i = 0; i < GridViewImportExcel.RowCount; i++)
            {

                tS = new Model.Table_TSample.Table_TSample()
                {
                    GasStationCode = ComboTreeGasStation.SelectedNode.Cells[0].Text,
                    GasStationName = ComboTreeGasStation.SelectedNode.Cells[1].Text,
                    time_Stamp = MSS.Library.Clasess.Date.DateConvertor.ShamsiDateToMiladiWithTime(GridViewImportExcel.CurrentRow.Cells["strTimeStampShamsi"].Value.ToString(), "", "", "", 0, 0, 0),
                    strTimeStampShamsi = GridViewImportExcel.CurrentRow.Cells["strTimeStampShamsi"].Value.ToString(),
                    EK1_fC = Convert.ToInt32(GridViewImportExcel.CurrentRow.Cells["EK1_fC"].Value),
                    EK1_fP_Psi = Convert.ToInt32(GridViewImportExcel.CurrentRow.Cells["EK1_fP_Psi"].Value),
                    EK1_fPbX = Convert.ToInt32(GridViewImportExcel.CurrentRow.Cells["EK1_fPbX"].Value),
                    EK1_fQb = Convert.ToInt32(GridViewImportExcel.CurrentRow.Cells["EK1_fQb"].Value),
                    EK1_fQm = Convert.ToInt32(GridViewImportExcel.CurrentRow.Cells["EK1_fQm"].Value),
                    EK1_fT = Convert.ToInt32(GridViewImportExcel.CurrentRow.Cells["EK1_fC"].Value),
                    EK1_fTbX = Convert.ToInt32(GridViewImportExcel.CurrentRow.Cells["EK1_fTbX"].Value),
                    EK1_nBatRemain = Convert.ToInt32(GridViewImportExcel.CurrentRow.Cells["EK1_nBatRemain"].Value),
                    EK1_nVb = Convert.ToInt32(GridViewImportExcel.CurrentRow.Cells["EK1_nVb"].Value),
                    EK1_nVbD = Convert.ToInt32(GridViewImportExcel.CurrentRow.Cells["EK1_nVbD"].Value),
                    EK1_nVm = Convert.ToInt32(GridViewImportExcel.CurrentRow.Cells["EK1_nVm"].Value),
                    EK1_nVmD = Convert.ToInt32(GridViewImportExcel.CurrentRow.Cells["EK1_nVmD"].Value),

                    EK2_fC = Convert.ToInt32(GridViewImportExcel.CurrentRow.Cells["EK2_fC"].Value),
                    EK2_fP_Psi = Convert.ToInt32(GridViewImportExcel.CurrentRow.Cells["EK2_fP_Psi"].Value),
                    EK2_fPbX = Convert.ToInt32(GridViewImportExcel.CurrentRow.Cells["EK2_fPbX"].Value),
                    EK2_fQb = Convert.ToInt32(GridViewImportExcel.CurrentRow.Cells["EK2_fQb"].Value),
                    EK2_fQm = Convert.ToInt32(GridViewImportExcel.CurrentRow.Cells["EK2_fQm"].Value),
                    EK2_fT = Convert.ToInt32(GridViewImportExcel.CurrentRow.Cells["EK2_fC"].Value),
                    EK2_fTbX = Convert.ToInt32(GridViewImportExcel.CurrentRow.Cells["EK2_fTbX"].Value),
                    EK2_nBatRemain = Convert.ToInt32(GridViewImportExcel.CurrentRow.Cells["EK2_nBatRemain"].Value),
                    EK2_nVb = Convert.ToInt32(GridViewImportExcel.CurrentRow.Cells["EK2_nVb"].Value),
                    EK2_nVbD = Convert.ToInt32(GridViewImportExcel.CurrentRow.Cells["EK2_nVbD"].Value),
                    EK2_nVm = Convert.ToInt32(GridViewImportExcel.CurrentRow.Cells["EK2_nVm"].Value),
                    EK2_nVmD = Convert.ToInt32(GridViewImportExcel.CurrentRow.Cells["EK2_nVmD"].Value),

                    //EK3_fC = Convert.ToInt32(GridViewImportExcel.CurrentRow.Cells["EK3_fC"].Value),
                    //EK3_fP_Psi = Convert.ToInt32(GridViewImportExcel.CurrentRow.Cells["EK3_fP_Psi"].Value),
                    //EK3_fPbX = Convert.ToInt32(GridViewImportExcel.CurrentRow.Cells["EK3_fPbX"].Value),
                    //EK3_fQb = Convert.ToInt32(GridViewImportExcel.CurrentRow.Cells["EK3_fQb"].Value),
                    //EK3_fQm = Convert.ToInt32(GridViewImportExcel.CurrentRow.Cells["EK3_fQm"].Value),
                    //EK3_fT = Convert.ToInt32(GridViewImportExcel.CurrentRow.Cells["EK3_fC"].Value),
                    //EK3_fTbX = Convert.ToInt32(GridViewImportExcel.CurrentRow.Cells["EK3_fTbX"].Value),
                    //EK3_nBatRemain = Convert.ToInt32(GridViewImportExcel.CurrentRow.Cells["EK3_nBatRemain"].Value),
                    //EK3_nVb = Convert.ToInt32(GridViewImportExcel.CurrentRow.Cells["EK3_nVb"].Value),
                    //EK3_nVbD = Convert.ToInt32(GridViewImportExcel.CurrentRow.Cells["EK3_nVbD"].Value),
                    //EK3_nVm = Convert.ToInt32(GridViewImportExcel.CurrentRow.Cells["EK3_nVm"].Value),
                    //EK3_nVmD = Convert.ToInt32(GridViewImportExcel.CurrentRow.Cells["EK3_nVmD"].Value),


                };
                ls.Add(tS);
            }

            new ViewModel.Table_TSample.Table_TSample().InsertUpdateTable_T(ls, ref str);


            //int CntCheck = 0;
            //for (int i = 0; i < GridViewImportExcel.RowCount; i++)
            //{

            //    System.Windows.Forms.Application.DoEvents();

                //if (GridViewImportExcel.GetRowCellValue(i, "نوع بیمار").ToString() == "")
                //{
                //    listViewErrore.Items.Add("ردیف " + (i + 1).ToString() + ": نوع بیمار خالی می باشد");
                //    listViewErrore.Items[CntCheck].SubItems.Add(i.ToString());
                //    CntCheck++;
                //}

                //if (GridViewImportExcel.GetRowCellValue(i, "شماره پرونده").ToString() == "")
                //{
                //    listViewErrore.Items.Add("ردیف " + (i + 1).ToString() + ": شماره پرونده خالی می باشد");
                //    listViewErrore.Items[CntCheck].SubItems.Add(i.ToString());
                //    CntCheck++;
                //}

                //if (GridViewImportExcel.GetRowCellValue(i, "کدملی").ToString() == "")
                //{
                //    listViewErrore.Items.Add("ردیف " + (i + 1).ToString() + ": کدملی خالی می باشد");
                //    listViewErrore.Items[CntCheck].SubItems.Add(i.ToString());
                //    CntCheck++;
                //}

                //if (GridViewImportExcel.GetRowCellValue(i, "کدملی").ToString().Length != 10)
                //{
                //    listViewErrore.Items.Add("ردیف " + (i + 1).ToString() + ": کدملی 10 رقم نمی باشد");
                //    listViewErrore.Items[CntCheck].SubItems.Add(i.ToString());
                //    CntCheck++;
                //}

                //if (GridViewImportExcel.GetRowCellValue(i, "نام").ToString() == "")
                //{
                //    listViewErrore.Items.Add("ردیف " + (i + 1).ToString() + ": نام بیمار خالی می باشد");
                //    listViewErrore.Items[CntCheck].SubItems.Add(i.ToString());
                //    CntCheck++;
                //}

                //if (GridViewImportExcel.GetRowCellValue(i, "نام خانوادگی").ToString() == "")
                //{
                //    listViewErrore.Items.Add("ردیف " + (i + 1).ToString() + ": نام خانوادگی خالی می باشد");
                //    listViewErrore.Items[CntCheck].SubItems.Add(i.ToString());
                //    CntCheck++;
                //}
            //}
            //if (CntCheck != 0) return;


            //for (int j = 0; j < GridViewImportExcel.RowCount; j++)
            //{
            //    DataClasses_MainDataContext DCMDC = new DataLinq.DataClasses_MainDataContext(Global_Cls.ConnectionStr);
            //    System.Windows.Forms.Application.DoEvents();

            //    try
            //    {
            //        TBL_Patient THC = new TBL_Patient();

            //        //if ((from jh in DCMDC.TBL_PatientTypes
            //        //     where jh.PatientTypeDsc == GridViewImportExcel.GetRowCellValue(j, "نوع بیمار").ToString()
            //        //     select jh).Count() > 0)
            //        //    THC.PatientTypeId = DCMDC.TBL_PatientTypes.First(kk => kk.PatientTypeDsc == GridViewImportExcel.GetRowCellValue(j, "نوع بیمار").ToString()).PatientTypeId;
            //        //else
            //        //{
            //        //    DataClasses_MainDataContext DCM1 = new DataLinq.DataClasses_MainDataContext(Global_Cls.ConnectionStr);
            //        //    TBL_PatientType PT = new TBL_PatientType { PatientTypeDsc = GridViewImportExcel.GetRowCellValue(j, "نوع بیمار").ToString() };
            //        //    DCM1.TBL_PatientTypes.InsertOnSubmit(PT);
            //        //    DCM1.SubmitChanges();
            //        //    THC.PatientTypeId = DCMDC.TBL_PatientTypes.First(kk => kk.PatientTypeDsc == GridViewImportExcel.GetRowCellValue(j, "نوع بیمار").ToString()).PatientTypeId;
            //        //}

            //        THC.DosiersNo = GridViewImportExcel.GetRowCellValue(j, "شماره پرونده").ToString();

            //        THC.CreateDate = DateTime.Now;

            //        THC.PatientName = GridViewImportExcel.GetRowCellValue(j, "نام").ToString();
            //        THC.PatientFamily = GridViewImportExcel.GetRowCellValue(j, "نام خانوادگی").ToString();
            //        THC.ParentName = (GridViewImportExcel.GetRowCellValue(j, "نام پدر") ?? "").ToString();
            //        THC.IDNO = (GridViewImportExcel.GetRowCellValue(j, "شماره شناسنامه") ?? "0").ToString();
            //        THC.NationalCode = (GridViewImportExcel.GetRowCellValue(j, "کدملی") ?? "0").ToString();

            //        try
            //        {
            //            if (GridViewImportExcel.GetRowCellValue(j, "تاریخ تولد").ToString() == "")
            //                THC.BrithDate = DateTime.Now;
            //            else THC.BrithDate = Global_Cls.ShamsiDateToMiladi(GridViewImportExcel.GetRowCellValue(j, "تاریخ تولد").ToString());
            //        }
            //        catch
            //        {
            //            THC.BrithDate = DateTime.Now;
            //        }
            //        THC.BrithCityName = (GridViewImportExcel.GetRowCellValue(j, "صادره از") ?? "").ToString();

            //        THC.PercentState = Convert.ToInt16(GridViewImportExcel.GetRowCellValue(j, "درصد").ToString() == "" ? "0" : GridViewImportExcel.GetRowCellValue(j, "درصد").ToString());

            //        THC.KinShipWith = (GridViewImportExcel.GetRowCellValue(j, "نسبت") ?? "").ToString();
            //        THC.WifeSituation = (GridViewImportExcel.GetRowCellValue(j, "وضعیت همسر") ?? "").ToString();
            //        THC.ProtectSituation = (GridViewImportExcel.GetRowCellValue(j, "وضعیت پایش") ?? "").ToString();
            //        THC.WholeSituation = (GridViewImportExcel.GetRowCellValue(j, "وضعیت کل") ?? "").ToString();
            //        THC.Description = (GridViewImportExcel.GetRowCellValue(j, "توضیحات") ?? "").ToString();

            //        THC.PeriodVisit = Convert.ToInt16(GridViewImportExcel.GetRowCellValue(j, "دوره بازدید").ToString() == "" ? "0" : GridViewImportExcel.GetRowCellValue(j, "دوره بازدید").ToString());

            //        THC.CityPart = (GridViewImportExcel.GetRowCellValue(j, "شهر") ?? "").ToString();
            //        THC.AddressPart = Convert.ToInt16(GridViewImportExcel.GetRowCellValue(j, "منطقه").ToString() == "" ? "0" : GridViewImportExcel.GetRowCellValue(j, "منطقه").ToString());
            //        THC.Address = (GridViewImportExcel.GetRowCellValue(j, "آدرس") ?? "").ToString();
            //        THC.TelHome = (GridViewImportExcel.GetRowCellValue(j, "تلفن منزل") ?? "").ToString();
            //        THC.TelBusiness = (GridViewImportExcel.GetRowCellValue(j, "تلفن") ?? "").ToString();
            //        THC.Mobile = (GridViewImportExcel.GetRowCellValue(j, "موبایل") ?? "").ToString();
            //        THC.Mobile2 = (GridViewImportExcel.GetRowCellValue(j, "موبایل2") ?? "").ToString();
            //        THC.Email = "";

            //        THC.ContractTypeId = 0;
            //        //THC.LastDocHealthId = 0;
            //        THC.LastDocWatcherId = 0;

            //        try
            //        {
            //            if ((from jh in DCMDC.TBL_Doctors
            //                 where jh.DoctorFamily == GridViewImportExcel.GetRowCellValue(j, "پزشک سلامت").ToString()
            //                 select jh).Count() > 0)
            //                THC.LastDocHealthId = (short)DCMDC.TBL_Doctors.First(kk => kk.DoctorFamily == GridViewImportExcel.GetRowCellValue(j, "پزشک سلامت").ToString()).DoctorID;
            //            else
            //            {
            //                THC.LastDocHealthId = 0;
            //            }
            //        }
            //        catch
            //        {
            //            THC.LastDocHealthId = 0;
            //        }

            //        try
            //        {
            //            if (GridViewImportExcel.GetRowCellValue(j, "تاریخ آخرین ویزیت").ToString() == "")
            //                THC.LastOverhalDate = Global_Cls.ShamsiDateToMiladi("1387/01/01");
            //            else THC.LastOverhalDate = Global_Cls.ShamsiDateToMiladi(GridViewImportExcel.GetRowCellValue(j, "تاریخ آخرین ویزیت").ToString());
            //        }
            //        catch
            //        {
            //            THC.LastOverhalDate = Global_Cls.ShamsiDateToMiladi("1387/01/01");
            //        }
            //        THC.Active = true;

            //        DCMDC.TBL_Patients.InsertOnSubmit(THC);
            //        DCMDC.SubmitChanges();
            //    }
            //    catch (Exception ex)
            //    {
            //        if (ex.Message.IndexOf("Duplicated Row!") > -1)
            //        {
            //            listViewErrore.Items.Add("ردیف " + (j + 1).ToString() + ": اطلاعات بیمار در سیستم وجود دارد و تکراری است!");
            //            listViewErrore.Items[CntCheck].SubItems.Add(j.ToString());
            //            CntCheck++;
            //        }
            //        else
            //            if (ex.Message.IndexOf("Duplicated Tbl_Del!") > -1)
            //            {
            //                listViewErrore.Items.Add("ردیف " + (j + 1).ToString() + ": این بیمار در لیست حذفیات موجود می باشد!");
            //                listViewErrore.Items[CntCheck].SubItems.Add(j.ToString());
            //                CntCheck++;
            //            }
            //            else
            //            {
            //                listViewErrore.Items.Add("ردیف " + (j + 1).ToString() + ": اشکال در ثبت!" + ex.Message+"نوع مقادیر");
            //                listViewErrore.Items[CntCheck].SubItems.Add(j.ToString());
            //                CntCheck++;
            //            }
            //    }
            //}
            
            //if (CntCheck == 0)
            //    Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SInformation, false, "اطلاعات بیماران به طور کامل در سیستم درج گردید");
            //else
            //    Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SError, false, "اطلاعات بیماران به غیر از اشکال دارها در سیستم درج گردید");
        }


        private void GridViewImportExcel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)

                if (MSS.Library.Clasess.MSSMessage.MSSMessage_View(0, MSS.Library.Clasess.MSSMessage.MessageType.SWarning, true, "آیا به حذف این ردیف(ها) اطمینان دارید؟"))
                    GridViewImportExcel.SelectedItems.Clear();
        }

        private void listViewErrore_DoubleClick(object sender, EventArgs e)
        {
            //int RF = int.Parse(listViewErrore.SelectedItems[0].SubItems[1].Text);
            //GridViewImportExcel.UnselectRow(GridViewImportExcel.FocusedRowHandle);
            //GridViewImportExcel.SelectRow(RF);
            //GridViewImportExcel.FocusedRowHandle = RF;

        }

        private void buttonPatientID_Click(object sender, EventArgs e)
        {
            if (textBoxPatientID.Text == "")
            {
                MSS.Library.Clasess.MSSMessage.MSSMessage_View(0, MSS.Library.Clasess.MSSMessage.MessageType.SWarning , false, "نام شيت و یا فایل را وارد كنيد");
                textBoxPatientID.Focus();
                return;
            }


            System.Windows.Forms.OpenFileDialog op = new System.Windows.Forms.OpenFileDialog();
            op.Filter = "All Files (*.xls;*.xlsx;*.txt;*.AGR)|*.xls;*.xlsx";
            if (op.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //SetExcelToGrid(op.FileName, textBoxPatientID.Text);
                ReadExcel(op.FileName, textBoxPatientID.Text);
            }
        }

        private void GasStationImport_Uc_Load(object sender, EventArgs e)
        {
            string str = "";
            ComboTreeGasStation.DataSource = new ViewModel.GasStationClass.GasStationClass().GetList(ref str);
        }

        
    }
}
