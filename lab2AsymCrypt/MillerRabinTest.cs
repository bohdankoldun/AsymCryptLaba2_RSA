using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace lab2AsymCrypt
{
    class MillerRabinTest
    {
        public static bool verifyPrime(BigInteger n, int binarylegth, int k)
        {
            if (n < 2)
                return false;

            if (n != 2 && n % 2 == 0)
                return false;

            BigInteger d = n - 1;
            while (d % 2 == 0)
                d >>= 1;


            for (int i = 0; i < k; i++)
            {
                BigInteger a = GeneratorBigInteger.noFixedGenerateNumber(binarylegth);
                a = a % n;
                BigInteger temp = d;
                BigInteger mod = BigInteger.ModPow(a, temp, n);
                while (temp != n - 1 && mod != 1 && mod != n - 1)
                {
                    mod = (mod * mod) % n;
                    temp = temp * 2;
                }
                if (mod != n - 1 && temp % 2 == 0)
                    return false;

            }
            return true;
        }
    }
}
