using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aula1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropDownList1.Items.Add(new ListItem("Terceira Opção", "3"));
            }
            else
            {

            }

            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Nome.Text = "Hello World";
        }
    }
}