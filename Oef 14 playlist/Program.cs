namespace Oef_14_playlist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Aantal liedjes in de playlist?: ");
            string aantalLiedjesAlsTekst = Console.ReadLine();

            int aantalLiedjes;
            bool invoerOk = int.TryParse(aantalLiedjesAlsTekst, out aantalLiedjes);

            if (invoerOk && aantalLiedjes >= 1)
            {
                int faculteit;
                int teller = 2;
                faculteit = 1;
                while (teller <= aantalLiedjes)
                {
                    faculteit = faculteit * teller;
                    teller = teller + 1;
                }



                string meervoud = "";
                if (faculteit > 1)
                {
                    meervoud = "s";
                }
                Console.Write($"{aantalLiedjes} liedje{meervoud} kan je in {faculteit} verschillende volgorde{meervoud} in een playlist plaatsen.");
            }
        }
    }
}