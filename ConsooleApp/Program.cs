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
            int[] nums = {8,4,2,1};
            List<object> a = Array7(nums);
            WriteDownLineOfShit(a);
            Console.ReadKey();
        }
        static List<object> Array7(int[] nums)
        {
            List<object> numsList = new List<object>();
                            
            return numsList;
        }
        static void WriteDownLineOfShit(List<object> things)
        {
            foreach(object a in things)
                Console.Write(a + " ");
        }
    }
}
