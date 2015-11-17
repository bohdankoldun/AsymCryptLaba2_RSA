using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.IO;


namespace lab2AsymCrypt
{
    class PrimeNumber
    {
        public static BigInteger getPrimeNumber(int length)
        {

            BigInteger x;
            BigInteger n1;
            BigInteger m0;
            string strN1 = "";

            //раховуємомо верхнє число проміжку [n0,n1]
            for (int i = 0; i < length; i++)
                strN1 += 1;
            n1 = strN1.Aggregate(new BigInteger(), (b, c) => b * 2 + c - '0');

            //генеруємо випадкове число в проміжку [n0,n1]
            x = GeneratorBigInteger.fixedGenerateNumber(length);

            //визначаєм найменше непарне
            if (x % 2 == 1)
                m0 = x;
            else
                m0 = x + 1;

            Console.WriteLine();

            //шукаєм переше просте
            for (BigInteger temp = m0; temp < n1; temp += 2)
            {
                Console.WriteLine(temp.ToString("X"));

                if (DivisionTest.verifyPrime(temp) == true)
                    if (MillerRabinTest.verifyPrime(temp, length, 20) == true)
                        return temp;
            }


            return getPrimeNumber(length);

        }
    }
}
