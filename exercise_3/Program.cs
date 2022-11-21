using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Exercise_linked_list_A
{
    class Node
    {
        public int rollNumber;
        public string name;
        public string next;
    }
    class Circularlist
    {
        Node LAST;

        public Circularlist()
        {
            LAST = null;
        }

        public bool Search(int rollNo, ref Node previous, ref Node current)
        {
            for (previous = current = LAST.next; current != LAST; previous = current, current = current.next)
            {
                if (rollNo == current.rollNumber)
                    return (true);
            }
            if (rollNo == LAST.rollNumber)
                return true;
            else
                return false;
        }
        
    }
    
        

}