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
    public partial class DepartmentDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CancelButton_Click(object sender, EventArgs e)
        {
            //redirects back to departments page
            Response.Redirect("~/Departments.aspx");
        }

        protected void Savebutton_Click(object sender, EventArgs e)
        {
            //use Ef to connect to server
            using (DefaultConnection db = new DefaultConnection())
            {
                //use the Departments model to create new department object and save new record
                Department newDepartment = new Department();

                //add data to the new department record
                newDepartment.DepartmentID = Convert.ToInt16(DepartmentIDTextBox.Text);
                newDepartment.Name = NameTextBox.Text;
                newDepartment.Budget = Convert.ToDecimal(BudgetTextBox.Text);
                
                //use linq and ADO.NET to add/insert a new department into the DB
                db.Departments.Add(newDepartment);

                //save our changes
                db.SaveChanges();

                //redirect back to the updated departments page
                Response.Redirect("~/Departments.aspx");

            }
        }
    }
}