namespace BootcampBistro
{
    public class MenuItem
    {
        public string Name;
        public double Price;

        public MenuItem(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public string GetData()
        {
            return ($"{Name} {Price:C}");
        }
    }
}
