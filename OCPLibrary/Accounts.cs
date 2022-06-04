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
             * 
             * In adding the "Executive" employee type, we have changed the way we evaluate the output's IsManager
             * property, which may introduce a bug to a working class.
             */
            //if (person.TypeOfEmployee == EmployeeType.Manager)
            //{
            //    output.IsManager = true;
            //}

            switch (person.TypeOfEmployee)
            {
                case EmployeeType.Staff:
                    break;
                case EmployeeType.Manager:
                    output.IsManager = true;
                    break;
                case EmployeeType.Executive:
                    output.IsManager = true;
                    output.IsExecutive = true;
                    break;
                default:
                    break;
            }

            return output;
        }
    }
}
