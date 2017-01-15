using System;
using System.Collections.Generic;

using InsuranceApp.Core.Engine.Contracts;
using InsuranceApp.Core.Engine.Factories;
using InsuranceApp.Core.Contracts;
using System.Linq;
using InsuranceApp.InsuranceContract;

namespace InsuranceApp.Core.Engine
{
    public sealed class InsuranceEngine : IEngine
    {
        private const string EngineStrated = "Insurance engine successfully started!";
        private const string InvalidCommand = "Invalid command!";

        private HumanInsuranceFactory humanFactory;
        private ContractFactory contractFactory;

        private static IEngine SingleInstance;

        private readonly ILogger logger;
        private readonly ICommandReader reader;

        private IList<IPerson> persons;

        private InsuranceEngine(ILogger logger, ICommandReader commandReader)
        {
            this.logger = logger;
            this.reader = commandReader;
        }

        public static IEngine GetInstance(ILogger logger, ICommandReader commandReader)
        {
            SingleInstance = new InsuranceEngine(logger, commandReader);
            return SingleInstance;
        }
        public void StartEngine()
        {
            //implmement interfaces
            this.humanFactory = new HumanInsuranceFactory();
            this.contractFactory = new ContractFactory();

            this.persons = new List<IPerson>();

            this.logger.Log(EngineStrated);

            while (true)
            {
                string command = this.reader.ReadCommand();

                if (command == "exit")
                {
                    return;
                }

                this.ProccessCommand(command);
            }
        }

        private void ProccessCommand(string command)
        {
            var splittedCommand = command.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            var commandType = splittedCommand[0].ToLower();

            switch (commandType)
            {
                //TODO: move case contents to methods
                case "create":
                    this.CreateObject(splittedCommand[1].ToLower());
                    break;
                case "list":
                    this.ListObject(splittedCommand[1].ToLower());
                    break;
                case "insure":
                    var userId = splittedCommand[1];
                    var currentUser = this.persons.FirstOrDefault(x => x.PersonalID == userId);
                    decimal amount = 0m;
                    try
                    {
                        amount = decimal.Parse(splittedCommand[3]);
                    }
                    catch (Exception)
                    {
                        this.logger.Log("Invalid contract amount!");
                    }
                    this.CreateContract(currentUser, splittedCommand[2], amount);
                    break; 
                default:
                    this.logger.Log(InsuranceEngine.InvalidCommand);
                    break;
            }
        }

        private void CreateObject(string objectType)
        {
            switch (objectType.ToLower())
            {
                case "person":
                    var createdPerson = this.humanFactory.CreateHumanInsurance();
                    this.persons.Add(createdPerson);
                    this.logger.Log(string.Format("Person {0} with id {1} successfully created!", createdPerson.FirstName, createdPerson.PersonalID));
                    break;
                default:
                    this.logger.Log(InsuranceEngine.InvalidCommand);
                    break;
            }
        }

        private void CreateContract(IPerson owner, string assetType, decimal amount)
        {
            switch (assetType.ToLower())
            {
                case "property":
                    var contract = this.contractFactory.CreatePropertyContract(owner,amount);

                    this.logger.Log(string.Format("{0} successfully insured property at {1} for {2}.", owner.FirstName, owner.Address, amount));
                    break;
                default:
                    this.logger.Log(InsuranceEngine.InvalidCommand);
                    break;
            }
        }

        private void ListObject(string objectType)
        {
            switch (objectType.ToLower())
            {
                case "persons":
                    this.logger.Log("Listing persons:");
                    foreach (var person in this.persons)
                    {
                        this.logger.Log(string.Format("{0} {1} {2}, id - {3}", person.FirstName, person.MiddleName, person.LastName, person.PersonalID));
                    }
                    this.logger.Log("----End of list----");
                    break;
                default:
                    this.logger.Log(InsuranceEngine.InvalidCommand);
                    break;
            }
        }
    }
}

