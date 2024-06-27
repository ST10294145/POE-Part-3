// Storage.cs

namespace Part3
{
    public class Storage
    {
        public string Name { get; set; }
        public string Ingredients { get; set; }
        public string Steps { get; set; }
        public string FoodGroups { get; set; }
        public string Calories { get; set; }

        public Storage()
        {
            Name = "";
            Ingredients = "";
            Steps = "";
            FoodGroups = "";
            Calories = "";
        }
    }
}
