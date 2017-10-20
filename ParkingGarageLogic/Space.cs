
namespace ParkingGarageBusinessLogic
{
    public class Space
    {
        public bool Occupied;
        public Size Size;

        public Space(bool occupied, Size size)
        {
            Size = size;
            Occupied = occupied;
        }
    }
}
