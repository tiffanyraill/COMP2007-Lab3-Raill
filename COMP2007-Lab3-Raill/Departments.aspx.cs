using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

//using statements that are require to connect to EF DB
using COMP2007_Lab3_Raill.Models;
using System.Web.ModelBinding;

namespace COMP2007_Lab3_Raill
{
    public partial class Departments : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if loading page for the first time, populate departments grid
            if (!IsPostBack)
            {
                //Get the departments data
                this.GetDepartments();
            }
        }/**
         * <summary>
         * This method gets the departments data from the DB
         * </summary>
         * 
         * @method GetDepartments
         * @returns {void}
         */

        protected void GetDepartments()
        {
            //connect to EF
            using (DefaultConnection db = new DefaultConnection())
            {
                //query the Departments table using EF and LINQ
                var Departments = (from allDepartments in db.Departments
                                   select allDepartments);
                //bind the results to the gridview
                DepartmentsGridView.DataSource = Departments.ToList();
                DepartmentsGridView.DataBind();
            }
        }
    }
}