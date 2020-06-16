using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_HW_2_TAYLOR_LEAVELLE
{
    public partial class Form1 : Form
    {
        private double subtotal=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            subtotal_placeholder.Text = String.Empty;
            tax_placeholder.Text = String.Empty;
            total_placeholder.Text = String.Empty;
            subtotal = 0;
            comboBox1.Text = String.Empty;
            comboBox2.Text = String.Empty;
            comboBox3.Text = String.Empty;
            comboBox4.Text = String.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 p = new Form2();
            p.Show();
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {
                subtotal += 5.95;
                subtotal_placeholder.Text = subtotal.ToString();
                tax_placeholder.Text = (subtotal * .1).ToString();
                total_placeholder.Text = (subtotal * 1.1).ToString();
            }
            else if (comboBox2.SelectedIndex == 1)
            {
                subtotal += 3.95;
                subtotal_placeholder.Text = subtotal.ToString();
                tax_placeholder.Text = (subtotal * .1).ToString();
                total_placeholder.Text = (subtotal * 1.1).ToString();
            }
            else if (comboBox2.SelectedIndex == 2)
            {
                subtotal += 5.95;
                subtotal_placeholder.Text = subtotal.ToString();
                tax_placeholder.Text = (subtotal * .1).ToString();
                total_placeholder.Text = (subtotal * 1.1).ToString();
            }
            else if (comboBox2.SelectedIndex == 3)
            {
                subtotal += 4.95;
                subtotal_placeholder.Text = subtotal.ToString();
                tax_placeholder.Text = (subtotal * .1).ToString();
                total_placeholder.Text = (subtotal * 1.1).ToString();
            }
            else if (comboBox2.SelectedIndex == 4)
            {
                subtotal += 5.95;
                subtotal_placeholder.Text = subtotal.ToString();
                tax_placeholder.Text = (subtotal * .1).ToString();
                total_placeholder.Text = (subtotal * 1.1).ToString();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            if (comboBox1.SelectedIndex ==0)
            {
                subtotal += 1.95;
                subtotal_placeholder.Text = subtotal.ToString();
                tax_placeholder.Text = (subtotal * .1).ToString();
                total_placeholder.Text = (subtotal * 1.1).ToString();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                subtotal += 1.50;
                subtotal_placeholder.Text = subtotal.ToString();
                tax_placeholder.Text = (subtotal * .1).ToString();
                total_placeholder.Text = (subtotal * 1.1).ToString();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                subtotal += 1.25;
                subtotal_placeholder.Text = subtotal.ToString();
                tax_placeholder.Text = (subtotal * .1).ToString();
                total_placeholder.Text = (subtotal * 1.1).ToString();
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                subtotal += 2.95;
                subtotal_placeholder.Text = subtotal.ToString();
                tax_placeholder.Text = (subtotal * .1).ToString();
                total_placeholder.Text = (subtotal * 1.1).ToString();
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                subtotal += 2.50;
                subtotal_placeholder.Text = subtotal.ToString();
                tax_placeholder.Text = (subtotal * .1).ToString();
                total_placeholder.Text = (subtotal * 1.1).ToString();
            }
            else if (comboBox1.SelectedIndex == 5)
            {
                subtotal += 1.50;
                subtotal_placeholder.Text = subtotal.ToString();
                tax_placeholder.Text = (subtotal * .1).ToString();
                total_placeholder.Text = (subtotal * 1.1).ToString();
            }

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.SelectedIndex == 0)
            {
                subtotal += 5.95;
                subtotal_placeholder.Text = subtotal.ToString();
                tax_placeholder.Text = (subtotal * .1).ToString();
                total_placeholder.Text = (subtotal * 1.1).ToString();
            }
            else if (comboBox4.SelectedIndex == 1)
            {
                subtotal += 6.95;
                subtotal_placeholder.Text = subtotal.ToString();
                tax_placeholder.Text = (subtotal * .1).ToString();
                total_placeholder.Text = (subtotal * 1.1).ToString();
            }
            else if (comboBox4.SelectedIndex == 2)
            {
                subtotal += 8.95;
                subtotal_placeholder.Text = subtotal.ToString();
                tax_placeholder.Text = (subtotal * .1).ToString();
                total_placeholder.Text = (subtotal * 1.1).ToString();
            }
            else if (comboBox4.SelectedIndex == 3)
            {
                subtotal += 8.95;
                subtotal_placeholder.Text = subtotal.ToString();
                tax_placeholder.Text = (subtotal * .1).ToString();
                total_placeholder.Text = (subtotal * 1.1).ToString();
            }
            else if (comboBox4.SelectedIndex == 4)
            {
                subtotal += 10.95;
                subtotal_placeholder.Text = subtotal.ToString();
                tax_placeholder.Text = (subtotal * .1).ToString();
                total_placeholder.Text = (subtotal * 1.1).ToString();
            }
            else if (comboBox4.SelectedIndex == 5)
            {
                subtotal += 12.95;
                subtotal_placeholder.Text = subtotal.ToString();
                tax_placeholder.Text = (subtotal * .1).ToString();
                total_placeholder.Text = (subtotal * 1.1).ToString();
            }
            else if (comboBox4.SelectedIndex == 6)
            {
                subtotal += 6.95;
                subtotal_placeholder.Text = subtotal.ToString();
                tax_placeholder.Text = (subtotal * .1).ToString();
                total_placeholder.Text = (subtotal * 1.1).ToString();
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex == 0)
            {
                subtotal += 15.95;
                subtotal_placeholder.Text = subtotal.ToString();
                tax_placeholder.Text = (subtotal * .1).ToString();
                total_placeholder.Text = (subtotal * 1.1).ToString();
            }
            else if (comboBox3.SelectedIndex == 1)
            {
                subtotal += 13.95;
                subtotal_placeholder.Text = subtotal.ToString();
                tax_placeholder.Text = (subtotal * .1).ToString();
                total_placeholder.Text = (subtotal * 1.1).ToString();
            }
            else if (comboBox3.SelectedIndex == 2)
            {
                subtotal += 13.95;
                subtotal_placeholder.Text = subtotal.ToString();
                tax_placeholder.Text = (subtotal * .1).ToString();
                total_placeholder.Text = (subtotal * 1.1).ToString();
            }
            else if (comboBox3.SelectedIndex == 3)
            {
                subtotal += 11.95;
                subtotal_placeholder.Text = subtotal.ToString();
                tax_placeholder.Text = (subtotal * .1).ToString();
                total_placeholder.Text = (subtotal * 1.1).ToString();
            }
            else if (comboBox3.SelectedIndex == 4)
            {
                subtotal += 19.95;
                subtotal_placeholder.Text = subtotal.ToString();
                tax_placeholder.Text = (subtotal * .1).ToString();
                total_placeholder.Text = (subtotal * 1.1).ToString();
            }
            else if (comboBox3.SelectedIndex == 5)
            {
                subtotal += 20.95;
                subtotal_placeholder.Text = subtotal.ToString();
                tax_placeholder.Text = (subtotal * .1).ToString();
                total_placeholder.Text = (subtotal * 1.1).ToString();
            }
            else if(comboBox3.SelectedIndex == 6)
            {
                subtotal += 18.95;
                subtotal_placeholder.Text = subtotal.ToString();
                tax_placeholder.Text = (subtotal * .1).ToString();
                total_placeholder.Text = (subtotal * 1.1).ToString();
            }
            else if(comboBox3.SelectedIndex == 7)
            {
                subtotal += 13.95;
                subtotal_placeholder.Text = subtotal.ToString();
                tax_placeholder.Text = (subtotal * .1).ToString();
                total_placeholder.Text = (subtotal * 1.1).ToString();
            }
            else if(comboBox3.SelectedIndex == 8)
            {
                subtotal += 14.95;
                subtotal_placeholder.Text = subtotal.ToString();
                tax_placeholder.Text = (subtotal * .1).ToString();
                total_placeholder.Text = (subtotal * 1.1).ToString();
            }
        }

        private void Submit_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
