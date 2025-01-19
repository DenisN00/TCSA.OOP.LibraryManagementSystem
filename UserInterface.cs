using Spectre.Console;
using static TCSA.OOP.LibraryManagementSystem.Enums;


namespace TCSA.OOP.LibraryManagementSystem;


internal class UserInterface
{

    BooksController userInterface = new BooksController();
    internal void MainMenu()
    {
        while (true)
        {
            Console.Clear();

            var choice = AnsiConsole.Prompt(
                           new SelectionPrompt<MenuOption>()
                           .Title("What do you want to do next?")
                           .AddChoices(Enum.GetValues<MenuOption>()));

            switch (choice)
            {
                case MenuOption.ViewBooks:
                    userInterface.ViewBooks();
                    break;

                case MenuOption.AddBook:
                    userInterface.AddBook();
                    break;

                case MenuOption.DeleteBook:
                    userInterface.DeleteBook();
                    break;
            }
        }
    }
}
