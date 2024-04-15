namespace BaseWeb.API.Entities.Interfaces
{
    interface IProduct
    {
        int id { get; set; }
        string description { get; set; }
        string name { get; set; }
        string imageName { get; set; }
        string category { get; set; }
        double price { get; set; }
        double discount { get; set; }
    }
}
