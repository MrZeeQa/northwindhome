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
/// Summary description for ProductsCS
/// </summary>
public class ProductsCS
{

    public void AddNewProduct(string productName, int supplierID, int categoryID, string
      quantityPerUnit, decimal unitPrice)
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        SqlCommand command = new SqlCommand();
        command.Connection = connection;
        command.CommandType = CommandType.StoredProcedure;
        command.CommandText = "Northwind_InsertNewProduct";
        SqlParameter ParameterProductName = new SqlParameter("@ProductName", SqlDbType.NVarChar,
       255);
        ParameterProductName.Direction = ParameterDirection.Input;
        ParameterProductName.Value = productName;
        command.Parameters.Add(ParameterProductName);
        SqlParameter ParameterProductSupplierID = new SqlParameter("@ProductSupplierID",
       SqlDbType.Int, 4);
        ParameterProductSupplierID.Direction = ParameterDirection.Input;
        ParameterProductSupplierID.Value = supplierID;
        command.Parameters.Add(ParameterProductSupplierID);
        SqlParameter ParameterProductCategoryID = new SqlParameter("@ProductCategoryID",
       SqlDbType.Int, 4);
        ParameterProductCategoryID.Direction = ParameterDirection.Input;
        ParameterProductCategoryID.Value = categoryID;
        command.Parameters.Add(ParameterProductCategoryID);
        SqlParameter ParameterQuantityPerUnit = new SqlParameter("@QuantityPerUnit",
       SqlDbType.NVarChar, 255);
        ParameterQuantityPerUnit.Direction = ParameterDirection.Input;
        ParameterQuantityPerUnit.Value = quantityPerUnit;
        command.Parameters.Add(ParameterQuantityPerUnit);
        SqlParameter ParameterProductPrice = new SqlParameter("@ProductPrice", SqlDbType.Money);
        ParameterProductPrice.Direction = ParameterDirection.Input;
        ParameterProductPrice.Value = unitPrice;
        command.Parameters.Add(ParameterProductPrice);
        connection.Open();
        command.ExecuteNonQuery();
        connection.Close();

    }

    public SqlDataReader GetProducts()
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        SqlCommand command = new SqlCommand();
        command.Connection = connection;
        command.CommandType = CommandType.StoredProcedure;
        command.CommandText = "GetProducts";
        connection.Open();
        SqlDataReader Reader = command.ExecuteReader(CommandBehavior.CloseConnection);
        return Reader;
    }
}