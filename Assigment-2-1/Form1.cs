namespace Assigment_2_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblCleanCost_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            long total = GetPay();
            txtTotal.Text = total.ToString();
        }
        private long GetPay()
        {
            long total = 0;
            if (chkClean.Checked) total += 100000;
            if (chkWhitening.Checked) total += 1200000;
            if (chkXray.Checked) total += 200000;
            total += (int)(numFilling.Value) * 80000;

            return total;
        }
    }
}