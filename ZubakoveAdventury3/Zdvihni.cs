namespace ZubakoveAdventury3;

internal class Zdvihni : IPrikaz
{
    public string GetNazov() => "zdvihni";

    public void Vykonaj(Robot robot) => robot.Zdvihni();
}
