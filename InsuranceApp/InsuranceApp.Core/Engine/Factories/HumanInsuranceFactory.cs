using InsuranceApp.Core.Objects.HumanEntities;
using System;

namespace InsuranceApp.Core.Engine.Factories
{
    public class HumanInsuranceFactory
    {

        private string[] names =
            {
            "Pesho Ivanov Petrov",
            "Gosho Petrov Dimitrov"
        };
        private readonly string[] address =
            {
            "Ul. Niama Znachenie 23"
        };

        private readonly string[] phonenumber = 
            {
            "0888888888"
        };
        private readonly string[] personalID =
            {
             "8010207889"
        };


        public HumanInsurance CreateHumanInsurance()
        {
            var firstName = names[0].Split(' ')[0];
            var middleName = names[0].Split(' ')[1];
            var lastName = names[0].Split(' ')[2];
            return new HumanInsurance(firstName, middleName, lastName, address[0], phonenumber[0], personalID[0]);
        }
    }
}
