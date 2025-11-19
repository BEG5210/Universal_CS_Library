namespace UCSL
{
    internal class Printing
    {
        public void WriteLineToConsole(string message)
        {
            Console.WriteLine(message);
        }

        /// <summary>
        /// Writes each string in the specified array to the console, with each string in the array on a new line.
        /// </summary>
        /// <param name="messages">An array of strings to be written to the console. Cannot be null.</param>
        public void WriteArrayOfLinesToConsole(string[] messages)
        {
            foreach (string message in messages)
            {
                Console.WriteLine(message);
            }
        }
    }
}
