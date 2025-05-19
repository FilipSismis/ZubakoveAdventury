namespace ZubakoveAdventury;

internal abstract class Budova(int _riadok, int _stlpec, string _meno)
{
    protected List<Surovina> _sklad = new();
    private VyrobnyPlan? _vyrobnyPlan;

    public int Riadok => _riadok;
    public int Stlpec => _stlpec;
    public bool IsInProduction => _vyrobnyPlan != null;

    public void Aktualizuj(HernySvet hernySvet) 
    {
        var budova = hernySvet.GetBudova(Riadok, Stlpec);
        if(_vyrobnyPlan != null)
        {
            _vyrobnyPlan.Aktualizuj();
            var vyrobenaSurovina = _vyrobnyPlan.VyrobenaSurovina;
            if(vyrobenaSurovina != null)
            {
                PridajSurovinuNaSklad(vyrobenaSurovina.Value);
                _vyrobnyPlan = null;
                Console.WriteLine($"    Budova {_meno} na {Riadok},{Stlpec} vyrobila predmet {vyrobenaSurovina} (počet položiek na sklade: {_sklad.Count(i => i == vyrobenaSurovina)})\n");
            }
        }
        if(_vyrobnyPlan == null)
        {
            _vyrobnyPlan = budova!.ZacniProdukciu(hernySvet);
            if(_vyrobnyPlan != null)
                Console.WriteLine($"    Budova {_meno} na {Riadok},{Stlpec} začala výrobu {_vyrobnyPlan.Popis}\n"); 
        }
    }
    public void PridajSurovinuNaSklad(Surovina surovina) => _sklad.Add(surovina);
    public bool VyberSurovinuZoSkladu(Surovina surovina)
    {
        var result = _sklad.Any(i => i == surovina);
        if (result)
            _sklad.Remove(surovina);
        return result;
    }
    public bool JeNaPozicii(int stlpec, int riadok) => stlpec == Stlpec && riadok == Riadok;
    public bool ZiskajSurovinuVOkoli(HernySvet hernySvet, Surovina surovina)
    {
        if(ZiskajSurovinu(Riadok - 1, Stlpec, hernySvet, surovina)) return true;
        if(ZiskajSurovinu(Riadok, Stlpec + 1, hernySvet, surovina)) return true;
        if(ZiskajSurovinu(Riadok, Stlpec - 1, hernySvet, surovina)) return true;
        if(ZiskajSurovinu(Riadok + 1, Stlpec, hernySvet, surovina)) return true;
        return false;
    }

    public abstract VyrobnyPlan? ZacniProdukciu(HernySvet hernySvet);

    private bool ZiskajSurovinu(int riadok, int stlpec, HernySvet hernySvet, Surovina surovina)
    {
        if (hernySvet.GetBudova(riadok, stlpec) is var budova && budova != null)
        {
            if (budova.VyberSurovinuZoSkladu(surovina))
            {
                PridajSurovinuNaSklad(surovina);
                return true;
            }
        }
        return false;
    }

}
