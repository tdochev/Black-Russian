using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceApp.Core.Objects
{
    abstract class Vehicle
    {
        private VehicleType type;
        private Person owner;
        private string brand;
        private string model;
        private double horsePower;
        private double engineVolume;
        private bool ensurable;

        public VehicleType Type { get { return this.type; } }
        public Person Owner { get {return this.owner ;} }
        public string Brand { get { return this.brand; } }
        public string Model { get { return this.model; } }
        public double HorsePower { get { return this.horsePower; } }
        public double EngineVolume { get { return this.engineVolume; } }
        public bool Ensurable { get { return this.ensurable; } }

        public Vehicle(VehicleType type,string brand,string model, bool ensurable)
        {
            this.type = type;
            this.brand = brand;
            this.model = model;
            this.ensurable = ensurable;
        }

        public Vehicle(VehicleType type,Person owner, string brand, string model,
                       double horsePower,double engineVolume, bool ensurable)
        {
            this.type = type;
            this.owner = owner;
            this.brand = brand;
            this.model = model;
            this.horsePower = horsePower;
            this.engineVolume = engineVolume;
            this.ensurable = ensurable;
        }

    }
}
