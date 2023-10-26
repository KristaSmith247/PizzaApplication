/* PizzaGUI.cs
 * Author: Krista Smith
 * Date: 10/23/23
 * Description: This file will detail the actions taken when a user interacts with 
 * the order GUI.
 */

using System;
using System.Windows.Forms;

namespace PizzaApp
{
    public partial class PizzaGUI : Form
    {
        private PizzaOrder newOrder;
        
        public PizzaGUI()
        {
            InitializeComponent();
        }

        // events enacted when loading form
        private void PizzaGUI_Load(object sender, EventArgs e)
        {
            // create a new order when the form loads
            newOrder = new PizzaOrder();

            // fill lstBxToppings with the items inside the topping array
            for (int i = 0; i < newOrder.Topping.Length; i++)
            {
                lstBxToppings.Items.Add(newOrder.topping[i]);
            }
        }

        // pizza events
        private void CbxSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            // allow user to select size of pizza
            newOrder.Size = CbxSize.Text;
        }


        private void CbxCrust_SelectedIndexChanged(object sender, EventArgs e)
        {
            // allow user to select crust of pizza
            newOrder.Crust = CbxCrust.Text;
        }

        private void CbxSauce_SelectedIndexChanged(object sender, EventArgs e)
        {
            // sauce selection
            newOrder.Sauce = CbxSauce.Text;
        }

        private void CbxSpecialtyPizza_SelectedIndexChanged(object sender, EventArgs e)
        {
            // specialty pizza selection
            newOrder.SpecialtyPizza = CbxSpecialtyPizza.Text;

        }

        private void lstBxToppings_SelectedIndexChanged(object sender, EventArgs e)
        {
            // topping amount = number of selected items in list box
            newOrder.ToppingAmount = lstBxToppings.SelectedItems.Count;
            
        }


        // drink events
        private void txtBxSoda_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtBxSoda.Text, out int SodaAmount))
            {
                // if user input can successfully be parsed: set to soda amount
                newOrder.SodaAmount = SodaAmount;
            }
            else
            {
                newOrder.SodaAmount = 0;
            }
        }

        private void txtBxWater_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtBxWater.Text, out int WaterAmount))
            {
                // if user input can successfully be parsed: set to water amount
                newOrder.WaterAmount = WaterAmount;
            }
            else
            {
                newOrder.WaterAmount = 0;
            }
        }


        // side events

        private void CbxSides_SelectedIndexChanged(object sender, EventArgs e)
        {
            // allow user to select a side
            newOrder.Side = CbxSides.Text;
        }


        // accepting customer information
        private void txtBxCustomerName_TextChanged(object sender, EventArgs e)
        {
            // user enters order name
            newOrder.CustomerName = txtBxCustomerName.Text;
        }

        private void txtBxCustomerAddress_TextChanged(object sender, EventArgs e)
        {
            newOrder.Address = txtBxCustomerAddress.Text;
        }

        private void txtBxCustomerPhone_TextChanged(object sender, EventArgs e)
        {
            newOrder.Phone = txtBxCustomerPhone.Text;
        }

        private void txtBxCustomerEmail_TextChanged(object sender, EventArgs e)
        {
            newOrder.Email = txtBxCustomerEmail.Text;
        }


        // placing and resetting order
        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            // place user order when "Place Order" button clicked
            // show prices, items ordered, and customer information
            MessageBox.Show("Pizza: " +
                "\n" + newOrder.Size + "\n" + newOrder.Crust + "\n" +
                newOrder.Sauce + "\n" + newOrder.SpecialtyPizza + 
                "\nToppings: $1.50 each\n\n" +
                "Drinks: " + newOrder.GetDrinkPrice().ToString("C") + "\n" +
                "Sodas ordered: " + newOrder.SodaAmount + "\n" +
                "Waters ordered: " + newOrder.WaterAmount + "\n\n" + "Side: " +
                 "\n" + newOrder.Side + "\n"
                + "\n\nTotal Due: " + newOrder.CalculateTotalPrice().ToString("C") 
                + "\n\n" + "Customer Information:\n" +
                newOrder.CustomerName + "\n" +
                newOrder.Address + "\n" +
                newOrder.Phone + "\n" + newOrder.Email);

        }

        private void btnResetOrder_Click(object sender, EventArgs e)
        {
            // reset pizza info
            lstBxToppings.ClearSelected();
            newOrder.Crust = "";
            newOrder.Sauce = "";
            newOrder.Size = "";
            newOrder.SpecialtyPizza = "";
            newOrder.ToppingAmount = 0;
            CbxCrust.SelectedIndex = -1;
            CbxSauce.SelectedIndex = -1;
            CbxSpecialtyPizza.SelectedIndex = -1;
            CbxSize.SelectedIndex = -1;

            // reset side info
            newOrder.Side = "";
            CbxSides.SelectedIndex = -1;
            

            // reset drink info
            newOrder.SodaAmount = 0;
            newOrder.WaterAmount = 0;
            txtBxSoda.Clear();
            txtBxWater.Clear();

            // reset customer info
            newOrder.CustomerName = "";
            newOrder.Address = "";
            newOrder.Phone = "";
            newOrder.Email = "";
            txtBxCustomerName.Clear();
            txtBxCustomerAddress.Clear();
            txtBxCustomerPhone.Clear();
            txtBxCustomerEmail.Clear();

            // reset price info
            newOrder.SizePrice = 0;
            newOrder.DrinkPrice = 0;
            newOrder.SidePrice = 0;

        }

        // validate input

        private void txtBxSoda_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtBxSoda.Text != "")
            {
                try
                {
                    int SodaAmount = Int32.Parse(txtBxSoda.Text);
                    errorProviderSoda.SetError(txtBxSoda, "");
                }
                catch
                {
                    errorProviderSoda.SetError(txtBxSoda, "You entered an invalid amount of sodas.");
                }
            }
        }

        private void txtBxWater_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtBxWater.Text != "")
            {
                try
                {
                    int SodaAmount = Int32.Parse(txtBxWater.Text);
                    errorProviderWater.SetError(txtBxWater, "");
                }
                catch
                {
                    errorProviderWater.SetError(txtBxWater, "You entered an invalid amount of waters.");
                }
            }
        }
    }
}
