namespace ZubakoveAdventury3;

internal class ZubakoveAdventuryMain
{
    static void Main(string[] args)
    {
        var plocha = new Plocha();
        var program = new Program();
        bool askForNextStep = true;
        Console.WriteLine("Zadaj program:");
        while (askForNextStep)
        {
            var prikaz = Console.ReadLine();
            switch (prikaz)
            {
                case "krok":
                    program.PridajPrikaz(new Krok());
                    break;
                case "vlavo":
                    program.PridajPrikaz(new Vlavo());
                    break;
                case "vpravo":
                    program.PridajPrikaz(new Vpravo());
                    break;
                case "zdvihni":
                    program.PridajPrikaz(new Zdvihni());
                    break;
                case "poloz":
                    program.PridajPrikaz(new Poloz());
                    break;
                case "koniec":
                    askForNextStep = false;
                    break;
                default:
                    Console.WriteLine("Zadaný príkaz neexistuje");
                    break;
            }
        }
        plocha.Vypis();
        program.Vypis();
        program.Spusti(plocha);
    }
}
