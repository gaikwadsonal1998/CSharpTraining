using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDemoMam
{
	class DaysOfTheWeek : IEnumerable<string>
	{
		string[] week = { "sunday", "Monday", "Tuesday", "Wednesday", "Thurday", "Friday", "Saturday" };

		public IEnumerator<string> GetEnumerator()
		{
			for (int i = 0; i < week.Length; i++)
			{
				yield return week[i];
			}
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			throw new NotImplementedException();
		}
	}
}
