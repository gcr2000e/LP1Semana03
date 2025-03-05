using System;
using System.Globalization;

namespace ArrayMul
{
    public class Program
    {
        private static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = 
            CultureInfo.InvariantCulture;

            float[,] a = new float [2,2]
            {
              {float.Parse(args[0]), float.Parse(args[1])},
              {float.Parse(args[2]), float.Parse(args[3])}
            };

            float[] b = new float[2] {float.Parse(args[4]), float.Parse(args[5])};
            float[] ab = new float[2];

            for (int i=0; i < 2; i++)
            {
               ab[i] = 0;
               for (int j=0; j < 2; j++)
               {
                  ab[i] += a[i, j] * b[j];
               }
            }

            foreach(float valor in ab)
            {
              Console.WriteLine("| {0,7:f2} |", valor);
            }
        }
    }
}
