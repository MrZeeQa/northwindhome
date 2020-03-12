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
public class ReviewCS
{

    public void AddReview(int Review_Rating, string Review_Comment, DateTime Review_Date, int ProductID )
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        SqlCommand command = new SqlCommand();
        command.Connection = connection;
        command.CommandType = CommandType.StoredProcedure;
        command.CommandText = "Northwind_AddReview";
     
        SqlParameter ParamReviewRating = new SqlParameter("@Review_Rating",
        SqlDbType.Int);
        ParamReviewRating.Direction = ParameterDirection.Input;
        ParamReviewRating.Value = Review_Rating;
        command.Parameters.Add(ParamReviewRating);
        SqlParameter ParamReviewComment = new SqlParameter("@Review_Comment", SqlDbType.NVarChar, 4000);
        ParamReviewComment.Direction = ParameterDirection.Input;
        ParamReviewComment.Value = Review_Comment;
        command.Parameters.Add(ParamReviewComment);
        SqlParameter ParamDateTime = new SqlParameter("@Review_Date", SqlDbType.SmallDateTime);
        ParamDateTime.Direction = ParameterDirection.Input;
        ParamDateTime.Value = Review_Date;
        command.Parameters.Add(ParamDateTime);
        SqlParameter ParamProductID = new SqlParameter("@ReviewProductID", SqlDbType.Int, 4);
        ParamProductID.Direction = ParameterDirection.Input;
        ParamProductID.Value = ProductID;
        command.Parameters.Add(ParamProductID);

        connection.Open();
        command.ExecuteNonQuery();
        connection.Close();
    }
}