namespace Exempel11
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            //Övning 11.1
            string name = "Gustav"; //Initierar variablen name och sätter dess värde
            
            Hello(name); //Anropar metoden Hello och ger den parametern name

            //Övning 11.2
            string firstSentence = "Hej din gamle galosh!"; //Initierar variablen firstSentence och sätter dess värde
            string secondSentence = "Hur mår du? "; //Initierar variablen secondSentence och sätter dess värde

            string result = AddString(firstSentence, secondSentence); //Initierar variablen result och genom att anropa metoden AddString med dess parametrar så får vi värdet som vi sparar
            Console.WriteLine(result);

            
            //Övning 11.3
            int firstNumber = 10; //Initierar variablen och sätter dess värde
            int secondNumber = 20; //Initierar variablen och sätter dess värde

            int adderaResult = Addera(firstNumber, secondNumber); //Initierar variablen adderaResult. Värdet vi sparar får vi genom att anropa metoden Addera
            Console.WriteLine(adderaResult); //Skriver ut variablen adderaRsultat 


            //Övning 11.4
            double betalning = 100; //Initierar variablen och sätter dess värde
            double betalningResult = Moms(betalning); //Initierar variablen betalningResult och sätter det till svaret från metoden Moms
            Console.WriteLine(betalningResult); //Skriver ut variablen betalningResult

            //Övning 11.5
            double momssats = 1.25; //initierar variablen momssats till 1.25
            double betalningResultat2 = Momstvå(betalning, momssats); //Initierar variablen betalningResult2 och sätter det till svaret från metoden Moms2
            Console.WriteLine(betalningResultat2); //Skriver ut betalningResultat2

            //Övning 11.6
            double toProcent = 0.25; //Initierar variablen toProcent och sätter dess värde
            int toPercentageResult = ToPercentage(toProcent); //intitierar variablen toPercentageResult till resultatet av metoden ToPercentage
            Console.WriteLine(toPercentageResult); //Skriver ut variablen toPercentageResult

            //Övning 11.7
            int age = 18; //Initierar och sätter värdet på variablen age
            bool myndigResult = Myndig(age); //intierar variablen myndigResult till resultatet av metoden Myndig

            if (myndigResult == true) //Om variablen har värdet true
            {
                Console.WriteLine("Grattis, du är myndig! :)"); //Skriv ut detta 
            }
            else //Om variablen inte har värdet false
            {
                Console.WriteLine("Tyvärr, du är inte myndig än :("); //Skriv ut detta
            }

            //Övning 11.8
            SkapaEnMeny();
        }

        static void Hello(string name) //Övning 11.1 
        {
            Console.WriteLine("Hello " + name); //Skriver ut "Hello " och värdet som variabel namn har.  
        }

        static string AddString(string firstSentence, string secondSentence) //Övning 11.2
        {
            string addedStrings = firstSentence + " " + secondSentence; //initierar och sätter string 
            return addedStrings; //Returnerar variablen addedStrings
            
        }

        static int Addera(int firstNumber, int secondNumber) //Övning 11.3
        {
            int sum = firstNumber + secondNumber; //initierar variablen sum och ger den värdet firstNumber + secondNumber
            return sum; //Returnerar sum 
        }

        static double Moms(double betalning) //Övning 11.4
        {
            betalning *= 1.25; //sätter värdet av variablen betalning till gånger 1.25
            return betalning; //returnerar betalning 

        }

        static double Momstvå(double betalning, double momssats) //Övning 11.5
        {
            betalning *= momssats; //sätter värdet av variablen betalning till värdet på vairablen momssats
            return betalning; //returnerar betalning 

        }

        static int ToPercentage(double toProcent) //Övning 11.6
        {
            int fromDeciaml = Convert.ToInt32(toProcent * 100);
            return fromDeciaml;
        }

        static bool Myndig(int myndigAge) //Övning 11.7
        {
            if (myndigAge >= 18) //OM myndigAge är större än eller likamed 18
            {
                return true; //returnera true
            }
            else //annars
            {
                return false; //returnera false
            }
        }

        static void SkapaEnMeny() //Övning 11.8
        {
            while (true)
            {
                Console.WriteLine("Välj ett alternativ i menyn nedan: ");
                Console.WriteLine("- - - - - - - - - - - - - - - - -");
                Console.WriteLine("[H]ello");
                Console.WriteLine("[A]ddera");
                Console.WriteLine("[K]ontrollera Moms");
                Console.WriteLine("[D]ecimal till Procent");
                Console.WriteLine("[Q]uit\n");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "H":
                        Console.WriteLine("Skriv in ditt namn :)");
                        string? name = Console.ReadLine();
                        Hello(name);
                        break;

                    case "A":
                        Console.WriteLine("Mata in de två siffror du vill addera");
                        Console.WriteLine("Tal 1: ");
                        int tal1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Tal 2: ");
                        int tal2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(Addera(tal1, tal2));
                        break;

                    case "K":
                        Console.WriteLine("Mata in vad du ska betala för att räkna ut momsen: ");
                        double betalning = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(Moms(betalning));
                        break;

                    case "D":
                        Console.WriteLine("Mata in decimaltalet du vill omvandla till procent: ");
                        int procent = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(ToPercentage(procent));
                        break;

                    case "Q":
                        Console.WriteLine("Programmet avslutas, ses nästa gång :)");
                        return;

                    default:
                        Console.WriteLine("Felaktig input, försök igen");
                        break;
                }
            }
        }
    }
}