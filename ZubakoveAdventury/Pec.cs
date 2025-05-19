namespace ZubakoveAdventury;

internal class Pec(int riadok, int stlpec) : Budova(riadok, stlpec, "Pec")
{
    private const int TrvanieZeleznyPlat = 4;
    private const int TrvanieMednyPlat = 5;
    private readonly Surovina[] Vstupy = { Surovina.ZELEZNA_RUDA, Surovina.MEDENA_RUDA };
    public override VyrobnyPlan? ZacniProdukciu(HernySvet hernySvet)
    {
        var budova = (Pec)hernySvet.GetBudova(Riadok, Stlpec)!;
        if (budova.IsInProduction)
            return null;
        foreach (var vstup in Vstupy)
        {
            if (budova.ZiskajSurovinuVOkoli(hernySvet, vstup))
                break;
        }
        if (budova._sklad.Any(i => i == Surovina.ZELEZNA_RUDA))
        {
            budova.VyberSurovinuZoSkladu(Surovina.ZELEZNA_RUDA);
            return new VyrobnyPlan(Surovina.ZELEZNY_PLAT, TrvanieZeleznyPlat);
        }
        if (budova._sklad.Any(i => i == Surovina.MEDENA_RUDA))
        {
            budova.VyberSurovinuZoSkladu(Surovina.ZELEZNA_RUDA);
            return new VyrobnyPlan(Surovina.MEDENY_PLAT, TrvanieMednyPlat);
        }
        return null;
    }
}
