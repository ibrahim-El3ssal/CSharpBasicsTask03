namespace C_BasicsTask03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Questio01
            //Given string title = "Refactoring";, write a switch statement that prints "Great choice!"
            //if the title is "Clean Code", "Nice pick!" if it's "Refactoring", and "Never heard of it" for anything else.

            string title = "Refactoring";
            switch (title)
            {
                case "Clean Code":
                    Console.WriteLine("Great choice!");
                    break;
                case "Refactoring":
                    Console.WriteLine("Nice pick!");
                    break;
                default:
                    Console.WriteLine("Never heard of it");
                    break;
            }
            #endregion

            #region Question02
            //Given int pages = 464;, use the ternary operator to store "Long Book" 
            // or "Short Book" into a variable sizeLabel(same rule as question 8: long if pages > 300).

            Console.WriteLine("");
            Console.WriteLine("Question02 : ");
            int pages = 464;

            string sizeLabel = (pages > 300) ? "Long Book" : "Short Book";

            Console.WriteLine(sizeLabel);

            #endregion

            #region Question03
            //Given string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };,
            //use a for loop to print each book with its position number, like 1.Clean Code.\

            Console.WriteLine("");
            Console.WriteLine("Question03 : ");

            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine($"{i + 1}.{books[i]}");
            }
            #endregion

            #region Question04
            //Using the same books array, use a while loop to print every book title.________________________________________
            Console.WriteLine("");
            Console.WriteLine("Question04 : ");
            string[] bookList = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            int j = 0;
            while (j < bookList.Length)
            {
                Console.WriteLine($"{j + 1}.{bookList[j]}");
                j++;
            }
            #endregion

            #region Question05
            //Write a do -while loop that prints "Checking book..." exactly 3 times.

            Console.WriteLine("");
            Console.WriteLine("Question05 : ");
            int count = 0;
            //
            do
            {
                Console.WriteLine("Checking book...");
                count++;
            } while (count < 3);

            #endregion
            Console.ReadLine();
        }
    }
}
