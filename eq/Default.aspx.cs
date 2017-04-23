using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class eq_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        LBLun.Text = "";
        LBLpr.Text = "";
    }

    protected void BTNsearch_Click(object sender, EventArgs e)
    {
        LBLun.Text = "";
        LBLpr.Text = "";
        foreach (ListItem un in this.CBLuniversities.Items)
        {
            if (un.Selected)
                LBLun.Text += un.Value.ToString() + " ,";
        }
        foreach (ListItem pr in this.CBLprograms.Items)
        {
            if (pr.Selected)
                LBLpr.Text += pr.Value.ToString() + " ,";
        }
        if (!(LBLun.Text == "" || LBLpr.Text == ""))
            ReportViewer1.LocalReport.Refresh();
        else
        {
            if (LBLun.Text == "")
                LBLun.Text = "NO Item has selected.";
            if (LBLpr.Text == "")
                LBLpr.Text = "NO Item has selected.";
        }

    }

    protected void CBuntoggol_CheckedChanged(object sender, EventArgs e)
    {
        foreach (ListItem un in this.CBLuniversities.Items)
        {
            if (CBuntoggol.Checked)
                un.Selected = true;
            else
                un.Selected = false;

        }
    }

    protected void CBprtoggol_CheckedChanged(object sender, EventArgs e)
    {
        foreach (ListItem pr in this.CBLprograms.Items)
        {
            if (CBprtoggol.Checked)
                pr.Selected = true;
            else
                pr.Selected = false;
        }
    }
}