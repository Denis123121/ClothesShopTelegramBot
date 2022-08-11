using ClothesShopTelegramBot.Db.Model;
using ClothesShopTelegramBot.Db;

DbManager dbManager = DbManager.GetInstance();

List<TypeClothes> typesClothes = dbManager.TableTypesClothes.GetAllTypesClothes();

foreach (TypeClothes typeClothes in typesClothes)
{
    Console.WriteLine($"id:{typeClothes.Id} name:{typeClothes.Name}");
}