﻿namespace WindowsFormsApp4
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Menu = new System.Windows.Forms.Label();
            this.margherittaRadioBtn = new System.Windows.Forms.RadioButton();
            this.vegetarianaRadioBtn = new System.Windows.Forms.RadioButton();
            this.toscaRadioBtn = new System.Windows.Forms.RadioButton();
            this.veneciaRadioBtn = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cheeseBox = new System.Windows.Forms.CheckBox();
            this.salamiBox = new System.Windows.Forms.CheckBox();
            this.hamBox = new System.Windows.Forms.CheckBox();
            this.mushroomsBox = new System.Windows.Forms.CheckBox();
            this.addPizzaBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tomatoBtn = new System.Windows.Forms.Button();
            this.chickenBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.schnitzelChipsBtn = new System.Windows.Forms.Button();
            this.schnitzelRiceBtn = new System.Windows.Forms.Button();
            this.schnitzelPotatoBtn = new System.Windows.Forms.Button();
            this.fishBtn = new System.Windows.Forms.Button();
            this.cakeBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.saladBtn = new System.Windows.Forms.Button();
            this.saucesBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.coffeeBtn = new System.Windows.Forms.Button();
            this.teaBtn = new System.Windows.Forms.Button();
            this.colaBtn = new System.Windows.Forms.Button();
            this.commentTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.totalityTextBox = new System.Windows.Forms.TextBox();
            this.addComBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.submitBtn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.billBox = new System.Windows.Forms.ListBox();
            this.orderdetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restaurantDataSet = new WindowsFormsApp4.RestaurantDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restaurantDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.order_detailsTableAdapter = new WindowsFormsApp4.RestaurantDataSetTableAdapters.order_detailsTableAdapter();
            this.numericUpDownSchnitzelChip = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSalad = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCoffee = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSchnitzelRice = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSchnitzelPotatoes = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownFishChips = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCake = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSauces = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownTea = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCola = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownTomatoSoup = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownChickenSoup = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.orderdetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSchnitzelChip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSalad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCoffee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSchnitzelRice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSchnitzelPotatoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFishChips)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCake)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSauces)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCola)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTomatoSoup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownChickenSoup)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.AutoSize = true;
            this.Menu.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Menu.Location = new System.Drawing.Point(12, 9);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(100, 37);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "Menu";
            this.Menu.Click += new System.EventHandler(this.Menu_Click);
            // 
            // margherittaRadioBtn
            // 
            this.margherittaRadioBtn.AutoSize = true;
            this.margherittaRadioBtn.Location = new System.Drawing.Point(19, 86);
            this.margherittaRadioBtn.Name = "margherittaRadioBtn";
            this.margherittaRadioBtn.Size = new System.Drawing.Size(78, 17);
            this.margherittaRadioBtn.TabIndex = 1;
            this.margherittaRadioBtn.TabStop = true;
            this.margherittaRadioBtn.Text = "Margheritta";
            this.margherittaRadioBtn.UseVisualStyleBackColor = true;
            this.margherittaRadioBtn.CheckedChanged += new System.EventHandler(this.margherittaRadioBtn_CheckedChanged);
            // 
            // vegetarianaRadioBtn
            // 
            this.vegetarianaRadioBtn.AutoSize = true;
            this.vegetarianaRadioBtn.Location = new System.Drawing.Point(19, 110);
            this.vegetarianaRadioBtn.Name = "vegetarianaRadioBtn";
            this.vegetarianaRadioBtn.Size = new System.Drawing.Size(82, 17);
            this.vegetarianaRadioBtn.TabIndex = 2;
            this.vegetarianaRadioBtn.TabStop = true;
            this.vegetarianaRadioBtn.Text = "Vegetariana";
            this.vegetarianaRadioBtn.UseVisualStyleBackColor = true;
            this.vegetarianaRadioBtn.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // toscaRadioBtn
            // 
            this.toscaRadioBtn.AutoSize = true;
            this.toscaRadioBtn.Location = new System.Drawing.Point(19, 134);
            this.toscaRadioBtn.Name = "toscaRadioBtn";
            this.toscaRadioBtn.Size = new System.Drawing.Size(55, 17);
            this.toscaRadioBtn.TabIndex = 3;
            this.toscaRadioBtn.TabStop = true;
            this.toscaRadioBtn.Text = "Tosca";
            this.toscaRadioBtn.UseVisualStyleBackColor = true;
            // 
            // veneciaRadioBtn
            // 
            this.veneciaRadioBtn.AutoSize = true;
            this.veneciaRadioBtn.Location = new System.Drawing.Point(19, 158);
            this.veneciaRadioBtn.Name = "veneciaRadioBtn";
            this.veneciaRadioBtn.Size = new System.Drawing.Size(64, 17);
            this.veneciaRadioBtn.TabIndex = 4;
            this.veneciaRadioBtn.TabStop = true;
            this.veneciaRadioBtn.Text = "Venecia";
            this.veneciaRadioBtn.UseVisualStyleBackColor = true;
            this.veneciaRadioBtn.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(17, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pizza:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(157, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Addons to pizza - 2 zł";
            // 
            // cheeseBox
            // 
            this.cheeseBox.AutoSize = true;
            this.cheeseBox.Location = new System.Drawing.Point(6, 7);
            this.cheeseBox.Name = "cheeseBox";
            this.cheeseBox.Size = new System.Drawing.Size(97, 17);
            this.cheeseBox.TabIndex = 7;
            this.cheeseBox.Text = "Double chesse";
            this.cheeseBox.UseVisualStyleBackColor = true;
            this.cheeseBox.CheckedChanged += new System.EventHandler(this.cheeseBox_CheckedChanged);
            // 
            // salamiBox
            // 
            this.salamiBox.AutoSize = true;
            this.salamiBox.Location = new System.Drawing.Point(6, 31);
            this.salamiBox.Name = "salamiBox";
            this.salamiBox.Size = new System.Drawing.Size(57, 17);
            this.salamiBox.TabIndex = 8;
            this.salamiBox.Text = "Salami";
            this.salamiBox.UseVisualStyleBackColor = true;
            // 
            // hamBox
            // 
            this.hamBox.AutoSize = true;
            this.hamBox.Location = new System.Drawing.Point(6, 56);
            this.hamBox.Name = "hamBox";
            this.hamBox.Size = new System.Drawing.Size(48, 17);
            this.hamBox.TabIndex = 9;
            this.hamBox.Text = "Ham";
            this.hamBox.UseVisualStyleBackColor = true;
            // 
            // mushroomsBox
            // 
            this.mushroomsBox.AutoSize = true;
            this.mushroomsBox.Location = new System.Drawing.Point(6, 80);
            this.mushroomsBox.Name = "mushroomsBox";
            this.mushroomsBox.Size = new System.Drawing.Size(80, 17);
            this.mushroomsBox.TabIndex = 10;
            this.mushroomsBox.Text = "Mushrooms";
            this.mushroomsBox.UseVisualStyleBackColor = true;
            // 
            // addPizzaBtn
            // 
            this.addPizzaBtn.Location = new System.Drawing.Point(19, 208);
            this.addPizzaBtn.Name = "addPizzaBtn";
            this.addPizzaBtn.Size = new System.Drawing.Size(299, 23);
            this.addPizzaBtn.TabIndex = 11;
            this.addPizzaBtn.Text = "Add pizza to the bill ";
            this.addPizzaBtn.UseVisualStyleBackColor = true;
            this.addPizzaBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(344, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Soups:";
            // 
            // tomatoBtn
            // 
            this.tomatoBtn.Location = new System.Drawing.Point(347, 83);
            this.tomatoBtn.Name = "tomatoBtn";
            this.tomatoBtn.Size = new System.Drawing.Size(114, 23);
            this.tomatoBtn.TabIndex = 13;
            this.tomatoBtn.Text = "Tomato soup - 12zł";
            this.tomatoBtn.UseVisualStyleBackColor = true;
            this.tomatoBtn.Click += new System.EventHandler(this.tomatoBtn_Click);
            // 
            // chickenBtn
            // 
            this.chickenBtn.Location = new System.Drawing.Point(347, 112);
            this.chickenBtn.Name = "chickenBtn";
            this.chickenBtn.Size = new System.Drawing.Size(114, 23);
            this.chickenBtn.TabIndex = 14;
            this.chickenBtn.Text = "Chicken soup - 10zł";
            this.chickenBtn.UseVisualStyleBackColor = true;
            this.chickenBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(17, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Main foods:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // schnitzelChipsBtn
            // 
            this.schnitzelChipsBtn.Location = new System.Drawing.Point(21, 267);
            this.schnitzelChipsBtn.Name = "schnitzelChipsBtn";
            this.schnitzelChipsBtn.Size = new System.Drawing.Size(161, 23);
            this.schnitzelChipsBtn.TabIndex = 17;
            this.schnitzelChipsBtn.Text = "Schnitzel with chips - 30zł";
            this.schnitzelChipsBtn.UseVisualStyleBackColor = true;
            this.schnitzelChipsBtn.Click += new System.EventHandler(this.schnitzelChipsBtn_Click);
            // 
            // schnitzelRiceBtn
            // 
            this.schnitzelRiceBtn.Location = new System.Drawing.Point(21, 296);
            this.schnitzelRiceBtn.Name = "schnitzelRiceBtn";
            this.schnitzelRiceBtn.Size = new System.Drawing.Size(161, 23);
            this.schnitzelRiceBtn.TabIndex = 18;
            this.schnitzelRiceBtn.Text = "Schnitzel with rice - 30zł";
            this.schnitzelRiceBtn.UseVisualStyleBackColor = true;
            this.schnitzelRiceBtn.Click += new System.EventHandler(this.schnitzelRiceBtn_Click);
            // 
            // schnitzelPotatoBtn
            // 
            this.schnitzelPotatoBtn.Location = new System.Drawing.Point(21, 325);
            this.schnitzelPotatoBtn.Name = "schnitzelPotatoBtn";
            this.schnitzelPotatoBtn.Size = new System.Drawing.Size(161, 23);
            this.schnitzelPotatoBtn.TabIndex = 19;
            this.schnitzelPotatoBtn.Text = "Schnitzel with potatoes - 30zł";
            this.schnitzelPotatoBtn.UseVisualStyleBackColor = true;
            this.schnitzelPotatoBtn.Click += new System.EventHandler(this.schnitzelPotatoBtn_Click);
            // 
            // fishBtn
            // 
            this.fishBtn.Location = new System.Drawing.Point(21, 354);
            this.fishBtn.Name = "fishBtn";
            this.fishBtn.Size = new System.Drawing.Size(161, 23);
            this.fishBtn.TabIndex = 20;
            this.fishBtn.Text = "Fish with chips - 28zł";
            this.fishBtn.UseVisualStyleBackColor = true;
            this.fishBtn.Click += new System.EventHandler(this.button7_Click);
            // 
            // cakeBtn
            // 
            this.cakeBtn.Location = new System.Drawing.Point(21, 383);
            this.cakeBtn.Name = "cakeBtn";
            this.cakeBtn.Size = new System.Drawing.Size(161, 23);
            this.cakeBtn.TabIndex = 21;
            this.cakeBtn.Text = "Hungarian cake - 27zł";
            this.cakeBtn.UseVisualStyleBackColor = true;
            this.cakeBtn.Click += new System.EventHandler(this.button8_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(226, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Addonds to main foods:";
            // 
            // saladBtn
            // 
            this.saladBtn.Location = new System.Drawing.Point(230, 266);
            this.saladBtn.Name = "saladBtn";
            this.saladBtn.Size = new System.Drawing.Size(173, 23);
            this.saladBtn.TabIndex = 23;
            this.saladBtn.Text = "Salad bar - 5zł";
            this.saladBtn.UseVisualStyleBackColor = true;
            this.saladBtn.Click += new System.EventHandler(this.saladBtn_Click);
            // 
            // saucesBtn
            // 
            this.saucesBtn.Location = new System.Drawing.Point(230, 296);
            this.saucesBtn.Name = "saucesBtn";
            this.saucesBtn.Size = new System.Drawing.Size(173, 23);
            this.saucesBtn.TabIndex = 24;
            this.saucesBtn.Text = "A set of sauces - 6zł";
            this.saucesBtn.UseVisualStyleBackColor = true;
            this.saucesBtn.Click += new System.EventHandler(this.saucesBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(449, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Drinks:";
            // 
            // coffeeBtn
            // 
            this.coffeeBtn.Location = new System.Drawing.Point(453, 267);
            this.coffeeBtn.Name = "coffeeBtn";
            this.coffeeBtn.Size = new System.Drawing.Size(75, 23);
            this.coffeeBtn.TabIndex = 27;
            this.coffeeBtn.Text = "Coffee - 5zł";
            this.coffeeBtn.UseVisualStyleBackColor = true;
            this.coffeeBtn.Click += new System.EventHandler(this.coffeeBtn_Click);
            // 
            // teaBtn
            // 
            this.teaBtn.Location = new System.Drawing.Point(453, 297);
            this.teaBtn.Name = "teaBtn";
            this.teaBtn.Size = new System.Drawing.Size(75, 23);
            this.teaBtn.TabIndex = 28;
            this.teaBtn.Text = "Tea - 5zł";
            this.teaBtn.UseVisualStyleBackColor = true;
            this.teaBtn.Click += new System.EventHandler(this.teaBtn_Click);
            // 
            // colaBtn
            // 
            this.colaBtn.Location = new System.Drawing.Point(453, 327);
            this.colaBtn.Name = "colaBtn";
            this.colaBtn.Size = new System.Drawing.Size(75, 23);
            this.colaBtn.TabIndex = 29;
            this.colaBtn.Text = "Cola - 5zł";
            this.colaBtn.UseVisualStyleBackColor = true;
            this.colaBtn.Click += new System.EventHandler(this.colaBtn_Click);
            // 
            // commentTextBox
            // 
            this.commentTextBox.Location = new System.Drawing.Point(19, 445);
            this.commentTextBox.Multiline = true;
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.Size = new System.Drawing.Size(442, 79);
            this.commentTextBox.TabIndex = 30;
            this.commentTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(17, 422);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 20);
            this.label7.TabIndex = 31;
            this.label7.Text = "Comments:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(575, 389);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Totality:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // totalityTextBox
            // 
            this.totalityTextBox.Enabled = false;
            this.totalityTextBox.Location = new System.Drawing.Point(621, 386);
            this.totalityTextBox.Name = "totalityTextBox";
            this.totalityTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.totalityTextBox.Size = new System.Drawing.Size(196, 20);
            this.totalityTextBox.TabIndex = 33;
            this.totalityTextBox.Text = "0";
            // 
            // addComBtn
            // 
            this.addComBtn.Location = new System.Drawing.Point(467, 501);
            this.addComBtn.Name = "addComBtn";
            this.addComBtn.Size = new System.Drawing.Size(41, 23);
            this.addComBtn.TabIndex = 35;
            this.addComBtn.Text = "Add";
            this.addComBtn.UseVisualStyleBackColor = true;
            this.addComBtn.Click += new System.EventHandler(this.button15_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(574, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 20);
            this.label9.TabIndex = 36;
            this.label9.Text = "The bill:";
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(742, 501);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(75, 23);
            this.submitBtn.TabIndex = 37;
            this.submitBtn.Text = "Submit ";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.button14_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label10.Location = new System.Drawing.Point(103, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 38;
            this.label10.Text = "- 20 zł";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label11.Location = new System.Drawing.Point(103, 112);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 39;
            this.label11.Text = "- 22 zł";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label12.Location = new System.Drawing.Point(103, 136);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 40;
            this.label12.Text = "- 25 zł";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label13.Location = new System.Drawing.Point(103, 160);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 13);
            this.label13.TabIndex = 41;
            this.label13.Text = "- 25 zł";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(606, 475);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.emailTextBox.Size = new System.Drawing.Size(211, 20);
            this.emailTextBox.TabIndex = 42;
            this.emailTextBox.Text = "Email:";
            this.emailTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.emailTextBox.Enter += new System.EventHandler(this.emailTextBox_Enter);
            // 
            // billBox
            // 
            this.billBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.orderdetailsBindingSource, "PriceFood", true));
            this.billBox.FormattingEnabled = true;
            this.billBox.Location = new System.Drawing.Point(578, 88);
            this.billBox.Name = "billBox";
            this.billBox.Size = new System.Drawing.Size(239, 277);
            this.billBox.TabIndex = 43;
            this.billBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // orderdetailsBindingSource
            // 
            this.orderdetailsBindingSource.DataMember = "order_details";
            this.orderdetailsBindingSource.DataSource = this.restaurantDataSet;
            // 
            // restaurantDataSet
            // 
            this.restaurantDataSet.DataSetName = "RestaurantDataSet";
            this.restaurantDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.cheeseBox);
            this.groupBox1.Controls.Add(this.salamiBox);
            this.groupBox1.Controls.Add(this.hamBox);
            this.groupBox1.Controls.Add(this.mushroomsBox);
            this.groupBox1.Location = new System.Drawing.Point(161, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(157, 106);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            // 
            // menuBindingSource
            // 
            this.menuBindingSource.DataMember = "menu";
            this.menuBindingSource.CurrentChanged += new System.EventHandler(this.menuBindingSource_CurrentChanged);
            // 
            // restaurantDataSetBindingSource
            // 
            this.restaurantDataSetBindingSource.DataSource = this.restaurantDataSet;
            this.restaurantDataSetBindingSource.Position = 0;
            // 
            // order_detailsTableAdapter
            // 
            this.order_detailsTableAdapter.ClearBeforeFill = true;
            // 
            // numericUpDownSchnitzelChip
            // 
            this.numericUpDownSchnitzelChip.Location = new System.Drawing.Point(185, 268);
            this.numericUpDownSchnitzelChip.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownSchnitzelChip.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSchnitzelChip.Name = "numericUpDownSchnitzelChip";
            this.numericUpDownSchnitzelChip.Size = new System.Drawing.Size(40, 20);
            this.numericUpDownSchnitzelChip.TabIndex = 57;
            this.numericUpDownSchnitzelChip.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownSalad
            // 
            this.numericUpDownSalad.Location = new System.Drawing.Point(407, 268);
            this.numericUpDownSalad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSalad.Name = "numericUpDownSalad";
            this.numericUpDownSalad.Size = new System.Drawing.Size(39, 20);
            this.numericUpDownSalad.TabIndex = 59;
            this.numericUpDownSalad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownCoffee
            // 
            this.numericUpDownCoffee.Location = new System.Drawing.Point(532, 268);
            this.numericUpDownCoffee.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCoffee.Name = "numericUpDownCoffee";
            this.numericUpDownCoffee.Size = new System.Drawing.Size(39, 20);
            this.numericUpDownCoffee.TabIndex = 60;
            this.numericUpDownCoffee.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownSchnitzelRice
            // 
            this.numericUpDownSchnitzelRice.Location = new System.Drawing.Point(186, 297);
            this.numericUpDownSchnitzelRice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSchnitzelRice.Name = "numericUpDownSchnitzelRice";
            this.numericUpDownSchnitzelRice.Size = new System.Drawing.Size(39, 20);
            this.numericUpDownSchnitzelRice.TabIndex = 61;
            this.numericUpDownSchnitzelRice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownSchnitzelPotatoes
            // 
            this.numericUpDownSchnitzelPotatoes.Location = new System.Drawing.Point(186, 326);
            this.numericUpDownSchnitzelPotatoes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSchnitzelPotatoes.Name = "numericUpDownSchnitzelPotatoes";
            this.numericUpDownSchnitzelPotatoes.Size = new System.Drawing.Size(39, 20);
            this.numericUpDownSchnitzelPotatoes.TabIndex = 62;
            this.numericUpDownSchnitzelPotatoes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownFishChips
            // 
            this.numericUpDownFishChips.Location = new System.Drawing.Point(186, 356);
            this.numericUpDownFishChips.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownFishChips.Name = "numericUpDownFishChips";
            this.numericUpDownFishChips.Size = new System.Drawing.Size(39, 20);
            this.numericUpDownFishChips.TabIndex = 63;
            this.numericUpDownFishChips.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownCake
            // 
            this.numericUpDownCake.Location = new System.Drawing.Point(186, 384);
            this.numericUpDownCake.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCake.Name = "numericUpDownCake";
            this.numericUpDownCake.Size = new System.Drawing.Size(39, 20);
            this.numericUpDownCake.TabIndex = 64;
            this.numericUpDownCake.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownSauces
            // 
            this.numericUpDownSauces.Location = new System.Drawing.Point(407, 297);
            this.numericUpDownSauces.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSauces.Name = "numericUpDownSauces";
            this.numericUpDownSauces.Size = new System.Drawing.Size(39, 20);
            this.numericUpDownSauces.TabIndex = 65;
            this.numericUpDownSauces.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownTea
            // 
            this.numericUpDownTea.Location = new System.Drawing.Point(532, 298);
            this.numericUpDownTea.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownTea.Name = "numericUpDownTea";
            this.numericUpDownTea.Size = new System.Drawing.Size(39, 20);
            this.numericUpDownTea.TabIndex = 66;
            this.numericUpDownTea.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownCola
            // 
            this.numericUpDownCola.Location = new System.Drawing.Point(532, 328);
            this.numericUpDownCola.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCola.Name = "numericUpDownCola";
            this.numericUpDownCola.Size = new System.Drawing.Size(39, 20);
            this.numericUpDownCola.TabIndex = 67;
            this.numericUpDownCola.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownTomatoSoup
            // 
            this.numericUpDownTomatoSoup.Location = new System.Drawing.Point(465, 84);
            this.numericUpDownTomatoSoup.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownTomatoSoup.Name = "numericUpDownTomatoSoup";
            this.numericUpDownTomatoSoup.Size = new System.Drawing.Size(39, 20);
            this.numericUpDownTomatoSoup.TabIndex = 68;
            this.numericUpDownTomatoSoup.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownChickenSoup
            // 
            this.numericUpDownChickenSoup.Location = new System.Drawing.Point(465, 113);
            this.numericUpDownChickenSoup.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownChickenSoup.Name = "numericUpDownChickenSoup";
            this.numericUpDownChickenSoup.Size = new System.Drawing.Size(39, 20);
            this.numericUpDownChickenSoup.TabIndex = 69;
            this.numericUpDownChickenSoup.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(840, 552);
            this.Controls.Add(this.numericUpDownChickenSoup);
            this.Controls.Add(this.numericUpDownTomatoSoup);
            this.Controls.Add(this.numericUpDownCola);
            this.Controls.Add(this.numericUpDownTea);
            this.Controls.Add(this.numericUpDownSauces);
            this.Controls.Add(this.numericUpDownCake);
            this.Controls.Add(this.numericUpDownFishChips);
            this.Controls.Add(this.numericUpDownSchnitzelPotatoes);
            this.Controls.Add(this.numericUpDownSchnitzelRice);
            this.Controls.Add(this.numericUpDownCoffee);
            this.Controls.Add(this.numericUpDownSalad);
            this.Controls.Add(this.numericUpDownSchnitzelChip);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.billBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.addComBtn);
            this.Controls.Add(this.totalityTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.commentTextBox);
            this.Controls.Add(this.colaBtn);
            this.Controls.Add(this.teaBtn);
            this.Controls.Add(this.coffeeBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.saucesBtn);
            this.Controls.Add(this.saladBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cakeBtn);
            this.Controls.Add(this.fishBtn);
            this.Controls.Add(this.schnitzelPotatoBtn);
            this.Controls.Add(this.schnitzelRiceBtn);
            this.Controls.Add(this.schnitzelChipsBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chickenBtn);
            this.Controls.Add(this.tomatoBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addPizzaBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.veneciaRadioBtn);
            this.Controls.Add(this.toscaRadioBtn);
            this.Controls.Add(this.vegetarianaRadioBtn);
            this.Controls.Add(this.margherittaRadioBtn);
            this.Controls.Add(this.Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderdetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSchnitzelChip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSalad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCoffee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSchnitzelRice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSchnitzelPotatoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFishChips)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCake)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSauces)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCola)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTomatoSoup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownChickenSoup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Menu;
        private System.Windows.Forms.RadioButton margherittaRadioBtn;
        private System.Windows.Forms.RadioButton vegetarianaRadioBtn;
        private System.Windows.Forms.RadioButton toscaRadioBtn;
        private System.Windows.Forms.RadioButton veneciaRadioBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cheeseBox;
        private System.Windows.Forms.CheckBox salamiBox;
        private System.Windows.Forms.CheckBox hamBox;
        private System.Windows.Forms.CheckBox mushroomsBox;
        private System.Windows.Forms.Button addPizzaBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button tomatoBtn;
        private System.Windows.Forms.Button chickenBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button schnitzelChipsBtn;
        private System.Windows.Forms.Button schnitzelRiceBtn;
        private System.Windows.Forms.Button schnitzelPotatoBtn;
        private System.Windows.Forms.Button fishBtn;
        private System.Windows.Forms.Button cakeBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button saladBtn;
        private System.Windows.Forms.Button saucesBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button coffeeBtn;
        private System.Windows.Forms.Button teaBtn;
        private System.Windows.Forms.Button colaBtn;
        private System.Windows.Forms.TextBox commentTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox totalityTextBox;
        private System.Windows.Forms.Button addComBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.ListBox billBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource menuBindingSource;
        private System.Windows.Forms.BindingSource restaurantDataSetBindingSource;
        private RestaurantDataSet restaurantDataSet;
        private System.Windows.Forms.BindingSource orderdetailsBindingSource;
        private RestaurantDataSetTableAdapters.order_detailsTableAdapter order_detailsTableAdapter;
        private System.Windows.Forms.NumericUpDown numericUpDownSchnitzelChip;
        private System.Windows.Forms.NumericUpDown numericUpDownSalad;
        private System.Windows.Forms.NumericUpDown numericUpDownCoffee;
        private System.Windows.Forms.NumericUpDown numericUpDownSchnitzelRice;
        private System.Windows.Forms.NumericUpDown numericUpDownSchnitzelPotatoes;
        private System.Windows.Forms.NumericUpDown numericUpDownFishChips;
        private System.Windows.Forms.NumericUpDown numericUpDownCake;
        private System.Windows.Forms.NumericUpDown numericUpDownSauces;
        private System.Windows.Forms.NumericUpDown numericUpDownTea;
        private System.Windows.Forms.NumericUpDown numericUpDownCola;
        private System.Windows.Forms.NumericUpDown numericUpDownTomatoSoup;
        private System.Windows.Forms.NumericUpDown numericUpDownChickenSoup;
        //private WindowsFormsApp4.MenuDataSet menuDataSet;
        //private WindowsFormsApp4.MenuDataSetTableAdapters.menuTableAdapter menuTableAdapter;
    }
}

