namespace ZubakoveAdventury3;

internal class Vlavo : IPrikaz
{
    public string GetNazov() => "vlavo";
    public void Vykonaj(Robot robot) => robot.Vlavo();
}
