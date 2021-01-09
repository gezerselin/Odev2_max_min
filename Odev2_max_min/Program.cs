using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2_max_min
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = { 54, 32, 76, 89, 43, 55, 21 };
            int toplam = 0;
            int max = arr[0];
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                toplam += arr[i];
                if (i != 0)
                {
                    if (max < arr[i])
                    {
                        max = arr[i];
                    }
                    if (min > arr[i])
                    {
                        min = arr[i];
                    }
                }
                   
            }
            int ort = toplam / arr.Length;

            Console.WriteLine($"en küçük eleman {min}");
            Console.WriteLine($"en büyük eleman {max}");
            Console.WriteLine($"ortalama {ort}");
            Console.ReadLine();
        }
    }
}
