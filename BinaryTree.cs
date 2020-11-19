//****************************************************************
// Programmer: Melinda Fischer
// CIT Number : CIT245143
// Date: 19 November 2020
// Software: Microsoft Visual Studio 2019 Community Edition 
// Platform: Microsoft Windows 10 Professional 64-bit 
// Purpose: Assessment 4 - Task 2 - Binary Tree - Class BinaryTree
// Refrences: class notes, stack overflow, dotnetperl, csharpexamples, youtube
//**************************************************************** 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MelindaFischerAssessment4
{
    public class BinaryTree //Creating the class BinaryTree
    {

        public Node Root { get; set; } //Referencing Node class

        public bool Add(int value) //function to add to BinaryTree
        {
            Node before = null, after = this.Root;

            while (after != null)
            {
                before = after;
                if (value < after.Data) //Is new node in left tree? 
                    after = after.LeftNode;
                else if (value > after.Data) //Is new node in right tree?
                    after = after.RightNode;
                else
                {
                    //Exist same value
                    return false;
                }
            }

            Node newNode = new Node();
            newNode.Data = value;
         

            //if the tree is empty and has no root, the current value will become the root else it is inserted in the right place
            if (this.Root == null)//Tree is empty
                this.Root = newNode;
            else
            {
                if (value < before.Data)
                    before.LeftNode = newNode;
                else
                    before.RightNode = newNode;
            }

            return true;
        }

        string result;

        public void clearResult()
        {
            result = "";
        }


        public string TraverseInOrder(Node parent) //function to traverse through the tree and return the data in order 
        {

            if (parent != null)
            {

                TraverseInOrder(parent.LeftNode);
                //Console.Write(parent.Data + " "); //used for debugging
                result += (Convert.ToInt32(parent.Data) + " - ");
                TraverseInOrder(parent.RightNode);
                
            }

            return result;
            
        }

        public Node Search(int value)
        {
            return this.Find(value, this.Root);
        }

        private Node Find(int value, Node parent)
        {
            if (parent != null)
            {
                if (value == parent.Data) return parent;
                if (value < parent.Data)
                    return Find(value, parent.LeftNode);
                else
                    return Find(value, parent.RightNode);
            }

            return null;
        }

        public Node GoToNode(int? key)
        {
            Node thisNode = Root;

            while(thisNode != null)
            {
                if (thisNode.Data == key)
                {
                    return thisNode;
                }
                
                if (thisNode.Data == null)
                {
                    return null;
                }

                if (key < thisNode.Data)
                {
                    thisNode = thisNode.LeftNode;
                }
                else
                {
                    thisNode = thisNode.RightNode;
                }
            }

            return thisNode; 
        }

        //find smallest number in tree
        public int? Minimum(int? key)
        {
            Node currentNode = Root;
            if (currentNode == null)
            {
                return null;
            }

            while (currentNode.LeftNode != null)
                {
                    currentNode = currentNode.LeftNode;
                }

            return currentNode.Data;

        }

        //find biggest number in tree
        public int? Maximum(int? key)
        {
            Node currentNode = Root;
            if (currentNode == null)
            {
                return null;
            }

            while (currentNode.RightNode != null)
            {
                currentNode = currentNode.RightNode;
            }

            return currentNode.Data;
        }

    }
}

