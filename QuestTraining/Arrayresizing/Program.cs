using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrayresizing
{
    internal class Program
    {
        /*public static int[] ResizingArray(int[] oldArray,int newsize)
        {
            int[] newArray = new int[newsize];

            for (int i = 0; i < oldArray.Length && i < newsize; i++) { 
            
                newArray[i] = oldArray[i];
            }
            return newArray;
        }

        static void Main(string[] args)
        {
            int[] originalArray = { 1, 2, 3, 4, 5 };
            int[] largerArray = ResizingArray(originalArray,10);

            Console.WriteLine("Larger Array:");
            foreach(int item in largerArray)
            {
                Console.WriteLine(item+"");
            }

            int[] smallerArray=ResizingArray(originalArray,5);
            Console.WriteLine("smaller Array:");
            foreach(int item in smallerArray)
            {
                Console.WriteLine(item + " ");
            }

        }*/


        static Dictionary<string, Dictionary<string, object>> rooms = new Dictionary<string, Dictionary<string, object>>();
        static void AddRoom()
        {
            Console.WriteLine("Enter room Id:");
            string roomId = Console.ReadLine();

            Console.WriteLine("Enter the room type:");
            string roomType = Console.ReadLine();

            Console.WriteLine("Enter room price pre night:");
            decimal price = decimal.Parse(Console.ReadLine());

            if (!rooms.ContainsKey(roomId))
            {
                rooms.Add(roomId, new Dictionary<string, object>
                {
                    {"RoomType",roomType},
                    {"Status","Available" },
                    {"Price",price},
                    {"Guest",null}

                });
                Console.WriteLine("Room Added successfully");

            }
            else
            {
                Console.WriteLine("Room id already exist");
            }
        }

        static void BookRoom()
        {
            Console.WriteLine("Enter the room id:");
            string roomId = Console.ReadLine();

            if (rooms.ContainsKey(roomId))
            {

                if ((string)rooms[roomId]["Status"] == "Available")
                {
                    Console.WriteLine("Enter guest name:");
                    string guestname = Console.ReadLine();

                    Console.WriteLine("Enter no. of nights:");
                    int nights = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter the check in date in the form (MM/DD/YYYY)");
                    string checkInDate = Console.ReadLine();

                    rooms[roomId]["Status"] = "Booked";
                    rooms[roomId]["Guest"] = new Dictionary<string, object>
                    {
                        { "GusetNmae",guestname},
                        {"Nights",nights },
                        {"CheckInDate",checkInDate }

                    };
                    Console.WriteLine($"Room booked successfully for{guestname}");


                }
                else
                {
                    Console.WriteLine("Rooms are not available to book");
                }
            }
            else
            {
                Console.WriteLine("Room id does not exist");
            }

        }
        static void CheckOutRoom()
        {
            Console.WriteLine("Enter room id");
            string roomId = Console.ReadLine();

            if (rooms.ContainsKey(roomId))
            {

                if ((string)rooms[roomId]["Status"] == "Booked")
                {
                    rooms[roomId]["Status"] = "Available";
                    rooms[roomId]["Guest"] = null;
                    Console.WriteLine("Room checked out and now available to book");

                }
                else
                {
                    Console.WriteLine("Room is not currently booked");
                }

            }
            else
            {
                Console.WriteLine("Room id does not exist");
            }


        }
        static void SetRoomStatus()
        {
            Console.WriteLine("Enter room id:");
            string roomId = Console.ReadLine();

            if (rooms.ContainsKey(roomId))
            {

                Console.WriteLine("Enter the new status of room: Available/Booked/UnderManintaince");
                string status = Console.ReadLine();
                if (status == "Available" || status == "Booked" || status == "Maintaince")
                {
                    rooms[roomId]["Status"] = status;
                    Console.WriteLine($"Room status updated:{status}");

                }
                else
                {
                    Console.WriteLine("Ivalid room status");
                }

            }
            else
            {
                Console.WriteLine("Room id does not exist");
            }
        }
        static void GetAvailableRooms()
        {
            Console.WriteLine("Available Rooms:");
            foreach (var room in rooms)
            {
                if ((string)room.Value["Status"] == "Available")
                {
                    Console.WriteLine($"Room ID: {room.Key}, Type: {room.Value["RoomType"]}, Price: {room.Value["Price"]}");
                }
            }
        }

        static void GetBookedRooms()
        {
            Console.WriteLine("Booked Rooms:");
            foreach (var room in rooms)
            {
                if ((string)room.Value["Status"] == "Booked")
                {
                    var guest = (Dictionary<string, object>)room.Value["Guest"];
                    Console.WriteLine($"Room ID: {room.Key}, Guest: {guest["GuestName"]}, Check-in: {guest["CheckInDate"]}, Nights: {guest["Nights"]}");
                }
            }
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n1. Add Room");
                Console.WriteLine("2. Book Room");
                Console.WriteLine("3. Check Out Room");
                Console.WriteLine("4. Set Room Status");
                Console.WriteLine("5. Get Available Rooms");
                Console.WriteLine("6. Get Booked Rooms");
                Console.WriteLine("7. Exit");

                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        AddRoom();
                        break;
                    case "2":
                        BookRoom();
                        break;
                    case "3":
                        CheckOutRoom();
                        break;
                    case "4":
                        SetRoomStatus();
                        break;
                    case "5":
                        GetAvailableRooms();
                        break;
                    case "6":
                        GetBookedRooms();
                        break;
                    case "7":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                }
            }
        }
    }
}





