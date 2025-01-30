using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using System.IO;
using System.Reflection.Emit;
using System.Runtime.Remoting.Contexts;

namespace TASK1
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void log_Click(object sender, EventArgs e)
        {
            if (Email.Text=="Admin@gmail.com" && Password.Text == "123")
            {
                storLoged();
                Response.Redirect("admindash.aspx");
            }
            else
            {

                string file = Server.MapPath("users.txt");

                string[] usersData = File.ReadAllLines(file);

                foreach (string user in usersData)
                {
                    string[] userData = user.Split(',');

                    if (Email.Text == userData[1] && Password.Text == userData[2])
                    {
                        result.Text = "login successfully";
                        result.Visible = true;
                        storLoged();
                        Response.Redirect("userdash.aspx");

                    }




                }

                result.Text = "Invalid username or password ";
                result.Visible = true;
            }

        }
        
        private void storLoged()
        {
            string filePath = Server.MapPath("loged.txt");
            if (File.Exists(filePath))
            {
                File.WriteAllText(filePath, Email.Text);
            }
            else
            {
                File.WriteAllText(filePath, Email.Text);

            }
        }
        protected void registr_Click(object sender, EventArgs e)
        {
            Response.Redirect("regester.aspx");
        }
    }
}