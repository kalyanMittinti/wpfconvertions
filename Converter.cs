using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
namespace WpfAppProject
{
    public class Converter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            decimal unitPrice = 0;
            decimal unitsinStock = 0;
            unitPrice = (decimal)values[0];
            string Netstock = string.Empty;
             unitPrice = (values[0] != null && values[0] !=DependencyProperty.UnsetValue) ? System.Convert.ToDecimal(values[0]) :0;
             unitsinStock = (values[0] != null && values[1] !=DependencyProperty.UnsetValue) ? System.Convert.ToDecimal(values[1]) :0;
            unitPrice = (values[0] != null) ?
System.Convert.ToDecimal(values[0]) : 0;
            unitsinStock = (values[0] != null) ?
System.Convert.ToDecimal(values[1]) : 0;
            Netstock = System.Convert.ToString(unitPrice * unitsinStock);
            return Netstock;

        }

        public object[] ConvertBack(object value, Type[] targmetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
