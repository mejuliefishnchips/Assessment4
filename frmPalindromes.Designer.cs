namespace MelindaFischerAssessment4
{
    partial class frmPalindromes
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnTellMe = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnBackward = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtAnswer = new System.Windows.Forms.RichTextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(574, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "What does a racecar have in common with a tacocat?";
            // 
            // btnTellMe
            // 
            this.btnTellMe.BackColor = System.Drawing.Color.Orange;
            this.btnTellMe.Location = new System.Drawing.Point(310, 92);
            this.btnTellMe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTellMe.Name = "btnTellMe";
            this.btnTellMe.Size = new System.Drawing.Size(268, 55);
            this.btnTellMe.TabIndex = 1;
            this.btnTellMe.Text = "&Tell Me!!";
            this.btnTellMe.UseVisualStyleBackColor = false;
            this.btnTellMe.Click += new System.EventHandler(this.btnTellMe_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Gold;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(716, 472);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(156, 62);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnForward
            // 
            this.btnForward.BackColor = System.Drawing.Color.SandyBrown;
            this.btnForward.Location = new System.Drawing.Point(188, 405);
            this.btnForward.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(160, 60);
            this.btnForward.TabIndex = 4;
            this.btnForward.Text = "&Forward";
            this.btnForward.UseVisualStyleBackColor = false;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnBackward
            // 
            this.btnBackward.BackColor = System.Drawing.Color.SandyBrown;
            this.btnBackward.Location = new System.Drawing.Point(18, 403);
            this.btnBackward.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBackward.Name = "btnBackward";
            this.btnBackward.Size = new System.Drawing.Size(160, 62);
            this.btnBackward.TabIndex = 5;
            this.btnBackward.Text = "&Backward";
            this.btnBackward.UseVisualStyleBackColor = false;
            this.btnBackward.Click += new System.EventHandler(this.btnBackward_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(18, 349);
            this.txtInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(852, 26);
            this.txtInput.TabIndex = 6;
            // 
            // txtAnswer
            // 
            this.txtAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer.Location = new System.Drawing.Point(18, 172);
            this.txtAnswer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(852, 136);
            this.txtAnswer.TabIndex = 7;
            this.txtAnswer.Text = "";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.SandyBrown;
            this.btnNext.Location = new System.Drawing.Point(542, 403);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(165, 60);
            this.btnNext.TabIndex = 8;
            this.btnNext.Text = "&Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.Color.DarkOrange;
            this.btnDone.Location = new System.Drawing.Point(716, 403);
            this.btnDone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(156, 60);
            this.btnDone.TabIndex = 9;
            this.btnDone.Text = "&Done";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // frmPalindromes
            // 
            this.AcceptButton = this.btnNext;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(898, 553);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnBackward);
            this.Controls.Add(this.btnForward);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnTellMe);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmPalindromes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Melinda - Task 1 - Palindromes";
            this.Load += new System.EventHandler(this.frmPalindromes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTellMe;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnBackward;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.RichTextBox txtAnswer;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnDone;
    }
}