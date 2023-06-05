using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2_3
{
    public partial class Lunar : Form
    {
        public Lunar()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int normalYear;
            if (int.TryParse(txtCalYear.Text, out normalYear))
            {
                if (normalYear < 0)
                {
                    MessageBox.Show("Invalid input. Please enter a valid year.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    txtLunarYear.Text = GetLunarYear(normalYear);

                }
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter a valid year.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string GetLunarYear(int normalYear)
        {
            string can="";
            switch (normalYear % 10)
            {
                case 0:
                    can = "CANH";
                    break;
                case 1:
                    can = "TÂN";
                    break;
                case 2:
                    can = "NHÂM";
                    break;
                case 3:
                    can = "QUÝ";
                    break;
                case 4:
                    can = "GIÁP";
                    break;
                case 5:
                    can = "ẤT";
                    break;
                case 6:
                    can = "BÍNH";
                    break;
                case 7:
                    can = "ĐINH";
                    break;
                case 8:
                    can = "MẬU";
                    break;
                case 9:
                    can = "KỶ";
                    break;
            }
            string chi="";
            switch (normalYear % 12)
            {
                case 0:
                    chi = "THÂN";
                    break;
                case 1:
                    chi = "DẬU";
                    break;
                case 2:
                    chi = "TUẤT";
                    break;
                case 3:
                    chi = "HỢI";
                    break;
                case 4:
                    chi = "TÝ";
                    break;
                case 5:
                    chi = "SỬU";
                    break;
                case 6:
                    chi = "DẦN";
                    break;
                case 7:
                    chi = "MÃO";
                    break;
                case 8:
                    chi = "THÌN";
                    break;
                case 9:
                    chi = "TỴ";
                    break;
                case 10:
                    chi = "NGỌ";
                    break;
                case 11:
                    chi = "MÙI";
                    break;
            }
            return can + " " + chi;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtCalYear_Enter(object sender, EventArgs e)
        {
            txtCalYear.BackColor = Color.Pink;
        }

        private void txtCalYear_Leave(object sender, EventArgs e)
        {
            txtCalYear.BackColor = Color.White;
        }

        private void txtLunarYear_Enter(object sender, EventArgs e)
        {
            txtLunarYear.BackColor = Color.Pink;
        }

        private void txtLunarYear_Leave(object sender, EventArgs e)
        {
            txtLunarYear.BackColor = Color.White;
        }

        private void txtLunarYear_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
