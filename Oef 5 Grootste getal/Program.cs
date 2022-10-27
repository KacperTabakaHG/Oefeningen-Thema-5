namespace Oef_5_Grootste_getal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int getal = 0;
            int grootsteGetal = 0;
            int teller = 0;

            do
            {
                Console.WriteLine("Geef getal in :");
                getal = int.Parse(Console.ReadLine());

                if (getal > grootsteGetal)
                {
                    grootsteGetal = getal;

                }
            
            } while (getal != -1);

            Console.WriteLine($"Grootste getal is {grootsteGetal}");
            


        }
    }
}