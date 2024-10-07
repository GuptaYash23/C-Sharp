using System;

namespace Properties
{
    public class Student
    {
        private int _StdId;
        private string _Name;
        private string _LName; 
      
        // Read only property
        private int _SubjectTotalMarks = 100; // Now the standard property will be get only as value is already set

        // Write only property
        private string _Address;  // It can't be accessed as there is not get property defined 

        // Autoimplemented property (Here we can't use custom logic for get/set functions)
        // Same name property and variable
        public int RollNo { get; set; }

        // Private set property restricts the members outside this class to set the variable value. Ony class members can do so.
        public string NickName { get; private set;}
        public void setNickName(string NickName)
        {
            this.NickName = NickName;
        }

        public int StdId
        {
            set
            {
                // Custom logic implementation
                if (value <= 0)
                {
                    Console.WriteLine("Student Id cannot be negative");
                }
                else
                {
                    this._StdId = value;
                }
            }

            get
            {
                return this._StdId;
            }
        }

        public string Name
        {
            set
            {
                // Custom logic implementation
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Please enter your name");
                }
                else
                {
                    this._Name = value;
                }
            }

            get
            {
                return this._Name;
            }
        }

        public string LName
        {
            set
            {
                // Custom logic implementation
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Please enter your last name");
                }
                else
                {
                    this._LName = value; 
                }
            }

            get
            {
                return this._LName;
            }
        }

        public int SubjectTotalMarks
        {
            // Read Only
            // Contains only get property as value was predefined
            get
            {
                return this._SubjectTotalMarks;
            }

        }

        public string Address
        {
            // Write Only
            // Contains only set property, we can't acccess this property
            set
            {
                this._Address = value;
            }
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Student s = new Student();
            s.StdId = 23;
            s.Name = "Yash";
            s.LName = "Gupta";
            s.Address = "Delhi";
            s.RollNo = 241;
            // s.SubjectTotalMarks = 150;    // Will throw an error as there is no set property defined
            s.setNickName("Cheems");
           
            Console.WriteLine(s.StdId);
            Console.WriteLine(s.Name);
            Console.WriteLine(s.LName);
            Console.WriteLine(s.SubjectTotalMarks);
            Console.WriteLine(s.RollNo);
            // Console.WriteLine(s.Address);  // Will throw an error as there is no get property defined
            Console.WriteLine(s.NickName);
        }
    }
}
