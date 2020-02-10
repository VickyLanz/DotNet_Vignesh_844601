namespace SampleADOApp
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnSolution = new System.Windows.Forms.Button();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.txtSecond = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbAdd = new System.Windows.Forms.RadioButton();
            this.rdbSub = new System.Windows.Forms.RadioButton();
            this.rdbMultiply = new System.Windows.Forms.RadioButton();
            this.rdbDivide = new System.Windows.Forms.RadioButton();
            this.lblSolution = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter First number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter second number";
            // 
            // btnSolution
            // 
            this.btnSolution.Location = new System.Drawing.Point(268, 156);
            this.btnSolution.Name = "btnSolution";
            this.btnSolution.Size = new System.Drawing.Size(75, 23);
            this.btnSolution.TabIndex = 2;
            this.btnSolution.Text = "Get Solution";
            this.btnSolution.UseVisualStyleBackColor = true;
            this.btnSolution.Click += new System.EventHandler(this.btnSolution_Click);
            // 
            // txtFirst
            // 
            this.txtFirst.Location = new System.Drawing.Point(268, 44);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(100, 20);
            this.txtFirst.TabIndex = 3;
            // 
            // txtSecond
            // 
            this.txtSecond.Location = new System.Drawing.Point(268, 93);
            this.txtSecond.Name = "txtSecond";
            this.txtSecond.Size = new System.Drawing.Size(100, 20);
            this.txtSecond.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbDivide);
            this.groupBox1.Controls.Add(this.rdbMultiply);
            this.groupBox1.Controls.Add(this.rdbSub);
            this.groupBox1.Controls.Add(this.rdbAdd);
            this.groupBox1.Location = new System.Drawing.Point(29, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Your Choice";
            // 
            // rdbAdd
            // 
            this.rdbAdd.AutoSize = true;
            this.rdbAdd.Location = new System.Drawing.Point(35, 19);
            this.rdbAdd.Name = "rdbAdd";
            this.rdbAdd.Size = new System.Drawing.Size(44, 17);
            this.rdbAdd.TabIndex = 0;
            this.rdbAdd.TabStop = true;
            this.rdbAdd.Text = "Add";
            this.rdbAdd.UseVisualStyleBackColor = true;
            // 
            // rdbSub
            // 
            this.rdbSub.AutoSize = true;
            this.rdbSub.Location = new System.Drawing.Point(35, 42);
            this.rdbSub.Name = "rdbSub";
            this.rdbSub.Size = new System.Drawing.Size(65, 17);
            this.rdbSub.TabIndex = 1;
            this.rdbSub.TabStop = true;
            this.rdbSub.Text = "Subtract";
            this.rdbSub.UseVisualStyleBackColor = true;
            this.rdbSub.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rdbMultiply
            // 
            this.rdbMultiply.AutoSize = true;
            this.rdbMultiply.Location = new System.Drawing.Point(35, 65);
            this.rdbMultiply.Name = "rdbMultiply";
            this.rdbMultiply.Size = new System.Drawing.Size(60, 17);
            this.rdbMultiply.TabIndex = 2;
            this.rdbMultiply.TabStop = true;
            this.rdbMultiply.Text = "Multiply";
            this.rdbMultiply.UseVisualStyleBackColor = true;
            // 
            // rdbDivide
            // 
            this.rdbDivide.AutoSize = true;
            this.rdbDivide.Location = new System.Drawing.Point(35, 83);
            this.rdbDivide.Name = "rdbDivide";
            this.rdbDivide.Size = new System.Drawing.Size(55, 17);
            this.rdbDivide.TabIndex = 3;
            this.rdbDivide.TabStop = true;
            this.rdbDivide.Text = "Divide";
            this.rdbDivide.UseVisualStyleBackColor = true;
            this.rdbDivide.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // lblSolution
            // 
            this.lblSolution.AutoSize = true;
            this.lblSolution.Location = new System.Drawing.Point(265, 123);
            this.lblSolution.Name = "lblSolution";
            this.lblSolution.Size = new System.Drawing.Size(37, 13);
            this.lblSolution.TabIndex = 6;
            this.lblSolution.Text = "Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 295);
            this.Controls.Add(this.lblSolution);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSecond);
            this.Controls.Add(this.txtFirst);
            this.Controls.Add(this.btnSolution);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Calculation";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSolution;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.TextBox txtSecond;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbDivide;
        private System.Windows.Forms.RadioButton rdbMultiply;
        private System.Windows.Forms.RadioButton rdbSub;
        private System.Windows.Forms.RadioButton rdbAdd;
        private System.Windows.Forms.Label lblSolution;
    }
}

