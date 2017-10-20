using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingGarageBusinessLogic.Services
{
    class FittingService
    {
        public bool IsVehicleAbleToFitIntoSpace(Size vehicleSize, Size spaceSize)
        {
            if (vehicleSize.Height < spaceSize.Height || vehicleSize.Width < spaceSize.Width ||
                vehicleSize.Length < spaceSize.Length)
            {
                return false;
            }
            return true;
        }
    }
}
