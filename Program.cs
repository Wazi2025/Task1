namespace Task1;

class Program
{
    static void Main(string[] args)
    {
        string? value = "";

        //these variables can be constants since they will never change
        const string exit = "exit";
        const string message = "Your passwordlength is";
        const string typeInPW = "\nPlease type in your password (or 'exit' to quit): ";

        while (value.ToLower() != exit)
        {
            Console.WriteLine(typeInPW);
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
