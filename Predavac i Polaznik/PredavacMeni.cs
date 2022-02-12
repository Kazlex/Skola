using Skola;
    internal class PredavacMeni
    {
    
   
    public static void MeniPredavac()
    {
        Console.WriteLine("===================");
        Console.WriteLine("1. Unos Predavaca");
        Console.WriteLine("2. Prikaz Predavaca");
        Console.WriteLine("3. Brisanje");
        Console.WriteLine("4. Prethodni meni");
        Console.WriteLine("===================");

        string pred = Console.ReadLine();
        switch (pred)
        {
            case "1":
                Console.Clear();
                UnosPredavaca();
                break;

            case "2":
                PrikazPredavaca();
                break;

            case "3":
                BrisanjePredavaca();
                break;

            case "4":
                return;

            default:
                Console.WriteLine("ERROR");
                break;
        }

    }

    public static void UnosPredavaca()
    {

        Predavac p = new();
        Console.Write("Unesite ime: ");
        p._ime = Console.ReadLine();
        Console.Write("Unesite prezime: ");
        p._prezime = Console.ReadLine();
        Console.ReadKey();
        Predavac._predavaci.Add(p);
        

    }
    public static void PrikazPredavaca()
    {
        Console.Clear();
        int dex = 0;
        Predavac._predavaci.ForEach(p => Console.WriteLine($"{++dex}. {p._ime} {p._prezime}"));
        Console.ReadKey();

    }
    public static void BrisanjePredavaca()
    {
        Console.Write("Unesite indeks: ");
        int i = int.Parse(Console.ReadLine()) - 1;

        if (i >= 0 && i < Predavac._predavaci.Count)
        {
            Predavac._predavaci.RemoveAt(i);
        }
        else
        {
            Console.WriteLine("Jooook");
            Console.ReadKey();
        }
    }
}



