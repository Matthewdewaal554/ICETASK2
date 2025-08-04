namespace IndexIceTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Games game = new Games(599, 2023, "Elden Ring", "Action RPG");

                // Output values using int indexer
                Console.WriteLine("Using int indexer:");
                Console.WriteLine("Price: " + game[0]);
                Console.WriteLine("Year: " + game[1]);
                Console.WriteLine("Name: " + game[2]);
                Console.WriteLine("Genre: " + game[3]);

                // Update values using int indexer
                game[0] = 499;
                game[1] = 2024;

                // Output values using string indexer
                Console.WriteLine("\nUsing string indexer:");
                Console.WriteLine("Price: " + game["price"]);
                Console.WriteLine("Year: " + game["year"]);
                Console.WriteLine("Name: " + game["name"]);
                Console.WriteLine("Genre: " + game["genre"]);

                // Update name and genre using string indexer
                game["name"] = "Genshin: Impact";
                game["genre"] = "Gacha";

                // Final output
                Console.WriteLine("\nUpdated game details:");
                Console.WriteLine("Price: " + game["price"]);
                Console.WriteLine("Year: " + game["year"]);
                Console.WriteLine("Name: " + game["name"]);
                Console.WriteLine("Genre: " + game["genre"]);
        
        }
    }
}
