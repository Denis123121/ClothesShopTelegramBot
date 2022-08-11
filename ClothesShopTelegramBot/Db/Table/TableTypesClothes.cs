using ClothesShopTelegramBot.Db.Connection;
using ClothesShopTelegramBot.Db.Model;

namespace ClothesShopTelegramBot.Db.Table;
using  Npgsql;

public class TableTypesClothes
{
    private NpgsqlConnection _connection;

    public TableTypesClothes()
    {
        _connection = DbConnector.GetConnection();
    }

    public List<TypeClothes> GetAllTypesClothes()
    {
        List<TypeClothes> typesClothes = new List<TypeClothes>();

        string sqlRequest = "SELECT * FROM types_clothes";
        NpgsqlCommand command = new NpgsqlCommand(sqlRequest, _connection);

        NpgsqlDataReader dataReader = command.ExecuteReader();
        while (dataReader.Read())
        {
            int id = dataReader.GetInt32(dataReader.GetOrdinal("id"));
            string name = dataReader.GetString(dataReader.GetOrdinal("name"));

            TypeClothes typeClothes = new TypeClothes()
            {
                Id = id,
                Name = name
            };

            typesClothes.Add(typeClothes);
        }

        return typesClothes;
    }
}