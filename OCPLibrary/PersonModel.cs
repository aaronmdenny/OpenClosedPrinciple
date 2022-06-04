namespace OCPLibrary
{
    /// <summary>
    /// We never have to change this class again. Previously, we added an enum to indicate the type of applicant. Now,
    /// we can implement the IApplicantModel interface differently by simply add a new AccountProcessor to handle each
    /// new situation. The PersonModel class is open for extension (implement IApplicantModel however we need), but
    /// closed for modification (we never change it again).
    /// </summary>
    public class PersonModel : IApplicantModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public IAccounts AccountProcessor { get; set; } = new Accounts();
    }
}
