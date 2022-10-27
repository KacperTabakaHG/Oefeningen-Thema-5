namespace Oef_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int teller = 0;
            int getal = 0;
            int grootsteGetal = 0;
            
            do
            {
                Console.WriteLine("Geef getal in : (stop met -1)");
                getal = int.Parse(Console.ReadLine());

                if(getal > grootsteGetal)
                {
                    grootsteGetal = getal;
                  // als het grotere getal was ingevoert onze teller reset tot 1   
                    teller = 1;
                }else if (getal == grootsteGetal)
                {
                    teller++;
                }
            }while(getal != -1);

            Console.WriteLine($"Grootste getal is {grootsteGetal} en heeft {teller} keer voorgekomen");
        }
    }
}