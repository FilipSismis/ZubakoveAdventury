namespace ZubakoveAdventury;

internal class VyrobnyPlan(Surovina _surovina, int _trvanie)
{
    public string Popis => $"{_surovina} - trvanie: {_trvanie}"; 
    public Surovina? VyrobenaSurovina => _trvanie == 0 ? _surovina : null;   
    public void Aktualizuj()
    {
        _trvanie--;
    }
}
