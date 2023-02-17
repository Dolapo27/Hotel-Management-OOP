namespace HotelManagementSystem
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int selectedMainOption = 10;
            int selectedAdminOption;

            WestminsterHotel westminster = new WestminsterHotel();

         

            while (selectedMainOption != 0)
            {
                Console.WriteLine("Welcome to Westminter Hotel \n");
                Console.WriteLine("Please choose any of the following options \n");
                Console.WriteLine("1. List Available Rooms. \n" +
                    "2. List Available Rooms With Price \n" +
                    "3. Book a room \n" +
                    "4. Open Admin Menu \n");

                selectedMainOption = Convert.ToInt32(Console.ReadLine());

                if (selectedMainOption == 4)
                {

                    westminster.OpenAdminMenu();

                    selectedAdminOption = Convert.ToInt32(Console.ReadLine());

                    while (selectedAdminOption != 0)
                    {
                        if(selectedAdminOption == 1)
                        {
                            selectedAdminOption = westminster.AdminMenuAddRoom(westminster);

                        }
                        if(selectedAdminOption == 2)
                        {
                            selectedAdminOption = westminster.AdminMenuDeleteRoom(westminster);

                        }
                        if(selectedAdminOption == 0)
                        {
                            selectedMainOption = 4;
                        }
                        
                    }


                }

            }
           


        }
    }
}