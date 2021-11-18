using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Comida
{
    public class TypeToFont : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            String fontName = "";
            switch(value.ToString().ToLower())
            {
                case "americana":
                    fontName = "Slim Summer";
                    break;
                case "china":
                    fontName = "Chinese Wok Food St";
                    break;
                case "mexicana":
                    fontName = "Taco Salad";
                    break;
            }

            return fontName;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            String type = "";
            switch (value.ToString().ToLower())
            {
                case "slim summer":
                    type = "americana";
                    break;
                case "chinese wok food st":
                    type = "china";
                    break;
                case "taco salad":
                    type = "mexicana";
                    break;
            }

            return type;
        }
    }
}
