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
    public partial class Students : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if loading page for the first time, populate student grid
            if(!IsPostBack)
            {
                //Get the student data
                this.GetStudents();
            }
        }
        /**
         * <summary>
         * This method gets the student data from the DB
         * </summary>
         * 
         * @method GetStudents
         * @returns {void}
         */
         
        protected void GetStudents()
        {
            //connect to EF
            using (DefaultConnection db = new DefaultConnection())
            {
                //query the students table using EF and LINQ
                var Students = (from allStudents in db.Students
                                select allStudents);
                //bind the results to the gridview
                StudentsGridView.DataSource = Students.ToList();
                StudentsGridView.DataBind();
            }
        }
    }
}