using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ves_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void rost_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void resault_Click(object sender, EventArgs e)
        {
            String ves1 = ves.Text;
            String rost1 = rost.Text;
            double ves2 = Convert.ToInt32(ves1);
            double rost2 = Convert.ToInt32(rost1);

            string result = "0";
            double resualt = Convert.ToDouble(result);
            resualt = ves2 / (rost2 * rost2) * 10000;
            string res2 = Convert.ToString(resualt);
            textBox1.Text = res2;

            if (resualt > 25)
           {
                MessageBox.Show("Ожирение");
           } 

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
}
