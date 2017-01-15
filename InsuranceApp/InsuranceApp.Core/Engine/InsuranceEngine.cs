using InsuranceApp.Core.Engine.Contracts;
using InsuranceApp.Core.Engine.Factories;

namespace InsuranceApp.Core.Engine
{
	public sealed class InsuranceEngine : IEngine
	{
		private const string EngineStrated = "Insurance engine successfully started!";
        private HumanInsuranceFactory humanFactory;

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
            this.humanFactory = new HumanInsuranceFactory();

            this.logger.Log(EngineStrated);


            var someperson = humanFactory.CreateHumanInsurance();
            this.logger.Log(someperson.FirstName);
        }

    }
}

