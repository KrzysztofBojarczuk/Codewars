using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    using System.Text;

    public class RangeExtraction
    {
        public string Extract(int[] args)
        {
            if (args == null || args.Length == 0)
                return "";

            StringBuilder result = new StringBuilder();
            int startRange = args[0];
            int endRange = args[0];

            for (int i = 1; i < args.Length; i++)
            {
                if (args[i] == endRange + 1)
                {
                    endRange = args[i];
                }
                else
                {
                    if (startRange == endRange)
                    {
                        result.Append(startRange).Append(",");
                    }
                    else if (endRange - startRange == 1)
                    {
                        result.Append(startRange).Append(",").Append(endRange).Append(",");
                    }
                    else
                    {
                        result.Append(startRange).Append("-").Append(endRange).Append(",");
                    }

                    startRange = endRange = args[i];
                }
            }

            // Handle the last range
            if (startRange == endRange)
            {
                result.Append(startRange);
            }
            else if (endRange - startRange == 1)
            {
                result.Append(startRange).Append(",").Append(endRange);
            }
            else
            {
                result.Append(startRange).Append("-").Append(endRange);
            }

            return result.ToString();
        }
    }
}
