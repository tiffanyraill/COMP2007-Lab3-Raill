using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

//using statements required for EF DB access
using COMP2007_Lab3_Raill.Models;
using System.Web.ModelBinding;

namespace COMP2007_Lab3_Raill
{
    public partial class CourseDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CancelButton_Click(object sender, EventArgs e)
        {
            //redirects back to courses page
            Response.Redirect("~/Courses.aspx");
        }

        protected void Savebutton_Click(object sender, EventArgs e)
        {

            //use Ef to connect to server
            using (DefaultConnection db = new DefaultConnection())
            {
                //use the Courses model to create new course object and save new record
                Course newCourse = new Course();

                //add data to the new course record
                newCourse.Title = TitleTextBox.Text;


                //use linq and ADO.NET to add/insert a new course into the DB
                db.Courses.Add(newCourse);

                //save our changes
                db.SaveChanges();

                //redirect back to the updated courses page
                Response.Redirect("~/Courses.aspx");

            }
        }
    }
}