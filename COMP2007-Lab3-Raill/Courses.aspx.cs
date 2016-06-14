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
    public partial class Courses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            //if loading page for the first time, populate courses grid
            if (!IsPostBack)
            {
                //Get the courses data
                this.GetCourses();
            }
        }

        /**
         * <summary>
         * This method gets the course data from the DB
         * </summary>
         * 
         * @method GetCourse
         * @returns {void}
         */

        protected void GetCourses()
        {
            //connect to EF
            using (DefaultConnection db = new DefaultConnection())
            {
                //query the students table using EF and LINQ
                var Courses = (from allCourses in db.Courses
                              select allCourses);
                //bind the results to the gridview
                CoursesGridView.DataSource = Courses.ToList();
                CoursesGridView.DataBind();
            }
        }
    }
}