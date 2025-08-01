using System;

namespace IT_Elective_2___11.Models
{
    public enum Gender
    {
        Unknown,
        Male,
        Female
    }

    public class Student
    {
        private string firstName;
        private string lastName;
        private Gender gender = Gender.Unknown;

        public string Title { get; set; }
        public string Course { get; set; }
        public string Section { get; set; }
        public DateTime Birthday { get; set; }

        public string FirstName => firstName;
        public string LastName => lastName;
        public Gender Gender => gender;

        public string FullName => $"{Title} {FirstName} {LastName}";
        public int Age
        {
            get
            {
                var today = DateTime.Today;
                var age = today.Year - Birthday.Year;
                if (Birthday > today.AddYears(-age)) age--;
                return age;
            }
        }

        public Student()
        {
            firstName = "Default";
            lastName = "Student";
            Title = "Mr./Ms.";
            Course = "Unknown";
            Section = "Unknown";
            Birthday = DateTime.Today;
        }

        public Student(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            Title = "Mr./Ms.";
            Course = "Unknown";
            Section = "Unknown";
            Birthday = DateTime.Today;
        }

        public void SetFirstName(string firstName)
        {
            this.firstName = firstName;
        }

        public void SetLastName(string lastName)
        {
            this.lastName = lastName;
        }

        public void SetGender(Gender gender)
        {
            this.gender = gender;
        }
    }
}
