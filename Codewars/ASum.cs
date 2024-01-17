using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class ASum
    {
        public static long findNb(long m)
        {
            long volume = 0;
            long n = 0;

            while (volume < m)
            {
                n++;
                volume += n * n * n;
            }

            return volume == m ? n : -1;
        }
    }
}
