using System;
using System.Collections.Generic;
using System.Collections;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            NodeList<string> nodeList = new();
            nodeList.AddNode("1");
            nodeList.AddNode("2");
            nodeList.AddNode("3");
            nodeList.AddNode("4");

            foreach (var item in nodeList)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            Console.WriteLine(nodeList.GetCount());


            nodeList.RemoveNode("5");
            foreach (var item in nodeList)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            Console.WriteLine(nodeList.GetCount());
        }
    }

    interface INode<T> : IEnumerable<T>
    {        
        void AddNode(T content);
        bool RemoveNode(T content);
        int GetCount();
    }

    public class Node<T>
    {
        public Node(T content)
        {
            Content = content;
        }
        public T Content { get; set; }
        public Node<T> Previous { get; set; }
        public Node<T> Next { get; set; }
    }


    public class NodeList<T> : INode<T>
    {

        public int count { get; set; }
        public Node<T> head { get; set; }
        public Node<T> tail { get; set; }

        
        public void AddNode(T content)
        {
            Node<T> node = new Node<T>(content);

            if (head == null) head = node;

            else
            {
                tail.Next = node;
                node.Previous = tail;
            }
            tail = node;
            count++;
        }        
        public bool RemoveNode(T content)
        {
            Node<T> current = head;

            while (current != null)
            {
                if (current.Content.Equals(content))
                {
                    break;
                }
                current = current.Next;
            }
            if (current != null)
            {
                if (current.Next != null)
                {
                    current.Next.Previous = current.Previous;
                }
                else
                {
                    tail = current.Previous;
                }

                if (current.Previous != null)
                {
                    current.Previous.Next = current.Next;
                }
                else
                {
                    head = current.Next;
                }
                count--;
                return true;
            }
            return false;
        }
        public int GetCount()
        {
            return count;
        }


        public IEnumerator GetEnumerator()
        {
            Node<T> current = head;
            while (current != null)
            {
                yield return current.Content;
                current = current.Next;
            }
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return (IEnumerator<T>)GetEnumerator();
        }

       
    }
}



