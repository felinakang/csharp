namespace TicTacToe
{
    public class Menu
    {
        public Menu() 
        {
            Console.WriteLine("Welcome to Felina's TicTacToe mini-game!");
            bool validOption = true;
            do
            {
                Console.WriteLine("To start, please choose your difficulty:\n(1) Easy\n(2) Medium\n(3) Hard\n(q) Quit");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        //create easy difficulty tictactoe game
                        Console.WriteLine("option 1");
                        validOption = true;
                        break;
                    case "2":
                        //create medium difficulty ttt game
                        Console.WriteLine("option 2");
                        validOption = true;
                        break;
                    case "3":
                        //create hard difficulty ttt game
                        Console.WriteLine("option 3");
                        validOption = true;
                        break;
                    case "q":
                        Console.WriteLine("See you next time!");
                        validOption = true;
                        break;
                    default:
                        validOption = false;
                        Console.WriteLine("Sorry, that's not a valid option! Please enter your selection again.");
                        break;
                }
            } while (!validOption);
            
        }
    }
}