using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Controller
{
    internal abstract class BaseController
    {
        protected void DisplayMessage(string message, string color ="yellow")
        {
            AnsiConsole.MarkupLine($"[{color}]{message}[/]");

        }
        protected bool ConfirmDeletion(string itemName)
        {
            var confirm = AnsiConsole.Confirm($"Are you sure to delete [red] {itemName}[/]?");
            return confirm;
        }
    }
}
