using CodingChallanges;

namespace CodingChallanges
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("Select from List...");
                Console.WriteLine("1) Get century from year.");
                Console.WriteLine("2) Check Palindrome.");
                Console.WriteLine("0) Exit!");
                string option = Console.ReadLine();
                string stringInput = "";
                switch (option)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Enter a year  (shoud be of four numbers)");
                        stringInput = Console.ReadLine();
                        if (stringInput == "")
                        {
                            Console.WriteLine("Can't Perform function on empty string");
                            Console.WriteLine("Press any key for Main Menu");
                            Console.ReadKey();
                            break;
                        }
                        var century = CenturyFromYear.Calculate(Convert.ToInt32(stringInput));
                        Console.WriteLine($"{stringInput} is in {century} century");
                        Console.WriteLine("Press any key for Main Menu");
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Enter a value");
                        stringInput = Console.ReadLine();
                        if (stringInput == "")
                        {
                            Console.WriteLine("Can't Perform function on empty string");
                            Console.WriteLine("Press any key for Main Menu");
                            Console.ReadKey();
                            break;
                        }
                        var palindromeMessage = PalindromeChecker.Check(stringInput);
                        Console.WriteLine($"{palindromeMessage}");
                        Console.WriteLine("Press any key for Main Menu");
                        Console.ReadKey();
                        break;
                    case "0":
                        exit = true;
                        break;
                    default:
                        exit = true;
                        break;
                }
            }
        }
    }
}
