using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DownloadCenter
{
	internal class City
	{
		public string Name { get; set; }
	}

	internal class Province
	{
		public string Name { get; set; }
		public List<City> Citys { get; set;}
	}

	internal class Country
	{
		public string Name { get; set; }
		public List<Province> Provinces { get; set; }
	}
}
