using static UCSL.Printing;
namespace UCSL_Testing
{
    public class PrintingTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestWriteArrayOfLinesToConsole()
        {
            StringWriter stringWriterMethodOut = new StringWriter(); //Created stringwriter to get strings from console.WriteLine outputs
            Console.SetOut(stringWriterMethodOut); // Redirect console output to previously defined stringwriter

            WriteArrayOfLinesToConsole(new string[] { "word 1", "word 2"});


            StringWriter stringWriterExpectedOut = new StringWriter(); //Created stringwriter to get strings from console.WriteLine outputs
            Console.SetOut(stringWriterExpectedOut); // Redirect console output to previously defined stringwriter

            Console.WriteLine("word 1\nword 2\n");

            Assert.AreEqual(stringWriterExpectedOut.ToString(), stringWriterMethodOut.ToString());
        }
    }
}
