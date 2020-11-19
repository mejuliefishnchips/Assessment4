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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void palindromesTask1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPalindromes myPalindromes = new frmPalindromes();
            myPalindromes.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void binaryTreeTask2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBinaryTree myBinaryTree = new frmBinaryTree();
            myBinaryTree.ShowDialog();
        }

        private void hashableTask3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHashing myHashing = new frmHashing();
            myHashing.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Application was developed by Melinda Fischer to meet the criteria for her C# Assessment 4 " +
                "\nName: Melinda Fischer\nCIT Number: CIT245143\nExtra: Melinda loves coding in C#.", "About this Application", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
