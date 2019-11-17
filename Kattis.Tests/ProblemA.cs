using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace Kattis.Tests
{
	public class ProblemA
	{
		[Theory]
		[InlineData("bob")]
		[InlineData("booob")]
		public void GivenName_WhenContainsRepetitiveLetters_ThenOutputReturns_bob(string name)
		{
			const string expected = "bob";
			var actual = GetName(name);
			Assert.Equal(expected, actual);
		}

		[Theory]
		[InlineData("boooooobapalaxxxxios")]
		public void GivenName_WhenContainsRepetitiveLetters_ThenoutputReturns_bobapalaxios(string name)
		{
			const string expected = "bobapalaxios";
			var actual = GetName(name);
			Assert.Equal(expected, actual);
		}

		private static string GetName(string name)
		{
			var set = name.ToCharArray();
			var addedChars = new char[name.Length];
			var cleansedName = new List<char>(name.Length);
			var firstChar = set.First();
			var sb = new StringBuilder();

			addedChars[0] = firstChar;
			cleansedName.Add(firstChar);
			sb.Append(firstChar);
			for (var i = 0; i < set.Length; i++)
			{
				if (cleansedName.Last() == set[i])
				{
					continue;
				}
				cleansedName.Add(name[i]);
				sb.Append(set[i]);
			}

			return sb.ToString();
		}
	}
}
