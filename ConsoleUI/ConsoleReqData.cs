using GuestLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI;

public static class ConsoleReqData
{
    public static void GetGuestInput(List<GuestBookModel> guestMessages)
    {
        string isQuiting = string.Empty;

        do
        {
            GuestBookModel guest = new();

            Console.Write("First name: ");
            guest.FirstName = Console.ReadLine();

            Console.Write("Last name: ");
            guest.LastName = Console.ReadLine();

            Console.Write("Message: ");
            guest.GuestBookMessage = Console.ReadLine();

            guestMessages.Add(guest);

            Console.Write("Do you wish to quit? (yes/no)");
            isQuiting = Console.ReadLine();

        } while (isQuiting != "yes");
    }
}
