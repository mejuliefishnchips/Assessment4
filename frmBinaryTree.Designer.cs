namespace MelindaFischerAssessment4
{
    partial class frmBinaryTree
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNumInput = new System.Windows.Forms.TextBox();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.RichTextBox();
            this.txtRoot = new System.Windows.Forms.TextBox();
            this.txtLeft = new System.Windows.Forms.TextBox();
            this.txtRight = new System.Windows.Forms.TextBox();
            this.txtLeftLeft = new System.Windows.Forms.TextBox();
            this.txtLeftRight = new System.Windows.Forms.TextBox();
            this.txtRightLeft = new System.Windows.Forms.TextBox();
            this.txtRightRight = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtLeftLeftLeft = new System.Windows.Forms.TextBox();
            this.txtLeftLeftRight = new System.Windows.Forms.TextBox();
            this.txtLeftRightLeft = new System.Windows.Forms.TextBox();
            this.txtLeftRightRight = new System.Windows.Forms.TextBox();
            this.txtRightLeftLeft = new System.Windows.Forms.TextBox();
            this.txtRightLeftRight = new System.Windows.Forms.TextBox();
            this.txtRightRightRight = new System.Windows.Forms.TextBox();
            this.txtRightRightLeft = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNumInput
            // 
            this.txtNumInput.Location = new System.Drawing.Point(186, 285);
            this.txtNumInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNumInput.Name = "txtNumInput";
            this.txtNumInput.Size = new System.Drawing.Size(141, 26);
            this.txtNumInput.TabIndex = 0;
            // 
            // btnDisplay
            // 
            this.btnDisplay.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnDisplay.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDisplay.Location = new System.Drawing.Point(22, 379);
            this.btnDisplay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(305, 46);
            this.btnDisplay.TabIndex = 3;
            this.btnDisplay.Text = "&Display Numbers in Order";
            this.btnDisplay.UseVisualStyleBackColor = false;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(391, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "Binary Trees";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(896, 433);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(130, 49);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnSearch.Location = new System.Drawing.Point(22, 325);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(157, 46);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(186, 339);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(141, 26);
            this.txtSearch.TabIndex = 9;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(334, 277);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(692, 148);
            this.txtResult.TabIndex = 10;
            this.txtResult.Text = "";
            // 
            // txtRoot
            // 
            this.txtRoot.Location = new System.Drawing.Point(449, 84);
            this.txtRoot.Name = "txtRoot";
            this.txtRoot.Size = new System.Drawing.Size(100, 26);
            this.txtRoot.TabIndex = 11;
            // 
            // txtLeft
            // 
            this.txtLeft.Location = new System.Drawing.Point(212, 117);
            this.txtLeft.Name = "txtLeft";
            this.txtLeft.Size = new System.Drawing.Size(100, 26);
            this.txtLeft.TabIndex = 12;
            // 
            // txtRight
            // 
            this.txtRight.Location = new System.Drawing.Point(712, 117);
            this.txtRight.Name = "txtRight";
            this.txtRight.Size = new System.Drawing.Size(100, 26);
            this.txtRight.TabIndex = 13;
            // 
            // txtLeftLeft
            // 
            this.txtLeftLeft.Location = new System.Drawing.Point(91, 157);
            this.txtLeftLeft.Name = "txtLeftLeft";
            this.txtLeftLeft.Size = new System.Drawing.Size(100, 26);
            this.txtLeftLeft.TabIndex = 14;
            // 
            // txtLeftRight
            // 
            this.txtLeftRight.Location = new System.Drawing.Point(334, 157);
            this.txtLeftRight.Name = "txtLeftRight";
            this.txtLeftRight.Size = new System.Drawing.Size(100, 26);
            this.txtLeftRight.TabIndex = 15;
            // 
            // txtRightLeft
            // 
            this.txtRightLeft.Location = new System.Drawing.Point(591, 157);
            this.txtRightLeft.Name = "txtRightLeft";
            this.txtRightLeft.Size = new System.Drawing.Size(100, 26);
            this.txtRightLeft.TabIndex = 16;
            // 
            // txtRightRight
            // 
            this.txtRightRight.Location = new System.Drawing.Point(831, 157);
            this.txtRightRight.Name = "txtRightRight";
            this.txtRightRight.Size = new System.Drawing.Size(100, 26);
            this.txtRightRight.TabIndex = 17;
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnInsert.Location = new System.Drawing.Point(22, 277);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(157, 42);
            this.btnInsert.TabIndex = 18;
            this.btnInsert.Text = "&Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtLeftLeftLeft
            // 
            this.txtLeftLeftLeft.Location = new System.Drawing.Point(37, 194);
            this.txtLeftLeftLeft.Name = "txtLeftLeftLeft";
            this.txtLeftLeftLeft.Size = new System.Drawing.Size(100, 26);
            this.txtLeftLeftLeft.TabIndex = 19;
            // 
            // txtLeftLeftRight
            // 
            this.txtLeftLeftRight.Location = new System.Drawing.Point(143, 194);
            this.txtLeftLeftRight.Name = "txtLeftLeftRight";
            this.txtLeftLeftRight.Size = new System.Drawing.Size(100, 26);
            this.txtLeftLeftRight.TabIndex = 20;
            // 
            // txtLeftRightLeft
            // 
            this.txtLeftRightLeft.Location = new System.Drawing.Point(276, 194);
            this.txtLeftRightLeft.Name = "txtLeftRightLeft";
            this.txtLeftRightLeft.Size = new System.Drawing.Size(100, 26);
            this.txtLeftRightLeft.TabIndex = 21;
            // 
            // txtLeftRightRight
            // 
            this.txtLeftRightRight.Location = new System.Drawing.Point(382, 194);
            this.txtLeftRightRight.Name = "txtLeftRightRight";
            this.txtLeftRightRight.Size = new System.Drawing.Size(100, 26);
            this.txtLeftRightRight.TabIndex = 22;
            // 
            // txtRightLeftLeft
            // 
            this.txtRightLeftLeft.Location = new System.Drawing.Point(536, 194);
            this.txtRightLeftLeft.Name = "txtRightLeftLeft";
            this.txtRightLeftLeft.Size = new System.Drawing.Size(100, 26);
            this.txtRightLeftLeft.TabIndex = 23;
            // 
            // txtRightLeftRight
            // 
            this.txtRightLeftRight.Location = new System.Drawing.Point(642, 194);
            this.txtRightLeftRight.Name = "txtRightLeftRight";
            this.txtRightLeftRight.Size = new System.Drawing.Size(100, 26);
            this.txtRightLeftRight.TabIndex = 24;
            // 
            // txtRightRightRight
            // 
            this.txtRightRightRight.Location = new System.Drawing.Point(885, 194);
            this.txtRightRightRight.Name = "txtRightRightRight";
            this.txtRightRightRight.Size = new System.Drawing.Size(100, 26);
            this.txtRightRightRight.TabIndex = 25;
            // 
            // txtRightRightLeft
            // 
            this.txtRightRightLeft.Location = new System.Drawing.Point(779, 194);
            this.txtRightRightLeft.Name = "txtRightRightLeft";
            this.txtRightRightLeft.Size = new System.Drawing.Size(100, 26);
            this.txtRightRightLeft.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1008, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "_________________________________________________________________________________" +
    "______________________________";
            // 
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.Color.SeaGreen;
            this.btnMin.Location = new System.Drawing.Point(22, 437);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(143, 40);
            this.btnMin.TabIndex = 28;
            this.btnMin.Text = "Minimum";
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnMax
            // 
            this.btnMax.BackColor = System.Drawing.Color.SeaGreen;
            this.btnMax.Location = new System.Drawing.Point(171, 437);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(141, 40);
            this.btnMax.TabIndex = 29;
            this.btnMax.Text = "Maximum";
            this.btnMax.UseVisualStyleBackColor = false;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // frmBinaryTree
            // 
            this.AcceptButton = this.btnInsert;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1044, 493);
            this.Controls.Add(this.btnMax);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRightRightLeft);
            this.Controls.Add(this.txtRightRightRight);
            this.Controls.Add(this.txtRightLeftRight);
            this.Controls.Add(this.txtRightLeftLeft);
            this.Controls.Add(this.txtLeftRightRight);
            this.Controls.Add(this.txtLeftRightLeft);
            this.Controls.Add(this.txtLeftLeftRight);
            this.Controls.Add(this.txtLeftLeftLeft);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtRightRight);
            this.Controls.Add(this.txtRightLeft);
            this.Controls.Add(this.txtLeftRight);
            this.Controls.Add(this.txtLeftLeft);
            this.Controls.Add(this.txtRight);
            this.Controls.Add(this.txtLeft);
            this.Controls.Add(this.txtRoot);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.txtNumInput);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmBinaryTree";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Melinda - Task 2 - Binary Tree";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumInput;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.RichTextBox txtResult;
        private System.Windows.Forms.TextBox txtRoot;
        private System.Windows.Forms.TextBox txtLeft;
        private System.Windows.Forms.TextBox txtRight;
        private System.Windows.Forms.TextBox txtLeftLeft;
        private System.Windows.Forms.TextBox txtLeftRight;
        private System.Windows.Forms.TextBox txtRightLeft;
        private System.Windows.Forms.TextBox txtRightRight;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txtLeftLeftLeft;
        private System.Windows.Forms.TextBox txtLeftLeftRight;
        private System.Windows.Forms.TextBox txtLeftRightLeft;
        private System.Windows.Forms.TextBox txtLeftRightRight;
        private System.Windows.Forms.TextBox txtRightLeftLeft;
        private System.Windows.Forms.TextBox txtRightLeftRight;
        private System.Windows.Forms.TextBox txtRightRightRight;
        private System.Windows.Forms.TextBox txtRightRightLeft;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnMax;
    }
}