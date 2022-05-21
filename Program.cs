using System;

namespace BinarySearch
{
    class Program
    {
        
        static Boolean LinearSearch(int [] inputArray,int n)
        {
            foreach (var current in inputArray)
            {
                if (current==n)
                {
                    return true;
                }
            }

            return false;
        }

        static void Main(string[] args)
        {
            int [ ] inputArray = {1,2,3,4,5,6,7,8,9};
           Console.WriteLine(LinearSearch(inputArray,3));

           Array.Find(inputArray,i=>i==3);

           int [] items = Array.FindAll(inputArray,i=>i>=3);
           Array.ForEach(items,Console.WriteLine);

        }
    }
}
