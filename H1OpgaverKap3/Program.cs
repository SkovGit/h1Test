using System;

namespace H1OpgaverKap3
{
    class MainClass
    {
        enum Ugedage : byte {Søndag, Mandag, Tirsdag, Onsdag, Torsdag, Fredag, Lørdag }

        enum BeerType
        {
            Lager,
            Pilsner,
            Münchener,
            Wiener,
            Dortmunder,
            Bock,
            DobbelBock,
            Porter
        }

        struct Beer
        {
            public string Fabrikant;
            public BeerType Type;
            public double AlcProcent;
            public int Volumen;

            
        }

        static string input;

        

        static void ErDetWeekend(Ugedage ugedage)
        {
            switch (ugedage)
            {
                case Ugedage.Mandag:
                    
                case Ugedage.Tirsdag:
                    
                case Ugedage.Onsdag:
                    
                case Ugedage.Torsdag:
                    
                case Ugedage.Fredag:
                    
                case Ugedage.Lørdag:
                    Console.WriteLine("Det er Weekend");
                    break;
                case Ugedage.Søndag:
                    Console.WriteLine("Det er Weekend");
                    break;
                default:
                    break;
            }
            

        }
        static void UdskrivBeer(Beer beer)
        {
            
            foreach (var prop in beer.GetType().GetFields())
            {
                Console.WriteLine(prop.Name +": "+ prop.GetValue(beer));
            }
        }

        public static void Main(string[] args)
        {

            //foreach (Ugedage item in Enum.GetValues(typeof(Ugedage)))
            //{
            //    Console.WriteLine(item + " har værdien: " + (int)item);

            //}
            //foreach (DayOfWeek item in Enum.GetValues(typeof(DayOfWeek)))
            //{
            //    Console.WriteLine(item + "Value: " + (int)item);
            //}
            //Ugedage ud = (Ugedage)0;
            //do
            //{
            //    try
            //    {
            //        Console.Write("indtast en ugedag: ");
            //        ud = (Ugedage)Enum.Parse(typeof(Ugedage), Console.ReadLine());
            //    }
            //    catch (ArgumentException ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }
            //} while (ud < Ugedage.Søndag || ud > Ugedage.Lørdag);
            ////Console.WriteLine(ErDetWeekend());

            Beer beer1 = new Beer
            {
                Fabrikant = "Albani",
                Type = BeerType.Pilsner,
                Volumen = 330,
                AlcProcent = 4.6
            };

            Beer beer2 = new Beer
            {
                Fabrikant = "Tuborg",
                Type = BeerType.Lager,
                Volumen = 330,
                AlcProcent = 5.2
            };

            Console.WriteLine(nameof(beer1));
            UdskrivBeer(beer1);
            Console.WriteLine(nameof(beer2));
            UdskrivBeer(beer2);

            

        }
    }
}
