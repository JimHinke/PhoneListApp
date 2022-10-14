using System;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Xml.Linq;

namespace PhoneListApp
{
    class PhoneListApp
    {
        string fNamn;
        string eNamn;
        string adress;
        int telefonnummer;
        public int antalpersoner = 0;
        public int pos = 0;
        public PhoneListApp[] lista = new PhoneListApp[10];

        public PhoneListApp(string FNAMN, string ENAMN, string ADRESS, int TELEFONNUMMER)
        {
            fNamn = FNAMN;
            eNamn = ENAMN;
            adress = ADRESS;
            telefonnummer = TELEFONNUMMER;
        }
        public void run()
        {
            Console.WriteLine("Hej och välkommen till telefonlistan.");
            string command;
            do
            {
                Console.WriteLine("");
                Console.WriteLine("Skriv 'hjälp' för hjälp!");
                Console.WriteLine("1. Lägg till");
                Console.WriteLine("2. Ta bort");
                Console.WriteLine("3. Visa telefonlist");
                Console.WriteLine("4. Avsluta");
                command = Console.ReadLine();
                //if (command == "hjälp")
                //{
                //    Console.WriteLine($"Tyvärr ej implementerat!");
                //}
                if (command == "1")
                {
                    addPerson();

                }
                if (command == "2")
                {
                    Console.Clear();
                    removePerson();
                }
                if (command == "3")
                {
                    Console.Clear();
                    PrintAlla(lista);
                }
                else if (command == "4")
                {

                }
            } while (command != "4");
            Console.WriteLine("Hej då!");
        }
        public void addPerson()
        {
            Console.Clear();
            Console.WriteLine("Lägg till en person i telefonboken");
            Console.Write("Ange Förnamnamn: ");
            fNamn = Console.ReadLine();
            Console.Write("Ange Efternamn: ");
            eNamn = Console.ReadLine();
            Console.Write("Ange adress: ");
            adress = Console.ReadLine();
            Console.Write("Ange telefonnummer: ");
            telefonnummer = int.Parse(Console.ReadLine());
            lista[antalpersoner] = new PhoneListApp(fNamn, eNamn, adress, telefonnummer);
            antalpersoner++;
        }
        public void removePerson()
        {
            Console.Clear();
            Console.WriteLine("Vem vill du ta bort? ");
            Console.WriteLine("");
            for (int i = 0; i < antalpersoner; i++)
            {
                Console.Write(i + 1);
                lista[i].PrintForEfter();
            }
            antalpersoner--;
            Console.WriteLine("---------------------------------");
            Console.Write("Skriv en siffra: ");
            pos = int.Parse(Console.ReadLine()); //tog bort en int
            for (int i = pos - 1; i < lista.Length - 1; i++)
            {
                lista[i] = lista[i + 1];
            }

        }
        static void PrintAlla(PhoneListApp[] lista)
        {
            foreach (PhoneListApp element in lista)
            {
                if (element != null)
                {
                    element.Print();
                }
            }
        }
        public void Print() //kommentar
        {
            Console.WriteLine($"Namn: {fNamn} {eNamn}"); //kommentar2
            Console.WriteLine($"Adress: {adress}"); //Kommentar 3
            Console.WriteLine($"Telefonnummer: {telefonnummer}"); //kommentar 4
            Console.WriteLine(""); //kommentar 5 och 6
        }

        public void PrintForEfter()
        {
            Console.WriteLine($" Namn: {fNamn} {eNamn}");

        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var telefonlista = new PhoneListApp("", "", "", 0);
            telefonlista.run();
        }
    }
}