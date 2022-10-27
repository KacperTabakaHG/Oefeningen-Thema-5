namespace Oef_3_som
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int som = 0;
            int getal;
            do
            {
                Console.WriteLine("geef getal in :");
                getal = int.Parse(Console.ReadLine());

                som += getal;

            } while (getal != -1);

            som -= getal;
            
            Console.WriteLine($"De som is {som }");
        }
    }
}