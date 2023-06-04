namespace Assignment_2_3
{
    partial class Lunar
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
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            txtCalYear = new TextBox();
            txtLunarYear = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(63, 31);
            label2.Name = "label2";
            label2.Size = new Size(366, 21);
            label2.TabIndex = 6;
            label2.Text = "Chương trình đổi năm dương lịch sang âm lịch";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(102, 82);
            label1.Name = "label1";
            label1.Size = new Size(138, 21);
            label1.TabIndex = 7;
            label1.Text = "Năm dương lịch:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(102, 118);
            label3.Name = "label3";
            label3.Size = new Size(111, 21);
            label3.TabIndex = 8;
            label3.Text = "Năm âm lịch:";
            // 
            // txtCalYear
            // 
            txtCalYear.Location = new Point(271, 84);
            txtCalYear.Name = "txtCalYear";
            txtCalYear.Size = new Size(100, 23);
            txtCalYear.TabIndex = 9;
            txtCalYear.Enter += txtCalYear_Enter;
            txtCalYear.Leave += txtCalYear_Leave;
            // 
            // txtLunarYear
            // 
            txtLunarYear.Location = new Point(271, 120);
            txtLunarYear.Name = "txtLunarYear";
            txtLunarYear.Size = new Size(100, 23);
            txtLunarYear.TabIndex = 10;
            txtLunarYear.Enter += txtLunarYear_Enter;
            txtLunarYear.Leave += txtLunarYear_Leave;
            // 
            // button1
            // 
            button1.Location = new Point(89, 182);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 11;
            button1.Text = "View";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(338, 182);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 12;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Lunar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(506, 255);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtLunarYear);
            Controls.Add(txtCalYear);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "Lunar";
            Text = "Calendar -> Lunar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox txtCalYear;
        private TextBox txtLunarYear;
        private Button button1;
        private Button button2;
    }
}