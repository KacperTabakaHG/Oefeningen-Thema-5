namespace Oef_7_Rechthoek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hoogte?: ");
            int hoogte = int.Parse(Console.ReadLine());
            int hoogteTeller = 0;

            Console.Write("Breedte?: ");
            int breedte = int.Parse(Console.ReadLine());
            
            do
            {
                int breedteTeller = 0; //reset van getal
                do
                {
                    Console.Write("*");
                    breedteTeller++;
                }while (breedteTeller < breedte );  
                
                Console.WriteLine(); // Naar nieuwe lijngaat
                hoogteTeller++;


            } while (hoogteTeller < hoogte);
           


            
               

            
        }
    }
}