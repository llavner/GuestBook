using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestLibrary.Models;

public class GuestBookModel
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string GuestBookMessage { get; set; }
    public string GuestInformation
    { 
        get
        {
            return $"Name: {FirstName} {LastName}\nMessage: {GuestBookMessage}";
        }
    }
}
