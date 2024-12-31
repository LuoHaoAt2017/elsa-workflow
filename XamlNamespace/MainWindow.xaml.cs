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

namespace XamlNamespace
{
	/// <summary>
	/// MainWindow.xaml 的交互逻辑
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();

			this.textBox1.Text = this.FindResource("greeting") as string;
		}

		private void Button1_Click(object sender, RoutedEventArgs e)
		{
			this.button1.Content = this.FindResource("greeting") as string;
		}

		private void button2_Click(object sender, RoutedEventArgs e)
		{
			this.rectangle.Fill = new SolidColorBrush()
			{
				Color = Colors.OrangeRed
			};
		}

		private void button3_Click(object sender, RoutedEventArgs e)
		{
			Human human = this.FindResource("human") as Human;
			MessageBox.Show(human.Child.Name);
		}
	}
}
