using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2(List<string> history)
        {
            InitializeComponent();

            foreach (string calculation in history)
            {
                listBox1.Items.Add(calculation);
            }
        }
    }
}
