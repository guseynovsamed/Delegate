using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatePraktiki
{
    public class DelegatePredicate
    {

       public delegate bool CheckNums(int a);

       //public bool CheckOddNums(int num)
       //{
       //     return num % 2 == 1;
       //}
       public bool CheckEvenNums(int num)
       {
            return num % 2 == 0;
       }
        
        public void SumNumsWithConditions(List<int> nums , CheckNums func)
       {
            int sum = 0;
            foreach (int item in nums)
            {
                if(func(item))
                {
                    sum += item;
                }
            }
            Console.WriteLine(sum);
       }

        public void ShowResult()
        {
            List<int> nums = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            SumNumsWithConditions(nums,num => num %2 == 1 );
        }



        //public void SumOfGreaterThanThree(List<int> nums)
        //{
        //    int sum = 0;
        //    foreach (int item in nums)
        //    {
        //        if (item > 3)
        //        {
        //            sum += item;
        //        }
        //    }
        //    Console.WriteLine(sum);
        //}
    }
}
