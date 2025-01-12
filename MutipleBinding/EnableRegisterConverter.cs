﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace MutipleBinding
{
	internal class EnableRegisterConverter : IMultiValueConverter
	{
		public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
		{
			if (values.Cast<string>().Any(text => string.IsNullOrEmpty(text)))
			{
				return false;
			}
			if (!values[0].ToString().Equals(values[1].ToString()))
			{
				return false;
			}
			if (!values[2].ToString().Equals(values[3].ToString()))
			{
				return false;
			}
			return true;
		}

		public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
