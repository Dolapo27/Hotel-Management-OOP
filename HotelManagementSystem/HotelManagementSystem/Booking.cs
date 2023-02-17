using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem
{
    internal class Booking : IOverlappable
    {
        public DateTime check_in_date;
        public DateTime check_out_date;
        public int room_number;

        public bool Overlaps(Booking other)
        {
            if(other.check_in_date == check_in_date && other.room_number == room_number)
            {
                return true;
            }
            if (other.check_out_date == check_out_date && other.room_number == room_number)
            {
                return true;
            }

            return false;
        }
    }
}
