using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModbusInterface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Checkbox");
            Console.WriteLine(checkBox1.Checked);
            if (checkBox1.Checked)
            {
                checkBox1.BackColor = Color.LightGreen;
                button1.BackColor = Color.LightGreen;
            }
            else
            {
                checkBox1.BackColor = Color.Red;
                button1.BackColor = Color.Red;
            }
        }
    }
}
