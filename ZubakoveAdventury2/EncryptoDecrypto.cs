namespace ZubakoveAdventury2;

internal class EncryptoDecrypto
{
    private readonly List<Operation> _operations = new();
    private readonly List<Operation> _reversedOperations = new();
    public EncryptoDecrypto(string password)
    {
        var splitPassword = password.Split(' ');
        for (int i = 0; i < splitPassword.Length; i++)
        {
            switch (splitPassword[i])
            {
                case "L":
                    _operations.Add(new LetterSwitcher(int.Parse(splitPassword[i + 1])));
                    _reversedOperations.Add(new LetterSwitcher(int.Parse(splitPassword[i + 1])));
                    break;
                case "W":
                    _operations.Add(new WaveShifter(int.Parse(splitPassword[i + 1])));
                    _reversedOperations.Add(new WaveShifter(int.Parse(splitPassword[i + 1]) * -1));
                    break;
                case "S":
                    _operations.Add(new ShiftShifter(int.Parse(splitPassword[i + 1]), int.Parse(splitPassword[i + 2])));
                    _reversedOperations.Add(new ShiftShifter(int.Parse(splitPassword[i + 1]) * -1, int.Parse(splitPassword[i + 2])));
                    break;
                default:
                    break;
            }
        }
        _reversedOperations.Reverse();
    }
    public string Encrypt(string text)
    {
        var result = text;
        _operations.ForEach(o => result = o.Encrypt(result));
        return result;
    }

    public string Decrypt(string text) 
    {
        var result = text;
        _reversedOperations.ForEach(o => result = o.Encrypt(result));
        return result;
    }

    public void WriteToFile(string text, string file) => File.WriteAllText(file, text);

    public string ReadFromFile(string file) => File.ReadAllText(file);
}
