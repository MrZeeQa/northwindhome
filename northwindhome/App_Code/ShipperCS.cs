using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Text;
/// <summary>
/// Summary description for ShipperCS
/// </summary>
public class ShipperCS
{

        //
        // TODO: Add constructor logic here
        //
        public void InsertNewShipper(string CompanyName, string CompanyTelephoneNumber)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "Northwind_InsertNewShipper2016";
            SqlParameter ParamCompanyName = new SqlParameter("@CompanyName",
            SqlDbType.NVarChar, 40);
            ParamCompanyName.Value = CompanyName;
            ParamCompanyName.Direction = ParameterDirection.Input;
            command.Parameters.Add(ParamCompanyName);
            SqlParameter ParamTelephoneNumber = new SqlParameter("@CompanyTelephoneNumber",
            SqlDbType.NVarChar, 24);
            ParamTelephoneNumber.Value = CompanyTelephoneNumber;
            ParamTelephoneNumber.Direction = ParameterDirection.Input;
            command.Parameters.Add(ParamTelephoneNumber);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public SqlDataReader GetShippers()
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        SqlCommand command = new SqlCommand();
        command.Connection = connection;
        command.CommandType = CommandType.StoredProcedure;
        command.CommandText = "Northwind_GetShippers";
        connection.Open();
        SqlDataReader Reader = command.ExecuteReader(CommandBehavior.CloseConnection);
        return Reader;
    }

    
}