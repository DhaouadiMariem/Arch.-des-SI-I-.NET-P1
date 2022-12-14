using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Flight
    {
        public string Destination { get; set; }
        public string Departure { get; set; }
        public DateTime FlightDate  { get; set; }
        public int FlightId  { get; set; }
        public int EffectiveArrival  { get; set; }
        public int EstimatedDuration  { get; set; }
        public List<Passenger> Passengers { get; set; }
        public Plane Plane { get; set; }
        public Flight()
        {
                
        }
        public Flight(string destination, string departure, DateTime flightDate, int flightId, int effectiveArrival, int estimatedDuration)
        {
            Destination = destination;
            Departure = departure;
            FlightDate = flightDate;
            FlightId = flightId;
            EffectiveArrival = effectiveArrival;
            EstimatedDuration = estimatedDuration;
        }
    }
}
