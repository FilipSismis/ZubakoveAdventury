namespace ZubakoveAdventury2;

internal abstract class Operation
{
    public abstract string Encrypt(string text);

    public abstract string Decrypt(string text);
}
