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
            Console.WriteLine("Print Array Using Insertion Sort");
            int[] arr = { 12, 11, 13, 5, 6 };
            InsertionSort ob = new InsertionSort();
            ob.sort(arr);
            InsertionSort ob1 = new InsertionSort();
            ob1.printArray(arr);

            Console.WriteLine("Print int value Array Using BubbleSort ");
            int[] arr1 = { 64, 34, 25, 12, 22, 11, 90 }; 
            BubbleSort ob2 = new BubbleSort(); 
            ob2.bubbleSort(arr1);
            BubbleSort ob3 = new BubbleSort();
            ob3.printArray1(arr1);
        }
    }
}
