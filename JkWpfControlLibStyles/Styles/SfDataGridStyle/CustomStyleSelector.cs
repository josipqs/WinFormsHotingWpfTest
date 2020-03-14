using Syncfusion.UI.Xaml.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace JkWpfControlLibStyles.Styles.SfDataGridStyle
{
    /// <summary>
    /// Style selector class
    /// </summary>
    public class CustomStyleSelector : StyleSelector
    {
        private Style rowStyle = null;
        private Style altRowStyle = null;

        public override Style SelectStyle(object item, DependencyObject container)
        {
            var row = item as DataRowBase;
            if ((row.RowIndex % 2) == 0)
            {
                if (rowStyle == null)
                {
                    // style not found
                    //rowStyle = ((VirtualizingCellsControl)container).FindResource("SfDataGridRowStyle") as Style;

                    // creating style at runtime works
                    rowStyle = new Style(typeof(VirtualizingCellsControl));
                    rowStyle.Setters.Add(new Setter(VirtualizingCellsControl.BackgroundProperty, new BrushConverter().ConvertFrom("#FF072E4B")));
                    rowStyle.Setters.Add(new Setter(VirtualizingCellsControl.ForegroundProperty, new BrushConverter().ConvertFrom("#FFCFD8DF")));
                }
                return rowStyle;
            }
            else
            {
                if (altRowStyle == null)
                {
                    // style not found
                    //altRowStyle = ((VirtualizingCellsControl)container).FindResource("SfDataGridAltRowStyle") as Style;

                    // creating style at runtime works
                    altRowStyle = new Style(typeof(VirtualizingCellsControl));
                    altRowStyle.Setters.Add(new Setter(VirtualizingCellsControl.BackgroundProperty, new BrushConverter().ConvertFrom("#FF0F3F63")));
                    altRowStyle.Setters.Add(new Setter(VirtualizingCellsControl.ForegroundProperty, new BrushConverter().ConvertFrom("#FFCFD8DF")));
                    //Resources.Add(typeof(TextBlock), style);
                }
                return altRowStyle;
            }
        }
    }
}
