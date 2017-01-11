using InsuranceApp.Engine.Contracts;
using InsuranceApp.Engine.Models;


namespace InsuranceApp.Engine
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
