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
using System.Data.SqlClient;
using System.Collections;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        ArrayList idOrderFood = new ArrayList();
        ArrayList amountFood = new ArrayList();
        String query;
        SqlCommand myCommand = new SqlCommand();
        SqlConnection connection = new SqlConnection(@"Data Source=PUSSYROAD\SQLSERVER;Initial Catalog=Restaurant;User ID=sa;password=restauracja");
        int totality = 0;
        int amount = 0;

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
                        //connection.Open();
                        tempPizzaString = "Margheritta ";
                        Debug.WriteLine("Switch: Add to totality pizza price - 20");
                        totality = totality + 20;
                        idOrderFood.Add(1);
                        amountFood.Add(1);
                        billBox.Items.Add(tempPizzaString + "           20zł");
                        //String query = "INSERT INTO dbo.order_details (IdOrder,IdFood,Amount,PriceFood"
                        break;
                    case "vegetarianaRadioBtn":
                        ///   Debug.Write("Vegetariana");
                        tempPizzaString = "Vegetariana ";
                        Debug.WriteLine("Switch: Add to totality pizza price - 22");
                        totality = totality + 22;
                        idOrderFood.Add(2);
                        amountFood.Add(1);
                        billBox.Items.Add(tempPizzaString + "           22zł");
                        break;
                    case "toscaRadioBtn":
                        //  Debug.Write("Tosca");
                        tempPizzaString = "Tosca ";
                        Debug.WriteLine("Switch: Add to totality pizza price - 25");
                        totality = totality + 25;
                        idOrderFood.Add(3);
                        amountFood.Add(1);
                        billBox.Items.Add(tempPizzaString + "           25zł");
                        break;
                    case "veneciaRadioBtn":
                        //   Debug.Write("Venecia");
                        tempPizzaString = "Venecia ";
                        Debug.WriteLine("Switch Add to totality pizza price - 25");
                        totality = totality + 25;
                        idOrderFood.Add(4);
                        amountFood.Add(1);
                        billBox.Items.Add(tempPizzaString + "           25zł");
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
                    switch (checkBox.Text)
                    {
                        case "Double chesse":
                            idOrderFood.Add(5);
                            amountFood.Add(1);
                            billBox.Items.Add(checkBox.Text + "         2zł");
                            break;
                        case "Salami":
                            idOrderFood.Add(6);
                            amountFood.Add(1);
                            billBox.Items.Add(checkBox.Text + "         2zł");
                            break;
                        case "Ham":
                            idOrderFood.Add(7);
                            amountFood.Add(1);
                            billBox.Items.Add(checkBox.Text + "         2zł");
                            break;
                        case "Mushrooms":
                            idOrderFood.Add(8);
                            amountFood.Add(1);
                            billBox.Items.Add(checkBox.Text + "         2zł");
                            break;
                    }
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
            amount = Convert.ToInt32(numericUpDownChickenSoup.Value);
            totality = Int32.Parse(totalityTextBox.Text);
            totality = totality + (amount * 10);
            Debug.WriteLine("Button3_Clicked: Adding totality value to the totalityTextBox - " + totality);
            totalityTextBox.Text = totality.ToString();
            idOrderFood.Add(10);
            amountFood.Add(amount);
            billBox.Items.Add("Chicken Soup             " + amount + "x" + 10);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Button7_Clicked: Fish with chips ordered: ");
            amount = Convert.ToInt32(numericUpDownFishChips.Value);
            totality = Int32.Parse(totalityTextBox.Text);
            totality = totality + (amount * 28);
            Debug.WriteLine("Button7_Clicked: Adding totality value to the totalityTextBox - " + totality);
            totalityTextBox.Text = totality.ToString();
            idOrderFood.Add(14);
            amountFood.Add(amount);
            billBox.Items.Add("Fish with chips          " + amount + "x" + 28);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Button8_Clicked: Hungarian cake ordered: ");
            amount = Convert.ToInt32(numericUpDownCake.Value);
            totality = Int32.Parse(totalityTextBox.Text);
            totality = totality + (amount * 27);
            Debug.WriteLine("Button8_Clicked: Adding totality value to the totalityTextBox - " + totality);
            totalityTextBox.Text = totality.ToString();
            idOrderFood.Add(15);
            amountFood.Add(amount);
            billBox.Items.Add("Hungarian Cake           " + amount + "x" + 27);
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
            /*Debug.WriteLine("Button15_Clicked: Locking the comment");
            commentTextBox.Enabled = false;
            String comment = "";
            comment = commentTextBox.Text;
            Debug.WriteLine("Button15_Clicked: Comment added - " + comment);*/
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
                string billToSend = "";
                foreach(var item in billBox.Items)
                {
                    billToSend += item.ToString() + "\n";
                }
                MailMessage message = new MailMessage("yourrestaurantemail@gmail.com", emailTextBox.Text, "Your order from restaurant", "Ordered: " + "\n" + billToSend + "\n" + "Do zapłaty: " + totalityTextBox.Text + "\n" + "Komentarz: " + "\n" + commentTextBox.Text);
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com ", 587);
                smtpClient.Credentials = new System.Net.NetworkCredential("yourrestaurantemail@gmail.com", "writeyourpassword");
                smtpClient.EnableSsl = true;
                Debug.WriteLine("SmtpClient: Mail is sending to: " + emailTextBox.Text);
                try
                {
                    smtpClient.Send(message);
                
                    MessageBox.Show("Message sent successfully", "Success!", MessageBoxButtons.OK);
                    Debug.WriteLine("SmtpClient: Mail sent");
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("SmtpClient: Exception message: " + ex.Message);
                }
                connection.Open();
                query = "BEGIN IF NOT EXISTS (SELECT Email FROM dbo.clients WHERE Email = '" + emailTextBox.Text + "')" + " BEGIN INSERT INTO clients (Email) VALUES ('" + emailTextBox.Text + "') END END ";
                myCommand = new SqlCommand(query, connection);
                myCommand.ExecuteNonQuery();
                query = "SELECT MAX(IdOrder) FROM order_details ;";
                myCommand = new SqlCommand(query, connection);
                int idOrder = (int)myCommand.ExecuteScalar() + 1;
                if (idOrder == -1)
                {
                    idOrder = 1;
                }
                Debug.WriteLine("Button14_Click: Check length two arraylist ");
                var numberOfList = idOrderFood.Count;
                if (numberOfList == amountFood.Count)
                {
                    Debug.WriteLine("Button14_Click: Open connection of database");

                    Debug.WriteLine("Button14_Click: Starting foreach");
                    for (int i = 0; i <numberOfList; i++)
                    {
                        int foodprice = 0;
                        SqlCommand myCommand = new SqlCommand();
                        query = "SELECT PriceFood FROM dbo.foods WHERE IdFood=" + idOrderFood[i];
                        Debug.WriteLine("Button14_Click FOR: idOrderFood[i] before execute myCommand2 " + idOrderFood[i]);
                        SqlCommand myCommand2 = new SqlCommand(query, connection);
                        foodprice = (int)myCommand2.ExecuteScalar();
                        Debug.WriteLine("Button14_Click FOR EmailTextBox: " + emailTextBox.Text);
                        query = "SELECT IdClient FROM clients WHERE Email='" + emailTextBox.Text + "'";
                        SqlCommand myCommand3 = new SqlCommand(query, connection);
                        int idClient = (int)myCommand3.ExecuteScalar();
                        Debug.WriteLine("Button14_Click FOR: Id client: " + idClient);
                        query = "INSERT INTO dbo.order_details(IdFood,IdClient,Amount,PriceFood,Comments,IdOrder) VALUES (@IdFood,@IdClient,@Amount,@PriceFood,@Comments,@IdOrder)";
                        myCommand = new SqlCommand(query, connection);
                        Debug.WriteLine("Button14_Click FOR: Execute myCommand idOrderFood" + idOrderFood[i]);
                        myCommand.Parameters.AddWithValue("@IdFood", idOrderFood[i]);
                        Debug.WriteLine("Button14_Click FOR: Execute myCommand idClient" + idClient);
                        myCommand.Parameters.AddWithValue("@IdClient", idClient);
                        Debug.WriteLine("Button14_Click FOR: Execute myCommand amountFood" + amountFood[i]);
                        myCommand.Parameters.AddWithValue("@Amount", amountFood[i]);
                        Debug.WriteLine("Button14_Click FOR: PriceFood: " + foodprice * Convert.ToInt32(amountFood[i]));
                        myCommand.Parameters.AddWithValue("@PriceFood", foodprice * Convert.ToInt32(amountFood[i]));
                        myCommand.Parameters.AddWithValue("@Comments", commentTextBox.Text);
                        Debug.WriteLine("Button14_Click FOR: Execute myCommand " + idOrder);
                        myCommand.Parameters.AddWithValue("@IdOrder", idOrder);
                        myCommand.ExecuteNonQuery();
                    }
                    amountFood.Clear();
                    idOrderFood.Clear();
                    numericUpDownCake.ResetText();
                    numericUpDownChickenSoup.ResetText();
                    numericUpDownCoffee.ResetText();
                    numericUpDownCola.ResetText();
                    numericUpDownFishChips.ResetText();
                    numericUpDownSalad.ResetText();
                    numericUpDownSauces.ResetText();
                    numericUpDownSchnitzelChip.ResetText();
                    numericUpDownSchnitzelPotatoes.ResetText();
                    numericUpDownSchnitzelRice.ResetText();
                    numericUpDownTea.ResetText();
                    numericUpDownTomatoSoup.ResetText();
                    foreach (CheckBox checkBox in groupBox1.Controls)
                    {
                        checkBox.Checked = false;
                    }
                    totalityTextBox.Text = "0";
                    billBox.Items.Clear();
                    emailTextBox.Text = "Email:";
                    commentTextBox.Text = "";
                }
                connection.Close();

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
            amount = Convert.ToInt32(numericUpDownSchnitzelChip.Value);
            totality = Int32.Parse(totalityTextBox.Text);
            totality = totality + (amount * 30);
            Debug.WriteLine("Button3_Clicked: Adding totality value to the totalityTextBox - " + totality);
            totalityTextBox.Text = totality.ToString();
            idOrderFood.Add(11);
            amountFood.Add(amount);
            billBox.Items.Add("Schnitzel with Chips             " + amount + "x" + 30);
        }

        private void schnitzelRiceBtn_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("SchnitzelRice_Clicked: Schnitzel with Rice ordered: ");
            amount = Convert.ToInt32(numericUpDownSchnitzelRice.Value);
            totality = Int32.Parse(totalityTextBox.Text);
            totality = totality + (amount * 30);
            Debug.WriteLine("Button3_Clicked: Adding totality value to the totalityTextBox - " + totality);
            totalityTextBox.Text = totality.ToString();
            idOrderFood.Add(12);
            amountFood.Add(amount);
            billBox.Items.Add("Schnitzel with Rice              " + amount + "x" + 30);
        }

        private void schnitzelPotatoBtn_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("SchnitzelPotato_Clicked: Schnitzel with Potatoes ordered: ");
            amount = Convert.ToInt32(numericUpDownSchnitzelPotatoes.Value);
            totality = Int32.Parse(totalityTextBox.Text);
            totality = totality + (amount * 30);
            Debug.WriteLine("SchnitzelPotato_Clicked: Adding totality value to the totalityTextBox - " + totality);
            totalityTextBox.Text = totality.ToString();
            idOrderFood.Add(13);
            amountFood.Add(amount);
            billBox.Items.Add("Chicken Soup             " + amount + "x" + 30);
        }

        private void saladBtn_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("SaladBtn_Clicked: Salad bar ordered: ");
            amount = Convert.ToInt32(numericUpDownSalad.Value);
            totality = Int32.Parse(totalityTextBox.Text);
            totality = totality + (amount * 5);
            Debug.WriteLine("SaladBtn_Clicked: Adding totality value to the totalityTextBox - " + totality);
            totalityTextBox.Text = totality.ToString();
            idOrderFood.Add(16);
            amountFood.Add(amount);
            billBox.Items.Add("Salad bar            " + amount + "x" + 5);
        }

        private void saucesBtn_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("SaucesBtn_Clicked: A set of sauces ordered: ");
            amount = Convert.ToInt32(numericUpDownSauces.Value);
            totality = Int32.Parse(totalityTextBox.Text);
            totality = totality + (amount * 6);
            Debug.WriteLine("SaucesBtn_Clicked: Adding totality value to the totalityTextBox - " + totality);
            totalityTextBox.Text = totality.ToString();
            idOrderFood.Add(17);
            amountFood.Add(amount);
            billBox.Items.Add("A set of sauces          " + amount + "x" + 6);
        }

        private void tomatoBtn_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("TomatoBtn_Clicked: Tomato soup ordered: ");
            amount = Convert.ToInt32(numericUpDownTomatoSoup.Value);
            totality = Int32.Parse(totalityTextBox.Text);
            totality = totality + (amount * 12);
            Debug.WriteLine("TomatoBtn_Clicked: Adding totality value to the totalityTextBox - " + totality);
            totalityTextBox.Text = totality.ToString();
            idOrderFood.Add(9);
            amountFood.Add(amount);
            billBox.Items.Add("Tomato Soup          " + amount + "x" + 12);
        }

        private void coffeeBtn_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("CoffeeBtn_Clicked: Coffee ordered: ");
            amount = Convert.ToInt32(numericUpDownCoffee.Value);
            totality = Int32.Parse(totalityTextBox.Text);
            totality = totality + (amount * 5);
            Debug.WriteLine("CoffeeBtn_Clicked: Adding totality value to the totalityTextBox - " + totality);
            totalityTextBox.Text = totality.ToString();
            idOrderFood.Add(18);
            amountFood.Add(amount);
            billBox.Items.Add("Coffee           " + amount + "x" + 5);
        }

        private void teaBtn_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("TeaBtn_Clicked: Tea ordered: ");
            amount = Convert.ToInt32(numericUpDownTea.Value);
            totality = Int32.Parse(totalityTextBox.Text);
            totality = totality + (amount * 5);
            Debug.WriteLine("TeaBtn_Clicked: Adding totality value to the totalityTextBox - " + totality);
            totalityTextBox.Text = totality.ToString();
            idOrderFood.Add(19);
            amountFood.Add(amount);
            billBox.Items.Add("Tea          " + amount + "x" + 5);
        }

        private void colaBtn_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("ColaBtn_Clicked: Cola ordered: ");
            amount = Convert.ToInt32(numericUpDownCola.Value);
            totality = Int32.Parse(totalityTextBox.Text);
            totality = totality + (amount * 5);
            Debug.WriteLine("Button3_Clicked: Adding totality value to the totalityTextBox - " + totality);
            totalityTextBox.Text = totality.ToString();
            idOrderFood.Add(20);
            amountFood.Add(amount);
            billBox.Items.Add("Cola             " + amount + "x" + 5);
        }

        private void menuBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'restaurantDataSet.order_details' . Możesz go przenieść lub usunąć.
            //this.order_detailsTableAdapter.Fill(this.restaurantDataSet.order_details);

        }

        private void emailTextBox_Enter(object sender, EventArgs e)
        {
            if (emailTextBox.Text == "Email:")
            {
                emailTextBox.Text = "";
            }
        }
    }
}
