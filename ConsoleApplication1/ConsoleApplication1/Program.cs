using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("hello github");
            Console.WriteLine("Nhap so kiem tra chan");
            int Even = int.Parse(Console.ReadLine());
            Console.WriteLine(IsEven(Even));
            Console.WriteLine("Nhap so kiem tra le");
            int Odd = int.Parse(Console.ReadLine());
            Console.WriteLine(IsOdd(Odd));
            Console.WriteLine("Nhap so kiem tra nguyen to");
            int Prime = int.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(Prime));
            Console.WriteLine("Nhap so kiem tra Pow");
            Console.Write("Nhap so kiem tra Nguyen : ");
            int Pow = int.Parse(Console.ReadLine());
            Console.Write("Nhap so kiem tra Mu : ");
            int Pows = int.Parse(Console.ReadLine());
            Console.WriteLine(Pow + "^" + Pows + "=" + pow(Pow,Pows));
            Console.WriteLine("Nhap so kiem tra gia tri tuyet doi");
            int ABS = int.Parse(Console.ReadLine());
            Console.WriteLine(abs(ABS));
            Console.WriteLine("Nhap so kiem tra Ceil");
            float ceil = float.Parse(Console.ReadLine());
            Console.WriteLine(Ceil(ceil));
            Console.WriteLine("Nhap so kiem tra Floor");
            float fl = float.Parse(Console.ReadLine());
            Console.WriteLine(Floor(fl));
            Console.WriteLine("Nhap so kiem tra giai thua");
            int fac = int.Parse(Console.ReadLine());
            Console.WriteLine(Factorial(fac));
            Console.WriteLine("Nhap so kiem tra Rand2");
            Console.WriteLine(Rand2());
            Console.WriteLine("Nhap so kiem tra Rand1");
            Console.WriteLine(Rand1());
            Console.WriteLine("Nhap so kiem tra mu 2");
            int sq = int.Parse(Console.ReadLine());
            Console.WriteLine(Square(sq));
            Console.WriteLine("Nhap so kiem tra mu 3");
            int cu = int.Parse(Console.ReadLine());
            Console.WriteLine(Cube(cu));
        }
        public static bool IsOdd(int n)
        {
            for (int i = 0; i < n; i++)
            {
                if (n % 2 == 0)
                    return false;
            }
            return true;
        }
        public static bool IsEven(int n)
        {
            for (int i = 0; i < n; i++)
            {
                if (n % 2 == 0)
                    return true;
            }
            return false;
        }
        public static bool IsPrime(int n)
        {
            if (n <= 1)
            {
                return false;
            }
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
        public static int pow(int x, int y)
        {
            int r = 1;
            for (int i = 1; i <= y; i++)
            {
                r = r * x;
            }
            return r;
        }
        public static int abs(int n)
        {
            if (n < 0)
                n = n * -1;
            return n;
        }
        public static int Ceil(float x)
        {
            int a = (int)x;
            if (x > 0)
                if (x > a)
                    a = a + 1;
            return a;
        }
        public static int Floor(float x)
        {
            int a = (int)x;
            if (x < 0 && x != a)
                a = a - 1;
            return a;
        }
        public static int Square(int n)
        {
            n = n * n;
            return n;
        }
        public static int Cube(int n)
        {
            n = n * n * n;
            return n;
        }
        public static float Rand2()
        {               
            Random rd =  new Random();
            Double R = rd.NextDouble();
            return (float)R;
        }
        public static int Rand1()
        {
            int r = 2;
            for (int i = 1; i <= 31; i++)
            {
                r = r * i;
            }
            Random rds = new Random();
            int so = rds.Next(0, r - 1);
            return so;
        }
        public static long Factorial(long n)
        {
            long f = 1;
            for (long i = 2; i <=n; i++)
            {
                f = f * i;
            }
            return f;
        }
    }
}



