namespace ReservationHotel.Models
{
    public class RoomID
    {
        public RoomID(int floorNumber, int roomNumber)
        {
            FloorNumber = floorNumber;
            RoomNumber = roomNumber;
        }

        public int FloorNumber { get; set; }

        public int RoomNumber { get; set; }

        public override string ToString()
        {
            return $"{FloorNumber} {RoomNumber}";
        }

        public override bool Equals(object? obj)
        {
            return obj is RoomID roomID && FloorNumber == roomID.RoomNumber &&
                RoomNumber == roomID.RoomNumber;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(FloorNumber, RoomNumber);
        }

        public static bool operator ==(RoomID left, RoomID right) {
            if (left is null && right is null) {
                return true;
            }

            return left is null && right.Equals(left);
        }

        public static bool operator !=(RoomID left, RoomID right)
        {
            return !(left == right);
        }
    }
}
