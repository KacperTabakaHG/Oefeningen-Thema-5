namespace Oef_13_Driehoek
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.Write("Rechthoekzijde?: ");
            int zijde = int.Parse(Console.ReadLine());
            int teller = 0;
            do
            {

                teller++;
                int tellerTwee = zijde;
                do
                {
                    Console.Write("*");
                    tellerTwee--;
                }while (tellerTwee >= teller);
                Console.WriteLine();
                
                

            }while(teller != zijde);
        }
    }
}