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
        foreach (var message in guestMessages)
        {
            Console.WriteLine(message.GuestInformation);
            Console.WriteLine();
        }

    }

}
