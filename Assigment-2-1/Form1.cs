using Microsoft.VisualBasic.ApplicationServices;

namespace Assigment_2_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Dictionary<string,User> users = new Dictionary<string,User>();
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
            if (txtName.Text.Length == 0)
            {
                MessageBox.Show("Please Enter Your Name");
                txtTotal.Text = "0";
            }
            else
            {
                long total = GetPay();
                txtTotal.Text = total.ToString();
                User user = new User(txtName.Text, chkClean.Checked, chkWhitening.Checked, chkXray.Checked, (int)numFilling.Value);

                if (users.ContainsKey(txtName.Text)){
                    users[txtName.Text] = user;
                }
                else
                {
                    users.Add(txtName.Text, user);

                }
                MessageBox.Show("User:" + txtName.Text + "\nYour Total Price: " + total);
            }

        }
        long total = 0;
        private long GetPay()
        {

            total = 0;
            if (chkClean.Checked) total += 100000;
            if (chkWhitening.Checked) total += 1200000;
            if (chkXray.Checked) total += 200000;
            total += (int)(numFilling.Value) * 80000;

            return total;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if(users.ContainsKey(txtName.Text))
            {
                User user = users[txtName.Text];
                chkClean.Checked = user.chkClean;
                chkWhitening.Checked = user.chkWhitening;
                chkXray.Checked = user.chkXray;
                numFilling.Value = user.number;
                long total = GetPay();
                txtTotal.Text = total.ToString();
            }
            else
            {
                chkClean.Checked = false;
                chkWhitening.Checked = false;
                chkXray.Checked = false;
                numFilling.Value = 0;
                txtTotal.Text = "";
            }
        }

        private void chkClean_CheckedChanged(object sender, EventArgs e)
        {
            if (chkClean.Checked)
            {
                total += 100000;
                txtTotal.Text = total.ToString();
            }
            else
            {
                total -= 100000;
                txtTotal.Text = total.ToString();
            }
        }

        private void chkWhitening_CheckedChanged(object sender, EventArgs e)
        {
            if (chkWhitening.Checked)
            {
                total += 1200000;
                txtTotal.Text = total.ToString();
            }
            else
            {
                total -= 1200000;
                txtTotal.Text = total.ToString();
            }
        }

        private void chkXray_CheckedChanged(object sender, EventArgs e)
        {
            if (chkXray.Checked)
            {
                total += 200000;
                txtTotal.Text = total.ToString();
            }
            else
            {
                total -= 200000;
                txtTotal.Text = total.ToString();
            }
        }
    }
}