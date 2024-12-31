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

namespace RelativeResource
{
	/// <summary>
	/// MainWindow.xaml 的交互逻辑
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		    RelativeSource rs = new RelativeSource();
			rs.Mode = RelativeSourceMode.FindAncestor;
			rs.AncestorLevel = 2;
			rs.AncestorType = typeof(Grid);
			Binding binding = new Binding("Name")
			{
				RelativeSource = rs,
			};
			this.textBox.SetBinding(TextBox.TextProperty, binding);
		}
	}
}
