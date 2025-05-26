namespace ZubakoveAdventury3;

internal class Vpravo : IPrikaz
{
    public string GetNazov() => "vpravo";
    public void Vykonaj(Robot robot) => robot.Vpravo();
}
