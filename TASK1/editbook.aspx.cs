using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Threading;

namespace TASK1
{
    public partial class editbook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string filePath = Server.MapPath("books.txt");
            if (File.Exists(filePath))
            {
                var fileContent = File.ReadAllLines(filePath);
                StringBuilder tableRows = new StringBuilder();

                foreach (var line in fileContent)
                {
                    var columns = line.Split(',');
                    if (columns.Length == 4)
                    {
                        tableRows.Append("<tr>");
                        tableRows.AppendFormat("<td>{0}</td>", columns[0]);
                        tableRows.AppendFormat("<td>{0}</td>", columns[1]);
                        tableRows.AppendFormat("<td>{0}</td>", columns[2]);
                        tableRows.AppendFormat("<td>{0}</td>", columns[3]);
                        tableRows.Append("</tr>");
                    }
                }

                TableBody.InnerHtml = tableRows.ToString();
            }
            else
            {
                TableBody.InnerHtml = "<tr><td colspan='4'>File not found.</td></tr>";
            }
        }


        protected void edit_Click(object sender, EventArgs e)
        {

            string filePath = Server.MapPath("books.txt");
            if (File.Exists(filePath))
            {
                var fileContent = File.ReadAllLines(filePath);

                int count = 0;
                foreach (var line in fileContent)
                {
                    
                    string[] book = line.Split(',');
                    string[] newBook = new string[book.Length];
                    if (book[0] == bookId.Text)
                    {
                        newBook[0] = book[0];
                        newBook[1] = bookName.Text;
                        newBook[2] = bookType.Text;
                        newBook[3] = bookLevel.Text;
                        fileContent[count] = $"{newBook[0]},{newBook[1]},{newBook[2]},{newBook[3]}";
                        break;
                    }
                    count++;

                }
                File.WriteAllLines(filePath,fileContent);
            }

        }
    }
}