using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    
     class Drawing
    {
         public static void Main(string[] args)
         {
             // Draw W , VKin' , Vuong , VuongRong~ , I , U , V , A
             //Drawing.DrawU(4);
             // Draw X , + ,  A Gach Ngang
             Drawing.DrawU(5);
         }
        private static void Setup(char[,] arr , int n)
        {
            for(int d = 0 ; d<n;d++)
                for(int c = 0;c<n;c++)
                    arr[d,c] = ' ';
         }
        private static void Print(char[,]arr , int n)
        {
            for(int d = 0 ; d<n;d++)
            {
                for(int c = 0 ; c<n;c++)
                    Console.Write(arr[d,c]);
                Console.WriteLine();
            }
        }
        public static void DrawU(int n)
        {
            char[,] arr = new char[4*n, 4*n];
            Setup(arr,n*4);
            for(int i =0;i<n;i++)
            {
              // Draw W
                //arr[i, i] = 'W';
                //arr[i, n + 2 - i] = 'W';
                //arr[i, n + 2 + i] = 'W';
                //arr[i, n + 8 - i] = 'W';

              // Draw VKin'
                //arr[0, i] = 'v';
                //arr[i, i] = 'v';
                //arr[0, n - 1 + i] = 'v';
                //arr[i, n + 2 - i] = 'v';

              // Draw Vuong
                //arr[i, 0] = 'o';
                //arr[i, 1] = 'o';
                //arr[i, 2] = 'o';
                //arr[i, 3] = 'o';

              // Draw VuongRong~
                //arr[i, 0] = 'o';
                //arr[i, n - 1] = 'o';
                //arr[n - 1, i] = 'o';
                //arr[n - 4, i] = 'o';

              // Draw I
                //arr[i, 0] = 'i';

              // Draw U
                //arr[i, 0] = 'u';
                //arr[i, n - 1] = 'u';
                //arr[n - 1, i] = 'u';

              // Draw V
                //arr[i, i] = 'v';
                //arr[i, n + 2 - i] = 'v';

              // Draw A
                //arr[n - 1 - i, n + 2 - i] = 'A';
                //arr[n - 1 - i, i] = 'A';
                //arr[n - 1, i] = 'A';
                //arr[n - 1, n + 1 - i] = 'A';
            
            // Draw X
                //arr[i, i] = 'x';
                //arr[i, n - 1 - i] = 'x';
            // Draw +
                //arr[i, n - 3] = '+';
                //arr[n - 3, i] = '+';  
            // Draw A Gach Ngang
                arr[n - 1 - i, n + 3 - i] = 'A';
                arr[n - 1 - i, i] = 'A';
                arr[n - 3, n - 3 + i] = 'A';  
            }
            Print(arr,4*n);
        }
        }
    }

