using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class Exe1
    {
        public int[] Number { get; set; }

        public Exe1(int[] number)
        {
            Number = number;
        }

        public int[] Calc()
        {
            var nQuery =
                from VrNum in Number
                where (VrNum % 2) == 0
                select VrNum;
            return nQuery.ToArray();


            //return Number.Where(x => x % 2 == 0).ToArray();
        }

        public int[] Range()
        {
            var nQuery =
               from VrNum in Number
               where VrNum > 0
               where VrNum < 12
               select VrNum;

            return nQuery.ToArray();

            //return Number.Where(x => x > 0 && x < 12).ToArray();
        }

        public void DisplayNumbersWithSquaresGreaterThan20()
        {

            var sqNo = from int num in Number
                       let SqrNo = num * num
                       where SqrNo > 20
                       select new { num, SqrNo };

            //var sqNo = Number
            //    .Select(Number => new { Number, SqrNo = Number * Number })
            //    .Where(pair => pair.SqrNo > 20);

            foreach (var a in sqNo)
            {
                Console.WriteLine(a);
            }
        }
    }
}
