using System.Collections.Generic;

namespace ParkingGarageBusinessLogic
{
    public class Floor
    {
        public List<Space> ParkingSpaces;

        public Floor(List<Space> spaces)
        {
            ParkingSpaces = spaces;
        }
    }
}
