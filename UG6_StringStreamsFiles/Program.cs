using System;

namespace UG6StringStreamsFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            TextHanterar textHanterar = new TextHanterar();
            while (flag)
            {
                Console.WriteLine("* Text hantering *");
                textHanterar.RepeatMetod();

                int enSiffra =0;                
                Console.WriteLine("Vänlingen välja en siffra {1 - 7} för utföra en sträng metod.");
                enSiffra = int.Parse(Console.ReadLine());
                if (enSiffra<=7 && enSiffra>=1)
                {
                    textHanterar.VanligaMetod(enSiffra);
                }

                // skapar logg i en fil

                Console.WriteLine("\nVill du stänga program tryck X, forstätta tryck enter.");
                string stopp = Console.ReadLine();
                if (stopp == "x"|| stopp == "X")
                {
                    flag = false;
                }
                Console.Clear();
            }



        }
    }
}
