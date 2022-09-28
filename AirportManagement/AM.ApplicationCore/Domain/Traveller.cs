using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Traveller : Passenger
    {
        public string HealthInformation { get; set; }
        public string Nationality { get; set; }

        public Traveller(string passportNumber, string firstName, string lastName, string emailAddress, string telNumber, string HealthInformation, string Nationality) : base(passportNumber, firstName, lastName, emailAddress, telNumber)
        {
            this.HealthInformation = HealthInformation;
            this.Nationality = Nationality;
        }
        public Traveller()
        {

        }
        public override string ToString()
        {
            return $"{base.ToString} , {HealthInformation} , {Nationality}";
        }

    }
}
