//TODO: refactor out boilerplate code, maybe use lambdas? maybe.
namespace ConsoleInputStubs
{
    public static class InputStubs
    {
        public static int InputInt()
        {
            string foo="";
            int number;
            while(true) 
            {
                Console.WriteLine($"Input an integer");
                foo = Console.ReadLine() + "";
                if (String.Equals(foo, "q", StringComparison.OrdinalIgnoreCase))
                    throw new QuitInputException();
                if (!int.TryParse(foo, out number))
                {
                    Console.WriteLine($"{foo} is not an integer");
                }
                else break;
            } 
            return number;
        }

        public static int InputNaturalInt() 
        {
            string foo = "";
            int number;
            while (true)
            {
                Console.WriteLine($"Input a natural integer (>=0)");
                foo = Console.ReadLine() + "";
                if (String.Equals(foo, "q", StringComparison.OrdinalIgnoreCase))
                    throw new QuitInputException();
                if (!int.TryParse(foo, out number) || number < 0)
                {
                    Console.WriteLine($"{foo} is not a natural number");
                }
                else break;
            }
            return number;
        }

        public static string? InputString()
        {
            Console.WriteLine($"Input any string");
            return Console.ReadLine();
        }

        public static string? InputWord()
        {
            Console.WriteLine($"Input an word");
            string foo = Console.ReadLine() + "";
            while (foo.Contains(' '))
            {
                Console.WriteLine($"No spaces allowed. Try again.");
                foo = Console.ReadLine() + "";
            }

            return foo;
        }

        public static List<int> InputIntList()
        {
            string foo;
            List<int> newList;
            while(true)
            {
                Console.WriteLine($"Input a list of integers seperated by spaces");
                foo = Console.ReadLine() + "";
                if (String.Equals(foo, "q", StringComparison.OrdinalIgnoreCase))
                    throw new QuitInputException();
                if (IsArrayInts(foo.Split(' '), out newList))
                    break;
            }
            return newList;
        }

        public static List<int> InputNaturalIntList()
        {
            string foo;
            List<int> newList;
            while (true)
            {
                Console.WriteLine($"Input a list of natural integers seperated by spaces");
                foo = Console.ReadLine() + "";
                if (String.Equals(foo, "q", StringComparison.OrdinalIgnoreCase))
                    throw new QuitInputException();
                if (IsArrayNaturalInts(foo.Split(' '), out newList))
                    break;
            }
            return newList;
        }

        private static bool IsArrayInts(string[] numbers, out List<int> newList) 
        {
            int num;
            newList = new List<int>();
            foreach (var number in numbers)
            {
                if (number == "")
                    break;
                if (!Int32.TryParse(number, out num))
                {
                    Console.WriteLine($"{number} is not an integer");
                    return false;
                }
                newList.Add(num);
            }
            return true;
        }

        private static bool IsArrayNaturalInts(string[] numbers, out List<int> newList)
        {
            int num;
            newList = new List<int>();
            foreach (var number in numbers)
            {
                if (number == "")
                    break;
                if (!Int32.TryParse(number, out num))
                {
                    Console.WriteLine($"{number} is not a natural integer");
                    return false;
                }
                newList.Add(num);
            }
            return true;
        }

    }
}
