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
using Northwind.Components;
public partial class AddProducts : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            LoadDropDownListCategories();
            LoadDropDownListSuppliers();
            
            PanelUserMessage.Visible = false;
        }

    }



    






    protected void LoadDropDownListSuppliers()
    {
        SupplierCS Supp = new SupplierCS();
        DropDownListSuppliers.DataSource = Supp.GetSuppliers();
        DropDownListSuppliers.DataValueField = "SupplierID";
        DropDownListSuppliers.DataTextField = "CompanyName";
        DropDownListSuppliers.DataBind();
    }
    protected void LoadDropDownListCategories()
    {
        NorthWindCS Cat = new NorthWindCS();
        DropDownListCategories.DataSource = Cat.GetCategories();
        DropDownListCategories.DataValueField = "CategoryID";
        DropDownListCategories.DataTextField = "CategoryName";
        DropDownListCategories.DataBind();

    }
    protected void DropDownListCategories_Redirect(object sender, EventArgs e)
    {
        LoadDropDownListCategories();

    }
    protected void DropDownListSuppliers_Redirect(object sender, EventArgs e)
    {
        LoadDropDownListSuppliers();
    }

    protected void ButtonSubmit_Click(object sender, EventArgs e)
    {
        try
        {
            ProductsCS NewProd = new ProductsCS();
            NewProd.AddNewProduct(TextBoxProductName.Text,
            Convert.ToInt32(DropDownListSuppliers.SelectedItem.Value),
            Convert.ToInt32(DropDownListCategories.SelectedItem.Value),
            TextBoxQuantityPerUnit.Text,
            Convert.ToDecimal(TextBoxUnitPrice.Text));
           
            PanelFormInsert.Visible = false;
            PanelUserMessage.Visible = true;
        }
        catch (Exception ex)
        {
            LabelErrorMessage.Text = ex.Message.ToString();

        }
    }
}
