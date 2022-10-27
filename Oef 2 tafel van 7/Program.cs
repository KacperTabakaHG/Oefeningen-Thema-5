namespace Oef_2_tafel_van_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int teller = 1 ;
            int maal = 7;


            do
            {
                int antwoord = teller * maal;
                Console.WriteLine($"{teller} x {maal} = {antwoord}");
                teller++ ;
            } while (teller <= 10);
        }
    }
}