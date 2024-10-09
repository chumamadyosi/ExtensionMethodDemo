namespace ExtensionMethodDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {


            
            string demo = "this is a demo";
            demo.PrintToConsole();
            "this is a demo".PrintToConsole();

            SimpleLogger logger = new SimpleLogger();
            logger.LogError("this is an err");

            Student student = new();
            student.GetDetails();
            student.CalculateFee();
            
        }
    }

    public static class ExtendSimpleLogger
    {
        public static void LogError(this SimpleLogger logger, string message)
        {
            logger.Log(message, "ERROR");
        }
    }
    public class SimpleLogger
    {
        public void Log(string message)
        {
            System.Console.WriteLine(message);

        }

        public void Log(string message, string messageType)
        {
            Log($"{messageType}:{message}");

        }


    }
}


