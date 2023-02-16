/*
    ========================================================================

    Notes:
        - [0] "datatype this[datatype name]" is needed for the intex to work
        - [1] We can't use set for this since we cant change our properties,
              that would break the code.
        - [2] We cannot use a List here, therfore we use 
              a for loop instead of a for each loop.
        - Crashes if the index is outside the bounds of the array.

    ========================================================================
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListDeepDive {

    public class MyList {
        private int[] data;             // All lists are made up of arrays.
        private int count;

        public int this[int i] {        // Allows us to index our list. [0]
            get { return data[i]; }
            set { data[i] = value; }
        }

        public int Count {              // [1]
            get { return count; }
        }

        public MyList() {               // Constructor that declares the size of our list.
            data = new int[10];
        }

        public void Add(int item) {
            if(count == data.Length) {
                Resize();
            }

            data[count] = item;
            count++;
        }

        // 1 2 3 4 5 6 7    Count: 6 <=>    1 2 3 4 6 7 7
        public void RemoveAt(int index) {
            for (int i = 0; i < count-1; i++) {
                data[i] = data[i+1];
            }
            count--;
        }

        private void Resize() {             // Resize our list
            int[] temp = data;              // Temporary storage
            data = new int[count * 2];

            for (int i = 0; i < count; i++) {   // [2]
                data[i] = temp[i];
            }
        }

    }
}