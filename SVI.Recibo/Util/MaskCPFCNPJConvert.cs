using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace SVI.Recibo.Util
{
    public class MaskCPFCNPJConvert : IValueConverter
    {
        public object Convert( object value, Type targetType, object parameter, CultureInfo culture )
        {
            string str = ( string )value;
            string formato = "";
            int iCount = 0;

            if( str != null && str.Length == 11 )
            {
                foreach(char c in str)
                {
                    iCount++;
                    
                    switch(iCount)
                    {
                        case 3:
                        case 6:
                            formato += '.';
                            break;

                        case 9:
                            formato += '-';
                            break;
                    }

                    formato += c;
                }

                return formato;
            }
            else if( str != null && str.Length == 14 )
            {
                iCount++;

                switch(iCount)
                {
                    case 2:
                    case 5:
                        formato += '.';
                        break;
                    case 8:
                        formato += '/';
                        break;
                    case 12:
                        formato += '-';
                        break;
                }

                return formato;
            }
            else
                return value;
        }

        public object ConvertBack( object value, Type targetType, object parameter, CultureInfo culture )
        {
            throw new NotImplementedException();
        }
    }
}
