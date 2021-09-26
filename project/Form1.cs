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

        int devisibleTern = 1;
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

        private void cmbDevisibleTern_SelectedIndexChanged(object sender, EventArgs e)
        {
            devisibleTern = Convert.ToInt32(cmbDevisibleTern.SelectedItem);
        }


        int controlNumber = 1;
        string devisibleNumber = "";
        string preduprejdenie = "Please fill the neccessary field";
        private void btnCount_Click(object sender, EventArgs e)
        {
            //string preduprejdenie = "Please fill the neccessary field";
            if (txtStartForm.Text.Trim() == "" || txtTo.Text.Trim() == "")
            {
                string preduprejdenie = "Error! Please enter correct values";
                string messagetitle = "Error";

                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(preduprejdenie, messagetitle, buttons, MessageBoxIcon.Error);
                
            }
            else if(cmbDevisibleTern.SelectedIndex == -1)
            {
                string preduprejdenie2 = "Error! Please enter correct devisible tern values";
                string messagetitle2 = "Error";

                MessageBoxButtons buttons2 = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(preduprejdenie2, messagetitle2, buttons2, MessageBoxIcon.Error);
            }
            else
            {

                firstNumber = Convert.ToInt32(txtStartForm.Text);
                lastNumber = Convert.ToInt32(txtTo.Text);

                //MessageBox.Show("Devisible " + devisibleTern + " From " + firstNumber + " To " + lastNumber);
                for (int i = firstNumber; i < lastNumber; i++)
                {
                    if (i % devisibleTern == 0)
                        devisibleNumber += i.ToString() + " ";
                    if (controlNumber % 10 == 0)
                        devisibleNumber += Environment.NewLine;
                    controlNumber++;
                }
                txtDevisibleNumbers.Text = devisibleNumber;
            }

        }
    }
}
