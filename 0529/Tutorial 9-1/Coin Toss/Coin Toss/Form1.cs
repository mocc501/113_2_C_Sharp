﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coin_Toss
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tossButton_Click(object sender, EventArgs e)
        {
            Coin myCoin = new Coin();
            outputListBox.Items.Clear();

            for (int i = 0; i < 5; i++)
            { 
                myCoin.Toss();
                outputListBox.Items.Add(myCoin.GetSideUp());
            }

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單，結束應用程式的執行。
            this.Close();
        }
    }
}
