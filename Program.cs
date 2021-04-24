using System;
using System.Collections.Generic;

namespace BDD_MBK
{
    class Program
    {
        static void Main()
        {
            List<int> A = new List<int>() { 6, 12, 18 };
            List<int> B = new List<int>(A);
            int DBD = Rekursija(A, "dbd");
            int MBK = Rekursija(B, "mbk");

            Console.WriteLine("Didziausias bendras daliklis: " + DBD);
            Console.WriteLine("Maziausias bendras kartotinis: " + MBK);
        }
        public static int Rekursija(List<int> A, string tipas)
        {
            if (A.Count > 1)
            {
                if (tipas == "dbd")
                    A[0] = dbd(A[0], A[1]);
                else
                    A[0] = mbk(A[0], A[1]);

                A.RemoveAt(1);
                Rekursija(A, tipas);
            }

            return A[0];
        }

        public static int dbd(int a, int b)
        {
            if (a == 0)
                return b;

            return dbd(b % a, a);
        }

        public static int mbk(int a, int b)
        {
            return Math.Abs(a * b) / dbd(a, b);
        }
    }
}
