using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Text;

/// <summary>
/// Summary description for EmployeeCS
/// </summary>
public class EmployeeCS
{
    public SqlDataReader GetEmployees()
    {
        SqlConnection connection =  new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        SqlCommand command = new SqlCommand();
        command.Connection = connection;
        command.CommandType = CommandType.StoredProcedure;
        command.CommandText = "Get_Employee";
        connection.Open();
        SqlDataReader Reader = command.ExecuteReader(CommandBehavior.CloseConnection);
        return Reader;
    }





    //public SqlDataReader GetData(string queryString, string connectionString)
    //{

    //    SqlConnection connection = new SqlConnection(connectionString);
    //    connection.Open();
    //    SqlCommand command = new SqlCommand(queryString, connection);
    //    SqlDataReader reader = command.ExecuteReader();
    //    SqlDataReader sqlDataReader = reader;
    //    DataTable dataTable = new DataTable();
    //    dataTable.Columns.Add("First Name");
    //    dataTable.Columns.Add("Last Name");
    //    dataTable.Columns.Add("City lo");
    //    dataTable.Columns.Add("Country lo");
    //    while (sqlDataReader.Read())
    //    {
    //        DataRow row = dataTable.NewRow();
    //        row["First Name"] = sqlDataReader["@FirstName"];
    //        row["Last Name"] = sqlDataReader["@LastName"];
    //        row["City lo"] = sqlDataReader["@City"];
    //        row["Countrylo "] = sqlDataReader["@Country"];
    //        dataTable.Rows.Add(row);
    //    }
    //     ;
    //    GridView1.DataBind();
    //    connection.Close();
    //    return reader;
    //}




    //DataTable dt = new DataTable();


    //conn.Open();

    //SqlDataAdapter da = new SqlDataAdapter(commmand);

    //da.Fill(dt);
    //dataGridView.ItemsSource = dt.DefaultView;




}