using System;


namespace MSS.Library.Clasess.Date
{
    public class DateConvertor
    {

        #region Date Convertor & Control
        static public string MiladiDateToShamsi(DateTime MiladiDate)
        {
            try
            {
                if (MiladiDate == null) return "0000/00/00";
                System.Globalization.PersianCalendar farsi = new System.Globalization.PersianCalendar();
                int dd, mm, yy;
                string Ret;

                yy = farsi.GetYear(MiladiDate);
                Ret = yy.ToString() + "/";
                mm = farsi.GetMonth(MiladiDate);
                if (mm < 10) Ret = Ret + "0" + mm.ToString() + "/";
                else Ret = Ret + mm.ToString() + "/";
                dd = farsi.GetDayOfMonth(MiladiDate);
                if (dd < 10) Ret = Ret + "0" + dd.ToString();
                else Ret = Ret + dd.ToString();

                return Ret;
            }
            catch 
            {
                return "";
            }

        }

        static public string MiladiDateToShamsiWithTime(DateTime MiladiDate)
        {
            try
            {
                if (MiladiDate == null) return "0000/00/00";
                System.Globalization.PersianCalendar farsi = new System.Globalization.PersianCalendar();
                int dd, mm, yy;
                string Ret;

                yy = farsi.GetYear(MiladiDate);
                Ret = yy.ToString() + "/";
                mm = farsi.GetMonth(MiladiDate);
                if (mm < 10) Ret = Ret + "0" + mm.ToString() + "/";
                else Ret = Ret + mm.ToString() + "/";
                dd = farsi.GetDayOfMonth(MiladiDate);
                if (dd < 10) Ret = Ret + "0" + dd.ToString();
                else Ret = Ret + dd.ToString();

                Ret += " " + farsi.GetHour(MiladiDate) + ":" + farsi.GetMinute(MiladiDate);
                return Ret;
            }
            catch
            {
                return "";
            }

        }

        static public DateTime ShamsiDateToMiladiWithTime(string DateString, string year, string month, string dy, int Hour, int Minute, int Second)
        {

            if (DateString == "" && year == "" && month == "" && dy == "")
                return DateTime.MinValue;

            short yy, mm, dd;

            if (DateString != "")
            {
                yy = Convert.ToInt16(DateString.Substring(0, 4));
                mm = Convert.ToInt16(DateString.Substring(5, 2));
                dd = Convert.ToInt16(DateString.Substring(8, 2));
            }
            else
            {
                yy = Convert.ToInt16(year);
                mm = Convert.ToInt16(month);
                dd = Convert.ToInt16(dy);
            }

            DateTime MiladiDate;
            System.Globalization.PersianCalendar farsi = new System.Globalization.PersianCalendar();
            MiladiDate = farsi.ToDateTime(yy, mm, dd, Hour, Minute, Second, 0);

            return MiladiDate;
        }
        static public DateTime ShamsiDateToMiladi(string DateString, string year, string month, string dy)
        {

            if (DateString == "" && year == "" && month == "" && dy == "")
                return DateTime.MinValue;

            short yy, mm, dd;

            if (DateString != "")
            {
                yy = Convert.ToInt16(DateString.Substring(0, 4));
                mm = Convert.ToInt16(DateString.Substring(5, 2));
                dd = Convert.ToInt16(DateString.Substring(8, 2));
            }
            else
            {
                yy = Convert.ToInt16(year);
                mm = Convert.ToInt16(month);
                dd = Convert.ToInt16(dy);
            }

            DateTime MiladiDate;
            System.Globalization.PersianCalendar farsi = new System.Globalization.PersianCalendar();
            MiladiDate = farsi.ToDateTime(yy, mm, dd, 12, 0, 0, 0);

            return MiladiDate;


           
        }
        static public DateTime ShamsiDateToMiladi(string DateString) { return ShamsiDateToMiladi(DateString, "", "", ""); }

        static public DateTime ShamsiDateToMiladi(string year, string mnth, string dy) { return ShamsiDateToMiladi("", year, mnth, dy); }

        static public bool CheckShamsiDate(string DateString)
        {
            int y, m, d;
            try
            {
                y = Convert.ToInt32(DateString.Substring(0, 4));
                m = Convert.ToInt32(DateString.Substring(5, 2));
                d = Convert.ToInt32(DateString.Substring(8, 2));
            }
            catch
            { return false; }

            if ((y < 1300 | y > 1420) | ((y % 4 != 3) & (m == 12) & (d == 30))
                | ((m >= 7) & (d == 31)) | (m > 12) | (d > 31) | (m == 0) | (d == 0))
                return false;
            return true;
        }
        #endregion

    }

}
