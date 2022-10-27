namespace Oef_9_Double
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double getal;
            do
            {
                Console.WriteLine("Geef een double getal in");
                if (double.TryParse(Console.ReadLine(), out getal))
                {
                    Console.WriteLine("Dank je voor het dubbel getal");
                }
                else
                {
                    Console.WriteLine("Eide (Wegens geen double getal)");
                    break;
                }
                

            } while(true);
            
        }
    }
}