﻿namespace CalculatorApplication
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
            btnEqual = new Button();
            txtboxinput2 = new TextBox();
            txtboxinput1 = new TextBox();
            cbOperator = new ComboBox();
            label1 = new Label();
            lblDisplayTotal = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnEqual
            // 
            btnEqual.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEqual.Location = new Point(254, 227);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(112, 41);
            btnEqual.TabIndex = 0;
            btnEqual.Text = "calculate";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += btnEqual_Click;
            // 
            // txtboxinput2
            // 
            txtboxinput2.Location = new Point(245, 142);
            txtboxinput2.Name = "txtboxinput2";
            txtboxinput2.Size = new Size(100, 23);
            txtboxinput2.TabIndex = 1;
            // 
            // txtboxinput1
            // 
            txtboxinput1.Location = new Point(245, 40);
            txtboxinput1.Name = "txtboxinput1";
            txtboxinput1.Size = new Size(100, 23);
            txtboxinput1.TabIndex = 2;
            // 
            // cbOperator
            // 
            cbOperator.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbOperator.FormattingEnabled = true;
            cbOperator.Location = new Point(245, 87);
            cbOperator.Name = "cbOperator";
            cbOperator.Size = new Size(121, 27);
            cbOperator.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(150, 178);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 4;
            label1.Text = "label1";
            // 
            // lblDisplayTotal
            // 
            lblDisplayTotal.AutoSize = true;
            lblDisplayTotal.Location = new Point(254, 178);
            lblDisplayTotal.Name = "lblDisplayTotal";
            lblDisplayTotal.Size = new Size(67, 15);
            lblDisplayTotal.TabIndex = 4;
            lblDisplayTotal.Text = "____________";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(150, 145);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 5;
            label3.Text = "label1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(150, 40);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 6;
            label4.Text = "label4";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(428, 280);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblDisplayTotal);
            Controls.Add(label1);
            Controls.Add(cbOperator);
            Controls.Add(txtboxinput1);
            Controls.Add(txtboxinput2);
            Controls.Add(btnEqual);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEqual;
        private TextBox txtboxinput2;
        private TextBox txtboxinput1;
        private ComboBox cbOperator;
        private Label label1;
        private Label lblDisplayTotal;
        private Label label3;
        private Label label4;
    }
}
