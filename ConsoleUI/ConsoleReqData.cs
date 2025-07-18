using GuestLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI;

public static class ConsoleReqData
{
    public static void GetGuestInformation(List<GuestBookModel> guestMessages)
    {
        string isQuiting = string.Empty;

        do
        {
            GuestBookModel guest = new();

            guest.FirstName = GetUserInput("First name: ");
            guest.LastName = GetUserInput("Last name: ");
            guest.GuestBookMessage = GetUserInput("Message: ");
            guestMessages.Add(guest);
            isQuiting = GetUserInput("Do you wish to quit? (yes/no)");

        } while (isQuiting != "yes");
    }

    public static string GetUserInput(string message)
    {
        Console.Write(message);
        string output = Console.ReadLine();

        return output;
    }
}
