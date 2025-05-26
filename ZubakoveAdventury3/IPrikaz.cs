namespace ZubakoveAdventury3;

internal interface IPrikaz
{
    void Vykonaj(Robot robot);
    string GetNazov();
}
