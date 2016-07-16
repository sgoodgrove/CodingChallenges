using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Solution
{
	public int ParseRomanNumerals(string input)
	{
		var numeralValues = new Dictionary<char, int>
		{
			{ 'M', 1000 },
			{ 'D', 500 },
			{ 'C', 100 },
			{ 'L', 50 },
			{ 'X', 10 },
			{ 'V', 5},
			{ 'I', 1 }
		};

		Func<char, int> numVal = (n) => numeralValues [n];
		var pairValues = input.Zip (input.Skip (1), (a,b) => new Tuple<int,int>(numVal(a), numVal(b)));
		var values =
			pairValues
				.Select (p => p.Item1 < p.Item2 ? p.Item1 * -1 : p.Item1)
				.Concat (new int[] {numVal(input[input.Length - 1])});

		return values.Sum ();

	}
}
