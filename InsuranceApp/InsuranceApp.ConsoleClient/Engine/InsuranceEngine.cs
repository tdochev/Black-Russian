using InsuranceApp.ConsoleClient.Engine.Contracts;
using InsuranceApp.ConsoleClient.Engine.Models;


namespace InsuranceApp.ConsoleClient.Engine
{
	public sealed class InsuranceEngine
	{

		//TODO: Implement Singleton for the engine
		//TODO: Define Interface for the Engine

		private readonly ILogger logger;

		private InsuranceEngine()
		{
			this.logger = ConsoleLogger.Instance();
		}
	}
}
