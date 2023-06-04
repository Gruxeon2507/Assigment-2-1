namespace Assignment_2_3
{
    public partial class StartUp : Form
    {
        public StartUp()
        {
            InitializeComponent();
            timer1.Start();





        }

        private void StartUp_Load(object sender, EventArgs e)
        {


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar.PerformStep();
            if (progressBar.Value == progressBar.Maximum)
            {
                timer1.Stop();
                frmMain mainForm = new frmMain();
                Hide();
                mainForm.Show();
            }

        }
    }
}