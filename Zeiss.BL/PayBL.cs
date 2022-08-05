using Zeiss.DataAccess;

namespace Zeiss.BL
{
    public class PayBL
    {
        int GetBasicPay(string empID, Int16 Month, Int16 Year)
        {
            PayDA payDA = new PayDA();
            int basicPay = payDA.GetBasicPay(empID, Month, Year);
            return basicPay;
        }
        public int CalculateDA(string empID, Int16 Month, Int16 Year)
        {
            int basicPay = GetBasicPay(empID, Month, Year);
            int da;
            if (basicPay > 25000)
            {

                da = basicPay * 30/100;
            }
            else
            {
                da = basicPay * 40 / 100;
            }
            return da;
//eee
        }
    }
    public class EmployeeBL
    {
        public string empID;
        public string FirstName;
        public string LastName;
        public string DOJ;

        public EmployeeBL GetEmplDetails(string empID)
        {
            EmployeeDA emp01 = new EmployeeDA();
            emp01 = emp01.GetEmplDetails(empID);
            EmployeeBL empB1 = new EmployeeBL();
            empB1.empID = emp01.empID;
            empB1.FirstName = emp01.FirstName;
            empB1.LastName = emp01.LastName;
            empB1.DOJ = emp01.DOJ;

            return empB1;

        }
    }
}