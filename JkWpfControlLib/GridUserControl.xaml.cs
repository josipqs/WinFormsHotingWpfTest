using JkWpfControlLib.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace JkWpfControlLib
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class GridUserControl : UserControl
    {
        public GridUserControl()
        {
            InitializeComponent();

            SetData();
        }

        private void SetData()
        {
            #region First grid

            var allCultures = CultureInfo.GetCultures(CultureTypes.SpecificCultures);

            var specificCultures = allCultures.Where(c => !c.IsNeutralCulture).ToList();

            var languages = specificCultures.Select(c => new Language
            {
                Code = c.Name,
                Country = new RegionInfo(c.LCID).DisplayName,
                EnglishName = c.EnglishName,
                LCID = c.LCID,
                NativeName = c.NativeName,
                CalendarType = c.Calendar.AlgorithmType.ToString(),
                CurrencySymbol = c.NumberFormat.CurrencySymbol,
                DayNames = c.DateTimeFormat.DayNames,
                FirstDayOfWeek = c.DateTimeFormat.FirstDayOfWeek,
                IsNeutral = c.IsNeutralCulture,
                IsRightToLeft = c.TextInfo.IsRightToLeft,
                LongDatePattern = c.DateTimeFormat.LongDatePattern,
                LongTimePattern = c.DateTimeFormat.LongTimePattern,
                MonthNames = c.DateTimeFormat.MonthNames,
                ParentLanguageName = c.Parent?.DisplayName
            }).ToList();

            datagrid.ItemsSource = languages.ToList();

            #endregion

            #region Second grid

            //sfdatagrid.Columns.Clear();

            //int i = 0;
            //foreach (var col in results.Columns)
            //{
            //    var colType = col.Type.FromNullable();
            //    var bindName = $"[{i++}]";

            //    var column = (colType == typeof(bool)) ? (GridColumn)new GridCheckBoxColumn() : new GridTextColumn();
            //    column.AllowGrouping = true;
            //    column.HeaderText = col.Name.Replace("_", "__");
            //    column.DisplayBinding = new Binding(bindName) { Mode = BindingMode.OneTime };
            //    column.ValueBinding = new Binding(bindName) { Mode = BindingMode.OneTime };
            //    column.UseBindingValue = true;
            //    sfdatagrid.Columns.Add(column);

            //    if (colType == typeof(double) || colType == typeof(float) || colType == typeof(decimal) || colType == typeof(int) || colType == typeof(long))
            //    {
            //        //column.DisplayBinding.StringFormat = $"{{0:{editorSettings.ResultsGridNumberFormatting}}}";
            //    }
            //}
            
            sfdatagrid.ItemsSource = languages;

            #endregion
        }
    }
}
