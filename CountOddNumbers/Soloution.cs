using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountOddNumbers
{
    internal class Soloution
    {
        public int CountOdds(int low, int high)
        {
            var counter = 0;

            for (var i = low; i <= high; i++)
            {
                if (i % 2 != 0)
                {
                    counter++;
                }
            }

            return counter;

            //var oddNums = Enumerable.Range(low, high - low + 1).Where(n => n % 2 != 0);

            //return oddNums.Count();
        }
    }
}
