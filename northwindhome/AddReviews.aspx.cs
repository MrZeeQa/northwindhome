using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

using Northwind.Components;


public partial class AddReviews : System.Web.UI.Page
{
    //SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            LoadDropDownListProducts();
          
           
        }


    }
 

    protected void LoadDropDownListProducts()
    {
        ProductsCS prod = new ProductsCS();
        DropDownListProducts.DataSource = prod.GetProducts();
        DropDownListProducts.DataValueField = "ProductID";
        DropDownListProducts.DataTextField = "ProductName";

        DropDownListProducts.DataBind();
    }

    protected void DropDownListProducts_Redirect(object sender, EventArgs e)
    {
        LoadDropDownListProducts();

    }

    //protected void RatingProduct_Changed(object sender, AjaxControlToolkit.RatingEventArgs e)
    //{
    //    connection.Open();
    //    SqlCommand cmd = new SqlCommand("INSERT INTO Reviews(Review_Rating) VALUES (@Review_Rating)", connection);
    //    cmd.Parameters.AddWithValue("@Review_Rating", SqlDbType.Int).Value = RatingProduct.CurrentRating;
    //    cmd.ExecuteNonQuery();
    //    connection.Close();

    //}


    protected void ButtonSubmit_Click(object sender, EventArgs e)
    {
        try
        {
            ReviewCS NewRev = new ReviewCS();
            NewRev.AddReview(Convert.ToInt32(RatingProduct.CurrentRating), TextBoxReview.Text, Convert.ToDateTime(DateTime.Now), Convert.ToInt32(DropDownListProducts.SelectedItem.Value));

          
        }
        catch (Exception ex)
        {
            LabelErrorMessage.Text = ex.Message.ToString();

        }
    }
}