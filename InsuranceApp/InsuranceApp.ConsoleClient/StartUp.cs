using InsuranceApp.Core.Engine;
using InsuranceApp.Core.Engine.Contracts;
using InsuranceApp.Core.Engine.Models;

namespace InsuranceApp.ConsoleClient
{
    public class StartUp
    {
        public static void Main()
        {
            ILogger logger = ConsoleLogger.Instance();
            ICommandReader reader = ConsoleCommandReader.Instance();
            InsuranceEngine.GetInstance(logger, reader).StartEngine();
        }
    }
}
