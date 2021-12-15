using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace UG6StringStreamsFiles
{
    public class FilHanterar
    {
        static string username = Environment.UserName.ToString();
        string path = @"C:\Users\" + username + @"\Documents\";
        public FilHanterar()
        {
            if (File.Exists(path + "AktivitetLoggfil.txt"))
            {
                File.Delete(path + "AktivitetLoggfil.txt");
            }
        }


        // denna metod sparar användarens aktiviteter
        public void LoggerIn(string aktivitet)
        {
            if (File.Exists(path + "AktivitetLoggfil.txt"))
            {
                using (StreamWriter streamWriter = File.AppendText(path + "AktivitetLoggfil.txt"))
                {
                    
                    string timeStamp = DateTime.Now.ToString();
                    streamWriter.WriteLine("TimeStamp: " + timeStamp + "\tAktivitet namn: " + aktivitet);
                    //streamWriter.WriteLine("TimeStamp: " + timeStamp);
                }
            }
            else // den drivar bara en gång att skappa fil
            {
                using (StreamWriter streamWriter = File.CreateText(path + "AktivitetLoggfil.txt"))
                {
                    string timeStamp = DateTime.Now.ToString();
                    streamWriter.WriteLine("TimeStamp: " + timeStamp + "\tAktivitet namn: " + aktivitet);
                }
            }
               
        }
        //output metod
        public void LoggerOut()
        {
            Console.Clear();
            Console.WriteLine("Aktivitet loggbok finns här ");
            string line = "";
            if (File.Exists(path + "AktivitetLoggfil.txt"))
            {
                using (StreamReader sr = new StreamReader(path + "AktivitetLoggfil.txt"))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            else
            {
                Console.WriteLine("Filen är bortaget.");
            }
            
        }
    }
}

