using System;
using System.Diagnostics;
using System.Globalization;
using Fassetto.Mine.Models;
using Fassetto.Mine.Pages;

namespace Fassetto.Mine.ValueConverters
{
    internal class ApplicationPageConverter: BaseValueConverter<ApplicationPageConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch ((ApplicationPage)value)
            {
                case ApplicationPage.Login:
                    return new LoginPage();

                default: 
                    Debugger.Break();
                    return null;
            }
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
