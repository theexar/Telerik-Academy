﻿namespace _02.EmployeesMultipage
{
    using Northwind.Data;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.UI;
    using System.Web.UI.WebControls;

    public partial class Employees : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                var db = new NorthwindEntities();
                var emps = db.Employees.ToList();
                this.GridViewEmployees.DataSource = emps;
                this.GridViewEmployees.DataBind();
            }
        }
    }
}