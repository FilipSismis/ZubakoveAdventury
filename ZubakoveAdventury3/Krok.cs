namespace ZubakoveAdventury3;

internal class Krok : IPrikaz
{
    public string GetNazov() => "krok";

    public void Vykonaj(Robot robot) => robot.Krok();
}
