using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars.CodeWars
{
    public class OppositeNum
    {
        public static int GetOpposite(int number)
        {
            return -number;
        }

        public static int MakePositive(int number)
        {
            return Math.Abs(number);
        }
    }
}
