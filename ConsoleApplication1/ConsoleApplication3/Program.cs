using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] array = new int[10];
            Int(array);
        }

        public static void Int(int[] iArr)
        {
            for (int i = 0; i < iArr.Length; i++)
            {
                Console.WriteLine("A[{0}] ", i);
                string str = Console.ReadLine();
                iArr[i] = int.Parse(str);
            }
        }
        public static bool IsContain5(int[] iArr)
        {
            for (int i = 0; i < iArr.Length; i++)
            {
                if (iArr[i] == 5)
                    return true;
            }
            return false;
        }
        public static bool IsContain5or6(int[] iArr)
        {
            for (int i = 0; i < iArr.Length; i++)
            {
                if (iArr[i] == 5 || iArr[i] == 6)
                    return true;
            }
            return false;
        }
        public static bool IsContain5and6(int[] iArr)
        {
            for (int i = 0; i < iArr.Length; i++)
            {
                for (int j = 0; j < iArr.Length; j++)
                {
                    if (iArr[i] == 5 && iArr[j] == 6)
                        return true;
                }
            }
            return false;
        }
        public static int Count5(int[] iArr)
        {
            int count = 0;
            for (int i = 0; i < iArr.Length; i++)
            {
                if (iArr[i] == 5)
                    count++;
            }
            return count;
        }
        public static int Count5or6(int[] iArr)
        {
            int count = 0;
            for ( int i = 0 ; i <iArr.Length;i++)
            {
                if(iArr[i] == 5 || iArr[i] == 6)
                    count++;
            }
            return count;
        }
        public static int Sum(int[] iArr)
        {
            int sum = 0;
            for(int i = 0 ; i < iArr.Length;i++)
            {
                sum = sum + iArr[i];
            }
            return sum;
        }
    }
}
