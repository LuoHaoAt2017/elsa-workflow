using System;
using System.Collections.Generic;
using System.IO;
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

namespace MyValueConverter
{
	/// <summary>
	/// MainWindow.xaml 的交互逻辑
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void buttonLoad_Click(object sender, RoutedEventArgs e)
		{
			List<Plane> planes = new List<Plane>()
			{
				new Plane() { Category = Category.Bomber, Name = "B-22", State = State.Available },
				new Plane() { Category = Category.Bomber, Name = "B-22", State = State.Locked },
				new Plane() { Category = Category.Bomber, Name = "B-22", State = State.Unknown },
				new Plane() { Category = Category.Fighter, Name = "F-22", State = State.Available },
				new Plane() { Category = Category.Fighter, Name = "F-22", State = State.Locked },
				new Plane() { Category = Category.Fighter, Name = "F-22", State = State.Unknown },
			};
			this.listBoxPlane.ItemsSource = planes;
		}

		private void buttonSave_Click(object sender, RoutedEventArgs e)
		{
			StringBuilder sb = new StringBuilder();
			foreach(Plane item in this.listBoxPlane.Items)
			{
				sb.AppendLine(string.Format(@"Category={0}, Name={1}, State={2}", item.Category, item.Name, item.State));
			}
			File.WriteAllText(@"D:\plane.txt", sb.ToString());
		}
	}

	public enum Category
	{
		Bomber,
		Fighter,
	}

	public enum State
	{
		Available,
		Locked,
		Unknown,
	}

	public class Plane
	{
		public Category Category { get; set; }

		public String Name { get; set; }

		public State State { get; set; }
	}
}
