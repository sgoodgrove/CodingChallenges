using System;
using System.Collections.Generic;

using NUnit.Framework;

[TestFixture]
public class SolutionTests
{
	[Test]
	public void Test1()
	{
		var solution = new Solution ();

		Assert.That (solution.ParseRomanNumerals ("I"), Is.EqualTo (1));
	}

	[Test]
	public void Test1961()
	{
		var solution = new Solution();

		Assert.That(solution.ParseRomanNumerals("MCMLXI"), Is.EqualTo(1961));
	}

	[Test]
	public void Test1999()
	{
		var solution = new Solution();

		Assert.That(solution.ParseRomanNumerals("MCMXCIX"), Is.EqualTo(1999));
	}

	[Test]
	public void Test2016()
	{
		var solution = new Solution();

		Assert.That(solution.ParseRomanNumerals("MMXVI"), Is.EqualTo(2016));
	}
}
