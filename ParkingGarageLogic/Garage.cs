using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.ServiceModel;
using ParkingGarageBusinessLogic.Services;

namespace ParkingGarageBusinessLogic
{
    public class Garage
    {
        public List<Floor> listOfFloors;
        public FittingService fittingService= new FittingService();

        public Garage()
        {
            listOfFloors = new List<Floor>();
        }

        public Space FindASpace(Size size)
        {
            foreach (var floor in listOfFloors)
            {
                foreach (var space in floor.ParkingSpaces)
                {
                    if (fittingService.IsVehicleAbleToFitIntoSpace(size,space.Size))
                    {
                        return space;
                    }
                }
            }

            return null;
        }

    }

}
