namespace CalcProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TxtCount = new TextBox();
            txtResult = new TextBox();
            btnSub = new Button();
            btnDiv = new Button();
            btnMult = new Button();
            ButtonC = new Button();
            btnEight = new Button();
            btnNine = new Button();
            btnSeven = new Button();
            btnSum = new Button();
            btnFive = new Button();
            btnSix = new Button();
            btnFour = new Button();
            btnEqual = new Button();
            btnTwo = new Button();
            btnThree = new Button();
            btnOne = new Button();
            btnZero = new Button();
            SuspendLayout();
            // 
            // TxtCount
            // 
            TxtCount.Location = new Point(36, 56);
            TxtCount.Name = "TxtCount";
            TxtCount.ReadOnly = true;
            TxtCount.Size = new Size(264, 23);
            TxtCount.TabIndex = 0;
            TxtCount.TextAlign = HorizontalAlignment.Right;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(72, 101);
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.Size = new Size(228, 23);
            txtResult.TabIndex = 1;
            txtResult.TextAlign = HorizontalAlignment.Right;
            // 
            // btnSub
            // 
            btnSub.Location = new Point(240, 157);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(70, 55);
            btnSub.TabIndex = 9;
            btnSub.Text = "-";
            btnSub.UseVisualStyleBackColor = true;
            btnSub.Click += btnSub_Click;
            // 
            // btnDiv
            // 
            btnDiv.Location = new Point(88, 157);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(70, 55);
            btnDiv.TabIndex = 8;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += btnDiv_Click;
            // 
            // btnMult
            // 
            btnMult.Location = new Point(164, 157);
            btnMult.Name = "btnMult";
            btnMult.Size = new Size(70, 55);
            btnMult.TabIndex = 7;
            btnMult.Text = "*";
            btnMult.UseVisualStyleBackColor = true;
            btnMult.Click += btnMult_Click;
            // 
            // ButtonC
            // 
            ButtonC.Location = new Point(12, 156);
            ButtonC.Name = "ButtonC";
            ButtonC.Size = new Size(70, 56);
            ButtonC.TabIndex = 6;
            ButtonC.Text = "C";
            ButtonC.UseVisualStyleBackColor = true;
            ButtonC.Click += btnC_Click;
            // 
            // btnEight
            // 
            btnEight.Location = new Point(88, 218);
            btnEight.Name = "btnEight";
            btnEight.Size = new Size(70, 55);
            btnEight.TabIndex = 12;
            btnEight.Text = "8";
            btnEight.UseVisualStyleBackColor = true;
            btnEight.Click += btnEight_Click;
            // 
            // btnNine
            // 
            btnNine.Location = new Point(164, 218);
            btnNine.Name = "btnNine";
            btnNine.Size = new Size(70, 55);
            btnNine.TabIndex = 11;
            btnNine.Text = "9";
            btnNine.UseVisualStyleBackColor = true;
            btnNine.Click += btnNine_Click;
            // 
            // btnSeven
            // 
            btnSeven.Location = new Point(12, 217);
            btnSeven.Name = "btnSeven";
            btnSeven.Size = new Size(70, 56);
            btnSeven.TabIndex = 10;
            btnSeven.Text = "7";
            btnSeven.UseVisualStyleBackColor = true;
            btnSeven.Click += btnSeven_Click;
            // 
            // btnSum
            // 
            btnSum.Location = new Point(240, 218);
            btnSum.Name = "btnSum";
            btnSum.Size = new Size(70, 116);
            btnSum.TabIndex = 17;
            btnSum.Text = "+";
            btnSum.UseVisualStyleBackColor = true;
            btnSum.Click += btnSum_Click;
            // 
            // btnFive
            // 
            btnFive.Location = new Point(88, 279);
            btnFive.Name = "btnFive";
            btnFive.Size = new Size(70, 55);
            btnFive.TabIndex = 16;
            btnFive.Text = "5";
            btnFive.UseVisualStyleBackColor = true;
            btnFive.Click += btnFive_Click;
            // 
            // btnSix
            // 
            btnSix.Location = new Point(164, 279);
            btnSix.Name = "btnSix";
            btnSix.Size = new Size(70, 55);
            btnSix.TabIndex = 15;
            btnSix.Text = "6";
            btnSix.UseVisualStyleBackColor = true;
            btnSix.Click += btnSix_Click;
            // 
            // btnFour
            // 
            btnFour.Location = new Point(12, 278);
            btnFour.Name = "btnFour";
            btnFour.Size = new Size(70, 56);
            btnFour.TabIndex = 14;
            btnFour.Text = "4";
            btnFour.UseVisualStyleBackColor = true;
            btnFour.Click += btnFour_Click;
            // 
            // btnEqual
            // 
            btnEqual.Location = new Point(240, 340);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(70, 55);
            btnEqual.TabIndex = 21;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += btnEqual_Click;
            // 
            // btnTwo
            // 
            btnTwo.Location = new Point(88, 340);
            btnTwo.Name = "btnTwo";
            btnTwo.Size = new Size(70, 55);
            btnTwo.TabIndex = 20;
            btnTwo.Text = "2";
            btnTwo.UseVisualStyleBackColor = true;
            btnTwo.Click += btnTwo_Click;
            // 
            // btnThree
            // 
            btnThree.Location = new Point(164, 340);
            btnThree.Name = "btnThree";
            btnThree.Size = new Size(70, 55);
            btnThree.TabIndex = 19;
            btnThree.Text = "3";
            btnThree.UseVisualStyleBackColor = true;
            btnThree.Click += btnThree_Click;
            // 
            // btnOne
            // 
            btnOne.Location = new Point(12, 339);
            btnOne.Name = "btnOne";
            btnOne.Size = new Size(70, 56);
            btnOne.TabIndex = 18;
            btnOne.Text = "1";
            btnOne.UseVisualStyleBackColor = true;
            btnOne.Click += btnOne_Click;
            // 
            // btnZero
            // 
            btnZero.Location = new Point(12, 401);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(297, 56);
            btnZero.TabIndex = 22;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = true;
            btnZero.Click += btnZero_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(321, 469);
            Controls.Add(btnZero);
            Controls.Add(btnEqual);
            Controls.Add(btnTwo);
            Controls.Add(btnThree);
            Controls.Add(btnOne);
            Controls.Add(btnSum);
            Controls.Add(btnFive);
            Controls.Add(btnSix);
            Controls.Add(btnFour);
            Controls.Add(btnEight);
            Controls.Add(btnNine);
            Controls.Add(btnSeven);
            Controls.Add(btnSub);
            Controls.Add(btnDiv);
            Controls.Add(btnMult);
            Controls.Add(ButtonC);
            Controls.Add(txtResult);
            Controls.Add(TxtCount);
            Name = "Form1";
            Text = "Calc";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtCount;
        private TextBox txtResult;
        private Button btnSub;
        private Button btnDiv;
        private Button btnMult;
        private Button ButtonC;
        private Button btnEight;
        private Button btnNine;
        private Button btnSeven;
        private Button btnSum;
        private Button btnFive;
        private Button btnSix;
        private Button btnFour;
        private Button btnEqual;
        private Button btnTwo;
        private Button btnThree;
        private Button btnOne;
        private Button btnZero;
    }
}