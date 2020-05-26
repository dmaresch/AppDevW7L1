using System;
using System.Collections.Generic;
using System.Text;

namespace AppDevW7L1
{
	public class UserFactData
	{
		public UserFactData() { }
		public static IEnumerable<UserFactData> All { private set; get; }
		public string TheFact { get; set; }
		public string ShortFact { get; set; }

		static UserFactData()
		{
			List<UserFactData> all = new List<UserFactData>();
			all.Add(new UserFactData() { TheFact = "I absolutely hate javascript and I would much rather spend my time tinkering with Flask in Python instead of Node.", ShortFact = "JScript" });
			all.Add(new UserFactData() { TheFact = "The first programming language I learned was Visual Basic Forms. Later that year I taught myself C# and Python.", ShortFact = "History" });
			all.Add(new UserFactData() { TheFact = "I used to be an honors choir student. I quit doing all of that to go into IT as I stopped enjoying music.", ShortFact = "Music" });
			all.Add(new UserFactData() { TheFact = "I've finished in the top 100 for the National Cyber League 3 seasons total now.", ShortFact = "NCL" });
			all.Add(new UserFactData() { TheFact = "Back when Beat Saber was in its early modding days, I was in the top 100 players.", ShortFact = "VR" });
			All = all;
		}
	}
}
