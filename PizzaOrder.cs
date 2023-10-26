/* PizzaOrder.cs
 * Author: Krista Smith
 * Date: 10/21/23
 * Description: The file will define a PizzaOrder object. The pizza order will
 * include information about possible toppings, prices, drinks, and other extra
 * items a customer may order.
 */
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PizzaApp
{
    public class PizzaOrder
    {
        public string[] topping =
        {
            // an array containing pizza toppings a customer may order
            "Pepperoni", "Extra Cheese", "Onions", "Garlic",
            "Green Peppers", "Olives", "Mushroom", "Bacon",
            "Sausage", "Tomato", "Parmesan", "Anchovies",
            "Ham", "Chicken", "Banana Pepper", "Spinach"
        };

        // pizzas
        public string Topping { get; set; }
        public int ToppingAmount { get; set; }
        public string Size { get; set; }
        public string Crust { get; set; }
        public string Sauce { get; set; }
        public string SpecialtyPizza { get; set; }

        // sides
        public string Side { get; set; }

        // drinks
        public int SodaAmount { get; set; }
        public int WaterAmount { get; set; }

        // prices

        public decimal ToppingPrice { get; set; }
        public decimal SizePrice { get; set; }
        public decimal DrinkPrice { get; set; }
        public decimal SidePrice { get; set; }


        // customer information
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public PizzaOrder()
        {
            // initialize a pizza order, including pizza, drinks, sides,
            //  prices and customer info

            // pizza
            Topping = string.Empty; // selected toppings
            ToppingAmount = 0; // amount of toppings
            SpecialtyPizza = string.Empty; // specialty pizza name
            Crust = string.Empty; // crust type
            Sauce = string.Empty; // sauce type
            Size = string.Empty; // size of pizza

            // side
            Side = string.Empty;

            // drinks
            SodaAmount = 0; // amount of sodas ordered
            WaterAmount = 0;  // amount of waters ordered

            // prices
            ToppingPrice = 0; // price of toppings
            SizePrice = 0; // pizza size price
            SidePrice = 0; // price of side
            DrinkPrice = 0; // price of ordered drinks

            // customer info
            CustomerName = string.Empty;
            Address = string.Empty;
            Phone = string.Empty;
            Email = string.Empty;
        }

        // Functions to calculate price and format output

        public decimal GetPizzaPrice() {
            // calculate pizza price - size, toppings relevant to price
            // sauce, crust, specialty pizza make no difference to price
            switch (Size)
            {
                // determine price based on size
                case "Small(10\") - $9.95":
                    SizePrice = 9.95m;
                    break;
                case "Medium(12\") - $12.95":
                    SizePrice = 12.95m;
                    break;
                case "Large(16\") - $15.95":
                    SizePrice = 15.95m;
                    break;
            }
            // determine total amount for toppings
            ToppingPrice = ToppingAmount * 1.50m;

            return SizePrice + ToppingPrice;
        }

        public decimal GetDrinkPrice()
        {
            // set price of drinks
            // soda is $1.75, water is free
            return SodaAmount * 1.75m;
        }

        public decimal GetSidePrice()
        {
            // calculate price of side dish
            switch (Side)
            {
                case "Cheese Bread - $1.00":
                    SidePrice = 1.00m;
                    break;
                case "Cinnamon Breadsticks - $1.50":
                    SidePrice = 1.50m;
                    break;
                case "Cheese Dip - $1.75":
                    SidePrice = 1.75m;
                    break;
                case "Lava Cakes - $2.00":
                    SidePrice = 2.00m;
                    break;
            }
            return SidePrice;
        }

        public decimal CalculateTotalPrice()
        {
            // calculate total order cost
            // pizza + sides + drinks
            decimal PizzaPrice = GetPizzaPrice();
            SidePrice = GetSidePrice();
            DrinkPrice = GetDrinkPrice();
            return DrinkPrice + PizzaPrice + SidePrice;
        }

        public override string ToString()
        {
            return "Total Due: " + CalculateTotalPrice().ToString("C");
        }
    }
}
