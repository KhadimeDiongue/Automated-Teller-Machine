using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class Search
    {
        public  int LinearSearch(int[] array, int target)
        {
            for (int i = 0; i < array.Length; i++)
                if (array[i] == target)
                    return i;
            return -1;
        }
    }
}
