using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SingletonApp
{
    public class Item
    {
        public string name { get; set; }
        public string level { get; set; }
    }
    public class NodeBin
    {
        public NodeBin(string data)
        {
            this.data = data;
        }
        public string data { get; set; }
        public NodeBin leftNode { get; set; }
        public NodeBin rightNode { get; set; }
        public void addLeftNode(NodeBin node, string data)
        {
            node.leftNode = new NodeBin(data);
        }
        public void addRightNode(NodeBin node, string data)
        {
            node.rightNode = new NodeBin(data);
        }
    }
    public class Node
    {

        public Node(string data)
        {
            this.data = data;
        }
        public void addLeftNode(Node node, string data)
        {
            node.firstChild = new Node(data);
        }
        public void addRightNode(Node node, string data)
        {
            node.nextSibling = new Node(data);
        }
        public string data { get; set; }
        public Node firstChild { get; set; }
        public Node nextSibling { get; set; }
    }

    class tree_DeQui
    {
        public static void preoder(Node root, Action<string> callBack)
        {
            if (root != null)
            {
                callBack(root.data);
                Node node = root.firstChild;
                while (node != null)
                {
                    preoder(node, callBack);
                    node = node.nextSibling;
                }
            }
        }
        public static void inoder(Node root, Action<string> callBack)
        {
            if (root != null)
            {

                Node node = root.firstChild;
                while (node != null)
                {

                    inoder(node, callBack);
                    if (node == root.firstChild)
                    {
                        callBack(root.data);
                    }
                    node = node.nextSibling;


                }
                if (root.firstChild == null)
                    callBack(root.data);
            }
        }
        public static void postoder(Node root, Action<string> callBack)
        {
            if (root != null)
            {

                Node node = root.firstChild;
                while (node != null)
                {

                    // if (node.firstChild == null)
                    //  {

                    // }
                    postoder(node, callBack);
                    node = node.nextSibling;
                    //  postoder(node, callBack);
                }
                callBack(root.data);
                //    callBack(root.data);
            }
        }
    }
    class tree_NoneDeQui
    {
        public static void preoder(Node root, Action<string> callBack)
        {
            Stack s = new Stack();
            Node p = root;
            while (p != null)
            {
                callBack(p.data);
                s.Push(p);
                p = p.firstChild;


            }
            while (s.Count > 0)
            {
                p = (Node)s.Pop();
                p = p.nextSibling;
                while (p != null)
                {
                    callBack(p.data);
                    s.Push(p);
                    p = p.firstChild;
                }
            }
        }
       public static void inoder(Node root, Action<string> callBack)
        {
            Stack s = new Stack();
            Node p = root;
            while (p != null)
            {
              
                s.Push(p);
                p = p.firstChild;


            }
            while (s.Count > 0)
            {
                p = (Node)s.Pop();
                callBack(p.data);
                p = p.nextSibling;
                while (p != null)
                {
                    callBack(p.data);
                    s.Push(p);
                    p = p.firstChild;
                }
            }
        }
        public static void postoder(Node root, Action<string> callBack)
        {
            Stack s = new Stack();
            Node p = root;
            while (p != null)
            {
                s.Push(p);
                p = p.firstChild;
            }
            while (s.Count > 0)
            {
                p = (Node)s.Pop();
                callBack(p.data);
                p = p.nextSibling;
                while (p != null)
                {
                    s.Push(p);
                    p = p.firstChild;
                }
            }
        }
    }
    class treebin_DeQui
    {
        public static void preoder(NodeBin root, Action<string> callBack)
        {
            if (root != null)
            {
                callBack(root.data);
                preoder(root.leftNode, callBack);
                preoder(root.rightNode, callBack);
                
            }
        }
       public static void postoder(NodeBin root, Action<string> callBack)
        {
            if (root != null)
            {
               
                preoder(root.leftNode, callBack);
               
                preoder(root.rightNode, callBack);
                callBack(root.data);

            }
        }
        public static void inoder(Node root, Action<string> callBack)
        {
            if (root != null)
            {

                Node node = root.firstChild;
                while (node != null)
                {

                    inoder(node, callBack);
                    if (node == root.firstChild)
                    {
                        callBack(root.data);
                    }
                    node = node.nextSibling;


                }
                if (root.firstChild == null)
                    callBack(root.data);
            }
        }
        public static void postoder(Node root, Action<string> callBack)
        {
            if (root != null)
            {

                Node node = root.firstChild;
                while (node != null)
                {

                    // if (node.firstChild == null)
                    //  {

                    // }
                    postoder(node, callBack);
                    node = node.nextSibling;
                    //  postoder(node, callBack);
                }
                callBack(root.data);
                //    callBack(root.data);
            }
        }
    }
    class treebin_NoneDeQui
    {
        public static void preoder(Node root, Action<string> callBack)
        {
            Stack s = new Stack();
            Node p = root;
            while (p != null)
            {
                callBack(p.data);
                s.Push(p);
                p = p.firstChild;


            }
            while (s.Count > 0)
            {
                p = (Node)s.Pop();
                p = p.nextSibling;
                while (p != null)
                {
                    callBack(p.data);
                    s.Push(p);
                    p = p.firstChild;
                }
            }
        }
        public static void postoder(Node root, Action<string> callBack)
        {
            Stack s = new Stack();
            Node p = root;
            while (p != null)
            {
                s.Push(p);
                p = p.firstChild;
            }
            while (s.Count > 0)
            {
                p = (Node)s.Pop();
                callBack(p.data);
                p = p.nextSibling;
                while (p != null)
                {
                    s.Push(p);
                    p = p.firstChild;
                }
            }
        }
    }
}
