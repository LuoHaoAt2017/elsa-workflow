using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace MyValueConverter
{
	internal class CategoryToSourceConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			Category category = (Category)value;
			switch (category)
			{
				case Category.Bomber:
					return @"\Icons\Bomber.png";
				case Category.Fighter:
					return @"\Icons\Fighter.png";
				default:
					return null;
			}
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
