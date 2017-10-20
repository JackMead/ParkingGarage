using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.ServiceModel;

namespace ParkingGarageBusinessLogic
{
    public class Garage
    {
        public List<Floor> listOfFloors;
        
        public Garage()
        {
            listOfFloors = new List<Floor>();
        }


    }

}
