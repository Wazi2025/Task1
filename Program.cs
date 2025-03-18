namespace Task1;

class Program
{
    static void Main(string[] args)
    {
        //Make string variable a nullable reference type (whatever that is)
        //Appears to have something to do with Readline()
        string? value;

        //These variables can be constants since they will never change
        const string exit = "exit";
        const string message = "Your passwordlength is";
        const string typeInPW = "Please type in your password (or 'exit' to quit): ";

        do
        {
            Console.WriteLine(typeInPW);
            value = Console.ReadLine();

            //Check for empty/null value 
            if (!string.IsNullOrEmpty(value))
            {

                //Exit loop if value == exit
                if (value.ToLower() == exit)
                    break;

                //Choose cases based on value.length
                switch (value.Length)
                {
                    case > 15:
                        Console.WriteLine($"{message} {value.Length}. Brilliant!");
                        break;

                    case >= 10:
                        Console.WriteLine($"{message} {value.Length}. A decent size.");
                        break;

                    case < 9:
                        Console.WriteLine($"{message} {value.Length}. A bit short.");
                        break;
                }
            }
            else
            {
                //Inform user if value is empty/null
                Console.WriteLine($"Minimum passwordlength is 1.");
                continue;
            }
        } while (true);
    }
}
