using System.Diagnostics.Metrics;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Channels;

namespace ROT13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var counter = 1;

            while (counter == 1)
            {
                string propt = @"
                 /$$$$$$$              /$$             /$$    /$$$$$$       /$$ /$$   /$$ /$$$$$$$$
                | $$__  $$            | $$           /$$$$   /$$__  $$     /$$/| $$  | $$|_____ $$/
                | $$  \ $$  /$$$$$$  /$$$$$$        |_  $$  |__/  \ $$    /$$/ | $$  | $$     /$$/ 
                | $$$$$$$/ /$$__  $$|_  $$_/          | $$     /$$$$$/   /$$/  | $$$$$$$$    /$$/  
                | $$__  $$| $$  \ $$  | $$            | $$    |___  $$  /$$/   |_____  $$   /$$/   
                | $$  \ $$| $$  | $$  | $$ /$$        | $$   /$$  \ $$ /$$/          | $$  /$$/    
                | $$  | $$|  $$$$$$/  |  $$$$/       /$$$$$$|  $$$$$$//$$/           | $$ /$$/     
                |__/  |__/ \______/    \___/        |______/ \______/|__/            |__/|__/     

                                    Welchen Rot wollen sie En oder Decoden?
";
                
            var converter = new Decoder();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(propt);
            Console.ForegroundColor = ConsoleColor.White;

            Thread.Sleep(1000);
            Console.WriteLine();
            Console.WriteLine("[1] Rot13 (nur buchstaben)");
            Console.WriteLine("[2] Rot47 (sonderzeichen Buchstaben und Zahlen)");
            Console.WriteLine("[3] Was ist ein Rot?");
            Console.WriteLine("[4] Exit");

            Console.WriteLine();
            Console.Write("Eingabe: ");
            var eg = Console.ReadLine();

            int abc = Int32.Parse(eg);
            Thread.Sleep(800);

            Console.Write("Loading...");

            Thread.Sleep(2000);
            Console.Clear();

                if (abc == 1)
                {
                    Console.Write("Eingabe: ");
                    var eingabe = Console.ReadLine();
                    var t1 = converter.Rot13(eingabe);
                    Console.WriteLine("Dein Ergebnis Lautet: " + t1);
                    Thread.Sleep(2000);
                    Console.WriteLine();
                    Console.WriteLine("Möchten sie etwas anderes En oder Decoden?");
                    Console.WriteLine("[1] für Ja");
                    Console.WriteLine("[2] um das Programm zu Beenden");
                    string goback = Console.ReadLine();
                    int gobackint = int.Parse(goback);

                    if (gobackint == 1)
                    {
                        
                        Console.WriteLine("Sie können in 5 Sekunden ihre Eingabe Erneuern!");


                        Thread.Sleep(5000);
                        Console.Clear();

                    }

                    if (gobackint == 2)
                    {
                        Console.WriteLine("Das Programm wird in wenigen Sekunden geschlossen!");
                        Thread.Sleep(4000);
                        counter = 0;
                        return;
                    }
                    else
                    {
                        Console.Clear();
                    }

                }

                if (abc == 2)
                {

                    Console.Write("Eingabe: ");
                    var eingabe = Console.ReadLine();
                    var t2 = converter.Rot47(eingabe);
                    Console.WriteLine("Dein Ergebnis Lautet: " + t2);
                    Thread.Sleep(3000);

                    Console.WriteLine();
                    Console.WriteLine("Möchten sie etwas anderes En oder Decoden?");
                    Console.WriteLine("[1] für Ja");
                    Console.WriteLine("[2] um das Programm zu Beenden");
                    
                    string goback = Console.ReadLine();
                    int gobackint = int.Parse(goback);

                    if (gobackint == 1)
                    {
                        ;
                        Console.WriteLine("Sie können in 5 Sekunden ihre Eingabe Erneuern!");
                    
                    
                    Thread.Sleep(5000);
                    Console.Clear();

                    }

                    if (gobackint == 2)
                    {
                        Console.WriteLine("Das Programm wird in wenigen Sekunden geschlossen!");
                        Thread.Sleep(4000);
                        counter = 0;
                        return;
                    }
                    else
                    {
                        Console.Clear();
                    }

                }

                if (abc == 3)
                {
                    Console.WriteLine(
                        "ROT13 ist eine Caesar-Verschlüsselung, mit der auf einfache Weise Texte verschlüsselt werden können.");

                    Console.WriteLine("Der unterschied Zwischen den Beiden liegt in der Verschiebung Rot13 arbeitet mit einer 13 als\nverschiebung und Rot47 mit einer 47 und mehr Zeichen."+
                                      "Dazu besitzt Rot 13 nur Buchstaben und\nRot47 Zahlen, Buchstaben und Sonderzeichen.");
                    Thread.Sleep(3000);
                    Console.WriteLine();
                    Console.ReadKey();
                    Console.WriteLine("Möchten sie etwas anderes En oder Decoden?");
                    Console.WriteLine("[1] für Ja");
                    Console.WriteLine("[2] um das Programm zu Beenden");

                    string goback = Console.ReadLine();
                    int gobackint = int.Parse(goback);

                    if (gobackint == 1)
                    {
                        ;
                        Console.WriteLine("Sie können in 5 Sekunden ihre Eingabe Erneuern!");


                        Thread.Sleep(5000);
                        Console.Clear();

                    }
                    else
                    {
                        Console.Clear();
                    }

                    if (gobackint == 2)
                    {
                        Console.WriteLine("Das Programm wird in wenigen Sekunden geschlossen!");
                        Thread.Sleep(4000);
                        counter = 0;
                        return;
                    }
                }

                if (abc == 4)
                {
                    return;
                }


            }



        }

    }
}