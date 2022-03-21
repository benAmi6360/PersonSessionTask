using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DeleteDB();
            UpdateDB(GenPersonList());
            UpdateHTML();
            UpdateSession(GenPersonList().GetValue());
        }
        private Node<Person> GenPersonList()
        {
            Node<Person> first = new Node<Person>(new Person("", "", ""));
            Node<Person> pos = first;
            for (int i = 0; i < 10; i++)
            {
                pos.SetNext(new Node<Person>(new Person("Ben" + i, "Kadmia" + i, "minebenking" + i + "@gmail.com")));
                pos = pos.GetNext();
            }
            return first.GetNext();
        }
        private void DeleteDB()
        {
            MyAdoHelper.DoQuery("BestDatabaseEverCreated.accdb", "DELETE * FROM People");
        }
        private void UpdateSession(Person p)
        {
            Session["UserPerson"] = p;
        }
        private void UpdateDB(Node<Person> lst)
        {
            for (int i = 1; lst != null; i++)
            {
                string sqlCommand = "INSERT INTO People ";
                sqlCommand += $" Values ('{lst.GetValue().email}', '{lst.GetValue().city}', '{lst.GetValue().name}', '{i}')";
                MyAdoHelper.DoQuery("BestDatabaseEverCreated.accdb", sqlCommand);
                lst = lst.GetNext();
            }
        }
        private void UpdateHTML()
        {
            Response.Write("<table>" +
                           "<tr> <th>PID</th>  <th>Name</th> <th>City</th> <th>Email</th></tr>");
            DataTable dt = MyAdoHelper.ExecuteDataTable("BestDatabaseEverCreated.accdb", "SELECT * FROM People");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Response.Write("<tr>" +
                               $"<td> {(string)dt.Rows[i]["uname"]} </td>" +
                               $"<td> {(string)dt.Rows[i]["city"]} </td>" +
                               $"<td> {(string)dt.Rows[i]["email"]} </td>" +
                               $"<td> {(string)dt.Rows[i]["pid"]} </td>");
            }
            Response.Write("</table>");
        }
    }
}