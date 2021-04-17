using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace parentComp
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        private void search()
        {
            OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = D:\Project\Database\Database.mdb");
            con.Open();
            OleDbCommand cm = new OleDbCommand("Select * from health where Rollno like'" + TextBox1.Text + "%'", con);
            OleDbDataAdapter od = new OleDbDataAdapter(cm);
            DataTable dt = new DataTable();
            od.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = D:\Project\Database\Database.mdb");
            con.Open();
            OleDbCommand cm = new OleDbCommand("Select * from health", con);
            OleDbDataAdapter od = new OleDbDataAdapter(cm);
            DataTable dt = new DataTable();
            od.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm1.aspx");
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void Search_Click(object sender, EventArgs e)
        {
            search();
        }
    }
}