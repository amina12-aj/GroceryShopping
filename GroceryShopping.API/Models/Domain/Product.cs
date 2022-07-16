namespace GroceryShopping.API.Models.Domain
{
    public class Product
    {

        public int Id { get; set; }
        public string ProductName { get; set; }
        public short QuantityInPackage { get; set; }
        public string UnitOfMeasurement { get; set; }

        public int CategoryId { get; set; }
        public Category category { get; set; }
    }
}

public enum UnitOfMeasurement : byte
{
    [Description("UN")]
    Unity = 1,

    [Description("MG")]
    Milligram = 2,

    [Description("G")]
    Gram = 3,

    [Description("KG")]
    Kilogram = 4,

    [Description("L")]
    Liter = 5
}
}
}

