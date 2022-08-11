using ClothesShopTelegramBot.Db.Table;

namespace ClothesShopTelegramBot.Db;

public class DbManager
{
    private static DbManager _dbManager = null;
    
    public TableTypesClothes TableTypesClothes { private set; get; }
    private DbManager()
    {
        TableTypesClothes = new TableTypesClothes();
    }

    public static DbManager GetInstance()
    {
        if (_dbManager == null)
        {
            _dbManager = new DbManager();
        }

        return _dbManager;
    }
}