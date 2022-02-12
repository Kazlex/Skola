using Skola;


List<Osoba> osobas = new();
bool izlaz = false;

do
{

    Console.Write($"Izaberite Predavaca ili Polaznika {Environment.NewLine}");

    StampajMeni();
    string izb = Console.ReadLine();
    switch (izb)
    {
        case "1":
            Console.Clear();
            PredavacMeni.MeniPredavac();
            break;

        case "2":
            Console.Clear();
            PolaznikMeni.MeniPolaznika();
            break;

        case "3":
            Console.Clear();
            KursMeni.MeniKurs();
            break;

        case "4":
            Console.Clear();
            Console.WriteLine("Vidimo se (・_・)/");
            Console.ReadKey();
            izlaz = true;
            break;

        default:
            Console.WriteLine("ERROR");
            break;
    }
    Console.Clear();
} while (!izlaz);


void StampajMeni()
{
    Console.WriteLine("===================");
    Console.WriteLine("1. Predavac");
    Console.WriteLine("2. Polaznik");
    Console.WriteLine("3. Kurs");
    Console.WriteLine("4. Izlaz");
    Console.WriteLine("===================");
}
