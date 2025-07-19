using GuestLibrary.Models;

namespace ConsoleUI;

public static class ConsoleMessages
{
    public static void WelcomeMessage()
    {
        Console.WriteLine("Welcome to the GuestBook Practise App");
        Console.WriteLine("*************************************");
        Console.WriteLine();
    }

    public static void GoodByeMessage()
    {
        Console.WriteLine("Goodbye and thank you for using the guestbook.");
    }

    public static void PrintGuestBookMessages(List<GuestBookModel> guestMessages)
    {
        Console.Clear();

        if (guestMessages.Count != 0)
        {
            foreach (var message in guestMessages)
            {
                Console.WriteLine(message.GuestInformation);
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("There is no messages in the guestbook.");
        }

        Console.WriteLine("<Press a key to continue>");
        Console.ReadLine();
    }

}
