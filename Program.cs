using System.ComponentModel.DataAnnotations;

namespace ClubInterface
{
    interface IClub
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Fullname();
    }
    class Program
    {
        class Club : IClub
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Date { get; set; }
            public string Membership { get; set; }
            public string Email { get; set; }

            public Club()
            {
                Id = 0;
                FirstName = string.Empty;
                LastName = string.Empty;
                Date = string.Empty;
                Membership = string.Empty;
                Email = string.Empty;
            }

            public Club(int id, string firstName, string lastName, string date, string membership, string email)
            {
                Id = id;
                FirstName = firstName;
                LastName = lastName;
                Date = date;
                Membership = membership;
                Email = email;
            }

            public string Display()
            {
                return "Id: " + Id + "\nFirst name: " + FirstName + "\nLast name: " + LastName + "\nMembership date: " + Date + "\nMembership type: " + Membership + "\nEmail: " + Email;
            }

            public string Fullname()
            {
                return FirstName + " " + LastName;
            }
        }
        static void Main(string[] args)
        {
            Club myClub = new Club(23,"Rose","Tyler","1999","yearly","roset@email.com");
            Console.WriteLine(myClub.Fullname());
            Console.WriteLine(myClub.Display());
        }
    }
}
