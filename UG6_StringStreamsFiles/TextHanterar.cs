using System;
using System.Collections.Generic;
using System.Text;

namespace UG6StringStreamsFiles
{
    public class TextHanterar
    {
        string sampleText = "Programkod skriven i C# omvandlas av en kompilator till så " +
                "kallad CIL-kod (tidigare kallad MSIL-kod), \nvilket är en sorts " +
                "bytekod vilken sedan körs i en virtuell maskin, \nCLR (Common Language Runtime). ";
        public void RepeatMetod()
        {
            
            Console.WriteLine(sampleText.ToString());
            Console.WriteLine("\n1\tToUpper() \n2\tToLowerr()\n3\tIndexOf()\n4\tSubString()" +
                        "\n5\tRemove()\n6\tReplace()\n7\tSplit()");
        }
        public string VanligaMetod(int input)
        {
            
            string tempString1, tempString2, loggInfo;
            int tempInt1, tempInt2;
            char tempChar='z';
            
            switch (input)
            {
                case 1: //ToUpper()
                    Console.WriteLine(sampleText.ToUpper());
                    loggInfo = "ToUpper()";
                    break;
                case 2: //ToLower() 
                    Console.WriteLine(sampleText.ToLower());
                    loggInfo = "ToLower()"; 
                    break;
                case 3: // IndexOf()
                    Console.WriteLine("Vänlingen ange en karaktär!");
                    tempChar = char.Parse(Console.ReadLine());
                    Console.WriteLine( "Karaktär '"+ tempChar +"' först kommit på " + sampleText.IndexOf(tempChar,0) + " index");
                    loggInfo = "IndexOf()";
                    break;
                case 4: //SubString()
                    Console.WriteLine("Vänlingen ange två parameter för att få en substring");
                    tempInt1 = int.Parse(Console.ReadLine());
                    tempInt2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Substring ->\""+ sampleText.Substring(tempInt1,tempInt2)+ "\"");
                    loggInfo = "SubString()";
                    break;
                case 5: //Remove() 
                    Console.WriteLine("Vänlingen ange två parameter för att ta bort en substring");
                    tempInt1 = int.Parse(Console.ReadLine());
                    tempInt2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Den här texten har tagit bort \n" + sampleText.Substring(tempInt1,tempInt2) + "\n");
                    Console.WriteLine(sampleText.Remove(tempInt1,tempInt2));
                    loggInfo = "Remove()";
                    break;
                case 6: //Replace()
                    Console.WriteLine("Vänlingen skriv din sträng för att byta ut [som versal] i sample text");
                    tempString1 = Console.ReadLine();
                    tempString2 = Console.ReadLine();
                    Console.WriteLine(sampleText.Replace(tempString1,tempString2.ToUpper()));
                    loggInfo = "Replace()";
                    break;
                case 7: //Split()
                    Console.WriteLine("Speciel karaktär tar bor med Split() metod");
                    string[] separators = { ",", ".", "!", "?", ";", ":", " " };
                    string[] words = sampleText.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                    foreach (var word in words)
                    {
                        Console.WriteLine(word.ToString());
                    }
                    loggInfo = "Split()";
                    break;
                default:
                    Console.WriteLine("Ogiltig input");
                    loggInfo = "Ogiltig input";
                    break;
            }
            return loggInfo;
        }
    }
}
