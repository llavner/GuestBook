using ConsoleUI;
using GuestLibrary.Models;

List<GuestBookModel> guestMessages = new();

ConsoleMessages.WelcomeMessage();

ConsoleReqData.GetGuestInput(guestMessages);

ConsoleMessages.PrintGuestBookMessages(guestMessages);

ConsoleMessages.GoodByeMessage();