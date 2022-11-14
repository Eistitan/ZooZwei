using System.Diagnostics.Contracts;

namespace ZooZwei
{
    internal class Program
    {
        static void Main(string[] args)
        {
           SW1();
        }
        static int Eingabe() //Eingabe der Zahl
        {
            int wahl = 0;
            bool check;
            do
            {
                Console.WriteLine("Wählen sie ein Tier:");
                Console.WriteLine(" 1.Pferd\n 2.Tiger\n 3.Schildkröte\n 4.Storch\n 5.Gans");
                check = int.TryParse(Console.ReadLine(), out wahl);
                if (!check)
                    Console.WriteLine("Nur die Ziffern eingeben.\n");
                if ((check && wahl < 1) || (check && wahl > 5))
                {
                    Console.WriteLine("Sie haben sich verklickt.\n");
                    check = false;
                }
            } while (!check);
            return wahl;
        }
        public static string Menu2()
        {
            Console.WriteLine("Eine gute Wahl.");
            Console.WriteLine("Möchten sie die Beschreibung(A) oder den Weg(B) zum Gehege sehen?");
            string menu = Console.ReadLine().ToLower();
            return menu;
        }
        public static void SW1()
        {   //Erstellung der Objekte auslagern? Schutzgrad
            mammal pferd = new("Hans", "Horsus schnellus", 4, false, true, "rot", false, "auf der Weide", "B-7");
            mammal tiger = new("Rappu", "Tigrus altus", 4, false, true, "gestreift", true, "im Tiger-Dome", "K-2");
            reptile schildkroete = new("Leonardo", "Ninja turtle", 4, false, false, "grün", false, "in der Kanalisation", "S-1");
            vogel storch = new("Bomber", "Langbeinus entus", 2, true, false, "grau", false, "auf dem Chimney", "U-8");
            vogel gans = new("Verwüster", "Gansus enormus", 2, true, false, "blutrot", true, "in der Mensa", "M-3");

            int wahl =Eingabe();
            string menu = Menu2(); //<<<
            switch (wahl,menu)
            {
                case (1,"a"):
                       pferd.Beschreibung();
                    break;
                    case (1,"b"):
                        pferd.Wegbeschreibung(); 
                    break;
                case (2,"a"):
                        tiger.Beschreibung();
                    break;
                    case (2,"b"):
                        tiger.Wegbeschreibung();
                    break;
                case (3,"a"):
                        schildkroete.Beschreibung();
                    break;
                case (3, "b"):
                        schildkroete.Wegbeschreibung();
                    break;
                case (4,"a"):
                        storch.Beschreibung();
                    break;
                case (4, "b"):
                        storch.Wegbeschreibung();
                    break;
                case (5,"a"):
                        gans.Beschreibung();
                    break;
                case (5, "b"):
                        gans.Wegbeschreibung();
                    break;
                default:
                    Console.WriteLine("Sie haben sich verklickt, wieder.");
                    break;
            }
        }
    }
}