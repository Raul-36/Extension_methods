using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_methods
{
    public static class ExtensionMethods
    {
        public static int[] Sort(this int[] ints,Direction direction = Direction.Descending)
        {
            int[] newInts = new int[ints.Length];  
            int i = 0;
            foreach (int x in ints)
            {
                newInts[i++] = x;
            }
            for(int x = 0; x < newInts.Length; x++)
            {
                for (int y = 0; y < newInts.Length; y++)
                {
                    int cost;
                    if (direction == Direction.Descending ? newInts[x] > newInts[y] : newInts[x] < newInts[y])
                    {
                        cost = newInts[x];
                        newInts[x] = newInts[y];
                        newInts[y] = cost;
                    }
                }
            }
            return newInts;
        }
        public static bool Find(this int[] ints, int valueToFind)
        {
            if (ints.Length == 0)
                return false;

            foreach (int item in ints)
            {
                if (item == valueToFind)
                    return true;
            }
            return false;
        }
        public static bool Find(this int[] ints, params int[] valuesToFind)
        {
            if (ints.Length == 0)
                return false;
              
            bool[] checks = new bool[valuesToFind.Length];
            int i = 0;
            foreach (int item in valuesToFind) {
                checks[i++] = ints.Find(item);
            }
            foreach(bool check in checks)
            {
                if (!check)
                    return false;
            }
            return true;
        }
        public static int[] Plus(this int[] ints,int[] anotherArr)
        {
            int[] newInts = new int[ints.Length + anotherArr.Length];
            int i = 0;
            foreach (var item in ints)
            {
                newInts[i++] = item;
            }
            foreach (var item in anotherArr)
            {
                newInts[i++] = item;
            }
            return newInts;
        }
        public static int[] Get(this int[] ints, Predicate<int> predicate)
        {
            int[] newInts = { };
            foreach(var item in ints)
            {
                if (predicate.Invoke(item))
                {
                   int[] newInt1 = new int[newInts.Length + 1];
                    int i1 = 0;
                    foreach (int x in newInts) {
                        newInt1[i1++] = x;
                    }
                    newInt1[newInts.Length] = item;
                    newInts = newInt1; 
                }
            }
            return newInts;
        }
    }
}
