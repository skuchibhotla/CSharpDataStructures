using System;

namespace RotateArray
{
    class Program
    {
        static void Main(string[] args)
        {
            const int m = 2;
            int[] image = new int[m*m];

            for(int x=0; x<m; x++)
            {
                for(int y=0; y<m; y++)
                {
                    int _someValue = x*y;
                    image[m*(m-1-y)+x] = _someValue;
                }
            }

            for(int i=0; i<image.Length; i++)
            {
                Console.WriteLine(image[i]);
            }

            Console.ReadKey();
        }
    }
}
