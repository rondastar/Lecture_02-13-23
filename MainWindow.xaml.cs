using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
// Ronda Rutherford
// Lecture Notes - radio and checkboxes
// 02-13-23
namespace Lecture_02_13_23
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Preload();
        }
        private void Preload()
        {
            rbSmall.IsChecked = true;
            rbSmallDrink.IsChecked = true;
        }

        //private void btnShowCheckBoxResult_Click(object sender, RoutedEventArgs e)
        //{
        //    bool isChecked = ckfirstCheckBox.IsChecked.Value; // bool? means the bool is nullable
        //}

        private void btnOrderPizza_Click(object sender, RoutedEventArgs e)
        {
            double amount = 0;

            bool hasPepperoni = ckPepperoni.IsChecked.Value;
            bool hasCheese = ckCheese.IsChecked.Value;
            bool hasMushrooms = ckMushrooms.IsChecked.Value;
            bool hasPineapple = ckPineapple.IsChecked.Value;
            bool hasGreenPeppers = ckGreenPeppers.IsChecked.Value;

            bool isSmall = rbSmall.IsChecked.Value;
            bool isMedium = rbMedium.IsChecked.Value;
            bool isLarge = rbLarge.IsChecked.Value;
            bool isExtraLarge = rbExtraLarge.IsChecked.Value;

            bool isSmallDrink = rbSmallDrink.IsChecked.Value;
            bool isMediumDrink = rbMediumDrink.IsChecked.Value;
            bool isLargeDrink = rbLargeDrink.IsChecked.Value;
            bool isExtraLargeDrink = rbExtraLargeDrink.IsChecked.Value;

            // Customer Name
            runReceipt.Text += $"Customer Name: {txtCustomerName.Text}\n";

            // Pizza Size
            runReceipt.Text += "\nPizza Size:\n";
            double pizzaPrice = 0;

            if (isSmall)
            {
                runReceipt.Text += "Small";
                pizzaPrice = 12;
            }
            else if (isMedium)
            {
                runReceipt.Text += "Medium";
                pizzaPrice = 15;
            }
            else if (isLarge)
            {
                runReceipt.Text += "Large";
                pizzaPrice = 18;
            }
            else if (isExtraLarge)
            {
                runReceipt.Text += "Extra Large";
                pizzaPrice = 20;
            }
            else
            {
                MessageBox.Show("Please select a size.");
            }
            amount += pizzaPrice;
            runReceipt.Text += $" - { pizzaPrice.ToString("c")}\n";

            // Pizza Toppings

            double pepperoniPrice = 4;
            double cheesePrice = 5;
            double mushroomsPrice = 2;
            double pineapplePrice = 20;
            double greenPepperPrice = 2;

            runReceipt.Text += "\nPizza Toppings:\n";
            double toppingsPrice = 0;

            if (hasPepperoni == true)
            {
                runReceipt.Text += $"Pepperoni - {pepperoniPrice.ToString("c")}\n";
                toppingsPrice += pepperoniPrice;
            }


            if (hasCheese)
            {
                runReceipt.Text += $"Cheese - {cheesePrice.ToString("c")}\n";
                toppingsPrice += cheesePrice;
            }

            if (hasMushrooms)
            {
                runReceipt.Text += $"Mushrooms - {mushroomsPrice.ToString("c")}\n";
                toppingsPrice += mushroomsPrice;
            }

            if (hasPineapple)
            {
                runReceipt.Text += $"Pineapple - {pineapplePrice.ToString("c")}\n";
                toppingsPrice += pineapplePrice;
            }

            if (hasGreenPeppers)
            {
                runReceipt.Text += $"Green Peppers - {greenPepperPrice.ToString("c")}\n";
                toppingsPrice += greenPepperPrice;
            }
            
            if (toppingsPrice == 0)
            {
                runReceipt.Text += "None\n";
            }
            amount += toppingsPrice;

            // Drink Size
            double smallDrinkPrice = 2;
            double mediumDrinkPrice = 2.69;
            double largeDrinkPrice = 3.25;
            double extraLargeDrinkPrice = 7.50;


            runReceipt.Text += "\nDrink Size:\n";

            if (isSmallDrink)
            {
                runReceipt.Text += $"Small - {smallDrinkPrice.ToString("c")}\n";
                amount += smallDrinkPrice;
            }
            else if (isMediumDrink)
            {
                runReceipt.Text += $"Medium - {mediumDrinkPrice.ToString("c")}\n";
                amount += mediumDrinkPrice;
            }
            else if (isLargeDrink)
            {
                runReceipt.Text += $"Large - {largeDrinkPrice.ToString("c")}\n";
                amount += largeDrinkPrice;
            }
            else if (isExtraLargeDrink)
            {
                runReceipt.Text += $"Extra Large - {extraLargeDrinkPrice.ToString("c")}\n";
                amount += extraLargeDrinkPrice;
            }
            else
            {
                MessageBox.Show("Please select a drink size.");
            }
            // Total Cost
            double taxRate = .1;
            double calculatedTax = amount * taxRate;
            double totalCost = amount + calculatedTax;

            runReceipt.Text += $"\nSubtotal: {amount.ToString("c")}\n" +
                $"Tax: {calculatedTax.ToString("c")}\n" +
                $"Total: {totalCost.ToString("c")}";






        }
    }
} // namespace
    //// HW Questions
    //// Check boxes and radio buttons both return a type of bool
    //How what property do you use to get the true / false value from your individual check boxes / radio buttons
    // IsChecked.Value
    //When using check boxes you need to use an if statement for each check box
    //When working with radio buttons you need an if / else if / else structure
    //You need to group together radio buttons, otherwise they may not work properly
    //You can use a canvas layout to accomplish this
