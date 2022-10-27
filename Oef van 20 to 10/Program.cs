namespace Oef_van_20_to_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int getal = 20;
            do
            {
                Console.WriteLine(getal);
                getal = getal - 2;
            } while (getal >= 10);
        }
    }
}