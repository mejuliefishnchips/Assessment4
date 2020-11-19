//****************************************************************
// Programmer: Melinda Fischer
// CIT Number : CIT245143
// Date: 17 November 2020
// Software: Microsoft Visual Studio 2019 Community Edition 
// Platform: Microsoft Windows 10 Professional 64-bit 
// Purpose: Assessment 4 - Task 2 - Binary Tree
// Refrences: class notes, stack overflow, dotnetperl, csharpexamples, youtube
//**************************************************************** 


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace MelindaFischerAssessment4
{
    public partial class frmBinaryTree : Form
    {

      

        //Form-wide variables
        BinaryTree myTree = new BinaryTree(); //Creating new Binary Tree
         
        public frmBinaryTree()
        {
            InitializeComponent();
        }


        private void btnDisplay_Click(object sender, EventArgs e)
        {       

            string treeData;

            myTree.clearResult();
            treeData = myTree.TraverseInOrder(myTree.Root); // Traverse through the tree and save result into treeData 
         
            txtResult.Text = treeData;

 
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Node searchResult;
            if (txtSearch.Text != "")
            {

                try
                {
                    int search = Convert.ToInt32(txtSearch.Text);
                    if ((myTree.Search(search) != null))
                    {
                        searchResult = myTree.Search(Convert.ToInt32(txtSearch.Text));
                        txtResult.Text = Convert.ToString(searchResult.Data) + " exists in the tree.";

                    }
                    else
                        txtResult.Text = "Sorry, that number does not exist in your Binary Tree.";
                }
                catch
                {
                    txtResult.Text = "That is not a valid integer.";
                }
          
            }
            else
                txtResult.Text = "Please enter a number to search for.";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //Displaying tree contents in the form
        public void displayTree()
        {
            if (myTree.Root.Data != null)
            {
                txtRoot.Text = Convert.ToString(myTree.Root.Data);
                if (myTree.Root.LeftNode != null)
                {
                    txtLeft.Text = Convert.ToString(myTree.Root.LeftNode.Data);

                    if (myTree.Root.LeftNode.RightNode != null)
                    {
                        txtLeftRight.Text = Convert.ToString(myTree.Root.LeftNode.RightNode.Data);

                        if (myTree.Root.LeftNode.RightNode.LeftNode != null)
                            txtLeftRightLeft.Text = Convert.ToString(myTree.Root.LeftNode.RightNode.LeftNode.Data);
                        if (myTree.Root.LeftNode.RightNode.RightNode != null)
                            txtLeftRightRight.Text = Convert.ToString(myTree.Root.LeftNode.RightNode.RightNode.Data);
                    }
                        
                    if (myTree.Root.LeftNode.LeftNode != null)
                    {
                        txtLeftLeft.Text = Convert.ToString(myTree.Root.LeftNode.LeftNode.Data);

                        if (myTree.Root.LeftNode.LeftNode.LeftNode != null)
                            txtLeftLeftLeft.Text = Convert.ToString(myTree.Root.LeftNode.LeftNode.LeftNode.Data);
                        if (myTree.Root.LeftNode.LeftNode.RightNode != null)
                            txtLeftLeftRight.Text = Convert.ToString(myTree.Root.LeftNode.LeftNode.RightNode.Data);
                    }
                       
                }

                if (myTree.Root.RightNode != null)
                {
                    txtRight.Text = Convert.ToString(myTree.Root.RightNode.Data);
                    if (myTree.Root.RightNode.LeftNode != null)
                    {
                        txtRightLeft.Text = Convert.ToString(myTree.Root.RightNode.LeftNode.Data);

                        if (myTree.Root.RightNode.LeftNode.LeftNode != null)
                            txtRightLeftLeft.Text = Convert.ToString(myTree.Root.RightNode.LeftNode.LeftNode.Data);
                        if (myTree.Root.RightNode.LeftNode.RightNode != null)
                            txtRightLeftRight.Text = Convert.ToString(myTree.Root.RightNode.LeftNode.RightNode.Data);
                    } 
                    if (myTree.Root.RightNode.RightNode != null)
                    {
                        txtRightRight.Text = Convert.ToString(myTree.Root.RightNode.RightNode.Data);

                        if (myTree.Root.RightNode.RightNode.LeftNode != null)
                            txtRightRightLeft.Text = Convert.ToString(myTree.Root.RightNode.RightNode.LeftNode.Data);
                        if (myTree.Root.RightNode.RightNode.RightNode != null)
                            txtRightRightRight.Text = Convert.ToString(myTree.Root.RightNode.RightNode.RightNode.Data);
                    }
                      
                }
            }
        }

        // adding numbers one by one to the binary tree
        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (txtNumInput.Text != "")
            {
                try
                {
                    int add = Convert.ToInt32(txtNumInput.Text);
                    myTree.Add(add);
                    txtNumInput.Text = "";

                    displayTree();
                }
                catch
                {
                    txtResult.Text = "That is not a valid integer.";
                }
             
            }
            else
            {
                txtResult.Text = "Please enter an integer to add.";
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            if (myTree.Root != null)
            {
                txtResult.Text = "The smallest number in the tree is: " + Convert.ToString(myTree.Minimum(myTree.Root.Data));
            }
            else
            {
                txtResult.Text = "Your Tree is empty.";
            }
            
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (myTree.Root != null)
            {
                txtResult.Text = "The biggest number in the tree is: " + Convert.ToString(myTree.Maximum(myTree.Root.Data));
            }
            else
            {
                txtResult.Text = "Your Tree is empty.";
            }

        }
    }
}
