using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Binary_Search_Tree
{
    internal class Program
    {

        public class Node
        {
            public int key;
            public Node left, right;

            public Node(int item)
            {
                key = item;
                left = right = null;
            }
        }



        public class BinarySearchTree
        {


            public Node root;


            public BinarySearchTree() { root = null; }

            public BinarySearchTree(int value) { root = new Node(value); }
            public void insertRecursive(int key) { root = insertRec(root, key); }

       
            Node insertRec(Node root, int key)
            {

               
                if (root == null)
                {
                    root = new Node(key);
                    return root;
                }

          
                if (key < root.key)
                    root.left = insertRec(root.left, key);
                else if (key > root.key)
                    root.right = insertRec(root.right, key);

            
                return root;
            }


            //insert method
            public void insert(int key)
            {
                Node node = new Node(key);
                if (root == null)
                {
                    root = node;
                    return;
                }
                Node prev = null;
                Node temp = root;
                while (temp != null)
                {
                    if (temp.key > key)
                    {
                        prev = temp;
                        temp = temp.left;
                    }
                    else if (temp.key < key)
                    {
                        prev = temp;
                        temp = temp.right;
                    }
                }
                if (prev.key > key)
                    prev.left = node;
                else
                    prev.right = node;
            }



            // delete method
            public void deleteKey(int key) { root = deleteRec(root, key); }



            Node deleteRec(Node root, int key)
            {
                if (root == null)
                    return root;

              
                if (key < root.key)
                    root.left = deleteRec(root.left, key);
                else if (key > root.key)
                    root.right = deleteRec(root.right, key);

                
                else
                {
                    
                    if (root.left == null)
                        return root.right;
                    else if (root.right == null)
                        return root.left;

                    root.key = minValue(root.right);

                    // Delete successfully
                    root.right = deleteRec(root.right, root.key);
                }
                return root;
            }


            int minValue(Node root)
            {
                int minv = root.key;
                while (root.left != null)
                {
                    minv = root.left.key;
                    root = root.left;
                }
                return minv;
            }

           
            public Node search(Node root, int key)
            {
                
                if (root == null ||
                    root.key == key)
                    return root;

                if (root.key < key)
                    return search(root.right, key);

                return search(root.left, key);
            }

           
            public void inorder() { inorderRec(root); }

          
            void inorderRec(Node root)
            {
                if (root != null)
                {
                    inorderRec(root.left);
                    Console.Write(root.key + " ");
                    inorderRec(root.right);
                }
            }

        }



        static void Main(string[] args)
        {

            BinarySearchTree bst = new BinarySearchTree(5);

            bst.insert(8);
            bst.insert(7);
            bst.insert(4);
            bst.insertRecursive(9);

            bst.inorder();

            bst.deleteKey(8);
            Console.WriteLine();
            bst.inorder();
            Console.ReadLine();


        }
    }
}
