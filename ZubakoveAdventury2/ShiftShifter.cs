namespace ZubakoveAdventury2;

internal class ShiftShifter(int _shift, int _skip) : Shifter
{
    public override char CharOperation(int charIndex, char character) => charIndex % _skip == 0 ? ShiftChar(character, _shift) : character;

    public override string Decrypt(string text) => Shift(text);

    public override string Encrypt(string text) => Shift(text);
}
