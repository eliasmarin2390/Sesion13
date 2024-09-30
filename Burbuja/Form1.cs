﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Burbuja
{
    public partial class Form1 : Form
    {
        int[] numbers = new int[10];
        int i = 0;

        public MetBurbuja Metburbuja { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int number = int.Parse(tbNumbers.Text);
            numbers[i++] = number;
            showNumbers();
        }
        private void showNumbers()
        {
            if (numbers.Length > 0)
            {
                lbNumbers.Items.Clesar();
            }
            for(int i =0;  i < numbers.Length; i++)
            {
                lbNumbers.Items.Add(numbers[i]);
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            Metburbuja = new MetBurbuja ();
            burbuja.OrdenarBurbuja(numbers);
            showNumbers();
        }
    }
}

