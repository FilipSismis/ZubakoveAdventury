namespace ZubakoveAdventury;

internal class VrtnaSuprava : Budova
{
    private Surovina _taznaSurovina;
    private const int TrvanieTazenia = 4;
    public VrtnaSuprava(int riadok, int stlpec, Surovina surovina) : base(riadok, stlpec, "Vŕtna Súprava")
    {
        if (surovina == Surovina.ZELEZNA_RUDA || surovina == Surovina.MEDENA_RUDA)
            _taznaSurovina = surovina;
        else
            throw new ArgumentException($"Vrtná súprava nedokáže ťažiť túto surovinu: {surovina}");
    }
    public override VyrobnyPlan? ZacniProdukciu(HernySvet hernySvet)
    {
        var budova = hernySvet.GetBudova(Riadok, Stlpec);
        if (budova!.IsInProduction)
            return null;
        return new VyrobnyPlan(_taznaSurovina, TrvanieTazenia);
    }
}
