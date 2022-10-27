namespace Oefening_8_Vierkant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zijde?: ");
            int zijde = int.Parse(Console.ReadLine());
            int hoogteTeller = 0;

            do
            {
                int zijdeTeller = 0;
                do
                {
                    Console.Write("*");
                    zijdeTeller++;
                } while (zijdeTeller < zijde);
                Console.WriteLine();
                hoogteTeller++;
            } while (hoogteTeller < zijde);
        }
    }
}