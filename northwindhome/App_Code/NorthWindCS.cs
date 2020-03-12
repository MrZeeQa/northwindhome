using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Text;
using Northwind.Components;

/// <summary>
/// Summary description for NorthWindCS
/// </summary>
/// 
namespace Northwind.Components
{
    public class NorthWindCS
    {
        
        public SqlDataReader GetCategories()
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "Northwind_GetCategories";
            connection.Open();
            SqlDataReader Reader = command.ExecuteReader(CommandBehavior.CloseConnection);
            return Reader;
        }
        public SqlDataReader GetProductsByCategory(int categoryID)
        {
            SqlConnection connection = new
            SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "Northwind_GetProductsByCategory";
            SqlParameter ParameterCategoryID = new SqlParameter("@CategoryID", SqlDbType.Int, 4);
            ParameterCategoryID.Direction = ParameterDirection.Input;
            ParameterCategoryID.Value = categoryID;
            command.Parameters.Add(ParameterCategoryID);
            connection.Open();
            SqlDataReader Reader = command.ExecuteReader(CommandBehavior.CloseConnection);
            return Reader;
        }
        public SqlDataReader GetCustomerDropDown()
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "NorthWind_GetCustomerDropDown";
            connection.Open();
            SqlDataReader Reader = command.ExecuteReader(CommandBehavior.CloseConnection);
            return Reader;
        }

       

    }
}
