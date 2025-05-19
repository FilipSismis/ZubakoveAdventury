namespace ZubakoveAdventury;

internal class HernySvet
{
    private List<Budova> budovy = new();
    private int hernyKrok = 1;

    public void PridajBudovu(Budova budova) => budovy.Add(budova);
    public Budova? GetBudova(int riadok, int stlpec) => budovy.FirstOrDefault(i => i.Riadok == riadok && i.Stlpec == stlpec);
    public void VykonajKrok()
    {
        Console.WriteLine($"Herný krok {hernyKrok}:\n");
        budovy.ForEach(i => i.Aktualizuj(this));
        hernyKrok++;
    }
}
