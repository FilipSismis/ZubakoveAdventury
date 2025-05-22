namespace ZubakoveAdventury2;

internal abstract class Shifter : Operation
{
    public string Shift(string input)
    {
        char[]result = new char[input.Length];
        for(int i = 0; i < input.Length; i++)
        {
            result[i] = CharOperation(i + 1, input[i]);
        }
        return new string(result);
    }

    public char ShiftChar(char character, int amount) => (char)(character + amount);

    public abstract char CharOperation(int charIndex, char character);
}
