using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace colour
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBox1.Text)
            {
                case "pembe": 
                    this.BackColor = Color.Pink;
                    break;
                case "mavi":
                    this.BackColor = Color.Blue;
                    break;
                case "kırmızı":
                    this.BackColor = Color.Red;
                    break;
                case "sarı":
                    this.BackColor = Color.Yellow;
                    break;
                case "yeşil":
                    this.BackColor = Color.Green;
                    break;
                case "mor":
                    this.BackColor = Color.Purple;
                    break;
                case "turuncu":
                    this.BackColor = Color.Orange;
                    break;
                   
            }


        }
    }
}
