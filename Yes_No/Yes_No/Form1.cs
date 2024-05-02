using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yes_No
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random x = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            double p = x.NextDouble();

            if (p < 0.5) Answer.Text = "Нет";
            else Answer.Text = "Да";
            Answer.Visible = true;
        }
    }
}
