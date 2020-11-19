//****************************************************************
// Programmer: Melinda Fischer
// CIT Number : CIT245143
// Date: 19 November 2020
// Software: Microsoft Visual Studio 2019 Community Edition 
// Platform: Microsoft Windows 10 Professional 64-bit 
// Purpose: Assessment 4 - Task 3 - Hashing
// Refrences: class notes, stack overflow, dotnetperl, dotnetpattern
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
using System.Collections;


namespace MelindaFischerAssessment4
{
    public partial class frmHashing : Form
    {

        Hashtable myHashtable;
        bool found;


        public frmHashing()
        {
            InitializeComponent();
        }
        
        //Construct and Return Hashtable
        static Hashtable GetHashtable()
        {
            Hashtable myHashtable = new Hashtable();
            myHashtable.Add(10, "Link");
            myHashtable.Add(11, "Zelda");
            myHashtable.Add(12, "Korok");
            myHashtable.Add(13, "Spiderman");
            myHashtable.Add(14, "Mario");


            return myHashtable;
        }

        private void frmHashing_Load(object sender, EventArgs e)
        {
            myHashtable = GetHashtable();
        }

        //Find a record either by Name or Number
        private void btnFind_Click(object sender, EventArgs e)

        {
            if (txtNameInput.Text != "") //exception handler incase nothing is entered to field
            {
                try
                {
                    //if the value entered can be converted to a number we are searching by key
                    int key = Convert.ToInt32(txtNameInput.Text);
                    found = myHashtable.Contains(key);
                    if (found == true)
                    {
                        string value = (string)myHashtable[key];
                        txtResult.Text = key + " is a valid record number with the value " + value + ".";
                    }
                    else
                    {
                        txtResult.Text = "Sorry, this record does not exist.";
                    }
                }
                catch // else we are searching by value
                {
                    found = myHashtable.ContainsValue(txtNameInput.Text);
                    if (found == true)
                    {

                        foreach (DictionaryEntry entry in myHashtable)
                        {
                            if ((Convert.ToString(entry.Value)) == (txtNameInput.Text))
                            {
                                string key = Convert.ToString(entry.Key);
                                string value = Convert.ToString(entry.Value);
                                txtResult.Text = value + " is a valid character name with the record number " + key + ".";
                            }
                        }

                    }
                    else
                    {
                        txtResult.Text = "Sorry, this character does not Exist.";
                    }
                }
            }
            else
            {
                txtResult.Text = "Please enter a name or record to search for.";
            }
        }

        // adding another Character to the Hashtable 
        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (txtNameInput.Text != "") //exception handler incase nothing is entered to field
            {
                string newCharacter;
                newCharacter = txtNameInput.Text;

                int count = myHashtable.Count + 10;

                myHashtable.Add(count, newCharacter);
                txtResult.Text = "Great, you have successfully added " + newCharacter + ". It has the record number " + count + ".";
            }
            else
            {
                txtResult.Text = "Please enter a character name to add.";
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
