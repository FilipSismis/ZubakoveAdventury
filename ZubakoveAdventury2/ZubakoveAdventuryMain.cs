namespace ZubakoveAdventury2
{
	class ZubakoveAdventuryMain
	{
        static void Main(string[] args)
        {
            var inputText = "Ako sa mas kamo?";
            var filePath = @"D:\Pro\C#\ZubakoveAdventury\ZubakoveAdventury\ZubakoveAdventury2\ZubakoveAdventury2.txt";
            var encryptoDecrypto = new EncryptoDecrypto("L 2 S 15 1 L 3 S 10 3 W 9");
            Console.WriteLine($"Orig: {inputText}");
            var encryptedText = encryptoDecrypto.Encrypt(inputText);
            Console.WriteLine($"Ecnr: {encryptedText}");
            var decryptedText = encryptoDecrypto.Decrypt(encryptedText);
            Console.WriteLine($"Decr: {decryptedText}");
            encryptoDecrypto.WriteToFile(decryptedText, filePath);
            Console.WriteLine($"Defi: {encryptoDecrypto.ReadFromFile(filePath)}");
            Console.ReadKey();
        }
    }
}