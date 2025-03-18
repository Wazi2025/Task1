namespace Task1;

class Program
{
    static void Main(string[] args)
    {
        string? value = "";

        //these two variables can be constants since they will never change
        const string exit = "exit";
        const string message = "Your passwordlength is";

        // do
        // {
        while (value.ToLower() != exit)
        {
            Console.WriteLine("\nPlease type in your password (or 'exit' to quit): ");
            value = Console.ReadLine();

            //check for empty pw
            if (!string.IsNullOrEmpty(value) && value.ToLower() != exit)
            {

                switch (value.Length)
                {
                    case > 15:
                        Console.WriteLine($"{message} {value.Length}. Brilliant!");
                        break;

                    case > 10:
                        Console.WriteLine($"{message} {value.Length}. A decent size");
                        break;

                    case < 10:
                        Console.WriteLine($"{message} {value.Length}. A bit short");
                        break;
                }
            }
        }
    }
}
