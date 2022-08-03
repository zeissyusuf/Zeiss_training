namespace Zeiss.DataAccess
{
    public class PayDA
    {
        public int GetBasicPay(string emp10, Int16 Month, Int16 Year)
        {
            return 20000;
        }

    }
    public class EmployeeDA
    {
        public string empID;
        public string FirstName;
        public string LastName;
        public string DOJ;
    
    public EmployeeDA GetEmplDetails(string empID)
    {
        EmployeeDA emp = new EmployeeDA();
        emp.empID = "M100232";
        emp.FirstName = "raj";
        emp.LastName = "sharma";
        emp.DOJ = "05-07-2022";

        return emp;
    }
    }
}