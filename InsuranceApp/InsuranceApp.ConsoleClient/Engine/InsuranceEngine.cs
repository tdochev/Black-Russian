using InsuranceApp.ConsoleClient.Engine.Contracts;
using InsuranceApp.ConsoleClient.Engine.Models;

namespace InsuranceApp.ConsoleClient.Engine
{
	public sealed class InsuranceEngine
	{
		private const string EngineStrated = "Insurance engine successfully started!";

		//TODO: Define Interface for the Engine

		private static readonly InsuranceEngine SingleInstance = new InsuranceEngine();

		private readonly ILogger logger;

		private InsuranceEngine()
		{
			this.logger = ConsoleLogger.Instance();
		}

		public static InsuranceEngine Instance
		{
			get
			{
				return SingleInstance;
			}
		}

		public void StartEngine()
		{
			this.logger.Log(EngineStrated);
		}
	}
}

