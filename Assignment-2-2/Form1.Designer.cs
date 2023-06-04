namespace Assignment_2_2
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
            lblSercurityCode = new Label();
            txtSecurityCode = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            buttonHashTag = new Button();
            button0 = new Button();
            buttonClear = new Button();
            txtAccessLog = new Label();
            lbxAccessLog = new ListBox();
            SuspendLayout();
            // 
            // lblSercurityCode
            // 
            lblSercurityCode.AutoSize = true;
            lblSercurityCode.Location = new Point(49, 44);
            lblSercurityCode.Name = "lblSercurityCode";
            lblSercurityCode.Size = new Size(78, 15);
            lblSercurityCode.TabIndex = 0;
            lblSercurityCode.Text = "Secutiry code";
            lblSercurityCode.Click += label1_Click;
            // 
            // txtSecurityCode
            // 
            txtSecurityCode.Location = new Point(133, 42);
            txtSecurityCode.Name = "txtSecurityCode";
            txtSecurityCode.PasswordChar = '*';
            txtSecurityCode.ReadOnly = true;
            txtSecurityCode.Size = new Size(134, 23);
            txtSecurityCode.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(91, 90);
            button1.Name = "button1";
            button1.Size = new Size(35, 35);
            button1.TabIndex = 3;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button9_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(132, 90);
            button2.Name = "button2";
            button2.Size = new Size(35, 35);
            button2.TabIndex = 4;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button9_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(173, 90);
            button3.Name = "button3";
            button3.Size = new Size(35, 35);
            button3.TabIndex = 5;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button9_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(91, 131);
            button4.Name = "button4";
            button4.Size = new Size(35, 35);
            button4.TabIndex = 6;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button9_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(132, 131);
            button5.Name = "button5";
            button5.Size = new Size(35, 35);
            button5.TabIndex = 7;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button9_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(173, 131);
            button6.Name = "button6";
            button6.Size = new Size(35, 35);
            button6.TabIndex = 8;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button9_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Location = new Point(91, 172);
            button7.Name = "button7";
            button7.Size = new Size(35, 35);
            button7.TabIndex = 9;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button9_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button8.Location = new Point(132, 172);
            button8.Name = "button8";
            button8.Size = new Size(35, 35);
            button8.TabIndex = 10;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button9_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button9.Location = new Point(173, 172);
            button9.Name = "button9";
            button9.Size = new Size(35, 35);
            button9.TabIndex = 11;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // buttonHashTag
            // 
            buttonHashTag.BackColor = SystemColors.ActiveCaption;
            buttonHashTag.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonHashTag.ForeColor = Color.FromArgb(255, 128, 255);
            buttonHashTag.Location = new Point(214, 131);
            buttonHashTag.Name = "buttonHashTag";
            buttonHashTag.Size = new Size(35, 35);
            buttonHashTag.TabIndex = 12;
            buttonHashTag.Text = "#";
            buttonHashTag.UseVisualStyleBackColor = false;
            buttonHashTag.Click += buttonHashTag_Click;
            // 
            // button0
            // 
            button0.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button0.Location = new Point(214, 172);
            button0.Name = "button0";
            button0.Size = new Size(35, 35);
            button0.TabIndex = 13;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += button9_Click;
            // 
            // buttonClear
            // 
            buttonClear.BackColor = Color.FromArgb(255, 128, 0);
            buttonClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonClear.ForeColor = Color.Lime;
            buttonClear.Location = new Point(214, 90);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(35, 35);
            buttonClear.TabIndex = 14;
            buttonClear.Text = "C";
            buttonClear.UseVisualStyleBackColor = false;
            buttonClear.Click += buttonClear_Click;
            // 
            // txtAccessLog
            // 
            txtAccessLog.AutoSize = true;
            txtAccessLog.Location = new Point(49, 234);
            txtAccessLog.Name = "txtAccessLog";
            txtAccessLog.Size = new Size(69, 15);
            txtAccessLog.TabIndex = 15;
            txtAccessLog.Text = "Access Log:";
            // 
            // lbxAccessLog
            // 
            lbxAccessLog.FormattingEnabled = true;
            lbxAccessLog.ItemHeight = 15;
            lbxAccessLog.Location = new Point(49, 252);
            lbxAccessLog.Name = "lbxAccessLog";
            lbxAccessLog.Size = new Size(218, 109);
            lbxAccessLog.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(314, 430);
            Controls.Add(lbxAccessLog);
            Controls.Add(txtAccessLog);
            Controls.Add(buttonClear);
            Controls.Add(button0);
            Controls.Add(buttonHashTag);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtSecurityCode);
            Controls.Add(lblSercurityCode);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSercurityCode;
        private TextBox txtSecurityCode;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button buttonHashTag;
        private Button button0;
        private Button buttonClear;
        private Label txtAccessLog;
        private ListBox lbxAccessLog;
    }
}