//Employee.cs

using System;

namespace L1
{
    /// <summary>
    /// Class to store information about single employee
    /// </summary>
    internal class Employee
    {
        //Name and surname
        public string NameAndSurname { get; set; } 
        //Profession
        public string Profession { get; set; }
        //Gender
        public Gender Gender { get; set; }
        //Work experience
        public int WorkExperience { get; set; }
        //Preferred working time
        public int PreferredWorkingTime { get; set; }
        //Preferred salary
        public int PreferredSalary { get; set; }

        /// <summary>
        /// Constructor without parameters
        /// </summary>
        public Employee()
        {

        }

        /// <summary>
        /// Constructor with parameters
        /// </summary>
        /// <param name="nameAndSurname">Name and surname</param>
        /// <param name="profession">Profession</param>
        /// <param name="gender">Gender</param>
        /// <param name="workExperience">Work experience</param>
        /// <param name="preferredWorkingTime">Preferred working time</param>
        /// <param name="preferredSalary">Preferred salary</param>
        public Employee(string nameAndSurname, string profession, 
                    Gender gender, int workExperience, int preferredWorkingTime, 
                    int preferredSalary)
        {
            this.NameAndSurname = nameAndSurname;
            this.Profession = profession;
            this.Gender = gender;
            this.WorkExperience = workExperience;
            this.PreferredWorkingTime = preferredWorkingTime;
            this.PreferredSalary = preferredSalary;
        }

        /// <summary>
        /// Returns a formatted string representation of the employee's details
        /// </summary>
        /// <returns>Formatted string</returns>
        public override string ToString()
        {
            // Line that needs to be formatted
            string line = string.Format("{0, -18} {1,-16} {2,-16} {3,-16:d}" +
                " {4,-10:d} {5,-8}", NameAndSurname, Profession, Gender, 
                WorkExperience, PreferredWorkingTime, PreferredSalary);
            return line;
        }

        /// <summary>
        /// Compares the current employee object with another employee 
        /// to define a sorting order
        /// </summary>
        /// <param name="other">The employee</param>
        /// <returns>
        /// An integer indicating the relative order of the employees:
        /// - A negative value if the current employee 
        /// should come after the other
        /// - A positive value if the current employee 
        /// should come before the other
        /// - Zero if the employees are equal in both 
        /// work experience and Profession
        /// </returns>
        public int CompareTo(Employee other)
        {
            // Comparison by experience
            int experienceComparison = 
                other.WorkExperience.CompareTo(this.WorkExperience); 
            if (experienceComparison != 0)
            {
                return experienceComparison;
            }
            else
            {
                // Comparison by string
                int sCompare = string.Compare(this.Profession, other.Profession, 
                    StringComparison.CurrentCulture);
                return sCompare;
            }
        }

    }
}
