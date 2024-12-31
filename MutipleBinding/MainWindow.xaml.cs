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

namespace MutipleBinding
{
	/// <summary>
	/// MainWindow.xaml 的交互逻辑
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();

			Binding binding1 = new Binding("Text") { Source = this.textBox1 };
			Binding binding2 = new Binding("Text") { Source = this.textBox2 };
			Binding binding3 = new Binding("Text") { Source = this.textBox3 };
			Binding binding4 = new Binding("Text") { Source = this.textBox4 };

			MultiBinding multiBinding = new MultiBinding() { Mode = BindingMode.OneWay };
			multiBinding.Bindings.Add(binding1);
			multiBinding.Bindings.Add(binding2);
			multiBinding.Bindings.Add(binding3);
			multiBinding.Bindings.Add(binding4);

			multiBinding.Converter = new EnableRegisterConverter();
			this.button1.SetBinding(IsEnabledProperty, multiBinding);
		}
	}
}
