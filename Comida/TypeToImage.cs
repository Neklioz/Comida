using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Comida
{

    public class TypeToImage : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            String imageName = "";
            switch(value.ToString().ToLower())
            {
                case "americana":
                    imageName = "united_states";
                    break;
                case "china":
                    imageName = "china";
                    break;
                case "mexicana":
                    imageName = "mexico";
                    break;
            }

            return "./Assets/" + imageName + ".png";
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            String type = "";
            switch (value.ToString().ToLower())
            {
                case "united_states":
                    type = "americana";
                    break;
                case "china":
                    type = "china";
                    break;
                case "mexico":
                    type = "mexicana";
                    break;
            }

            return type;
        }
    }
}
