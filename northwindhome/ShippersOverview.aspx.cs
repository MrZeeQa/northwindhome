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

public partial class ShippersOverview : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            LoadGridViewShippers();
        }

    }
    protected void LoadGridViewShippers()
    {
        ShipperCS ship = new ShipperCS();
        GridViewShippers.DataSource = ship.GetShippers();
   
        GridViewShippers.DataBind();

    }
}