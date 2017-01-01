using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Dotnet4Techies
{
    public partial class DropdownWithGroupItems : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    string conString = ConfigurationManager.ConnectionStrings["Dotnet4Techies"].ConnectionString;

                    StringBuilder sb = new StringBuilder();
                    sb.Append("SELECT '-- ' + ModelName AS ModelName,ModelId,ManufacturerId FROM Notebook_Models UNION ");
                    sb.Append("SELECT UPPER(NotebookName),'',NotebookId FROM Notebook_Manufacturer ORDER BY ManufacturerId,ModelId");

                    SqlConnection connection = new SqlConnection(conString);
                    SqlCommand command = new SqlCommand(sb.ToString(), connection);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    ddlNotebookModel.DataSource = reader;
                    ddlNotebookModel.DataTextField = "ModelName";
                    ddlNotebookModel.DataValueField = "ModelId";
                    ddlNotebookModel.DataBind();

                    ddlNotebookModel.Items.Insert(0, new ListItem("--- Choose your notebook model ---"));

                    connection.Close();
                }
                catch { }
            }

        }       

        protected void dllNotebook_DataBound(object sender, EventArgs e)
        {
            DropDownList notebook = (DropDownList)sender;

            foreach (ListItem item in notebook.Items)
            {
                if (!item.Text.StartsWith("--"))
                {
                    item.Attributes.Add("disabled", "true");
                    item.Attributes.Add("style", "color:red");
                }                
            }
        }
    }
}