//****************************************************************
// Programmer: Melinda Fischer
// CIT Number : CIT245143
// Date: 19 November 2020
// Software: Microsoft Visual Studio 2019 Community Edition 
// Platform: Microsoft Windows 10 Professional 64-bit 
// Purpose: Assessment 4 - Task 1 - Doubly Linked List
// Refrences: class notes, 
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
    public partial class frmPalindromes : Form
    {
        public frmPalindromes()
        {
            InitializeComponent();
        }

        //Declare linked List
        LinkedList<char> palindrome = new LinkedList<char>();
        char letter;
        string word;

        private void btnTellMe_Click(object sender, EventArgs e)
        {
           
            txtAnswer.Visible = true;
            txtInput.Visible = true;
            btnNext.Visible = true;
            btnDone.Visible = true;

            txtAnswer.Text = "They are palindromes! Palindromes are words that are the same backwards and forwards.\nDon't believe me? Try it out yourself.\nEnter a Palindrome one letter at the time, click \"Next\" or press Enter between letters and \"Done\" when finished!\nHave Fun :)";
            btnTellMe.Enabled = false;
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            word = "";
            //Traverse forward and display contents
            for (LinkedListNode<char> node = palindrome.First; node != null; node = node.Next)
            {
                word += node.Value;
            }
            txtInput.Text = word; 
        }

        private void btnBackward_Click(object sender, EventArgs e)
        {
            word = "";
            //Traverse backward and display contents
            for (LinkedListNode<char> node = palindrome.Last; node != null; node = node.Previous)
            {
                word += node.Value;
            }
            txtInput.Text = word;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPalindromes_Load(object sender, EventArgs e)
        {
            //setting windows components to invisible
            btnBackward.Visible = false;
            btnForward.Visible = false;
            txtAnswer.Visible = false;
            txtInput.Visible = false;
            btnNext.Visible = false;
            btnDone.Visible = false;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            btnBackward.Visible = true;
            btnForward.Visible = true;
            btnNext.Enabled = false; 
        }

        //Add to doubly linked List
        private void btnNext_Click(object sender, EventArgs e)
        {
            letter = Convert.ToChar(txtInput.Text);
            palindrome.AddFirst(letter);

            txtInput.Text = "";
        }
    }
}
