namespace CalculatorApplication
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
            label2 = new Label();
            SuspendLayout();
            // 
            // btnEqual
            // 
            btnEqual.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEqual.Location = new Point(160, 207);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(130, 41);
            btnEqual.TabIndex = 0;
            btnEqual.Text = "calculate";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += btnEqual_Click;
            // 
            // txtboxinput2
            // 
            txtboxinput2.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtboxinput2.Location = new Point(160, 132);
            txtboxinput2.Name = "txtboxinput2";
            txtboxinput2.Size = new Size(143, 26);
            txtboxinput2.TabIndex = 1;
            // 
            // txtboxinput1
            // 
            txtboxinput1.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtboxinput1.Location = new Point(160, 30);
            txtboxinput1.Name = "txtboxinput1";
            txtboxinput1.Size = new Size(143, 26);
            txtboxinput1.TabIndex = 2;
            // 
            // cbOperator
            // 
            cbOperator.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbOperator.FormattingEnabled = true;
            cbOperator.Location = new Point(192, 73);
            cbOperator.Name = "cbOperator";
            cbOperator.Size = new Size(68, 27);
            cbOperator.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(100, 183);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 4;
            label1.Text = "Answer:";
            // 
            // lblDisplayTotal
            // 
            lblDisplayTotal.AutoSize = true;
            lblDisplayTotal.Location = new Point(160, 168);
            lblDisplayTotal.Name = "lblDisplayTotal";
            lblDisplayTotal.Size = new Size(17, 15);
            lblDisplayTotal.TabIndex = 4;
            lblDisplayTotal.Text = "__";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 135);
            label3.Name = "label3";
            label3.Size = new Size(126, 15);
            label3.TabIndex = 5;
            label3.Text = "Enter Second Number:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 33);
            label4.Name = "label4";
            label4.Size = new Size(109, 15);
            label4.TabIndex = 6;
            label4.Text = "Enter First Number:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(160, 183);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 7;
            label2.Text = "__________________";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(336, 271);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblDisplayTotal);
            Controls.Add(label1);
            Controls.Add(cbOperator);
            Controls.Add(txtboxinput1);
            Controls.Add(txtboxinput2);
            Controls.Add(btnEqual);
            Name = "Form1";
            Text = "FrmCalculator";
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
        private Label label2;
    }
}
