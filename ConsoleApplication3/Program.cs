using System;

namespace ConsoleApplication3
{
    
    class Programa2Exemplo
    {

        public static void Main(string[] args)
        {

            if (DateTime.Now.Hour >= 6 && DateTime.Now.Hour <= 12)
            {
                Console.WriteLine("Bom dia");
            } else if (DateTime.Now.Hour > 12 && DateTime.Now.Hour < 20)
            {
                Console.WriteLine("Boa tarde");
            } else if (DateTime.Now.Hour >= 20 && DateTime.Now.Hour < 6)
            {
                Console.WriteLine("Boa noite");
            }
        }
    }
}