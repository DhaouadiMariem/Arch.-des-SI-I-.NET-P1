using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Plane
    {
        public int Capacity { get; set; }
        public DateTime ManufactureDate{ get; set; }
        public int PlaneId{ get; set; }
       public  Planetype PlaneType{ get; set; }
        public List<Flight> Flights { get; set; }

        public Plane()
        {

        }
        public Plane(int capacity, DateTime manufactureDate, int planeId, Planetype planeType)
        {
            Capacity = capacity;
            ManufactureDate = manufactureDate;
            PlaneId = planeId;
            PlaneType = planeType;
        }

    }
}
