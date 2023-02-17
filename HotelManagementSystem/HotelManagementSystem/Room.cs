using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem
{
    abstract class Room
    {
        public int Room_Number;
        public string Room_Floor = "";
        public string[] Room_Size = new string[3] { "single", "double", "triple" };
        public string selectedRoomSize = "";
        public double Room_Price;

    }

    internal class StandardRoom : Room
    {
        public int Windows;

        public StandardRoom(int roomNumber, string roomFloor, int roomSize, double roomPrice, int windows)
        {
            Room_Number = roomNumber;
            Room_Floor = roomFloor;
            selectedRoomSize = Room_Size[roomSize];
            Room_Price = roomPrice;
            Windows = windows;
        }
    }

    internal class DeluxeRoom : Room
    {
        public double BalconySize;
        public string[] View = new string[3] {"seaview","mountainview","landmarkview"};
        public string selectedView = "";
        public DeluxeRoom(int roomNumber, string roomFloor, int roomSize, double roomPrice, double balconySize, int view)
        {
            Room_Number = roomNumber;
            Room_Floor = roomFloor;
            selectedRoomSize = Room_Size[roomSize];
            Room_Price = roomPrice;
            BalconySize = balconySize;
            selectedView = View[view];
        }

    }
}
