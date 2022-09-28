using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Staff : Passenger
    {
        public Staff(string passportNumber, string firstName, string lastName, string emailAddress, string telNumber, DateTime employementDate, string function, double salary) :base (passportNumber, firstName, lastName, emailAddress, telNumber)
        {
            EmployementDate = employementDate;
            Function = function;
            Salary = salary;
        }
        public Staff()
        {
                
        }

        public DateTime EmployementDate{ get; set; }
        public string Function { get; set; }

        public double Salary { get; set; }

        public override string ToString()
        {
            return $"{base.ToString} , {EmployementDate} , {Function} , {Salary}";
        }

    }
}
