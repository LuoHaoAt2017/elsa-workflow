using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace MyDataTemplate
{
	internal class MyDataTemplateSelector: DataTemplateSelector
	{
		public override DataTemplate SelectTemplate(object item, DependencyObject container)
		{
			DataTemplate template = base.SelectTemplate(item, container);

			if (item is Student)
			{
				if (container is FrameworkElement fe)
				{
					template = fe.FindResource("StudentTemplate") as DataTemplate;
				}
					
			}
			else if (item is Company)
			{
				if (container is FrameworkElement fe)
				{
					template = fe.FindResource("CompanyTemplate") as DataTemplate;
				}
			}
			return template;
		}
	}
}
