using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Cinnabarlab.Data
{
  public static class DataManager
  {
    private static readonly string ConnectionString = @"Data Source=DESKTOP-R8FGPOJ\SQLEXPRESS;Initial Catalog=CinnabarLab;Integrated Security=True";

    public static void QueryTest()
    {
      var con = new SqlConnection(ConnectionString);
      con.Open();
      if (con.State == System.Data.ConnectionState.Open)
      {
        string cmd = "select[count],[value] from test.[values]";
        var command = new SqlCommand(cmd, con);

        using (SqlDataReader reader = command.ExecuteReader())
        {
          while (reader.Read())
          {
            Console.WriteLine($"Count: {reader[0]}, Value: {reader[1]}");
          }
        }
      }
    }
    public static void ProcedureTest()
    {
      var con = new SqlConnection(ConnectionString);
      con.Open();
      if (con.State == System.Data.ConnectionState.Open)
      {
        string proc = "test.p_getTestValueAsJson";
        var command = new SqlCommand(proc, con);

        command.CommandType = System.Data.CommandType.StoredProcedure;

        command.Parameters.AddWithValue("@int", 5);
        command.Parameters.AddWithValue("@message", "from the c#");

        var retParam = new SqlParameter("@json", "");
        retParam.Direction = System.Data.ParameterDirection.Output;
        retParam.Size = -1;
        command.Parameters.Add(retParam);


        command.ExecuteNonQuery();

        var value = (string) command.Parameters["@json"].Value;
        
      }
    }


  }
}
