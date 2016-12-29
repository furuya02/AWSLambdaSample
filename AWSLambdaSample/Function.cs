using Amazon.Lambda.Core;

[assembly: LambdaSerializerAttribute(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]
namespace AWSLambdaSample
{
	public class Function
	{
		public string FunctionHandler(SampleData sampleData, ILambdaContext context)
		{
			context.Logger.LogLine(sampleData.ToString());
			return sampleData.ToString();
		}
	}

	public class SampleData
	{
		public string Key1 { get; set; }
		public string Key2 { get; set; }
		public string Key3 { get; set; }
		override public string ToString()
		{
			return $"Key1={Key1}, Key2={Key2}, Key3={Key3}";
		}
	}
}