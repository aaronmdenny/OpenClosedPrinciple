namespace OCPLibrary
{
    /// <summary>
    /// This illustrates OCP. By extracting the IAccounts interface and implementing it in the Accounts class, and here,
    /// we no longer have to make changes to the Accounts class when new logic needs to be implemented for a new type of
    /// applicant. We can say the Accounts class is open for extension, but closed to modification. We achieved this by
    /// extracting the interface.
    /// </summary>
    public class ManagerAccounts : IAccounts
    {
        public EmployeeModel Create(IApplicantModel person)
        {
            EmployeeModel output = new EmployeeModel();

            output.FirstName = person.FirstName;
            output.LastName = person.LastName;
            output.EmailAddress = $"{person.FirstName.Substring(0, 1)}{person.LastName}@acmecorp.com";
            output.IsManager = true;

            return output;
        }
    }
}
