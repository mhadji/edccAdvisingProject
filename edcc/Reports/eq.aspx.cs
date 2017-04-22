using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace edcc.Reports
{
    public partial class eq : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblSelected.Text = "";
            lblSelectedPr.Text = "";
      
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            foreach (ListItem listItem in ListUniversities.Items)
            {
                if (listItem.Selected == true)
                {
                    lblSelected.Text += listItem.Text.ToString()+",";
                }
            }
            foreach (ListItem prItem in ListPrograms.Items)
            {
                if (prItem.Selected == true)
                {
                    lblSelectedPr.Text += prItem.Text.ToString();
                }
            }

            ReportViewer1.LocalReport.Refresh();
         
        }

    }
}