using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Dotnet4Techies
{
    public partial class CsharpTuples : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            //create Tuple using constructor
            Tuple<int, string, string, string, long, DateTime> employee1 = new Tuple<int, string, string, string, long, DateTime>
                                                    (1, "Srinivasa Rao", "Dhulipalla", "email@domain.com", 9876543210, DateTime.Now);


            //create Tuple using Create method
            var employee2 = Tuple.Create(2, "Srinivasa Rao", "Dhulipalla", "email@domain.com", 9876543210, DateTime.Now);
            

            //create Tuple using Create method
            var colors = Tuple.Create("Red", "Green", "Blue", "Yellow", "Black", "White", "Orange", "Pink");

            //colors.Item1; //returns Red
            //colors.Item2; //returns Green
            //colors.Item3; //returns Blue
            //colors.Item4; //returns Yellow
            //colors.Item5; //returns Black
            //colors.Item6; //returns White
            //colors.Item7; //returns Orange
            //colors.Rest; //returns Pink


            //create Tuple using Create method
            var months = Tuple.Create("Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", Tuple.Create("Aug", "Sep", "Oct", "Nov", "Dec"));

            //months.Item1; //returns Jan
            //months.Item2; //returns Feb
            //months.Item3; //returns Mar
            //months.Item4; //returns Apr
            //months.Item5; //returns May
            //months.Item6; //returns Jun
            //months.Item7; //returns Jul
            //months.Rest.Item1; //returns (Aug, Sep, Oct, Nov, Dec)
            //months.Rest.Item1.Item1; //returns Aug
            //months.Rest.Item1.Item2; //returns Sep
            //months.Rest.Item1.Item3; //returns Oct
            //months.Rest.Item1.Item4; //returns Nov
            //months.Rest.Item1.Item5; //returns Dec


            //pass Tuple as a parameter to method
            PrintEmployee(employee1);

            //call a method which returns the Tuple object
            var employee = GetEmployee();
        }

        private void PrintEmployee(Tuple<int, string, string, string, long, DateTime> employee)
        {
            Console.WriteLine(employee.Item1);
            Console.WriteLine(employee.Item2);
            Console.WriteLine(employee.Item3);
            Console.WriteLine(employee.Item4);
            Console.WriteLine(employee.Item5);
            Console.WriteLine(employee.Item6);
        }

        private Tuple<int, string, long, DateTime> GetEmployee()
        {
            return Tuple.Create(1, "Srinivasa Rao Dhulipalla", 9876543210, DateTime.Now);
        }


    }
}