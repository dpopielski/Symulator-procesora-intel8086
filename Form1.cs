using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace intel_8086_symulator
{
    public partial class form1 : Form
    {

        public form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string AX = textBox3.Text;
            string BX = textBox1.Text;
            string CX = textBox4.Text;
            string DX = textBox2.Text;

            if (comboBox1.Text == "AX" && comboBox2.Text == "BX" && comboBox3.Text == "MOV")
            {
                textBox1.Text = AX + BX;
            }
            else if (comboBox1.Text == "BX" && comboBox2.Text == "AX" && comboBox3.Text == "MOV")
            {
                textBox3.Text = BX + AX;
            }
            else if (comboBox1.Text == "BX" && comboBox2.Text == "CX" && comboBox3.Text == "MOV")
            {
                textBox4.Text = CX + BX;
            }
            else if (comboBox1.Text == "CX" && comboBox2.Text == "BX" && comboBox3.Text == "MOV")
            {
                textBox1.Text = BX + CX;
            }
            else if (comboBox1.Text == "CX" && comboBox2.Text == "DX" && comboBox3.Text == "MOV")
            {
                textBox2.Text = DX + CX;
            }
            else if (comboBox1.Text == "DX" && comboBox2.Text == "CX" && comboBox3.Text == "MOV")
            {
                textBox4.Text = CX + DX;
            }
            else if (comboBox1.Text == "AX" && comboBox2.Text == "CX" && comboBox3.Text == "MOV")
            {
                textBox4.Text = AX + CX;
            }
            else if (comboBox1.Text == "CX" && comboBox2.Text == "AX" && comboBox3.Text == "MOV")
            {
                textBox3.Text = CX + AX;
            }
            else if (comboBox1.Text == "AX" && comboBox2.Text == "DX" && comboBox3.Text == "MOV")
            {
                textBox2.Text = AX + DX;
            }
            else if (comboBox1.Text == "DX" && comboBox2.Text == "AX" && comboBox3.Text == "MOV")
            {
                textBox3.Text = DX + AX;
            }
            else if (comboBox1.Text == "BX" && comboBox2.Text == "DX" && comboBox3.Text == "MOV")
            {
                textBox2.Text = BX + DX;
            }
            else if (comboBox1.Text == "DX" && comboBox2.Text == "BX" && comboBox3.Text == "MOV")
            {
                textBox1.Text = DX + BX;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
            textBox2.ResetText();
            textBox3.ResetText();
            textBox4.ResetText();
            comboBox1.ResetText();
            comboBox2.ResetText();
            comboBox3.ResetText();
        }
    }
}
