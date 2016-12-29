using System;
using Amazon.Lambda.TestUtilities;
using AWSLambdaSample;

class Program
{
	static void Main(string[] args)
	{
		// setup
		var sut = new Function();
		var expected = "Key1=value1, Key2=value2, Key3=value3";
		var sampleData = new SampleData() { Key1 = "value1", Key2 = "value2", Key3 = "value3" };

		//exercise
		var acture = sut.FunctionHandler(sampleData, new TestLambdaContext());

		//veryfy
		Assert.That(acture, expected);

		//tearDown
	}

	class Assert
	{
		static public void That(string acture, string expected)
		{
			if (acture == expected)
			{
				Console.WriteLine($"success");
			}
			else
			{
				Console.WriteLine($"error {acture}!={expected}");
			}
		}
	}
}