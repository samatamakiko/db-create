using Microsoft.IdentityModel.Protocols;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Net.Cache;

class DB
{
    static void Main(string[] args)
    {
        string ID = "";
        string Name = "";
        string Age = "";
        string Prefecture = ";";

        //接続文字列の取得
        var connectionString = "Data Source = LAPTOP-861DHBEM; Initial Catalog = Test-db; Integrated Security = True ;TrustServerCertificate=true;";
        SqlConnection connnection = new SqlConnection(connectionString);

        //DB接続開始
        connnection.Open();

        //実行するSQLの準備
        SqlCommand command = new SqlCommand();
        command.Connection = connnection;
        command.CommandText = @"SELECT * FROM PROFILE_TBL";

        //command.ExecuteNonQuery();
        SqlDataReader reader = command.ExecuteReader();
        
        while (reader.Read())
        {
            ID = reader.GetValue(0).ToString();
            Name = reader.GetValue(1).ToString();
            Age = reader.GetValue(2).ToString();
            Prefecture = reader.GetValue(3).ToString();
            Console.WriteLine(ID + Name + Age + Prefecture);
        }

        string No = "";
        string Ken = "";

        var connectionString2 = "Data Source = LAPTOP-861DHBEM; Initial Catalog = Test-db; Integrated Security = True ;TrustServerCertificate=true;";
        SqlConnection connnection2 = new SqlConnection(connectionString2);

        //DB接続開始
        connnection2.Open();

        //実行するSQLの準備
        SqlCommand command2 = new SqlCommand();
        command2.Connection = connnection2;
        command2.CommandText = @"SELECT * FROM TB_0510";

        //command.ExecuteNonQuery();
        SqlDataReader reader2 = command2.ExecuteReader();

        while (reader2.Read())
        {
            No = reader2.GetValue(0).ToString();
            Ken = reader2.GetValue(1).ToString();
            
            Console.WriteLine(No + Ken);
        }





    }  
}
