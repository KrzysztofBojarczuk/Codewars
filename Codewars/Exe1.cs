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

        public void DispalyNumberByFrequency()
        {
            var n = from x in Number
                    group x by x into y
                    select y;

            foreach (var arrNo in n)
            {
                Console.WriteLine("Number " + arrNo.Key + " appears " + arrNo.Count() + " times");
            }

            Console.WriteLine("-------------------");

            var nx = Number.GroupBy(number => number)
                          .Select(x => new { Number = x.Key, Appears = x.Count() })
                          .ToList();

            foreach (var arrNo in nx)
            {
                Console.WriteLine("Number " + arrNo.Number  + " appears " + arrNo.Appears  + " times");
            }
        }

        public void DispalyCharacterFrequency()
        {
            string str; 

            Console.Write("\nLINQ : Display the characters and frequency of character from giving string : ");
            Console.Write("\n----------------------------------------------------------------------------\n");
            Console.Write("Input the string : ");


            str = Console.ReadLine();
            Console.Write("\n");

            var FreQ = from x in str
                       group x by x into y
                       select y;

            Console.Write("The frequency of the characters are :\n");
            
            foreach (var ArrEle in FreQ)
            {
                Console.WriteLine("Character " + ArrEle.Key + ": " + ArrEle.Count() + " times");
            }

            var FreQ2 = str.GroupBy(x => x);

            Console.WriteLine("====================================");

            Console.Write("The frequency of the characters are :\n");
            
            foreach (var ArrEle in FreQ2)
            {
                Console.WriteLine("Character " + ArrEle.Key + ": " + ArrEle.Count() + " times");
            }
        }
    } 
}
