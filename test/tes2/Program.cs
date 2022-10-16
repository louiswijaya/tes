using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tes2
{
    class Program
    {
        public static class RandomUtils
        {
            public static int[] generateArray(int count)
            {
                Random random = new Random();
                int[] values = new int[count];

                for (int i = 0; i < count; ++i)
                    values[i] = random.Next(0,9);
                return values;
            }
        }
        static void Main(string[] args)
        {
            int[] lowarr = { 0, 1, 2, 3, 4, 5 };
            int[] hgharr = { 5, 6, 7, 8, 9 };
            int masklow,low=0, high=0;
            int w=0,z,k=0;
            int[] check=new int[10];
            Random randNum = new Random();
            Random random = new Random();
            Console.Write("Banyak Data Array: ");
            int a = Convert.ToInt16(Console.ReadLine());
            int[] values = RandomUtils.generateArray(a);
            Array.Sort(values);
            for(int i = 0; i < values.Length; i++)
            {
                Array.Sort(values);
                Console.Write(values[i]);
            }
            Console.WriteLine();
            Console.Write("Banyak Data yang ingin disamakan(1-9): ");
            int x = Convert.ToInt32(Console.ReadLine());
            int[] jawaban = new int[x];
            List<int> jwb = new List<int>();
            for (int y = 0; y < x; y++)
            {
                int element = 0;
                int indexlow = randNum.Next(lowarr.Length);
                int indexhigh = randNum.Next(hgharr.Length);
                masklow = lowarr[indexlow];
                for(w = masklow; w != hgharr[indexhigh]+1; w++)
                {
                    //Console.WriteLine(w);
                    for(z = 0; z < values.Length; z++)
                    {
                        if (values[z] == w)
                        {
                            element++;
                            k = element;
                            jwb.Add(k);
                        }
                    }
                }
                Console.WriteLine(y+1 + ". " + "Low = " + lowarr[indexlow] + ", High = " + hgharr[indexhigh] + " ada " + k + " element dalam range " );
            }
            Console.Write("Jawabannya Adalah:");
            for(int i = 0; i < jwb.Count; i++)
            {
                Console.WriteLine(jwb[i]);
            }
            Console.ReadKey();
        }
    }
}
