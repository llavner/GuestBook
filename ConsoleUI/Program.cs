using ConsoleUI;
using GuestLibrary.Models;

List<GuestBookModel> guestMessages = new();

ConsoleMessages.WelcomeMessage();

ConsoleReqData.GetGuestInformation(guestMessages);

ConsoleMessages.PrintGuestBookMessages(guestMessages);

ConsoleMessages.GoodByeMessage();