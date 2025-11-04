using place_me.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace place_me.Pages.Clients
{
    public partial class available_rooms : System.Web.UI.Page
    {
        private readonly DataBase db = new DataBase();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                getAllData();
            }
        }

        protected void BtnEnroll_Click(object sender, EventArgs e)
        {
            try
            {
                Button btnEnroll = (Button)sender;
                DataListItem item = (DataListItem)btnEnroll.NamingContainer;


                Label label1 = (Label)item.FindControl("Label1");

                if (label1 != null)
                {
                    Session["Name"] = label1.Text;
                    getDate(Session["Name"].ToString());
                    using (db.mySqlConn())
                    {
                        db.ReadData("SELECT * FROM [dbo].[Applications] WHERE Student = '" + Session["UserID"] + "' AND [Course Code] = '" + Session["Course Code"] + "'");
                        if (db.rd.HasRows)
                        {
                            Response.Redirect("Course_Layout.aspx");
                        }
                        else
                        {
                            Response.Redirect("Payment.aspx");
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        private void getDate(string name)
        {
            try
            {
                using (db.mySqlConn())
                {
                    db.ReadData("SELECT * FROM [dbo].[Rooms] WHERE [Course Name] = '" + name + "'");
                    if (db.rd.HasRows)
                    {
                        while (db.rd.Read())
                        {
                            Session["Course Code"] = db.rd.GetValue(0);
                            Session["Course Price"] = db.rd.GetValue(3);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Response.Redirect("Error 404.aspx");
            }
        }

        private void getAllData()
        {
            try
            {
                using (db.mySqlConn())
                {
                    db.ReadData("SELECT * FROM [dbo].[Rooms] ");
                    DataList1.DataSource = db.rd;
                    DataList1.DataBind();
                }
            }
            catch
            {
                Response.Redirect("Error 404.aspx");
            }
        }
    }
}