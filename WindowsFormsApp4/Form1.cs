using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        int totality = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Menu_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            totality = Int32.Parse(totalityTextBox.Text);
            String tempPizzaString = "";
            RadioButton radioBtn = this.Controls.OfType<RadioButton>().Where(x => x.Checked).FirstOrDefault();
            if (radioBtn != null)
            {
                Debug.WriteLine("Button1_Click: Starting do switch");
                switch (radioBtn.Name)
                {
                    case "margherittaRadioBtn":
                        //   Debug.Write("Margheritta ");
                        tempPizzaString = "Margheritta ";
                        Debug.WriteLine("Switch: Add to totality pizza price - 20");
                        totality = totality + 20;
                        break;
                    case "vegetarianaRadioBtn":
                        ///   Debug.Write("Vegetariana");
                        tempPizzaString = "Vegetariana ";
                        Debug.WriteLine("Switch: Add to totality pizza price - 22");
                        totality = totality + 22;
                        break;
                    case "toscaRadioBtn":
                        //  Debug.Write("Tosca");
                        tempPizzaString = "Tosca ";
                        Debug.WriteLine("Switch: Add to totality pizza price - 25");
                        totality = totality + 25;
                        break;
                    case "veneciaRadioBtn":
                        //   Debug.Write("Venecia");
                        tempPizzaString = "Venecia ";
                        Debug.WriteLine("Switch Add to totality pizza price - 25");
                        totality= totality + 25;
                        break;
                }
            }
            Debug.WriteLine("Button1_Click: Starting do foreach");
            foreach (CheckBox checkBox in groupBox1.Controls)
            {
                if (checkBox.Checked)
                {
                    // Debug.Write(", " +checkBox.Text);
                    tempPizzaString = tempPizzaString + " + " + checkBox.Text;
                    Debug.WriteLine("Foreach: Add to totality addon price - 2");
                    totality = totality + 2;
                }
            }
            Debug.WriteLine("Button1_Clicked: Pizza ordered: " + tempPizzaString);
            Debug.WriteLine("Button1_Clicked: Adding totality value to the totalityTextBox - " + totality);
            totalityTextBox.Text = totality.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cheeseBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void margherittaRadioBtn_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
