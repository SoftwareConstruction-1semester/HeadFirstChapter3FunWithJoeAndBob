﻿namespace HeadFirstChapter3FunWithJoeAndBob
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.joesCashLabel = new System.Windows.Forms.Label();
            this.bobsCashLabel = new System.Windows.Forms.Label();
            this.bankCashLabel = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 66);
            this.button1.TabIndex = 0;
            this.button1.Text = "Give $10 to Joe";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(154, 125);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 66);
            this.button2.TabIndex = 1;
            this.button2.Text = "Receive $5 from Bob";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // joesCashLabel
            // 
            this.joesCashLabel.AccessibleDescription = "";
            this.joesCashLabel.AccessibleName = "";
            this.joesCashLabel.AutoSize = true;
            this.joesCashLabel.Location = new System.Drawing.Point(24, 33);
            this.joesCashLabel.Name = "joesCashLabel";
            this.joesCashLabel.Size = new System.Drawing.Size(65, 13);
            this.joesCashLabel.TabIndex = 2;
            this.joesCashLabel.Text = "Joe has $50";
            // 
            // bobsCashLabel
            // 
            this.bobsCashLabel.AccessibleName = "bobsCashLabel";
            this.bobsCashLabel.AutoSize = true;
            this.bobsCashLabel.Location = new System.Drawing.Point(24, 63);
            this.bobsCashLabel.Name = "bobsCashLabel";
            this.bobsCashLabel.Size = new System.Drawing.Size(73, 13);
            this.bobsCashLabel.TabIndex = 3;
            this.bobsCashLabel.Text = "Bob has $100";
            // 
            // bankCashLabel
            // 
            this.bankCashLabel.AccessibleName = "bankCashLabel";
            this.bankCashLabel.AutoSize = true;
            this.bankCashLabel.Location = new System.Drawing.Point(24, 92);
            this.bankCashLabel.Name = "bankCashLabel";
            this.bankCashLabel.Size = new System.Drawing.Size(101, 13);
            this.bankCashLabel.TabIndex = 4;
            this.bankCashLabel.Text = "The Bank has $100";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(27, 209);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 66);
            this.button3.TabIndex = 5;
            this.button3.Text = "Joe gives $10 to Bob";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(154, 209);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(109, 66);
            this.button4.TabIndex = 6;
            this.button4.Text = "Bob gives $5 to Joe";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 296);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.bankCashLabel);
            this.Controls.Add(this.bobsCashLabel);
            this.Controls.Add(this.joesCashLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label joesCashLabel;
        private System.Windows.Forms.Label bobsCashLabel;
        private System.Windows.Forms.Label bankCashLabel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

