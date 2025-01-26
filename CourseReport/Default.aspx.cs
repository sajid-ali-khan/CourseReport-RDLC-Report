using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.Ajax.Utilities;
using Microsoft.Reporting.WebForms;

namespace CourseReport
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-PJ0OUAF\\SQLEXPRESS;Initial Catalog=RDLC_Report;Integrated Security=True");
        protected void Button1_Click(object sender, EventArgs e)
        {
            string branch = et_branch.Text;
            string sem = et_sem.Text;
            string scode = et_subjectCode.Text;
            StringBuilder query = new StringBuilder();
            query.Append("SELECT * FROM course");

            List<string> conditions = new List<string>();

            if (!string.IsNullOrEmpty(branch))
            {
                conditions.Add($"branch = '{branch}'");
            }
            if(!string.IsNullOrEmpty(sem))
            {
                conditions.Add($"sem = '{sem}'");
            }
            if (!string.IsNullOrEmpty(scode))
            {
                conditions.Add($"subject_code = '{scode}'");
            }

            if (conditions.Count > 0)
            {
                query.Append(" WHERE ");
                query.Append(string.Join( " AND ", conditions));
            }


            SqlCommand command = new SqlCommand(query.ToString(), con);
            SqlDataAdapter s = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            s.Fill(dt);

            ReportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource rds = new ReportDataSource("DataSet1", dt);
            ReportViewer1.LocalReport.ReportPath = Server.MapPath("Report1.rdlc");
            ReportViewer1.LocalReport.DataSources.Add(rds);
            ReportViewer1.LocalReport.Refresh();
        }
    }
}