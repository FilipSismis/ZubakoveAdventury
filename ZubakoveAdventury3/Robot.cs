namespace ZubakoveAdventury3;

internal class Robot(Plocha _plocha)
{
    private char _reprezentacia = '>';
    private int _x = 0;
    private int _y = 9;

    public void Vlavo()
    {
        switch (GetReprezentacia())
        {
            case '<':
                _reprezentacia = 'V';
                break;
            case '>':
                _reprezentacia = 'A';
                break;
            case 'A':
                _reprezentacia = '<';
                break;
            case 'V':
                _reprezentacia = '>';
                break;
            default:
                break;
        }
    }
    public void Vpravo()
    {
        switch (GetReprezentacia())
        {
            case '<':
                _reprezentacia = 'A';
                break;
            case '>':
                _reprezentacia = 'V';
                break;
            case 'A':
                _reprezentacia = '>';
                break;
            case 'V':
                _reprezentacia = '<';
                break;
            default:
                break;
        }
    }
    public void Krok()
    {
        switch (GetReprezentacia())
        {
            case '<':
                if(_x - 1 >= 0)
                    _x -= 1;
                break;
            case '>':
                if (_x + 1 <= 9)
                    _x += 1;
                break;
            case 'A':
                if (_y - 1 >= 0)
                    _y -= 1;
                break;
            case 'V':
                if (_y + 1 <= 9)
                    _y += 1;
                break;
            default:
                break;
        }
    }
    public void Poloz() => _plocha.Poloz(_x, _y);
    public void Zdvihni() => _plocha.Zdvihni(_x, _y);
    public bool JeNaPozicii(int x, int y) => x == _x && y == _y;
    public char GetReprezentacia() => _reprezentacia;

}
