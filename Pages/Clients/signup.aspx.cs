using place_me.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace place_me.Pages.Clients
{
    public partial class signup : System.Web.UI.Page
    {
        DataBase db = new DataBase();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnregister_Click(object sender, EventArgs e)
        {
            using (db.mySqlConn())
            {
                db.sqlQueries("INSERT INTO [dbo].[Users]VALUES('" + floatingInput.Text + "','" + floatingEmail.Text + "','" + floatingPassword.Text + "','"+ floatingStudentNumber.Text + "')");
                db.nonQuery();

                Response.Redirect("User_LogIn.aspx");

            }
        }
    }
}