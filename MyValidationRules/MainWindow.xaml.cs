using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MyValidationRules
{
	/// <summary>
	/// MainWindow.xaml 的交互逻辑
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();

			Binding binding = new Binding();
			binding.Source = this.slider;
			binding.Path = new PropertyPath("Value");
			binding.Mode = BindingMode.OneWayToSource;
			binding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;

			RangeValidationRule rvr = new RangeValidationRule();
			rvr.ValidatesOnTargetUpdated = true;
			binding.ValidationRules.Add(rvr);
			binding.NotifyOnValidationError = true;

			this.textBox.SetBinding(TextBox.TextProperty, binding);
			this.textBox.AddHandler(Validation.ErrorEvent, new RoutedEventHandler(this.ValidationError));
		}

		private void ValidationError(object sender, RoutedEventArgs e)
		{
			if (Validation.GetErrors(this.textBox).Count > 0)
			{
				this.textBox.ToolTip = Validation.GetErrors(this.textBox)[0].ErrorContent.ToString();
			}
		}
	}
}
