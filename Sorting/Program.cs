using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sorting.Sorts;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrForQS = new int[] {3,15,2,-1,0,9,3,12,1,-8 };

            var qSort = new QuickSort(arrForQS);
            var kthItem = qSort.GetKSmallestElement(arrForQS.Length-5);

            qSort = new QuickSort(arrForQS);
            var result = qSort.Sort();
        }
    }
}
