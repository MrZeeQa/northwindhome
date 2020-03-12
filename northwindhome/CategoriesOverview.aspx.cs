using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CategoriesOverview : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            LoadGridViewCategoriesOverview();
        }
    }
    protected void LoadGridViewCategoriesOverview()
    {
        CategoriesOverviewCS cat = new CategoriesOverviewCS();
        GridViewCategories.DataSource = cat.GetCategoriesOverview();
        GridViewCategories.DataBind();
    }
}