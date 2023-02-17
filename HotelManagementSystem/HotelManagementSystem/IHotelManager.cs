using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem
{
    internal interface IHotelManager
    {
        bool AddRoom(Room room);

        bool DeleteRoom(int roomNumber);

        void ListRooms();

        void ListRoomsOrderedByPrice();

        void GenerateReport(string fileName);
    }
}
