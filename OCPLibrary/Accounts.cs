namespace OCPLibrary
{
    /*
     * This class will demonstrate the Open-Closed Principle.
     */
    public class Accounts
    {
        public EmployeeModel Create(PersonModel person)
        {
            EmployeeModel output = new EmployeeModel();

            output.FirstName = person.FirstName;
            output.LastName = person.LastName;
            output.EmailAddress = $"{person.FirstName.Substring(0, 1)}{person.LastName}@acme.com";

            /*
             * Modifying the Create() method violates the Open-Closed Principle.
             */
            if (person.TypeOfEmployee == EmployeeType.Manager)
            {
                output.IsManager = true;
            }

            return output;
        }
    }
}
