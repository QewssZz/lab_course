using System;
using System.Windows.Forms;

namespace lab_course
{

    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.nudIntensity = new System.Windows.Forms.NumericUpDown();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.process1 = new System.Diagnostics.Process();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.nudBurstMin = new System.Windows.Forms.NumericUpDown();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.nudBurstMax = new System.Windows.Forms.NumericUpDown();
            this.cbRamSize = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.nudAddrSpaceMin = new System.Windows.Forms.NumericUpDown();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.nudAddrSpaceMax = new System.Windows.Forms.NumericUpDown();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.OccupiedSize = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.FreeSize = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label14 = new System.Windows.Forms.Label();
            this.lblDevice_1 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.rbManual = new System.Windows.Forms.RadioButton();
            this.label15 = new System.Windows.Forms.Label();
            this.rbAuto = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnWork = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel12 = new System.Windows.Forms.Panel();
            this.nudPriority = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.lblDevice_2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.lblCPULoad = new System.Windows.Forms.Label();
            this.CPULoad = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.Perfomance = new System.Windows.Forms.Label();
            this.lblPerfomance = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudIntensity)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBurstMin)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBurstMax)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddrSpaceMin)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddrSpaceMax)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPriority)).BeginInit();
            this.panel13.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel15.SuspendLayout();
            this.SuspendLayout();
            // 
            // nudIntensity
            // 
            this.nudIntensity.DecimalPlaces = 1;
            this.nudIntensity.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudIntensity.Location = new System.Drawing.Point(-1, 70);
            this.nudIntensity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudIntensity.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudIntensity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudIntensity.Name = "nudIntensity";
            this.nudIntensity.Size = new System.Drawing.Size(149, 22);
            this.nudIntensity.TabIndex = 1;
            this.nudIntensity.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.nudIntensity);
            this.panel1.Location = new System.Drawing.Point(12, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(149, 94);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 51);
            this.label1.TabIndex = 2;
            this.label1.Text = "Интенсивность\r\nпоступления \r\nпроцессов\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.nudBurstMin);
            this.panel2.Location = new System.Drawing.Point(205, 15);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(149, 94);
            this.panel2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 68);
            this.label2.TabIndex = 5;
            this.label2.Text = "Минимальное \r\nзначение\r\nпромежутка\r\nработы на ЦП\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudBurstMin
            // 
            this.nudBurstMin.Location = new System.Drawing.Point(-1, 70);
            this.nudBurstMin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudBurstMin.Name = "nudBurstMin";
            this.nudBurstMin.Size = new System.Drawing.Size(149, 22);
            this.nudBurstMin.TabIndex = 4;
            this.nudBurstMin.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.nudBurstMax);
            this.panel3.Location = new System.Drawing.Point(401, 15);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(149, 94);
            this.panel3.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 68);
            this.label3.TabIndex = 1;
            this.label3.Text = "Максимальное \r\nзначение\r\nпромежутка\r\nработы на ЦП";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudBurstMax
            // 
            this.nudBurstMax.Location = new System.Drawing.Point(-1, 70);
            this.nudBurstMax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudBurstMax.Name = "nudBurstMax";
            this.nudBurstMax.Size = new System.Drawing.Size(149, 22);
            this.nudBurstMax.TabIndex = 0;
            this.nudBurstMax.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // cbRamSize
            // 
            this.cbRamSize.FormattingEnabled = true;
            this.cbRamSize.Items.AddRange(new object[] {
            "1000",
            "2000",
            "4000",
            "8000",
            "16000",
            "32000",
            "64000"});
            this.cbRamSize.Location = new System.Drawing.Point(-1, 68);
            this.cbRamSize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbRamSize.Name = "cbRamSize";
            this.cbRamSize.Size = new System.Drawing.Size(148, 24);
            this.cbRamSize.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.cbRamSize);
            this.panel4.Location = new System.Drawing.Point(835, 15);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(149, 94);
            this.panel4.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 51);
            this.label4.TabIndex = 6;
            this.label4.Text = "Размер\r\nоперативной \r\nпамяти";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.nudAddrSpaceMin);
            this.panel5.Location = new System.Drawing.Point(1051, 15);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(149, 94);
            this.panel5.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 68);
            this.label5.TabIndex = 1;
            this.label5.Text = "Минимальный \r\nразмер адресного\r\nпространства\r\nпроцесса";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // nudAddrSpaceMin
            // 
            this.nudAddrSpaceMin.Location = new System.Drawing.Point(-1, 69);
            this.nudAddrSpaceMin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudAddrSpaceMin.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudAddrSpaceMin.Name = "nudAddrSpaceMin";
            this.nudAddrSpaceMin.Size = new System.Drawing.Size(149, 22);
            this.nudAddrSpaceMin.TabIndex = 0;
            this.nudAddrSpaceMin.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudAddrSpaceMin.ValueChanged += new System.EventHandler(this.numericUpDown4_ValueChanged);
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.nudAddrSpaceMax);
            this.panel6.Location = new System.Drawing.Point(1252, 15);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(149, 94);
            this.panel6.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 68);
            this.label6.TabIndex = 1;
            this.label6.Text = "Максимальный \r\nразмер адресного\r\nпространства\r\nпроцесса";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudAddrSpaceMax
            // 
            this.nudAddrSpaceMax.Location = new System.Drawing.Point(-1, 68);
            this.nudAddrSpaceMax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudAddrSpaceMax.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudAddrSpaceMax.Name = "nudAddrSpaceMax";
            this.nudAddrSpaceMax.Size = new System.Drawing.Size(149, 22);
            this.nudAddrSpaceMax.TabIndex = 0;
            this.nudAddrSpaceMax.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.nudAddrSpaceMax.ValueChanged += new System.EventHandler(this.numericUpDown5_ValueChanged);
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.label7);
            this.panel7.Controls.Add(this.listBox1);
            this.panel7.Location = new System.Drawing.Point(12, 210);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(691, 318);
            this.panel7.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(256, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Очередь к центральному процессору";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(3, 23);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(687, 292);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.listBox3);
            this.panel8.Controls.Add(this.label8);
            this.panel8.Controls.Add(this.listBox2);
            this.panel8.Location = new System.Drawing.Point(709, 210);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(702, 318);
            this.panel8.TabIndex = 10;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 16;
            this.listBox3.Location = new System.Drawing.Point(0, 167);
            this.listBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(703, 148);
            this.listBox3.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 2);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(227, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Очередь к внешним устройствам";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(0, 23);
            this.listBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(705, 132);
            this.listBox2.TabIndex = 0;
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.OccupiedSize);
            this.panel9.Controls.Add(this.label11);
            this.panel9.Controls.Add(this.FreeSize);
            this.panel9.Controls.Add(this.label9);
            this.panel9.Location = new System.Drawing.Point(223, 535);
            this.panel9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(869, 57);
            this.panel9.TabIndex = 11;
            // 
            // OccupiedSize
            // 
            this.OccupiedSize.AutoSize = true;
            this.OccupiedSize.Location = new System.Drawing.Point(776, 26);
            this.OccupiedSize.Name = "OccupiedSize";
            this.OccupiedSize.Size = new System.Drawing.Size(16, 17);
            this.OccupiedSize.TabIndex = 3;
            this.OccupiedSize.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(487, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(262, 17);
            this.label11.TabIndex = 2;
            this.label11.Text = "Размер памяти, занятой процессами: ";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FreeSize
            // 
            this.FreeSize.AutoSize = true;
            this.FreeSize.Location = new System.Drawing.Point(220, 26);
            this.FreeSize.Name = "FreeSize";
            this.FreeSize.Size = new System.Drawing.Size(16, 17);
            this.FreeSize.TabIndex = 1;
            this.FreeSize.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(187, 34);
            this.label9.TabIndex = 0;
            this.label9.Text = "Оперативная память\r\nРазмер свободной памяти:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label9.Click += new System.EventHandler(this.label9_Click_1);
            // 
            // panel10
            // 
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Controls.Add(this.label17);
            this.panel10.Controls.Add(this.label13);
            this.panel10.Location = new System.Drawing.Point(12, 113);
            this.panel10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(691, 46);
            this.panel10.TabIndex = 12;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3, 17);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(0, 17);
            this.label17.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(-3, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(173, 17);
            this.label13.TabIndex = 0;
            this.label13.Text = "Центральный процессор";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.label14);
            this.flowLayoutPanel1.Controls.Add(this.lblDevice_1);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(709, 113);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(697, 46);
            this.flowLayoutPanel1.TabIndex = 13;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(172, 17);
            this.label14.TabIndex = 0;
            this.label14.Text = "Внешнее устройство №1";
            // 
            // lblDevice_1
            // 
            this.lblDevice_1.AutoSize = true;
            this.lblDevice_1.Location = new System.Drawing.Point(3, 17);
            this.lblDevice_1.Name = "lblDevice_1";
            this.lblDevice_1.Size = new System.Drawing.Size(0, 17);
            this.lblDevice_1.TabIndex = 1;
            // 
            // panel11
            // 
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel11.Controls.Add(this.rbManual);
            this.panel11.Controls.Add(this.label15);
            this.panel11.Controls.Add(this.rbAuto);
            this.panel11.Location = new System.Drawing.Point(227, 609);
            this.panel11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(443, 66);
            this.panel11.TabIndex = 14;
            // 
            // rbManual
            // 
            this.rbManual.AutoSize = true;
            this.rbManual.Checked = true;
            this.rbManual.Location = new System.Drawing.Point(156, 22);
            this.rbManual.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbManual.Name = "rbManual";
            this.rbManual.Size = new System.Drawing.Size(77, 21);
            this.rbManual.TabIndex = 3;
            this.rbManual.TabStop = true;
            this.rbManual.Text = "Ручной";
            this.rbManual.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(24, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 21);
            this.label15.TabIndex = 0;
            this.label15.Text = "Режим роботы";
            // 
            // rbAuto
            // 
            this.rbAuto.AutoSize = true;
            this.rbAuto.Location = new System.Drawing.Point(276, 22);
            this.rbAuto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbAuto.Name = "rbAuto";
            this.rbAuto.Size = new System.Drawing.Size(138, 21);
            this.rbAuto.TabIndex = 1;
            this.rbAuto.Text = "Автоматический";
            this.rbAuto.UseVisualStyleBackColor = true;
            this.rbAuto.CheckedChanged += new System.EventHandler(this.rbAutomatic_CheckedChanged);
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSave.Location = new System.Drawing.Point(697, 609);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(107, 66);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Сохранение \r\nнастроек";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnWork
            // 
            this.btnWork.Location = new System.Drawing.Point(841, 609);
            this.btnWork.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnWork.Name = "btnWork";
            this.btnWork.Size = new System.Drawing.Size(107, 66);
            this.btnWork.TabIndex = 16;
            this.btnWork.Text = "Рабочий такт";
            this.btnWork.UseVisualStyleBackColor = true;
            this.btnWork.Click += new System.EventHandler(this.btnWork_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(985, 609);
            this.btnEnd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(107, 66);
            this.btnEnd.TabIndex = 17;
            this.btnEnd.Text = "Завершение \r\nсеанса";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnSessionEnd_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(169, 633);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(16, 17);
            this.lblTime.TabIndex = 19;
            this.lblTime.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Interval = 1500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel12
            // 
            this.panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel12.Controls.Add(this.nudPriority);
            this.panel12.Controls.Add(this.label10);
            this.panel12.Location = new System.Drawing.Point(605, 15);
            this.panel12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(162, 92);
            this.panel12.TabIndex = 20;
            // 
            // nudPriority
            // 
            this.nudPriority.Location = new System.Drawing.Point(-1, 66);
            this.nudPriority.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudPriority.Name = "nudPriority";
            this.nudPriority.Size = new System.Drawing.Size(163, 22);
            this.nudPriority.TabIndex = 22;
            this.nudPriority.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(153, 34);
            this.label10.TabIndex = 21;
            this.label10.Text = "Максимальное \r\nзначение приоритета\r\n";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel13
            // 
            this.panel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel13.Controls.Add(this.lblDevice_2);
            this.panel13.Controls.Add(this.label12);
            this.panel13.Location = new System.Drawing.Point(709, 166);
            this.panel13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(693, 44);
            this.panel13.TabIndex = 21;
            // 
            // lblDevice_2
            // 
            this.lblDevice_2.AutoSize = true;
            this.lblDevice_2.Location = new System.Drawing.Point(3, 17);
            this.lblDevice_2.Name = "lblDevice_2";
            this.lblDevice_2.Size = new System.Drawing.Size(0, 17);
            this.lblDevice_2.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(172, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "Внешнее устройство №2";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 633);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(124, 17);
            this.label16.TabIndex = 2;
            this.label16.Text = "Системное время";
            // 
            // panel14
            // 
            this.panel14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel14.Controls.Add(this.lblCPULoad);
            this.panel14.Controls.Add(this.CPULoad);
            this.panel14.Location = new System.Drawing.Point(1108, 535);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(198, 56);
            this.panel14.TabIndex = 22;
            // 
            // lblCPULoad
            // 
            this.lblCPULoad.AutoSize = true;
            this.lblCPULoad.Location = new System.Drawing.Point(3, 6);
            this.lblCPULoad.Name = "lblCPULoad";
            this.lblCPULoad.Size = new System.Drawing.Size(189, 17);
            this.lblCPULoad.TabIndex = 1;
            this.lblCPULoad.Text = "Загруженность процессора";
            // 
            // CPULoad
            // 
            this.CPULoad.AutoSize = true;
            this.CPULoad.Location = new System.Drawing.Point(14, 30);
            this.CPULoad.Name = "CPULoad";
            this.CPULoad.Size = new System.Drawing.Size(0, 17);
            this.CPULoad.TabIndex = 0;
            // 
            // panel15
            // 
            this.panel15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel15.Controls.Add(this.Perfomance);
            this.panel15.Controls.Add(this.lblPerfomance);
            this.panel15.Location = new System.Drawing.Point(1108, 609);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(198, 61);
            this.panel15.TabIndex = 23;
            // 
            // Perfomance
            // 
            this.Perfomance.AutoSize = true;
            this.Perfomance.Location = new System.Drawing.Point(11, 27);
            this.Perfomance.Name = "Perfomance";
            this.Perfomance.Size = new System.Drawing.Size(0, 17);
            this.Perfomance.TabIndex = 1;
            // 
            // lblPerfomance
            // 
            this.lblPerfomance.AutoSize = true;
            this.lblPerfomance.Location = new System.Drawing.Point(3, 10);
            this.lblPerfomance.Name = "lblPerfomance";
            this.lblPerfomance.Size = new System.Drawing.Size(147, 17);
            this.lblPerfomance.TabIndex = 0;
            this.lblPerfomance.Text = "Производительность";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1413, 686);
            this.Controls.Add(this.panel15);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnWork);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudIntensity)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBurstMin)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBurstMax)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddrSpaceMin)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddrSpaceMax)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPriority)).EndInit();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label16;

        private void label7_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            // throw new NotImplementedException();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void label9_Click_1(object sender, EventArgs e)
        {
            // throw new NotImplementedException();
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Diagnostics.Process process1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        public System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.RadioButton rbAuto;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RadioButton rbManual;
        public System.Windows.Forms.NumericUpDown nudIntensity;
        public System.Windows.Forms.NumericUpDown nudBurstMin;
        public System.Windows.Forms.NumericUpDown nudBurstMax;
        public System.Windows.Forms.NumericUpDown nudAddrSpaceMax;
        public System.Windows.Forms.NumericUpDown nudAddrSpaceMin;
        public System.Windows.Forms.ComboBox cbRamSize;
        public System.Windows.Forms.ListBox listBox2;
        public System.Windows.Forms.Label OccupiedSize;
        public System.Windows.Forms.Label FreeSize;
        public Label label17;
        public Label lblDevice_1;
        public System.Windows.Forms.Label lblTime;
        public System.Windows.Forms.Button btnWork;
        public System.Windows.Forms.Button btnEnd;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel13;
        public Label label12;
        public System.Windows.Forms.ListBox listBox3;
        public Label lblDevice_2;
        public System.Windows.Forms.NumericUpDown nudPriority;
        private Panel panel15;
        private Label lblPerfomance;
        private Panel panel14;
        private Label lblCPULoad;
        public Label CPULoad;
        public Label Perfomance;
    }

}