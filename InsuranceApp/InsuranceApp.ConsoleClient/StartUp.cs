
using InsuranceApp.ConsoleClient.Engine;

namespace InsuranceApp.ConsoleClient
{
    public class StartUp
    {
        public static void Main()
        {
            InsuranceEngine.Instance.StartEngine();
        }
    }
}
