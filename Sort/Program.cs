using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    internal class Program
    {
        public static void SelctionSort(int[] someList)
        {
            for (int i = 0; i<someList.Length; i++)
            {
                for (int j=i+1; j<someList.Length; j++)
                {
                    if (someList[i] > someList[j])
                    {
                        int temp = someList[i];
                        someList[i] = someList[j];
                        someList[j] = temp;
                    }
                }
            }
        }
        public static void QuickSort(int[] someList, int low, int high)
        {
            if(low >= high)
            {
                return;
            }
            int pivotIndex = Partition(someList, low, high);
            QuickSort(someList,low,pivotIndex-1);
            QuickSort(someList,pivotIndex+1,high);
        }
        public static int Partition(int[] someList, int low, int high)
        {
            // setting random pivot
            // pivot_index = random generating function
            // swap(someList(high), someList(pivot_index))
            // so what's in the someList[high] now is what was in someList[pivot_index]
            // and the algo continues just the same
            int pivotValue = someList[high];
            int i = low;
            for(int j=low; j<high; j++)
            {
                if (someList[j] <= pivotValue)
                {
                    Swap(someList, i, j);
                    i++;
                }
            }
            Swap(someList, i, high);
            return i;
        }
        public static void Swap(int[] someList, int i, int j)
        {
            int temp = someList[i];
            someList[i] = someList[j];
            someList[j] = temp;
        }
        public static void printList(int[] someList)
        {
            Console.WriteLine(String.Join(",",someList));
        }
        static void Main(string[] args)
        {
            int[] someList = { 10, 20, 3, 14, 8, 7, 6, 15, 19, 1, 17, 12, 13, 4, 18, 16, 11, 5, 9, 2 };
            printList(someList);
            //SelctionSort(someList);
            QuickSort(someList,0,someList.Length-1);
            printList(someList);
        }
    }
}
