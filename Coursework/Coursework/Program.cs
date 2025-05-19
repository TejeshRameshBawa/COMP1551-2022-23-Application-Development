using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// namespace named Coursework
namespace Coursework
{
    // enumeration named "RoleType" that defines three values
    public enum RoleType
    {
        Teacher,
        Admin,
        Student
    }
    // class named Person
    class Person
    {
        // private variables that stored in the Person object
        private string name = "";
        private string telephonenumber = "";
        private string email = "";
        private RoleType role = RoleType.Student;

        // public property Name to give access to the Person object
        public string Name
        {
            get { return (name); }
            set { name = value; }
        }
        // public property TelephoneNumber to give access to the Person object
        public string TelephoneNumber
        {
            get { return (telephonenumber); }
            set { telephonenumber = value; }
        }
        // public property Email to give access to the Person object
        public string Email
        {
            get { return (email); }
            set { email = value; }
        }
        // public property RoleType to give access to the Person object
        public RoleType Role
        {
            // property returns the role of the Person object
            get { return (role); }
            // property sets the role of the Person object to possible value in RoleType enumeration
            set { if (((int)value >= (int)RoleType.Teacher) && ((int)value <= (int)RoleType.Student)) { role = value; } }

        }
    }

    // class named Teacher that inherits from the Person class
    class Teacher : Person
    {
        // private variables that stored in the Teacher object
        private string salary = "";
        private string subject1 = "";
        private string subject2 = "";

        // public property Salary to give access to the Teacher object
        public string Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        // public property Subject1 to give access to the Teacher object
        public string Subject1
        {
            get { return subject1; }
            set { subject1 = value; }
        }
        // public property Subject2 to give access to the Teacher object
        public string Subject2
        {
            get { return subject2; }
            set { subject2 = value; }
        }
    }
    // class named Admin that inherits from the Person class
    class Admin : Person
    {
        // private variables that stored in the Admin object
        private string salary = "";
        private string fulltimeparttime = "";
        private string workinghours = "";

        // public property Salary to give access to the Admin object
        public string Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        // public property Fulltime_Parttime to give access to the Admin object
        public string Fulltime_Parttime
        {
            get { return fulltimeparttime; }
            set { fulltimeparttime = value; }
        }
        // public property WorkingHours to give access to the Admin object
        public string WorkingHours
        {
            get { return workinghours; }
            set { workinghours = value; }
        }
    }
    // class named Student that inherits from the Person class
    class Student : Person
    {
        // private variables that stored in the Student object
        private string currentsubject1 = "";
        private string currentsubject2 = "";
        private string previoussubject1 = "";
        private string previoussubject2 = "";

        // public property CurrentSubject1 to give access to the Student object
        public string CurrentSubject1
        {
            get { return currentsubject1; }
            set { currentsubject1 = value; }
        }
        // public property CurrentSubject2 to give access to the Student object
        public string CurrentSubject2
        {
            get { return currentsubject2; }
            set { currentsubject2 = value; }
        }
        // public property PreviousSubject1 to give access to the Student object
        public string PreviousSubject1
        {
            get { return previoussubject1; }
            set { previoussubject1 = value; }
        }
        // public property PreviousSubject2 to give access to the Student object
        public string PreviousSubject2
        {
            get { return previoussubject2; }
            set { previoussubject2 = value; }
        }
    }

    // main program MyClass
    public class MyClass
    {
        public static void Main(string[] args)
        {
            int i = 0;
            int c = 1;
            int r = 0;
            // List of objects
            List<Person> Person = new List<Person>();

            while (c < 6)
            {
                // writes the table for the users to choose their choice
                Console.WriteLine("\n Main Menu \n");
                Console.WriteLine("1. Add new data");
                Console.WriteLine("2. View all existing data");
                Console.WriteLine("3. View existing data by user group");
                Console.WriteLine("4. Edit existing user");
                Console.WriteLine("5. Delete existing user");
                Console.WriteLine("6. Exit");
                c = Convert.ToInt32(Console.ReadLine());
                switch (c)
                {
                    // Adding new data
                    case 1:
                        // writes line
                        Console.WriteLine("\n Adding new record \n");
                        Person newPerson;
                        Console.Write("Enter name: ");
                        // reads line to store data in name
                        string name = Console.ReadLine();
                        Console.Write("Enter telephone number: ");
                        // reads line to store data in telephonenumber
                        string telephoneNumber = Console.ReadLine();
                        Console.Write("Enter email: ");
                        // reads line to store data in email
                        string email = Console.ReadLine();
                        // prompts user to choose the corresponding index
                        Console.Write("Enter a role (0: Teacher, 1: Admin, 2: Student): ");
                        int role = Convert.ToInt32(Console.ReadLine());
                        // after the role is chosen it will switch to the chosen role
                        switch ((RoleType)role)
                        {
                            case RoleType.Teacher:
                                newPerson = new Teacher();
                                Console.Write("Enter salary: ");
                                // reads line to store data in Salary
                                ((Teacher)newPerson).Salary = Console.ReadLine();
                                Console.Write("Enter subject 1: ");
                                // reads line to store data in Subject1
                                ((Teacher)newPerson).Subject1 = Console.ReadLine();
                                Console.Write("Enter subject 2: ");
                                // reads line to store data in Subject2
                                ((Teacher)newPerson).Subject2 = Console.ReadLine();
                                break;
                            case RoleType.Admin:
                                newPerson = new Admin();
                                Console.Write("Enter salary: ");
                                // reads line to store data in Salary
                                ((Admin)newPerson).Salary = Console.ReadLine();
                                Console.Write("Enter full-time/part-time: ");
                                // reads line to store data in Fulltime_Parttime
                                ((Admin)newPerson).Fulltime_Parttime = Console.ReadLine();
                                Console.Write("Enter working hours: ");
                                // reads line to store data in WorkingHours
                                ((Admin)newPerson).WorkingHours = Console.ReadLine();
                                break;
                            case RoleType.Student:
                                newPerson = new Student();
                                Console.Write("Enter current subject 1: ");
                                // reads line to store data in CurrentSubject1
                                ((Student)newPerson).CurrentSubject1 = Console.ReadLine();
                                Console.Write("Enter current subject 2: ");
                                // reads line to store data in CurrentSubject2
                                ((Student)newPerson).CurrentSubject2 = Console.ReadLine();
                                Console.Write("Enter previous subject 1: ");
                                // reads line to store data in PreviousSubject1
                                ((Student)newPerson).PreviousSubject1 = Console.ReadLine();
                                Console.Write("Enter previous subject 2: ");
                                // reads line to store data in PreviousSubject2
                                ((Student)newPerson).PreviousSubject2 = Console.ReadLine();
                                break;
                            default:
                                Console.WriteLine("Invalid role");
                                continue;
                        }
                        // all data is stored in newPerson
                        newPerson.Name = name;
                        newPerson.TelephoneNumber = telephoneNumber;
                        newPerson.Email = email;
                        newPerson.Role = (RoleType)role;
                        // data added from newPerson to Person
                        Person.Add(newPerson);
                        break;
                    // listing all the records
                    case 2:
                        Console.WriteLine("\n Listing all records \n");
                        i = 1;
                        // depending on the roletype it displays the data
                        foreach (Person b in Person)
                        {
                            // displays data for teacher roletype
                            if (b.Role == RoleType.Teacher)
                                Console.WriteLine("{0}. Name:{1} Telephone Number:{2} Email:{3} Role:{4} Salary:{5} Subject1:{6} Subject2:{7}", i, b.Name, b.TelephoneNumber, b.Email, b.Role, ((Teacher)b).Salary, ((Teacher)b).Subject1, ((Teacher)b).Subject2);

                            // displays data for admin roletype
                            if (b.Role == RoleType.Admin)
                                Console.WriteLine("{0}. Name:{1} Telephone Number:{2} Email:{3} Role:{4} Salary:{5} Fulltime/Parttime:{6} Working Hours:{7}", i, b.Name, b.TelephoneNumber, b.Email, b.Role, ((Admin)b).Salary, ((Admin)b).Fulltime_Parttime, ((Admin)b).WorkingHours);

                            // displays data for student roletype
                            if (b.Role == RoleType.Student)
                                Console.WriteLine("{0}. Name:{1} Telephone Number:{2} Email:{3} Role:{4} Current Subject1:{5} Current Subject2:{6} Previous Subject1:{7} Previous Subject2:{8}", i, b.Name, b.TelephoneNumber, b.Email, b.Role, ((Student)b).CurrentSubject1, ((Student)b).CurrentSubject2, ((Student)b).PreviousSubject1, ((Student)b).PreviousSubject2);

                            i = i + 1;
                        }
                        break;
                    // listing records by role
                    case 3:
                        // prompts users to choose the index
                        Console.Write("Enter a role  (0: Teacher, 1: Admin, 2: Student): ");
                        // reads the chosen index
                        r = Convert.ToInt32(Console.ReadLine());
                        // prints the roletype chosen
                        Console.WriteLine("You selected {0}: ", (RoleType)r);
                        i = 1;
                        foreach (Person b in Person)
                        {
                            if (r == (int)b.Role)
                            {
                                // prints data for teacher roletype
                                if (b.Role == RoleType.Teacher)
                                    Console.WriteLine("{0}. Name:{1} Telephone Number:{2} Email:{3} Role:{4} Salary:{5} Subject1:{6} Subject2:{7}", i, b.Name, b.TelephoneNumber, b.Email, b.Role, ((Teacher)b).Salary, ((Teacher)b).Subject1, ((Teacher)b).Subject2);

                                // prints data for admin roletype
                                if (b.Role == RoleType.Admin)
                                    Console.WriteLine("{0}. Name:{1} Telephone Number:{2} Email:{3} Role:{4} Salary:{5} Fulltime/Parttime:{6} Working Hours:{7}", i, b.Name, b.TelephoneNumber, b.Email, b.Role, ((Admin)b).Salary, ((Admin)b).Fulltime_Parttime, ((Admin)b).WorkingHours);

                                // prints data for student roletype
                                if (b.Role == RoleType.Student)
                                    Console.WriteLine("{0}. Name:{1} Telephone Number:{2} Email:{3} Role:{4} Current Subject1:{5} Current Subject2:{6} Previous Subject1:{7} Previous Subject2:{8}", i, b.Name, b.TelephoneNumber, b.Email, b.Role, ((Student)b).CurrentSubject1, ((Student)b).CurrentSubject2, ((Student)b).PreviousSubject1, ((Student)b).PreviousSubject2);

                                i = i + 1;
                            }
                        }
                        break;
                    // editing data by choosing the index 
                    case 4:
                        // choosing index
                        Console.Write("Enter the index of the record you want to edit: ");
                        int index = Convert.ToInt32(Console.ReadLine());
                        if (index >= 1 && index <= Person.Count)
                        {
                            // saves the updated data as existingPerson
                            Person existingPerson = Person[index - 1];
                            // Enter updated data
                            //update for name
                            Console.Write("Enter updated name (or press enter to keep existing value): ");
                            string updatedName = Console.ReadLine();
                            // updates details
                            if (!string.IsNullOrEmpty(updatedName))
                            {
                                existingPerson.Name = updatedName;
                            }
                            //update for telephonenumber
                            Console.Write("Enter updated telephone number (or press enter to keep existing value): ");
                            string updatedTelephoneNumber = Console.ReadLine();
                            // updates details
                            if (!string.IsNullOrEmpty(updatedTelephoneNumber))
                            {
                                existingPerson.TelephoneNumber = updatedTelephoneNumber;
                            }
                            //update for email
                            Console.Write("Enter updated email (or press enter to keep existing value): ");
                            string updatedEmail = Console.ReadLine();
                            // updates details
                            if (!string.IsNullOrEmpty(updatedEmail))
                            {
                                existingPerson.Email = updatedEmail;
                            }

                            // update data depending on teacher roletype
                            if (existingPerson.Role == RoleType.Teacher)
                            {
                                Teacher existingTeacher = (Teacher)Person[index - 1];
                                //update for salary for teacher
                                Console.Write("Enter updated salary (or press enter to keep existing value): ");
                                string updatedSalary = Console.ReadLine();
                                // updates details
                                if (!string.IsNullOrEmpty(updatedSalary))
                                {
                                    existingTeacher.Salary = updatedSalary;
                                }
                                //update for subject1 for teacher
                                Console.Write("Enter updated subject1 (or press enter to keep existing value): ");
                                string updatedSubject1 = Console.ReadLine();
                                // updates details
                                if (!string.IsNullOrEmpty(updatedSubject1))
                                {
                                    existingTeacher.Subject1 = updatedSubject1;
                                }
                                //update for subject2 for teacher
                                Console.Write("Enter updated subject2 (or press enter to keep existing value): ");
                                string updatedSubject2 = Console.ReadLine();
                                // updates details
                                if (!string.IsNullOrEmpty(updatedSubject2))
                                {
                                    existingTeacher.Subject2 = updatedSubject2;
                                }
                            }
                            // update data depending on admin roletype
                            if (existingPerson.Role == RoleType.Admin)
                            {
                                Admin existingAdmin = (Admin)Person[index - 1];
                                //update for salary for admin
                                Console.Write("Enter updated salary (or press enter to keep existing value): ");
                                string updatedSalaryAdmin = Console.ReadLine();
                                // updates details
                                if (!string.IsNullOrEmpty(updatedSalaryAdmin))
                                {
                                    existingAdmin.Salary = updatedSalaryAdmin;
                                }
                                //update for fulltime/parttime for admin
                                Console.Write("Enter updated Fulltime/Part (or press enter to keep existing value): ");
                                string updatedFullPart = Console.ReadLine();
                                // updates details
                                if (!string.IsNullOrEmpty(updatedFullPart))
                                {
                                    existingAdmin.Fulltime_Parttime = updatedFullPart;
                                }
                                //update for workinghours for admin
                                Console.Write("Enter updated Work Hour (or press enter to keep existing value): ");
                                string updatedWorkHour = Console.ReadLine();
                                // updates details
                                if (!string.IsNullOrEmpty(updatedWorkHour))
                                {
                                    existingAdmin.WorkingHours = updatedWorkHour;
                                }
                            }
                            // update data depending on student roletype
                            if (existingPerson.Role == RoleType.Student)
                            {
                                Student existingStudent = (Student)Person[index - 1];
                                //update for currentsubject1 for student
                                Console.Write("Enter updated Current Subject1 (or press enter to keep existing value): ");
                                string updatedCurrentSubject1 = Console.ReadLine();
                                // updates details
                                if (!string.IsNullOrEmpty(updatedCurrentSubject1))
                                {
                                    existingStudent.CurrentSubject1 = updatedCurrentSubject1;
                                }
                                //update for currentsubject2 for student
                                Console.Write("Enter updated Current Subject2 (or press enter to keep existing value): ");
                                string updatedCurrentSubject2 = Console.ReadLine();
                                // updates details
                                if (!string.IsNullOrEmpty(updatedCurrentSubject2))
                                {
                                    existingStudent.CurrentSubject2 = updatedCurrentSubject2;
                                }
                                //update for pervioussubject1 for student
                                Console.Write("Enter updated Previous Subject1 (or press enter to keep existing value): ");
                                string updatedPreviousSubject1 = Console.ReadLine();
                                // updates details
                                if (!string.IsNullOrEmpty(updatedPreviousSubject1))
                                {
                                    existingStudent.PreviousSubject1 = updatedPreviousSubject1;
                                }
                                //update for pervioussubject2 for student
                                Console.Write("Enter updated Previous Subject2 (or press enter to keep existing value): ");
                                string updatedPreviousSubject2 = Console.ReadLine();
                                // updates details
                                if (!string.IsNullOrEmpty(updatedPreviousSubject2))
                                {
                                    existingStudent.PreviousSubject2 = updatedPreviousSubject2;
                                }
                            }
                        }
                        break;
                    // deleting data by choosing index
                    case 5:
                        // prints line
                        Console.WriteLine("\n Deleting a record \n");
                        // choosing the index of the data to delete
                        Console.Write("Enter the index of the record to be deleted: ");
                        // reads the choose index
                        index = Convert.ToInt32(Console.ReadLine()); 
                        if (index >= 1 && index <= Person.Count)
                        {
                            // deletes the data
                            Person.RemoveAt(index - 1);
                            Console.WriteLine("Record deleted successfully!");
                        }
                        else
                        {
                            Console.WriteLine("Invalid index!");
                        }
                        break;

                }
            }
        }
    }
}
