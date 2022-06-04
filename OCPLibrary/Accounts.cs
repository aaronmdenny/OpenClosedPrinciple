namespace OCPLibrary
{
    /*
     * This class will demonstrate the Open-Closed Principle.
     */
    public class Accounts: IAccounts
    {
        public EmployeeModel Create(IApplicantModel person)
        {
            EmployeeModel output = new EmployeeModel();

            output.FirstName = person.FirstName;
            output.LastName = person.LastName;
            output.EmailAddress = $"{person.FirstName.Substring(0, 1)}{person.LastName}@acme.com";

            /*
             * Modifying the Create() method violates the Open-Closed Principle.
             * 
             * In adding the "Executive" employee type, we have changed the way we evaluate the output's IsManager
             * property, which may introduce a bug to a working class.
             */

            return output;
        }
    }
}
