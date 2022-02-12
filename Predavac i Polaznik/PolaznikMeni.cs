using Skola;
internal class PolaznikMeni
{


    public static void MeniPolaznika()
    {
        Console.WriteLine("===================");
        Console.WriteLine("1. Unos Polaznika");
        Console.WriteLine("2. Prikaz Polaznika");
        Console.WriteLine("3. Brisanje");
        Console.WriteLine("4. Prethodni meni");
        Console.WriteLine("===================");

        string polaznik = Console.ReadLine();
        switch (polaznik)
        {
            case "1":
                Console.Clear();
                UnosPolaznika();
                break;

            case "2":
                Console.Clear();
                PrikazPolaznika();
                break;

            case "3":
                BrisanjePolaznika();
                break;

            case "4":
                return;

            default:
                Console.WriteLine("ERROR");
                break;
        }

    }

    public static void UnosPolaznika()
    {

        Polaznik polaz = new();
        Console.Write("Unesite ime: ");
        polaz._ime = Console.ReadLine();
        Console.Write("Unesite prezime: ");
        polaz._prezime = Console.ReadLine();
        Console.ReadKey();
        Polaznik._polaznici.Add(polaz);


    }
    public static void PrikazPolaznika()
    {
        Console.Clear();
        int dex = 0;
        Polaznik._polaznici.ForEach(polaz =>
        {
            Console.WriteLine($"{++dex}. {polaz._ime} {polaz._prezime}");
            polaz._kursevi.ForEach(k => Console.WriteLine($"\t{k}"));
        });
        Console.ReadKey();

    }
    public static void BrisanjePolaznika()
    {
        Console.Write("Unesite indeks: ");
        int i = int.Parse(Console.ReadLine()) - 1;

        if (i >= 0 && i < Polaznik._polaznici.Count)
        {
            Polaznik._polaznici.RemoveAt(i);
        }
        else
        {
            Console.WriteLine("Nemaa :/");
            Console.ReadKey();
        }
    }
}