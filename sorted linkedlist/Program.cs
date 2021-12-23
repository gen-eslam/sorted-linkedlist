using System;

namespace sorted_linkedlist
{
    class Program
    {
        public class LinkedlistIS
        {
            public node head;
            public node sorted;

            public class node
            {
                public int val;
                public char character;
                public node next;

             
            }

            void push(int val,char character)
            {
                
                node newnode = new node();
                newnode.val = val;
                newnode.character = character;

                
                newnode.next = head;

                
                head = newnode;
            }

            
            void insertionSort(node headref)
            {
               
                sorted = null;
                node current = headref;

               
                while (current != null)
                {
                    
                    node next = current.next;

                  
                    sortedInsert(current);

                   
                    current = next;
                }

               
                head = sorted;
            }

          
            void sortedInsert(node newnode)
            {
               
                if (sorted == null || sorted.val >= newnode.val)
                {
                    newnode.next = sorted;
                    sorted = newnode;
                }
                else
                {
                    node current = sorted;

                    
                    while (current.next != null &&
                            current.next.val < newnode.val)
                    {
                        current = current.next;
                    }
                    newnode.next = current.next;
                    current.next = newnode;
                }
            }

            void printlist()
            {
                insertionSort(head);

                node pointer = head;
                
                while (pointer != null)
                {
                    Console.Write(pointer.character + " ");
                    pointer = pointer.next;
                }
            }

          
            public static void Main(String[] args)
            {

                LinkedlistIS list = new LinkedlistIS();
                
                list.push(2, 'e');
                list.push(1, 'b');
                list.push(3, 'a');
                list.push(5, 'h');
                list.push(4, 'c');
                list.printlist();
            }
        }
    }
}
