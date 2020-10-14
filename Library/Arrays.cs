using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Arrays
    {
        static List<object> Array1(int N)
        {
            List<object> array = new List<object>();
            int num = 1;
            while (num <= N)
            {
                array.Add(num);
                num += 2;
            }
            return array;
        }
        public List<object> Array3(int N, int A, int D)
        {
            List<object> nums = new List<object>();
            for (int i = 0; i < N; i++)
                nums.Add(A + D * i);
            return nums;
        }
        public List<object> Array5(int N)
        {
            List<object> nums = new List<object>();
            int num1 = 0;
            int num2 = 1;
            int num3 = 0;
            while (N > 0)
            {
                nums.Add(num2);
                num3 = num2 + num1;
                num1 = num2;
                num2 = num3;
                N--;
            }
            return nums;
        }
        public void WriteDownLineOfShit(List<object> things)
        {
            foreach (object a in things)
                Console.Write(a + " ");
        }
    }
}
