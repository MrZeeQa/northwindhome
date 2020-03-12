using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Text;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Web.Security;
using System.Collections;
using Northwind.Components;
public partial class Categories : System.Web.UI.Page
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


   


}