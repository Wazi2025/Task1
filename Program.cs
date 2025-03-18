namespace Task1;

class Program
{
    static void Main(string[] args)
    {
        //make string variable a nullable reference type (whatever that is)
        string? value;

        //these variables can be constants since they will never change
        const string exit = "exit";
        const string message = "Your passwordlength is";
        const string typeInPW = "\nPlease type in your password (or 'exit' to quit): ";

        do
        {
            Console.WriteLine(typeInPW);
            value = Console.ReadLine();

            //check for empty value and that value is not 'exit' (which will exit the program)
            if (!string.IsNullOrEmpty(value) && value.ToLower() != exit)
            {
                //choose cases based on value.length
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
        } while (value.ToLower() != exit);
    }
}
