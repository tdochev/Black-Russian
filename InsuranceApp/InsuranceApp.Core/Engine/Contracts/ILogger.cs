namespace InsuranceApp.Core.Engine.Contracts
{
	public interface ILogger
	{
		void Log(object message);

        void LogError(object message);
    }
}