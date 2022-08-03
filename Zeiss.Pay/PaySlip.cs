using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeiss.BL;

namespace Zeiss.PaySlip
{

    internal class PaySlip
    {
        string EmpID;
        string FirstName;
        string LastName;
        DateTime DOJ;
        string Department;
        short Month;
        short Year;
        int BasicPay;
        int DA;
        int HRA;
        int LTA;
        int PF;
        int ProfTax;
        int IncomeTax;
        int Loan;

        public void PrintPaySlip(string empID, short Month, short Year)
        {
            Console.WriteLine("PaySlip for " + Year.ToString() + ":" + Month.ToString());
            EmployeeBL empBL = new EmployeeBL();
            empBL = empBL.GetEmplDetails("M100232");
            Console.WriteLine(empBL.empID + " " + empBL.FirstName + " " + empBL.LastName);
            Console.WriteLine("Date of Joining : "+ empBL.DOJ);

        }




    }
}
