using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _27.ORN_Sinema_Bufe_SatısUyg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int genel_toplam = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            int cay, su, mısır, bilet, toplam;

            cay = Convert.ToInt32(textBox1.Text);
            su = Convert.ToInt32(textBox2.Text);
            mısır = Convert.ToInt32(textBox3.Text);
            bilet = Convert.ToInt32(textBox4.Text);

            toplam = (cay * 2) + (su * 1) + (mısır * 4) + (bilet * 8);
            label10.Text = toplam + " TL";

            genel_toplam = genel_toplam + toplam;
            label13.Text = genel_toplam + " TL";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox1.Focus();
        }
    }
}
