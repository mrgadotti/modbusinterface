namespace ModbusInterface
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btOut16 = new System.Windows.Forms.CheckBox();
            this.btOut15 = new System.Windows.Forms.CheckBox();
            this.btOut14 = new System.Windows.Forms.CheckBox();
            this.btOut13 = new System.Windows.Forms.CheckBox();
            this.btOut12 = new System.Windows.Forms.CheckBox();
            this.btOut11 = new System.Windows.Forms.CheckBox();
            this.btOut10 = new System.Windows.Forms.CheckBox();
            this.btOut9 = new System.Windows.Forms.CheckBox();
            this.btOut8 = new System.Windows.Forms.CheckBox();
            this.btOut7 = new System.Windows.Forms.CheckBox();
            this.btOut6 = new System.Windows.Forms.CheckBox();
            this.btOut5 = new System.Windows.Forms.CheckBox();
            this.btOut4 = new System.Windows.Forms.CheckBox();
            this.btOut3 = new System.Windows.Forms.CheckBox();
            this.btOut2 = new System.Windows.Forms.CheckBox();
            this.btOut1 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btConnect = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label1.Location = new System.Drawing.Point(14, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Endereço IP da placa:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btOut16);
            this.groupBox1.Controls.Add(this.btOut15);
            this.groupBox1.Controls.Add(this.btOut14);
            this.groupBox1.Controls.Add(this.btOut13);
            this.groupBox1.Controls.Add(this.btOut12);
            this.groupBox1.Controls.Add(this.btOut11);
            this.groupBox1.Controls.Add(this.btOut10);
            this.groupBox1.Controls.Add(this.btOut9);
            this.groupBox1.Controls.Add(this.btOut8);
            this.groupBox1.Controls.Add(this.btOut7);
            this.groupBox1.Controls.Add(this.btOut6);
            this.groupBox1.Controls.Add(this.btOut5);
            this.groupBox1.Controls.Add(this.btOut4);
            this.groupBox1.Controls.Add(this.btOut3);
            this.groupBox1.Controls.Add(this.btOut2);
            this.groupBox1.Controls.Add(this.btOut1);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(12, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 322);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Saídas";
            // 
            // btOut16
            // 
            this.btOut16.Appearance = System.Windows.Forms.Appearance.Button;
            this.btOut16.AutoSize = true;
            this.btOut16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOut16.Location = new System.Drawing.Point(112, 282);
            this.btOut16.MaximumSize = new System.Drawing.Size(100, 30);
            this.btOut16.MinimumSize = new System.Drawing.Size(100, 30);
            this.btOut16.Name = "btOut16";
            this.btOut16.Size = new System.Drawing.Size(100, 30);
            this.btOut16.TabIndex = 39;
            this.btOut16.Text = "Saída 16";
            this.btOut16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btOut16.UseVisualStyleBackColor = true;
            this.btOut16.CheckedChanged += new System.EventHandler(this.btOut16_CheckedChanged);
            // 
            // btOut15
            // 
            this.btOut15.Appearance = System.Windows.Forms.Appearance.Button;
            this.btOut15.AutoSize = true;
            this.btOut15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOut15.Location = new System.Drawing.Point(112, 246);
            this.btOut15.MaximumSize = new System.Drawing.Size(100, 30);
            this.btOut15.MinimumSize = new System.Drawing.Size(100, 30);
            this.btOut15.Name = "btOut15";
            this.btOut15.Size = new System.Drawing.Size(100, 30);
            this.btOut15.TabIndex = 38;
            this.btOut15.Text = "Saída 15";
            this.btOut15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btOut15.UseVisualStyleBackColor = true;
            this.btOut15.CheckedChanged += new System.EventHandler(this.btOut15_CheckedChanged);
            // 
            // btOut14
            // 
            this.btOut14.Appearance = System.Windows.Forms.Appearance.Button;
            this.btOut14.AutoSize = true;
            this.btOut14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOut14.Location = new System.Drawing.Point(112, 210);
            this.btOut14.MaximumSize = new System.Drawing.Size(100, 30);
            this.btOut14.MinimumSize = new System.Drawing.Size(100, 30);
            this.btOut14.Name = "btOut14";
            this.btOut14.Size = new System.Drawing.Size(100, 30);
            this.btOut14.TabIndex = 37;
            this.btOut14.Text = "Saída 14";
            this.btOut14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btOut14.UseVisualStyleBackColor = true;
            this.btOut14.CheckedChanged += new System.EventHandler(this.btOut14_CheckedChanged);
            // 
            // btOut13
            // 
            this.btOut13.Appearance = System.Windows.Forms.Appearance.Button;
            this.btOut13.AutoSize = true;
            this.btOut13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOut13.Location = new System.Drawing.Point(112, 174);
            this.btOut13.MaximumSize = new System.Drawing.Size(100, 30);
            this.btOut13.MinimumSize = new System.Drawing.Size(100, 30);
            this.btOut13.Name = "btOut13";
            this.btOut13.Size = new System.Drawing.Size(100, 30);
            this.btOut13.TabIndex = 36;
            this.btOut13.Text = "Saída 13";
            this.btOut13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btOut13.UseVisualStyleBackColor = true;
            this.btOut13.CheckedChanged += new System.EventHandler(this.btOut13_CheckedChanged);
            // 
            // btOut12
            // 
            this.btOut12.Appearance = System.Windows.Forms.Appearance.Button;
            this.btOut12.AutoSize = true;
            this.btOut12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOut12.Location = new System.Drawing.Point(112, 138);
            this.btOut12.MaximumSize = new System.Drawing.Size(100, 30);
            this.btOut12.MinimumSize = new System.Drawing.Size(100, 30);
            this.btOut12.Name = "btOut12";
            this.btOut12.Size = new System.Drawing.Size(100, 30);
            this.btOut12.TabIndex = 35;
            this.btOut12.Text = "Saída 12";
            this.btOut12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btOut12.UseVisualStyleBackColor = true;
            this.btOut12.CheckedChanged += new System.EventHandler(this.btOut12_CheckedChanged);
            // 
            // btOut11
            // 
            this.btOut11.Appearance = System.Windows.Forms.Appearance.Button;
            this.btOut11.AutoSize = true;
            this.btOut11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOut11.Location = new System.Drawing.Point(112, 102);
            this.btOut11.MaximumSize = new System.Drawing.Size(100, 30);
            this.btOut11.MinimumSize = new System.Drawing.Size(100, 30);
            this.btOut11.Name = "btOut11";
            this.btOut11.Size = new System.Drawing.Size(100, 30);
            this.btOut11.TabIndex = 34;
            this.btOut11.Text = "Saída 11";
            this.btOut11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btOut11.UseVisualStyleBackColor = true;
            this.btOut11.CheckedChanged += new System.EventHandler(this.btOut11_CheckedChanged);
            // 
            // btOut10
            // 
            this.btOut10.Appearance = System.Windows.Forms.Appearance.Button;
            this.btOut10.AutoSize = true;
            this.btOut10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOut10.Location = new System.Drawing.Point(112, 66);
            this.btOut10.MaximumSize = new System.Drawing.Size(100, 30);
            this.btOut10.MinimumSize = new System.Drawing.Size(100, 30);
            this.btOut10.Name = "btOut10";
            this.btOut10.Size = new System.Drawing.Size(100, 30);
            this.btOut10.TabIndex = 33;
            this.btOut10.Text = "Saída 10";
            this.btOut10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btOut10.UseVisualStyleBackColor = true;
            this.btOut10.CheckedChanged += new System.EventHandler(this.btOut10_CheckedChanged);
            // 
            // btOut9
            // 
            this.btOut9.Appearance = System.Windows.Forms.Appearance.Button;
            this.btOut9.AutoSize = true;
            this.btOut9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOut9.Location = new System.Drawing.Point(112, 30);
            this.btOut9.MaximumSize = new System.Drawing.Size(100, 30);
            this.btOut9.MinimumSize = new System.Drawing.Size(100, 30);
            this.btOut9.Name = "btOut9";
            this.btOut9.Size = new System.Drawing.Size(100, 30);
            this.btOut9.TabIndex = 32;
            this.btOut9.Text = "Saída 9";
            this.btOut9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btOut9.UseVisualStyleBackColor = true;
            this.btOut9.CheckedChanged += new System.EventHandler(this.btOut9_CheckedChanged);
            // 
            // btOut8
            // 
            this.btOut8.Appearance = System.Windows.Forms.Appearance.Button;
            this.btOut8.AutoSize = true;
            this.btOut8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOut8.Location = new System.Drawing.Point(6, 282);
            this.btOut8.MaximumSize = new System.Drawing.Size(100, 30);
            this.btOut8.MinimumSize = new System.Drawing.Size(100, 30);
            this.btOut8.Name = "btOut8";
            this.btOut8.Size = new System.Drawing.Size(100, 30);
            this.btOut8.TabIndex = 31;
            this.btOut8.Text = "Saída 8";
            this.btOut8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btOut8.UseVisualStyleBackColor = true;
            this.btOut8.CheckedChanged += new System.EventHandler(this.btOut8_CheckedChanged);
            // 
            // btOut7
            // 
            this.btOut7.Appearance = System.Windows.Forms.Appearance.Button;
            this.btOut7.AutoSize = true;
            this.btOut7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOut7.Location = new System.Drawing.Point(6, 246);
            this.btOut7.MaximumSize = new System.Drawing.Size(100, 30);
            this.btOut7.MinimumSize = new System.Drawing.Size(100, 30);
            this.btOut7.Name = "btOut7";
            this.btOut7.Size = new System.Drawing.Size(100, 30);
            this.btOut7.TabIndex = 30;
            this.btOut7.Text = "Saída 7";
            this.btOut7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btOut7.UseVisualStyleBackColor = true;
            this.btOut7.CheckedChanged += new System.EventHandler(this.btOut7_CheckedChanged);
            // 
            // btOut6
            // 
            this.btOut6.Appearance = System.Windows.Forms.Appearance.Button;
            this.btOut6.AutoSize = true;
            this.btOut6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOut6.Location = new System.Drawing.Point(6, 210);
            this.btOut6.MaximumSize = new System.Drawing.Size(100, 30);
            this.btOut6.MinimumSize = new System.Drawing.Size(100, 30);
            this.btOut6.Name = "btOut6";
            this.btOut6.Size = new System.Drawing.Size(100, 30);
            this.btOut6.TabIndex = 29;
            this.btOut6.Text = "Saída 6";
            this.btOut6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btOut6.UseVisualStyleBackColor = true;
            this.btOut6.CheckedChanged += new System.EventHandler(this.btOut6_CheckedChanged);
            // 
            // btOut5
            // 
            this.btOut5.Appearance = System.Windows.Forms.Appearance.Button;
            this.btOut5.AutoSize = true;
            this.btOut5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOut5.Location = new System.Drawing.Point(6, 174);
            this.btOut5.MaximumSize = new System.Drawing.Size(100, 30);
            this.btOut5.MinimumSize = new System.Drawing.Size(100, 30);
            this.btOut5.Name = "btOut5";
            this.btOut5.Size = new System.Drawing.Size(100, 30);
            this.btOut5.TabIndex = 28;
            this.btOut5.Text = "Saída 5";
            this.btOut5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btOut5.UseVisualStyleBackColor = true;
            this.btOut5.CheckedChanged += new System.EventHandler(this.btOut5_CheckedChanged);
            // 
            // btOut4
            // 
            this.btOut4.Appearance = System.Windows.Forms.Appearance.Button;
            this.btOut4.AutoSize = true;
            this.btOut4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOut4.Location = new System.Drawing.Point(6, 138);
            this.btOut4.MaximumSize = new System.Drawing.Size(100, 30);
            this.btOut4.MinimumSize = new System.Drawing.Size(100, 30);
            this.btOut4.Name = "btOut4";
            this.btOut4.Size = new System.Drawing.Size(100, 30);
            this.btOut4.TabIndex = 27;
            this.btOut4.Text = "Saída 4";
            this.btOut4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btOut4.UseVisualStyleBackColor = true;
            this.btOut4.CheckedChanged += new System.EventHandler(this.btOut4_CheckedChanged);
            // 
            // btOut3
            // 
            this.btOut3.Appearance = System.Windows.Forms.Appearance.Button;
            this.btOut3.AutoSize = true;
            this.btOut3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOut3.Location = new System.Drawing.Point(6, 102);
            this.btOut3.MaximumSize = new System.Drawing.Size(100, 30);
            this.btOut3.MinimumSize = new System.Drawing.Size(100, 30);
            this.btOut3.Name = "btOut3";
            this.btOut3.Size = new System.Drawing.Size(100, 30);
            this.btOut3.TabIndex = 26;
            this.btOut3.Text = "Saída 3";
            this.btOut3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btOut3.UseVisualStyleBackColor = true;
            this.btOut3.CheckedChanged += new System.EventHandler(this.btOut3_CheckedChanged);
            // 
            // btOut2
            // 
            this.btOut2.Appearance = System.Windows.Forms.Appearance.Button;
            this.btOut2.AutoSize = true;
            this.btOut2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOut2.Location = new System.Drawing.Point(6, 66);
            this.btOut2.MaximumSize = new System.Drawing.Size(100, 30);
            this.btOut2.MinimumSize = new System.Drawing.Size(100, 30);
            this.btOut2.Name = "btOut2";
            this.btOut2.Size = new System.Drawing.Size(100, 30);
            this.btOut2.TabIndex = 25;
            this.btOut2.Text = "Saída 2";
            this.btOut2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btOut2.UseVisualStyleBackColor = true;
            this.btOut2.CheckedChanged += new System.EventHandler(this.btOut2_CheckedChanged);
            // 
            // btOut1
            // 
            this.btOut1.Appearance = System.Windows.Forms.Appearance.Button;
            this.btOut1.AutoSize = true;
            this.btOut1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOut1.Location = new System.Drawing.Point(6, 30);
            this.btOut1.MaximumSize = new System.Drawing.Size(100, 30);
            this.btOut1.MinimumSize = new System.Drawing.Size(100, 30);
            this.btOut1.Name = "btOut1";
            this.btOut1.Size = new System.Drawing.Size(100, 30);
            this.btOut1.TabIndex = 24;
            this.btOut1.Text = "Saída 1";
            this.btOut1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btOut1.UseVisualStyleBackColor = true;
            this.btOut1.CheckedChanged += new System.EventHandler(this.btOut1_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.textBox1.Location = new System.Drawing.Point(186, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(157, 27);
            this.textBox1.TabIndex = 24;
            this.textBox1.Text = "192.168.255.1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button16);
            this.groupBox2.Controls.Add(this.button15);
            this.groupBox2.Controls.Add(this.button14);
            this.groupBox2.Controls.Add(this.button13);
            this.groupBox2.Controls.Add(this.button12);
            this.groupBox2.Controls.Add(this.button11);
            this.groupBox2.Controls.Add(this.button10);
            this.groupBox2.Controls.Add(this.button9);
            this.groupBox2.Controls.Add(this.button8);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(237, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(221, 322);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Entradas";
            // 
            // button16
            // 
            this.button16.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.button16.Location = new System.Drawing.Point(112, 282);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(100, 30);
            this.button16.TabIndex = 55;
            this.button16.Text = "Entrada 16";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.button15.Location = new System.Drawing.Point(112, 246);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(100, 30);
            this.button15.TabIndex = 54;
            this.button15.Text = "Entrada 15";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.button14.Location = new System.Drawing.Point(112, 210);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(100, 30);
            this.button14.TabIndex = 53;
            this.button14.Text = "Entrada 14";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.button13.Location = new System.Drawing.Point(112, 174);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(100, 30);
            this.button13.TabIndex = 52;
            this.button13.Text = "Entrada 13";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.button12.Location = new System.Drawing.Point(112, 138);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(100, 30);
            this.button12.TabIndex = 51;
            this.button12.Text = "Entrada 12";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.button11.Location = new System.Drawing.Point(112, 102);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(100, 30);
            this.button11.TabIndex = 50;
            this.button11.Text = "Entrada 11";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.button10.Location = new System.Drawing.Point(112, 66);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(100, 30);
            this.button10.TabIndex = 49;
            this.button10.Text = "Entrada10";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.button9.Location = new System.Drawing.Point(112, 30);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(100, 30);
            this.button9.TabIndex = 48;
            this.button9.Text = "Entrada 9";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.button8.Location = new System.Drawing.Point(6, 282);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(100, 30);
            this.button8.TabIndex = 47;
            this.button8.Text = "Entrada 8";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.button7.Location = new System.Drawing.Point(6, 246);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 30);
            this.button7.TabIndex = 46;
            this.button7.Text = "Entrada 7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.button6.Location = new System.Drawing.Point(6, 210);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 30);
            this.button6.TabIndex = 45;
            this.button6.Text = "Entrada 6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.button5.Location = new System.Drawing.Point(6, 174);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 30);
            this.button5.TabIndex = 44;
            this.button5.Text = "Entrada 5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.button4.Location = new System.Drawing.Point(6, 138);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 30);
            this.button4.TabIndex = 43;
            this.button4.Text = "Entrada 4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.button3.Location = new System.Drawing.Point(6, 102);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 30);
            this.button3.TabIndex = 42;
            this.button3.Text = "Entrada 3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.button2.Location = new System.Drawing.Point(6, 66);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 30);
            this.button2.TabIndex = 41;
            this.button2.Text = "Entrada 2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.button1.Location = new System.Drawing.Point(6, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 40;
            this.button1.Text = "Entrada 1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btConnect
            // 
            this.btConnect.Appearance = System.Windows.Forms.Appearance.Button;
            this.btConnect.AutoSize = true;
            this.btConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConnect.Location = new System.Drawing.Point(349, 19);
            this.btConnect.MaximumSize = new System.Drawing.Size(100, 30);
            this.btConnect.MinimumSize = new System.Drawing.Size(100, 30);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(100, 30);
            this.btConnect.TabIndex = 40;
            this.btConnect.Text = "Conectar";
            this.btConnect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.CheckedChanged += new System.EventHandler(this.btConnect_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 391);
            this.Controls.Add(this.btConnect);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(488, 438);
            this.MinimumSize = new System.Drawing.Size(488, 438);
            this.Name = "Form1";
            this.Text = "LuxShui";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox btOut1;
        private System.Windows.Forms.CheckBox btOut16;
        private System.Windows.Forms.CheckBox btOut15;
        private System.Windows.Forms.CheckBox btOut14;
        private System.Windows.Forms.CheckBox btOut13;
        private System.Windows.Forms.CheckBox btOut12;
        private System.Windows.Forms.CheckBox btOut11;
        private System.Windows.Forms.CheckBox btOut10;
        private System.Windows.Forms.CheckBox btOut9;
        private System.Windows.Forms.CheckBox btOut8;
        private System.Windows.Forms.CheckBox btOut7;
        private System.Windows.Forms.CheckBox btOut6;
        private System.Windows.Forms.CheckBox btOut5;
        private System.Windows.Forms.CheckBox btOut4;
        private System.Windows.Forms.CheckBox btOut3;
        private System.Windows.Forms.CheckBox btOut2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox btConnect;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
    }
}

