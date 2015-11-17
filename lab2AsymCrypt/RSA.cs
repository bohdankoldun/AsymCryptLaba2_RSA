using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace lab2AsymCrypt
{
    class RSA
    {
        private BigInteger P;
        private BigInteger Q;

        public BigInteger N { get; private set; }
        public BigInteger E { get; private set; }

        public BigInteger D { get; private set; }

        public void generateKeys(int length)
        {
            P = PrimeNumber.getPrimeNumber(length / 2);
            Q = PrimeNumber.getPrimeNumber(length / 2);
            while (P == Q)
                Q = PrimeNumber.getPrimeNumber(length / 2);

            Console.WriteLine("P = " + P.ToString("X"));
            Console.WriteLine("Q = " + Q.ToString("X"));

            N = P * Q;
            BigInteger funEuler = (P - 1) * (Q - 1);

            do
            {
                E = GeneratorBigInteger.noFixedGenerateNumber(length);
                E = E % funEuler;
            }
            while (EulerAlgorithm.gcd(E, funEuler) != 1);

            D = EulerAlgorithm.inverse(E, funEuler);



        }

        public BigInteger Encrypt(BigInteger M)
        {

            BigInteger C;
            C = BigInteger.ModPow(M, E, N);

            return C;

        }

        public BigInteger Decrypt(BigInteger C)
        {

            BigInteger M;
            M = BigInteger.ModPow(C, D, N);

            return M;

        }


    }
}
