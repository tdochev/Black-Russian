using InsuranceApp.Core.Engine.Contracts;

namespace InsuranceApp.Core.Engine
{
	public sealed class InsuranceEngine : IEngine
	{
		private const string EngineStrated = "Insurance engine successfully started!";

        //TODO: Define Interface for the Engine

        private static IEngine SingleInstance;

		private readonly ILogger logger;

		private InsuranceEngine(ILogger logger)
		{
			this.logger = logger;
		}

		public static IEngine GetInstance(ILogger logger)
		{
            SingleInstance = new InsuranceEngine(logger);
            return SingleInstance;
		}
        public void StartEngine()
        {
            this.logger.Log(EngineStrated);
        }

    }
}

