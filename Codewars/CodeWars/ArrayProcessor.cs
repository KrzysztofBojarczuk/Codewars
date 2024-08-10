using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars.CodeWars
{
    public class ArrayProcessor
    {
        public int[] CountPositivesSumNegatives(int[] arr)
        {
            //if (arr == null || arr.Length == 0)
            //{
            //    return new int[0];
            //}

            //int countPositives = 0;
            //int sumNegatives = 0;

            //foreach (int num in arr)
            //{
            //    if (num > 0)
            //    {
            //        countPositives++;
            //    }
            //    else if (num < 0)
            //    {
            //        sumNegatives += num;
            //    }
            //}

            //return new int[] { countPositives, sumNegatives };

            if (arr == null || arr.Length == 0)
            {
                return new int[0];
            }

            int countPositives = arr.Count(num => num > 0);
            int sumNegatives = arr.Where(num => num < 0).Sum();

            return new int[] { countPositives, sumNegatives };
        }
    }
}
