namespace PizzaApp
{
    partial class PizzaGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PizzaTab = new System.Windows.Forms.TabControl();
            this.tabPizza = new System.Windows.Forms.TabPage();
            this.lstBxToppings = new System.Windows.Forms.ListBox();
            this.CbxSpecialtyPizza = new System.Windows.Forms.ComboBox();
            this.CbxSauce = new System.Windows.Forms.ComboBox();
            this.CbxCrust = new System.Windows.Forms.ComboBox();
            this.CbxSize = new System.Windows.Forms.ComboBox();
            this.lblFamousPizzas = new System.Windows.Forms.Label();
            this.lblToppings = new System.Windows.Forms.Label();
            this.lblSpecialtyPizzas = new System.Windows.Forms.Label();
            this.lblSauce = new System.Windows.Forms.Label();
            this.lblCrust = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.tabDrinks = new System.Windows.Forms.TabPage();
            this.txtBxWater = new System.Windows.Forms.TextBox();
            this.txtBxSoda = new System.Windows.Forms.TextBox();
            this.lblDrinksDescription = new System.Windows.Forms.Label();
            this.lblDrinksQuantity = new System.Windows.Forms.Label();
            this.lblWater = new System.Windows.Forms.Label();
            this.lblSoda = new System.Windows.Forms.Label();
            this.lblTitleDrinks = new System.Windows.Forms.Label();
            this.tabSides = new System.Windows.Forms.TabPage();
            this.CbxSides = new System.Windows.Forms.ComboBox();
            this.lblSidesDescription = new System.Windows.Forms.Label();
            this.lblSidesTitle = new System.Windows.Forms.Label();
            this.tabCustomerInfo = new System.Windows.Forms.TabPage();
            this.txtBxCustomerEmail = new System.Windows.Forms.TextBox();
            this.txtBxCustomerPhone = new System.Windows.Forms.TextBox();
            this.txtBxCustomerAddress = new System.Windows.Forms.TextBox();
            this.txtBxCustomerName = new System.Windows.Forms.TextBox();
            this.lblCustomerEmail = new System.Windows.Forms.Label();
            this.lblCustomerPhone = new System.Windows.Forms.Label();
            this.lblCustomerAddress = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblCustomerInfoTitle = new System.Windows.Forms.Label();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.btnResetOrder = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderSoda = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderWater = new System.Windows.Forms.ErrorProvider(this.components);
            this.PizzaTab.SuspendLayout();
            this.tabPizza.SuspendLayout();
            this.tabDrinks.SuspendLayout();
            this.tabSides.SuspendLayout();
            this.tabCustomerInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSoda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderWater)).BeginInit();
            this.SuspendLayout();
            // 
            // PizzaTab
            // 
            this.PizzaTab.Controls.Add(this.tabPizza);
            this.PizzaTab.Controls.Add(this.tabDrinks);
            this.PizzaTab.Controls.Add(this.tabSides);
            this.PizzaTab.Controls.Add(this.tabCustomerInfo);
            this.PizzaTab.Location = new System.Drawing.Point(1, 1);
            this.PizzaTab.Name = "PizzaTab";
            this.PizzaTab.SelectedIndex = 0;
            this.PizzaTab.Size = new System.Drawing.Size(799, 406);
            this.PizzaTab.TabIndex = 2;
            // 
            // tabPizza
            // 
            this.tabPizza.BackgroundImage = global::PizzaApp.Properties.Resources.ivan_torres_MQUqbmszGGM_unsplash;
            this.tabPizza.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPizza.Controls.Add(this.lstBxToppings);
            this.tabPizza.Controls.Add(this.CbxSpecialtyPizza);
            this.tabPizza.Controls.Add(this.CbxSauce);
            this.tabPizza.Controls.Add(this.CbxCrust);
            this.tabPizza.Controls.Add(this.CbxSize);
            this.tabPizza.Controls.Add(this.lblFamousPizzas);
            this.tabPizza.Controls.Add(this.lblToppings);
            this.tabPizza.Controls.Add(this.lblSpecialtyPizzas);
            this.tabPizza.Controls.Add(this.lblSauce);
            this.tabPizza.Controls.Add(this.lblCrust);
            this.tabPizza.Controls.Add(this.lblSize);
            this.tabPizza.Location = new System.Drawing.Point(4, 25);
            this.tabPizza.Name = "tabPizza";
            this.tabPizza.Padding = new System.Windows.Forms.Padding(3);
            this.tabPizza.Size = new System.Drawing.Size(791, 377);
            this.tabPizza.TabIndex = 0;
            this.tabPizza.Text = "Pizza";
            this.tabPizza.UseVisualStyleBackColor = true;
            // 
            // lstBxToppings
            // 
            this.lstBxToppings.FormattingEnabled = true;
            this.lstBxToppings.ItemHeight = 16;
            this.lstBxToppings.Items.AddRange(new object[] {
            "Anchovies",
            "Bacon",
            "Banana Pepper",
            "Chicken",
            "Extra Cheese",
            "Garlic",
            "Green Peppers",
            "Ham",
            "Mushroom",
            "Olives",
            "Onions",
            "Parmesan",
            "Pepperoni",
            "Sausage",
            "Spinach",
            "Tomato"});
            this.lstBxToppings.Location = new System.Drawing.Point(433, 129);
            this.lstBxToppings.Name = "lstBxToppings";
            this.lstBxToppings.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstBxToppings.Size = new System.Drawing.Size(192, 212);
            this.lstBxToppings.Sorted = true;
            this.lstBxToppings.TabIndex = 10;
            this.lstBxToppings.SelectedIndexChanged += new System.EventHandler(this.lstBxToppings_SelectedIndexChanged);
            // 
            // CbxSpecialtyPizza
            // 
            this.CbxSpecialtyPizza.FormattingEnabled = true;
            this.CbxSpecialtyPizza.Items.AddRange(new object[] {
            "Meat Lovers",
            "Supreme",
            "Veggie Lovers",
            "Hawaiian"});
            this.CbxSpecialtyPizza.Location = new System.Drawing.Point(84, 317);
            this.CbxSpecialtyPizza.Name = "CbxSpecialtyPizza";
            this.CbxSpecialtyPizza.Size = new System.Drawing.Size(184, 24);
            this.CbxSpecialtyPizza.TabIndex = 9;
            this.CbxSpecialtyPizza.SelectedIndexChanged += new System.EventHandler(this.CbxSpecialtyPizza_SelectedIndexChanged);
            // 
            // CbxSauce
            // 
            this.CbxSauce.FormattingEnabled = true;
            this.CbxSauce.Items.AddRange(new object[] {
            "Tomato",
            "Pesto",
            "White",
            "Ranch",
            "Buffalo"});
            this.CbxSauce.Location = new System.Drawing.Point(84, 254);
            this.CbxSauce.Name = "CbxSauce";
            this.CbxSauce.Size = new System.Drawing.Size(184, 24);
            this.CbxSauce.TabIndex = 8;
            this.CbxSauce.SelectedIndexChanged += new System.EventHandler(this.CbxSauce_SelectedIndexChanged);
            // 
            // CbxCrust
            // 
            this.CbxCrust.FormattingEnabled = true;
            this.CbxCrust.Items.AddRange(new object[] {
            "Thin & Crispy Crust",
            "Pan Crust",
            "Regular Crust"});
            this.CbxCrust.Location = new System.Drawing.Point(84, 191);
            this.CbxCrust.Name = "CbxCrust";
            this.CbxCrust.Size = new System.Drawing.Size(184, 24);
            this.CbxCrust.TabIndex = 7;
            this.CbxCrust.SelectedIndexChanged += new System.EventHandler(this.CbxCrust_SelectedIndexChanged);
            // 
            // CbxSize
            // 
            this.CbxSize.FormattingEnabled = true;
            this.CbxSize.Items.AddRange(new object[] {
            "Small(10\") - $9.95",
            "Medium(12\") - $12.95",
            "Large(16\") - $15.95"});
            this.CbxSize.Location = new System.Drawing.Point(84, 128);
            this.CbxSize.Name = "CbxSize";
            this.CbxSize.Size = new System.Drawing.Size(184, 24);
            this.CbxSize.TabIndex = 6;
            this.CbxSize.SelectedIndexChanged += new System.EventHandler(this.CbxSize_SelectedIndexChanged);
            // 
            // lblFamousPizzas
            // 
            this.lblFamousPizzas.AutoSize = true;
            this.lblFamousPizzas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFamousPizzas.ForeColor = System.Drawing.Color.White;
            this.lblFamousPizzas.Location = new System.Drawing.Point(207, 20);
            this.lblFamousPizzas.Name = "lblFamousPizzas";
            this.lblFamousPizzas.Size = new System.Drawing.Size(338, 36);
            this.lblFamousPizzas.TabIndex = 5;
            this.lblFamousPizzas.Text = "Famous Pizza Delivery";
            // 
            // lblToppings
            // 
            this.lblToppings.AutoSize = true;
            this.lblToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToppings.ForeColor = System.Drawing.Color.White;
            this.lblToppings.Location = new System.Drawing.Point(453, 99);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(172, 17);
            this.lblToppings.TabIndex = 4;
            this.lblToppings.Text = "Toppings - $1.50 each";
            // 
            // lblSpecialtyPizzas
            // 
            this.lblSpecialtyPizzas.AutoSize = true;
            this.lblSpecialtyPizzas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecialtyPizzas.ForeColor = System.Drawing.Color.White;
            this.lblSpecialtyPizzas.Location = new System.Drawing.Point(124, 294);
            this.lblSpecialtyPizzas.Name = "lblSpecialtyPizzas";
            this.lblSpecialtyPizzas.Size = new System.Drawing.Size(126, 17);
            this.lblSpecialtyPizzas.TabIndex = 3;
            this.lblSpecialtyPizzas.Text = "Specialty Pizzas";
            // 
            // lblSauce
            // 
            this.lblSauce.AutoSize = true;
            this.lblSauce.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSauce.ForeColor = System.Drawing.Color.White;
            this.lblSauce.Location = new System.Drawing.Point(153, 229);
            this.lblSauce.Name = "lblSauce";
            this.lblSauce.Size = new System.Drawing.Size(53, 17);
            this.lblSauce.TabIndex = 2;
            this.lblSauce.Text = "Sauce";
            // 
            // lblCrust
            // 
            this.lblCrust.AutoSize = true;
            this.lblCrust.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrust.ForeColor = System.Drawing.Color.White;
            this.lblCrust.Location = new System.Drawing.Point(158, 164);
            this.lblCrust.Name = "lblCrust";
            this.lblCrust.Size = new System.Drawing.Size(46, 17);
            this.lblCrust.TabIndex = 1;
            this.lblCrust.Text = "Crust";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.ForeColor = System.Drawing.Color.White;
            this.lblSize.Location = new System.Drawing.Point(160, 99);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(39, 17);
            this.lblSize.TabIndex = 0;
            this.lblSize.Text = "Size";
            // 
            // tabDrinks
            // 
            this.tabDrinks.BackgroundImage = global::PizzaApp.Properties.Resources.ivan_torres_MQUqbmszGGM_unsplash;
            this.tabDrinks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabDrinks.Controls.Add(this.txtBxWater);
            this.tabDrinks.Controls.Add(this.txtBxSoda);
            this.tabDrinks.Controls.Add(this.lblDrinksDescription);
            this.tabDrinks.Controls.Add(this.lblDrinksQuantity);
            this.tabDrinks.Controls.Add(this.lblWater);
            this.tabDrinks.Controls.Add(this.lblSoda);
            this.tabDrinks.Controls.Add(this.lblTitleDrinks);
            this.tabDrinks.Location = new System.Drawing.Point(4, 25);
            this.tabDrinks.Name = "tabDrinks";
            this.tabDrinks.Padding = new System.Windows.Forms.Padding(3);
            this.tabDrinks.Size = new System.Drawing.Size(791, 377);
            this.tabDrinks.TabIndex = 1;
            this.tabDrinks.Text = "Drinks";
            this.tabDrinks.UseVisualStyleBackColor = true;
            // 
            // txtBxWater
            // 
            this.txtBxWater.Location = new System.Drawing.Point(398, 243);
            this.txtBxWater.Name = "txtBxWater";
            this.txtBxWater.Size = new System.Drawing.Size(122, 22);
            this.txtBxWater.TabIndex = 6;
            this.txtBxWater.TextChanged += new System.EventHandler(this.txtBxWater_TextChanged);
            this.txtBxWater.Validating += new System.ComponentModel.CancelEventHandler(this.txtBxWater_Validating);
            // 
            // txtBxSoda
            // 
            this.txtBxSoda.Location = new System.Drawing.Point(398, 170);
            this.txtBxSoda.Name = "txtBxSoda";
            this.txtBxSoda.Size = new System.Drawing.Size(122, 22);
            this.txtBxSoda.TabIndex = 5;
            this.txtBxSoda.TextChanged += new System.EventHandler(this.txtBxSoda_TextChanged);
            this.txtBxSoda.Validating += new System.ComponentModel.CancelEventHandler(this.txtBxSoda_Validating);
            // 
            // lblDrinksDescription
            // 
            this.lblDrinksDescription.AutoSize = true;
            this.lblDrinksDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrinksDescription.ForeColor = System.Drawing.Color.White;
            this.lblDrinksDescription.Location = new System.Drawing.Point(225, 310);
            this.lblDrinksDescription.Name = "lblDrinksDescription";
            this.lblDrinksDescription.Size = new System.Drawing.Size(341, 25);
            this.lblDrinksDescription.TabIndex = 4;
            this.lblDrinksDescription.Text = "Soda cost is $1.75 - Water is free!";
            // 
            // lblDrinksQuantity
            // 
            this.lblDrinksQuantity.AutoSize = true;
            this.lblDrinksQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrinksQuantity.ForeColor = System.Drawing.Color.White;
            this.lblDrinksQuantity.Location = new System.Drawing.Point(413, 117);
            this.lblDrinksQuantity.Name = "lblDrinksQuantity";
            this.lblDrinksQuantity.Size = new System.Drawing.Size(93, 25);
            this.lblDrinksQuantity.TabIndex = 3;
            this.lblDrinksQuantity.Text = "Quantity";
            // 
            // lblWater
            // 
            this.lblWater.AutoSize = true;
            this.lblWater.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWater.ForeColor = System.Drawing.Color.White;
            this.lblWater.Location = new System.Drawing.Point(271, 243);
            this.lblWater.Name = "lblWater";
            this.lblWater.Size = new System.Drawing.Size(97, 25);
            this.lblWater.TabIndex = 2;
            this.lblWater.Text = "Water(s)";
            // 
            // lblSoda
            // 
            this.lblSoda.AutoSize = true;
            this.lblSoda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoda.ForeColor = System.Drawing.Color.White;
            this.lblSoda.Location = new System.Drawing.Point(275, 164);
            this.lblSoda.Name = "lblSoda";
            this.lblSoda.Size = new System.Drawing.Size(90, 25);
            this.lblSoda.TabIndex = 1;
            this.lblSoda.Text = "Soda(s)";
            // 
            // lblTitleDrinks
            // 
            this.lblTitleDrinks.AutoSize = true;
            this.lblTitleDrinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleDrinks.ForeColor = System.Drawing.Color.White;
            this.lblTitleDrinks.Location = new System.Drawing.Point(226, 31);
            this.lblTitleDrinks.Name = "lblTitleDrinks";
            this.lblTitleDrinks.Size = new System.Drawing.Size(338, 36);
            this.lblTitleDrinks.TabIndex = 0;
            this.lblTitleDrinks.Text = "Famous Pizza Delivery";
            // 
            // tabSides
            // 
            this.tabSides.BackgroundImage = global::PizzaApp.Properties.Resources.ivan_torres_MQUqbmszGGM_unsplash;
            this.tabSides.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabSides.Controls.Add(this.CbxSides);
            this.tabSides.Controls.Add(this.lblSidesDescription);
            this.tabSides.Controls.Add(this.lblSidesTitle);
            this.tabSides.Location = new System.Drawing.Point(4, 25);
            this.tabSides.Name = "tabSides";
            this.tabSides.Size = new System.Drawing.Size(791, 377);
            this.tabSides.TabIndex = 2;
            this.tabSides.Text = "Sides";
            this.tabSides.UseVisualStyleBackColor = true;
            // 
            // CbxSides
            // 
            this.CbxSides.FormattingEnabled = true;
            this.CbxSides.Items.AddRange(new object[] {
            "Cheese Bread - $1.00",
            "Cheese Dip - $1.75",
            "Cinnamon Breadsticks - $1.50",
            "Lava Cakes - $2.00"});
            this.CbxSides.Location = new System.Drawing.Point(281, 188);
            this.CbxSides.Name = "CbxSides";
            this.CbxSides.Size = new System.Drawing.Size(229, 24);
            this.CbxSides.Sorted = true;
            this.CbxSides.TabIndex = 2;
            this.CbxSides.SelectedIndexChanged += new System.EventHandler(this.CbxSides_SelectedIndexChanged);
            // 
            // lblSidesDescription
            // 
            this.lblSidesDescription.AutoSize = true;
            this.lblSidesDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSidesDescription.ForeColor = System.Drawing.Color.White;
            this.lblSidesDescription.Location = new System.Drawing.Point(232, 116);
            this.lblSidesDescription.Name = "lblSidesDescription";
            this.lblSidesDescription.Size = new System.Drawing.Size(326, 25);
            this.lblSidesDescription.TabIndex = 1;
            this.lblSidesDescription.Text = "Pick a side to go with your order!";
            // 
            // lblSidesTitle
            // 
            this.lblSidesTitle.AutoSize = true;
            this.lblSidesTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSidesTitle.ForeColor = System.Drawing.Color.White;
            this.lblSidesTitle.Location = new System.Drawing.Point(226, 33);
            this.lblSidesTitle.Name = "lblSidesTitle";
            this.lblSidesTitle.Size = new System.Drawing.Size(338, 36);
            this.lblSidesTitle.TabIndex = 0;
            this.lblSidesTitle.Text = "Famous Pizza Delivery";
            // 
            // tabCustomerInfo
            // 
            this.tabCustomerInfo.BackgroundImage = global::PizzaApp.Properties.Resources.ivan_torres_MQUqbmszGGM_unsplash;
            this.tabCustomerInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabCustomerInfo.Controls.Add(this.txtBxCustomerEmail);
            this.tabCustomerInfo.Controls.Add(this.txtBxCustomerPhone);
            this.tabCustomerInfo.Controls.Add(this.txtBxCustomerAddress);
            this.tabCustomerInfo.Controls.Add(this.txtBxCustomerName);
            this.tabCustomerInfo.Controls.Add(this.lblCustomerEmail);
            this.tabCustomerInfo.Controls.Add(this.lblCustomerPhone);
            this.tabCustomerInfo.Controls.Add(this.lblCustomerAddress);
            this.tabCustomerInfo.Controls.Add(this.lblCustomerName);
            this.tabCustomerInfo.Controls.Add(this.lblCustomerInfoTitle);
            this.tabCustomerInfo.Location = new System.Drawing.Point(4, 25);
            this.tabCustomerInfo.Name = "tabCustomerInfo";
            this.tabCustomerInfo.Size = new System.Drawing.Size(791, 377);
            this.tabCustomerInfo.TabIndex = 3;
            this.tabCustomerInfo.Text = "Customer Info";
            this.tabCustomerInfo.UseVisualStyleBackColor = true;
            // 
            // txtBxCustomerEmail
            // 
            this.txtBxCustomerEmail.Location = new System.Drawing.Point(124, 240);
            this.txtBxCustomerEmail.Name = "txtBxCustomerEmail";
            this.txtBxCustomerEmail.Size = new System.Drawing.Size(250, 22);
            this.txtBxCustomerEmail.TabIndex = 8;
            this.txtBxCustomerEmail.TextChanged += new System.EventHandler(this.txtBxCustomerEmail_TextChanged);
            // 
            // txtBxCustomerPhone
            // 
            this.txtBxCustomerPhone.Location = new System.Drawing.Point(124, 192);
            this.txtBxCustomerPhone.Name = "txtBxCustomerPhone";
            this.txtBxCustomerPhone.Size = new System.Drawing.Size(250, 22);
            this.txtBxCustomerPhone.TabIndex = 7;
            this.txtBxCustomerPhone.TextChanged += new System.EventHandler(this.txtBxCustomerPhone_TextChanged);
            // 
            // txtBxCustomerAddress
            // 
            this.txtBxCustomerAddress.Location = new System.Drawing.Point(224, 147);
            this.txtBxCustomerAddress.Name = "txtBxCustomerAddress";
            this.txtBxCustomerAddress.Size = new System.Drawing.Size(250, 22);
            this.txtBxCustomerAddress.TabIndex = 6;
            this.txtBxCustomerAddress.TextChanged += new System.EventHandler(this.txtBxCustomerAddress_TextChanged);
            // 
            // txtBxCustomerName
            // 
            this.txtBxCustomerName.Location = new System.Drawing.Point(124, 103);
            this.txtBxCustomerName.Name = "txtBxCustomerName";
            this.txtBxCustomerName.Size = new System.Drawing.Size(250, 22);
            this.txtBxCustomerName.TabIndex = 5;
            this.txtBxCustomerName.TextChanged += new System.EventHandler(this.txtBxCustomerName_TextChanged);
            // 
            // lblCustomerEmail
            // 
            this.lblCustomerEmail.AutoSize = true;
            this.lblCustomerEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerEmail.ForeColor = System.Drawing.Color.White;
            this.lblCustomerEmail.Location = new System.Drawing.Point(39, 240);
            this.lblCustomerEmail.Name = "lblCustomerEmail";
            this.lblCustomerEmail.Size = new System.Drawing.Size(65, 22);
            this.lblCustomerEmail.TabIndex = 4;
            this.lblCustomerEmail.Text = "Email:";
            // 
            // lblCustomerPhone
            // 
            this.lblCustomerPhone.AutoSize = true;
            this.lblCustomerPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerPhone.ForeColor = System.Drawing.Color.White;
            this.lblCustomerPhone.Location = new System.Drawing.Point(39, 192);
            this.lblCustomerPhone.Name = "lblCustomerPhone";
            this.lblCustomerPhone.Size = new System.Drawing.Size(73, 22);
            this.lblCustomerPhone.TabIndex = 3;
            this.lblCustomerPhone.Text = "Phone:";
            // 
            // lblCustomerAddress
            // 
            this.lblCustomerAddress.AutoSize = true;
            this.lblCustomerAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerAddress.ForeColor = System.Drawing.Color.White;
            this.lblCustomerAddress.Location = new System.Drawing.Point(39, 144);
            this.lblCustomerAddress.Name = "lblCustomerAddress";
            this.lblCustomerAddress.Size = new System.Drawing.Size(168, 22);
            this.lblCustomerAddress.TabIndex = 2;
            this.lblCustomerAddress.Text = "Delivery Address:";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.ForeColor = System.Drawing.Color.White;
            this.lblCustomerName.Location = new System.Drawing.Point(39, 103);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(67, 22);
            this.lblCustomerName.TabIndex = 1;
            this.lblCustomerName.Text = "Name:";
            // 
            // lblCustomerInfoTitle
            // 
            this.lblCustomerInfoTitle.AutoSize = true;
            this.lblCustomerInfoTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerInfoTitle.ForeColor = System.Drawing.Color.White;
            this.lblCustomerInfoTitle.Location = new System.Drawing.Point(226, 30);
            this.lblCustomerInfoTitle.Name = "lblCustomerInfoTitle";
            this.lblCustomerInfoTitle.Size = new System.Drawing.Size(338, 36);
            this.lblCustomerInfoTitle.TabIndex = 0;
            this.lblCustomerInfoTitle.Text = "Famous Pizza Delivery";
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Location = new System.Drawing.Point(599, 415);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(109, 23);
            this.btnPlaceOrder.TabIndex = 3;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // btnResetOrder
            // 
            this.btnResetOrder.Location = new System.Drawing.Point(64, 415);
            this.btnResetOrder.Name = "btnResetOrder";
            this.btnResetOrder.Size = new System.Drawing.Size(104, 23);
            this.btnResetOrder.TabIndex = 4;
            this.btnResetOrder.Text = "Reset Order";
            this.btnResetOrder.UseVisualStyleBackColor = true;
            this.btnResetOrder.Click += new System.EventHandler(this.btnResetOrder_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProviderSoda
            // 
            this.errorProviderSoda.ContainerControl = this;
            // 
            // errorProviderWater
            // 
            this.errorProviderWater.ContainerControl = this;
            // 
            // PizzaGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnResetOrder);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.PizzaTab);
            this.Name = "PizzaGUI";
            this.Text = "Famous Pizza Delivery";
            this.Load += new System.EventHandler(this.PizzaGUI_Load);
            this.PizzaTab.ResumeLayout(false);
            this.tabPizza.ResumeLayout(false);
            this.tabPizza.PerformLayout();
            this.tabDrinks.ResumeLayout(false);
            this.tabDrinks.PerformLayout();
            this.tabSides.ResumeLayout(false);
            this.tabSides.PerformLayout();
            this.tabCustomerInfo.ResumeLayout(false);
            this.tabCustomerInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSoda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderWater)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl PizzaTab;
        private System.Windows.Forms.TabPage tabPizza;
        private System.Windows.Forms.TabPage tabDrinks;
        private System.Windows.Forms.TabPage tabSides;
        private System.Windows.Forms.TabPage tabCustomerInfo;
        private System.Windows.Forms.Label lblToppings;
        private System.Windows.Forms.Label lblSpecialtyPizzas;
        private System.Windows.Forms.Label lblSauce;
        private System.Windows.Forms.Label lblCrust;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblFamousPizzas;
        private System.Windows.Forms.ComboBox CbxSize;
        private System.Windows.Forms.ListBox lstBxToppings;
        private System.Windows.Forms.ComboBox CbxSpecialtyPizza;
        private System.Windows.Forms.ComboBox CbxSauce;
        private System.Windows.Forms.ComboBox CbxCrust;
        private System.Windows.Forms.Label lblDrinksDescription;
        private System.Windows.Forms.Label lblDrinksQuantity;
        private System.Windows.Forms.Label lblWater;
        private System.Windows.Forms.Label lblSoda;
        private System.Windows.Forms.Label lblTitleDrinks;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Button btnResetOrder;
        private System.Windows.Forms.ComboBox CbxSides;
        private System.Windows.Forms.Label lblSidesDescription;
        private System.Windows.Forms.Label lblSidesTitle;
        private System.Windows.Forms.Label lblCustomerEmail;
        private System.Windows.Forms.Label lblCustomerPhone;
        private System.Windows.Forms.Label lblCustomerAddress;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblCustomerInfoTitle;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtBxWater;
        private System.Windows.Forms.TextBox txtBxSoda;
        private System.Windows.Forms.TextBox txtBxCustomerEmail;
        private System.Windows.Forms.TextBox txtBxCustomerPhone;
        private System.Windows.Forms.TextBox txtBxCustomerAddress;
        private System.Windows.Forms.TextBox txtBxCustomerName;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProviderSoda;
        private System.Windows.Forms.ErrorProvider errorProviderWater;
    }
}

