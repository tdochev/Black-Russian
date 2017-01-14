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
            InsuranceEngine.GetInstance(logger).StartEngine();
        }
    }
}
