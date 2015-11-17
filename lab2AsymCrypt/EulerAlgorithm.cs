using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace lab2AsymCrypt
{
    class EulerAlgorithm
    {
        public static BigInteger gcd(BigInteger a, BigInteger b)
        {
            while (b != 0)
                b = a % (a = b);
            return a;
        }

        public static BigInteger inverse(BigInteger a, BigInteger m)
        {
            BigInteger x, y;
            BigInteger g = gcdFull(a, m, out x, out y);
            if (g != 1)
                throw new ArgumentException();
            return (x % m + m) % m;
        }

        private static BigInteger gcdFull(BigInteger a, BigInteger b, out BigInteger x, out BigInteger y)
        {
            if (a == 0)
            {
                x = 0;
                y = 1;
                return b;
            }
            BigInteger x1, y1;
            BigInteger d = gcdFull(b % a, a, out x1, out y1);
            x = y1 - (b / a) * x1;
            y = x1;
            return d;
        }
    }
}
