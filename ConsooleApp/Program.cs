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
            int[] nums = {3,4,2,1,5,6,8,6};
            List<object> a = Array19(nums);
            WriteDownLineOfShit(a);
            Console.ReadKey();
        }
        static List<object> Array19(int[] nums)
        {
            List<object> numsList = new List<object>();
            for (int i = 1; i < nums.Length - 1; i++)
                if (nums[i] > nums[0] && nums[i] < nums[nums.Length - 1])
                    numsList.Add(nums[i]);
            if (numsList.Count == 0)
                numsList.Add(0);
            return numsList;
        }
        static void WriteDownLineOfShit(List<object> things)
        {
            foreach(object a in things)
                Console.Write(a + " ");
        }
    }
}
