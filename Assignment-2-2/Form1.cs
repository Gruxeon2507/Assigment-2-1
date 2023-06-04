namespace Assignment_2_2
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> map = new Dictionary<string, string>();
        public Form1()
        {
            InitializeComponent();
            map["1645"] = "Technicians";
            map["1689"] = "Technicians";
            map["8345"] = "Custodians";
            map["9998"] = "Scientist";
            map["1006"] = "Scientist";
            map["1008"] = "Scientist";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtSecurityCode.Text += ((Button)sender).Text;
        }



        private void buttonClear_Click(object sender, EventArgs e)
        {
            txtSecurityCode.Text = "";
        }

        private void buttonHashTag_Click(object sender, EventArgs e)
        {
            if (map.ContainsKey(txtSecurityCode.Text))
            {
                lbxAccessLog.Items.Add(DateTime.Now.ToString("dd-MM-yyyy") + " " + DateTime.Now.ToString("HH:mm:ss") + "\t" + map[txtSecurityCode.Text]);

            }
            else
            {
                lbxAccessLog.Items.Add(DateTime.Now.ToString("dd-MM-yyyy") + " " + DateTime.Now.ToString("HH:mm:ss") + "\t" + "Restricted Access");
            }
            txtSecurityCode.Text = "";
        }
    }
}