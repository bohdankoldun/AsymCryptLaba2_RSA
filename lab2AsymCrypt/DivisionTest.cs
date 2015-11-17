using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace lab2AsymCrypt
{
    class DivisionTest
    {

        public static bool verifyPrime(BigInteger p)
        {
            string strP = p.ToString();

            Dictionary<char, int> decNumbers = new Dictionary<char, int>
            {
               {'0', 0},{'1', 1},{'2', 2},{'3', 3}, {'4', 4},
               {'5', 5},{'6', 6},{'7', 7}, {'8', 8},{'9', 9},
            };

            //перевыряєм чи число p ділиться на 2
            if (dividedBy2(strP, decNumbers) == false)
                return false;

            //перевыряєм чи число p ділиться на 3
            if (dividedBy3(strP, decNumbers) == false)
                return false;

            //перевыряєм чи число p ділиться на 5
            if (dividedBy5(strP, decNumbers) == false)
                return false;

            //перевыряєм чи число p ділиться на 7
            if (dividedBy7(strP, decNumbers) == false)
                return false;

            //перевыряєм чи число p ділиться на 11
            if (dividedBy11(strP, decNumbers) == false)
                return false;

            return true;
        }

        private static bool dividedBy2(string strP, Dictionary<char, int> decNumbers)
        {
            if (decNumbers[strP[strP.Length - 1]] % 2 == 0)
                return false;
            else
                return true;
        }

        private static bool dividedBy3(string strP, Dictionary<char, int> decNumbers)
        {
            int sum = 0;
            for (int i = 0; i < strP.Length; i++)
                sum += decNumbers[strP[i]];

            if (sum % 3 == 0)
                return false;
            else
                return true;
        }

        private static bool dividedBy5(string strP, Dictionary<char, int> decNumbers)
        {
            if (decNumbers[strP[strP.Length - 1]] % 5 == 0)
                return false;
            else
                return true;
        }


        private static bool dividedBy7(string strP, Dictionary<char, int> decNumbers)
        {
            int sum = 0;
            int tempNum = 0, abs = 1;
            for (int i = strP.Length - 1; i >= 0; i -= 3)
            {
                if (i - 2 >= 0)
                    tempNum = decNumbers[strP[i]] + decNumbers[strP[i - 1]] * 10 + decNumbers[strP[i - 2]] * 100;
                if (i - 2 == -1)
                    tempNum = decNumbers[strP[i]] + decNumbers[strP[i - 1]] * 10;
                if (i - 2 == -2)
                    tempNum = decNumbers[strP[i]];

                if (abs % 2 == 0)
                    sum += tempNum;
                else
                    sum -= tempNum;
                abs++;
            }

            if (sum % 7 == 0)
                return false;
            else
                return true;
        }

        private static bool dividedBy11(string strP, Dictionary<char, int> decNumbers)
        {
            int sum = 0;
            int tempNum = 0;
            for (int i = strP.Length - 1; i >= 0; i -= 2)
            {
                if (i - 1 >= 0)
                    tempNum = decNumbers[strP[i]] + decNumbers[strP[i - 1]] * 10;
                if (i - 1 == -1)
                    tempNum = decNumbers[strP[i]];

                sum += tempNum;
            }

            if (sum % 11 == 0)
                return false;
            else
                return true;
        }

    }
}
