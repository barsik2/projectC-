using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); // выход из приложения
        }


        int firstNumber = 0, lastNumber = 0;
        private void btnCount_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToInt32(txtStartForm.Text);
            lastNumber = Convert.ToInt32(txtTo.Text);

        }
    }
}
