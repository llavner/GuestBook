using ConsoleUI;
using GuestLibrary.Models;

List<GuestBookModel> guestMessages = new();
int option = 0;

ConsoleMessages.WelcomeMessage();

while (option != 3)
{

    Console.WriteLine("1. View Guestbook\n2. Write to Guestbook\n3. Quit");
    Console.WriteLine();
    Console.Write("Option: ");
    string optionText = Console.ReadLine();

    bool isValidNumber = int.TryParse(optionText, out option);

    if (isValidNumber)
    {

        switch (option)
        {
            case 1:
                {
                    ConsoleMessages.PrintGuestBookMessages(guestMessages);
                    break;
                }
            case 2:
                {
                    ConsoleReqData.GetGuestInformation(guestMessages);
                    break;
                }
            case 3:
                {
                    ConsoleMessages.GoodByeMessage();
                    break;
                }
            default:
                {
                    Console.WriteLine("Options are 1, 2 and 3.");
                    break;
                }
        }

    }
    else
    {
        Console.WriteLine("Not a valid number.");
        Console.WriteLine();
    }
   
}

// Add options Write and View Guestbook + Quit

//ConsoleReqData.GetGuestInformation(guestMessages);

//ConsoleMessages.PrintGuestBookMessages(guestMessages);

//ConsoleMessages.GoodByeMessage();