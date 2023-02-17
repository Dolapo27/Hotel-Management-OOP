using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem
{
    internal interface IHotelCustomer
    {
        void ListAvailableRooms(Booking wantedBooking, string roomSize);

        void ListAvailableRooms(Booking wantedBooking, string roomSize, int maxPrice);

        bool BookRoom(int roomNumber, Booking wantedBooking);
    }
}
