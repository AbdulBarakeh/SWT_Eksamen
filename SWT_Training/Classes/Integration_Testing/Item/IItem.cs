namespace Classes.Integration_Testing.Item
{
    public interface IItem
    {
        string Name { get; set; }
        double Price { get; set; }
        int Barcode { get; set; }
    }
}