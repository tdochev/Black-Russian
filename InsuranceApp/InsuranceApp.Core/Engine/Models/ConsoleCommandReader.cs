using System;
using InsuranceApp.Core.Engine.Contracts;

namespace InsuranceApp.Core.Engine.Models
{
    public sealed class ConsoleCommandReader : ICommandReader
    {
        private static readonly ConsoleCommandReader instance = new ConsoleCommandReader();

        private ConsoleCommandReader()
        {
        }

        public static ConsoleCommandReader Instance()
        {
            return instance;
        }

        public string ReadCommand()
        {
           return Console.ReadLine();
        }
    }
}
