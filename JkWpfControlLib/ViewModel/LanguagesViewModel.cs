using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JkWpfControlLib.Model;

namespace JkWpfControlLib.ViewModel
{
    public class LanguagesViewModel
    {
        private ObservableCollection<Language> _languages;
        public ObservableCollection<Language> Languages
        {
            get { return _languages; }
            set { _languages = value; }
        }

        public LanguagesViewModel()
        {
            _languages = new ObservableCollection<Language>();

            this.GetLanguagess();
        }

        private void GetLanguagess()
        {
            var allCultures = CultureInfo.GetCultures(CultureTypes.AllCultures);

            var neutralCultures = allCultures.Where(c => c.IsNeutralCulture).ToList();

            foreach (var c in neutralCultures)
            {
                _languages.Add(new Language
                {
                    Code = c.Name,
                    Country = "Unknown",
                    EnglishName = c.EnglishName,
                    LCID = c.LCID,
                    NativeName = c.NativeName,
                    IsNeutral = c.IsNeutralCulture,
                    CalendarType = c.Calendar.AlgorithmType.ToString(),
                    //IsLeapYear = c.Calendar.IsLeapYear(DateTime.Now.Year),
                    CurrencySymbol = c.NumberFormat.CurrencySymbol,
                    MonthNames = c.DateTimeFormat.MonthNames,
                    FirstDayOfWeek = c.DateTimeFormat.FirstDayOfWeek,
                    DayNames = c.DateTimeFormat.DayNames,
                    LongDatePattern = c.DateTimeFormat.LongDatePattern,
                    LongTimePattern = c.DateTimeFormat.LongTimePattern,
                    IsRightToLeft = c.TextInfo.IsRightToLeft,
                    ParentLanguageName = c.Parent.EnglishName
                });
            }

        }
    }
}
