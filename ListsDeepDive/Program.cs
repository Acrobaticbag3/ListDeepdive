/*
    ========================================================================

    Notes:

    ========================================================================
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ListsDeepDive;

namespace ListDeepDive {

    internal class Program {

        static void Main(string[] args)  {
            /*
            MyList list = new MyList();

            for (int i = 0; i < 11; i++) {
                list.Add(i);
            }

            list.RemoveAt(7);

            for (int i = 0; i < list.Count; i++) {
                Console.WriteLine(list[i]);
            }
            */

            MyLinkedList linkedList = new MyLinkedList();
            linkedList.Add(1);
            linkedList.Add(2);
            linkedList.Add(3);
            linkedList.Add(4);
            linkedList.Add(5);

            linkedList.Remove(2);
        }
    }
}