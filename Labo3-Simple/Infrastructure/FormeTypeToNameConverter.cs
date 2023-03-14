using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using Labo3_Simple.ViewModel;

namespace Labo3_Simple.Infrastructure
{
    public class FormeTypeToNameConverter : IValueConverter 
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch (value)
            {
                case CarreWrapper:
                    return "CARRE";
                case RectangleWrapper:
                    return "RECTANGLE";
                case CercleWrapper:
                    return "CERCLE";
            }

            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
