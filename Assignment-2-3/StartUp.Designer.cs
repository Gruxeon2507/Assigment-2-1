namespace Assignment_2_3
{
    partial class StartUp
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
            components = new System.ComponentModel.Container();
            progressBar = new ProgressBar();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // progressBar
            // 
            progressBar.Location = new Point(265, 384);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(473, 33);
            progressBar.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.PrimierLeague;
            pictureBox1.ImageLocation = "";
            pictureBox1.Location = new Point(35, 285);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(149, 132);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.ChampionLeague;
            pictureBox2.ImageLocation = "";
            pictureBox2.Location = new Point(35, 81);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(149, 129);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(35, 38);
            label1.Name = "label1";
            label1.Size = new Size(83, 21);
            label1.TabIndex = 3;
            label1.Text = "Đón xem:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(265, 81);
            label2.Name = "label2";
            label2.Size = new Size(335, 21);
            label2.TabIndex = 4;
            label2.Text = "Giới thiệu các câu lạc bộ bóng đá nổi tiếng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(265, 192);
            label3.Name = "label3";
            label3.Size = new Size(334, 42);
            label3.TabIndex = 5;
            label3.Text = "Với nhiều logo đẹp và ấn tượng về các câu\r\n lạc bộ bạn yêu thích";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(265, 351);
            label4.Name = "label4";
            label4.Size = new Size(178, 21);
            label4.TabIndex = 6;
            label4.Text = "Xin chờ trong giây lát:";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // StartUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.FPTU;
            ClientSize = new Size(750, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(progressBar);
            Name = "StartUp";
            Text = "Start Up Form";
            Load += StartUp_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private System.Windows.Forms.Timer timer1;
    }
}