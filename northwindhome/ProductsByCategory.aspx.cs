using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls.WebParts;
using Northwind.Components;

public partial class ProductsByCategory : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            LoadDropDownListCategories();
        }
        
    }
    protected void LoadDropDownListCategories()
    {

        NorthWindCS cat = new NorthWindCS();
        DropDownListCategories.DataSource = cat.GetCategories();
        DropDownListCategories.DataTextField = "CategoryName";
        DropDownListCategories.DataValueField = "CategoryID";
        DropDownListCategories.DataBind();


    }




    protected void LoadGridViewProducts()
    {
        NorthWindCS Prod = new NorthWindCS();
        GridViewProducts.DataSource =
        Prod.GetProductsByCategory(Convert.ToInt32(DropDownListCategories.SelectedItem.Value));
        GridViewProducts.DataBind();
    }


    protected void DropDownListCategories_Redirect(object sender, EventArgs e)
    {
        LoadGridViewProducts();

    }
    protected void GridViewProducts_Redirect(object sender, EventArgs e)
    {
        LoadDropDownListCategories();
    }


}