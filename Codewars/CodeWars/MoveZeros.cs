using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars.CodeWars
{
    internal class MoveZeroes
    {
        public static int[] MoveZeroesNumber(int[] arr)
        {
            return arr.OrderBy(x => x == 0).ToArray();
        }
    }
}
