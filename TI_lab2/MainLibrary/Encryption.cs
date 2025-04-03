namespace MainLibrary
{
    public partial class Stream_encryption
    {
        public static class Encryption
        {
            public static byte[] plainText;
            public static byte[] cipherText;

            public static void Encrypt(byte[] generatedKey)
            {
                cipherText = new byte[plainText.Length];
                for (int i = 0; i < cipherText.Length; i++)
                {
                    cipherText[i] = (byte)(generatedKey[i] ^ plainText[i]);
                }
            }
        }
    }
}
