using System;
using System.Numerics;

class WeAllLoveBits
{
    static void Main()
    {
        long N = Convert.ToInt32(Console.ReadLine());
        long[] arrayOfN = new long[N];
        string[] binaryN = new string[N];
        BigInteger[] binToInt = new BigInteger[N];      
        //Input numbers
        for (int i = 0; i < N; i++)
        {
            arrayOfN[i] = Convert.ToInt64(Console.ReadLine());   
        }
        //From decimal to binary
        for (int i = 0; i < N; i++)
        {
            binaryN[i] = Convert.ToString(arrayOfN[i], 2);
        }
        for (int i = 0; i < N; i++)
        {
            binToInt[i] = BigInteger.Parse(binaryN[i]);
        }
        for (int d = 0; d < N; d++)
        {
            BigInteger[] output = new BigInteger[binaryN[d].Length];
            for (int i = 0; i < binaryN[d].Length; i++)//1011
            {
                output[i] = binToInt[d] % 10;
                binToInt[d] = binToInt[d] / 10;
            }
            string mainOutput = null;
            for (int i = 0; i < binaryN[d].Length; i++)
            {              
               mainOutput =  mainOutput + "" + Convert.ToString(output[i]);
            }
            Console.WriteLine(Convert.ToInt32(mainOutput, 2));
        }                                          
    }
}

