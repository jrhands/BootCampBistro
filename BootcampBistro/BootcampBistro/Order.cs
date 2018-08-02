namespace BootcampBistro
{
    public class Order
    {
        public Sandwich OrderSandwich;
        public Drink OrderDrink;
        public Chip OrderChip;
        public double Price;

        public Order(Sandwich sandwich)
        {
            OrderSandwich = sandwich;
            OrderDrink = null;
            OrderChip = null;
            Price = sandwich.Price;
        }

        public Order(Drink drink)
        {
            OrderSandwich = null;
            OrderDrink = drink;
            OrderChip = null;
            Price = drink.Price;
        }

        public Order(Chip chip)
        {
            OrderSandwich = null;
            OrderDrink = null;
            OrderChip = chip;
            Price = chip.Price;
        }

        public Order(Sandwich sandwich, Drink drink, Chip chip)
        {
            OrderSandwich = sandwich;
            OrderDrink = drink;
            OrderChip = chip;
            Price = sandwich.Price + drink.Price + chip.Price;
        }
    }
}
