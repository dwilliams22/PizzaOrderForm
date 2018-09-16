namespace PizzaOrderForm
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.customerInformationGroupBox = new System.Windows.Forms.GroupBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.stateOption = new System.Windows.Forms.ComboBox();
            this.stateLabel = new System.Windows.Forms.Label();
            this.zipCodeTextBox = new System.Windows.Forms.TextBox();
            this.zipCodeLabel = new System.Windows.Forms.Label();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.paymentInformationGroupBox = new System.Windows.Forms.GroupBox();
            this.expiryDateOption = new System.Windows.Forms.DateTimePicker();
            this.expiryDateLabel = new System.Windows.Forms.Label();
            this.cardNumberTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.paymentOption = new System.Windows.Forms.ComboBox();
            this.paymentMethodLabel = new System.Windows.Forms.Label();
            this.quantityOption = new System.Windows.Forms.ComboBox();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.pizzaSizeGroupBox = new System.Windows.Forms.GroupBox();
            this.largeOption = new System.Windows.Forms.RadioButton();
            this.mediumOption = new System.Windows.Forms.RadioButton();
            this.smallOption = new System.Windows.Forms.RadioButton();
            this.toppingsGroupBox = new System.Windows.Forms.GroupBox();
            this.extraCheeseOption = new System.Windows.Forms.CheckBox();
            this.onionOption = new System.Windows.Forms.CheckBox();
            this.oliveOption = new System.Windows.Forms.CheckBox();
            this.sausageOption = new System.Windows.Forms.CheckBox();
            this.pepperoniOption = new System.Windows.Forms.CheckBox();
            this.toppingsLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.customerInformationGroupBox.SuspendLayout();
            this.paymentInformationGroupBox.SuspendLayout();
            this.pizzaSizeGroupBox.SuspendLayout();
            this.toppingsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // customerInformationGroupBox
            // 
            this.customerInformationGroupBox.Controls.Add(this.phoneNumberTextBox);
            this.customerInformationGroupBox.Controls.Add(this.phoneLabel);
            this.customerInformationGroupBox.Controls.Add(this.stateOption);
            this.customerInformationGroupBox.Controls.Add(this.stateLabel);
            this.customerInformationGroupBox.Controls.Add(this.zipCodeTextBox);
            this.customerInformationGroupBox.Controls.Add(this.zipCodeLabel);
            this.customerInformationGroupBox.Controls.Add(this.cityTextBox);
            this.customerInformationGroupBox.Controls.Add(this.cityLabel);
            this.customerInformationGroupBox.Controls.Add(this.addressTextBox);
            this.customerInformationGroupBox.Controls.Add(this.addressLabel);
            this.customerInformationGroupBox.Controls.Add(this.nameTextBox);
            this.customerInformationGroupBox.Controls.Add(this.nameLabel);
            this.customerInformationGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerInformationGroupBox.Location = new System.Drawing.Point(93, 38);
            this.customerInformationGroupBox.Name = "customerInformationGroupBox";
            this.customerInformationGroupBox.Size = new System.Drawing.Size(534, 382);
            this.customerInformationGroupBox.TabIndex = 0;
            this.customerInformationGroupBox.TabStop = false;
            this.customerInformationGroupBox.Text = "Customer Information";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(34, 304);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(92, 31);
            this.phoneLabel.TabIndex = 10;
            this.phoneLabel.Text = "Phone";
            // 
            // stateOption
            // 
            this.stateOption.FormattingEnabled = true;
            this.stateOption.Items.AddRange(new object[] {
            "Alabama",
            "Alaska",
            "Arizona",
            "Arkansas",
            "California",
            "Colorado",
            "Connecticut",
            "Delaware",
            "Florida",
            "Georgia",
            "Hawaii",
            "Idaho",
            "Illinois",
            "Indiana",
            "Iowa",
            "Kansas",
            "Kentucky",
            "Louisiana",
            "Maine",
            "Maryland",
            "Massachusetts",
            "Michigan",
            "Minnesota",
            "Mississippi",
            "Missouri",
            "Montana",
            "Nebraska",
            "Nevada",
            "New Hampshire",
            "New Jersey",
            "New Mexico",
            "New York",
            "North Carolina",
            "North Dakota",
            "Ohio",
            "Oklahoma",
            "Oregon",
            "Pennsylvania",
            "Rhode Island",
            "South Carolina",
            "South Dakota",
            "Tennessee",
            "Texas",
            "Utah",
            "Vermont",
            "Virginia",
            "Washington",
            "West Virginia",
            "Wisconsin",
            "Wyoming"});
            this.stateOption.Location = new System.Drawing.Point(158, 251);
            this.stateOption.Name = "stateOption";
            this.stateOption.Size = new System.Drawing.Size(266, 39);
            this.stateOption.TabIndex = 9;
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Location = new System.Drawing.Point(34, 254);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(78, 31);
            this.stateLabel.TabIndex = 8;
            this.stateLabel.Text = "State";
            // 
            // zipCodeTextBox
            // 
            this.zipCodeTextBox.Location = new System.Drawing.Point(158, 202);
            this.zipCodeTextBox.Name = "zipCodeTextBox";
            this.zipCodeTextBox.Size = new System.Drawing.Size(314, 38);
            this.zipCodeTextBox.TabIndex = 7;
            // 
            // zipCodeLabel
            // 
            this.zipCodeLabel.AutoSize = true;
            this.zipCodeLabel.Location = new System.Drawing.Point(34, 205);
            this.zipCodeLabel.Name = "zipCodeLabel";
            this.zipCodeLabel.Size = new System.Drawing.Size(124, 31);
            this.zipCodeLabel.TabIndex = 6;
            this.zipCodeLabel.Text = "Zip Code";
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(158, 154);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(314, 38);
            this.cityTextBox.TabIndex = 5;
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(34, 157);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(62, 31);
            this.cityLabel.TabIndex = 4;
            this.cityLabel.Text = "City";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(158, 106);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(314, 38);
            this.addressTextBox.TabIndex = 3;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(34, 106);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(114, 31);
            this.addressLabel.TabIndex = 2;
            this.addressLabel.Text = "Address";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(158, 59);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(314, 38);
            this.nameTextBox.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(34, 62);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(86, 31);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // paymentInformationGroupBox
            // 
            this.paymentInformationGroupBox.BackColor = System.Drawing.Color.Gray;
            this.paymentInformationGroupBox.Controls.Add(this.expiryDateOption);
            this.paymentInformationGroupBox.Controls.Add(this.expiryDateLabel);
            this.paymentInformationGroupBox.Controls.Add(this.cardNumberTextBox);
            this.paymentInformationGroupBox.Controls.Add(this.label1);
            this.paymentInformationGroupBox.Controls.Add(this.paymentOption);
            this.paymentInformationGroupBox.Controls.Add(this.paymentMethodLabel);
            this.paymentInformationGroupBox.Controls.Add(this.quantityOption);
            this.paymentInformationGroupBox.Controls.Add(this.quantityLabel);
            this.paymentInformationGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentInformationGroupBox.Location = new System.Drawing.Point(703, 402);
            this.paymentInformationGroupBox.Name = "paymentInformationGroupBox";
            this.paymentInformationGroupBox.Size = new System.Drawing.Size(534, 340);
            this.paymentInformationGroupBox.TabIndex = 3;
            this.paymentInformationGroupBox.TabStop = false;
            this.paymentInformationGroupBox.Text = "Payment Information";
            // 
            // expiryDateOption
            // 
            this.expiryDateOption.Location = new System.Drawing.Point(179, 264);
            this.expiryDateOption.Name = "expiryDateOption";
            this.expiryDateOption.Size = new System.Drawing.Size(340, 38);
            this.expiryDateOption.TabIndex = 7;
            // 
            // expiryDateLabel
            // 
            this.expiryDateLabel.AutoSize = true;
            this.expiryDateLabel.Location = new System.Drawing.Point(19, 270);
            this.expiryDateLabel.Name = "expiryDateLabel";
            this.expiryDateLabel.Size = new System.Drawing.Size(154, 31);
            this.expiryDateLabel.TabIndex = 6;
            this.expiryDateLabel.Text = "Expiry Date";
            // 
            // cardNumberTextBox
            // 
            this.cardNumberTextBox.Location = new System.Drawing.Point(266, 197);
            this.cardNumberTextBox.Name = "cardNumberTextBox";
            this.cardNumberTextBox.Size = new System.Drawing.Size(253, 38);
            this.cardNumberTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Debit/Credit Card #";
            // 
            // paymentOption
            // 
            this.paymentOption.FormattingEnabled = true;
            this.paymentOption.Items.AddRange(new object[] {
            "Cash",
            "Debit/Credit"});
            this.paymentOption.Location = new System.Drawing.Point(237, 125);
            this.paymentOption.Name = "paymentOption";
            this.paymentOption.Size = new System.Drawing.Size(199, 39);
            this.paymentOption.TabIndex = 3;
            // 
            // paymentMethodLabel
            // 
            this.paymentMethodLabel.AutoSize = true;
            this.paymentMethodLabel.Location = new System.Drawing.Point(13, 128);
            this.paymentMethodLabel.Name = "paymentMethodLabel";
            this.paymentMethodLabel.Size = new System.Drawing.Size(218, 31);
            this.paymentMethodLabel.TabIndex = 2;
            this.paymentMethodLabel.Text = "Payment Method";
            // 
            // quantityOption
            // 
            this.quantityOption.FormattingEnabled = true;
            this.quantityOption.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.quantityOption.Location = new System.Drawing.Point(135, 55);
            this.quantityOption.Name = "quantityOption";
            this.quantityOption.Size = new System.Drawing.Size(86, 39);
            this.quantityOption.TabIndex = 1;
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(13, 58);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(116, 31);
            this.quantityLabel.TabIndex = 0;
            this.quantityLabel.Text = "Quantity";
            // 
            // pizzaSizeGroupBox
            // 
            this.pizzaSizeGroupBox.Controls.Add(this.largeOption);
            this.pizzaSizeGroupBox.Controls.Add(this.mediumOption);
            this.pizzaSizeGroupBox.Controls.Add(this.smallOption);
            this.pizzaSizeGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pizzaSizeGroupBox.Location = new System.Drawing.Point(739, 88);
            this.pizzaSizeGroupBox.Name = "pizzaSizeGroupBox";
            this.pizzaSizeGroupBox.Size = new System.Drawing.Size(462, 125);
            this.pizzaSizeGroupBox.TabIndex = 0;
            this.pizzaSizeGroupBox.TabStop = false;
            this.pizzaSizeGroupBox.Text = "Pizza Size";
            // 
            // largeOption
            // 
            this.largeOption.AutoSize = true;
            this.largeOption.Location = new System.Drawing.Point(326, 56);
            this.largeOption.Name = "largeOption";
            this.largeOption.Size = new System.Drawing.Size(114, 35);
            this.largeOption.TabIndex = 2;
            this.largeOption.TabStop = true;
            this.largeOption.Text = "Large";
            this.largeOption.UseVisualStyleBackColor = true;
            // 
            // mediumOption
            // 
            this.mediumOption.AutoSize = true;
            this.mediumOption.Location = new System.Drawing.Point(164, 56);
            this.mediumOption.Name = "mediumOption";
            this.mediumOption.Size = new System.Drawing.Size(140, 35);
            this.mediumOption.TabIndex = 1;
            this.mediumOption.TabStop = true;
            this.mediumOption.Text = "Medium";
            this.mediumOption.UseVisualStyleBackColor = true;
            // 
            // smallOption
            // 
            this.smallOption.AutoSize = true;
            this.smallOption.Location = new System.Drawing.Point(26, 56);
            this.smallOption.Name = "smallOption";
            this.smallOption.Size = new System.Drawing.Size(112, 35);
            this.smallOption.TabIndex = 0;
            this.smallOption.TabStop = true;
            this.smallOption.Text = "Small";
            this.smallOption.UseVisualStyleBackColor = true;
            // 
            // toppingsGroupBox
            // 
            this.toppingsGroupBox.Controls.Add(this.extraCheeseOption);
            this.toppingsGroupBox.Controls.Add(this.onionOption);
            this.toppingsGroupBox.Controls.Add(this.oliveOption);
            this.toppingsGroupBox.Controls.Add(this.sausageOption);
            this.toppingsGroupBox.Controls.Add(this.pepperoniOption);
            this.toppingsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toppingsGroupBox.Location = new System.Drawing.Point(739, 230);
            this.toppingsGroupBox.Name = "toppingsGroupBox";
            this.toppingsGroupBox.Size = new System.Drawing.Size(462, 130);
            this.toppingsGroupBox.TabIndex = 4;
            this.toppingsGroupBox.TabStop = false;
            this.toppingsGroupBox.Text = "Toppings (+50¢ each)";
            // 
            // extraCheeseOption
            // 
            this.extraCheeseOption.AutoSize = true;
            this.extraCheeseOption.Location = new System.Drawing.Point(210, 79);
            this.extraCheeseOption.Name = "extraCheeseOption";
            this.extraCheeseOption.Size = new System.Drawing.Size(210, 35);
            this.extraCheeseOption.TabIndex = 4;
            this.extraCheeseOption.Text = "Extra Cheese";
            this.extraCheeseOption.UseVisualStyleBackColor = true;
            // 
            // onionOption
            // 
            this.onionOption.AutoSize = true;
            this.onionOption.Location = new System.Drawing.Point(59, 79);
            this.onionOption.Name = "onionOption";
            this.onionOption.Size = new System.Drawing.Size(132, 35);
            this.onionOption.TabIndex = 3;
            this.onionOption.Text = "Onions";
            this.onionOption.UseVisualStyleBackColor = true;
            // 
            // oliveOption
            // 
            this.oliveOption.AutoSize = true;
            this.oliveOption.Location = new System.Drawing.Point(348, 37);
            this.oliveOption.Name = "oliveOption";
            this.oliveOption.Size = new System.Drawing.Size(108, 35);
            this.oliveOption.TabIndex = 2;
            this.oliveOption.Text = "Olive";
            this.oliveOption.UseVisualStyleBackColor = true;
            // 
            // sausageOption
            // 
            this.sausageOption.AutoSize = true;
            this.sausageOption.Location = new System.Drawing.Point(191, 37);
            this.sausageOption.Name = "sausageOption";
            this.sausageOption.Size = new System.Drawing.Size(153, 35);
            this.sausageOption.TabIndex = 1;
            this.sausageOption.Text = "Sausage";
            this.sausageOption.UseVisualStyleBackColor = true;
            // 
            // pepperoniOption
            // 
            this.pepperoniOption.AutoSize = true;
            this.pepperoniOption.Location = new System.Drawing.Point(16, 38);
            this.pepperoniOption.Name = "pepperoniOption";
            this.pepperoniOption.Size = new System.Drawing.Size(169, 35);
            this.pepperoniOption.TabIndex = 0;
            this.pepperoniOption.Text = "Pepperoni";
            this.pepperoniOption.UseVisualStyleBackColor = true;
            // 
            // toppingsLabel
            // 
            this.toppingsLabel.AutoSize = true;
            this.toppingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toppingsLabel.Location = new System.Drawing.Point(893, 38);
            this.toppingsLabel.Name = "toppingsLabel";
            this.toppingsLabel.Size = new System.Drawing.Size(150, 37);
            this.toppingsLabel.TabIndex = 5;
            this.toppingsLabel.Text = "Toppings";
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.Red;
            this.exitButton.Location = new System.Drawing.Point(1065, 762);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(172, 52);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.ForeColor = System.Drawing.Color.Green;
            this.submitButton.Location = new System.Drawing.Point(703, 762);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(255, 52);
            this.submitButton.TabIndex = 7;
            this.submitButton.Text = "Submit Order";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Location = new System.Drawing.Point(158, 301);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(314, 38);
            this.phoneNumberTextBox.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(209, 504);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(446, 310);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1326, 836);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.toppingsLabel);
            this.Controls.Add(this.toppingsGroupBox);
            this.Controls.Add(this.pizzaSizeGroupBox);
            this.Controls.Add(this.paymentInformationGroupBox);
            this.Controls.Add(this.customerInformationGroupBox);
            this.Name = "Form1";
            this.Text = "Pizza Order Form";
            this.customerInformationGroupBox.ResumeLayout(false);
            this.customerInformationGroupBox.PerformLayout();
            this.paymentInformationGroupBox.ResumeLayout(false);
            this.paymentInformationGroupBox.PerformLayout();
            this.pizzaSizeGroupBox.ResumeLayout(false);
            this.pizzaSizeGroupBox.PerformLayout();
            this.toppingsGroupBox.ResumeLayout(false);
            this.toppingsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox customerInformationGroupBox;
        private System.Windows.Forms.ComboBox stateOption;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.TextBox zipCodeTextBox;
        private System.Windows.Forms.Label zipCodeLabel;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.GroupBox paymentInformationGroupBox;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.GroupBox pizzaSizeGroupBox;
        private System.Windows.Forms.GroupBox toppingsGroupBox;
        private System.Windows.Forms.RadioButton largeOption;
        private System.Windows.Forms.RadioButton mediumOption;
        private System.Windows.Forms.RadioButton smallOption;
        private System.Windows.Forms.Label toppingsLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.CheckBox extraCheeseOption;
        private System.Windows.Forms.CheckBox onionOption;
        private System.Windows.Forms.CheckBox oliveOption;
        private System.Windows.Forms.CheckBox sausageOption;
        private System.Windows.Forms.CheckBox pepperoniOption;
        private System.Windows.Forms.DateTimePicker expiryDateOption;
        private System.Windows.Forms.Label expiryDateLabel;
        private System.Windows.Forms.TextBox cardNumberTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox paymentOption;
        private System.Windows.Forms.Label paymentMethodLabel;
        private System.Windows.Forms.ComboBox quantityOption;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

