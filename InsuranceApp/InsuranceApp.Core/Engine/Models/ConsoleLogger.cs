using System;

using InsuranceApp.Core.Engine.Contracts;

namespace InsuranceApp.Core.Engine.Models
{
	public sealed class ConsoleLogger : ILogger
	{
		private static readonly ConsoleLogger instance = new ConsoleLogger();

		public void Log(object message)
		{
			Console.WriteLine(message);
		}

		private ConsoleLogger() 
		{ 
		}

		public static ConsoleLogger Instance()
		{
			return instance;
		}
	}
}
