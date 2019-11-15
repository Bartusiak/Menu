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
        String tempFood = "";

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
            Debug.WriteLine("Button3_Clicked: Chicken soup ordered: ");
            totality = Int32.Parse(totalityTextBox.Text);
            totality = totality + 10;
            Debug.WriteLine("Button3_Clicked: Adding totality value to the totalityTextBox - " + totality);
            totalityTextBox.Text = totality.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Button7_Clicked: Fish with chips ordered: ");
            totality = Int32.Parse(totalityTextBox.Text);
            totality = totality + 28;
            Debug.WriteLine("Button7_Clicked: Adding totality value to the totalityTextBox - " + totality);
            totalityTextBox.Text = totality.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Button8_Clicked: Hungarian cake ordered: ");
            totality = Int32.Parse(totalityTextBox.Text);
            totality = totality + 27;
            Debug.WriteLine("Button8_Clicked: Adding totality value to the totalityTextBox - " + totality);
            totalityTextBox.Text = totality.ToString();
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
            Debug.WriteLine("Button15_Clicked: Locking the comment");
            commentTextBox.Enabled = false;
            String comment = "";
            comment = commentTextBox.Text;
            Debug.WriteLine("Button15_Clicked: Comment added - " + comment);
        }

        private void button14_Click(object sender, EventArgs e)
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

        private void schnitzelChipsBtn_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("SchnitzelChipsBtn_Clicked: Schnitzel with Chips ordered: ");
            totality = Int32.Parse(totalityTextBox.Text);
            totality = totality + 30;
            Debug.WriteLine("Button3_Clicked: Adding totality value to the totalityTextBox - " + totality);
            totalityTextBox.Text = totality.ToString();
        }

        private void schnitzelRiceBtn_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("SchnitzelRice_Clicked: Schnitzel with Rice ordered: ");
            totality = Int32.Parse(totalityTextBox.Text);
            totality = totality + 30;
            Debug.WriteLine("Button3_Clicked: Adding totality value to the totalityTextBox - " + totality);
            totalityTextBox.Text = totality.ToString();
        }

        private void schnitzelPotatoBtn_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("SchnitzelPotato_Clicked: Schnitzel with Potatoes ordered: ");
            totality = Int32.Parse(totalityTextBox.Text);
            totality = totality + 30;
            Debug.WriteLine("SchnitzelPotato_Clicked: Adding totality value to the totalityTextBox - " + totality);
            totalityTextBox.Text = totality.ToString();
        }

        private void saladBtn_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("SaladBtn_Clicked: Salad bar ordered: ");
            totality = Int32.Parse(totalityTextBox.Text);
            totality = totality + 5;
            Debug.WriteLine("SaladBtn_Clicked: Adding totality value to the totalityTextBox - " + totality);
            totalityTextBox.Text = totality.ToString();
        }

        private void saucesBtn_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("SaucesBtn_Clicked: A set of sauces ordered: ");
            totality = Int32.Parse(totalityTextBox.Text);
            totality = totality + 6;
            Debug.WriteLine("SaucesBtn_Clicked: Adding totality value to the totalityTextBox - " + totality);
            totalityTextBox.Text = totality.ToString();
        }

        private void tomatoBtn_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("TomatoBtn_Clicked: Tomato soup ordered: ");
            totality = Int32.Parse(totalityTextBox.Text);
            totality = totality + 12;
            Debug.WriteLine("TomatoBtn_Clicked: Adding totality value to the totalityTextBox - " + totality);
            totalityTextBox.Text = totality.ToString();
        }

        private void coffeeBtn_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("CoffeeBtn_Clicked: Coffee ordered: ");
            totality = Int32.Parse(totalityTextBox.Text);
            totality = totality + 5;
            Debug.WriteLine("CoffeeBtn_Clicked: Adding totality value to the totalityTextBox - " + totality);
            totalityTextBox.Text = totality.ToString();
        }

        private void teaBtn_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("TeaBtn_Clicked: Tea ordered: ");
            totality = Int32.Parse(totalityTextBox.Text);
            totality = totality + 5;
            Debug.WriteLine("TeaBtn_Clicked: Adding totality value to the totalityTextBox - " + totality);
            totalityTextBox.Text = totality.ToString();
        }

        private void colaBtn_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("ColaBtn_Clicked: Cola ordered: ");
            totality = Int32.Parse(totalityTextBox.Text);
            totality = totality + 5;
            Debug.WriteLine("Button3_Clicked: Adding totality value to the totalityTextBox - " + totality);
            totalityTextBox.Text = totality.ToString();
        }
    }
}
