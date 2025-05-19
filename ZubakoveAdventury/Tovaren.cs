namespace ZubakoveAdventury;

internal class Tovaren(int riadok, int stlpec) : Budova(riadok, stlpec, "Továreň")
{
    private const int TrvanieElektronickyObvod = 6;
    private const int TrvanieKabel = 2;
    private readonly Surovina[] Vstupy = { Surovina.ZELEZNY_PLAT, Surovina.MEDENY_PLAT };
    public override VyrobnyPlan? ZacniProdukciu(HernySvet hernySvet)
    {
        var budova = (Tovaren)hernySvet.GetBudova(Riadok, Stlpec)!;
        if (budova.IsInProduction)
            return null;
        foreach (var vstup in Vstupy)
        {
            if (budova.ZiskajSurovinuVOkoli(hernySvet, vstup))
                break;
        }
        if (budova._sklad.Any(i => i == Surovina.ZELEZNY_PLAT) && budova._sklad.Any(i => i == Surovina.MEDENY_PLAT))
        {
            budova.VyberSurovinuZoSkladu(Surovina.ZELEZNY_PLAT);
            budova.VyberSurovinuZoSkladu(Surovina.MEDENY_PLAT);
            return new VyrobnyPlan(Surovina.ELEKTRONICKY_OBVOD, TrvanieElektronickyObvod);
        }
        if (budova._sklad.Any(i => i == Surovina.MEDENY_PLAT))
        {
            budova.VyberSurovinuZoSkladu(Surovina.MEDENY_PLAT);
            return new VyrobnyPlan(Surovina.KABEL, TrvanieKabel);
        }
        return null;
    }
}
