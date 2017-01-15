using InsuranceApp.Core.Contracts;
using InsuranceApp.Core.Objects.HumanEntities;
using System;

namespace InsuranceApp.Core.Engine.Factories
{
    public class HumanInsuranceFactory
    {

        private string[] names =
            {
            "Pesho Ivanov Petrov",
            "Gosho Petrov Dimitrov",
            "Genka Slavcheva Ivanova"
        };
        private readonly string[] addresses =
            {
            "Ul. Niama Znachenie 23"
        };

        private readonly string[] phonenumbers = 
            {
            "0888888888",
            "0888123456"
        };
        private readonly string[] personalIDs =
            {
             "8010207889"
        };


        public IPerson CreateHumanInsurance()
        {

            var randomFullName = this.GetRandomValueFromArray(this.names);
            var firstName = randomFullName.Split(' ')[0];
            var middleName = randomFullName.Split(' ')[1];
            var lastName = randomFullName.Split(' ')[2];

            var randomAddresses = this.GetRandomValueFromArray(this.addresses);

            var randomPhonenumber = this.GetRandomValueFromArray(this.phonenumbers);

            var randomPersonalID = this.GetRandomValueFromArray(this.personalIDs);

            return new HumanInsurance(firstName, middleName, lastName, randomAddresses, randomPhonenumber, randomPersonalID);
        }

        private T GetRandomValueFromArray<T>(T[] arr)
        {
            var rnd = new Random();
            var index = rnd.Next(0, arr.Length);
            return arr[index];
        }
    }
}
