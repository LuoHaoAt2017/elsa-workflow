using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DownloadCenter
{
	internal class Student: INotifyPropertyChanged
	{
		private string name;

		private int age;

		public string Name 
		{ 
			get { return name; } 
			set 
			{ 
				name = value; 
				if (this.PropertyChanged != null)
				{
					// Name 属性值发生改变时，通知数据关联的目标方向的UI元素
					this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Name"));
				}
			}
		}

		public int Age
		{
			get { return age; }
			set 
			{ 
				age = value; 
				if (this.PropertyChanged != null)
				{
					this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Age"));
				}
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;
	}
}
