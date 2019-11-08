using System;
using System.Collections.Generic;
using System.Threading;

namespace TravelOffice
{
    class TravelOffice
    {

        static public customer addCustomer()
        {
            int rok = 0;
            int miesiac = 0;
            int dzien = 0;
            string kod;
            string ulica;
            string miasto;
            string imieinazwisko;
            string cel;


            Console.WriteLine("Jak się nazywasz?");
            imieinazwisko = Console.ReadLine();
            Console.WriteLine("Podaj ulicę");
            ulica = Console.ReadLine();
            Console.WriteLine("Podaj kod pocztowy");
            kod = Console.ReadLine();
            Console.WriteLine("Podaj Miejscowość");
            miasto = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Podaj cel podróży");
            cel = Console.ReadLine();
            Console.WriteLine("Podaj datę rozpoczecia podróży(W kolejności rok>miesiąc>dzień, po wpisaniu każdego naciśnij 'Enter'");
            try
            {
                rok = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Nie podałeś liczby \n" + e);
            }
            try
            {
                miesiac = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Nie podałeś liczby \n" + e);
            }
            try
            {
                dzien = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Nie podałeś liczby \n" + e);
            }
            date start = new date(rok, miesiac, dzien);
            Console.Clear();
            Console.WriteLine("Podaj datę zakończenia podróży(W kolejności rok>miesiąc>dzień, po wpisaniu każdego naciśnij 'Enter'");
            try
            {
                rok = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Nie podałeś liczby \n" + e);
            }
            try
            {
                miesiac = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Nie podałeś liczby \n" + e);
            }
            try
            {
                dzien = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Nie podałeś liczby \n" + e);
            }
            date end = new date(rok, miesiac, dzien);
            Console.Clear();

            address adresklienta = new address(kod, miasto, ulica);
            customer klient = new customer(imieinazwisko);
            trip tripkilenta = new trip(start, end, cel);
            klient.setAddress(adresklienta);
            klient.setTrip(tripkilenta);
            Console.Clear();
            return klient;
        }
        enum Menu { NowyKlient = 1, Raport = 2, Informacje, Wyjście };
        static void Main(string[] args)
        {

            List<customer> Lista = new List<customer>();
            bool powrotdomenu = true; ;
            while (powrotdomenu)
            {
                Console.Clear();
                Menu operacje;
                Console.WriteLine("Witaj w symulatorze podróży, wybierz jedną z opcji");
                Console.WriteLine("1-Utworzenie nowego klienta");
                Console.WriteLine("2-Liczba utworzonych klientów");
                Console.WriteLine("3-Informacje o wszystkich klientach");
                Console.WriteLine("4-Wyjście");

                bool czypoprawna = Enum.TryParse<Menu>(Console.ReadLine(), out operacje);

                if (!czypoprawna)
                {
                    Console.WriteLine("Niepoprawne dane");
                }

                switch (operacje)
                {
                    case Menu.NowyKlient:
                        Lista.Add(addCustomer());
                        Console.WriteLine("Nowy użytkownik został utworzony");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case Menu.Raport:
                        Console.WriteLine("Liczba osób korzystających z naszych usług wynosi " + Lista.Count);
                        Console.ReadKey();
                        break;
                    case Menu.Informacje:
                        for (int i = 0; i < Lista.Count; i++)
                        {
                            Console.WriteLine(Lista[i].getinfo());
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("");

                        }
                        Console.ReadKey();
                        break;
                    case Menu.Wyjście:
                        Console.WriteLine("Zapraszamy ponownie :)");
                        powrotdomenu = false;
                        break;
                }
            }
        }
    }
}