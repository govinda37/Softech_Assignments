using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class Program
    {
        
        public class Node
        {
            public int data;
            public Node next;
            public Node(int d)
            {
                data = d;
                next = null;
            }
        }
        //List class
        public class List
        {
            public Node head;
        
            public void push(int new_data)
            {
                
                Node new_node = new Node(new_data);

            
                new_node.next = head;

                
                head = new_node;
            }
            //append method
            public void append(int new_data)
            {
               
                Node new_node = new Node(new_data);

               
                if (head == null)
                {
                    head = new Node(new_data);
                    return;
                }

               
                new_node.next = null;

            
                Node last = head;
                while (last.next != null)
                    last = last.next;

                last.next = new_node;
                return;
            }
            //insertAfter method
            public void insertAfter(Node prev_node, int new_data)
            {

                if (prev_node == null)
                {
                    Console.WriteLine("The given previous node"
                    + " cannot be null");
                    return;
                }

                
                Node new_node = new Node(new_data);

                
                new_node.next = prev_node.next;

               
                prev_node.next = new_node;
            }
            //deleteFirst method
            public void deleteFirst()
            {
                head = head.next;
            }
            //DeleteLast method
            public void deleteLast()
            {


                Node temp = head;


                while (temp.next.next != null)
                {
                    temp = temp.next;

                }
                temp.next = null;


            }
            //search method
            public bool searchIterative(Node head, int x)
            {
                Node current = head; 
                while (current != null)
                {
                    if (current.data == x)
                        return true; 
                    current = current.next;
                }
                return false; 
            }

            public bool searchResersive(Node head, int x)
            {
             
                if (head == null)
                    return false;

               
                if (head.data == x)
                    return true;

           
                return searchResersive(head.next, x);
            }
            //for printing list method
            public void printList()
            {
                Node tnode = head;
                while (tnode != null)
                {
                    Console.WriteLine(tnode.data + " ");
                    tnode = tnode.next;

                }


            }

        }
        //Main method
        static void Main(string[] args)
        {
            List obj = new List();


            obj.push(6);
            obj.append(10);
            obj.insertAfter(obj.head, 8);


            Console.WriteLine(obj.searchIterative(obj.head, 6));

            Console.WriteLine(obj.searchResersive(obj.head, 9));

            obj.printList();

            obj.printList();
            Console.ReadLine();

        }


    }
}

