using OCPLibrary.Applicants;

namespace OCPLibrary.Accounts
{
    public interface IAccounts
    {
        EmployeeModel Create(IApplicantModel person);
    }
}
