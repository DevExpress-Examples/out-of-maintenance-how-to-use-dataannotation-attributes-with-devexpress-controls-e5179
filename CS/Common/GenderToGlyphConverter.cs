using DataAnnotationAttributes.Model;
using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace DataAnnotationAttributes.Common {
    public class GenderToGlyphConverter : IValueConverter {
        public ImageSource MaleGlyph { get; set; }
        public ImageSource FemaleGlyph { get; set; }
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
            Gender? gender = value as Gender?;
            if(gender == null)
                gender = parameter as Gender?;
            if(gender == null)
                return null;
            return gender == Gender.Female ? FemaleGlyph : MaleGlyph;
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
            throw new NotImplementedException();
        }
    }
}
