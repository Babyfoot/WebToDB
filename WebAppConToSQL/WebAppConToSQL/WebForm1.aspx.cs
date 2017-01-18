using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppConToSQL
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            string Name = TextBoxName.Text;
            string City = TextBoxCity.Text;
            string Phone = TextBoxPhone.Text;
            string Mail = TextBoxMail.Text;

            DB db1 = new DB();
            db1.Inserts(Name, City, Phone, Mail);

            GridView1.DataBind();
        }
    }
}