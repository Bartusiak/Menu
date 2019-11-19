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
using System.Text.RegularExpressions;
using System.Net.Mail;

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
            Debug.WriteLine("Button14_Click: Clicked submit, declaring pattern to check email. ");
            String pattern2 = @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$";
            Regex email = new Regex(pattern2);
            Match match = email.Match(emailTextBox.Text);
            if (match.Success)
            {
                Debug.WriteLine("Button14_Click: Match success. ");
                Debug.WriteLine("Button14_Click: Trying to send mail with the bill ");
                // We need free smtp server to send mail without using password
                MailMessage message = new MailMessage("mailofrestaurant@domain.com", emailTextBox.Text, "Your order from restaurant", "Here we want to put the bill later");
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com ",587);
                smtpClient.Credentials = new System.Net.NetworkCredential("mailofrestaurant@domain.com", "passwordemail");
                smtpClient.EnableSsl = true;
                Debug.WriteLine("SmtpClient: Mail is sending to: " + emailTextBox.Text);
                try
                {
                    smtpClient.Send(message);
                    Debug.WriteLine("SmtpClient: Mail sent");
                }catch(Exception ex)
                {
                    Debug.WriteLine("SmtpClient: Exception message: " + ex.Message);
                }
                
                
            }
            else
            {
                MessageBox.Show("You writed incorrect email");
            }
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

        private void menuBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'restaurantDataSet.order_details' . Możesz go przenieść lub usunąć.
            this.order_detailsTableAdapter.Fill(this.restaurantDataSet.order_details);

        }
    }
}
