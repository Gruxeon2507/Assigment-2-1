namespace Assigment_2_1
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
            labelTitle = new Label();
            lblName = new Label();
            txtName = new TextBox();
            chkClean = new CheckBox();
            lblCleanCost = new Label();
            label1 = new Label();
            chkWhitening = new CheckBox();
            lblXRayCost = new Label();
            chkXray = new CheckBox();
            numFilling = new NumericUpDown();
            lblFillCost = new Label();
            lblFilling = new Label();
            lblTotal = new Label();
            txtTotal = new TextBox();
            btnExit = new Button();
            btnCalc = new Button();
            ((System.ComponentModel.ISupportInitialize)numFilling).BeginInit();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Impact", 17.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitle.ForeColor = Color.Blue;
            labelTitle.Location = new Point(76, 28);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(212, 28);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Dental Payment Form";
            labelTitle.Click += label1_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(35, 89);
            lblName.Name = "lblName";
            lblName.Size = new Size(94, 15);
            lblName.TabIndex = 1;
            lblName.Text = "Customer Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(147, 86);
            txtName.Name = "txtName";
            txtName.Size = new Size(174, 23);
            txtName.TabIndex = 2;
            // 
            // chkClean
            // 
            chkClean.AutoSize = true;
            chkClean.Location = new Point(35, 126);
            chkClean.Name = "chkClean";
            chkClean.Size = new Size(66, 19);
            chkClean.TabIndex = 3;
            chkClean.Text = "Cạo vôi";
            chkClean.UseVisualStyleBackColor = true;
            // 
            // lblCleanCost
            // 
            lblCleanCost.AutoSize = true;
            lblCleanCost.Location = new Point(272, 127);
            lblCleanCost.Name = "lblCleanCost";
            lblCleanCost.Size = new Size(49, 15);
            lblCleanCost.TabIndex = 4;
            lblCleanCost.Text = "$100000";
            lblCleanCost.Click += lblCleanCost_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(266, 163);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 6;
            label1.Text = "$1200000";
            // 
            // chkWhitening
            // 
            chkWhitening.AutoSize = true;
            chkWhitening.Location = new Point(35, 163);
            chkWhitening.Name = "chkWhitening";
            chkWhitening.Size = new Size(75, 19);
            chkWhitening.TabIndex = 5;
            chkWhitening.Text = "Tẩy trắng";
            chkWhitening.UseVisualStyleBackColor = true;
            // 
            // lblXRayCost
            // 
            lblXRayCost.AutoSize = true;
            lblXRayCost.Location = new Point(272, 200);
            lblXRayCost.Name = "lblXRayCost";
            lblXRayCost.Size = new Size(49, 15);
            lblXRayCost.TabIndex = 8;
            lblXRayCost.Text = "$200000";
            // 
            // chkXray
            // 
            chkXray.AutoSize = true;
            chkXray.Location = new Point(35, 199);
            chkXray.Name = "chkXray";
            chkXray.Size = new Size(114, 19);
            chkXray.TabIndex = 7;
            chkXray.Text = "Chụp Hình Răng";
            chkXray.UseVisualStyleBackColor = true;
            // 
            // numFilling
            // 
            numFilling.Location = new Point(115, 237);
            numFilling.Name = "numFilling";
            numFilling.Size = new Size(64, 23);
            numFilling.TabIndex = 9;
            // 
            // lblFillCost
            // 
            lblFillCost.AutoSize = true;
            lblFillCost.Location = new Point(258, 239);
            lblFillCost.Name = "lblFillCost";
            lblFillCost.Size = new Size(63, 15);
            lblFillCost.TabIndex = 10;
            lblFillCost.Text = "$80000/cái";
            // 
            // lblFilling
            // 
            lblFilling.AutoSize = true;
            lblFilling.Location = new Point(30, 239);
            lblFilling.Name = "lblFilling";
            lblFilling.Size = new Size(63, 15);
            lblFilling.TabIndex = 11;
            lblFilling.Text = "Trám Răng";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(115, 320);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(32, 15);
            lblTotal.TabIndex = 12;
            lblTotal.Text = "Total";
            // 
            // txtTotal
            // 
            txtTotal.Enabled = false;
            txtTotal.Location = new Point(181, 312);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(140, 23);
            txtTotal.TabIndex = 13;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(35, 361);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 14;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(246, 361);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(75, 23);
            btnCalc.TabIndex = 15;
            btnCalc.Text = "Tính tiền";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCalc_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(369, 440);
            Controls.Add(btnCalc);
            Controls.Add(btnExit);
            Controls.Add(txtTotal);
            Controls.Add(lblTotal);
            Controls.Add(lblFilling);
            Controls.Add(lblFillCost);
            Controls.Add(numFilling);
            Controls.Add(lblXRayCost);
            Controls.Add(chkXray);
            Controls.Add(label1);
            Controls.Add(chkWhitening);
            Controls.Add(lblCleanCost);
            Controls.Add(chkClean);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(labelTitle);
            Name = "Form1";
            Text = "Dental Payment Application";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numFilling).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private Label lblName;
        private TextBox txtName;
        private CheckBox chkClean;
        private Label lblCleanCost;
        private Label label1;
        private CheckBox chkWhitening;
        private Label lblXRayCost;
        private CheckBox chkXray;
        private NumericUpDown numFilling;
        private Label lblFillCost;
        private Label lblFilling;
        private Label lblTotal;
        private TextBox txtTotal;
        private Button btnExit;
        private Button btnCalc;
    }
}