﻿using System;
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

namespace MyDataTemplate
{
	/// <summary>
	/// MainWindow.xaml 的交互逻辑
	/// </summary>
	public partial class MainWindow : Window
	{
		private List<object> _objectList;

		public List<Object> ObjectList
		{
			get
			{
				return this._objectList;
			}
			set
			{
				this._objectList = value;
			}
		}

		public MainWindow()
		{
			InitializeComponent();

			List<object> list1 = new List<object>()
			{
				new Student() { Id = 1, Name = "AAA", Age = 20 },
				new Student() { Id = 2, Name = "BBB", Age = 30 },
				new Student() { Id = 3, Name = "CCC", Age = 40 },
				new Company() { CompanyName = "MS", Industry = "IT" },
				new Company() { CompanyName = "IBM", Industry = "IT" },
			};
			this.ObjectList = list1;

			this.DataContext = this;
		}
	}
}
