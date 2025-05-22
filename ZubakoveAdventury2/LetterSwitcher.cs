namespace ZubakoveAdventury2;

internal class LetterSwitcher(int _step) : Operation
{
    public override string Decrypt(string text)
    {
        var result = text.ToCharArray();
        int i = (text.Length - (text.Length % _step)) - 1;
        for(; i >= 0; i -= _step)
        {
            var swapping = result[i + _step];
            result[i + _step] = result[i];
            result[i] = swapping;
        }
        return new string(result);
    }

    public override string Encrypt(string text)
    {
        var result = text.ToCharArray();
        for(int i = 0; i < text.Length; i++)
        {
            if(_step == i + 1 && i + 1 + _step <= text.Length)
            {
                var swapping = result[i + _step];
                result[i + _step] = result[i];
                result[i] = swapping;
            }
        }
        return new string(result);
    }
}
