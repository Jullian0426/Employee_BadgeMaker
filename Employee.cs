namespace CatWorx.BadgeMaker
{
    class Employee
    {
        public string FirstName;
        public string LastName;
        public string Id;
        public string PhotoUrl;
        public Employee(string firstName, string lastName, string id, string photoUrl)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
            PhotoUrl = photoUrl;
        }
        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }

        public string GetId()
        {
            return Id;
        }

        public string GetPhotoUrl()
        {
            return PhotoUrl;

        }

        public string GetCompanyName()
        {
            return "Cat Worx";
        }
    }
}