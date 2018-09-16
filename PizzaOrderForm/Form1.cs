using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PizzaOrderForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool CustomerInformationIsValid()
        {
            if (string.IsNullOrWhiteSpace(nameTextBox.Text) ||
                string.IsNullOrWhiteSpace(addressTextBox.Text) ||
                string.IsNullOrWhiteSpace(cityTextBox.Text) ||
                string.IsNullOrWhiteSpace(zipCodeTextBox.Text) ||
                string.IsNullOrWhiteSpace(stateOption.Text) ||
                string.IsNullOrWhiteSpace(phoneNumberTextBox.Text))
            {
                return false;
            }

            return true;
        }

        private bool PaymentInformationIsValid()
        {
            if (string.IsNullOrWhiteSpace(quantityOption.Text) ||
                string.IsNullOrWhiteSpace(paymentOption.Text) ||
                string.IsNullOrWhiteSpace(cardNumberTextBox.Text))
            {
                return false;
            }

            return true;
        }

        private bool ExpiryDateIsValid()
        {
            if (expiryDateOption.Value.Date < DateTime.Now.Date)
            {
                return false;
            }
            return true;
        }

        private float CalculateTotalPrice(List<RadioButton> pizzaSizes, List<CheckBox> toppings, ref int quantity)
        {
            var subTotal = 0f;
            var tax = 0.06f;

            foreach (var size in pizzaSizes)
            {
                if (size.Checked)
                {
                    switch (size.Text)
                    {
                        case "Small":
                            subTotal = 10;
                            break;
                        case "Medium":
                            subTotal = 15;
                            break;
                        case "Large":
                            subTotal = 20;
                            break;
                    }
                }
            }

            foreach (var topping in toppings)
            {
                if (topping.Checked)
                {
                    subTotal += 0.5f;
                }
            }

            return (subTotal * quantity) + (subTotal * quantity * tax);
        }

        private string GetSelectedToppings(List<CheckBox> toppings)
        {
            var selectedToppings = new List<string>();

            foreach (var topping in toppings)
            {
                if (topping.Checked)
                {
                    selectedToppings.Add(topping.Text);
                }
            }

            return string.Join(", ", selectedToppings);
        }

        private string GetPizzaSize(List<RadioButton> pizzaSizes)
        {
            string pizzaSize = "";
            foreach (var size in pizzaSizes)
            {
                if (size.Checked)
                {
                    pizzaSize = size.Text;
                }
            }

            return pizzaSize;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            
            if (!CustomerInformationIsValid())
            {
                MessageBox.Show("You must fill out all fields in 'Customer Information'.");
            }
            else if (!PaymentInformationIsValid())
            {
                MessageBox.Show("You must fill out all fields in 'Payment Information'.");
            }
            else if (!ExpiryDateIsValid())
            {
                MessageBox.Show("Unable to submit order with invalid expiry date.");
            }
            else
            {
                var name = nameTextBox.Text;
                var address = addressTextBox.Text;
                var city = cityTextBox.Text;
                var zipCode = zipCodeTextBox.Text;
                var state = stateOption.Text;
                var phoneNumber = phoneNumberTextBox.Text;

                var pizzaSizes = new List<RadioButton>
                {
                    smallOption,
                    mediumOption,
                    largeOption
                };
                var toppings = new List<CheckBox>
                {
                    pepperoniOption,
                    sausageOption,
                    oliveOption,
                    onionOption,
                    extraCheeseOption
                };

                var quantity = Convert.ToInt32(quantityOption.Text);
                var paymentMethod = paymentOption.Text;
                var cardNumber = cardNumberTextBox.Text;
                var expiryDate = expiryDateOption.Value;

                var totalPrice = CalculateTotalPrice(pizzaSizes, toppings, ref quantity);



                MessageBox.Show($"Name: {name}\n" +
                                $"Address: {address}\n" +
                                $"City: {city}\n" + 
                                $"Zip Code: {zipCode}\n" + 
                                $"State: {state}\n" + 
                                $"Phone Number: {phoneNumber}\n" +
                                "--------------------------------------------------------------------------------------------" +
                                $"Pizza Size: {GetPizzaSize(pizzaSizes)}\n" +
                                $"Selected Toppings: {GetSelectedToppings(toppings)}\n" +
                                "--------------------------------------------------------------------------------------------" +
                                $"Quantity: {quantity}\n" +
                                $"Payment Method: {paymentMethod}\n" +
                                $"Card Number: {cardNumber}\n" +
                                $"Expiry Date: {expiryDate.ToLongDateString()}\n" +
                                "--------------------------------------------------------------------------------------------" + 
                                $"TOTAL: ${totalPrice}", "Order Details");
            }
        }
    }
}
