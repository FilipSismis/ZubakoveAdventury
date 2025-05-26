namespace ZubakoveAdventury3;

internal class Program
{
    private List<IPrikaz> prikazy = new();
    
    public void PridajPrikaz(IPrikaz prikaz) => prikazy.Add(prikaz);
    public void Vypis() => prikazy.ForEach(i => Console.WriteLine(i.GetNazov()));
    public void Spusti(Plocha plocha)
    {
        foreach (var prikaz in prikazy)
        {
            prikaz.Vykonaj(plocha.Robot);
            plocha.Vypis();
        }
    }
}
