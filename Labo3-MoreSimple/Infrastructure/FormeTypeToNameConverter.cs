﻿using System;
using System.Globalization;
using System.Windows.Data;
using Labo3_MoreSimple.ViewModel;

namespace Labo3_MoreSimple.Infrastructure
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
