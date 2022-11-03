namespace Oef_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int getal;
            int som = 0;
            string getalAlsTekst;
            bool geenStopIngetypt; // (1)
            do
            {
                getalAlsTekst = Console.ReadLine();

                geenStopIngetypt = (getalAlsTekst.Trim().ToUpper() != "STOP"); // (1)

                bool invoerOk = int.TryParse(getalAlsTekst, out getal);
                if (invoerOk)
                {
                    // gebruiker een getal heeft ingetypt
                    som += getal;
                    Console.WriteLine("+");
                }
                else if (geenStopIngetypt) // (1)
                {
                    // andere tekst ingetypt
                    Console.WriteLine("Gelieve een geheel getal in te voeren (of STOP om te stoppen).");

                }
            } while (geenStopIngetypt); // (1)

            Console.WriteLine("=");
            Console.WriteLine(som);






        }
    }
}