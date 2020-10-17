using System;

namespace WaterJugProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter m: ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter d: ");
            int d = Convert.ToInt32(Console.ReadLine());

            Program p = new Program();
            p.FillJug(m, n, d);

            Console.ReadKey();

        }

        public void FillJug(int m, int n, int d)
        {
            int jug1 = 0;
            int jug2 = 0;

            while(jug1 != d || jug2 != d)
            {
                // Fill jug1
                if (jug1 == 0) 
                { 
                    jug1 = 3;
                    Console.WriteLine(jug1 + "," + jug2);
                }

                // Fill jug2 if jug1 is full. Empty jug1.
                if(jug1 == m) 
                {
                    if(jug2 == 0)
                    {
                        jug2 = jug1;
                        jug1 = 0;
                        Console.WriteLine(jug1 + "," + jug2);
                    }
                    if(jug2 != 0)
                    {
                        jug2 += jug1;
                        jug1 = 0;
                        Console.WriteLine(jug1 + "," + jug2);
                    }
                }

                // Empty jug2 if full.
                if(jug2 == n)
                {
                    jug2 = 0;
                    Console.WriteLine(jug1 + "," + jug2);
                }
            }
        }
    }
}
