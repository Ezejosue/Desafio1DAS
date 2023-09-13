using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Information : Form
    {
        public Information()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabInfo2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabInfo1;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Information_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabEstadistica;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabEstadistica;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabInfo2;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabInfo1;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
