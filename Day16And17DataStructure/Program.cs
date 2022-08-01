using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16And17DataStructure
{
    public class Program
    {
        public static void Main()
        {
            
            int[] arr = { 12, 11, 13, 5, 6 };
            InsertionSort ob = new InsertionSort();
            ob.sort(arr);
            InsertionSort ob1 = new InsertionSort();
            ob1.printArray(arr);
        }
    }
}
