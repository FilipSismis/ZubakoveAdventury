namespace ZubakoveAdventury3;

internal class Poloz : IPrikaz
{
    public string GetNazov() => "poloz";

    public void Vykonaj(Robot robot) => robot.Poloz();
}
