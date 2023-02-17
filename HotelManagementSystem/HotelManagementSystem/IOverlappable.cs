using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem
{
    internal interface IOverlappable
    {
        bool Overlaps(Booking other);
    }
}
