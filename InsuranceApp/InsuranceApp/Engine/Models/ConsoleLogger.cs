using System;

using InsuranceApp.Engine.Contracts;

namespace InsuranceApp.Engine.Models
{
	public class ConsoleLogger : ILogger
	{
		public void Log(object message)
		{
			Console.WriteLine(message);
		}
	}
}
