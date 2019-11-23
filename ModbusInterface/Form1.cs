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
using System.Threading;

/*
 * References:
 * http://easymodbustcp.net/codesampleseasymodbustcp-net
 * https://sourceforge.net/projects/easymodbustcp/
 */

namespace ModbusInterface
{
    public partial class Form1 : Form
    {
        ModbusClient modbusClient;
        Thread t;
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
            t = new Thread(new ThreadStart(UpdateInputs));
            t.Start();
            this.FormClosing += Form1_FormClosing;
        }
        // Write single coil and check connection
        private void WriteSingleCoilValue(int address, bool value)
        {
            try
            {
                modbusClient.WriteSingleCoil(address, value);
            }
            //catch (EasyModbus.Exceptions.ConnectionException ex)
            catch (Exception ex)
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
        private bool[] ReadDiscretInputsValue()
        {
            bool[] readInputs = new bool[16];
            try
            {
                readInputs = modbusClient.ReadDiscreteInputs(0, 16);
                return readInputs;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Erro de conexão com a placa Modbus", "Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                modbusClient.Disconnect();
                modbusClient = null;
              }
            return readInputs;
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
                    modbusClient.Connect();
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
                if(modbusClient != null)
                {
                    modbusClient.Disconnect();
                    Console.WriteLine("Disconecting...");
                    groupBox1.Enabled = false;
                    groupBox2.Enabled = false;
                    textBox1.Enabled = true;
                }
            }
        }
        /*
         * Create actions from output buttons
         */
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

        private void btOut3_CheckedChanged(object sender, EventArgs e)
        {
            if (btOut3.Checked)
            {
                WriteSingleCoilValue(3, true);
            }
            else
            {
                WriteSingleCoilValue(3, true);
            }

        }

        private void btOut4_CheckedChanged(object sender, EventArgs e)
        {
            if (btOut4.Checked)
            {
                WriteSingleCoilValue(4, true);
            }
            else
            {
                WriteSingleCoilValue(4, true);
            }
        }

        private void btOut5_CheckedChanged(object sender, EventArgs e)
        {
            if (btOut5.Checked)
            {
                WriteSingleCoilValue(5, true);
            }
            else
            {
                WriteSingleCoilValue(5, true);
            }
        }

        private void btOut6_CheckedChanged(object sender, EventArgs e)
        {
            if (btOut6.Checked)
            {
                WriteSingleCoilValue(6, true);
            }
            else
            {
                WriteSingleCoilValue(6, true);
            }
        }

        private void btOut7_CheckedChanged(object sender, EventArgs e)
        {
            if (btOut7.Checked)
            {
                WriteSingleCoilValue(7, true);
            }
            else
            {
                WriteSingleCoilValue(7, true);
            }
        }

        private void btOut8_CheckedChanged(object sender, EventArgs e)
        {
            if (btOut8.Checked)
            {
                WriteSingleCoilValue(8, true);
            }
            else
            {
                WriteSingleCoilValue(8, false);
            }
        }

        private void btOut9_CheckedChanged(object sender, EventArgs e)
        {
            if (btOut9.Checked)
            {
                WriteSingleCoilValue(9, true);
            }
            else
            {
                WriteSingleCoilValue(9, true);
            }
        }

        private void btOut10_CheckedChanged(object sender, EventArgs e)
        {
            if (btOut10.Checked)
            {
                WriteSingleCoilValue(10, true);
            }
            else
            {
                WriteSingleCoilValue(10, true);
            }
        }

        private void btOut11_CheckedChanged(object sender, EventArgs e)
        {
            if (btOut11.Checked)
            {
                WriteSingleCoilValue(11, true);
            }
            else
            {
                WriteSingleCoilValue(11, true);
            }
        }

        private void btOut12_CheckedChanged(object sender, EventArgs e)
        {
            if (btOut12.Checked)
            {
                WriteSingleCoilValue(12, true);
            }
            else
            {
                WriteSingleCoilValue(12, true);
            }
        }

        private void btOut13_CheckedChanged(object sender, EventArgs e)
        {
            if (btOut13.Checked)
            {
                WriteSingleCoilValue(13, true);
            }
            else
            {
                WriteSingleCoilValue(13, true);
            }
        }

        private void btOut14_CheckedChanged(object sender, EventArgs e)
        {
            if (btOut14.Checked)
            {
                WriteSingleCoilValue(14, true);
            }
            else
            {
                WriteSingleCoilValue(14, true);
            }
        }

        private void btOut15_CheckedChanged(object sender, EventArgs e)
        {
            if (btOut15.Checked)
            {
                WriteSingleCoilValue(15, true);
            }
            else
            {
                WriteSingleCoilValue(15, true);
            }
        }

        private void btOut16_CheckedChanged(object sender, EventArgs e)
        {
            if (btOut16.Checked)
            {
                WriteSingleCoilValue(16, true);
            }
            else
            {
                WriteSingleCoilValue(16, true);
            }
        }
        /*
         * Update input status
         * 
         */
         public void UpdateInputs()
        {
            while (true)
            {
                if(modbusClient != null)
                {
                    Thread.Sleep(500);
                    bool[] readInputs = ReadDiscretInputsValue();
                    /*
                    Console.WriteLine("\r\n-----------------------------------------------------");
                    for (int i = 0; i < readInputs.Length; i++)
                    {
                        Console.WriteLine("Value of input " + i + " -> " + readInputs[i].ToString());
                    }
                    Console.WriteLine("-----------------------------------------------------");
                    */
                    if (readInputs[0])
                    {
                        button1.BackColor = Color.LightGreen;
                    }
                    else
                    {
                        button1.BackColor = Color.Red;
                    }
                    if (readInputs[1])
                    {
                        button2.BackColor = Color.LightGreen;
                    }
                    else
                    {
                        button2.BackColor = Color.Red;
                    }
                    if (readInputs[2])
                    {
                        button3.BackColor = Color.LightGreen;
                    }
                    else
                    {
                        button3.BackColor = Color.Red;
                    }
                    if (readInputs[3])
                    {
                        button4.BackColor = Color.LightGreen;
                    }
                    else
                    {
                        button4.BackColor = Color.Red;
                    }
                    if (readInputs[4])
                    {
                        button5.BackColor = Color.LightGreen;
                    }
                    else
                    {
                        button5.BackColor = Color.Red;
                    }
                    if (readInputs[5])
                    {
                        button6.BackColor = Color.LightGreen;
                    }
                    else
                    {
                        button6.BackColor = Color.Red;
                    }
                    if (readInputs[6])
                    {
                        button7.BackColor = Color.LightGreen;
                    }
                    else
                    {
                        button7.BackColor = Color.Red;
                    }
                    if (readInputs[7])
                    {
                        button8.BackColor = Color.LightGreen;
                    }
                    else
                    {
                        button8.BackColor = Color.Red;
                    }
                    if (readInputs[8])
                    {
                        button9.BackColor = Color.LightGreen;
                    }
                    else
                    {
                        button9.BackColor = Color.Red;
                    }
                    if (readInputs[9])
                    {
                        button10.BackColor = Color.LightGreen;
                    }
                    else
                    {
                        button10.BackColor = Color.Red;
                    }
                    if (readInputs[10])
                    {
                        button11.BackColor = Color.LightGreen;
                    }
                    else
                    {
                        button11.BackColor = Color.Red;
                    }
                    if (readInputs[11])
                    {
                        button12.BackColor = Color.LightGreen;
                    }
                    else
                    {
                        button12.BackColor = Color.Red;
                    }
                    if (readInputs[12])
                    {
                        button13.BackColor = Color.LightGreen;
                    }
                    else
                    {
                        button13.BackColor = Color.Red;
                    }
                    if (readInputs[13])
                    {
                        button14.BackColor = Color.LightGreen;
                    }
                    else
                    {
                        button14.BackColor = Color.Red;
                    }
                    if (readInputs[14])
                    {
                        button15.BackColor = Color.LightGreen;
                    }
                    else
                    {
                        button15.BackColor = Color.Red;
                    }
                    if (readInputs[15])
                    {
                        button16.BackColor = Color.LightGreen;
                    }
                    else
                    {
                        button16.BackColor = Color.Red;
                    }
                }
            }
        }

        private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {

            t.Abort();
            System.Environment.Exit(0);
        }
    }
}
