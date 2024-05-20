namespace AboutMyEnvironment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Environment.CurrentDirectory + Environment.NewLine);
            Console.WriteLine(Environment.OSVersion.VersionString + Environment.NewLine);
            Console.WriteLine("Namespace: {0}", typeof(Program).Namespace);
        }
    }
}
