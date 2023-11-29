using System.Data.Common;
using System.Data.SqlTypes;
using Npgsql;

namespace sl_app_tp_29112023;

public class Database
{
    private static Database? _instance = null;
    private readonly NpgsqlConnection _connection = new NpgsqlConnection("Host="
                                                                         + Environment.GetEnvironmentVariable("DB_HOSTNAME")
                                                                         + ";Username="
                                                                         + Environment.GetEnvironmentVariable("POSTGRES_USER")
                                                                         + ";Password="
                                                                         + Environment.GetEnvironmentVariable("POSTGRES_PASSWORD")
                                                                         + ";Database="
                                                                         + Environment.GetEnvironmentVariable("POSTGRES_USER"));

    private Database()
    {
    }

    public static Database Instance()
    {
        return _instance ??= new Database();
    }

    public DbDataReader FindObject(string cmd)
    {
        return (new NpgsqlCommand(cmd, _connection).ExecuteReader());
    }
    
    public string FindObjectId(string cmd)
    {
        var obj = new NpgsqlCommand(cmd, _connection).ExecuteScalar();

        return obj?.ToString() ?? throw new InvalidOperationException();
    }

    public int AddObject(string cmd)
    {
        return new NpgsqlCommand(cmd, _connection).ExecuteNonQuery();
    }
}