using InsuranceApp.ConsoleClient.Engine.Contracts;
using InsuranceApp.ConsoleClient.Engine.Models;

namespace InsuranceApp.ConsoleClient.Engine
{
	public sealed class InsuranceEngine : IEngine
	{
		private const string EngineStrated = "Insurance engine successfully started!";

		//TODO: Define Interface for the Engine

		private static readonly IEngine SingleInstance = new InsuranceEngine();

		private readonly ILogger logger;

		private InsuranceEngine()
		{
			this.logger = ConsoleLogger.Instance();
		}

		public static IEngine Instance
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

