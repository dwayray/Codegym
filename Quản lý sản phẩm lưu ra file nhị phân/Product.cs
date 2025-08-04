class Product
{
    public string ProductCode { get; set; }
    public string Name { get; set; }
    public string Manufacturer { get; set; }
    public double Price { get; set; }
    public string Description { get; set; }

    // Xuất thành một dòng để ghi file
    public override string ToString()
    {
        return $"{ProductCode}|{Name}|{Manufacturer}|{Price}|{Description}";
    }

    // Phân tích từ một dòng file
    public static Product FromString(string line)
    {
        string[] parts = line.Split('|');
        if (parts.Length != 5) return null;

        return new Product
        {
            ProductCode = parts[0],
            Name = parts[1],
            Manufacturer = parts[2],
            Price = double.TryParse(parts[3], out double p) ? p : 0,
            Description = parts[4]
        };
    }
}
