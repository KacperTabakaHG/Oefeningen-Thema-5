namespace Oef_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int getalEen = int.Parse(Console.ReadLine());
            string opeRator = Console.ReadLine();
            
            
            while (opeRator != "=")
            {
                int getal = int.Parse(Console.ReadLine());
                
                if (opeRator == "+")
                {
                    getalEen = getalEen + getal;
                } else if (opeRator == "-")
                {
                    getalEen = getalEen - getal;
                }
                
                opeRator = Console.ReadLine();
            }
            Console.WriteLine(getalEen);
        }
    }
}