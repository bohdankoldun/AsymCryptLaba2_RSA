using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Threading;

namespace lab2AsymCrypt
{
    class GeneratorBigInteger
    {
        public static BigInteger fixedGenerateNumber(int binaryLength)
        {
            BigInteger result;
            string strResult = "1";
            Random rand = new Random();

            for (int i = 0; i < binaryLength - 1; i++)
                strResult += rand.Next(0, 2);

            result = strResult.Aggregate(new BigInteger(), (b, c) => b * 2 + c - '0');

            Thread.Sleep(100);
            return result;
        }

        public static BigInteger noFixedGenerateNumber(int binaryLength)
        {
            BigInteger result;
            string strResult = "";
            Random rand = new Random((int)DateTime.Now.Millisecond);
            int length = rand.Next(0, binaryLength + 1);

            for (int i = 0; i < length; i++)
                strResult = strResult + rand.Next(0, 2);


            result = strResult.Aggregate(new BigInteger(), (b, c) => b * 2 + c - '0');
            if (result == 0 || result == 1)
                return noFixedGenerateNumber(binaryLength);

            Thread.Sleep(100);
            return result;
        }
    }
}
