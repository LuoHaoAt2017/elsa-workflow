using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamlNamespace
{
	internal class StringToHumanTypeConverter: TypeConverter
	{
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			if (value is string)
			{
				Human human = new Human();
				human.Name = (string)value;
				return human;
			}
			return base.ConvertFrom(context, culture, value);
		}
	}
}
