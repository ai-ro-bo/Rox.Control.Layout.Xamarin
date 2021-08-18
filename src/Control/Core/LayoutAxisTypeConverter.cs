using System;
using System.Globalization;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Rox
{
    /// <summary>
    /// Type converter for a LayoutAxis which represents either a X or Y axis.
    /// </summary>
    [TypeConversion(typeof(LayoutAxis))]
    public class LayoutAxisTypeConverter
        : TypeConverter
    {
        #region Convert

        ///<inheritdoc />
        public override object ConvertFromInvariantString(string value)
        {
            if (value != null)
            {
                string[] axisArray = value.Split(',');
                if (axisArray.Length == 2 &&
                    double.TryParse(axisArray[0], NumberStyles.Number, CultureInfo.InvariantCulture, out double point) &&
                    double.TryParse(axisArray[1], NumberStyles.Number, CultureInfo.InvariantCulture, out double measure))
                {
                    return new LayoutAxis(point, measure);
                }
            }

            throw new InvalidOperationException(string.Format("Cannot convert \"{0}\" into {1}", value, typeof(LayoutAxis)));
        }

        #endregion
    }
}