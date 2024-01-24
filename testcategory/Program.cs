using System;
using NUnit.Framework;

namespace testcategory;

public class Tests
{
	[SetUp]
	public void Setup()
	{
		Console.WriteLine("Setup");
	}

	[Test]
	public void TestWithoutCategory()
	{
		Console.WriteLine("TestWithoutCategory");
		Assert.Pass();
	}
	
	[Test]
	[Category("integration")]
	public void TestCategoryA()
	{
		Console.WriteLine("TestCategoryA");
		Assert.Pass();
	}
	
	[Test]
	[TestCategory("Unit")]
	public void TestCategoryB()
	{
		Console.WriteLine("TestCategoryB");
		Assert.Pass();
	}
}
