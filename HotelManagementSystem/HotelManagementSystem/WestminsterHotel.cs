using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem
{
    internal class WestminsterHotel : IHotelManager, IHotelCustomer
    {
        public List<Room> rooms = new List<Room>
        {
           new StandardRoom(1,"Floor 1",2,500.0f,5),
           new DeluxeRoom(2,"Floor 1",2,1500.0f,500.0f,1)
        };

        public List<Booking> bookings = new List<Booking> { };

        public bool AddRoom(Room room)
        {
            foreach (var singleRoom in rooms)
            {
                if (singleRoom.Room_Number != room.Room_Number)
                {
                    rooms.Add(room);
                    return true;
                }
                else
                {
                    Console.WriteLine("Room Number already exists");
                    return false;
                }
            }
            return false;
        }

        public bool BookRoom(int roomNumber, Booking wantedBooking)
        {
            throw new NotImplementedException();
        }

        public bool DeleteRoom(int roomNumber)
        {
            foreach (Room singleRoom in rooms)
            {
                if (singleRoom.Room_Number == roomNumber)
                {
                    int foundIndex = rooms.IndexOf(singleRoom);
                    rooms.RemoveAt(foundIndex);
                    return true;
                }
                else
                {
                    Console.WriteLine("Could not find the specified room number");
                    return false;
                }
            }
            return false;
        }

        public void GenerateReport(string fileName)
        {
            throw new NotImplementedException();
        }

        public void ListAvailableRooms(Booking wantedBooking, string roomSize)
        {
            throw new NotImplementedException();
        }

        public void ListAvailableRooms(Booking wantedBooking, string roomSize, int maxPrice)
        {
            throw new NotImplementedException();
        }

        public void ListRooms()
        {
          foreach (Room singleroom in rooms)
            {
                Console.WriteLine("This is the room number" + singleroom.Room_Number);
            }

        }

        public void ListRoomsOrderedByPrice()
        {
            throw new NotImplementedException();
        }

        public void OpenAdminMenu()
        {
            Console.WriteLine("Welcome to the Admin Menu \n");
            Console.WriteLine("Here are the available options \n");
            Console.WriteLine(
            "1. Add a room. \n" +
            "2. Delete a room \n" +
            "3. List All rooms \n" +
            "4. List rooms ordered by price \n" +
            "5. Generate a report \n" +
            "0. Go Back");
        }

        public int AdminMenuAddRoom(WestminsterHotel westminster)
        {
            int roomNumber;
            string roomFloor = "";
            int roomSize;
            double roomPrice;
            int roomType;
            int roomWindows;
            double balconySize;
            int roomView;


            Console.WriteLine("Please enter the following details about the room you want to add in this order \n" +
                "Room Number \n" +
                "Room Floor \n" +
                "Room Size: 1 for Single, 2 for Double, 3 for Triple \n" +
                "Room Price \n" +
                "Room Type: 1 for Standard, 2 for Deluxe \n" +
                "To cancel please enter 300 instead of a valid room number \n");
            roomNumber = Convert.ToInt32(Console.ReadLine());
            

            if (roomNumber != 6)
            {
                roomFloor = Console.ReadLine();
                roomSize = Convert.ToInt32(Console.ReadLine());
                roomPrice = Convert.ToDouble(Console.ReadLine());
                roomType = Convert.ToInt32(Console.ReadLine());
            }
            else
            {
                return 0;
            }

            //Standard Room
            if (roomType == 1)
            {
                Console.WriteLine("You have selected a standard room as the room you want to create \n");
                Console.WriteLine("Please enter the number of windows this room will have \n");
                roomWindows = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Adding the room now.............. \n");
                Room newRoom = new StandardRoom(roomNumber, roomFloor, roomSize, roomPrice, roomWindows);
                bool addedRoom = westminster.AddRoom(newRoom);
                if (addedRoom)
                {
                    Console.WriteLine("The room has now been added \n");
                    return 0;
                }
                else
                {
                    return 1;
                }
            }


            if (roomType == 2)
            {
                Console.WriteLine("You have selected a deluxe room as the room you want to create \n");
                Console.WriteLine("Please enter the balcony size of this room  \n");
                balconySize = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please enter the room view of this room  \n");
                Console.WriteLine("1: Seaview,2: Mountainview,3: Landmarkview  \n");
                roomView = Convert.ToInt32(Console.ReadLine());
                if (balconySize.GetType() == typeof(double) && (roomView >= 1 || roomView <= 3))
                {
                    Console.WriteLine("Adding the room now.............. \n");
                    Room newRoom = new DeluxeRoom(roomNumber, roomFloor, roomSize, roomPrice, balconySize, roomView);
                    bool addedRoom = westminster.AddRoom(newRoom);
                    if (addedRoom)
                    {
                        Console.WriteLine("The room has now been added \n");
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
                else
                {
                    Console.WriteLine("Please enter an appropriate balcony size or enter a room view between 1-3  \n");
                    return 1;
                }

            }

            return 1;
        }

        public int AdminMenuDeleteRoom(WestminsterHotel westminster)
        {

            Console.WriteLine("Please enter a valid room number to delete the room \n");
            Console.WriteLine("To cancel please enter 300 \n");
            int roomNumber = Convert.ToInt32(Console.ReadLine());
            bool removed = westminster.DeleteRoom(roomNumber);

            if(roomNumber.GetType() == typeof(int) && roomNumber != 300)
            {
                if (removed)
                {
                    Console.WriteLine("Removed the room");
                    return 0;

                }
                else
                {
                    return 2;
                }
            }
            
            if(roomNumber == 300)
            {
                return 0;
            }

            return 0; 
           
        }
    }
}
