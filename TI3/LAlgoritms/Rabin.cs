using System.Numerics;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;

namespace LAlgoritms
{
    public class Rabin
    {
        public byte[] plainText;
        public byte[] cipherText;
        public BigInteger p;
        public BigInteger q;
        public BigInteger n;
        public BigInteger b;
        private int blockSize;

        public Rabin(BigInteger p, BigInteger q, BigInteger b)
        {
            if (p % 4 != 3)
                throw new ArgumentException("p должно делиться на 4 с остатком 3!");
            if (!IsProbablyPrime(p, 10))
                throw new ArgumentException("p должно быть простым числом!");
            if (q % 4 != 3)
                throw new ArgumentException("q должно делиться на 4 с остатком 3!");
            if (!IsProbablyPrime(q, 10))
                throw new ArgumentException("q должно быть простым числом!");
            this.p = p;
            this.q = q;
            n = p * q;
            if (b >= n)
                throw new ArgumentException("b должно быть меньше n!");
            this.b = b;
            blockSize = (int)(BigInteger.Log2(n) / 8) + 1;
        }

        // Тест Миллера–Рабина для проверки простоты числа (k – число раундов)
        public static bool IsProbablyPrime(BigInteger n, int k)
        {
            if (n < 2)
                return false;
            if (n == 2 || n == 3)
                return true;
            if (n % 2 == 0)
                return false;

            // Представляем n - 1 = d * 2^s
            BigInteger d = n - 1;
            int s = 0;
            while (d % 2 == 0)
            {
                d /= 2;
                s++;
            }
            // Для k раундов теста
            for (int i = 0; i < k; i++)
            {
                BigInteger a = RandomBigInteger(2, n - 2);
                BigInteger x = BigInteger.ModPow(a, d, n);
                if (x == 1 || x == n - 1)
                    continue;
                bool passed = false;
                for (int r = 1; r < s; r++)
                {
                    x = BigInteger.ModPow(x, 2, n);
                    if (x == n - 1)
                    {
                        passed = true;
                        break;
                    }
                }
                if (!passed)
                    return false;
            }
            return true;
        }

        // Генерация случайного BigInteger в диапазоне от min до max включительно
        private static BigInteger RandomBigInteger(BigInteger min, BigInteger max)
        {
            if (min > max)
                throw new ArgumentException("min должно быть не больше max");

            BigInteger diff = max - min + 1;
            int bytes = (int)Math.Ceiling(BigInteger.Log(diff, 256));
            byte[] rndBytes = new byte[bytes + 1];
            BigInteger r;
            using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
            {
                do
                {
                    rng.GetBytes(rndBytes);
                    rndBytes[rndBytes.Length - 1] = 0; // гарантируем положительность
                    r = new BigInteger(rndBytes);
                }
                while (r < 0 || r >= diff);
            }
            return min + r;
        }

        public void CipherTextToBytes(BigInteger[] cipherText_int)
        {
            cipherText = new byte[cipherText_int.Length * blockSize];
            for (int i = 0; i < cipherText.Length; i += blockSize)
            {
                for (int j = i + blockSize - 1; j >= i; j--)
                {
                    cipherText[j] = (byte)(cipherText_int[i / blockSize] & 0xFF);
                    cipherText_int[i / blockSize] >>= 8;
                }
            }
        }

        public BigInteger[] BytesToCipherText(byte[] byteArr)
        {
            BigInteger[] result = new BigInteger[byteArr.Length / blockSize + (byteArr.Length % blockSize == 0 ? 0 : 1)];
            for (int j = 0, i = 0; j < result.Length; j++, i += blockSize)
            {
                for (int k = 0; k < blockSize && (i + k) < byteArr.Length; k++)
                {
                    result[j] <<= 8;
                    result[j] += byteArr[i + k];
                }
            }
            return result;
        }

        // Функция шифрования (используется формула: c = m^2 + b*m mod n)
        public BigInteger[] Encrypt()
        {
            BigInteger[] result = new BigInteger[plainText.Length];
            for (int i = 0; i < plainText.Length; i++)
            {
                result[i] = (plainText[i] * (plainText[i] + b)) % n;
            }
            return result;
        }

        private BigInteger[] EuclidEx(BigInteger a, BigInteger b)
        {
            BigInteger d0 = a, d1 = b, x0 = 1, x1 = 0, y0 = 0, y1 = 1;
            while (d1 > 1)
            {
                BigInteger q = d0 / d1;
                BigInteger d2 = d0 % d1;
                BigInteger x2 = x0 - q * x1;
                BigInteger y2 = y0 - q * y1;
                d0 = d1;
                d1 = d2;
                x0 = x1;
                x1 = x2;
                y0 = y1;
                y1 = y2;
            }
            return [x1, y1];
        }

        private BigInteger FastExp(BigInteger a, BigInteger z, BigInteger n)
        {
            BigInteger a1 = a, z1 = z, x = 1;
            while (z1 != 0)
            {
                while (z1 % 2 == 0)
                {
                    z1 /= 2;
                    a1 = (a1 * a1) % n;
                }
                z1--;
                x = (x * a1) % n;
            }
            return x;
        }

        public BigInteger[] GetRoots(BigInteger c)
        {
            BigInteger D = (b * b + 4 * c) % n;
            BigInteger mp = FastExp(D, (p + 1) / 4, p);
            BigInteger mq = FastExp(D, (q + 1) / 4, q);
            BigInteger[] y = EuclidEx(p, q);
            BigInteger[] d = new BigInteger[4];
            d[0] = (y[0] * p * mq + y[1] * q * mp) % n;
            d[1] = n - d[0];
            d[2] = (y[0] * p * mq - y[1] * q * mp) % n;
            d[3] = n - d[2];
            BigInteger[] m = new BigInteger[4];
            for (int i = 0; i < 4; i++)
            {
                if ((d[i] - b) % 2 == 0)
                {
                    m[i] = ((-b + d[i]) / 2) % n;
                }
                else
                {
                    m[i] = ((-b + n + d[i]) / 2) % n;
                }
            }
            return m;
        }

        public void Decipher()
        {
            BigInteger[] plain = BytesToCipherText(plainText);
            byte[] result = new byte[plain.Length];

            for (int i = 0; i < plain.Length; i++)
            {
                BigInteger[] roots = GetRoots(plain[i]);
                for (int j = 0; j < roots.Length; j++)
                    if (roots[j] <= 255 && roots[j] >= 0)
                    {
                        result[i] = (byte)roots[j];
                        break;
                    }
            }
            cipherText = result;
        }
    }
}
