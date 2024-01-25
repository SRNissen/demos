using System;
using NUnit.Framework;

namespace warninglist;

public class Tests
{
	public string Empty {get;set;}

	[SetUp]
	public void Setup()
	{
		Empty = "Hello world!";
	}

	[Test]
	public void TestWithoutCategory()
	{
		Assert.Pass(Empty);
	}
}
