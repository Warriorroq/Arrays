using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Arrays
    {
        public List<object> Array1(int N)
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
        //3
        public List<object> Array7(int[] nums)
        {
            List<object> numsList = new List<object>();
            for (int i = nums.Length - 1; i >= 0; i--)
                numsList.Add(nums[i]);
            return numsList;
        }
        public List<object> Array9(int[] nums)
        {
            List<object> numsList = new List<object>();
            for (int i = nums.Length - 1; i >= 0; i--)
                if (nums[i] % 2 == 0)
                    numsList.Add(nums[i]);
            numsList.Add("count: " + numsList.Count);
            return numsList;
        }
        public List<object> Array11(int[] nums, int K)
        {
            List<object> numsList = new List<object>();
            for (int i = K - 1; i <= (nums.Length - 1); i += K)
                numsList.Add(nums[i]);
            return numsList;
        }
        //6
        public List<object> Array13(int[] nums)
        {
            List<object> numsList = new List<object>();
            for (int i = nums.Length - 1; i >= 0; i -= 2)
                numsList.Add(nums[i]);
            return numsList;
        }
        public List<object> Array15(int[] nums)
        {
            List<object> numsList = new List<object>();
            for (int i = 0; i <= (nums.Length - 1); i += 2)
                numsList.Add(nums[i]);

            for (int i = nums.Length - (1 + nums.Length % 2); i >= 0; i -= 2)
                numsList.Add(nums[i]);

            return numsList;
        }
        public List<object> Array17(int[] nums)
        {
            List<object> numsList = new List<object>();
            for (int i = 0; i < nums.Length - nums.Length % 2; i += 2)
            {
                numsList.Add(nums[i]);
                numsList.Add(nums[i + 1]);
                numsList.Add(nums[nums.Length - (i + 1)]);
                numsList.Add(nums[nums.Length - (i + 2)]);
            }
            return numsList;
        }
        //9
        public List<object> Array19(int[] nums)
        {
            List<object> numsList = new List<object>();
            for (int i = 1; i < nums.Length - 1; i++)
                if (nums[i] > nums[0] && nums[i] < nums[nums.Length - 1])
                    numsList.Add(nums[i]);
            if (numsList.Count == 0)
                numsList.Add(0);
            return numsList;
        }
        public float Array21(int[] nums, int k, int l)
        {
            float sum = 0;
            for (int i = k - 1; i <= l - 1; i++)
                sum += nums[i];
            sum /= (l - k + 1);
            return sum;
        }
        public float Array23(int[] nums, int K, int L)
        {
            float sum = 0;
            for (int i = 0; i < K - 1; i++)
                sum += nums[i];
            for (int i = L - 1; i < nums.Length - 1; i++)
                sum += nums[i];
            sum /= nums.Length - (L - K + 1);
            return sum;
        }
        //12
        public float Array25(float[] nums)
        {
            float q = nums[1] / nums[0];
            for (int i = 0; i < nums.Length - 2; i++)
                if (nums[i + 1] / nums[i] != q)
                    q = 0;
            return q;
        }
        public List<object> Array27(int[] nums)
        {
            List<object> numsList = new List<object>();
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] < 0 && nums[i + 1] < 0)
                {
                    numsList.Add(" number: " + nums[i + 1]);
                    numsList.Add(" index: " + (i + 2));
                    i = nums.Length;
                }
                else if (nums[i] > 0 && nums[i + 1] > 0)
                {
                    numsList.Add(" number: " + nums[i + 1]);
                    numsList.Add(" index: " + (i + 2));
                    i = nums.Length;
                }
            }
            if (numsList.Count == 0)
                numsList.Add(0);
            return numsList;
        }
        public List<object> Array29(int[] nums)
        {
            List<object> numsList = new List<object>();
            for (int i = 0; i <= (nums.Length - 1); i += 2)
                numsList.Add(nums[i]);
            numsList.Sort();
            numsList[numsList.Count - 1] = "Biggest: " + numsList[numsList.Count - 1];
            return numsList;
        }

        public void WriteDownLineOfShit(List<object> things)
        {
            foreach (object a in things)
                WriteDownLineOfShit(a);
        }
        public void WriteDownLineOfShit(object[] things)
        {
            foreach (object a in things)
                WriteDownLineOfShit(a);
        }
        public void WriteDownLineOfShit(object things)
        {
            Console.Write(things + " ");
        }
    }
}
