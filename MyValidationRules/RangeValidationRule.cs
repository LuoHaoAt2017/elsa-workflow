using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MyValidationRules
{
	internal class RangeValidationRule : ValidationRule
	{
		public override ValidationResult Validate(object value, CultureInfo cultureInfo)
		{
			double d = 0;
			if (double.TryParse(value.ToString(), out d))
			{
				if (d >= 0 && d <= 100)
				{
					return new ValidationResult(true, null);
				}
				else
				{
					return new ValidationResult(false, "不在有效范围内"); // 如何将校验异常信息显示出来
				}
			}
			return new ValidationResult(false, "只接受数值类型");
		}
	}
}
