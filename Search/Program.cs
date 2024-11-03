using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Search
{
    internal class Program
    {
        public static int BinarySearch(List<int> someList, int item)
        {
            int low = 0;
            int high = someList.Count - 1;

            while(low <= high)
            {
                int mid = (low + high) / 2;
                int guess = someList[mid];
                if (guess == item)
                {
                    return mid;
                }
                else if (guess > item)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
            return -1;
        }
        public static int BinarySearchRecursion(List<int> someList, int item, int low, int high)
        {
            if(low == high)
            {
                if (someList[low] == item)
                { 
                    return low; 
                }
                else
                {
                    return -1;
                }
            }

            int mid = (low + high) / 2;
            if (item == someList[mid])
            {
                return mid;
            }
            else if(item > someList[mid])
            {
                low = mid + 1;
                return BinarySearchRecursion(someList, item, low, high);
            }
            else
            {
                high = mid - 1;
                return BinarySearchRecursion(someList, item, low, high);
            }
        }
        static void Main(string[] args)
        {
            List<int> someList = new List<int>() { 1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20 };
            int item = 6;
            int position = BinarySearchRecursion(someList,item,0,someList.Count-1);
            Console.WriteLine("The position of your item is: " + position.ToString());
            Console.ReadLine();
        }
    }
}
