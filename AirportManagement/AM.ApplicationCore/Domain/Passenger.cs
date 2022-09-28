using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {
        public Passenger()
        {

        }
        
        public string passportNumber {set; get;}
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string EmailAddress { set; get; }
        public string TelNumber { set; get; }
         List<Flight> Flights { get; set; }

        
        public override string ToString()
        {
            return $"{passportNumber},{FirstName} , {EmailAddress} , {TelNumber}";
        }

        public Passenger(string passportNumber, string firstName, string lastName, string emailAddress, string telNumber) 
        {
            this.passportNumber = passportNumber; 
            this.FirstName= firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
            TelNumber = telNumber;
        }
    }
}
