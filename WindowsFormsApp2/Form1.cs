﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public string[] stringArray = new string[5];
        public int cnt = 0;
        


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            stringArray[cnt]=textBox1.Text;
            Debug.WriteLine(stringArray[cnt]);
            cnt++;
            textBox1.Text = "";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for(int i = 0; i<5; i++)
            {
                listBox1.Items.Add(stringArray[i]);
            }
        }
    }
}
