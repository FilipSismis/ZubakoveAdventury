namespace ZubakoveAdventury2;

internal class WaveShifter(int _shift) : Shifter
{
    public override char CharOperation(int charIndex, char character) => charIndex % 2 == 0 ? ShiftChar(character, _shift) : ShiftChar(character, _shift * -1);

    public override string Decrypt(string text) => Shift(text);

    public override string Encrypt(string text) => Shift(text);
}
