using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void addNode()
        {
            int nim;
            string nm;
            Console.WriteLine("\nEnter the roll number of the student");
            nim = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter the name of the student: ");
            nm = Console.ReadLine();
            Node newNode = new Node();
            newNode.noMhs = nim;
            newNode.name = nm;


            if (START == null || nim <= START.noMhs)
            {
                if ((START != null) && (nim == START.noMhs))
                {
                    Console.WriteLine("\nDuplicade number not allowed");
                    return;
                }
                newNode.next = START;
                if (START != null)
                    START.prev = newNode;
                newNode.prev = null;
                return;
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
        public bool listEmpty()
        {
            if (LAST == null)
                return true;
            else
                return false;
        }



        public void traverse()
        {
            if (listEmpty())
                Console.WriteLine("\nList is empty");
            else
            {
                Console.WriteLine("\nRecords in the list are:\n");
                Node currentNode;
                currentNode = LAST.next;
                while (currentNode != LAST)
                {
                    Console.Write(currentNode.rollNumber + "    " + currentNode.name + "\n");
                    currentNode = currentNode.next;
                }
                Console.Write(LAST.rollNumber + "    " + LAST.name + "\n");
            }
        }
        public void firstNode()
        {
            if (!listEmpty())
                Console.WriteLine("\nList is empty");
            else
                Console.WriteLine("\nThe first record in the list is:\n\n" + LAST.next.rollNumber + "    " + LAST.next.name);
        }
        static void main(string[] args)
        {
            Circularlist obj = new Circularlist();
            while (true)
            {
                try
                {
                    Console.WriteLine("\nMenu");
                    Console.WriteLine("1. add a record to the list");
                    Console.WriteLine("2. delete a record from the list");
                    Console.WriteLine("3. view all record in the ascending order of roll number");
                    Console.WriteLine("4. view all record in the descending order of roll number");
                    Console.WriteLine("5. search for a record in the list");
                    Console.WriteLine("6. exit\n");
                    Console.Write("\nEnter your choice (1-6): ");
                    char ch = Convert.ToChar(Console.ReadLine());
                    switch (ch)
                    {
                        case '1':
                            {
                                obj.traverse();
                            }
                            break;
                        case '2':
                            {
                                Console.WriteLine("\nList is empty");
                                break;
                            }

                    }

                }
            }
        }
        
    }
    
        

}