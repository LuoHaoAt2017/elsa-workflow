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

namespace DownloadCenter
{
	/// <summary>
	/// MainWindow.xaml 的交互逻辑
	/// </summary>
	public partial class MainWindow : Window
	{
		private Student student;
		private List<string> stringList;
		List<Country> countrieList;

		public MainWindow()
		{
			InitializeComponent();
			stringList = new List<string>() { "Tim", "Tom", "Blog" };
			this.textBoxName2.SetBinding(TextBox.TextProperty, new Binding("/") { Source = stringList, Mode = BindingMode.OneWay });
			this.textBoxName3.SetBinding(TextBox.TextProperty, new Binding("/Length") { Source = stringList, Mode = BindingMode.OneWay });
			this.textBoxName4.SetBinding(TextBox.TextProperty, new Binding("/[2]") { Source = stringList, Mode = BindingMode.OneWay });

			countrieList = new List<Country>()
			{
				new Country() { Name = "日本",  Provinces = new List<Province>() {
					new Province() { Name = "大阪府", Citys = new List<City>() {
						new City() { Name = "奈良市"}
					}}
				}}
			};
			this.textBoxName5.SetBinding(TextBox.TextProperty, new Binding("/Name") { Source = countrieList });
			this.textBoxName6.SetBinding(TextBox.TextProperty, new Binding("/Provinces/Name") { Source = countrieList });
			this.textBoxName7.SetBinding(TextBox.TextProperty, new Binding("/Provinces/Citys/Name") { Source = countrieList });

			student = new Student();
			// Binding
			Binding binding = new Binding();
			binding.Source = student;
			binding.Path = new PropertyPath("Name");
			BindingOperations.SetBinding(this.studentBox, TextBox.TextProperty, binding);

			this.textBoxName.SetBinding(TextBox.TextProperty, new Binding()
			{
				Source = this.slider,
				Path = new PropertyPath("Value"),
				Mode = BindingMode.TwoWay, // 控制数据流动的方向
				UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged, // 控制更新的时机
			});
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			student.Name += "Name";
		}
	}
}
