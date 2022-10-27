namespace Oef_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int som = 0;
            int getal;
            int teller = 0;
            do
            {
                Console.WriteLine("Geef getal in : (Stop met -1 op te clicken)");
                getal = int.Parse(Console.ReadLine());


                som += getal;
                teller++;


            } while (getal != -1);
            teller--;
            som -= getal;

            if (teller > 0)
            {
                double gemiddelde = Convert.ToDouble(som) / teller;
                Console.WriteLine($"Gemmidelde is {gemiddelde}");

            }
            else
            {
                Console.WriteLine("Er werden geen bruikbare getalen gegeven");
            }




        }
    }
}