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
            if (SheetName == "") SheetName = System.IO.Path.GetFileNameWithoutExtension(pathStr);

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
                    dt.Columns.Add((range.Cells[2, j] as Microsoft.Office.Interop.Excel.Range).Value2.ToString(), Type.GetType("System.String"));

                for (int f = 3; f <= h; f++)
                {
                    DataRow dr = dt.NewRow();

                    for (int j = 1; j <= i; j++)
                    {
                        dr[j - 1] = ((range.Cells[f, j] as Microsoft.Office.Interop.Excel.Range).Value2 ?? "").ToString();
                    }
                    dt.Rows.Add(dr);
                }
                GridViewImportExcel.DataSource = null;
                GridViewImportExcel.DataSource = dt;
                GridViewImportExcel.RetrieveStructure();

            }
            catch (System.Exception ex)
            {
                if (ex.Message.Contains("is not a valid") || textBoxPatientID.Text == "")
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

        private void ReadText(string pathStr)
        {
            try
            {
                string filePath = pathStr;//string.Format("{0}/databases/{1}", AppDomain.CurrentDomain.BaseDirectory, pathStr);

                string[] textData = System.IO.File.ReadAllLines(filePath);
                string[] headers = textData[0].Split('\t');

                DataTable dataTable1 = new DataTable();
                foreach (string header in headers)
                {
                    dataTable1.Columns.Add(header.Replace(" ", ""), typeof(string), null);
                    dataTable1.Columns[header.Replace(" ", "")].Caption = header;
                }

                for (int i = 1; i < textData.Length; i++)
                    dataTable1.Rows.Add(textData[i].Split('\t'));

                GridViewImportExcel.DataSource = null;
                GridViewImportExcel.DataSource = dataTable1;
                GridViewImportExcel.RetrieveStructure();

            }
            catch (System.Exception ex)
            {
                MSS.Library.Clasess.MSSMessage.MSSMessage_View(0, MSS.Library.Clasess.MSSMessage.MessageType.SError, false, "اشكال در لود ديتا", ex.Message);
            }
        }
        
        private void ReadAGR(string pathStr)
        {

            try
            {
                string filePath = pathStr;//string.Format("{0}/databases/{1}", AppDomain.CurrentDomain.BaseDirectory, pathStr);

                DataTable dataTable1 = new DataTable();
                string[] textData = System.IO.File.ReadAllLines(filePath);
                string[] headers = textData[0].Split('\t');

                int i;
                for (i = 1; i < textData.Length; i++)
                    if (textData[i].Split('\t')[0] == "#")
                    {
                        headers = textData[i].Split('\t');
                        break;
                    }

                foreach (string header in headers)
                {
                    dataTable1.Columns.Add(header.Replace(" ",""), typeof(string), null);
                    dataTable1.Columns[header.Replace(" ", "")].Caption = header;
                }


                for (int j = i; j < textData.Length; j++)
                {
                    try { int.Parse(textData[j].Split('\t')[0]); }
                    catch { continue; }
                    dataTable1.Rows.Add(textData[j].Split('\t'));
                }
                
                GridViewImportExcel.DataSource = null;
                GridViewImportExcel.DataSource = dataTable1;
                GridViewImportExcel.RetrieveStructure();

            }
            catch (System.Exception ex)
            {
                MSS.Library.Clasess.MSSMessage.MSSMessage_View(0, MSS.Library.Clasess.MSSMessage.MessageType.SError, false, "اشكال در لود ديتا", ex.Message);
            }
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

            if (ComboBoxRan.SelectedItem == null)
            {
                MSS.Library.Clasess.MSSMessage.MSSMessage_View("شماره رن را وارد نمایید", MSS.Library.Clasess.MSSMessage.MessageType.SError);
                ComboBoxRan.Focus();
                return;
            }

            listViewErrore.Clear();

            ProgressBarSave.Visible = true;
            ProgressBarSave.Value = 0;
            ProgressBarSave.Maximum = GridViewImportExcel.RowCount;

            if (System.IO.Path.GetExtension(LabelAddress.Text) == ".txt")
                SaveTextFile();
            else if (System.IO.Path.GetExtension(LabelAddress.Text) == ".AGR")
                SaveAGRFile();
            else
                SaveXlsFile();

            MSS.Library.Clasess.MSSMessage.MSSMessage_View("ثبت اطلاعات با موفقیت به پایان رسید", MSS.Library.Clasess.MSSMessage.MessageType.SInformation);
            
            ProgressBarSave.Visible = false;
        }

        private void SaveTextFile()
        {
            string str = "";
            //List<Model.Table_TSample.Table_TSample> ls = new List<Model.Table_TSample.Table_TSample>();
            int CntCheck = 0;


            for (int i = 0; i < GridViewImportExcel.RowCount; i++)
            {
                GridViewImportExcel.Row = i;
                Model.Table_TSample.Table_TSample tS = new Model.Table_TSample.Table_TSample()
                {
                    GasStationCode = ComboTreeGasStation.SelectedNode.Cells[0].Text,
                    GasStationName = ComboTreeGasStation.SelectedNode.Cells[1].Text,
                };

                try
                {
                    tS.time_Stamp = Convert.ToDateTime(GridViewImportExcel.CurrentRow.Cells["Enddate"].Value.ToString());
                    tS.strTimeStampShamsi = MSS.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(tS.time_Stamp.Value);//
                }
                catch
                {
                    try
                    {
                        string strTime = GridViewImportExcel.CurrentRow.Cells["Time"].Value.ToString();
                        TimeSpan n;
                        strTime = strTime.Substring(strTime.IndexOf("-") + 1).Replace(" ", "");
                        if (strTime.Contains(":"))
                        {
                            if (int.Parse(strTime.Substring(strTime.IndexOf(":") + 1)) % 2 != 0)
                                n = new TimeSpan(int.Parse(strTime.Substring(0, strTime.IndexOf(":"))), int.Parse(strTime.Substring(strTime.IndexOf(":") + 1)) + 1, 0);
                            else
                                n = new TimeSpan(int.Parse(strTime.Substring(0, strTime.IndexOf(":"))), int.Parse(strTime.Substring(strTime.IndexOf(":") + 1)), 0);
                        }
                        else
                        {
                            n = new TimeSpan(int.Parse(strTime), 0, 0);
                        }



                        try { tS.time_Stamp = Convert.ToDateTime(GridViewImportExcel.CurrentRow.Cells["Date"].Value).Add(n); }
                        catch
                        {
                            //    listViewErrore.Items.Add("ردیف " + (i + 1).ToString() + ": نوع بیمار خالی می باشد");
                            //listViewErrore.Items[CntCheck].SubItems.Add(i.ToString());
                            //CntCheck++; 
                        }


                        try { tS.strTimeStampShamsi = MSS.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(tS.time_Stamp.Value); }
                        catch { }
                    }
                    catch { }
                }
                if (ComboBoxRan.SelectedItem.ToString() == "1")
                {
                    try { tS.EK1_fP_Psi = Convert.ToSingle(GridViewImportExcel.CurrentRow.Cells["Pav (Bar)".Replace(" ", "")].Value) * Convert.ToSingle(14.5); }
                    catch { }
                    try { tS.EK1_fQb = Convert.ToSingle(GridViewImportExcel.CurrentRow.Cells["Qcav (Standard Volume/h)".Replace(" ", "")].Value); }
                    catch { }
                    try { tS.EK1_fQm = Convert.ToSingle(GridViewImportExcel.CurrentRow.Cells["QUav (m3/h)".Replace(" ", "")].Value); }
                    catch { }

                    try { tS.EK1_fT = Convert.ToSingle(GridViewImportExcel.CurrentRow.Cells["Tav (�C)".Replace(" ", "")].Value); }
                    catch { }

                    try { tS.EK1_nVb = Convert.ToInt64(Math.Round(Convert.ToSingle(GridViewImportExcel.CurrentRow.Cells["Conv. cons. (Standard Volume)".Replace(" ", "")].Value))); }
                    catch { }

                    try
                    {
                        tS.EK1_nVbD =
                            Convert.ToInt64(Math.Round(Convert.ToSingle(GridViewImportExcel.CurrentRow.Cells["Conv. cons. (AL) (Standard Volume)".Replace(" ", "")].Value))) -
                            Convert.ToInt64(Math.Round(Convert.ToSingle(GridViewImportExcel.CurrentRow.Cells["Conv. cons. (Standard Volume)".Replace(" ", "")].Value)));
                    }
                    catch { }

                    try { tS.EK1_nVm = Convert.ToInt64(Math.Round(Convert.ToSingle(GridViewImportExcel.CurrentRow.Cells["Unconv. cons. (m3)".Replace(" ", "")].Value))); }
                    catch { }
                    try
                    {
                        tS.EK1_nVmD = Convert.ToInt64(Math.Round(Convert.ToSingle(GridViewImportExcel.CurrentRow.Cells["Unconv. cons.(AL) (m3)".Replace(" ", "")].Value)))
                            - Convert.ToInt64(Math.Round(Convert.ToSingle(GridViewImportExcel.CurrentRow.Cells["Unconv. cons. (m3)".Replace(" ", "")].Value)));
                    }
                    catch { }
                }
                else
                    if (ComboBoxRan.SelectedItem.ToString() == "2")
                    {
                        try { tS.EK2_fP_Psi = Convert.ToSingle(GridViewImportExcel.CurrentRow.Cells["Pav (Bar)".Replace(" ", "")].Value) * Convert.ToSingle(14.5); }
                        catch { }
                        try { tS.EK2_fQb = Convert.ToSingle(GridViewImportExcel.CurrentRow.Cells["Qcav (Standard Volume/h)".Replace(" ", "")].Value); }
                        catch { }
                        try { tS.EK2_fQm = Convert.ToSingle(GridViewImportExcel.CurrentRow.Cells["QUav (m3/h)".Replace(" ", "")].Value); }
                        catch { }

                        try { tS.EK2_fT = Convert.ToSingle(GridViewImportExcel.CurrentRow.Cells["Tav (�C)".Replace(" ", "")].Value); }
                        catch { }

                        try { tS.EK2_nVb = Convert.ToInt64(Math.Round(Convert.ToSingle(GridViewImportExcel.CurrentRow.Cells["Conv. cons. (Standard Volume)".Replace(" ", "")].Value))); }
                        catch { }

                        try
                        {
                            tS.EK2_nVbD =
                                Convert.ToInt64(Math.Round(Convert.ToSingle(GridViewImportExcel.CurrentRow.Cells["Conv. cons. (AL) (Standard Volume)".Replace(" ", "")].Value))) -
                                Convert.ToInt64(Math.Round(Convert.ToSingle(GridViewImportExcel.CurrentRow.Cells["Conv. cons. (Standard Volume)".Replace(" ", "")].Value)));
                        }
                        catch { }

                        try { tS.EK2_nVm = Convert.ToInt64(Math.Round(Convert.ToSingle(GridViewImportExcel.CurrentRow.Cells["Unconv. cons. (m3)".Replace(" ", "")].Value))); }
                        catch { }
                        try
                        {
                            tS.EK2_nVmD = Convert.ToInt64(Math.Round(Convert.ToSingle(GridViewImportExcel.CurrentRow.Cells["Unconv. cons.(AL) (m3)".Replace(" ", "")].Value)))
                                - Convert.ToInt64(Math.Round(Convert.ToSingle(GridViewImportExcel.CurrentRow.Cells["Unconv. cons. (m3)".Replace(" ", "")].Value)));
                        }
                        catch { }
                    }
                    else
                        if (ComboBoxRan.SelectedItem.ToString() == "3")
                        {
                            try { tS.EK3_fP_Psi = Convert.ToSingle(GridViewImportExcel.CurrentRow.Cells["Pav (Bar)".Replace(" ", "")].Value) * Convert.ToSingle(14.5); }
                            catch { }
                            try { tS.EK3_fQb = Convert.ToSingle(GridViewImportExcel.CurrentRow.Cells["Qcav (Standard Volume/h)".Replace(" ", "")].Value); }
                            catch { }
                            try { tS.EK3_fQm = Convert.ToSingle(GridViewImportExcel.CurrentRow.Cells["QUav (m3/h)".Replace(" ", "")].Value); }
                            catch { }

                            try { tS.EK3_fT = Convert.ToSingle(GridViewImportExcel.CurrentRow.Cells["Tav (�C)".Replace(" ", "")].Value); }
                            catch { }

                            try { tS.EK3_nVb = Convert.ToInt64(Math.Round(Convert.ToSingle(GridViewImportExcel.CurrentRow.Cells["Conv. cons. (Standard Volume)".Replace(" ", "")].Value))); }
                            catch { }

                            try
                            {
                                tS.EK3_nVbD =
                                    Convert.ToInt64(Math.Round(Convert.ToSingle(GridViewImportExcel.CurrentRow.Cells["Conv. cons. (AL) (Standard Volume)".Replace(" ", "")].Value))) -
                                    Convert.ToInt64(Math.Round(Convert.ToSingle(GridViewImportExcel.CurrentRow.Cells["Conv. cons. (Standard Volume)".Replace(" ", "")].Value)));
                            }
                            catch { }

                            try { tS.EK3_nVm = Convert.ToInt64(Math.Round(Convert.ToSingle(GridViewImportExcel.CurrentRow.Cells["Unconv. cons. (m3)".Replace(" ", "")].Value))); }
                            catch { }
                            try
                            {
                                tS.EK3_nVmD = Convert.ToInt64(Math.Round(Convert.ToSingle(GridViewImportExcel.CurrentRow.Cells["Unconv. cons.(AL) (m3)".Replace(" ", "")].Value)))
                                    - Convert.ToInt64(Math.Round(Convert.ToSingle(GridViewImportExcel.CurrentRow.Cells["Unconv. cons. (m3)".Replace(" ", "")].Value)));
                            }
                            catch { }
                        }

                ProgressBarSave.Value += 1;

                //ls.Add(tS);
                new ViewModel.Table_TSample.Table_TSample().InsertUpdateTable_T(tS, ref str);
                if (str != "")
                {
                   // GridViewImportExcel.CurrentRow.Table.RowFormatStyle.GridEX.CurrentRow = Color.MistyRose;
                    listViewErrore.Items.Add("ردیف " + (i + 1).ToString() + str);
                    listViewErrore.Items[CntCheck].SubItems.Add(i.ToString());
                    CntCheck++;
                }

            }
        }


        private void SaveAGRFile()
        {
            string str = "";
            List<Model.Table_TSample.Table_TSample> ls = new List<Model.Table_TSample.Table_TSample>();
            int CntCheck = 0;

            Model.Table_TSample.Table_TSample tS = null;
            for (int i = 0; i < GridViewImportExcel.RowCount; i++)
            {
                GridViewImportExcel.Row = i;
                tS = new Model.Table_TSample.Table_TSample()
                {
                    GasStationCode = ComboTreeGasStation.SelectedNode.Cells[0].Text,
                    GasStationName = ComboTreeGasStation.SelectedNode.Cells[1].Text,
                };



                try { tS.time_Stamp = Convert.ToDateTime(GridViewImportExcel.CurrentRow.Cells["Zeit"].Value); }
                catch { }
                try { tS.strTimeStampShamsi = MSS.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(tS.time_Stamp.Value); }
                catch { }


                if (ComboBoxRan.SelectedItem.ToString() == "1")
                {
                    try { tS.EK1_fP_Psi = Convert.ToSingle(GridViewImportExcel.CurrentRow.Cells["p.MP"].Value); }
                    catch { }

                    try { tS.EK1_fT = Convert.ToSingle(GridViewImportExcel.CurrentRow.Cells["T.MP"].Value); }
                    catch { }
                    try { tS.EK1_fC = Convert.ToSingle(GridViewImportExcel.CurrentRow.Cells["C.MP"].Value); }
                    catch { }

                    try { tS.EK1_nVb = Convert.ToInt64(Math.Round(Convert.ToSingle(GridViewImportExcel.CurrentRow.Cells["Vb"].Value))); }
                    catch { }

                    try { tS.EK1_nVbD = Convert.ToInt64(Math.Round(Convert.ToSingle(GridViewImportExcel.CurrentRow.Cells["VbT"].Value))); }
                    catch { }

                    try { tS.EK1_nVm = Convert.ToInt64(Math.Round(Convert.ToSingle(GridViewImportExcel.CurrentRow.Cells["Vm"].Value))); }
                    catch { }
                    try { tS.EK1_nVmD = Convert.ToInt64(Math.Round(Convert.ToSingle(GridViewImportExcel.CurrentRow.Cells["VmT"].Value))); }
                    catch { }
                }
                else
                    if (ComboBoxRan.SelectedItem.ToString() == "2")
                    {
                        try { tS.EK2_fP_Psi = Convert.ToSingle(GridViewImportExcel.CurrentRow.Cells["p.MP"].Value); }
                        catch { }

                        try { tS.EK2_fT = Convert.ToSingle(GridViewImportExcel.CurrentRow.Cells["T.MP"].Value); }
                        catch { }
                        try { tS.EK2_fC = Convert.ToSingle(GridViewImportExcel.CurrentRow.Cells["C.MP"].Value); }
                        catch { }

                        try { tS.EK2_nVb = Convert.ToInt64(Math.Round(Convert.ToSingle(GridViewImportExcel.CurrentRow.Cells["Vb"].Value))); }
                        catch { }

                        try { tS.EK2_nVbD = Convert.ToInt64(Math.Round(Convert.ToSingle(GridViewImportExcel.CurrentRow.Cells["VbT"].Value))); }
                        catch { }

                        try { tS.EK2_nVm = Convert.ToInt64(Math.Round(Convert.ToSingle(GridViewImportExcel.CurrentRow.Cells["Vm"].Value))); }
                        catch { }
                        try { tS.EK2_nVmD = Convert.ToInt64(Math.Round(Convert.ToSingle(GridViewImportExcel.CurrentRow.Cells["VmT"].Value))); }
                        catch { }
                    }
                    else
                        if (ComboBoxRan.SelectedItem.ToString() == "3")
                        {
                            try { tS.EK3_fP_Psi = Convert.ToSingle(GridViewImportExcel.CurrentRow.Cells["p.MP"].Value); }
                            catch
                            {
                                GridViewImportExcel.CurrentRow.Cells["p.MP"].FormatStyle.BackColor = Color.Red;
                            }

                            try { tS.EK3_fT = Convert.ToSingle(GridViewImportExcel.CurrentRow.Cells["T.MP"].Value); }
                            catch
                            {
                                GridViewImportExcel.CurrentRow.Cells["T.MP"].FormatStyle.BackColor = Color.Red;
                            }
                            
                            try { tS.EK3_fC = Convert.ToSingle(GridViewImportExcel.CurrentRow.Cells["C.MP"].Value); }
                            catch
                            {
                                GridViewImportExcel.CurrentRow.Cells["C.MP"].FormatStyle.BackColor = Color.Red;
                            }

                            try { tS.EK3_nVb = Convert.ToInt64(Math.Round(Convert.ToSingle(GridViewImportExcel.CurrentRow.Cells["Vb"].Value))); }
                            catch
                            {
                                GridViewImportExcel.CurrentRow.Cells["Vb"].FormatStyle.BackColor = Color.Red;
                            }

                            try { tS.EK3_nVbD = Convert.ToInt64(Math.Round(Convert.ToSingle(GridViewImportExcel.CurrentRow.Cells["VbT"].Value))); }
                            catch
                            {
                                GridViewImportExcel.CurrentRow.Cells["VbT"].FormatStyle.BackColor = Color.Red;
                            }

                            try { tS.EK3_nVm = Convert.ToInt64(Math.Round(Convert.ToSingle(GridViewImportExcel.CurrentRow.Cells["Vm"].Value))); }
                            catch
                            {
                                GridViewImportExcel.CurrentRow.Cells["Vm"].FormatStyle.BackColor = Color.Red;
                            }

                            try { tS.EK3_nVmD = Convert.ToInt64(Math.Round(Convert.ToSingle(GridViewImportExcel.CurrentRow.Cells["VmT"].Value))); }
                            catch
                            {
                                GridViewImportExcel.CurrentRow.Cells["VmT"].FormatStyle.BackColor = Color.Red;
                            }
                        }
                
                ProgressBarSave.Value += 1;

                //ls.Add(tS);
                new ViewModel.Table_TSample.Table_TSample().InsertUpdateTable_T(tS, ref str);
                if (str != "")
                {
                    GridViewImportExcel.CurrentRow.Table.RowFormatStyle.BackColor = Color.MistyRose;
                    listViewErrore.Items.Add("ردیف " + (i + 1).ToString() + str);
                    listViewErrore.Items[CntCheck].SubItems.Add(i.ToString());
                    CntCheck++;
                }
            }
        }

        private void SaveXlsFile()
        {
            string str = "";
            List<Model.Table_TSample.Table_TSample> ls = new List<Model.Table_TSample.Table_TSample>();
            int CntCheck = 0;


            Model.Table_TSample.Table_TSample tS = null;
            for (int i = 0; i < GridViewImportExcel.RowCount; i++)
            {
                GridViewImportExcel.Row = i;
                tS = new Model.Table_TSample.Table_TSample()
                {
                    GasStationCode = ComboTreeGasStation.SelectedNode.Cells[0].Text,
                    GasStationName = ComboTreeGasStation.SelectedNode.Cells[1].Text,
                };



                try { tS.time_Stamp = Convert.ToDateTime(GridViewImportExcel.CurrentRow.Cells["DateTime"].Value); }
                catch { }
                try { tS.strTimeStampShamsi = MSS.Library.Clasess.Date.DateConvertor.MiladiDateToShamsiWithTime(tS.time_Stamp.Value); }
                catch { }


                if (ComboBoxRan.SelectedItem.ToString() == "1")
                {
                    try { tS.EK1_fP_Psi = Convert.ToSingle(GridViewImportExcel.CurrentRow.Cells["Pressure p1"].Value) * Convert.ToSingle(14.5); }
                    catch { }

                    try { tS.EK1_fT = Convert.ToSingle(GridViewImportExcel.CurrentRow.Cells["Temperature t1"].Value); }
                    catch { }
                    try { tS.EK1_fC = Convert.ToSingle(GridViewImportExcel.CurrentRow.Cells["Convers. factor C1"].Value); }
                    catch { }

                    try { tS.EK1_nVb = Convert.ToInt64(Math.Round(Convert.ToSingle(GridViewImportExcel.CurrentRow.Cells["Base volume Vb1"].Value))); }
                    catch { }

                    try { tS.EK1_nVbD = Convert.ToInt64(Math.Round(Convert.ToSingle(GridViewImportExcel.CurrentRow.Cells["D_Base volume Vb1"].Value))); }
                    catch { }

                    try { tS.EK1_nVm = Convert.ToInt64(Math.Round(Convert.ToSingle(GridViewImportExcel.CurrentRow.Cells["Primary volume V1"].Value))); }
                    catch { }
                    try { tS.EK1_nVmD = Convert.ToInt64(Math.Round(Convert.ToSingle(GridViewImportExcel.CurrentRow.Cells["D_Primary volume V1"].Value))); }
                    catch { }


                    try { tS.EK1_fQb = Convert.ToSingle(GridViewImportExcel.CurrentRow.Cells["Base flow Qb1"].Value); }
                    catch { }
                    try { tS.EK1_fQm = Convert.ToSingle(GridViewImportExcel.CurrentRow.Cells["Flow Q1"].Value); }
                    catch { }
                }
                else
                    if (ComboBoxRan.SelectedItem.ToString() == "2")
                    {
                        try { tS.EK2_fP_Psi = Convert.ToSingle(GridViewImportExcel.CurrentRow.Cells["Pressure p1"].Value) * Convert.ToSingle(14.5); }
                        catch { }

                        try { tS.EK2_fT = Convert.ToSingle(GridViewImportExcel.CurrentRow.Cells["Temperature t1"].Value); }
                        catch { }
                        try { tS.EK2_fC = Convert.ToSingle(GridViewImportExcel.CurrentRow.Cells["Convers. factor C1"].Value); }
                        catch { }

                        try { tS.EK2_nVb = Convert.ToInt64(Math.Round(Convert.ToSingle(GridViewImportExcel.CurrentRow.Cells["Base volume Vb1"].Value))); }
                        catch { }

                        try { tS.EK2_nVbD = Convert.ToInt64(Math.Round(Convert.ToSingle(GridViewImportExcel.CurrentRow.Cells["D_Base volume Vb1"].Value))); }
                        catch { }

                        try { tS.EK2_nVm = Convert.ToInt64(Math.Round(Convert.ToSingle(GridViewImportExcel.CurrentRow.Cells["Primary volume V1"].Value))); }
                        catch { }
                        try { tS.EK2_nVmD = Convert.ToInt64(Math.Round(Convert.ToSingle(GridViewImportExcel.CurrentRow.Cells["D_Primary volume V1"].Value))); }
                        catch { }


                        try { tS.EK2_fQb = Convert.ToSingle(GridViewImportExcel.CurrentRow.Cells["Base flow Qb1"].Value); }
                        catch { }
                        try { tS.EK2_fQm = Convert.ToSingle(GridViewImportExcel.CurrentRow.Cells["Flow Q1"].Value); }
                        catch { }
                    }
                    else
                        if (ComboBoxRan.SelectedItem.ToString() == "3")
                        {
                            try { tS.EK3_fP_Psi = Convert.ToSingle(GridViewImportExcel.CurrentRow.Cells["Pressure p1"].Value) * Convert.ToSingle(14.5); }
                            catch { }

                            try { tS.EK3_fT = Convert.ToSingle(GridViewImportExcel.CurrentRow.Cells["Temperature t1"].Value); }
                            catch { }
                            try { tS.EK3_fC = Convert.ToSingle(GridViewImportExcel.CurrentRow.Cells["Convers. factor C1"].Value); }
                            catch { }

                            try { tS.EK3_nVb = Convert.ToInt64(Math.Round(Convert.ToSingle(GridViewImportExcel.CurrentRow.Cells["Base volume Vb1"].Value))); }
                            catch { }

                            try { tS.EK3_nVbD = Convert.ToInt64(Math.Round(Convert.ToSingle(GridViewImportExcel.CurrentRow.Cells["D_Base volume Vb1"].Value))); }
                            catch { }

                            try { tS.EK3_nVm = Convert.ToInt64(Math.Round(Convert.ToSingle(GridViewImportExcel.CurrentRow.Cells["Primary volume V1"].Value))); }
                            catch { }
                            try { tS.EK3_nVmD = Convert.ToInt64(Math.Round(Convert.ToSingle(GridViewImportExcel.CurrentRow.Cells["D_Primary volume V1"].Value))); }
                            catch { }


                            try { tS.EK3_fQb = Convert.ToSingle(GridViewImportExcel.CurrentRow.Cells["Base flow Qb1"].Value); }
                            catch { }
                            try { tS.EK3_fQm = Convert.ToSingle(GridViewImportExcel.CurrentRow.Cells["Flow Q1"].Value); }
                            catch { }
                        }

                ProgressBarSave.Value += 1;

                //ls.Add(tS);
                new ViewModel.Table_TSample.Table_TSample().InsertUpdateTable_T(tS, ref str);
                if (str != "")
                {
                    GridViewImportExcel.CurrentRow.Table.RowFormatStyle.BackColor = Color.MistyRose;
                    listViewErrore.Items.Add("ردیف " + (i + 1).ToString() + str);
                    listViewErrore.Items[CntCheck].SubItems.Add(i.ToString());
                    CntCheck++;
                }
            }
        }



        private void GridViewImportExcel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)

                if (MSS.Library.Clasess.MSSMessage.MSSMessage_View(0, MSS.Library.Clasess.MSSMessage.MessageType.SWarning, true, "آیا به حذف این ردیف(ها) اطمینان دارید؟"))
                    GridViewImportExcel.SelectedItems.Clear();
        }

        

        private void buttonPatientID_Click(object sender, EventArgs e)
        {
            //if (textBoxPatientID.Text == "")
            //{
            //    MSS.Library.Clasess.MSSMessage.MSSMessage_View(0, MSS.Library.Clasess.MSSMessage.MessageType.SWarning , false, "نام شيت و یا فایل را وارد كنيد");
            //    textBoxPatientID.Focus();
            //    return;
            //}


            System.Windows.Forms.OpenFileDialog op = new System.Windows.Forms.OpenFileDialog();
            op.Filter = "All Files (*.xls;*.xlsx;*.txt;*.AGR)|*.xls;*.xlsx;*.txt;*.AGR";
            if (op.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                LabelAddress.Text = op.FileName;
                if (System.IO.Path.GetExtension(op.FileName) == ".txt")
                    ReadText(op.FileName);
                else if (System.IO.Path.GetExtension(op.FileName) == ".AGR")
                    ReadAGR(op.FileName);
                else
                    ReadExcel(op.FileName, textBoxPatientID.Text);
            }
        }

        private void GasStationImport_Uc_Load(object sender, EventArgs e)
        {
            string str = "";
            ComboTreeGasStation.DataSource = new ViewModel.GasStationClass.GasStationClass().GetList(ref str);
        }

        private void listViewErrore_DoubleClick(object sender, EventArgs e)
        {
            int RF = int.Parse(listViewErrore.SelectedItems[0].SubItems[1].Text);
            GridViewImportExcel.Row = RF;
        }

        
    }
}
