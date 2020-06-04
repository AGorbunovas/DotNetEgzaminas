using System;

namespace CreditCompanyApplication.Model
{
    [Serializable]
    public class User
    {
        public string FirstName { get; set; }
        //public string LastName { get; set; }

        public User(string firstName)
        //public User(string firstName, string lastName)
        {
            if (string.IsNullOrWhiteSpace(firstName))
            {
                throw new ArgumentNullException("Vartotojo vardas negali buti tuscias", nameof(firstName));
            }
            //if (string.IsNullOrWhiteSpace(lastName))
            //{
            //    throw new ArgumentNullException("Vartotojo pavarde negali buti tuscia", nameof(lastName));
            //}

            FirstName = firstName;
            //LastName = lastName;
        }

        public override string ToString()
        {
            return FirstName;
        }
    }
}