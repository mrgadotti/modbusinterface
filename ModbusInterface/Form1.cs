using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyModbus;

namespace ModbusInterface
{
    public partial class Form1 : Form
    {
        ModbusClient modbusClient;

        public Form1()
        {
            InitializeComponent();
            button1.BackColor = Color.Red;
            button2.BackColor = Color.Red;
            button3.BackColor = Color.Red;
            button4.BackColor = Color.Red;
            button5.BackColor = Color.Red;
            button6.BackColor = Color.Red;
            button7.BackColor = Color.Red;
            button8.BackColor = Color.Red;
            button9.BackColor = Color.Red;
            button10.BackColor = Color.Red;
            button11.BackColor = Color.Red;
            button12.BackColor = Color.Red;
            button13.BackColor = Color.Red;
            button14.BackColor = Color.Red;
            button15.BackColor = Color.Red;
            button16.BackColor = Color.Red;

        }
        // Write single coil and check connection
        private void WriteSingleCoilValue(int address, bool value)
        {
            try
            {
                modbusClient.WriteSingleCoil(address, value);
            }
            catch (EasyModbus.Exceptions.ConnectionException ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Erro de conexão com a placa Modbus", "Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                modbusClient.Disconnect();
                groupBox1.Enabled = false;
                groupBox2.Enabled = false;
                btConnect.Checked = false;
                textBox1.Enabled = true;
            }
        }
        // Create connection
        private void btConnect_CheckedChanged(object sender, EventArgs e)
        {
            if (btConnect.Checked)
            {
                textBox1.Enabled = false;
                try
                {
                    Console.WriteLine("Conecting to: " + textBox1.Text);
                    modbusClient = new ModbusClient(textBox1.Text, 502);
                    groupBox1.Enabled = true;
                    groupBox2.Enabled = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
            else
            {
                modbusClient.Disconnect();
                Console.WriteLine("Disconecting...");
                groupBox1.Enabled = false;
                groupBox2.Enabled = false;
                textBox1.Enabled = true;
            }
        }
        private void btOut1_CheckedChanged(object sender, EventArgs e)
        {
            if (btOut1.Checked)
            {
                WriteSingleCoilValue(1, true);
            }
            else
            {
                WriteSingleCoilValue(1, true);
            }
        }

        private void btOut2_CheckedChanged(object sender, EventArgs e)
        {
            if (btOut1.Checked)
            {
                WriteSingleCoilValue(2, true);
            }
            else
            {
                WriteSingleCoilValue(2, true);
            }
        }
    }
}
