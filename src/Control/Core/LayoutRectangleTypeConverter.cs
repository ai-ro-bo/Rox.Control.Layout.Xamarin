using System;
using System.Globalization;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Rox
{
    /// <summary>
    /// Type converter for a LayoutRectangle which represents Fit or Flow rectangle.
    /// </summary>
    [TypeConversion(typeof(LayoutRectangle))]
    public class LayoutRectangleTypeConverter
        : TypeConverter
    {
        #region Convert

        ///<inheritdoc />
        public override object ConvertFromInvariantString(string value)
        {
            if (value != null)
            {
                string[] rectangleArray = value.Split(',');
                if (rectangleArray.Length == 4
                    && double.TryParse(rectangleArray[0], NumberStyles.Number, CultureInfo.InvariantCulture, out double fitPoint)
                    && double.TryParse(rectangleArray[1], NumberStyles.Number, CultureInfo.InvariantCulture, out double flowPoint)
                    && double.TryParse(rectangleArray[2], NumberStyles.Number, CultureInfo.InvariantCulture, out double fitMeasure)
                    && double.TryParse(rectangleArray[3], NumberStyles.Number, CultureInfo.InvariantCulture, out double flowMeasure))
                {
                    return new LayoutRectangle(fitPoint, flowPoint, fitMeasure, flowMeasure);
                }
            }

            throw new InvalidOperationException(string.Format("Cannot convert \"{0}\" into {1}", value, typeof(LayoutRectangle)));
        }

        #endregion
    }
}