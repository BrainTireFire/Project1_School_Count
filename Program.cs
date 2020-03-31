using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Projekt1_Kawęcki49105
{
    class Program
    {
        // Zmienna potrzebna do wyboru opcji menuItem
        private static int mkIndex = 0;

        private static void Main(string[] args)
        {
            Console.WriteLine("\t\t Projekt1_Kawęcki49105 umożliwia wielokrotne obliczanie wybranych wielkości matematycznych");
            Console.WriteLine("\t\t Zaprojektowal Maciej Kawęcki Nr. Albumu 49105");
            Console.WriteLine("\n\t\t Spis przycisków: \n\t\t\t* Góra - Strzałka w Góre   \n\t\t\t* Dół - Strzałka w dół \n\t\t\t* potwierdz wybor - Enter");
            Console.WriteLine("\n\t\t Aby zaczać nacisnij dowolny klawisz! ");
            Console.ReadKey();
            Console.Clear();

            //Lista potrzebna do menu wyboru
            List<string> mkMenuItems = new List<string>() // mkMenuItems zbior czynnosci w menu
            {
                "Obliczenie sumy <in-line>",
                "Obliczenie sumy <method-call>",
                "Obliczenie iloczynu <in-line>",
                "Obliczenie iloczynu <method-call>",
                "Obliczenie średniej arytmetycznej <in-line>",
                "Obliczenie średniej arytmetycznej <method-call>",
                "Obliczenie średniej ważonej <in-line>",
                "Obliczenie średniej ważonej <method-call>",
                "Obliczenie cena jednostki paszy <in-line>",
                "Obliczenie cena jednostki paszy <method-call>",
                "Obliczenie średniej harmonicznej <in-line>",
                "Obliczenie średniej harmonicznej <method-call>",
                "Obliczenie średniej geometrycznej <in-line>",
                "Obliczenie średniej geometrycznej <method-call>",
                "Obliczenie średniej kwadratowej <in-line>",
                "Obliczenie średniej kwadratowej <method-call>",
                "Obliczenie średniej potęgowej <średniej uogólnionej> <in-line>",
                "Obliczenie średniej potęgowej <średniej uogólnionej> <method-call>",
                "Zakończenie <wyjście z> programu"
            };

            //Petla do menu zeby mozna ciagle wybierac opcje
            while (true)
            {
                // Zmienna z wyborem czynnosci z menu
                string mkSelectMenuItem = mkdrawMenu(mkMenuItems);

                //SWITCH DO WYBORU METHOD CALL, tak dla odmiany, poniewaz mam dosc if :]
                switch(mkSelectMenuItem)
                {
                    case "Obliczenie sumy <method-call>":
                        mkSuma();
                    break;

                    case "Obliczenie iloczynu <method-call>":
                        mkIloczyn();
                    break;

                    case "Obliczenie średniej arytmetycznej <method-call>":
                        mkSredniaArytmetyczna();
                    break;

                    case "Obliczenie średniej ważonej <method-call>":
                        mkSredniaWazona();
                    break;

                    case "Obliczenie cena jednostki paszy <method-call>":
                        mkJednsotkaPaszy();
                    break;

                    case "Obliczenie średniej harmonicznej <method-call>":
                        mkSredniaHarmoniczna();
                    break;

                    case "Obliczenie średniej geometrycznej <method-call>":
                        mkSredniaGeometryczna();
                    break;

                    case "Obliczenie średniej kwadratowej <method-call>":
                        mkSredniaKwadratowa();
                    break;

                    case "Obliczenie średniej potęgowej <średniej uogólnionej> <method-call>":
                        mkSredniaPotegowa();
                    break;
                }

                //LICZENIE SUMY in-line
                if (mkSelectMenuItem == "Obliczenie sumy <in-line>")
                {
                    Console.Clear();
                    //Deklaracje lokalynych zmiennych
                    int mkIle = 0;
                    float mkSuma = 0.0F;
                    float[] mkLiczby;

                    Console.WriteLine("\t\tOBLICZANIE SUMA");
                    //WPISYWANIE ilosc liczb w średni arytmetycznej ze sprawdzenie czy inny znak wystapil
                    Console.WriteLine("\nProszę podac ciag liczb do obliczenia iloczynu");
                    while (!int.TryParse(Console.ReadLine(), out mkIle))
                    {
                        Console.WriteLine("ERROR: wystapił niedozwolony znak w zapisanie pierwszej wartości");
                        Console.WriteLine("Proszę wpisać ponownie wartość: ");
                    }

                    //DEKLAROWANIE TABLICY
                    mkLiczby = new float[mkIle];

                    //WPISYWANIE LICZB DO TABLICY ze sprawdzenie czy inny znak wystapil
                    for (int i = 0; i < mkIle; i++)
                    {
                        Console.WriteLine("\nProszę wpisac " + (i + 1) + " liczbę: ");
                        while (!float.TryParse(Console.ReadLine(), out mkLiczby[i]))
                        {
                            Console.WriteLine("ERROR: wystapił niedozwolony znak w zapisanie pierwszej wartości");
                            Console.WriteLine("Proszę wpisać ponownie wartość " + (i + 1) + ":");
                        }
                    }

                    // Liczenie średniej arytmetycznej
                    for (int a = 0; a < mkLiczby.Length; a++)
                    {
                        mkSuma += mkLiczby[a];
                    }

                    //SPRAWDZANIE CZY mkILe ma jakas wartosc
                    if (mkIle == 0)
                    {
                        Console.WriteLine("Musisz podac przynajmniej jedna wartosc!");
                        Console.WriteLine("\nNacisnij dowolny klawisz by wrocic do menu.");
                    }
                    else
                    {
                        //OBLICZANIE ILOCZYNU W RAZ Z WYSWIETLENIEM
                        Console.WriteLine("Suma wynosi: " + mkSuma);
                        Console.WriteLine("\nNacisnij dowolny klawisz by wrocic do menu.");
                    }

                    Console.ReadKey();
                    Console.Clear();
                }

                //LICZENIE ILOCZYNU in-line
                if (mkSelectMenuItem == "Obliczenie iloczynu <in-line>")
                {
                    Console.Clear();
                    //Deklaracje lokalynych zmiennych
                    int mkIle = 0;
                    float mkIloczyn = 1.0F;
                    float[] mkLiczby;

                    Console.WriteLine("\t\tOBLICZANIE ILOCZYNU");
                    //WPISYWANIE ilosc liczb w średni arytmetycznej ze sprawdzenie czy inny znak wystapil
                    Console.WriteLine("\nProszę podac ciag liczb do obliczenia iloczynu");
                    while (!int.TryParse(Console.ReadLine(), out mkIle))
                    {
                        Console.WriteLine("ERROR: wystapił niedozwolony znak w zapisanie pierwszej wartości");
                        Console.WriteLine("Proszę wpisać ponownie wartość: ");
                    }

                    //DEKLAROWANIE TABLICY
                    mkLiczby = new float[mkIle];

                    //WPISYWANIE LICZB DO TABLICY ze sprawdzenie czy inny znak wystapil
                    for (int i = 0; i < mkIle; i++)
                    {
                        Console.WriteLine("\nProszę wpisac " + (i + 1) + " liczbę: ");
                        while (!float.TryParse(Console.ReadLine(), out mkLiczby[i]))
                        {
                            Console.WriteLine("ERROR: wystapił niedozwolony znak w zapisanie pierwszej wartości");
                            Console.WriteLine("Proszę wpisać ponownie wartość " + (i + 1) + ":");
                        }
                    }

                    // Liczenie średniej arytmetycznej
                    for (int a = 0; a < mkLiczby.Length; a++)
                    {
                        mkIloczyn *= mkLiczby[a];
                    }

                    //SPRAWDZANIE CZY mkILe ma jakas wartosc
                    if (mkIle == 0)
                    {
                        Console.WriteLine("Musisz podac przynajmniej jedna wartosc!");
                        Console.WriteLine("\nNacisnij dowolny klawisz by wrocic do menu.");
                    }
                    else
                    {
                        //OBLICZANIE ILOCZYNU W RAZ Z WYSWIETLENIEM
                        Console.WriteLine("Iloczyn wynosi: " + mkIloczyn);
                        Console.WriteLine("\nNacisnij dowolny klawisz by wrocic do menu.");
                    }

                    Console.ReadKey();
                    Console.Clear();
                }

                //LICZENIE SREDNIEJ ARYTMETYCZNEJ in-line
                if (mkSelectMenuItem == "Obliczenie średniej arytmetycznej <in-line>")
                {
                    Console.Clear();
                    //Deklaracje lokalynych zmiennych
                    int mkIle=0;
                    float mkSrednia = 0.0F;
                    float[] mkLiczby;                  

                    Console.WriteLine("\t\tOBLICZANIE ŚREDNIEJ ARYTMETYCZNEJ");
                    //WPISYWANIE ilosc liczb w średni arytmetycznej ze sprawdzenie czy inny znak wystapil
                    Console.WriteLine("\nProszę podac ilosc liczb w średni arytmetycznej, która chesz obliczyć ");
                    while (!int.TryParse(Console.ReadLine(), out mkIle))
                    {
                        Console.WriteLine("ERROR: wystapił niedozwolony znak w zapisanie pierwszej wartości");
                        Console.WriteLine("Proszę wpisać ponownie wartość: ");
                    }

                    //DEKLAROWANIE TABLICY
                    mkLiczby = new float[mkIle];

                    //WPISYWANIE LICZB DO TABLICY ze sprawdzenie czy inny znak wystapil
                    for (int i = 0; i < mkIle; i++)
                    {
                        Console.WriteLine("\nProszę wpisac " + (i+1) + " liczbę: ");
                        while (!float.TryParse(Console.ReadLine(), out mkLiczby[i]))
                        {
                            Console.WriteLine("ERROR: wystapił niedozwolony znak w zapisanie pierwszej wartości");
                            Console.WriteLine("Proszę wpisać ponownie wartość " + (i+1) + ":");
                        }         
                    }

                    // Liczenie średniej arytmetycznej
                    for (int a = 0; a < mkLiczby.Length; a++)
                    {
                        mkSrednia += mkLiczby[a];
                    }

                    mkSrednia /= mkIle;

                    //SPRAWDZANIE CZY mkILe ma jakas wartosc
                    if (mkIle==0)
                    {
                        Console.WriteLine("Musisz podac przynajmniej jedna wartosc!");
                        Console.WriteLine("\nNacisnij dowolny klawisz by wrocic do menu.");
                    }else
                    {
                    //OBLICZANIE ILOCZYNU W RAZ Z WYSWIETLENIEM
                    Console.WriteLine("Średnia arytmetyczna wynosi: " + mkSrednia);
                    Console.WriteLine("\nNacisnij dowolny klawisz by wrocic do menu.");
                    }

                    Console.ReadKey();
                    Console.Clear();
                }

                //LICZENIE SREDNIEJ WAZONA in-line
                if (mkSelectMenuItem == "Obliczenie średniej ważonej <in-line>")
                {
                    Console.Clear();
                    //Deklaracje lokalynych zmiennych
                    int mkIle = 0, mkWagaOcen=0;

                    float mkSredniaW = 0.0F;
                    float[] mkLiczby;

                    Console.WriteLine("\t\tOBLICZANIE ŚREDNIEJ WAZONA");
                    //WPISYWANIE ilosc liczb w średni arytmetycznej ze sprawdzenie czy inny znak wystapil
                    Console.WriteLine("\nProszę podac ilosc liczb w średni ważonej, która chesz obliczyć ");
                    while (!int.TryParse(Console.ReadLine(), out mkIle))
                    {
                        Console.WriteLine("ERROR: wystapił niedozwolony znak w zapisanie pierwszej wartości");
                        Console.WriteLine("Proszę wpisać ponownie wartość: ");
                    }

                    //DEKLAROWANIE TABLICY
                    mkLiczby = new float[mkIle];

                    //WPISYWANIE do tablicy ze sprawdzenie czy inny znak wystapil
                    for (int i = 0; i < mkIle; i++)
                    {
                        //WPISYWANIE DO TABLICY LICZB
                        Console.WriteLine("\nProszę wpisac " + (i + 1) + " liczbę: ");
                        while (!float.TryParse(Console.ReadLine(), out mkLiczby[i]))
                        {
                            Console.WriteLine("ERROR: wystapił niedozwolony znak w zapisanie pierwszej wartości");
                            Console.WriteLine("Proszę wpisać ponownie wartość " + (i + 1) + ":");
                        }

                        //WPISYWANIE WAGI LICZBY
                        Console.WriteLine("\nProszę wpisac wage dla podanej wczesniej liczby: ");
                        while (!int.TryParse(Console.ReadLine(), out mkWagaOcen))
                        {
                            Console.WriteLine("ERROR: wystapił niedozwolony znak w zapisanie pierwszej wartości");
                            Console.WriteLine("Proszę wpisać ponownie wartość: ");
                        }
                        mkLiczby[i] *= mkWagaOcen;
                    }

                    // Liczenie średniej wazonej
                    for (int a = 0; a < mkLiczby.Length; a++)
                    {
                        mkSredniaW += mkLiczby[a];
                    }

                    mkSredniaW /= mkIle;

                    //SPRAWDZANIE CZY mkILe ma jakas wartosc
                    if (mkIle == 0)
                    {
                        Console.WriteLine("Musisz podac przynajmniej jedna wartosc!");
                        Console.WriteLine("\nNacisnij dowolny klawisz by wrocic do menu.");
                    }
                    else
                    {
                        //OBLICZANIE ILOCZYNU W RAZ Z WYSWIETLENIEM
                        Console.WriteLine("Średnia wazona wynosi: " + mkSredniaW);
                        Console.WriteLine("\nNacisnij dowolny klawisz by wrocic do menu.");
                    }
                    Console.ReadKey();
                    Console.Clear();
                }

                //LICZENIE CENA JEDNOSTKI PASZY??? in-line
                if(mkSelectMenuItem == "Obliczenie cena jednostki paszy <in-line>")
                {
                    Console.Clear();
                    //DEKLARACJE ZMIENNCYH 
                    float mkIleZyta = 0.0F, mkIlePrzenicy = 0.0F, mkCKGZyta = 0.0F, mkCKGPrzenicy = 0.0F, mkCenaPaszy = 0.0F;

                    Console.WriteLine("\t\tOBLICZANIE JEDNOSTKI PASZY");
                    //WPISYWANIE ILOSCI KILO ZYTA
                    Console.WriteLine("\nProszę podac ilosc kilo Zyta: ");
                    while (!float.TryParse(Console.ReadLine(), out mkIleZyta))
                    {
                        Console.WriteLine("ERROR: wystapił niedozwolony znak w zapisanie pierwszej wartości");
                        Console.WriteLine("Proszę wpisać ponownie wartość: ");
                    }

                    //WPISYWANIE ILOSCI KILO PRZENICY
                    Console.WriteLine("\nProszę podac ilosc kilo Przenicy: ");
                    while (!float.TryParse(Console.ReadLine(), out mkIlePrzenicy))
                    {
                        Console.WriteLine("ERROR: wystapił niedozwolony znak w zapisanie pierwszej wartości");
                        Console.WriteLine("Proszę wpisać ponownie wartość: ");
                    }

                    //WPISYWANIE CENY ZA KG ZYTA
                    Console.WriteLine("\nProszę podac cena za KG Zyta: ");
                    while (!float.TryParse(Console.ReadLine(), out mkCKGZyta))
                    {
                        Console.WriteLine("ERROR: wystapił niedozwolony znak w zapisanie pierwszej wartości");
                        Console.WriteLine("Proszę wpisać ponownie wartość: ");
                    }

                    //WPISYWANIE CENY ZA KG PRZENICY
                    Console.WriteLine("\nProszę podac cena za KG Przenicy: ");
                    while (!float.TryParse(Console.ReadLine(), out  mkCKGPrzenicy))
                    {
                        Console.WriteLine("ERROR: wystapił niedozwolony znak w zapisanie pierwszej wartości");
                        Console.WriteLine("Proszę wpisać ponownie wartość: ");
                    }

                    //Liczenie ceny Paszy
                    mkCenaPaszy = (mkIleZyta * mkCKGZyta + mkIlePrzenicy * mkCKGPrzenicy) / (mkCKGPrzenicy + mkCKGZyta);

                    Console.WriteLine("Cena paszy wynosi: " + mkCenaPaszy);
                    Console.WriteLine("\nNacisnij dowolny klawisz by wrocic do menu.");
                    Console.ReadKey();
                    Console.Clear();
                }           

                //LICZENIE SREDNIEJ HARMONICZNEJ in-line
                if (mkSelectMenuItem == "Obliczenie średniej harmonicznej <in-line>")
                {
                    Console.Clear();
                    //Deklaracje lokalynych zmiennych
                    int mkIle = 0;
                    float mkSredniaH = 0.0F;
                    float[] mkLiczby;

                    Console.WriteLine("\t\tOBLICZANIE ŚREDNIEJ HARMONICZNEJ");
                    //WPISYWANIE ilosc liczb w średni arytmetycznej ze sprawdzenie czy inny znak wystapil
                    Console.WriteLine("\nProszę podac ilosc liczb w średni harminicznej, która chesz obliczyć ");
                    while (!int.TryParse(Console.ReadLine(), out mkIle))
                    {
                        Console.WriteLine("ERROR: wystapił niedozwolony znak w zapisanie pierwszej wartości");
                        Console.WriteLine("Proszę wpisać ponownie wartość: ");
                    }

                    //DEKLAROWANIE TABLICY
                    mkLiczby = new float[mkIle];

                    //WPISYWANIE do tablicy ze sprawdzenie czy inny znak wystapil
                    for (int i = 0; i < mkIle; i++)
                    {
                        //SPRAWDZAMY CZY NIE WYNOSI ZERO, PONIEWAZ NIE MOZNA DZIELIC PRZEZ 0
                        do
                        {
                            //WPISYWANIE DO TABLICY LICZB
                            Console.WriteLine("\nProszę wpisac " + (i + 1) + " liczbę: ");
                            while (!float.TryParse(Console.ReadLine(), out mkLiczby[i]))
                            {
                                Console.WriteLine("ERROR: wystapił niedozwolony znak w zapisanie pierwszej wartości");
                                Console.WriteLine("Proszę wpisać ponownie wartość " + (i + 1) + ":");
                            }

                            if(mkLiczby[i]==0)
                            {
                                Console.WriteLine("\nTa liczba nie moze wynosic 0. (Nie dziel przez 0!)");
                                Console.WriteLine("Proszę wpisać ponownie wartość " + (i + 1) + ":");
                            }
                        } while (mkLiczby[i] == 0);
                    }

                    // Liczenie średniej harmonicznej
                    for (int a = 0; a < mkLiczby.Length; a++)
                    {
                        mkSredniaH = mkSredniaH + (1/mkLiczby[a]);
                    }

                    mkSredniaH = mkIle / mkSredniaH;

                    //SPRAWDZANIE CZY mkILe ma jakas wartosc
                    if (mkIle == 0)
                    {
                        Console.WriteLine("Musisz podac przynajmniej jedna wartosc!");
                        Console.WriteLine("\nNacisnij dowolny klawisz by wrocic do menu.");
                    }
                    else
                    {
                        //OBLICZANIE ILOCZYNU W RAZ Z WYSWIETLENIEM
                        Console.WriteLine("Średnia harmoniczna wynosi: " + mkSredniaH);
                        Console.WriteLine("\nNacisnij dowolny klawisz by wrocic do menu.");
                    }

                    Console.ReadKey();
                    Console.Clear();
                }

                //LICZENIE SREDNIEJ GEOMETRYCZNA in-line
                if (mkSelectMenuItem == "Obliczenie średniej geometrycznej <in-line>")
                {
                    Console.Clear();
                    //Deklaracje lokalynych zmiennych
                    int mkIle = 0;
                    float mkSredniaG = 1F;
                    float[] mkLiczby;

                    Console.WriteLine("\t\tOBLICZANIE ŚREDNIEJ GEOMETRYCZNEJ");
                    //WPISYWANIE ilosc liczb w średni arytmetycznej ze sprawdzenie czy inny znak wystapil
                    Console.WriteLine("\nProszę podac ilosc liczb w średni geometryczna, która chesz obliczyć ");
                    while (!int.TryParse(Console.ReadLine(), out mkIle))
                    {
                        Console.WriteLine("ERROR: wystapił niedozwolony znak w zapisanie pierwszej wartości");
                        Console.WriteLine("Proszę wpisać ponownie wartość: ");
                    }

                    //DEKLAROWANIE TABLICY
                    mkLiczby = new float[mkIle];

                    //WPISYWANIE do tablicy ze sprawdzenie czy inny znak wystapil
                    for (int i = 0; i < mkIle; i++)
                    {
                        //WPISYWANIE DO TABLICY LICZB
                        Console.WriteLine("\nProszę wpisac " + (i + 1) + " liczbę: ");
                        while (!float.TryParse(Console.ReadLine(), out mkLiczby[i]))
                        {
                            Console.WriteLine("ERROR: wystapił niedozwolony znak w zapisanie pierwszej wartości");
                            Console.WriteLine("Proszę wpisać ponownie wartość " + (i + 1) + ":");
                        }
                    }

                    // Liczenie średniej harmonicznej
                    for (int a = 0; a < mkLiczby.Length; a++)
                    {
                        mkSredniaG  *= mkLiczby[a];
                    }

                    mkSredniaG = (float)Math.Pow(mkSredniaG, 1.0/ (float)mkIle);

                    //SPRAWDZANIE CZY mkILe ma jakas wartosc
                    if (mkIle == 0)
                    {
                        Console.WriteLine("Musisz podac przynajmniej jedna wartosc!");
                        Console.WriteLine("\nNacisnij dowolny klawisz by wrocic do menu.");
                    }
                    else
                    {
                        //OBLICZANIE ILOCZYNU W RAZ Z WYSWIETLENIEM
                        Console.WriteLine("Średnia geometryczna wynosi: " + mkSredniaG);
                        Console.WriteLine("\nNacisnij dowolny klawisz by wrocic do menu.");
                    }

                    Console.ReadKey();
                    Console.Clear();
                }

                //LICZENIE SREDNIEJ KWADRATOWEJ in-line
                if (mkSelectMenuItem == "Obliczenie średniej kwadratowej <in-line>")
                {
                    Console.Clear();
                    //Deklaracje lokalynych zmiennych
                    int mkIle = 0;
                    float mkSredniaK = 0.0F;
                    float[] mkLiczby;

                    Console.WriteLine("\t\tOBLICZANIE ŚREDNIEJ KWADRATOWEJ");
                    //SPRAWDZENIE CZY mkIle nie ma zera, poneiwaz niw olno dzielic przez 0
                    do
                    {
                        //WPISYWANIE ilosc liczb w średni arytmetycznej ze sprawdzenie czy inny znak wystapil
                        Console.WriteLine("\nProszę podac ilosc liczb w średni kwadratowej, która chesz obliczyć ");
                        while (!int.TryParse(Console.ReadLine(), out mkIle))
                        {
                            Console.WriteLine("ERROR: wystapił niedozwolony znak w zapisanie pierwszej wartości");
                            Console.WriteLine("Proszę wpisać ponownie wartość: ");
                        }

                        //Komunikat jezeli mkIle jest 0
                        if (mkIle==0)
                        {
                            Console.WriteLine("Ta liczba nie moze byc 0, (NIE DZIEL PRZEZ 0)");
                        }
                    } while (mkIle==0);

                    //DEKLAROWANIE TABLICY
                    mkLiczby = new float[mkIle];

                    //WPISYWANIE do tablicy ze sprawdzenie czy inny znak wystapil
                    for (int i = 0; i < mkIle; i++)
                    {
                        //WPISYWANIE DO TABLICY LICZB
                        Console.WriteLine("\nProszę wpisac " + (i + 1) + " liczbę: ");
                        while (!float.TryParse(Console.ReadLine(), out mkLiczby[i]))
                        {
                            Console.WriteLine("ERROR: wystapił niedozwolony znak w zapisanie pierwszej wartości");
                            Console.WriteLine("Proszę wpisać ponownie wartość " + (i + 1) + ":");
                        }

                    }
                

                    // Liczenie średniej kwadratowej
                    for (int a = 0; a < mkLiczby.Length; a++)
                    {
                        mkSredniaK += (float)Math.Pow(mkLiczby[a], 2.0F); // JEST TO WYNIK NP. 2^2 + 5^2 
                    }

                    mkSredniaK = (float)Math.Sqrt(mkSredniaK / mkIle); // Koncowy wynik

                        //OBLICZANIE ILOCZYNU W RAZ Z WYSWIETLENIEM
                        Console.WriteLine("Średnia kwadratowej wynosi: " + mkSredniaK);
                        Console.WriteLine("\nNacisnij dowolny klawisz by wrocic do menu.");
                    

                    Console.ReadKey();
                    Console.Clear();
                }

                //LICZENIE SREDNIEJ POTEGOWA in-line
                if (mkSelectMenuItem == "Obliczenie średniej potęgowej <średniej uogólnionej> <in-line>")
                {
                    Console.Clear();
                    //Deklaracje lokalynych zmiennych
                    int mkIle = 0, mkRzad=0;
                    float mkSredniaP = 0.0F;
                    float[] mkLiczby;

                    Console.WriteLine("\t\tOBLICZANIE ŚREDNIEJ POTEGOWEJ");
                    //SPRAWDZENIE CZY mkIle nie ma zera, poneiwaz niw olno dzielic przez 0
                    do
                    {
                        //WPISYWANIE ilosc liczb w średni arytmetycznej ze sprawdzenie czy inny znak wystapil
                        Console.WriteLine("\nProszę podac ilosc liczb w średni potegowej, która chesz obliczyć ");
                        while (!int.TryParse(Console.ReadLine(), out mkIle))
                        {
                            Console.WriteLine("ERROR: wystapił niedozwolony znak w zapisanie pierwszej wartości");
                            Console.WriteLine("Proszę wpisać ponownie wartość: ");
                        }

                        //Komunikat jezeli mkIle jest 0
                        if (mkIle == 0)
                        {
                            Console.WriteLine("Ta liczba nie moze byc 0, (NIE DZIEL PRZEZ 0)");
                        }
                    } while (mkIle == 0);

                    //WPISYWANIE rzedu  ze sprawdzenie czy inny znak wystapil
                    Console.WriteLine("\nProszę podac rzad do średniej potegowej:  ");
                    while (!int.TryParse(Console.ReadLine(), out mkRzad))
                    {
                        Console.WriteLine("ERROR: wystapił niedozwolony znak w zapisanie pierwszej wartości");
                        Console.WriteLine("Proszę wpisać ponownie wartość: ");
                    }

                    //DEKLAROWANIE TABLICY
                    mkLiczby = new float[mkIle];

                    //WPISYWANIE do tablicy ze sprawdzenie czy inny znak wystapil
                    for (int i = 0; i < mkIle; i++)
                    {
                        //WPISYWANIE DO TABLICY LICZB
                        Console.WriteLine("\nProszę wpisac " + (i + 1) + " liczbę: ");
                        while (!float.TryParse(Console.ReadLine(), out mkLiczby[i]))
                        {
                            Console.WriteLine("ERROR: wystapił niedozwolony znak w zapisanie pierwszej wartości");
                            Console.WriteLine("Proszę wpisać ponownie wartość " + (i + 1) + ":");
                        }
                    }

                    // Liczenie średniej potęgowej
                    for (int a = 0; a < mkLiczby.Length; a++)
                    {
                        mkSredniaP += (float)Math.Pow(mkLiczby[a], mkRzad); // JEST TO WYNIK NP. 2^2 + 5^2 
                    }

                    mkSredniaP = (float)Math.Pow(mkSredniaP / mkIle, 1.0/mkRzad); // Koncowy wynik

                        //OBLICZANIE ILOCZYNU W RAZ Z WYSWIETLENIEM
                        Console.WriteLine("Średnia potęgowej wynosi: " + mkSredniaP);
                        Console.WriteLine("\nNacisnij dowolny klawisz by wrocic do menu.");
                    

                    Console.ReadKey();
                    Console.Clear();
                }

                //ZAKONCZENIE PROGRAMU. WYJSCIE Z NIEGO
                if(mkSelectMenuItem == "Zakończenie <wyjście z> programu")
                {
                    Console.Clear();
                    Console.WriteLine("\t\t\t\t\t PA PA PA");
                    Thread.Sleep(2000);
                    Environment.Exit(0);
                }
            }
        }

        //METODA OBLICZAJACA SUME method-call
        private static void mkSuma()
        {
            Console.Clear();
            //Deklaracje lokalynych zmiennych
            int mkIle = 0;
            float mkSuma = 0.0F;
            float[] mkLiczby;

            Console.WriteLine("\t\tOBLICZANIE SUMA");
            //WPISYWANIE ilosc liczb w średni arytmetycznej ze sprawdzenie czy inny znak wystapil
            Console.WriteLine("\nProszę podac ciag liczb do obliczenia iloczynu");
            while (!int.TryParse(Console.ReadLine(), out mkIle))
            {
                Console.WriteLine("ERROR: wystapił niedozwolony znak w zapisanie pierwszej wartości");
                Console.WriteLine("Proszę wpisać ponownie wartość: ");
            }

            //DEKLAROWANIE TABLICY
            mkLiczby = new float[mkIle];

            //WPISYWANIE LICZB DO TABLICY ze sprawdzenie czy inny znak wystapil
            for (int i = 0; i < mkIle; i++)
            {
                Console.WriteLine("\nProszę wpisac " + (i + 1) + " liczbę: ");
                while (!float.TryParse(Console.ReadLine(), out mkLiczby[i]))
                {
                    Console.WriteLine("ERROR: wystapił niedozwolony znak w zapisanie pierwszej wartości");
                    Console.WriteLine("Proszę wpisać ponownie wartość " + (i + 1) + ":");
                }
            }

            // Liczenie średniej arytmetycznej
            for (int a = 0; a < mkLiczby.Length; a++)
            {
                mkSuma += mkLiczby[a];
            }

            //SPRAWDZANIE CZY mkILe ma jakas wartosc
            if (mkIle == 0)
            {
                Console.WriteLine("Musisz podac przynajmniej jedna wartosc!");
                Console.WriteLine("\nNacisnij dowolny klawisz by wrocic do menu.");
            }
            else
            {
                //OBLICZANIE ILOCZYNU W RAZ Z WYSWIETLENIEM
                Console.WriteLine("Suma wynosi: " + mkSuma);
                Console.WriteLine("\nNacisnij dowolny klawisz by wrocic do menu.");
            }

            Console.ReadKey();
            Console.Clear();
        }

        //METODA OBLICZAJACA ILOCZYN method-call
        private static void mkIloczyn()
        {
            Console.Clear();
            //Deklaracje lokalynych zmiennych
            int mkIle = 0;
            float mkIloczyn = 1.0F;
            float[] mkLiczby;

            Console.WriteLine("\t\tOBLICZANIE ILOCZYNU");
            //WPISYWANIE ilosc liczb w średni arytmetycznej ze sprawdzenie czy inny znak wystapil
            Console.WriteLine("\nProszę podac ciag liczb do obliczenia iloczynu");
            while (!int.TryParse(Console.ReadLine(), out mkIle))
            {
                Console.WriteLine("ERROR: wystapił niedozwolony znak w zapisanie pierwszej wartości");
                Console.WriteLine("Proszę wpisać ponownie wartość: ");
            }

            //DEKLAROWANIE TABLICY
            mkLiczby = new float[mkIle];

            //WPISYWANIE LICZB DO TABLICY ze sprawdzenie czy inny znak wystapil
            for (int i = 0; i < mkIle; i++)
            {
                Console.WriteLine("\nProszę wpisac " + (i + 1) + " liczbę: ");
                while (!float.TryParse(Console.ReadLine(), out mkLiczby[i]))
                {
                    Console.WriteLine("ERROR: wystapił niedozwolony znak w zapisanie pierwszej wartości");
                    Console.WriteLine("Proszę wpisać ponownie wartość " + (i + 1) + ":");
                }
            }

            // Liczenie średniej arytmetycznej
            for (int a = 0; a < mkLiczby.Length; a++)
            {
                mkIloczyn *= mkLiczby[a];
            }

            //SPRAWDZANIE CZY mkILe ma jakas wartosc
            if (mkIle == 0)
            {
                Console.WriteLine("Musisz podac przynajmniej jedna wartosc!");
                Console.WriteLine("\nNacisnij dowolny klawisz by wrocic do menu.");
            }
            else
            {
                //OBLICZANIE ILOCZYNU W RAZ Z WYSWIETLENIEM
                Console.WriteLine("Iloczyn wynosi: " + mkIloczyn);
                Console.WriteLine("\nNacisnij dowolny klawisz by wrocic do menu.");
            }

            Console.ReadKey();
            Console.Clear();
        }

        //METODA OBLICZAJACA SREDNIA ARYTMETYCZNA method-call
        private static void mkSredniaArytmetyczna()
        {
            Console.Clear();
            //Deklaracje lokalynych zmiennych
            int mkIle = 0;
            float mkSrednia = 0.0F;
            float[] mkLiczby;

            Console.WriteLine("\t\tOBLICZANIE ŚREDNIEJ ARYTMETYCZNEJ");
            //WPISYWANIE ilosc liczb w średni arytmetycznej ze sprawdzenie czy inny znak wystapil
            Console.WriteLine("\nProszę podac ilosc liczb w średni arytmetycznej, która chesz obliczyć ");
            while (!int.TryParse(Console.ReadLine(), out mkIle))
            {
                Console.WriteLine("ERROR: wystapił niedozwolony znak w zapisanie pierwszej wartości");
                Console.WriteLine("Proszę wpisać ponownie wartość: ");
            }

            //DEKLAROWANIE TABLICY
            mkLiczby = new float[mkIle];

            //WPISYWANIE LICZB DO TABLICY ze sprawdzenie czy inny znak wystapil
            for (int i = 0; i < mkIle; i++)
            {
                Console.WriteLine("\nProszę wpisac " + (i + 1) + " liczbę: ");
                while (!float.TryParse(Console.ReadLine(), out mkLiczby[i]))
                {
                    Console.WriteLine("ERROR: wystapił niedozwolony znak w zapisanie pierwszej wartości");
                    Console.WriteLine("Proszę wpisać ponownie wartość " + (i + 1) + ":");
                }
            }

            // Liczenie średniej arytmetycznej
            for (int a = 0; a < mkLiczby.Length; a++)
            {
                mkSrednia += mkLiczby[a];
            }

            mkSrednia /= mkIle;

            //SPRAWDZANIE CZY mkILe ma jakas wartosc
            if (mkIle == 0)
            {
                Console.WriteLine("Musisz podac przynajmniej jedna wartosc!");
                Console.WriteLine("\nNacisnij dowolny klawisz by wrocic do menu.");
            }
            else
            {
                //OBLICZANIE ILOCZYNU W RAZ Z WYSWIETLENIEM
                Console.WriteLine("Średnia arytmetyczna wynosi: " + mkSrednia);
                Console.WriteLine("\nNacisnij dowolny klawisz by wrocic do menu.");
            }

            Console.ReadKey();
            Console.Clear();
        }

        //METODA OBLICZAJACA SREDNIA WAZONA method-call
        private static void mkSredniaWazona()
        {
            Console.Clear();
            //Deklaracje lokalynych zmiennych
            int mkIle = 0, mkWagaOcen = 0;

            float mkSredniaW = 0.0F;
            float[] mkLiczby;

            Console.WriteLine("\t\tOBLICZANIE ŚREDNIEJ WAZONA");
            //WPISYWANIE ilosc liczb w średni arytmetycznej ze sprawdzenie czy inny znak wystapil
            Console.WriteLine("\nProszę podac ilosc liczb w średni ważonej, która chesz obliczyć ");
            while (!int.TryParse(Console.ReadLine(), out mkIle))
            {
                Console.WriteLine("ERROR: wystapił niedozwolony znak w zapisanie pierwszej wartości");
                Console.WriteLine("Proszę wpisać ponownie wartość: ");
            }

            //DEKLAROWANIE TABLICY
            mkLiczby = new float[mkIle];

            //WPISYWANIE do tablicy ze sprawdzenie czy inny znak wystapil
            for (int i = 0; i < mkIle; i++)
            {
                //WPISYWANIE DO TABLICY LICZB
                Console.WriteLine("\nProszę wpisac " + (i + 1) + " liczbę: ");
                while (!float.TryParse(Console.ReadLine(), out mkLiczby[i]))
                {
                    Console.WriteLine("ERROR: wystapił niedozwolony znak w zapisanie pierwszej wartości");
                    Console.WriteLine("Proszę wpisać ponownie wartość " + (i + 1) + ":");
                }

                //WPISYWANIE WAGI LICZBY
                Console.WriteLine("\nProszę wpisac wage dla podanej wczesniej liczby: ");
                while (!int.TryParse(Console.ReadLine(), out mkWagaOcen))
                {
                    Console.WriteLine("ERROR: wystapił niedozwolony znak w zapisanie pierwszej wartości");
                    Console.WriteLine("Proszę wpisać ponownie wartość: ");
                }
                mkLiczby[i] *= mkWagaOcen;
            }

            // Liczenie średniej wazonej
            for (int a = 0; a < mkLiczby.Length; a++)
            {
                mkSredniaW += mkLiczby[a];
            }

            mkSredniaW /= mkIle;

            //SPRAWDZANIE CZY mkILe ma jakas wartosc
            if (mkIle == 0)
            {
                Console.WriteLine("Musisz podac przynajmniej jedna wartosc!");
                Console.WriteLine("\nNacisnij dowolny klawisz by wrocic do menu.");
            }
            else
            {
                //OBLICZANIE ILOCZYNU W RAZ Z WYSWIETLENIEM
                Console.WriteLine("Średnia wazona wynosi: " + mkSredniaW);
                Console.WriteLine("\nNacisnij dowolny klawisz by wrocic do menu.");
            }
            Console.ReadKey();
            Console.Clear();
        }

        //METODA OBLICZAJACA JEDNOSTKE PASZY method-call
        private static void mkJednsotkaPaszy()
        {
            Console.Clear();
            //DEKLARACJE ZMIENNCYH 
            float mkIleZyta = 0.0F, mkIlePrzenicy = 0.0F, mkCKGZyta = 0.0F, mkCKGPrzenicy = 0.0F, mkCenaPaszy = 0.0F;

            Console.WriteLine("\t\tOBLICZANIE JEDNOSTKI PASZY");
            //WPISYWANIE ILOSCI KILO ZYTA
            Console.WriteLine("\nProszę podac ilosc kilo Zyta: ");
            while (!float.TryParse(Console.ReadLine(), out mkIleZyta))
            {
                Console.WriteLine("ERROR: wystapił niedozwolony znak w zapisanie pierwszej wartości");
                Console.WriteLine("Proszę wpisać ponownie wartość: ");
            }

            //WPISYWANIE ILOSCI KILO PRZENICY
            Console.WriteLine("\nProszę podac ilosc kilo Przenicy: ");
            while (!float.TryParse(Console.ReadLine(), out mkIlePrzenicy))
            {
                Console.WriteLine("ERROR: wystapił niedozwolony znak w zapisanie pierwszej wartości");
                Console.WriteLine("Proszę wpisać ponownie wartość: ");
            }

            //WPISYWANIE CENY ZA KG ZYTA
            Console.WriteLine("\nProszę podac cena za KG Zyta: ");
            while (!float.TryParse(Console.ReadLine(), out mkCKGZyta))
            {
                Console.WriteLine("ERROR: wystapił niedozwolony znak w zapisanie pierwszej wartości");
                Console.WriteLine("Proszę wpisać ponownie wartość: ");
            }

            //WPISYWANIE CENY ZA KG PRZENICY
            Console.WriteLine("\nProszę podac cena za KG Przenicy: ");
            while (!float.TryParse(Console.ReadLine(), out mkCKGPrzenicy))
            {
                Console.WriteLine("ERROR: wystapił niedozwolony znak w zapisanie pierwszej wartości");
                Console.WriteLine("Proszę wpisać ponownie wartość: ");
            }

            //Liczenie ceny Paszy
            mkCenaPaszy = (mkIleZyta * mkCKGZyta + mkIlePrzenicy * mkCKGPrzenicy) / (mkCKGPrzenicy + mkCKGZyta);

            Console.WriteLine("Cena paszy wynosi: " + mkCenaPaszy);
            Console.WriteLine("\nNacisnij dowolny klawisz by wrocic do menu.");
            Console.ReadKey();
            Console.Clear();
        }

        //METODA OBLICZAJACA SREDNIA HARMONICZNA method-call
        private static void mkSredniaHarmoniczna()
        {
            Console.Clear();
            //Deklaracje lokalynych zmiennych
            int mkIle = 0;
            float mkSredniaH = 0.0F;
            float[] mkLiczby;

            Console.WriteLine("\t\tOBLICZANIE ŚREDNIEJ HARMONICZNEJ");
            //WPISYWANIE ilosc liczb w średni arytmetycznej ze sprawdzenie czy inny znak wystapil
            Console.WriteLine("\nProszę podac ilosc liczb w średni harminicznej, która chesz obliczyć ");
            while (!int.TryParse(Console.ReadLine(), out mkIle))
            {
                Console.WriteLine("ERROR: wystapił niedozwolony znak w zapisanie pierwszej wartości");
                Console.WriteLine("Proszę wpisać ponownie wartość: ");
            }

            //DEKLAROWANIE TABLICY
            mkLiczby = new float[mkIle];

            //WPISYWANIE do tablicy ze sprawdzenie czy inny znak wystapil
            for (int i = 0; i < mkIle; i++)
            {
                //SPRAWDZAMY CZY NIE WYNOSI ZERO, PONIEWAZ NIE MOZNA DZIELIC PRZEZ 0
                do
                {
                    //WPISYWANIE DO TABLICY LICZB
                    Console.WriteLine("\nProszę wpisac " + (i + 1) + " liczbę: ");
                    while (!float.TryParse(Console.ReadLine(), out mkLiczby[i]))
                    {
                        Console.WriteLine("ERROR: wystapił niedozwolony znak w zapisanie pierwszej wartości");
                        Console.WriteLine("Proszę wpisać ponownie wartość " + (i + 1) + ":");
                    }

                    if (mkLiczby[i] == 0)
                    {
                        Console.WriteLine("\nTa liczba nie moze wynosic 0. (Nie dziel przez 0!)");
                        Console.WriteLine("Proszę wpisać ponownie wartość " + (i + 1) + ":");
                    }
                } while (mkLiczby[i] == 0);
            }

            // Liczenie średniej harmonicznej
            for (int a = 0; a < mkLiczby.Length; a++)
            {
                mkSredniaH = mkSredniaH + (1 / mkLiczby[a]);
            }

            mkSredniaH = mkIle / mkSredniaH;

            //SPRAWDZANIE CZY mkILe ma jakas wartosc
            if (mkIle == 0)
            {
                Console.WriteLine("Musisz podac przynajmniej jedna wartosc!");
                Console.WriteLine("\nNacisnij dowolny klawisz by wrocic do menu.");
            }
            else
            {
                //OBLICZANIE ILOCZYNU W RAZ Z WYSWIETLENIEM
                Console.WriteLine("Średnia harmoniczna wynosi: " + mkSredniaH);
                Console.WriteLine("\nNacisnij dowolny klawisz by wrocic do menu.");
            }

            Console.ReadKey();
            Console.Clear();
        }

        //METODA OBLICZAJACA SREDNIE GEOMETRYCZNA method-call
        private static void mkSredniaGeometryczna()
        {
            Console.Clear();
            //Deklaracje lokalynych zmiennych
            int mkIle = 0;
            float mkSredniaG = 1F;
            float[] mkLiczby;

            Console.WriteLine("\t\tOBLICZANIE ŚREDNIEJ GEOMETRYCZNEJ");
            //WPISYWANIE ilosc liczb w średni arytmetycznej ze sprawdzenie czy inny znak wystapil
            Console.WriteLine("\nProszę podac ilosc liczb w średni geometryczna, która chesz obliczyć ");
            while (!int.TryParse(Console.ReadLine(), out mkIle))
            {
                Console.WriteLine("ERROR: wystapił niedozwolony znak w zapisanie pierwszej wartości");
                Console.WriteLine("Proszę wpisać ponownie wartość: ");
            }

            //DEKLAROWANIE TABLICY
            mkLiczby = new float[mkIle];

            //WPISYWANIE do tablicy ze sprawdzenie czy inny znak wystapil
            for (int i = 0; i < mkIle; i++)
            {
                //WPISYWANIE DO TABLICY LICZB
                Console.WriteLine("\nProszę wpisac " + (i + 1) + " liczbę: ");
                while (!float.TryParse(Console.ReadLine(), out mkLiczby[i]))
                {
                    Console.WriteLine("ERROR: wystapił niedozwolony znak w zapisanie pierwszej wartości");
                    Console.WriteLine("Proszę wpisać ponownie wartość " + (i + 1) + ":");
                }
            }

            // Liczenie średniej harmonicznej
            for (int a = 0; a < mkLiczby.Length; a++)
            {
                mkSredniaG *= mkLiczby[a];
            }

            mkSredniaG = (float)Math.Pow(mkSredniaG, 1.0 / (float)mkIle);

            //SPRAWDZANIE CZY mkILe ma jakas wartosc
            if (mkIle == 0)
            {
                Console.WriteLine("Musisz podac przynajmniej jedna wartosc!");
                Console.WriteLine("\nNacisnij dowolny klawisz by wrocic do menu.");
            }
            else
            {
                //OBLICZANIE ILOCZYNU W RAZ Z WYSWIETLENIEM
                Console.WriteLine("Średnia geometryczna wynosi: " + mkSredniaG);
                Console.WriteLine("\nNacisnij dowolny klawisz by wrocic do menu.");
            }

            Console.ReadKey();
            Console.Clear();
        }

        //METODA OBLICZAJACA SREDNIE KWADRATOWA method-call
        private static void mkSredniaKwadratowa()
        {
            Console.Clear();
            //Deklaracje lokalynych zmiennych
            int mkIle = 0;
            float mkSredniaK = 0.0F;
            float[] mkLiczby;

            Console.WriteLine("\t\tOBLICZANIE ŚREDNIEJ KWADRATOWEJ");
            //SPRAWDZENIE CZY mkIle nie ma zera, poneiwaz niw olno dzielic przez 0
            do
            {
                //WPISYWANIE ilosc liczb w średni arytmetycznej ze sprawdzenie czy inny znak wystapil
                Console.WriteLine("\nProszę podac ilosc liczb w średni kwadratowej, która chesz obliczyć ");
                while (!int.TryParse(Console.ReadLine(), out mkIle))
                {
                    Console.WriteLine("ERROR: wystapił niedozwolony znak w zapisanie pierwszej wartości");
                    Console.WriteLine("Proszę wpisać ponownie wartość: ");
                }

                //Komunikat jezeli mkIle jest 0
                if (mkIle == 0)
                {
                    Console.WriteLine("Ta liczba nie moze byc 0, (NIE DZIEL PRZEZ 0)");
                }
            } while (mkIle == 0);

            //DEKLAROWANIE TABLICY
            mkLiczby = new float[mkIle];

            //WPISYWANIE do tablicy ze sprawdzenie czy inny znak wystapil
            for (int i = 0; i < mkIle; i++)
            {
                //WPISYWANIE DO TABLICY LICZB
                Console.WriteLine("\nProszę wpisac " + (i + 1) + " liczbę: ");
                while (!float.TryParse(Console.ReadLine(), out mkLiczby[i]))
                {
                    Console.WriteLine("ERROR: wystapił niedozwolony znak w zapisanie pierwszej wartości");
                    Console.WriteLine("Proszę wpisać ponownie wartość " + (i + 1) + ":");
                }

            }

            // Liczenie średniej kwadratowej
            for (int a = 0; a < mkLiczby.Length; a++)
            {
                mkSredniaK += (float)Math.Pow(mkLiczby[a], 2.0F); // JEST TO WYNIK NP. 2^2 + 5^2 
            }

            mkSredniaK = (float)Math.Sqrt(mkSredniaK / mkIle); // Koncowy wynik

            //OBLICZANIE ILOCZYNU W RAZ Z WYSWIETLENIEM
            Console.WriteLine("Średnia kwadratowej wynosi: " + mkSredniaK);
            Console.WriteLine("\nNacisnij dowolny klawisz by wrocic do menu.");

            Console.ReadKey();
            Console.Clear();
        }

        //METODA OBLICZAJACA SREDNIE POTEGOWA method-call
        private static void mkSredniaPotegowa()
        {
            Console.Clear();
            //Deklaracje lokalynych zmiennych
            int mkIle = 0, mkRzad = 0;
            float mkSredniaP = 0.0F;
            float[] mkLiczby;

            Console.WriteLine("\t\tOBLICZANIE ŚREDNIEJ POTEGOWEJ");
            //SPRAWDZENIE CZY mkIle nie ma zera, poneiwaz niw olno dzielic przez 0
            do
            {
                //WPISYWANIE ilosc liczb w średni arytmetycznej ze sprawdzenie czy inny znak wystapil
                Console.WriteLine("\nProszę podac ilosc liczb w średni potegowej, która chesz obliczyć ");
                while (!int.TryParse(Console.ReadLine(), out mkIle))
                {
                    Console.WriteLine("ERROR: wystapił niedozwolony znak w zapisanie pierwszej wartości");
                    Console.WriteLine("Proszę wpisać ponownie wartość: ");
                }

                //Komunikat jezeli mkIle jest 0
                if (mkIle == 0)
                {
                    Console.WriteLine("Ta liczba nie moze byc 0, (NIE DZIEL PRZEZ 0)");
                }
            } while (mkIle == 0);

            //WPISYWANIE rzedu  ze sprawdzenie czy inny znak wystapil
            Console.WriteLine("\nProszę podac rzad do średniej potegowej:  ");
            while (!int.TryParse(Console.ReadLine(), out mkRzad))
            {
                Console.WriteLine("ERROR: wystapił niedozwolony znak w zapisanie pierwszej wartości");
                Console.WriteLine("Proszę wpisać ponownie wartość: ");
            }

            //DEKLAROWANIE TABLICY
            mkLiczby = new float[mkIle];

            //WPISYWANIE do tablicy ze sprawdzenie czy inny znak wystapil
            for (int i = 0; i < mkIle; i++)
            {
                //WPISYWANIE DO TABLICY LICZB
                Console.WriteLine("\nProszę wpisac " + (i + 1) + " liczbę: ");
                while (!float.TryParse(Console.ReadLine(), out mkLiczby[i]))
                {
                    Console.WriteLine("ERROR: wystapił niedozwolony znak w zapisanie pierwszej wartości");
                    Console.WriteLine("Proszę wpisać ponownie wartość " + (i + 1) + ":");
                }
            }

            // Liczenie średniej potęgowej
            for (int a = 0; a < mkLiczby.Length; a++)
            {
                mkSredniaP += (float)Math.Pow(mkLiczby[a], mkRzad); // JEST TO WYNIK NP. 2^2 + 5^2 
            }

            mkSredniaP = (float)Math.Pow(mkSredniaP / mkIle, 1.0 / mkRzad); // Koncowy wynik

            //OBLICZANIE ILOCZYNU W RAZ Z WYSWIETLENIEM
            Console.WriteLine("Średnia potęgowej wynosi: " + mkSredniaP);
            Console.WriteLine("\nNacisnij dowolny klawisz by wrocic do menu.");

            Console.ReadKey();
            Console.Clear();
        }

        // Klasa tworzaca nam menu
        private static string mkdrawMenu(List<string> items)
         {
              //Petla do wyboru menu
              for (int i = 0; i < items.Count; i++)
              {
                    if (i == mkIndex)
                    {
                        // Zmienianie koloru obramowki menu
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.ForegroundColor = ConsoleColor.Black;
                        // Wyswietlanie konktretnej opcji z listy menuItem
                        Console.WriteLine(items[i]);
                    }
                    else
                    {
                        // Wyswietlanie konktretnej opcji z listy menuItem
                        Console.WriteLine(items[i]);

                    }
                    Console.ResetColor();
              }

              // Tworzenie wyboru za pomoca strzalek 
              ConsoleKeyInfo mkCkey = Console.ReadKey();

              if (mkCkey.Key == ConsoleKey.DownArrow) // Jezli nacisniemy strzalke w gore
              {
                    // Sprawdzamy czy mkIndex nie wyszedl za liczbe pol w menuItem jak tak wracamy nim na gore
                    if (mkIndex == items.Count - 1) { mkIndex = 0; }
                    else { mkIndex++; }


              }
              else if (mkCkey.Key == ConsoleKey.UpArrow) // Jezeli nacisniey strzalke w dol
              {
                    // Sprawdzamy czy mkIndex nie wyszedl za liczbe pol w menuItem jak tak wracamy nim na dolu
                    if (mkIndex <= 0) { mkIndex = items.Count - 1; }
                    else { mkIndex--; }
              }
              else if (mkCkey.Key == ConsoleKey.Enter) // Wybor opcji, Naciskamy Enter wybiera dana opcje
              {
                    return items[mkIndex];
              }else if (mkCkey.Key == ConsoleKey.P)
              {
                Console.Clear();
                System.Media.SoundPlayer mkCheers;
                mkCheers = new System.Media.SoundPlayer();
                mkCheers.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "CROWDCHEER.wav";
                mkCheers.Play();
                Console.WriteLine("\t\t\t\t\t BRAWO! UDALO CI SIE ZNALEZC UKRYTA OPCJE!");
                Console.WriteLine("\t\t\t\t\t WYGRALES DARMOWE PIWO!");
                Thread.Sleep(5000);
                mkCheers.Stop();
              }
              else
              {
                Console.Clear();
                Console.WriteLine("\nERROR: wybrales przycisk bez czynnosc.");
                Console.WriteLine("\nSpis przycisków: \n\t- Strzałka w Góre - Góra  \n\t- Strzałka w dół - Dół  \n\t- Enter -  potwierdz wybor");
                Console.WriteLine("\n Nacisnij dowolny klawisz aby wrocic do menu");
                Console.ReadKey();
                Console.Clear();
                return "";
              }

              Console.Clear();

              return "";
         } 
    }
}
