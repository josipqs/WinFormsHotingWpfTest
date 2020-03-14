using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JkWpfControlLib.Model
{
    public class Language //: DataRow
    {
        public string Code { get; set; }
        public string NativeName { get; set; }
        public string EnglishName { get; set; }
        public int LCID { get; set; }
        public string Country { get; set; }
        public bool IsNeutral { get; set; }
        public string CalendarType { get; set; }
        //public bool IsLeapYear { get; set; }
        public string[] MonthNames { get; set; }
        public DayOfWeek FirstDayOfWeek { get; set; }
        public string[] DayNames { get; set; }
        public string LongDatePattern { get; set; }
        public string LongTimePattern { get; set; }
        public string CurrencySymbol { get; set; }
        public bool IsRightToLeft { get; set; }
        public string ParentLanguageName { get; set; }
    }
}
