namespace ZubakoveAdventury;
class ZubakoveAdventuryMain
{
    static void Main(string[] args)
    {
        var hernySvet = new HernySvet();
        hernySvet.PridajBudovu(new VrtnaSuprava(1, 1, Surovina.ZELEZNA_RUDA));
        hernySvet.PridajBudovu(new VrtnaSuprava(4, 2, Surovina.MEDENA_RUDA));
        hernySvet.PridajBudovu(new Pec(1, 2));
        hernySvet.PridajBudovu(new Pec(3, 2));
        hernySvet.PridajBudovu(new Tovaren(2, 2));
        hernySvet.PridajBudovu(new Tovaren(3, 1));

        for(int i = 0; i<20; i++)
        {
            hernySvet.VykonajKrok();
        }
        Console.ReadLine();
    }
}
