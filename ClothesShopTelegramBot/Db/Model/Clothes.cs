namespace ClothesShopTelegramBot.Db.Model;

public class Clothes
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Price { get; set; }
    public string TypeClothesId { get; set; }
}