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
public partial class InsertShipper : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        PanelUserMessage.Visible = false;
    }

    protected void ButtonSubmit_Click(object sender, EventArgs e)
    {

        try
        {
            ShipperCS shp = new ShipperCS();
            shp.InsertNewShipper(TextBoxCompanyName.Text, TextBoxTelephoneNumber.Text);
            PanelFormInsert.Visible = false;
            PanelUserMessage.Visible = true;
        }
        catch (Exception ex)
        {
            LabelErrorMessage.Text = ex.Message.ToString();
            
        }
       
    }
}