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
    public partial class StudentDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CancelButton_Click(object sender, EventArgs e)
        {
            //redirects back to Students page
            Response.Redirect("~/Students.aspx");
        }

        protected void Savebutton_Click(object sender, EventArgs e)
        {
            //use Ef to connect to server
            using (DefaultConnection db = new DefaultConnection())
            {
                //use the Student model to create new student object and save new record
                Student newStudent = new Student();

                //add data to the new student record
                newStudent.LastName = LastNameTextBox.Text;
                newStudent.FirstMidName = FirstNameTextBox.Text;
                newStudent.EnrollmentDate = Convert.ToDateTime(EnrollmentDateTextBox.Text);

                //use linq and ADO.NET to add/insert a new student into the DB
                db.Students.Add(newStudent);

                //save our changes
                db.SaveChanges();

                //redirect back to the updated students page
                Response.Redirect("~/Students.aspx");


            }
        }
    }
}