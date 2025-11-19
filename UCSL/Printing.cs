namespace UCSL
{
    public class Printing
    {
            string Out = "";

            foreach (string message in messages)
                Out += $"{message}\n";

            Console.WriteLine(Out);
        }
    }
}
