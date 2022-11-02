namespace Oef_12
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int newGetal;
            int getal = 0;
            int teller = 0;
            int laasteTweeGetalen = 2;
            do
            {
                newGetal = getal;
                getal = int.Parse(Console.ReadLine());
                teller++;

            } while (newGetal != getal);
            teller -= laasteTweeGetalen;
            Console.WriteLine(teller);






        }
    }
}