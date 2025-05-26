namespace ZubakoveAdventury3;

internal class Plocha
{
    private const char maxZnaciekNaPolicku = '9';
    public Robot Robot { get; }
    private char[,] hraciaPlocha;
    public Plocha()
    {
        Robot = new Robot(this);
        hraciaPlocha = new char[10,10];
    }

    public void Poloz(int x, int y) 
    {
        if (hraciaPlocha[x, y] == '\0')
        {
            hraciaPlocha[x, y] = '1';
            return;
        }

        if (hraciaPlocha[x, y] == maxZnaciekNaPolicku)
            throw new MaxPocetZnaciekException("Nemozes polozit dalsi marker na toto policko");

        hraciaPlocha[x, y]++;
    }

    public void Zdvihni(int x, int y)
    {
        if (hraciaPlocha[x, y] == '\0')
            throw new MaxPocetZnaciekException("Na danom poli nie su ziadne znacky");

        if (hraciaPlocha[x, y] == '1')
        {
            hraciaPlocha[x, y] = '\0';
            return;
        }

        hraciaPlocha[x, y]--;
    }

    public void Vypis()
    {
        for(int y = 0; y < hraciaPlocha.GetLength(0); y++)
        {
            for(int x = 0; x < hraciaPlocha.GetLength(1); x++)
            {
                if(Robot.JeNaPozicii(x, y))
                    Console.Write(Robot.GetReprezentacia());
                else if (hraciaPlocha[x,y] != '\0')
                    Console.Write(hraciaPlocha[x, y]);
                else
                    Console.Write('.');
            }
            Console.Write("\n");
        }
        Console.WriteLine();
    }
}
