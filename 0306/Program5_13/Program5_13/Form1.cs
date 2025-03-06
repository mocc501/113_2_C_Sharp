﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace Program5_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            StreamWriter outputFile;
            int count;

            try
            {
                outputFile = File.CreateText("number.txt");
                if (int.TryParse(textBox1.Text, out count))
                {
                    for (int i = 0; i < count; i++)
                    {
                        outputFile.WriteLine(rand.Next(100) + 1);
                    }
                    outputFile.Close();
                    MessageBox.Show("檔案已成立");
                }
                else
                {
                    MessageBox.Show("請輸入數字");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
