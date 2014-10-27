namespace Extra___3
{
    internal class Person
    {
        private string firstName;
        private string lastName;

        public void SetFirstName(string newfirstname)
        {
            firstName = newfirstname;
        }

        public void SetLastName(string newlastname)
        {
            lastName = newlastname;
        }

        public string GetFullName()
        {
            return firstName + " " + lastName;
        }
    }
}