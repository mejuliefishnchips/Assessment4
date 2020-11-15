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
    }
}
