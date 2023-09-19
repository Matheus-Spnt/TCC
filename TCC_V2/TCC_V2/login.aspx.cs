using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.IO;

namespace TCC_V2
{
    public class login : System.Web.UI.Page
    {
        if (Request["i"] != null && Request["i"].ToString() != "")
        {
            int bo = int.Parse(Request["i"].ToString());
        }
        else
        {
            Response.Redirect("~/home_sc.aspx");
        }
    }
}