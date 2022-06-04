using OCPLibrary.Accounts;

namespace OCPLibrary.Applicants
{
    /// <summary>
    /// We can implement this interface in new ways as needed. For example, when we have an applicant who is a manager
    /// applicant, we can implement this interface separately from how it is done in the non-manager implementation.
    /// </summary>
    public interface IApplicantModel
    {
        string FirstName { get; set; }

        string LastName { get; set; }

        IAccounts AccountProcessor { get; set; }
    }
}