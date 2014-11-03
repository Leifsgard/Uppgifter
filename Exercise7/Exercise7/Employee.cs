namespace Exercise7
{
    /// <summary>
    /// This class describes an employee
    /// </summary>
    public class Employee
    {
        // Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SocialSecurityNumber { get; set; }
        public int HourlyWage { get; set; }

        public string FullName
        {
            get { return string.Format("{0} {1}", FirstName, LastName); }
        }

        // Constructor #1
        public Employee(string firstName, string lastName, string socialSecurityNumber, int hourlyWage)
        {
            FirstName = firstName;
            LastName = lastName;
            SocialSecurityNumber = socialSecurityNumber;
            HourlyWage = hourlyWage;
        }

        // Constructor #2
        public Employee(string socialSecurityNumber)
        {
            SocialSecurityNumber = socialSecurityNumber;
        }
    }
}