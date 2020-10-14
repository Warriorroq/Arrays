using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsooleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {8,4,2,1,5,6,8,4};
            List<object> a = Array11(nums,2);
            WriteDownLineOfShit(a);
            Console.ReadKey();
        }
        static List<object> Array11(int[] nums,int K)
        {
            List<object> numsList = new List<object>();
            for(int i = K - 1;i <= (nums.Length - 1);i+=K)
                numsList.Add(nums[i]);
            return numsList;
        }
        static void WriteDownLineOfShit(List<object> things)
        {
            foreach(object a in things)
                Console.Write(a + " ");
        }
    }
}
