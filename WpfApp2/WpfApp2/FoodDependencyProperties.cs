using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp2
{
	class FoodDependencyProperty : DependencyObject
	{
		public static readonly DependencyProperty FoodDependency =
			DependencyProperty.Register("MyFavouriteFood",
			typeof(string),
			typeof(FoodDependencyProperty),
			new FrameworkPropertyMetadata("pan pizza"));

		public string MyFood
		{
			get
			{
				return (string)GetValue(FoodDependency);
			}
			set
			{
				SetValue(FoodDependency, value);
			}
		}

	}
}
